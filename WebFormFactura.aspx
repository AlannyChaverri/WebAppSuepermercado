<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormFactura.aspx.cs" Inherits="WebAppSupermercadoPatitosSA.WebFormFactura" %>
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
    <h3>Datos Factura</h3>
    <p>
    </p>
        <Table> 
            <tr>
            <td>Numero</td> <td> 
                <asp:TextBox ID="txtnumero" runat="server"></asp:TextBox>
                </td>
            <tr>
                

                <td>Cedula Cliente</td> <td> 
                <asp:TextBox ID="txtcliente" runat="server"></asp:TextBox>
                </td>
            
            </tr>

            <tr>
                    <td>Nombre Cajero</td> <td> 
                    <asp:TextBox ID="txtnombrecajero" runat="server"></asp:TextBox>
                    </td>
               
            </tr>

            <tr>
                 <td>Fecha Facturacion</td> <td> 
                 <asp:TextBox ID="txtfecha" placeholder="YYYY-MM-DD" runat="server"></asp:TextBox>
                 </td>
            </tr>

            <tr>
                 <td>Forma de Pago</td> <td> 
                 <asp:TextBox ID="txtpago" runat="server"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                 <td>Total</td> <td> 
                 <asp:TextBox ID="txttotal" runat="server"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                 <td>IVA</td> <td> 
                 <asp:TextBox ID="txtiva" runat="server"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                 <td>ID Cajero</td> <td> 
                 <asp:TextBox ID="txtidcajero" runat="server"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                 <td>ID Sucursal</td> <td> 
                 <asp:TextBox ID="txtsucuesal" runat="server"></asp:TextBox>
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
                    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
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
        <//div>
</asp:Content>
