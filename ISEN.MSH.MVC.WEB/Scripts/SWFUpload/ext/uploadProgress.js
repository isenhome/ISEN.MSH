/*
UI处理
参数:
file:           SWFUpload文件对象
targetid:    父容器标识
*/

function _uploadProgress(targetid) {
    this.targetid = targetid;

    this.layoutTable = $("<table></table>");
    this.layoutThead = $("<thead><tr><th>文件名</th><th>进度</th><th>百分比</th><th>文件大小</th><th>状态</th><th>操作</th></tr></thead>");
    this.layoutTfoot = $("<tfoot><tr><td colspan='6'><span id='fileNumber'>0</span>篇文档等待上传，上传成功：<span id='fileSuccess'>0</span>份，上传失败：<span id='fileError'>0</span>份</td></tr></tfoot>");
    this.layoutTbody = $("<tbody></tbody>")
    this.layoutThead.appendTo(this.layoutTable);
    this.layoutTfoot.appendTo(this.layoutTable);
    this.layoutTbody.appendTo(this.layoutTable);
    this.layoutTable.appendTo($("#" + targetid));
    $("#" + this.targetid + " " + "table tfoot span").css("font-weight", "700");
    $("#" + this.targetid + " " + "table tfoot span").css("color", "#57a000");
}

_uploadProgress.prototype.addFile = function (file) {
    //定义文件处理标识
    var layoutTr = $("<tr id='" + file.id + "'><td style='width:25%'>" + file.name + "</td><td  style='width:25%'><div class='file_progress' style='height:10px;'></div></td><td  style='width:10%' class='file_progress_percent'>0%</td><td style='width:15%'>" + file.size + "</td><td class='file_state' style='width:15%'></td><td  style='width:10%'><input type='button' value='' /></td></tr>");
    layoutTr.appendTo(this.layoutTbody);
    this.progressbarBar(file, 0);
    this.uploadFileState(file, "等待上传");
    this.bindCanel(file);
}

_uploadProgress.prototype.removeFile = function (file) {
    $("#" + file.id).remove();
    UploadProgress.entity.checkVisable();
}

_uploadProgress.prototype.progressbarBar = function (file, percent) {
    $("#" + file.id + " " + "td .file_progress").progressbar({
        value: percent
    });
    $("#" + file.id + " " + ".file_progress_percent").html(percent + "%");
}

_uploadProgress.prototype.uploadFileState = function (file, fileState) {
    $("#" + file.id + " " + ".file_state").html(fileState);
}

_uploadProgress.prototype.bindCanel = function (file) {
    $("#" + file.id + " " + "td input").unbind("click");
    $("#" + file.id + " " + "td input").val("取消");
    $("#" + file.id + " " + "td input").click(function () {
        swfu.cancelUpload(file.id);
        UploadProgress.entity.removeFile(file);
    });
}

_uploadProgress.prototype.bindDelete = function (file) {
    $("#" + file.id + " " + "td input").unbind("click");
    $("#" + file.id + " " + "td input").addClass("button");
    $("#" + file.id + " " + "td input").val("删除");
    $("#" + file.id + " " + "td input").click(function () {
        var jData = { fileID: file.id, fileName: file.name };
        $.ajax({
            url: swfu.settings.custom_settings.deleteAction,
            data: jData,
            type: "GET",
            success: function (data, textStatus, jqXHR) {
                var status = swfu.getStats();
                status.successful_uploads--;
                swfu.setStats(status);
                UploadProgress.entity.setStatus();
                UploadProgress.entity.removeFile(file);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert("error");
            }
        });
    });
}
_uploadProgress.prototype.setStatus = function () {
    $("#fileNumber").html(swfu.getStats().files_queued);
    $("#fileSuccess").html(swfu.getStats().successful_uploads);
    $("#fileError").html(swfu.getStats().upload_errors);
   
}

_uploadProgress.prototype.checkVisable = function () {
    if ($("#" + this.targetid+" "+"table tbody").find("tr").length == 0) {
        $("#" + this.targetid).find("table").remove();
        UploadProgress.entity = null;
    }
}

var UploadProgress = {
    getEntity: function (targetid) {

        if ("undefined" == typeof (this.entity) || this.entity == null) {
            this.entity = new _uploadProgress(targetid);
        }
        return this.entity;
    }
};