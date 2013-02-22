var gc = {
    ContainerName: "data",
    GetCharts: function (folderName, graphType, containerName) {

        $.post("GetChartsInfo.aspx",
            {
                "folder_name": folderName,
                "graph_type": graphType
            },
            function (res) {

                var resArr = res.split("@");
                switch (graphType) {
                    case "cookie": $("#cookie").html(resArr[0]); break;
                    case "age": case "edu": case "income": case "gender":
                        gc.FillPie(resArr, graphType, containerName);
                        break;
                    case "online_time":
                        gc.FillLine(resArr, graphType, containerName);
                        break;
                    case "online_sites": case "online_browsing_habits": case "click_ad_type":
                        gc.FillBar(resArr, graphType, containerName);
                        break;
                    case "area_distribution":
                        gc.FillArea(resArr, graphType, containerName);
                        break;
                    case "similar_crowd":
                        gc.FillBubble(resArr, graphType, containerName);
                        break;
                    default: break;
                }
            }
        );
    },
    FillGraph: function (myChart, data, graphType, containerName) {
        data = data.replace("[caption]", graphType);
        //alert(graphType);
        myChart.setDataXML(data);
        myChart.render(containerName.replace("#", ""));
    },
    CheckModel: function (data) {
        $("#model").text(data)
    },
    FillBubble: function (resArr, graphType, containerName) {
        var str = "";
        for (var i = 0; i < resArr.length; i++) {
            var tempArr = resArr[i].split("|");
            var categories = [
                                    "<category label='100' x='100' showVerticalLine='1' />" +
                                    "<category label='120' x='120' showVerticalLine='1' />" +
                                    "<category label='140' x='140' showVerticalLine='1'/>" +
                                    "<category label='160' x='160' showVerticalLine='1'/>" +
                                    "<category label='180' x='180' showVerticalLine='1'/>" +
                                    "<category label='200' x='200' showVerticalLine='1'/>",

                                    "<category label='220' x='220' showVerticalLine='1' />" +
                                    "<category label='240' x='240' showVerticalLine='1'/>",


                                    "<category label='260' x='260' showVerticalLine='1'/>" +
                                    "<category label='280' x='280' showVerticalLine='1'/>" +
                                    "<category label='300' x='300' showVerticalLine='1'/>"
                                    ];
            if (tempArr.length > 0) {
                str += "<set x='[x]' y='[y]' z='[z]' name='[label]'/>"
                    .replace("[label]", tempArr[0])
                    .replace("[x]", tempArr[1].replace(/,/g, ""))
                    .replace("[y]", tempArr[2].replace(/,/g, ""))
                    .replace("[z]", tempArr[3].replace(/,/g, ""));
            }
        }
        var data = mBubbleGraph.replace("[data]", str);
        switch (graphType) {
            //case "yule": case "qinzi": data = data.replace("[categories]", categories[0] + categories[1]); break;                    
            default: data = data.replace("[categories]", categories[0] + categories[1] + categories[2]); break;
        }
        gc.CheckModel(data);
        var myChart = new FusionCharts("FusionCharts/Bubble.swf", "Bubble" + Math.random(), "600", "400");
        gc.FillGraph(myChart, data, graphType, containerName);
    },
    FillArea: function (resArr, graphType, containerName) {
        var str = "";
        for (var i = 0; i < resArr.length; i++) {
            var tempArr = resArr[i].split("|");
            var sAreaName = "";
            switch (tempArr[0]) {
                case "黑龙江": sAreaName = "HL"; break;
                case "吉林": sAreaName = "JL"; break;
                case "辽宁": sAreaName = "LN"; break;
                case "北京": sAreaName = "BJ"; break;
                case "天津": sAreaName = "TJ"; break;
                case "河北": sAreaName = "HB"; break;
                case "河南": sAreaName = "HE"; break;
                case "江西": sAreaName = "JX"; break;

                case "内蒙古": sAreaName = "NM"; break;

                case "青海": sAreaName = "QH"; break;
                case "山西": sAreaName = "SX"; break;
                case "山东": sAreaName = "SD"; break;
                case "陕西": sAreaName = "SA"; break;

                case "新疆": sAreaName = "XJ"; break;
                case "西藏": sAreaName = "XZ"; break;
                case "贵州": sAreaName = "GZ"; break;
                case "甘肃": sAreaName = "GS"; break;
                case "宁夏": sAreaName = "NX"; break;

                case "江苏": sAreaName = "JS"; break;
                case "浙江": sAreaName = "ZJ"; break;
                case "安徽": sAreaName = "AH"; break;
                case "上海": sAreaName = "SH"; break;

                case "湖北": sAreaName = "HU"; break;
                case "湖南": sAreaName = "HN"; break;
                case "广东": sAreaName = "GD"; break;
                case "福建": sAreaName = "FJ"; break;
                case "重庆": sAreaName = "CQ"; break;
                case "广西": sAreaName = "GX"; break;
                case "云南": sAreaName = "YN"; break;
                case "四川": sAreaName = "SC"; break;
                case "海南": sAreaName = "HA"; break;

                case "香港": sAreaName = "HK"; break;
                case "澳门": sAreaName = "MA"; break;
                case "台湾": sAreaName = "TA"; break;
            }
            if (tempArr.length > 0) {
                str += "<entity id='CN.[sAreaName]' displayValue='[AreaName]' value='[value]' toolText='[dValue]'  />"
                    .replace("[sAreaName]", sAreaName)
                    .replace("[AreaName]", tempArr[0])
                    .replace("[value]", tempArr[1].replace(/,/g, ""))
                    .replace("[dValue]", tempArr[0] + " , " + tempArr[1]);
            }
        }
        var data = mAreaGraph.replace("[data]", str);
        alert(data);
        var myChart = new FusionMaps('FusionMaps/FCMap_China2.swf', "Map" + Math.random(), "600", "400", "0", "0");
        gc.FillGraph(myChart, data, graphType, containerName);
    },
    FillBar: function (resArr, graphType, containerName) {
        var str = "";
        for (var i = 0; i < resArr.length; i++) {
            var tempArr = resArr[i].split("|");
            if (tempArr.length > 0) {
                str += "<set value='[value]' showValue='0' label='[label]'/>"
                    .replace("[value]", tempArr[1].replace("%", ""))
                //.replace("[dValue]", tempArr[0])
                    .replace("[label]", tempArr[0]);
            }
        }
        var data = mLineGraph.replace("[data]", str);
        var myChart = new FusionCharts("FusionCharts/Column2D.swf", "Bar" + Math.random(), "600", "400");
        gc.FillGraph(myChart, data, graphType, containerName);
    },
    FillLine: function (resArr, graphType, containerName) {
        var str = "";
        for (var i = 0; i < resArr.length; i++) {
            var tempArr = resArr[i].split("|");
            if (tempArr.length > 0) {
                str += "<set value='[value]'  showValue='0' displayValue='[dValue]' label='[label]'/>"
                    .replace("[value]", tempArr[1].replace("%", ""))
                    .replace("[dValue]", tempArr[1])
                    .replace("[label]", tempArr[0]);
            }
        }
        var data = mLineGraph.replace("[data]", str);
        var myChart = new FusionCharts("FusionCharts/Line.swf", "Line" + Math.random(), "600", "400");
        gc.FillGraph(myChart, data, graphType, containerName);
    },
    FillPie: function (resArr, graphType, containerName) {
        var str = "";
        var itemCount = 0;
        for (var i = 0; i < resArr.length; i++) {
            var tempArr = resArr[i].split("|");
            if (tempArr.length > 0) {
                if (parseInt(tempArr[1].replace("%", "")) < 1) { continue; }
                str += "<set value='[value]' displayValue='[dValue]' label='[label]'/>"
                    .replace("[value]", tempArr[1].replace("%", ""))
                    .replace("[dValue]", tempArr[0])
                    .replace("[label]", tempArr[0]);
            }
            itemCount++;
        }
        var data = mPieGraph.replace("[data]", str);

        var width = "350";
        if (itemCount < 3) {
            width = "210";
            $("#" + containerName).css({ "margin-left": "70px", "width": "280px" });
        } else {
            $("#" + containerName).css({ "margin-left": "0px", "width": "350px" });
        }
        var myChart = new FusionCharts("FusionCharts/Pie2D.swf", "Pie" + Math.random(), width, "400");
        gc.FillGraph(myChart, data, graphType, containerName);
    }
}



