<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alerts.aspx.cs" Inherits="WebAlertSystem.Alerts" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link href="Skins/fw2/basic.css" rel="stylesheet" type="text/css" />
	<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.min.js"></script>

	<script>
		// timer func
	function descon() {
		var id = "#deconx";
		var c = $(id);
		var v = c.attr("tv");  //eval(c.text());
		if (!v) v = eval(c.text())
		try {
			if (--v > 0) { // elle cevirelim date gmt offset filan hesapliyor.
				var s = Math.floor(v / 3600) + ":" + Math.floor((v % 3600) / 60) + ":" + (v % 60);
				c.text(s);
				c.attr("tv", v);
			} else
				document.location = document.location;
		} catch (e) { ; }
	}
	</script>
</head>
<body>
    <form id="form1" runat="server">
    <table class="fdc">
			<tr>
				<td>
					adı</td>
				<td>
					<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td>
					soyadı</td>
				<td>
					<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
				</td>
			</tr>
		</table>
    <div>
    
    	<asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
