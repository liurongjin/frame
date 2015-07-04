/******************配置信息*********************************/
/*页面记录条数*/
var pagesize = 6;
/******************配置信息*********************************/

/*******************ajax调用函数，包括json和xml格式*****************************/
/*调用后台操作返回结果 包拓json数据和xml格式数据*/
var InvokeAction = {
    InvokeJsonAction: function (controller, action, param, success, error, isAsync) {
        $.ajax({
            type: "post",
            async: (isAsync == undefined || isAsync == null || isAsync === true),
            url: '/' + controller + '/' + action + '?rdm=' + Math.random(),
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            processData: true,
            dataType: 'json',
            data: param,
            success: function (data) {
                if (data.IsSuccess) {
                    success(data.JsonData);
                } else {
                    if (error)
                        error.apply(this, data);
                    else
                        alert(data.Message);
                    /*
                    layer.alert(data.Message, 8, '提示信息', function (index) {
                        layer.close(index);
                    });
                    */
                    return [];
                }
            },
            error: function () {
                error && error.apply(this, arguments);
            }
        });
    },
    InvokeXmlAction: function (controller, action, param, success, error, isAsync) {
        $.ajax({
            type: "post",
            async: isAsync === true,
            url: controller + '/' + action + '?rdm=' + Math.random(),
            contentType: "application/x-www-form-urlencoded; charset=UTF-8",
            dataType: 'xml',
            processData: true,
            data: param,
            success: function (data) {
                if (data.IsSuccess) {
                    success(data.XmlData);
                } else {
                    alert(data.Message);
                    return [];
                }
            },
            error: function () {
                error && error.apply(this, arguments);
            }
        });
    }
}
/*******************ajax调用函数，包括json和xml格式*****************************/


/*************************日期时间格式******************************/

/*日期格式*/
function FormatDateString(dateStr) {

    if (dateStr != undefined && dateStr != null) {
        var NewDtime = new Date(parseInt(dateStr.replace("/Date(", "").replace(")/", ""), 10));
        var Dyear = NewDtime.getFullYear();
        var Dmonth = NewDtime.getMonth() + 1;
        var Ddate = NewDtime.getDate();
        var dateTime = Dyear + "-" + Dmonth + "-" + Ddate;
        return dateTime;
    } else {
        return "";
    }
}

/*日期时间格式*/
function FormatDateTimeString(dateStr) {
    var NewDtime = new Date(parseInt(dateStr.replace("/Date(", "").replace(")/", ""), 10));
    var Dyear = NewDtime.getFullYear();
    var Dmonth = NewDtime.getMonth() + 1;
    var Ddate = NewDtime.getDate();
    var DHour = NewDtime.getHours();
    var DMinute = NewDtime.getMinutes();
    var DSecond = NewDtime.getSeconds();
    var dateTime = Dyear + "-" + Dmonth + "-" + Ddate + " " + DHour + ":" + DMinute + ":" + DSecond;
    return dateTime;
}
/*************************日期时间格式******************************/

/*************************checkbox操作，全选单选或多选******************************/
/*设置checkbox全选或单选*/
function CheckBoxAllorNull(checknodename, value) {
    if (value) {
        $('input[type=checkbox][name=' + checknodename + ']').each(function () {
            $(this).prop('checked', true);
        });
    }
    else {
        $('input[type=checkbox][name=' + checknodename + ']').each(function () {
            $(this).prop('checked', false);
        });
    }
}
/*判断checkbox是否选中*/
function CheckBoxNeed(checknodename) {
    var selcount = $('input[type=checkbox][name=' + checknodename + ']:checked').length;
    if (selcount > 0) {
        return true;
    }
    else {
        alert('未有选中项，请确认选中一项或多项后再进行操作！');
        return false;
    }
}

/*判断checkbox是否单选*/
function CheckBoxOnly(checknodename) {
    var selcount = $('input[type=checkbox][name=' + checknodename + ']:checked').length;
    if (selcount < 1) {
        alert('未有选中项，请确认选中一项后再进行操作！');
        return false;
    }
    else if (selcount == 1) {
        return true;
    }
    else {
        alert('已选中多项，请确认选中一项后再进行操作！');
        return false;
    }
}
/*************************checkbox操作，全选单选或多选******************************/

/*********************窗口操作函数**********************************/
function winModalFullScreen(strURL, maximum, width, height) {

    var sheight = screen.height - 70;
    var swidth = screen.width - 10;

    if (!maximum) {
        sheight = height;
        swidth = width;
    }
    
    var winoption = "dialogHeight:" + sheight + "px;dialogWidth:" + swidth + "px;status:yes;scroll:yes;resizable:false;center:yes";
    
    var tmp = window.showModalDialog(strURL, window, winoption);

    return tmp;
}

function winOpenFullScreen(strURL, maximum, width, height) {
    var sheight = screen.height - 70;
    var swidth = screen.width - 10;

    if (!maximum) {
        sheight = height;
        swidth = width;
    }
    var winoption = "left=0,top=0,height=" + sheight + ",width=" + swidth + ",toolbar=yes,menubar=yes,location=yes,status=yes,scrollbars=yes,resizable=false";

    var tmp = window.open(strURL, '', winoption);
    return tmp;
}
/*********************窗口操作函数**********************************/


/*********************获取url参数函数**********************************/
function getQueryStringValue(keyName) {
    var searchStr = location.search.substr(1);
    if (searchStr.length == 0)
        return null;
    var collection = searchStr.split('&');
    for (var i = 0; i < collection.length; i++) {
        var tmp = collection[i].split('=');
        if (tmp.length < 2)
            continue;
        if (tmp[0].toUpperCase() == keyName.toUpperCase())
            return tmp[1];
    }
    return null;
}
/*********************获取url参数函数**********************************/