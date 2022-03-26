<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="PantallaListadoTareasCreador.aspx.cs" Inherits="test_1.PantallaListadoTareasCreador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
        
    <section class="content-header" style=" text-align: center">
        <asp:Label ID="lblTitulo" runat="server" Text="LISTADO DE TAREAS" Font-Size="X-Large" Font-Bold="true"></asp:Label>
        <br />
    </section>
    <br />
     <div class="col-md-12" align="center">
                  <div align="right">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" CssClass="btn btn-success" Width="160px" Text=" Ir a tareas reportadas" OnClick="Button2_Click" />

                    </td>
                </tr>
            </table>
        </div>
           <br />
     <section class="content">
    <div class="col-md-12 col-md-offset-0">
        <asp:GridView ID="gdvListadoTareas" runat="server" CssClass="table  table-responsive"  HorizontalAlign="Center"
            OnRowEditing="onrowediting_RowEditing"
            OnRowUpdating="gdvListadoTareas_RowUpdating"
            OnRowCancelingEdit="gdvListadoTareas_RowCancelingEdit"
            OnRowDeleting="gdvListadoTareas_RowDeleting"
            DataKeyNames="ID_TAREA"
            AutoGenerateColumns="False"
            OnSelectedIndexChanged="gdvListadoTareas_SelectedIndexChanged"
            OnRowCommand="gdvListadoTareas_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
     

            <AlternatingRowStyle BackColor="White" />
     

            <Columns>
                <asp:TemplateField HeaderText="SELECCIONA PARA EDITAR">
                    <ItemTemplate>
                        <asp:CheckBox ID="Chk" runat="server" OnCheckedChanged="Chk_CheckedChanged" AutoPostBack="true" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="ID TAREA" DataField="ID_TAREA" />
                <asp:BoundField HeaderText="NOMBRE TAREA" DataField="NOMBRE_TAREA" />
                <asp:BoundField HeaderText="DESCRIPCIÓN TAREA" DataField="DESCRIPCION_TAREA" />
                <asp:BoundField HeaderText=" FECHA INICIO TAREA" DataField="FECHA_PROCESO" />
                <asp:BoundField HeaderText="FECHA FIN TAREA" DataField="FECHA_FIN" />
                <asp:BoundField HeaderText="ESTADO TAREA" DataField="ESTADO_TAREA" />
                <asp:BoundField HeaderText="ID_PROCESO" DataField="ID_PROCESO" />
                <asp:BoundField HeaderText="RUT RESPONSABLE" DataField="RUT_ASIGNADO" />
                <asp:BoundField HeaderText="NOMBRE RESPONSABLE" DataField="NOMBRE_RESPONSABLE" />
                <asp:ButtonField runat="server" Text="Crear sub Tarea" CommandName="crearSubTask" ControlStyle-CssClass="btn btn-danger" >
<ControlStyle CssClass="btn btn-danger"></ControlStyle>
                </asp:ButtonField>
                <asp:ButtonField runat="server" Text="ver SubTareas" CommandName="ListarSubtask" ControlStyle-CssClass="btn btn- alert-info" >
                  

<ControlStyle CssClass="btn btn- alert-info"></ControlStyle>
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


         <section class="content">
    <div class="col-md-12 col-md-offset-0">

            <div class="box box-primary" align="center">
                <div class="box-body" align="center">
                    <div class="form-group">
                        <label>ID TAREA</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtidTarea" runat="server" Text="" CssClass="form-control" ReadOnly="true" style="text-align: center"></asp:TextBox>
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
                        <asp:TextBox ID="txtDescripcionTarea" runat="server" Text="" CssClass="form-control" Height="124px" TextMode="MultiLine" style="text-align: center"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <label>FECHA INICIO TAREA</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtFechaIniTarea" runat="server" CssClass="form-control" TextMode="Date" style="text-align: center" ></asp:TextBox>
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
                        <asp:DropDownList ID="ddlResponsable" runat="server" CssClass="form-control" style="text-align: center"></asp:DropDownList>

                    </div>
                </div>
            </div>
    </div>
             </section>
 
    

        <div align="center">
            <table>
                <br />
                <tr>
                    <td>
                        <asp:Button ID="btnCrear" runat="server" Text="ACTUALIZAR" CssClass="btn btn-github" Width="200px" OnClick="btnCrear_Click1" />
                        
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="CANCELAR" OnClick="btnCancelar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    <br />
    <br />
    <br />

   
    </div>
         </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
