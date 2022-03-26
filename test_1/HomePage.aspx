<%@ Page Title="" Language="C#" MasterPageFile="~/Tareas.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="test_1.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">

    <section class="content">
            <div class="row">
                <div class="col-md-12" align="center">
                    <div align="left">

                        <div class="bg-home" style="min-height: 80vh; position: relative;">
                            <div class="img-home">
                                <img src="images/lista-de-tareas-pendientes-1536x864.jpg" />
                            </div>

                            <h1 style="text-transform: uppercase; font-weight: bold;">Bienvenidos al control de Tareas de Process SA.</h1>
                            <div class="row service">

                                <div class="col-md-4 col-xs-12">
                                    <a href="/MisTareas.aspx">
                                        <div class="single">
                                            <i class="fas fa-portrait" aria-hidden="true"></i>
                                            <h3>Mis Tareas</h3>
                                            <p>Visualiza la gestión de tus tareas asignadas.</p>
                                        </div>
                                    </a>
                                </div>

                                <div class="col-md-4 col-xs-12">
                                    <a href="/PantallaCrearTareas.aspx">
                                        <div class="single">
                                            <i class="fas fa-plus-square" aria-hidden="true"></i>
                                            <h3>Crear Tareas</h3>
                                            <p>Podrás gestionar y asignar la creación de tareas a usuario.</p>
                                        </div>
                                    </a>
                                </div>

                                <div class="col-md-4 col-xs-12">
                                    <a href="/ProcesosPage.aspx">
                                        <div class="single">
                                            <i class="fas fa-file-medical" aria-hidden="true"></i>
                                            <h3>Crear Procesos</h3>
                                            <p>Podrás gestionar y asignar las tareas a esta creación de procesos</p>
                                        </div>
                                    </a>
                                </div>

                                <div class="col-md-6 col-xs-12">
                                    <a href="/MiDashboard.aspx">
                                        <div class="single">
                                            <i class="fas fa-chart-pie" aria-hidden="true"></i>
                                            <h3>Mi Dashboard</h3>
                                            <p>Podrás visualizar un gráfico de las tareas</p>
                                        </div>
                                    </a>
                                </div>

                                <div class="col-md-6 col-xs-12">
                                    <a href="/DashboardGeneral.aspx">
                                        <div class="single">
                                            <i class="fas fa-bar-chart" aria-hidden="true"></i>
                                            <h3>Dashboard Global</h3>
                                            <p>Podrás visualizar los gráficos de las tareas globales</p>
                                        </div>
                                    </a>
                                </div>


                            </div>

                        </div>
                    </div>
                </div>
            </div>
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <div class="footer-bottom">
        <p>copyright &copy;2021 ProcessSA. designed by <span>Process Sa</span></p>
    </div>
</asp:Content>
