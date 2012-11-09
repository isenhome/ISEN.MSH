/*
UI处理
参数:
file:           SWFUpload文件对象
targetid:    父容器标识
*/

function _uploadProgress(targetid) {
    this.layoutTable = $("<table></table>");
    this.layoutThead = $("<thead><tr><th>文件名</th><th>进度</th><th>百分比</th><th>文件大小</th><th>状态</th><th>操作</th></tr></thead>");
    this.layoutTfoot = $("<tr><td colspan='6'><span id='fileNumber'>0</span>篇文档等待上传，上传成功：<span id='fileSuccess'>0</span>份，上传失败：<span id='fileError'>0</span>份</td></tr>");
    this.layoutTbody = $("<tbody></tbody>")
    this.layoutThead.appendto(this.layoutTable);
    this.layoutTfoot.appendto(this.layoutTable);
    this.layoutTbody.appendto(this.layoutTable);
    var fileNumber = 0;
    var fileSuccess = 0;
    var fileError = 0;
    var targetid = targetid;
    this.layoutTable.appendto($("#" + targetid));
}

_uploadProgress.prototype.setFileNumber = function (num) {
    this.fileNumber = num;
    $("#fileNumber").innerHTML(this.fileNumber);
}

_uploadProgress.prototype.add = function (file) {
    //定义文件处理标识
    this.ProgressId = file.id;
    var layoutTr = $("<tr id='" + file.id + "'><td>" + file.name + "</td><td></td><td>100%</td><td>10M</td><td>上传成功</td><td><input type='button' class='button' value='删除' /></td></tr>");


    //获取当前容器对象
    this.fileProgressElement = document.getElementById(file.id);

    if (!this.fileProgressElement) {
        //container
        this.fileProgressElement = document.createElement("div");
        this.fileProgressElement.id = file.id;
        this.fileProgressElement.className = swfu.settings.custom_settings.container_css;
        //Download by http://www.codefans.net
        //state button
        this.stateButton = document.createElement("input");
        this.stateButton.type = "button";
        this.stateButton.className = swfu.settings.custom_settings.icoWaiting_css;
        this.fileProgressElement.appendChild(this.stateButton);

        //filename
        this.filenameSpan = document.createElement("span");
        this.filenameSpan.className = swfu.settings.custom_settings.fname_css;
        this.filenameSpan.appendChild(document.createTextNode(file.name));
        this.fileProgressElement.appendChild(this.filenameSpan);

        //statebar div
        this.stateDiv = document.createElement("div");
        this.stateDiv.className = swfu.settings.custom_settings.state_div_css;
        this.stateBar = document.createElement("div");
        this.stateBar.className = swfu.settings.custom_settings.state_bar_css;
        this.stateBar.innerHTML = "&nbsp;";
        this.stateBar.style.width = "0%";
        this.stateDiv.appendChild(this.stateBar);
        this.fileProgressElement.appendChild(this.stateDiv);

        //span percent
        this.percentSpan = document.createElement("span");
        this.percentSpan.className = swfu.settings.custom_settings.percent_css;
        this.percentSpan.style.marginTop = "10px";
        this.percentSpan.innerHTML = "(等待上传中...)";
        this.fileProgressElement.appendChild(this.percentSpan);

        //delete href
        this.hrefSpan = document.createElement("span");
        this.hrefSpan.className = swfu.settings.custom_settings.href_delete_css;
        this.hrefControl = document.createElement("a");
        this.hrefControl.innerHTML = "删除";
        this.hrefControl.onclick = function () {
            swfu.cancelUpload(file.id);
        }
        this.hrefSpan.appendChild(this.hrefControl);
        this.fileProgressElement.appendChild(this.hrefSpan);

    }
    else {
        this.reset();
    }
}

//恢复默认设置
_uploadProgress.prototype.reset = function () {
    this.stateButton = this.fileProgressElement.childNodes[0];
    this.fileSpan = this.fileProgressElement.childNodes[1];
    this.stateDiv = this.fileProgressElement.childNodes[2];
    this.stateBar = this.stateDiv.childNodes[0];
    this.percentSpan = this.fileProgressElement.childNodes[3];
    this.hrefSpan = this.fileProgressElement.childNodes[4];
    this.hrefControl = this.hrefSpan.childNodes[0];
}

/*
设置状态按钮状态
state:        当前状态,1:初始化完成,2:正在等待,3:正在上传
settings:    swfupload.settings对象
*/
_uploadProgress.prototype.setUploadState = function (state, settings) {
    switch (state) {
        case 1:
            //初始化完成
            this.stateButton.className = settings.custom_settings.icoNormal_css;
            break;
        case 2:
            //正在等待
            this.stateButton.className = settings.custom_settings.icoWaiting_css;
            break;
        case 3:
            //正在上传
            this.stateButton.className = settings.custom_settings.icoUpload_css;
    }
}

/*
设置上传进度
percent:     已上传百分比
*/
_uploadProgress.prototype.setProgress = function (percent) {
    this.stateBar.style.width = percent + "%";
    this.percentSpan.innerHTML = percent + "%";
    //this.stateButton.className = swfu.settings.custom_settings.icoUpload_css;
    if (percent == 100) {
        this.hrefSpan.style.display = "none";
        //this.stateButton.className = swfu.settings.custom_settings.icoNormal_css;
    }
}

/*
上传完成
*/
_uploadProgress.prototype.setComplete = function (settings) {
    this.stateButton.className = settings.custom_settings.icoNormal_css;
    this.hrefSpan.style.display = "none";
}

/*
控制上传进度对象是否显示
*/
_uploadProgress.prototype.setShow = function (show) {
    this.fileProgressElement.style.display = show ? "" : "none";
}

var UploadProgress = {
    getEntity: function (targetid) {

        if ("undefined" == typeof (this.entity) || this.entity == null) {
            this.entity = new _uploadProgress(targetid);
        }
        return this.entity;
    }
};