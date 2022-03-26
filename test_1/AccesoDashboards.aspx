<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccesoDashboards.aspx.cs" Inherits="test_1.AccesoDashboards" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <asp:PlaceHolder ID="head" runat="server">
        <link href="styles/master.css" rel="stylesheet" />
    </asp:PlaceHolder>
</head>
<body>
    <div class="container">
        <div class ="header">
            <img class="img-logo" src="Images/LOGO TAREAS.png" />
            <ul class="menu">
                <li><a href="PantallaAdmin.aspx">Inicio</a>*</li>
                <li><a href="WebForm1.aspx">Cerrar Sesión</a>¤</li>
    <form id="form1" runat="server">
        <div>
            <div id="cabecera">
                <div id="contenidoCabecera">
                    <div id="barraHorizontal">

                    </div>
                    <div id="logotipo">

                    </div>
                    <div id="titulo" style="text-align:center">
                        <body style="background: -webkit-linear-gradient(90deg, lightgray 25%, lightsteelblue 75%)">
                            <header style=""background-color: black; color: white; text-align:center">

                            </header>
                        <h1>Acceso a Dashboards</h1>
                        <img class="img-col" src="Images/IMG.accesoDashboard.PNG" alt="Alternate Text" />
                        <h2>Puedes elegir las opciones de privacidad que mas te convengan.</h2>
                             <button class="btn btn-success" type="submit" name="btn1"><span class="glyphicon glyphicon-save"> EDITAR PROCESOS</span</>
                                  
                                <button style="margin:0 25px;" class="btn btn-primary" type="reset" name="btn2"><span class="glyphicon glyphicon-remove"> AGREGAR PROCESOS</span</>
                                            <button class="btn btn-success" type="submit" name="btn1"><span class="glyphicon glyphicon-save"> RESERVAR PROCESOS</span</>

                    </div>
                </div>

            </div>

            <div id="bajo">

                <div id="columnaIzq">
                    <asp:PlaceHolder ID="contenidoMenuContextual" runat="server">

                    </asp:PlaceHolder>

                </div>
                <div id="columnaCentro">

                    <asp:PlaceHolder ID="contenidoPrincipal" runat="server">

                    </asp:PlaceHolder>

                </div>
                <div id="columnaDer">

                </div>
                <div id="pie">

                </div>
            </div>
            
        </div>
    </form>
</body>
</html>
