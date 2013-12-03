using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Web.UI;

namespace WebAlertSystem
{
	public class ApplicationNode
	{
		public static Table MakeTable(int rows, int cols, bool fillEmpty = false)
		{
			Table Result = new Table();
			TableRow row = null;
			TableCell tc = null;
			int c = cols;
			Result.EnableViewState = false;
			while (rows > 0)
			{
				row = new TableRow();
				cols = c;
				while (cols > 0)
				{
					tc = new TableCell();
					tc.Text = "&nbsp;";
					row.Cells.Add(tc);
					cols -= 1;
				}
				Result.Rows.Add(row);
				rows -= 1;
			}
			return Result;
		}
			
			
	}
}