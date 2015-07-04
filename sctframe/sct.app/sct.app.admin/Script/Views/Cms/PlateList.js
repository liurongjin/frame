$(function () {
    /******数据加载函数***************************/
    //翻页事件
    PageClick = function (pageclickednumber) {
        var name = $("#txtQName").val();
        var plateid = $("#drplPlate").val();
         
        param = { name: name, plateid: plateid, pagenumber: pageclickednumber, pagesize: pagesize };

        InvokeAction.InvokeJsonAction('PlateMgr', 'ListPlate', param, function (jsonData) {

            //$("#pager").pager({ pagenumber: pageclickednumber, pagecount: recordPageCount, buttonClickCallback: PageClick, total: jsonData.total });
            $("#pager").pager({ pagenumber: pageclickednumber, pagesize: pagesize, buttonClickCallback: PageClick, total: jsonData.total });
            //绑定数据 
            $("#datalist").empty();
            var htmllist = '';
            htmllist += '<div>';
            if (jsonData != null && jsonData.rows != null && jsonData.rows.length > 0) {
                for (i = 0 ; i < jsonData.rows.length; i++) {
                    if (i % 2 == 0) {
                        htmllist += '<div  class ="listrow">';
                    } else {
                        htmllist += '<div  class ="listseprow">';
                    }
                    htmllist += '<div  class="floatleft"><input type = "checkbox" name ="chkSelect"  value="' + jsonData.rows[i].Id + '" /></div>' +
                                    '<div class="floatleft">' + jsonData.rows[i].Code + '</div>' +
                                    '<div class="floatleft">' + jsonData.rows[i].Name + '</div>' +
                                    '<div class="floatleft">' + jsonData.rows[i].ADType + '</div>' +
                                    '<div class="floatleft">' + jsonData.rows[i].ParentId + '</div>' +
                                    '<div class="floatleft">' + (jsonData.rows[i].SYS_IsValid == 1 ? '启用' : '失效') + '</div>' +
                                    '<div class="floatleft">' + jsonData.rows[i].SYS_OrderSeq + '</div>' +
                                    '<div class="floatleft">' + FormatDateString(jsonData.rows[i].SYS_ModifyTime) + '</div>' +
                               '</div><div style="clear:both;"></div>';
                }
            }
            else {
                htmllist += '<div>data is empty</div>';

            }
            htmllist += '</div>';
            $("#datalist").html(htmllist);
        });
    }
    /******数据加载函数***************************/

    /*******初始化数据*****************/
    /**加载列表数据**/
    PageClick(1);

    /*******初始化数据*****************/


    /*******按钮事件操作********************************/
    $("#btnSearch").click(function () {
        PageClick(1);
    });

    $("#btnAdd").click(function () {
        var retval = winModalFullScreen("PlateForm", false, 800, 600);
        PageClick(1);
    });

    $("#btnModify").click(function () {
        if (CheckBoxOnly("chkSelect")) {
            var checkenodevalue = $(":checkbox[name=chkSelect][checked=checked]").attr("value");
            var retval = winModalFullScreen("PlateForm?key=" + checkenodevalue, false, 800, 600);
            PageClick(1);
        }
    });

    $("#btnValid").click(function () {
        if (CheckBoxOnly("chkSelect")) {
            var checkenodevalue = $(":checkbox[name=chkSelect][checked=checked]").attr("value");
            param = { key: checkenodevalue, validstatus: 1 };
            InvokeAction.InvokeJsonAction('Cms', 'UpdatePlateValid', param, function (jsonData) {
                PageClick(1);
                alert(jsonData);

            });
        }
    });

    $("#btnInvalid").click(function () {
        if (CheckBoxOnly("chkSelect")) {
            var checkenodevalue = $(":checkbox[name=chkSelect][checked=checked]").attr("value");
            param = { key: checkenodevalue, validstatus: 0 };
            InvokeAction.InvokeJsonAction('Cms', 'UpdatePlateValid', param, function (jsonData) {
                PageClick(1);
                alert(jsonData);

            });
        }
    });

    $("#btnRemove").click(function () {

        if (CheckBoxOnly("chkSelect")) {
            if (confirm("确定要删除该信息吗?")) {
                var checkenodevalue = $(":checkbox[name=chkSelect][checked=checked]").attr("value");
                param = { key: checkenodevalue };
                InvokeAction.InvokeJsonAction('Cms', 'DeletePlate', param, function (jsonData) {
                    PageClick(1);
                    alert(jsonData);
                });
            }
        }
    });

    /*列表checkbox全选或全否*/
    $("#chkSelectAllNone").click(function () {
        if ($("#chkSelectAllNone").attr("checked") == 'checked') {
            CheckBoxAllorNull("chkSelect", true);
        }
        else {
            CheckBoxAllorNull("chkSelect", false);
        }

    });
    /*******按钮事件操作********************************/
});