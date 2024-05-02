<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectAkhir_RAiso.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="loginForm" runat="server">
        <h1>Login</h1>
        <h3>Doesn't have an account? <a href="RegisterPage.aspx">Click Here!</a></h3>
        <div>
            <div>
                <asp:Label ID="Lbl_Name" runat="server" Text="UserName: "></asp:Label>
                <asp:TextBox ID="Tb_Name" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Lbl_Password" runat="server" Text="Password: "></asp:Label>
                <asp:TextBox ID="Tb_Password" runat="server"></asp:TextBox>
                <asp:ImageButton ID="Btn_ShowPassword" runat="server" ImageUrl="~/Assets/show.png" Width="20" Height="23" ImageAlign="Top" OnClick="Btn_ShowPassword_Click" Show="0" />
            </div>
        </div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
        <asp:Button ID="Btn_Submit" runat="server" Text="Login" OnClick="Btn_Submit_Click" />
    </form>
</body>
</html>
