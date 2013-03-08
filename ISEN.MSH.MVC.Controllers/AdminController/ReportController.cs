using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ISEN.MSH.MVC.Controllers.Filters;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    [UserActionFilter]
    public class ReportController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            StringBuilder str = new StringBuilder();
            str.Append("<graph caption='每月销售额柱形图' xAxisName='月份' yAxisName='Units' showNames='1' decimalPrecision='0' formatNumberScale='0'>");
            str.Append("<set name='一月' value='462' color='AFD8F8' />");
            str.Append("<set name='二月' value='857' color='F6BD0F' />");
            str.Append("<set name='三月' value='671' color='8BBA00' />");
            str.Append("<set name='四月' value='494' color='FF8E46' />");
            str.Append("<set name='五月' value='761' color='008E8E' />");
            str.Append("<set name='六月' value='960' color='D64646' />");
            str.Append("<set name='七月' value='629' color='8E468E' />");
            str.Append("<set name='八月' value='622' color='588526' />");
            str.Append("<set name='九月' value='376' color='B3AA00' />");
            str.Append("<set name='十月' value='494' color='008ED6' />");
            str.Append("<set name='十一月' value='761' color='9D080D' />");
            str.Append("<set name='十二月' value='960' color='A186BE' />");
            str.Append("</graph>");
            var data = new { d = str.ToString() };
            return Json(data);
        }
        public JsonResult GetMapData()
        {
            StringBuilder str = new StringBuilder();
            str.Append("<map animation='0' showShadow='0' showBevel='0' showLabels='0' showMarkerLabels='1' fillColor='F1f1f1'borderColor='CCCCCC' baseFont='Verdana' baseFontSize='10' markerBorderColor='000000' markerBgColor='FF5904'markerRadius='6' legendPosition='bottom' useHoverColor='0' showToolTip='0' showMarkerToolTip='1' >");
            str.Append(" <data>");
            str.Append("  <entity id='NA' />");
            str.Append("  <entity id='SA' />");
            str.Append("  <entity id='EU' />");
            str.Append(" <entity id='AS' />");
            str.Append("  <entity id='AF' />");
            str.Append("   <entity id='AU' />");
            str.Append("</data>");
            str.Append("<markers>");
            str.Append("<definition>");
            str.Append(" <marker id='CA' x='116.65' y='94.85' label='Sales Office' labelPos='top'/>");
            str.Append("<marker id='US' x='131.57' y='133.22' label='Headquarters' labelPos='bottom'/>");
            str.Append("<marker id='CN' x='532.3' y='150.68' label='Call Center' labelPos='bottom'/>");
            str.Append("<marker id='BR' x='228.55' y='276.03' label='Production Center' labelPos='bottom'/>");
            str.Append("<marker id='AU' x='621.83' y='311.21' label='Q & A' labelPos='bottom'/>");
            str.Append("<marker id='RU' x='532.3' y='76.73' label='Back Office' labelPos='bottom'/>");
            str.Append("<marker id='IN' x='499.26' y='202.5' label='Accounts' labelPos='bottom'/>");
            str.Append("</definition>");
            str.Append("<shapes>");
            str.Append("<shape id='USMap' type='image' url='Resources/us_flag.jpg' labelPadding='12' />");
            str.Append("<shape id='CAMap' type='image' url='Resources/canada_flag.jpg' labelPadding='12' />");
            str.Append("<shape id='CNMap' type='image' url='Resources/china_flag.jpg' labelPadding='12' />");
            str.Append("<shape id='BRMap' type='image' url='Resources/brazil_flag.jpg' labelPadding='12' />");
            str.Append("<shape id='AUMap' type='image' url='Resources/aus_flag.jpg' labelPadding='12' />");
            str.Append("    <shape id='RUMap' type='image' url='Resources/rus_flag.jpg' labelPadding='12' />");
            str.Append("       <shape id='INMap' type='image' url='Resources/ind_flag.jpg' labelPadding='12' />");
            str.Append("    </shapes>");
            str.Append("     <application>");
            str.Append("       <marker id='CA' shapeId='CAMap' toolText='Canada&lt;BR&gt;2 Managers&lt;BR&gt;11 Staff'/>");
            str.Append("        <marker id='US' shapeId='USMap' toolText='United States&lt;BR&gt;CEO, CFO, 3 Managers&lt;BR&gt;26 Staff'/>");
            str.Append("      <marker id='CN' shapeId='CNMap' toolText='China&lt;BR&gt;1 Manager&lt;BR&gt;7 Support Staff'/>");
            str.Append("         <marker id='BR' shapeId='BRMap' toolText='Brazil&lt;BR&gt;COO, 2 Managers&lt;BR&gt;32 Factory Staff'/>");
            str.Append("   <marker id='AU' shapeId='AUMap' toolText='Australia&lt;BR&gt;1 Manager&lt;BR&gt;(Outsourced Agency)'/>");
            str.Append("         <marker id='RU' shapeId='RUMap' toolText='Russia&lt;BR&gt;1 Manager&lt;BR&gt;6 Staff'/>");
            str.Append("        <marker id='IN' shapeId='INMap' toolText='India&lt;BR&gt;1 Manager&lt;BR&gt;5 Accountants'/>");
            str.Append("      </application>");
            str.Append("   </markers>");
            str.Append("   <styles>");
            str.Append("      <definition>");
            str.Append("         <style name='TTipFont' type='font' isHTML='1' color='FFFFFF' bgColor='666666' size='11'/>");
            str.Append("         <style name='HTMLFont' type='font' color='333333' borderColor='CCCCCC' bgColor='FFFFFF'/>");
            str.Append("         <style name='myShadow' type='Shadow' distance='1'/>");
            str.Append("      </definition>");
            str.Append("      <application>");
            str.Append("         <apply toObject='MARKERS' styles='myShadow' />");
            str.Append("         <apply toObject='MARKERLABELS' styles='HTMLFont,myShadow' />");
            str.Append("         <apply toObject='TOOLTIP' styles='TTipFont' />");
            str.Append("      </application>");
            str.Append("   </styles>");
            str.Append("</map>");
            string aa = "<map showShadow=\'0\' baseFont=\'微软雅黑\' baseFontColor=\'555555\' legendBgColor=\'ffffff\' showBevel=\'0\' fillColor=\'#ffffff\'  borderColor=\"ffffff\"  caption=\"地域分布\" bgAlpha=\"100\" canvasBorderAlpha=\"0\" bgColor=\"ffffff\"  borderAlpha=\"0\" showBorder=\"1\" baseFont=\'Verdana\' baseFontColor=\'ffffff\' baseFontSize=\'12\' useHoverColor=\'1\' hoverColor=\'77C6E6\' showCanvasBorder=\'0\' showLabels=\'0\' showToolTip=\'1\' showLegend=\'1\' legendShadow=\'0\' legendCaption=\'UV\' legendBorderColor=\'ffffff\' legendBgColor=\'63707D\' legendPosition=\'RIGHT\'  legendPadding=\'50\'  toolTipBgColor=\'4799D4\' ><colorRange> <color minValue=\'0\' maxValue=\'0\' displayValue=\'0-500K\' color=\'b2df22\' /> <color minValue=\'500000\' maxValue=\'1000000\' displayValue=\'500K-1000K\' color=\'fbeb00\' /> <color minValue=\'1000001\' maxValue=\'5000000\' displayValue=\'1000K-5000K\' color=\'fba800\' /> <color minValue=\'5000001\' maxValue=\'10000000\' displayValue=\'5000K-10000K\' color=\'fe6d00\' /> <color minValue=\'10000001\' maxValue=\'15000000\' displayValue=\'10000K-15000K\' color=\'8a8a8a\' /> <color minValue=\'15000001\' maxValue=\'20000000\' displayValue=\'15000K-20000K\' color=\'bcbcbc\' /> <color minValue=\'20000001\' maxValue=\'25000000\' displayValue=\'20000K-25000K\' color=\'dddddd\' /> <color minValue=\'25000001\' maxValue=\'10000000000\' displayValue=\'25000K以上\' color=\'22a7e0\' /> </colorRange> <data><entity id=\'CN.GD\' displayValue=\'广东\' value=\'0\' toolText=\'广东 , 14,185,084\'  /><entity id=\'CN.JS\' displayValue=\'江苏\' value=\'9076307\' toolText=\'江苏 , 9,076,307\'  /><entity id=\'CN.BJ\' displayValue=\'北京\' value=\'8318845\' toolText=\'北京 , 8,318,845\'  /><entity id=\'CN.ZJ\' displayValue=\'浙江\' value=\'7964262\' toolText=\'浙江 , 7,964,262\'  /><entity id=\'CN.SD\' displayValue=\'山东\' value=\'7920932\' toolText=\'山东 , 7,920,932\'  /><entity id=\'CN.SH\' displayValue=\'上海\' value=\'7897355\' toolText=\'上海 , 7,897,355\'  /><entity id=\'CN.HB\' displayValue=\'河北\' value=\'7456751\' toolText=\'河北 , 7,456,751\'  /><entity id=\'CN.\' displayValue=\'其他\' value=\'4919868\' toolText=\'其他 , 4,919,868\'  /><entity id=\'CN.HU\' displayValue=\'湖北\' value=\'4917956\' toolText=\'湖北 , 4,917,956\'  /><entity id=\'CN.HE\' displayValue=\'河南\' value=\'4680163\' toolText=\'河南 , 4,680,163\'  /><entity id=\'CN.TJ\' displayValue=\'天津\' value=\'4426397\' toolText=\'天津 , 4,426,397\'  /><entity id=\'CN.SA\' displayValue=\'陕西\' value=\'4324035\' toolText=\'陕西 , 4,324,035\'  /><entity id=\'CN.LN\' displayValue=\'辽宁\' value=\'4276921\' toolText=\'辽宁 , 4,276,921\'  /><entity id=\'CN.SX\' displayValue=\'山西\' value=\'4072345\' toolText=\'山西 , 4,072,345\'  /><entity id=\'CN.FJ\' displayValue=\'福建\' value=\'4022345\' toolText=\'福建 , 4,022,345\'  /><entity id=\'CN.HN\' displayValue=\'湖南\' value=\'3552023\' toolText=\'湖南 , 3,552,023\'  /><entity id=\'CN.SC\' displayValue=\'四川\' value=\'3438002\' toolText=\'四川 , 3,438,002\'  /><entity id=\'CN.AH\' displayValue=\'安徽\' value=\'3043343\' toolText=\'安徽 , 3,043,343\'  /><entity id=\'CN.GX\' displayValue=\'广西\' value=\'2794423\' toolText=\'广西 , 2,794,423\'  /><entity id=\'CN.CQ\' displayValue=\'重庆\' value=\'2668524\' toolText=\'重庆 , 2,668,524\'  /><entity id=\'CN.JX\' displayValue=\'江西\' value=\'2290293\' toolText=\'江西 , 2,290,293\'  /><entity id=\'CN.HL\' displayValue=\'黑龙江\' value=\'2343833\' toolText=\'黑龙江 , 2,343,833\'  /><entity id=\'CN.JL\' displayValue=\'吉林\' value=\'2203649\' toolText=\'吉林 , 2,203,649\'  /><entity id=\'CN.YN\' displayValue=\'云南\' value=\'1439536\' toolText=\'云南 , 1,439,536\'  /><entity id=\'CN.NM\' displayValue=\'内蒙古\' value=\'1366769\' toolText=\'内蒙古 , 1,366,769\'  /><entity id=\'CN.GZ\' displayValue=\'贵州\' value=\'1078431\' toolText=\'贵州 , 1,078,431\'  /><entity id=\'CN.GS\' displayValue=\'甘肃\' value=\'965889\' toolText=\'甘肃 , 965,889\'  /><entity id=\'CN.XJ\' displayValue=\'新疆\' value=\'917898\' toolText=\'新疆 , 917,898\'  /><entity id=\'CN.HA\' displayValue=\'海南\' value=\'670115\' toolText=\'海南 , 670,115\'  /><entity id=\'CN.NX\' displayValue=\'宁夏\' value=\'358744\' toolText=\'宁夏 , 358,744\'  /><entity id=\'CN.QH\' displayValue=\'青海\' value=\'294969\' toolText=\'青海 , 294,969\'  /><entity id=\'CN.TA\' displayValue=\'台湾\' value=\'288874\' toolText=\'台湾 , 288,874\'  /><entity id=\'CN.HK\' displayValue=\'香港\' value=\'255979\' toolText=\'香港 , 255,979\'  /><entity id=\'CN.XZ\' displayValue=\'西藏\' value=\'45252\' toolText=\'西藏 , 45,252\'  /><entity id=\'CN.MA\' displayValue=\'澳门\' value=\'29330\' toolText=\'澳门 , 29,330\'  /></data></map>";
            var data = new { d = aa };
            return Json(data);
        }

        public ActionResult Flot()
        {
            return View();
        }

        public JsonResult GetFlotData()
        {
            StringBuilder str = new StringBuilder();
            str.Append("");
            var data = new { };
            return Json(data);
        }

        public ActionResult CompareJson()
        {
            return View();
        }
    }
}
