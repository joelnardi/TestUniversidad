<%@ Page Title="Estado de Curso" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstadoCurso.aspx.cs" Inherits="Web.EstadoCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Estado de Curso</h1>
        <div class="Curso">
            <asp:Label ID="lblCurso" runat="server" Text="Seleccione Curso:"></asp:Label>
&nbsp;
            <br />
            <asp:DropDownList ID="ddlCurso" runat="server" DataSourceID="odsCursos" DataTextField="Asignatura" DataValueField="ID" Width="281px">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="odsCursos" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.CursoLogic"></asp:ObjectDataSource>
            <asp:Button ID="btnVerCurso" runat="server" OnClick="btnVerCurso_Click" Text="Ver Curso" />
        </div>
        <div class="EstadoCurso">
            <asp:Label ID="lblDocente" runat="server" Text="Docente:"></asp:Label>
            <br />
            <asp:TextBox ID="txtDocente" runat="server" ReadOnly="True" Width="539px">Seleccione un curso y pulse Ver Curso</asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="dgvEstadoCurso" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsInscripciones" ForeColor="#333333" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="AlumnoStr" HeaderText="Alumnos" ReadOnly="True" SortExpression="AlumnoStr">
                    <ControlStyle Width="200px" />
                    <FooterStyle Width="200px" />
                    <HeaderStyle Width="200px" />
                    <ItemStyle Width="200px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FechaInscripcion" HeaderText="Fecha de Inscripción" ReadOnly="True" SortExpression="FechaInscripcion">
                    <ControlStyle Width="175px" />
                    <FooterStyle Width="175px" />
                    <HeaderStyle Width="175px" />
                    <ItemStyle Width="175px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="EstadoInsc" HeaderText="Estado de Inscripción" ReadOnly="True" SortExpression="EstadoInsc">
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
            <asp:ObjectDataSource ID="odsInscripciones" runat="server" SelectMethod="GetAllCursos" TypeName="Business.Logic.InscripcionLogic">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlCurso" Name="IDCu" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>

        </div>
    </div>
</asp:Content>
