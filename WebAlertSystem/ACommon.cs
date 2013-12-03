using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAlertSystem
{
	public class ACommon
	{		
		// The following is used for admin alerts
		public static string AdminAlertMessage;
		public static DateTime AdminAlertStarts;

		public static DateTime AdminAlertEnds;
		public static bool AdminAlertActive
		{
			get { return DateTime.Now > AdminAlertStarts && DateTime.Now < AdminAlertEnds; }
		}

		public static bool ByPassCidValid = false;

		public static long SecondsToEnd
		{
			get
			{
				if (AdminAlertActive)
				{
					return (long)Math.Floor((AdminAlertEnds - DateTime.Now).TotalSeconds);
				}
				else
				{
					return 0;
				}
			}
		}

		public static void SetAdminAlert(string Message, DateTime Starts, DateTime Ends)
		{
			AdminAlertMessage = Message;
			AdminAlertStarts = Starts;
			AdminAlertEnds = Ends;
		}

		public static void ClearAdminAlert()
		{
			AdminAlertStarts = DateTime.MinValue;
			AdminAlertEnds = DateTime.MinValue;
		}

	}
}