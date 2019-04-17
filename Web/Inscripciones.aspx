<%@ Page Title="Gestión de Inscripciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="Web.Inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Gestión de Inscripciones</h1>    
        <div class="inscripciones">

            <br />

            <asp:GridView ID="dgvInscripciones" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataSourceID="odsInscripciones" ForeColor="#333333" DataKeyNames="ID"
                GridLines="None" OnSelectedIndexChanged="dgvInscripciones_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" >
                    <ControlStyle Width="50px" />
                    <FooterStyle Width="50px" />
                    <HeaderStyle Width="50px" />
                    <ItemStyle Width="50px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="AlumnoStr" HeaderText="Alumnos" ReadOnly="True" SortExpression="AlumnoStr" >
                    <ControlStyle Width="200px" />
                    <FooterStyle Width="200px" />
                    <HeaderStyle Width="200px" />
                    <ItemStyle Width="200px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="CursoStr" HeaderText="CursoStr" ReadOnly="True" SortExpression="CursoStr" >
                    <ControlStyle Width="250px" />
                    <FooterStyle Width="250px" />
                    <HeaderStyle Width="250px" />
                    <ItemStyle Width="250px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FechaInscripcion" HeaderText="Fecha de Inscripción" SortExpression="FechaInscripcion" >
                    <ControlStyle Width="200px" />
                    <FooterStyle Width="200px" />
                    <HeaderStyle Width="200px" />
                    <ItemStyle Width="200px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="EstadoInsc" HeaderText="Estado Insc" SortExpression="EstadoInsc" >
                    <ControlStyle Width="150px" />
                    <FooterStyle Width="150px" />
                    <HeaderStyle Width="150px" />
                    <ItemStyle Width="150px" />
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
            <asp:ObjectDataSource ID="odsInscripciones" runat="server" DataObjectTypeName="Business.Entities.Inscripcion" DeleteMethod="Delete" InsertMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.InscripcionLogic" UpdateMethod="Save">
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
                    <asp:Label ID="lblTitulo" runat="server" Text="Inscripcion" Font-Bold="False" Font-Overline="True" Font-Size="Larger" Font-Underline="True"></asp:Label>
                    <br />
                    <asp:Label ID="lblID0" runat="server" Text="ID" Font-Bold="True"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    <br />
                        <asp:Label ID="lblAlumno" runat="server" Font-Bold="True" Text="Alumno"></asp:Label>
                        &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="ddlAlumno" runat="server" DataSourceID="odsAlumnos" DataTextField="Nombre" DataValueField="ID">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="odsAlumnos" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.AlumnoLogic"></asp:ObjectDataSource>
                    <br />
                        <asp:Label ID="lblCurso" runat="server" Font-Bold="True" Text="Curso"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlCurso" runat="server" DataSourceID="odsCursos" DataTextField="Asignatura" DataValueField="ID">
                        </asp:DropDownList>
                        &nbsp;<asp:ObjectDataSource ID="odsCursos" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.CursoLogic"></asp:ObjectDataSource>
                    <br />
                        <asp:Label ID="lblEstado" runat="server" Font-Bold="True" Text="Estado"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlEstado" runat="server">
                            <asp:ListItem>1-Inscripto</asp:ListItem>
                            <asp:ListItem>2-Regular</asp:ListItem>
                            <asp:ListItem>3-No Regularizo</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <br />
                    <asp:Label ID="lblFechaInscripcion" runat="server" Text="Fecha de Inscripcion" Font-Bold="True"></asp:Label>
                    <asp:Calendar ID="cldFechaInscripcion" runat="server"></asp:Calendar>
                        <br />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
                    <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
                    </asp:Panel>  
                </div>

    </div>
</asp:Content>
