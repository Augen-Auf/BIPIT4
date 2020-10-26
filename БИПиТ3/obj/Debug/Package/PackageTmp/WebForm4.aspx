<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="БИПиТ3.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    #Select1 {
        width: 185px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="field"><asp:Label ID="Label3" runat="server" Text="Клиент"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Client" DataValueField="IdC">
</asp:DropDownList></div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Clients" TypeName="БИПиТ3.WebService1"></asp:ObjectDataSource>
    <br />
    <div class="field"><asp:Label ID="Label4" runat="server" Text="Услуга"></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource2" DataTextField="Service" DataValueField="IdS">
</asp:DropDownList></div>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="Service" TypeName="БИПиТ3.WebService1"></asp:ObjectDataSource>
    <br />
    <div class="field"><asp:Label ID="Label1" runat="server" Text="Срок аренды:"></asp:Label>
<asp:TextBox ID="TextBox1" TextMode="Number" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" ErrorMessage="Поле не должно быть пустым!" ForeColor="Red"></asp:RequiredFieldValidator><br />
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Число должно быть положительным!" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    </div><br />
    <div class="field"><asp:Label ID="Label2" runat="server" Text="Дата заказа:"></asp:Label>
    <asp:TextBox ID="Txt1" runat="server" TextMode="Date" Width="152px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="Txt1" runat="server" ErrorMessage=" Укажите дату!" ForeColor="Red"></asp:RequiredFieldValidator></div>
    <asp:Button ID="Add" runat="server" class="bt3" Text="Добавить" OnClick="Button1_Click" BackColor="#FF99FF" BorderColor="#FF99FF" Height="40px" Width="130px" />
    <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:adverstConnectionString %>" SelectCommand="SELECT [IdC], [Client] FROM [Client]"></asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:adverstConnectionString %>" SelectCommand="SELECT [IdS], [Service] FROM [Service]"></asp:SqlDataSource> 
</asp:Content>
