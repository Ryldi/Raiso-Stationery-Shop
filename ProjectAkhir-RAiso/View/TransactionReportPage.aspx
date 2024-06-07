<%@ Page Title="" Language="C#" MasterPageFile="~/View/General.Master" AutoEventWireup="true" CodeBehind="TransactionReportPage.aspx.cs" Inherits="ProjectAkhir_RAiso.View.TransactionReportPage" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .report-container{
            display: flex;
            justify-content: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="report-container">
        <CR:CrystalReportViewer ID="CR_Viewer" runat="server" AutoDataBind="true"/>
    </div>
</asp:Content>
