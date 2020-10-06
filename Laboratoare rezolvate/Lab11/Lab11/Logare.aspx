<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logare.aspx.cs" Inherits="Lab11.Logare" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:AccessDataSource ID="DS1" runat="server" DataFile="~/App_Data/DB1.mdb" SelectCommand="SELECT DProdus, PretVanzare, UM, CotaTVA, IdProdus FROM Produse"></asp:AccessDataSource>
        <asp:Button ID="Button1" runat="server" Text="Adauga Produse" />
        <asp:GridView ID="GridView1" runat="server" style="position:absolute; top: 115px; left: 13px;" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdProdus" DataSourceID="DS1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="DProdus" HeaderText="DProdus" SortExpression="DProdus" />
                <asp:BoundField DataField="PretVanzare" HeaderText="PretVanzare" SortExpression="PretVanzare" />
                <asp:BoundField DataField="UM" HeaderText="UM" SortExpression="UM" />
                <asp:BoundField DataField="CotaTVA" HeaderText="CotaTVA" SortExpression="CotaTVA" />
                <asp:BoundField DataField="IdProdus" HeaderText="IdProdus" InsertVisible="False" ReadOnly="True" SortExpression="IdProdus" />
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
        <asp:Panel ID="Panel1" runat="server" Height="292px" style="margin-left: 352px">
        </asp:Panel>
        <asp:Label ID="Label1" runat="server" Text="Oferta produse" style="position:absolute; top: 68px; left: 15px;"></asp:Label>
    </form>
</body>
</html>
