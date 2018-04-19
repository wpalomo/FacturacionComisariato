/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
$(document).ready(function () {
    $("#seccionfacturas").click(function () {
        $("#Contenido").load('MVC/Vista/VistaFactura.php');
    });
    $("#seccionretencion").click(function () {
        $("#Contenido").load('MVC/Vista/VistaRetencion.php');
    }); 
    $("#seccionsesion").click(function () {
        $("#Contenido").load('MVC/Vista/VistaSesion.php');
    }); 
});
