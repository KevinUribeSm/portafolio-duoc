<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="MiDashboard.aspx.cs" Inherits="test_1.MiDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header" style=" text-align: center">  
        <asp:Label ID="lblTitulo" runat="server" Text="REPORTE INDIVIDUAL" Font-Size="X-Large" Font-Bold="true"></asp:Label><br />
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-12" align="center">
                <div align="left">
                    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
                    <script type="text/javascript">
                        google.charts.load('current', { 'packages': ['corechart'] });
                        google.charts.setOnLoadCallback(drawChart);

                        function drawChart() {

                            var data = google.visualization.arrayToDataTable(<%=obtenerData()%>);

                            var options = {
                                title: 'Estado de mis tareas',
                                align: 'center'
                            };

                            var chart = new google.visualization.PieChart(document.getElementById('piechart'));

                            chart.draw(data, options);
                        }
                    </script>
                    <div>
                        <div id="piechart" style="width: auto; height: 500px;"></div>
                    </div>
                </div>
            </div>
        </div>
        <%--separacion de charts--%>

        <div class="col-md-12" align="center">
            <div align="right">
                <table>
                </table>
            </div>
            <br />
            <div class="box box-primary" align="center">
                <div class="box-body" align="center">
                    <div class="form-group">
                 
     <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript" >
        google.charts.load('current', { 'packages': ['table'] });
        google.charts.setOnLoadCallback(drawTable);

        function drawTable() {

            var data = new google.visualization.arrayToDataTable(<%=dataPorcentajeTareasUsuario()%>);

            var table = new google.visualization.Table(document.getElementById('table_div1'));


            table.draw(data, { showRowNumber: true, width: '100%', height: '100%' });
        }
    </script>

    <section class="content-header" style=" text-align: left">  
        <asp:Label ID="Label2" runat="server" Text="Resumen de tareas y avance por proceso" Font-Size="Medium" Font-Bold="true"></asp:Label>         <br />
    </section>
    <br />
    <div id="table_div1"></div>

                    </div>
                </div>
            </div>
        </div>  
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>