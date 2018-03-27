<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="亂數改變字體大小和顏色"></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="改變字體" OnClick="Button1_Click" />
        </div>
        練習LINQ 查詢語法 Query syntax:
        <div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="物件轉換XML" />
        </div>
        <div>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="在select計算" />
        </div>
        <div>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="匿名型別用var隱含類型" />
        </div>
         <div>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="group分組子句使用巢狀迴圈讀取" />
        </div>
        練習LINQ 方法語法 Method syntax:
        <div>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="方法語句" />
        </div>
    </form>
</body>
</html>
