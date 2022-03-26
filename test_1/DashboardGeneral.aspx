<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="DashboardGeneral.aspx.cs" Inherits="test_1.DashboardGeneral" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    
    <div runat="server" id="divPdf">
    <section class="content-header" style=" text-align: center">  
        <asp:Label ID="lblTitulo" runat="server" Text="REPORTE GENERAL" Font-Size="X-Large" Font-Bold="true"></asp:Label><br />
    </section>
   
    
    <section class="content">
            <div class="col-md-8" align="center">
                <div align="left">
                    <table>
                    </table>
                </div>
                <br />
                    
                <div class="box box-primary" align="left">
                    <div class="box-body" align="left">
                        <script src="https://cdnjs.cloudflare.com/ajax/libs/html2pdf.js/0.10.1/html2pdf.bundle.min.js" integrity="sha512-GsLlZN/3F2ErC5ifS5QtgpiJtWd43JWSuIgh7mbzZ8zBps+dvLusV+eNQATqgA/HdeKFVgA5v3S/cIrLF7QnIg==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
                        <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
                        <script type="text/javascript">
                            google.charts.load('current', { 'packages': ['corechart'] });
                            google.charts.setOnLoadCallback(drawMultSeries);

                            function drawMultSeries() {

                                var data = google.visualization.arrayToDataTable(<%=obtenerData()%>);

                                var options = {
                                    title: 'Total de tareas por cada empresa',
                                    width: 500,
                                    height: 350,
                                    hAxis: {
                                        title: 'Nombre de la empresa',
                                        format: 'h:mm a'

                                    },
                                    vAxis: {
                                        title: 'Total de tareas por empresa'
                                    }

                                };

                                var chart = new google.visualization.ColumnChart(
                                    document.getElementById('chart_div'));

                                chart.draw(data, options);
                            }

                        </script>
                        <div>
                            <div id="chart_div" style="width: 200px;"></div>
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
                    <div class="form-group" runat="server">
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="lblRut" runat="server" Visible="false" Text="a"></asp:Label>
                                <label>SELECCIONE EMPRESA</label>
                    </div>
                   <div class="form-group"  runat="server">
                        <asp:DropDownList ID="ddlEmpresa" runat="server" AutoPostBack="true"
                            CssClass="form-control" OnSelectedIndexChanged="ddlEmpresa_SelectedIndexChanged"
                            Style="text-align: center">
                        </asp:DropDownList>
                   </div>
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


     <div class="col-md-12" align="center">
            <div align="right">
                <table>
                </table>
            </div>
            <br />
            <div class="box box-primary" align="center">
                <div class="box-body" align="center">
                    <div class="form-group" runat="server">
                 
     <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript" >
        google.charts.load('current', { 'packages': ['table'] });
        google.charts.setOnLoadCallback(drawTable);

        function drawTable() {
            var data = new google.visualization.arrayToDataTable(<%=dataPorcentajeProceso()%>);


            var table = new google.visualization.Table(document.getElementById('table_div'));

            table.draw(data, { showRowNumber: true, width: '100%', height: '100%' });
        }
    </script>

    <section class="content-header" style=" text-align: left">  
        <asp:Label ID="Label1" runat="server" Text="Resumen de procesos por empresa" Font-Size="Medium" Font-Bold="true"></asp:Label>         <br />
    </section>
    <br />
    <div id="table_div"></div>

                    </div>
                </div>
            </div>
        </div>
        <%--    separación de tablas--%>

     <div class="col-md-12" align="center">
            <div align="right">
                <table>
                </table>
            </div>
            <br />
            <div class="box box-primary" align="center">
                <div class="box-body" align="center">
                    <div class="form-group" >
                 
     <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript" >
        google.charts.load('current', { 'packages': ['table'] });
        google.charts.setOnLoadCallback(drawTable);

        function drawTable() {

            var data = new google.visualization.arrayToDataTable(<%=dataPorcentajeTareas(lblRut.Text)%>);

            var table = new google.visualization.Table(document.getElementById('table_div1'));


            table.draw(data, { showRowNumber: true, width: '100%', height: '100%' });
        }
    </script>
                        
    <section class="content-header" style=" text-align: left">  
        <asp:Label ID="Label2" runat="server" Text="Resumen de tareas por empresa seleccionada" Font-Size="Medium" Font-Bold="true"></asp:Label>  <br />
    </section>
    <br />
    <div id="table_div1"></div>

                    </div>
                </div>
            </div>
        </div>
    
    </section>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

