<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="MisTareas.aspx.cs" Inherits="test_1.MistTareas"  EnableEventValidation = "false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">

    <section class="content-header" style=" text-align: center">
        <asp:Label ID="lblTitulo" runat="server" Text="LISTADO DE TAREAS" Font-Size="X-Large" Font-Bold="true"></asp:Label>
    </section>

    <section class="content-header" style=" text-align: right">
        <asp:Button ID="Button1" runat="server" Text="PDF" CssClass="btn btn-google-plus" Width="100px" OnClick="Button1_Click1" />
    </section>

      <br />
      <br />

    <section>
        <asp:GridView ID="TareasGrid" runat="server" CssClass="table"
            CellPadding="4" ForeColor="#333333" GridLines="None" Height="85px" AutoGenerateColumns="False"
            OnSelectedIndexChanged="TareasGrid_SelectedIndexChanged"
            OnRowCommand="TareasGrid_RowCommand"
            OnRowDeleting="TareasGrid_RowDeleting"
            OnRowCancelingEdit="TareasGrid_RowCancelingEdit"
            OnRowUpdating="TareasGrid_RowUpdating"
            OnRowEditing="TareasGrid_RowEditing"
            DataKeyNames="ID_TAREA">


            <Columns>

                <asp:BoundField HeaderText="Id Tarea" DataField="ID_TAREA" ReadOnly="true" />
                <asp:BoundField HeaderText="Nombre Tarea" DataField="NOMBRE_TAREA" ReadOnly="true" />
                <asp:BoundField HeaderText="Fecha Proceso" DataField="FECHA_PROCESO" ReadOnly="true" />
                <asp:BoundField HeaderText="Fecha Fin" DataField="FECHA_FIN" ReadOnly="true" />
                <asp:BoundField HeaderText="Descripcion de la tarea" DataField="DESCRIPCION_TAREA" ReadOnly="true" />
                <asp:BoundField HeaderText="Estado de la Tarea" DataField="ESTADO_TAREA" ReadOnly="true" />
                <asp:BoundField HeaderText="Fecha fin real" DataField="FECHA_TERMINO_REAL" ReadOnly="true" />
                <asp:BoundField HeaderText="Porcentaje" DataField="PORCENTAJE" ReadOnly="true" />
                <asp:BoundField HeaderText="Id Proceso" DataField="ID_PROCESO" ReadOnly="true" />
                <asp:BoundField HeaderText="Rut Creador" DataField="RUT_CREADOR_TARE" ReadOnly="true" />

                <asp:CommandField ShowDeleteButton="true"
                    ControlStyle-CssClass="btn btn-danger" HeaderText="" DeleteText="Reportar">
                    <ControlStyle CssClass="btn btn-danger"></ControlStyle>
                </asp:CommandField>

                <asp:ButtonField runat="server" Text="Finalizar" CommandName="finalizarProceso" ControlStyle-CssClass="btn btn- alert-info">
                    <ControlStyle CssClass="btn btn- alert-info"></ControlStyle>
                </asp:ButtonField>

                <asp:ButtonField runat="server" Text="Ver sub Tareas" CommandName="verSubTask" ControlStyle-CssClass="btn btn-facebook">
                    <ControlStyle CssClass="btn btn-twitter "></ControlStyle>
                </asp:ButtonField>
               
                <%--<asp:ButtonField runat="server" Text="PDF" CommandName="expPdf" ControlStyle-CssClass="btn btn- alert-info">
                    <ControlStyle CssClass="btn btn- alert-info"></ControlStyle>
                </asp:ButtonField>--%>

            </Columns>
            <AlternatingRowStyle BackColor="White" />

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
            
    </section>

    <section>
          <section class="content-header" style=" text-align: center">
        <asp:Label ID="lblTituloSubTarea" runat="server" Text="LISTADO DE SUB TAREAS" Font-Size="X-Large" Font-Bold="true"></asp:Label>
    </section>
      <br />
      <br />
        <asp:GridView ID="gdvSubTareas" runat="server" CssClass="table"
            CellPadding="4" ForeColor="#333333" GridLines="None" Height="85px" AutoGenerateColumns="False"
            OnSelectedIndexChanged="TareasGrid_SelectedIndexChanged"
            OnRowCommand="subTareasGrid_RowCommand"
            OnRowDeleting="subTareasGrid_RowDeleting"
            DataKeyNames="ID_TAREA">

            <Columns>

                <asp:BoundField HeaderText="Id Sub Tarea" DataField="ID_TAREA" ReadOnly="true" />
                <asp:BoundField HeaderText="Nombre Sub Tarea" DataField="NOMBRE_TAREA" ReadOnly="true" />
                <asp:BoundField HeaderText="Fecha Proceso" DataField="FECHA_PROCESO" ReadOnly="true" />
                <asp:BoundField HeaderText="Fecha Fin" DataField="FECHA_FIN" ReadOnly="true" />
                <asp:BoundField HeaderText="Descripcion de la Sub Tarea" DataField="DESCRIPCION_TAREA" ReadOnly="true" />
                <asp:BoundField HeaderText="Estado de la Sub Tarea" DataField="ESTADO_TAREA" ReadOnly="true" />
                <asp:BoundField HeaderText="Fecha fin real" DataField="FECHA_TERMINO_REAL" ReadOnly="true" />
                <asp:BoundField HeaderText="Porcentaje" DataField="PORCENTAJE" ReadOnly="true" />

                <asp:CommandField ShowDeleteButton="true"
                    ControlStyle-CssClass="btn btn-danger" HeaderText="" DeleteText="Reportar">
                    <ControlStyle CssClass="btn btn-danger"></ControlStyle>
                </asp:CommandField>

                <asp:ButtonField runat="server" Text="Finalizar" CommandName="finalizarProceso" ControlStyle-CssClass="btn btn- alert-info">
                    <ControlStyle CssClass="btn btn- alert-info"></ControlStyle>
                </asp:ButtonField>

      

            </Columns>
            <AlternatingRowStyle BackColor="White" />

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
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
