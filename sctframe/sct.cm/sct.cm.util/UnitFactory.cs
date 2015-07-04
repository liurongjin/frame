using System;
using System.ServiceModel;
using Spring.Context.Support;

namespace sct.cm.util
{ 
    public class UnitFactory
    {
        public static object CreateUnit(String beanId)
        {
            object obj = ContextRegistry.GetContext().GetObject(beanId);
            ICommunicationObject com = obj as ICommunicationObject;
            if ((com != null && com.State == CommunicationState.Faulted) ||
                (com != null && com.State == CommunicationState.Closed))
            {
                if (com.State != CommunicationState.Closed)
                    com.Abort();
                ContextRegistry.Clear();
                obj = ContextRegistry.GetContext().GetObject(beanId);
            }
            return obj;
        }
    }
}
