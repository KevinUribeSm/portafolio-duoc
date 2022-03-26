<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="CrearSubTareasPages.aspx.cs" Inherits="test_1.CrearSubTareasPages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">

     <section class="content">


            <div class="box box-primary" align="center">
                <div class="box-body" align="center">
                    <div class="form-group">
                        <label>ID TAREA</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtidTarea" runat="server" Text="" CssClass="form-control" ReadOnly="true" style="text-align: center"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>NOMBRE SUBTAREA</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtnombreSubTarea" runat="server" Text="" CssClass="form-control" style="text-align: center"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>DESCRIPCION SUBTAREA</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtDescripcionSubTarea" runat="server" Text="" CssClass="form-control" Height="124px" TextMode="MultiLine" style="text-align: center"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <label>FECHA INICIO SUBTAREA</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtFechaIniSubTarea" runat="server" CssClass="form-control" TextMode="Date" style="text-align: center"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>FECHA FIN SUBTAREA</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtFechaTerminoSubTarea" runat="server" CssClass="form-control" TextMode="Date" style="text-align: center"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>RESPONSABLE SUB TAREA</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtResponsableSubTarea" runat="server" Text="" CssClass="form-control" style="text-align: center" ReadOnly="true"></asp:TextBox>

                    </div>
                </div>
            </div>
    </div>
    </div>

         <br />

        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnCrear" runat="server" Text="CREAR SUBTAREA" CssClass="btn btn-github" Width="200px" OnClick="btnCrear_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="CANCELAR" OnClick="btnCancelar_Click" />
                    </td>
                </tr>
            </table>
        </div>

    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
