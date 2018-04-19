<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>Portal Web Comisariato</title>
        <!--        <LINK REL=StyleSheet HREF="Resources/Estilos/loginestilos.css" TYPE="text/css" MEDIA=screen>-->
        <!-- Bootstrap CSS CDN -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
        <LINK REL=StyleSheet HREF="Resources/Estilos/Principal.css" TYPE="text/css" MEDIA=screen>
    </head>
    <body>
        <div class="wrapper">
            <!-- Sidebar Holder -->
            <nav id="sidebar">
                <div class="sidebar-header"  style="border-bottom: ridge;">
                    <!--<h3>Comisariato Super 2</h3>-->
                    <h3><span><img src="Resources/Imagenes/superpng.png" width="250px" height="140px"></span></h3>
                    <strong><span><img src="Resources/Imagenes/superpng.png" width="110px" height="60px"></span></strong>
                </div>

                <ul class="list-unstyled components">
                    <li class="">
                        <!--data-toggle="collapse" aria-expanded="false"-->
                        <a href="#homeSubmenu">
                            <i class="glyphicon glyphicon-home"></i>
                            Inicio
                        </a>
                    </li>
                    <li>
                        <!--                            <a href="#">
                                                        <i class="glyphicon glyphicon-briefcase"></i>
                                                        Configuración
                                                    </a>-->
                        <a href="#comprobantesSubmenu" data-toggle="collapse" aria-expanded="false">
                            <i class="glyphicon glyphicon-duplicate"></i>
                            Comprobantes
                        </a>
                        <ul class="collapse list-unstyled" id="comprobantesSubmenu">
                            <li><a href="#" id="seccionfacturas">Ver facturas</a></li>
                            <li><a href="#" id="seccionretencion">Ver retenciones</a></li>
                        </ul>
                    </li>
                    <li>
                        <!--                            <a href="#">
                                                        <i class="glyphicon glyphicon-briefcase"></i>
                                                        Configuración
                                                    </a>-->
                        <a href="#pageSubmenu" data-toggle="collapse" aria-expanded="false">
                            <i class="glyphicon glyphicon-cog"></i>
                            Configuración
                        </a>
                        <ul class="collapse list-unstyled" id="pageSubmenu">
                            <li><a id="seccionsesion" href="#">Cambiar contraseña</a></li>
                        </ul>
                    </li>
                    <!--                        <li>
                                                <a href="#">
                                                    <i class="glyphicon glyphicon-link"></i>
                                                    Portafolio
                                                </a>
                                            </li>-->
                    <li>
                        <a href="#">
                            <i class="glyphicon glyphicon-off"></i>
                            Cerrar Sesión
                        </a>
                    </li>
                </ul>

            </nav>
            <!-- Page Content Holder -->
            <div id="content" >

                <nav class="navbar navbar-default">
                    <div class="container-fluid">

                        <div class="navbar-header">
                            <button type="button" id="sidebarCollapse" class="btn btn-info navbar-btn">
                                <i class="glyphicon glyphicon-align-left"></i>
                                <span></span>
                            </button>
                        </div>
                        <!--
                                                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                                                    <ul class="nav navbar-nav navbar-right">
                                                        <li><a href="#">Cerrar Sesion</a></li>
                                                    </ul>
                                                </div>-->
                    </div>
                </nav>
                <center>
                    <!--min-height: 95vh;-->
                    <div id="Contenido" style=" width: 300%;  padding-left: 10%; max-width: 160vh;">

                        <?php
//                contenido
                        ?>
                    </div>
                </center>
            </div>
        </div>

        <!-- jQuery CDN -->
        <script src="https://code.jquery.com/jquery-1.12.0.min.js"></script>
        <script src="Resources/Js/jquery.min.js"></script>
        <script src="Resources/Js/menu.js"></script>
        <!-- Bootstrap Js CDN -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

        <script type="text/javascript">
            $(document).ready(function () {
                $('#sidebarCollapse').on('click', function () {
                    $('#sidebar').toggleClass('active');
                });
            });
        </script>
    </body>
    <!--    <footer>
            <div class="pull-right hidden-xs">
                <b>Version</b> 2.3.0
            </div>
            <strong>Copyright &copy; 2018-2019 <a href="http://www.Google.com.ec">  Google  </a>.</strong> All rights reserved .
        </footer>-->
</html>
