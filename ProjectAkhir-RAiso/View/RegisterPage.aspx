<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ProjectAkhir_RAiso.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #RegisterForm{
            display: grid;
        }
    </style>
</head>
<body>
    <form id="RegisterForm" runat="server">
        <h1>Register</h1>
        <h3>Already have an account? <a href="LoginPage.aspx">Click Here!</a></h3>
        <div name="form-container">
            <div>
                <asp:Label ID="Lbl_Name" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="Tb_Name" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Lbl_DOB" runat="server" Text="Date of Birth: "></asp:Label>
                <asp:TextBox ID="Tb_DOB" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Lbl_Gender" runat="server" Text="Gender: "></asp:Label>
                <asp:RadioButton ID="Rad_Male" runat="server" GroupName="Rad_Gender" Checked="true"/>
                <asp:Label ID="Lbl_Male" runat="server" Text="Male"></asp:Label>
                <asp:RadioButton ID="Rad_Female" runat="server" GroupName="Rad_Gender" />
                <asp:Label ID="Lbl_Female" runat="server" Text="Female"></asp:Label>
            </div>
            <div>
                <asp:Label ID="Lbl_Address" runat="server" Text="Address: "></asp:Label>
                <asp:TextBox ID="Tb_Address" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Lbl_Phone" runat="server" Text="Phone: "></asp:Label>
                <asp:TextBox ID="Tb_Phone" runat="server" TextMode="Phone"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Lbl_Password" runat="server" Text="Password: "></asp:Label>
                <asp:TextBox ID="Tb_Password" runat="server"></asp:TextBox>
                <asp:ImageButton ID="Btn_ShowPassword" runat="server" ImageUrl="~/Assets/show.png" Width="20" Height="23" ImageAlign="Top" OnClick="Btn_ShowPassword_Click" Show="0"/>
            </div>
        </div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
        <asp:Button ID="Btn_Submit" runat="server" Text="Submit" OnClick="Btn_Submit_Click"/>
    </form>
</body>
</html>
