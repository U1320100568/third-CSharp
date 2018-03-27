<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        轉換型別
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
            實質型別 ex.struct <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="實質" />
        </p>
        <p>
            參考型別 ex.class <asp:Button ID="Button3" runat="server" Text="參考" OnClick="Button3_Click" />
        </p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="列出學生名單" />
            <asp:Button ID="Button5" runat="server" Text="get&set" OnClick="Button5_Click" />
        </p>
    </form>
    
</body>
</html>
