<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SiteManagement.aspx.cs" Inherits="WebAlertSystem.SiteManagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
				<legend accesskey="I"> Yönetici Mesajı </legend>
				<table>
					<tr>
						<td>
								Başlangıç</td>
						<td>
							&nbsp;<asp:TextBox ID="tbStart" runat="server"></asp:TextBox>
						</td>
						<td rowspan="3" style="width:50%">
							<asp:Button ID="btnSend" runat="server" Text="Gönder" 
								onclick="btnSend_Click"  />
							<asp:Button ID="btnClear"
								runat="server" Text="Temizle" OnClick="btnClear_Click" /></td>
					</tr>
					<tr>
						<td>
								Bitiş 
						</td>
						<td>
						&nbsp;<asp:TextBox ID="tbEnd" runat="server"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td>
								Mesaj 
						</td>
						<td>
						&nbsp;<asp:TextBox ID="tbMessage" runat="server" Rows="4" TextMode="MultiLine" Wrap="False"></asp:TextBox>
						</td>
					</tr>
				</table>
			</fieldset>
    </div>
    </form>
</body>
</html>