var mPieGraph = '<graph showValues="1" borderColor="f4f2f2" canvasBgAlpha="100" caption="[caption]" bgAlpha="100" bgColor="f4f2f2"  borderAlpha="100" showBorder="1"   numberSuffix="%25" legendPosition="right" radius3D="100"  showlabels="0" showpercentvalues="1" enableSmartLabels="1" legendBorderColor="e4e4e4"  showLegend="1" baseFontSize="12">' +
                        '[data]' +
		    		  '</graph>';
// 
var mLineGraph = '<graph showValues="1" caption="[caption]" ' +
                        ' borderColor="f0eeee"  canvasBorderColor="cccccc" lineThickness="2" anchorRadius="2" anchorBorderThickness="3" divLineAlpha="0" plotGradientColor="000000" plotBorderAlpha="0" bgColor="f4f2f2" anchorBgAlpha="0" canvasBgColor="#ffffff"  bgAlpha="100" canvasBorderThickness="0" canvasBgAlpha="0" borderAlpha="100" ' +
                        ' showBorder="1"  numberSuffix="%25" baseFontSize="12" enableRotation="1" showLabels="1" showLegend="1" enableSmartLabels="1"   >' +
//                                  '<set value="13500" label="2009" color="#4693CF"/>' +
//		                            '<set value="5000" color="#1C4EA0"/>' +
//		                            '<set value="34510" label="2010" color="#155B9F" />' +
//		                            '<set value="23420" label="测试" color="#7CBCDB"/>' +
//		                            '<set value="1145" label="2012" color="#4457A4"/>' +
                        '[data]' +
		    			'</graph>';
