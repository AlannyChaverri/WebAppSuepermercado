<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebAppSupermercadoPatitosSA.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<style>
     .backimg {
            background-image:url('IMG/patitos.sa.png');
        height: 467px;
        width: 1080px;
    }
</style>
        <div class="backimg">   
        <h2><%: Title %>.</h2>
        <h3>Alanny José Chaverri Molina.</h3>
    <address >

        Desarrollador de esta web<br />
        Guanacaste, Costa Rica<br />
        <abbr title="Phone">P:</abbr>
        +506 8552-8765
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:achaverrim@est.utn.ac.cr">achaverrim@est.utn.ac.cr</a><br />
    </address>
        </div>


</asp:Content>
