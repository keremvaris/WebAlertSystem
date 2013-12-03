using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WebAlertSystem
{
	public partial class Alerts : System.Web.UI.Page 
	{

		public  void ekle()
		{

			
			if (ACommon.AdminAlertActive)
			{
				Table cx = ApplicationNode.MakeTable(2, 2, true);
				cx.CssClass = "swf";
				cx.Width = Unit.Percentage(100);
				cx.Rows[0].Style.Add("text-align", "center");

				cx.Rows[0].Cells[0].Text = ACommon.AdminAlertMessage;
				cx.Rows[0].Cells[0].Style.Add("color", "crimson");
				cx.Rows[0].Cells[0].Style.Add("font-size", "medium");
				cx.Rows[0].Cells[0].Width = Unit.Percentage(90);
				cx.Rows[0].Cells[0].RowSpan = 2;
				cx.Rows[0].Cells[1].Text = "Süre";
				cx.Rows[1].Cells[1].ID = "deconx";
				cx.Rows[1].Cells[1].Text = ACommon.SecondsToEnd.ToString();
				cx.Rows[1].Cells[1].Style.Add("font-size", "small");
				cx.Rows[1].Cells[1].Style.Add("text-align", "center");
				cx.Rows[1].Cells[1].Style.Add("color", "Navy");
				
				cx.Rows[1].Cells.RemoveAt(0);
				//FScripts.Add("setInterval(descon,1000);");

				Form.Controls.AddAt(0, cx);
				
			}
			else
			{
				// Insert dummy control so that naming of controls do not cause
				// exception when alert is posted and shown after postback
				// (This is required because after postbacks asp.net expects
				// auto named control ids to be same)
				Table cx = new Table();
				cx.Visible = false;
				Form.Controls.AddAt(0, cx);

			}
		}
		protected void Page_Load(object sender, EventArgs e)
		{
			ekle();
		}
			
			
		
	}
}