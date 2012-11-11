/*
UI处理
参数:
file:           SWFUpload文件对象
targetid:    父容器标识
*/

function _uploadProgress(targetid) {
    this.targetid = targetid;
    this.allNum = 0;
    this.successNum = 0;
    this.errorNum = 0;

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
    var layoutTr = $("<tr id='" + file.id + "'><td>" + file.name + "</td><td><div class='file_progress' style='height:10px;'></div></td><td class='file_progress_percent'>0%</td><td>" + file.size + "</td><td class='file_state'></td><td><input type='button' class='button' value='' /></td></tr>");
    layoutTr.appendTo(this.layoutTbody);
    this.addAllNum();
    this.progressbarBar(file, 0);
    this.uploadFileState(file, "等待上传");
    this.bindCanel(file);
}

_uploadProgress.prototype.removeFile = function (file) {
    $("#" + file.id).remove();
    this.reducedAllNum();
    if (this.allNum == 0) {
        $("#" + this.targetid).find("table").remove();
        UploadProgress.entity = null;
    }
}

_uploadProgress.prototype.progressbarBar = function (file, percent) {
    $("#" + file.id + " " + "td .file_progress").progressbar({
        value: percent
    });
    $("#" + file.id + " " + ".file_progress_percent").html(percent+"%");
}

_uploadProgress.prototype.uploadFileState = function (file,fileState) {
    $("#" + file.id + " " + ".file_state").html(fileState);
}

_uploadProgress.prototype.bindCanel = function (file) {
    $("#" + file.id + " " + "td .button").unbind("click");
    $("#" + file.id + " " + "td .button").val("取消");
    $("#" + file.id + " " + "td .button").click(function () {
        alert("cancel");
        swfu.cancelUpload(file.id);
        UploadProgress.entity.removeFile(file);
    });
}

_uploadProgress.prototype.bindDelete = function (file) {
    $("#" + file.id + " " + "td .button").unbind("click");
    $("#" + file.id + " " + "td .button").val("删除");
    $("#" + file.id + " " + "td .button").click(function () {
        alert("delete");
    });
}

_uploadProgress.prototype.addAllNum = function () {
    this.allNum = this.allNum + 1;
    $("#fileNumber").html(this.allNum);
}

_uploadProgress.prototype.reducedAllNum = function () {
    this.allNum = this.allNum - 1;
    $("#fileNumber").html(this.allNum);
}

_uploadProgress.prototype.addSuccessNum = function () {
    this.successNum = this.successNum + 1;
    $("#fileSuccess").html(this.successNum);
}

_uploadProgress.prototype.reducedeSuccessNum = function () {
    this.successNum = this.successNum - 1;
    $("#fileSuccess").html(this.successNum);
}

_uploadProgress.prototype.addErrorNum = function () {
    this.errorNum = this.errorNum + 1;
    $("#fileError").html(this.errorNum);
}

_uploadProgress.prototype.reducedErrorNum = function () {
    this.errorNum = this.errorNum - 1;
    $("#fileError").html(this.errorNum);
}

var UploadProgress = {
    getEntity: function (targetid) {

        if ("undefined" == typeof (this.entity) || this.entity == null) {
            this.entity = new _uploadProgress(targetid);
        }
        return this.entity;
    }
};