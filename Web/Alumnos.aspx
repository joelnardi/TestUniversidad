<%@ Page Title="Gestión de Alumnos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="Web.Alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Gestión de Alumnos</h1>       
        <div class="alumnos">

            <br />

            <asp:GridView ID="dgvAlumnos" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataSourceID="odsAlumnos" ForeColor="#333333" DataKeyNames="ID"
                GridLines="None" OnSelectedIndexChanged="dgvAlumnos_SelectedIndexChanged">
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
                    <asp:CommandField ShowSelectButton="True" />
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

            <asp:Panel ID="gridActionsPanel" runat="server">
                <asp:Button ID="btnNuevo" runat="server" BackColor="#66FFCC" OnClick="btnNuevo_Click" Text="Nuevo" />
                <asp:Button ID="btnEditar" runat="server" Text="Editar" BackColor="#FFFFCC" OnClick="btnEditar_Click" />
                <asp:Button ID="btnEliminar" runat="server" BackColor="#FF9999" OnClick="btnEliminar_Click" Text="Eliminar" />
            </asp:Panel>
        </div>
        <div class="alumnosDesktop">
                    <br />
                    <asp:Panel ID="formPanel" runat="server" BackColor="#FFCC99" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px">
                    <asp:Label ID="lblTitulo" runat="server" Text="Alumno" Font-Bold="False" Font-Overline="True" Font-Size="Larger" Font-Underline="True"></asp:Label>
                    <br />
                    <asp:Label ID="lblID" runat="server" Text="ID" Font-Bold="True"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre" Font-Bold="True"></asp:Label>
                    &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblLegajo" runat="server" Text="Legajo" Font-Bold="True"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
                    <br />
                        <br />
                    <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento" Font-Bold="True"></asp:Label>
                    <asp:Calendar ID="cldFechaNacimiento" runat="server"></asp:Calendar>
                        <br />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
                    <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
                    </asp:Panel>  
                </div>
    </div>
</asp:Content>
