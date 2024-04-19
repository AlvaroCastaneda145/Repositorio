<%@ Page Title="" Language="C#" MasterPageFile="~/master/CineStar.master" AutoEventWireup="true" CodeFile="Cines.aspx.cs" Inherits="pages_Cines" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <h1>Nuestros Cines</h1>
    <br />

    <asp:Repeater ID="rptCines" runat="server" >
        <ItemTemplate>
            <div class="contenido-cine">
                <img src="../img/cine/<%#Eval("id")%>.1.jpg" width="227" height="170" />
                <div class="datos-cine">
                    <h4><%#Eval("RazonSocial")%></h4>
                    <br />
                    <span><%#Eval("Direccion")%> - <%#Eval("Detalle")%><br />
                        <br />Teléfono: <%#Eval("Telefonos")%></span>
                </div>
                <br />
                <a href="Cine.aspx?idCine=<%#Eval("id")%>">
                    <img src="../img/varios/ico-info2.png" width="150" height="40" />
                </a>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    
    <asp:SqlDataSource runat="server" ID="cnCineStar"></asp:SqlDataSource>
    
      
    
    
    
</asp:Content>