//canvasBorderColor='cccccc' canvasBorderThickness='1' 
var mAreaGraph = "<map showShadow='0' showBevel='0' fillColor='#ffffff' " +
          ' borderColor="f0eeee"  caption="[caption]" bgAlpha="100" canvasBorderAlpha="0" bgColor="f4f2f2"  borderAlpha="0" showBorder="1" ' +
          "baseFont='Verdana' baseFontColor='ffffff' baseFontSize='12' useHoverColor='1' hoverColor='77C6E6' " +
          "showCanvasBorder='0' showLabels='0' showToolTip='1' showLegend='1' legendCaption='UV' legendBgColor='63707D' legendPosition='RIGHT' " +
          " legendPadding='50'  toolTipBgColor='4799D4' > " +
  "<colorRange> " +
    "<color minValue='0' maxValue='500000' displayValue='0-500K' color='dddddd' /> " +
    "<color minValue='500000' maxValue='1000000' displayValue='500K-1000K' color='FF0000' /> " +
    "<color minValue='1000001' maxValue='5000000' displayValue='1000K-5000K' color='E7AB43' /> " +
    "<color minValue='5000001' maxValue='10000000' displayValue='5000K-10000K' color='3CA61A' /> " +
    "<color minValue='10000001' maxValue='15000000' displayValue='10000K-15000K' color='FEF9CD' /> " +
    "<color minValue='15000001' maxValue='20000000' displayValue='15000K-20000K' color='22559F' /> " +
    "<color minValue='20000001' maxValue='25000000' displayValue='20000K-25000K' color='3399FF' /> " +
    "<color minValue='25000001' maxValue='10000000000' displayValue='25000K以上' color='3399FF' /> " +
  "</colorRange> " +
  "<data> " +
    "[data]" +
  "</data> " +
"</map> ";

//25,000,000以上
//20,000,000-25,000,000
//15,000,000-20,000,000
//10,000,000-15,000,000
//5,000,000-10,000,000
//1,000,000-5,000,000
//500,000-1,000,000
//500,000以下

var mBubbleGraph = "<chart palette='3' canvasBorderColor='cccccc' canvasBorderThickness='0' xAxisName='Index' yAxisName='Daily Impressions' is3D='0' " +
                                ' borderColor="f0eeee"  canvasBorderColor="cccccc" lineThickness="2" anchorRadius="2" anchorBorderThickness="3" divLineAlpha="0" plotGradientColor="000000" plotBorderAlpha="0" anchorBgAlpha="0" canvasBgColor="#ffffff"  bgAlpha="100" canvasBorderThickness="0" canvasBgAlpha="0" borderAlpha="100"' +
                                ' caption="[caption]" bgAlpha="100" bgColor="f4f2f2"  borderAlpha="100" ' +
                                " animation='1' clipBubbles='1' xAxisMinValue='100' showPlotBorder='0'>" +
                                "<categories>" +
                                   "[categories]" +
                                "</categories>" +
                                "<dataSet showValues='1'>" +
                                    "[data]" +
//                                   "<set x='146' y='324094059' z='26136618' color='00000'  name='Traders'/>"+
//                                   "<set x='255' y='165133543' z='12702580' name='Farmers'/>"+
//                                   "<set x='210' y='503641448' z='40291316' name='Individuals'/>"+
//                                   "<set x='196' y='292188335' z='23001444' name='Medium Business Houses'/>"+
//                                   "<set x='268' y='577245752' z='44747733' name='Corporate Group A'/>"+
//                                   "<set x='157' y='62466699' z='4732326' name='Corporate Group C'/>"+
//                                   "<set x='126' y='1024618526' z='79427793' name='HNW Individuals'/>"+
                                "</dataSet>" +
                            "</chart>";

