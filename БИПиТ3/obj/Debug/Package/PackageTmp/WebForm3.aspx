<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="БИПиТ3.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Таблица с заказами"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" Width="901px" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-top: 13px" Height="274px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetRecords" TypeName="БИПиТ3.WebService1"></asp:ObjectDataSource>
    <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:adverstConnectionString %>" SelectCommand="SELECT * FROM [OrderView]"></asp:SqlDataSource>
    <div class="field">
    <asp:Label ID="Labe2" runat="server" Text="c:"></asp:Label>
    <asp:TextBox ID="Txt1" runat="server" TextMode="Date"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="по:"></asp:Label>
    <asp:TextBox ID="Txt2" runat="server" TextMode="Date"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button2_Click" class="bt2" Text="Фильтровать" Width="125px" BackColor="#6699FF" BorderColor="#6699FF" Height="40px" />
    </div><br />
    <asp:Button ID="Delete" runat="server" OnClick="Button1_Click" class="bt1" Text="Удалить" Width="125px" BackColor="#6699FF" BorderColor="#6699FF" Height="40px" />
    </asp:Content>
