<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<?php
// put your code here
?>
<center>
    <div id="seccion" style=" width: 100%;  padding: 50px; ">
        <div class="panel panel-primary">
            <div class="panel-heading"><h3>Facturas</h3></div>
            <div class="panel-body">
                <p>Detalle de las faturas realizadas:</p>
                <div id="divformulario"  >
                    <form class="form-inline" role="form">
                        <div class="form-group">
                            <label  for="factura_N">Nº de factura:</label>
                            <input type="text" class="form-control" id="NFactura"
                                   placeholder="Nº de factura">
                        </div>
                        <div class="form-group">
                            <label  for="fechadesde">Desde:</label>
                            <input type="date" class="form-control" id="FechaDesde" 
                                   placeholder="Desde">
                        </div>
                        <div class="form-group">
                            <label  for="fechahasta">Hasta:</label>
                            <input type="date" class="form-control" id="FechaHasta" 
                                   placeholder="Hasta">
                        </div>
                        <button type="submit" class="btn btn-default">Buscar</button>
                    </form>
                </div>
            </div>
            <div class="table-responsive" >
                <div>
                    <table class="table table-bordered">
                        <thead>
                            <!-- Aplicadas en las filas -->
                            <tr class="active">
                                <td>Fecha</td>
                                <td>N° de factura</td>
                                <td>N° de comprobante</td>
                                <td style="text-align: center;">PDF</td>
                                <td style="text-align: center;">XML</td>
                            </tr>
                        </thead>
                        <tbody>
         <!-- Aplicadas en las celdas (<td> o <th>) -->
                            <tr>
                                <td style="padding-top: 12px">Contenido</td>
                                <td style="padding-top: 12px">Contenido</td>
                                <td style="padding-top: 12px">1201325465458795632102356478965412301356879546321</td>
                                <td style="text-align: center;"><a href="#"><span><img src="Resources/Imagenes/pdf.png" width="40px" height="30px"></span></a></td>
                                <td style="text-align: center;"><a href="#"><span><img src="Resources/Imagenes/xml.png" width="40px" height="30px"></span></a></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <ul class="pager">
                    <li class="previous"><a href="#">&larr; Anterior</a></li>
                    <li class="next"><a href="#">Siguiente &rarr;</a></li>
                </ul>
            </div>
        </div>
    </div>
</center>