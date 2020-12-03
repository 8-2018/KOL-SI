<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuItem.aspx.cs" Inherits="PresentationLayerWeb.WebForm1" %>
<asp:Content ID="MenuItemContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container">
            <div class="row">
                <div class="col-lg-5 text-center border-1">
                    <br />
                    <asp:ListBox ID="ListBoxMenuItem" runat="server" Height="200px" Width="620px" CssClass="bg-light" Rows="10"></asp:ListBox><br /><br />
                    
                    <asp:Button ID="ButtonMenuItemRefreshListBoxMenuItem" class="btn btn-lg btn-success" runat="server" Text="Osveži listu stavki menija" OnClick="ButtonMenuItemRefreshListBoxMenuItem_Click" /><br />
                    <asp:Label ID="LabelMessages" CssClass="text-success" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-lg-7 text-center border-1">
                    <br />
                    <asp:Label ID="LabelMenuItemTitle" runat="server" Text="Naslov: "></asp:Label><br />
                    <asp:TextBox ID="TextBoxMenuItemTitle" runat="server"></asp:TextBox><br /><br />
                    <asp:Label ID="LabelMenuItemDescription" runat="server" Text="Opis stavki: "></asp:Label><br />
                    <asp:TextBox ID="TextBoxMenuItemDescription" runat="server"></asp:TextBox><br /><br />
                    <asp:Label ID="LabelMenuItemPrice" runat="server" Text="Cena: "></asp:Label><br />
                    <asp:TextBox ID="TextBoxMenuItemPrice" runat="server"></asp:TextBox><br /><br />
                    <asp:Button ID="ButtonMenuItemInsert" class="btn btn-lg btn-primary" runat="server" Text="Unesi podatke o stavki menija" OnClick="ButtonMenuItemInsert_Click" />
                </div>
            </div>
    </div>
    <br /><br /><br />
</asp:Content>
