<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="TareasReportadas.aspx.cs" Inherits="test_1.TareasReportadas" %>
<asp:Content ID="Content4" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="contentBody" runat="server">
       <section class="content-header">
        <h1 style="text-align: center" class="auto-style1">TAREAS REPORTADAS</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-12" align="center">
                  <div align="left">
            <table>

            </table>
        </div>
                <br />

                <div class="box box-primary" align="center">
                    <div class="box-body" align="center">
                       
                        <div class="form-group">
                            <label>ID TAREA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtTarea" runat="server" Text="" CssClass="form-control" ReadOnly="true" style="text-align: center"></asp:TextBox>
                        </div>
                        <br />
                        <div class="form-group">
                            <label>DESCRIPCION REPORTE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtReporte" runat="server" Text="" CssClass="form-control" Height="124px" TextMode="MultiLine" style="text-align: center"></asp:TextBox>
                        </div>
                        <br />
                        
                    </div>
                </div>
            </div>

        <br />
        <div align="center">
            <table>
                <br />
                <tr>
                    <td>
                        <asp:Button ID="btnCrear" runat="server" Text="Crear" CssClass="btn btn-primary" Width="200px" OnClick="btnCrear_Click"  />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
    </section>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
