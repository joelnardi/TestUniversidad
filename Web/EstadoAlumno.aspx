<%@ Page Title="Estado Académico de Alumno" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstadoAlumno.aspx.cs" Inherits="Web.EstadoAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Estado Académico de Alumno</h1>  
        <div class="Alumno">
            Seleccione Alumno:<br />
            <asp:DropDownList ID="ddlAlumnos" runat="server" DataSourceID="odsAlumnos" DataTextField="Nombre" DataValueField="ID" Height="28px" Width="298px">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="odsAlumnos" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.AlumnoLogic"></asp:ObjectDataSource>
            <asp:Button ID="btnEstadoAcademico" runat="server" Text="Ver Estado Academico" />
        </div>
        <div class="Estado Alumno">
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsInscripciones" ForeColor="#333333" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="CursoStr" HeaderText="Cursos" ReadOnly="True" SortExpression="CursoStr">
                    <ControlStyle Width="300px" />
                    <FooterStyle Width="300px" />
                    <HeaderStyle Width="300px" />
                    <ItemStyle Width="300px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FechaInscripcion" HeaderText="Fecha de Inscripción" SortExpression="FechaInscripcion">
                    <ControlStyle Width="175px" />
                    <FooterStyle Width="175px" />
                    <HeaderStyle Width="175px" />
                    <ItemStyle Width="175px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="EstadoInsc" HeaderText="Estado de Inscripción" SortExpression="EstadoInsc">
                    <ControlStyle Width="200px" />
                    <FooterStyle Width="200px" />
                    <HeaderStyle Width="200px" />
                    <ItemStyle Width="200px" />
                    </asp:BoundField>
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
            <asp:ObjectDataSource ID="odsInscripciones" runat="server" SelectMethod="GetAllAlumnos" TypeName="Business.Logic.InscripcionLogic">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlAlumnos" Name="IDAl" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </div>
</asp:Content>
