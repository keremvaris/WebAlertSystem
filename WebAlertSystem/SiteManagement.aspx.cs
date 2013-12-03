using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAlertSystem
{
	public partial class SiteManagement : System.Web.UI.Page
	{
		private DateTime StartDate
		{
			get
			{
				DateTime v = DateTime.MinValue;
				DateTime.TryParse(tbStart.Text, out v);
				return v;
			}
			set
			{
				if (value == DateTime.MinValue)
				{
					tbStart.Text = "";
				}
				else
				{
					tbStart.Text = value.ToShortDateString() + " " + value.ToShortTimeString();
				}
			}
		}

		private DateTime EndDate
		{
			get
			{
				DateTime v = DateTime.MinValue;
				DateTime.TryParse(tbEnd.Text, out v);
				return v;
			}
			set
			{
				if (value == DateTime.MinValue)
				{
					tbEnd.Text = "";
				}
				else
				{
					tbEnd.Text = value.ToShortDateString() + " " + value.ToShortTimeString();
				}
			}
		}

		public string Message
		{
			get { return tbMessage.Text; }
			set { tbMessage.Text = value; }
		}
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				if (ACommon.AdminAlertActive)
				{
					StartDate = ACommon.AdminAlertStarts;
					EndDate = ACommon.AdminAlertEnds;
					Message = ACommon.AdminAlertMessage;
				}
				else
				{
					StartDate = DateTime.Now.AddSeconds(-1);
					EndDate = DateTime.Now.AddMinutes(10);
					Message = "Uygulamanız süre sonunda güncellenecek. Lütfen yapmakta olduğunuz işlemleri güncellemeye kadar tamamlayınız.";
				}
				
			}
		}

		protected void btnSend_Click(object sender, EventArgs e)
		{
			ACommon.SetAdminAlert(Message, StartDate, EndDate);
		}

		protected void btnClear_Click(object sender, EventArgs e)
		{
			ACommon.ClearAdminAlert();
		}
	}
}