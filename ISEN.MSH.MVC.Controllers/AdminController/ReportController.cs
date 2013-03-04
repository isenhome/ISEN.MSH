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
            var data = new { d = str.ToString() };
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
