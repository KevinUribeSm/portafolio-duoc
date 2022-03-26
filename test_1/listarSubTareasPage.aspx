<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="listarSubTareasPage.aspx.cs" Inherits="test_1.listarSubTareasPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">

    <br />
    <div class="col-md-12 col-md-offset-0">
        <asp:GridView ID="gdvListarSubTareas" runat="server" CssClass="table table-striped table-bordered table-responsive text-bold" HorizontalAlign="Center"
            AutoGenerateColumns="False"
            OnSelectedIndexChanged="gdvListarSubTareas_SelectedIndexChanged"
            OnRowCommand="gdvListarSubTareas_RowCommand1" CellPadding="4" ForeColor="#333333" GridLines="None">

            <AlternatingRowStyle BackColor="White" />

            <Columns>
                <asp:TemplateField HeaderText="SELECCIONA PARA EDITAR">
                    <ItemTemplate>
                        <asp:CheckBox ID="Chk" runat="server" OnCheckedChanged="Chk_CheckedChanged1" AutoPostBack="true" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="ID SUB TAREA" DataField="ID_TAREA" />
                <asp:BoundField HeaderText="NOMBRE SUB TAREA" DataField="NOMBRE_TAREA" />
                <asp:BoundField HeaderText="DESCRIPCION SUB TAREA" DataField="DESCRIPCION_TAREA" />
                <asp:BoundField HeaderText=" FECHA INICIO SUB TAREA" DataField="FECHA_PROCESO" />
                <asp:BoundField HeaderText="FECHA FIN SUB TAREA" DataField="FECHA_FIN" />
                <asp:BoundField HeaderText="ESTADO SUB TAREA" DataField="ESTADO_TAREA" />
                <asp:BoundField HeaderText="ID TAREA" DataField="ID_TAREA_PADRE" />
                <asp:BoundField HeaderText="RUT RESPONSABLE" DataField="RUT_CREADOR_TARE" />
                <asp:ButtonField runat="server" Text="ElIMINAR" CommandName="eliminarSubtask" ControlStyle-CssClass="btn btn- alert-info">
                <ControlStyle CssClass="btn btn-danger"></ControlStyle>
                </asp:ButtonField>



            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>


    <section class="content">
        <div class="row">
            <div class="col-md-8" align="center">
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
                            <asp:TextBox ID="txtidTarea" runat="server" Text="" CssClass="form-control" ReadOnly="true" Style="text-align: center"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>NOMBRE SUBTAREA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtnombreSubTarea" runat="server" Text="" CssClass="form-control" Style="text-align: center"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>DESCRIPCION SUBTAREA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDescripcionSubTarea" runat="server" Text="" CssClass="form-control" Height="124px" TextMode="MultiLine" Style="text-align: center"></asp:TextBox>

                        </div>
                        <div class="form-group">
                            <label>FECHA INICIO SUBTAREA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtFechaIniSubTarea" runat="server" CssClass="form-control" TextMode="Date" Style="text-align: center"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>FECHA FIN SUBTAREA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtFechaTerminoSubTarea" runat="server" CssClass="form-control" TextMode="Date" Style="text-align: center"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>RESPONSABLE SUB TAREA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtResponsableSubTarea" runat="server" Text="" CssClass="form-control" Style="text-align: center" ReadOnly="true"></asp:TextBox>

                        </div>
                    </div>
                </div>

            </div>
            <div class="col-md-4" align="center">
                <div align="right">
                    <table>
                    </table>
                </div>
                <br />
                <div class="box box-primary" align="center">
                    <div class="box-body" align="center">
                        <div class="form-group">
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <tr>
                                <td>
                                    <asp:Button ID="btnActualizar" runat="server" Text="ACTUALIZAR" CssClass="btn btn-success" Width="200px" OnClick="btnCrear_Click" Font-Size="X-Large" Font-Bold="true" />
                                </td>
                            </tr>

                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <tr>
                                <td>
                                    <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" CssClass="btn-bitbucket" OnClick="btnCancelar_Click" Width="200px" Font-Size="X-Large" Font-Bold="true" />
                                </td>
                            </tr>
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
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

                <div align="center">
                    <table>
                    </table>
                </div>
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
