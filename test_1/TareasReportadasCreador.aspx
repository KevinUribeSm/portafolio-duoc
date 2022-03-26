<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="TareasReportadasCreador.aspx.cs" Inherits="test_1.TareasReportadasCreador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header" style="text-align: center">
        <asp:Label ID="lblTitulo" runat="server" Text="TAREAS REPORTADAS" Font-Size="X-Large" Font-Bold="true"></asp:Label>
        <br />
        <br />
    </section>
    <section class="content-header" style="text-align: right">
        <div class="col-md-11">
            <asp:Button ID="Button1" runat="server" Text="IR A EDITAR TAREAS" CssClass="btn btn-tumblr" Width="160px" OnClick="Button1_Click1" />

        </div>

    </section>
      
    <div>
        
        <div class="col-md-12 col-md-offset-0">
            <br />
            <asp:GridView ID="gvdTareasReportadasCreador" runat="server"
                CssClass="table"
                DataKeyNames="ID_TAREA"
                AutoGenerateColumns="False"
                HorizontalAlign="Center"
                OnRowCommand="gvdTareasReportadasCreador_RowCommand"
                Width="880px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="ID TAREA" DataField="ID_TAREA" ReadOnly="true" />
                    <asp:BoundField HeaderText="NOMBRE TAREA" DataField="NOMBRE_TAREA" ReadOnly="true" />
                    <asp:BoundField HeaderText="RUT RESPONSABLE" DataField="RUT_ASIGNADO" ReadOnly="true" />
                    <asp:BoundField HeaderText="ESTADO" DataField="ESTADO_TAREA" ReadOnly="true" />

                    <asp:ButtonField runat="server" Text="Ver Reporte" CommandName="verReporte" ControlStyle-CssClass="btn btn- alert-info">
                        <ControlStyle CssClass="btn btn- alert-info"></ControlStyle>
                    </asp:ButtonField>

                    <asp:ButtonField runat="server" Text="Cerrar reporte" CommandName="cerrarReporte" ControlStyle-CssClass="btn btn-facebook">
                        <ControlStyle CssClass="btn btn-danger "></ControlStyle>
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
    </div>


    <section class="content-header" style="text-align: center">
        <asp:Label ID="lblSubTareasReportadas" runat="server" Text="SUB TAREAS REPORTADAS" Font-Size="X-Large" Font-Bold="true"></asp:Label>
        <br />
    </section>

    <br />
    <br />
    <div>
        <div class="col-md-12 col-md-offset-0">
            <asp:GridView ID="gdvSubTareasReportadas" runat="server"
                CssClass="table"
                DataKeyNames="ID_TAREA"
                AutoGenerateColumns="False"
                HorizontalAlign="Center"
                OnRowCommand="gdvSubTareasReportadas_RowCommand"
                Width="880px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="ID TAREA" DataField="ID_TAREA" ReadOnly="true" />
                    <asp:BoundField HeaderText="NOMBRE TAREA" DataField="NOMBRE_TAREA" ReadOnly="true" />
                    <asp:BoundField HeaderText="RUT RESPONSABLE" DataField="RUT_ASIGNADO" ReadOnly="true" />
                    <asp:BoundField HeaderText="ESTADO" DataField="ESTADO_TAREA" ReadOnly="true" />

                    <asp:ButtonField runat="server" Text="Ver Reporte" CommandName="verReporte" ControlStyle-CssClass="btn btn- alert-info">
                        <ControlStyle CssClass="btn btn- alert-info"></ControlStyle>
                    </asp:ButtonField>


                    <asp:ButtonField runat="server" Text="Cerrar reporte" CommandName="cerrarReporte" ControlStyle-CssClass="btn btn-facebook">
                        <ControlStyle CssClass="btn btn-danger "></ControlStyle>
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
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
