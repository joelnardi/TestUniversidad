<%@ Page Title="Gestión de Inscripciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="Web.Inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Gestión de Inscripciones</h1>    
        <div class="inscripcionDesktop">

            <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblAlumno" runat="server" Text="Alumno"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlAlumno" runat="server" DataSourceID="odsAlumnos" DataTextField="Nombre" DataValueField="ID">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="odsAlumnos" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.AlumnoLogic"></asp:ObjectDataSource>
            <br />
            <asp:Label ID="lblCurso" runat="server" Text="Curso"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCurso" runat="server" DataSourceID="odsCursos" DataTextField="Asignatura" DataValueField="ID">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="odsCursos" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.CursoLogic"></asp:ObjectDataSource>
            <br />
            <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlEstado" runat="server">
                <asp:ListItem>1-Inscripto</asp:ListItem>
                <asp:ListItem>2-Regular</asp:ListItem>
                <asp:ListItem>3-No Regularizo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Fecha de Inscripción"></asp:Label>
            <asp:Calendar ID="calFechaInscripcion" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />

        </div>
        <div class="inscripciones">

            <br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsInscripciones" ForeColor="#333333" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="AlumnoStr" HeaderText="AlumnoStr" ReadOnly="True" SortExpression="AlumnoStr" />
                    <asp:BoundField DataField="CursoStr" HeaderText="CursoStr" ReadOnly="True" SortExpression="CursoStr" />
                    <asp:BoundField DataField="FechaInscripcion" HeaderText="FechaInscripcion" SortExpression="FechaInscripcion" />
                    <asp:BoundField DataField="EstadoInsc" HeaderText="EstadoInsc" SortExpression="EstadoInsc" />
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
            <asp:ObjectDataSource ID="odsInscripciones" runat="server" DataObjectTypeName="Business.Entities.Inscripcion" DeleteMethod="Delete" InsertMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.InscripcionLogic" UpdateMethod="Save">
                <DeleteParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>

        </div>
    </div>
</asp:Content>
