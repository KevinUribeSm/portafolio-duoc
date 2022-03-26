<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="ProcesosPage.aspx.cs" Inherits="test_1.ProcesosPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header" style=" text-align: center">  
        <asp:Label ID="lblTitulo" runat="server" Text="CREACIÓN DE PROCESOS" Font-Size="X-Large" Font-Bold="true"></asp:Label><br />
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6" align="center">
                  <div align="left">
            <table>

            </table>
        </div>
                <br />

                <div class="box box-primary" align="center">
                    <div class="box-body" align="center">
                       
                        <div class="form-group">
                            <label>NOMBRE PROCESO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtProceso" runat="server" Text="" CssClass="form-control" style="text-align: center"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>DESCRIPCIÓN PROCESO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDescProceso" runat="server" Text="" CssClass="form-control" Height="124px" TextMode="MultiLine" style="text-align: center"></asp:TextBox>

                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6" align="center">
                  <div align="right">
            <table>

            </table>
        </div>
                <br />
                <div class="box box-primary" align="center">
                    <div class="box-body" align="center">
                        <div class="form-group">
                            <label>FECHA INICIO PROCESO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtIniProceso" runat="server" Text="" CssClass="form-control" TextMode="Date" style="text-align: center"></asp:TextBox>

                        </div>
                        <div class="form-group">
                            <label>FECHA TERMINO PROCESO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtFechaFin" runat="server" CssClass="form-control" TextMode="Date" style="text-align: center" ></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>FECHA TERMINO REAL</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtFechaTerminoReal" runat="server" CssClass="form-control" TextMode="Date" ReadOnly="true" style="text-align: center" ></asp:TextBox>

                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnCrear" runat="server" Text="Crear" CssClass="btn btn-primary" Width="200px" OnClick="btnCrear_Click1" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="Cancelar" OnClick="btnCancelar_Click1" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
    </section>

    <div>
        <div class="col-md-12 col-md-offset-0" >
            <asp:GridView ID="procGrid" runat="server" CssClass="table"
                OnRowCommand="procGrid_RowCommand"
                OnRowEditing="procGrid_RowEditing"
                OnRowUpdating="procGrid_RowUpdating"
                OnRowDeleting="procGrid_RowDeleting"
                OnRowCancelingEdit="procGrid_RowCancelingEdit"
                DataKeyNames="ID_PROCESO"
                AutoGenerateColumns="False" HorizontalAlign="Center" Width="880px" OnSelectedIndexChanged="procGrid_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="IDENTIFICADOR" DataField="ID_PROCESO" ReadOnly="true"/>
                    
                    <asp:TemplateField HeaderText="NOMBRE">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("NOM_PROCESO") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox CssClass="txt" ID="txtProceso" runat="server" Text='<%# Bind("NOM_PROCESO") %>'></asp:TextBox>
                        </EditItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="DESCRIPCION">
                        <EditItemTemplate>
                            <asp:TextBox CssClass="txt" ID="TextBox2" runat="server" Text='<%# Eval("DESC_PROCESO") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("DESC_PROCESO") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="FECHA INICIO">
                        <EditItemTemplate>
                            <asp:TextBox CssClass="txt" ID="txtFechaInicio" runat="server" TextMode="Date" Text='<%# Eval("FECHA_INICIO") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblFechaInicio" runat="server" Text='<%# Bind("FECHA_INICIO") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                                        
                    <asp:TemplateField HeaderText="FECHA FIN">
                        <EditItemTemplate>
                            <asp:TextBox CssClass="txt" ID="txtFechaFin" runat="server" TextMode="Date" Text='<%# Eval("FECHA_FIN") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblFechaFin" runat="server" Text='<%# Bind("FECHA_FIN") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField HeaderText="FECHA_TERMINO_REAL FIN" DataField="FECHA_TERMINO_REAL" ReadOnly="true"/>
      
                    
                    
                    
                    <asp:BoundField HeaderText="ESTADO" DataField="ESTADO_PROCESO" ReadOnly="true"/>
                    <asp:CommandField ShowDeleteButton="true"
                        ControlStyle-CssClass="btn btn-danger"  HeaderText="" DeleteText="Activar" >
                    <ControlStyle CssClass="btn btn-danger"></ControlStyle>
                    </asp:CommandField>
                    <asp:CommandField ShowEditButton="true"
                        ControlStyle-CssClass="btn btn-primary" HeaderText="" >
                    <ControlStyle CssClass="btn btn-primary"></ControlStyle>
                    </asp:CommandField>
                    <asp:ButtonField runat="server" Text="Finaliza" CommandName="finalizarProceso" ControlStyle-CssClass="btn btn- alert-info" >
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
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
