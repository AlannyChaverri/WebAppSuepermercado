﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormSucursal.aspx.cs" Inherits="WebAppSupermercadoPatitosSA.WebFormSucursal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <style>
     .backimg {
            background-image:url('IMG/patitos.sa.png');
        height: 467px;
        width: 1080px;
    }
</style>

    <div class="backimg"> 

<p>
    </p>
    <h3>Datos Sucursal</h3>
    <p>
    </p>
        <Table> 
            <tr>
            <td>ID Sucursal</td> <td> 
                <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                </td>
            <tr>
                

                <td>ID Empresa</td> <td> 
                <asp:TextBox ID="txtidempresa" runat="server"></asp:TextBox>
                </td>
            
            </tr>

            <tr>
                    <td>Nombre</td> <td> 
                    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                    </td>
               
            </tr>

            <tr>
                 <td>Telefono</td> <td> 
                 <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                <td>Email</td> <td> 
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Direccion</td> <td> 
                <asp:TextBox ID="txtdirecion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>


                    <br />


                </td>
            </tr>
            <tr>
                <td colspan ="2"> 
                    <asp:Button type="button" class="btn btn-primary" ID="btnagregar" runat="server" Text="Agregar" OnClick="btnagregar_Click"  />
                    <asp:Button type="button" class="btn btn-success" ID="btnModifi" runat="server" Text="Modificar" OnClick="btnModifi_Click" />
                    <asp:Button type="button" class="btn btn-danger" ID="btneliminar" runat="server" Text="Borrar" OnClick="btneliminar_Click" />
                    <asp:Button type="button" class="btn btn-info" ID="btnmostrar" runat="server" Text="Mostrar" OnClick="btnmostrar_Click" />
                   
                
            </tr>

             <tr>
                <td>&nbsp;</td> <td> 
                 <asp:Label ID="Labelmsg" runat="server"></asp:Label>
                </td>
            </tr>



            
             <tr>
                <td colspan ="2">
                    <asp:GridView ID="GridViewAgente" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    </asp:GridView>
                 </td>
            </tr>



            
          



            
        </table>
        </div>
</asp:Content>
