<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Bienvenido a Test TECSO</h1>
        <p>En este sitio hay acceso a las funciones solicitadas para testear. Al ser un sitio de evaluación es probable que algunas funcionalidades no funcionen de forma plena y que la estética del sitio no sea del todo óptima.</p>
        <p style="text-align:center;">
            <asp:Button ID="btnAlumnos" runat="server" Text="Gestion de Alumnos" Width="349px" OnClick="btnAlumnos_Click" />
        </p>
        <p style="text-align:center;">      
            <asp:Button ID="btnInscripciones" runat="server" Text="Gestion de Inscripciones" Width="349px" OnClick="btnInscripciones_Click" />
        </p>
        <p style="text-align:center;">
            <asp:Button ID="btnEstadoAcademico" runat="server" Text="Estado Academico Alumno" Width="349px" OnClick="btnEstadoAcademico_Click" />
        </p>
        <p style="text-align:center;">
            <asp:Button ID="btnEstadoCurso" runat="server" Text="Estado de Curso" Width="349px" OnClick="btnEstadoCurso_Click" />
        </p>             
    </div>
</asp:Content>
