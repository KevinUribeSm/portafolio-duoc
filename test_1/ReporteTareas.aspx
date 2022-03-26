<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="ReporteTareas.aspx.cs" Inherits="test_1.MisTareasReportadas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">

    <section class="content-header" style="text-align: center">
        <asp:Label ID="lblTitulo" runat="server" Text="VISTA DE REPORTE" Font-Size="X-Large" Font-Bold="true"></asp:Label>
        <br />

       <section class="content">
            <div class="row">
            <div class="col-md-8" align="center">
                <div align="center">

                    <div class="box box-primary" align="center">
                        <div class="box-body" align="center">
                            <div class="form-group">
                                   <asp:DetailsView ID="dtlReporte" runat="server" Height="250px" Width="650px" CellPadding="4" ForeColor="#333333" GridLines="None" AlternatingRowStyle-HorizontalAlign="Center">
                        <AlternatingRowStyle BackColor="White" />
                        <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" Width="200px" Font-Size="Small" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" HorizontalAlign ="Center" />
                    </asp:DetailsView>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

            <div class="col-md-4" align="center">
                <div align="center">

                    <div class="box box-primary" align="center">
                        <div class="box-body" align="center">
                            <div class="form-group">
                     <tr>
                         <br />
                         <br />
                         <br />
                         <br />
                         <br />
                         <br />
                         <br />
                                <td>
                                    <asp:Button ID="btnVolver" runat="server" Text="SALIR" CssClass="btn btn-success" Width="200px" OnClick="btnActualizar_Click" Font-Size="X-Large" Font-Bold="true" />
                                </td>
                            </tr>
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                               
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
            </div>
    </section>
        </section>




</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
