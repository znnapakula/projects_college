<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPrzychodnia._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Przychodnia XYZ</h1>
        <p class="lead">Lista dostępnych terminów</p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="Odswiez" Width="208px" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;<asp:ListBox ID="ListBox1" runat="server" Height="131px" Width="432px"></asp:ListBox>
            </p>
        </div>
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
