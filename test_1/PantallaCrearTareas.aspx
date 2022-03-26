<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="PantallaCrearTareas.aspx.cs" Inherits="test_1.PantallaCrearTareas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1577px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header" style=" text-align: center">
        <asp:Label ID="lblTitulo" runat="server" Text="CREACIÓN DE TAREAS" Font-Size="X-Large" Font-Bold="true"></asp:Label>
        <br />
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6" align="center">
                  <div align="left">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Listado de tareas" CssClass="btn btn-success" Width="200px" OnClick="Button3_Click" />
                    </td>
                </tr>
            </table>
        </div>
                <br />

                <div class="box box-primary" align="center">
                    <div class="box-body" align="center">
                        <div class="form-group">
                            <label>SELECCIONE PROCESO</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlEmpresa" runat="server" CssClass="form-control" OnSelectedIndexChanged
                                ="ddlEmpresa_SelectedIndexChanged" style="text-align: center"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>NOMBRE TAREA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtnombreTareas" runat="server" Text="" CssClass="form-control" style="text-align: center"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>DESCRIPCIÓN TAREA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDescripcion" runat="server" Text="" CssClass="form-control" Height="124px" TextMode="MultiLine"></asp:TextBox>

                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6" align="center">
                  <div align="right">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" CssClass="btn btn-success" Width="200px" Text="Tareas reportadas" OnClick="Button2_Click" />

                    </td>
                </tr>
            </table>
        </div>
                <br />
                <div class="box box-primary" align="center">
                    <div class="box-body" align="center">
                        <div class="form-group">
                            <label>FECHA INICIO TAREA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtFechaInicial" runat="server" Text="" CssClass="form-control" TextMode="Date" style="text-align: center"></asp:TextBox>

                        </div>
                        <div class="form-group">
                            <label>FECHA TÉRMINO TAREA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtFechaTerminoTarea" runat="server" CssClass="form-control" TextMode="Date" style="text-align: center"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>RESPONSABLE</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlResponsable" runat="server" CssClass="form-control"  OnSelectedIndexChanged="ddlResponsable_SelectedIndexChanged" style="text-align: center"></asp:DropDownList>

                        </div>
                        <div class="form-group">
                            <label>PORCENTAJE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPorcentaje" runat="server" Text="0" CssClass="form-control" ReadOnly="true" style="text-align: center"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnCrear" runat="server" Text="Crear" CssClass="btn btn-github" Width="200px" OnClick="btnCrear_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </td>
                </tr>
            </table>
        </div>

    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
