<%@ Page Title="Gestión de Alumnos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="Web.Alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Gestión de Alumnos</h1>       
        <div class="alumnosDesktop">

            <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblLegajo" runat="server" Text="Legajo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento"></asp:Label>
            <asp:Calendar ID="cldFechaNacimiento" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Button" />

        </div>
        <div class="alumnos">

            <br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsAlumnos" ForeColor="#333333" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID">
                    <ControlStyle Width="50px" />
                    <FooterStyle Width="50px" />
                    <HeaderStyle Width="50px" />
                    <ItemStyle Width="50px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre">
                    <ControlStyle Width="200px" />
                    <FooterStyle Width="200px" />
                    <HeaderStyle Width="200px" />
                    <ItemStyle Width="200px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Legajo" HeaderText="Legajo" SortExpression="Legajo">
                    <ControlStyle Width="150px" />
                    <FooterStyle Width="150px" />
                    <HeaderStyle Width="150px" />
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento">
                    <ControlStyle Width="200px" />
                    <FooterStyle Width="200px" />
                    <HeaderStyle Width="200px" />
                    <ItemStyle Width="200px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Edad" HeaderText="Edad" SortExpression="Edad">
                    <ControlStyle Width="50px" />
                    <FooterStyle Width="50px" />
                    <HeaderStyle Width="50px" />
                    <ItemStyle Width="50px" />
                    </asp:BoundField>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:ObjectDataSource ID="odsAlumnos" runat="server" DataObjectTypeName="Business.Entities.Alumno" DeleteMethod="Delete" InsertMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.AlumnoLogic" UpdateMethod="Save">
                <DeleteParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>

        </div>
    </div>
</asp:Content>
