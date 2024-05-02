﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/General.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectAkhir_RAiso.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #<%=Gv_Stationeries.ClientID %> {
            display: flex;
            justify-content: center;
            padding: 2vh;
        }
        .grid-header{
            border: none;
            padding-right: 10vh;
            padding-bottom: 3vh;
            font-weight: normal;
            font-size: larger;
            color: #779ECB;
        }
        .grid-item {
            border: none;
            padding-top: 3vh;
            padding-right: 10vh;
            border-bottom: 2px solid #779ECB;
        }
        .img-item{
            width: auto;
            padding-top: 3vh;
            border: none;
            padding-right: 1vh;
            border-bottom: 2px solid #779ECB;
            box-shadow: rgba(0, 0, 0, 0.15) 2.4px 2.4px 3.2px;
        }
        #<%=Btn_Insert.ClientID %>{
            background-color: #88AED0;
            color: whitesmoke;
            border: none;
            padding: 1vh;
            border-radius: 1vh;
            cursor: pointer;
        }
        .add-container {
            display: grid;
            justify-content: center;
            padding: 2vh;
        }
        #<%=Mdl_Delete.ClientID %>{
            border: 2px solid red;
            border-radius: 1vh;
            position: fixed;
            z-index: 1;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            background-color: whitesmoke;
            padding: 2vh;
            display: grid;
            gap: 2vh;
            box-shadow: rgba(0, 0, 0, 0.56) 0px 22px 70px 4px;
        }
        #<%=Btn_Confirm.ClientID %>{
            background-color: red;
            color: whitesmoke;
            border: none;
            padding: 1vh;
            border-radius: 1vh;
            cursor: pointer;
        }
        #<%=Btn_Cancel.ClientID %>{
            background-color: #88AED0;
            color: whitesmoke;
            border: none;
            padding: 1vh;
            border-radius: 1vh;
            cursor: pointer;
        }
        .sub-modal{
            display: flex;
            justify-content: center;
            gap: 3vh;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="add-container">
        <asp:Button ID="Btn_Insert" runat="server" Text="Add" Visible="true" OnClick="Btn_Insert_Click"/>
    </div>
    
    <asp:GridView ID="Gv_Stationeries" runat="server" AutoGenerateColumns="false" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="StationeryName" HeaderText="Stationery" ItemStyle-CssClass="grid-item" HeaderStyle-CssClass="grid-header"/>
            <asp:TemplateField ItemStyle-CssClass="img-item" HeaderStyle-CssClass="grid-header" >
                <ItemTemplate>
                    <asp:ImageButton ID="Btn_Detail" runat="server" ImageUrl="~/Assets/detail.png" Width="30" Visible="true" OnClick="Btn_Detail_Click"/>
                    <asp:ImageButton ID="Btn_Edit" runat="server" ImageUrl="~/Assets/edit.png" Width="30" Visible="true" OnClick="Btn_Edit_Click"/>
                    <asp:ImageButton ID="Btn_Delete" runat="server" ImageUrl="~/Assets/delete.png" Width="30" Visible="true" OnClick="Btn_Delete_Click"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <asp:Panel ID="Mdl_Delete" runat="server" Visible="false">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Are you sure want to delete "></asp:Label>
            <asp:Label ID="Lbl_Item" runat="server" Text="" Font-Bold="true"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text=" from inventory?"></asp:Label>
        </div>
        <div class="sub-modal">
            <asp:Button ID="Btn_Confirm" runat="server" Text="Delete" OnClick="Btn_Confirm_Click"/>
            <asp:Button ID="Btn_Cancel" runat="server" Text="Cancel" OnClick="Btn_Cancel_Click"/>
        </div>
    </asp:Panel>
</asp:Content>
