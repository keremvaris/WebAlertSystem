using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebAlertSystem.Services
{
	/// <summary>
	/// Summary description for SiteSvc
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class SiteSvc : System.Web.Services.WebService
	{
		[WebMethod()]
		public void sisSetAdminAlert(string Message, DateTime Starts, DateTime Ends)
		{
			ACommon.SetAdminAlert(Message, Starts, Ends);
		}

		[WebMethod()]
		public void sisClearAdminAlert()
		{
			ACommon.ClearAdminAlert();
		}
	}
}
