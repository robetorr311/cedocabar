function returnRefresh(returnVal) {
    window.document.reload();
}

function cargar() {
    cAyuda = document.getElementById("mensajesAyuda");
    cNombre = document.getElementById("ayudaTitulo");
    cTex = document.getElementById("ayudaTexto");
    ayuda = new Array();
    ayuda["Cedula"] = "Indique la cedula del cajero";
    ayuda["Nombre"] = "Indique nombre(s) y apellido(s) del cajero";
    ayuda["Direccion"] = "Indique la direccion del domicilio actual del cajero";
    ayuda["Ubicacion"] = "Ubicacion geografica del domicilio actual del cajero";
    ayuda["Telefono Fijo"] = "Indique el telefono de domicilio del cajero";
    ayuda["Telefono Movil"] = "Indique el telefono celular del cajero";
    ayuda["Correo"] = "Correo electronico (email) del cajero";
    ayuda["Guardar"] = "Guardar datos del cajero";
    ayuda["Modificar"] = "Modificar datos del cajero";
    ayuda["Actualizar"] = "Actualizar datos del cajero";
    ayuda["Nuevo"] = "Agregar nuevo cajero";
    ayuda["Seleccionar"] = "Seleccionar fila para ser modificada, eliminada o editada";
    ayuda["Editar Fila"] = "Editar datos del cajero";
    ayuda["Eliminar"] = "Eliminar cajero";
    ayuda["Editar Registro"] = "Ver datos del cajero para ser modificados";
    ayuda["Cancelar"] = "Cancelar cambios";
}
if (navigator.userAgent.indexOf("MSIE") >= 0) navegador = 0;
else navegador = 1;
function colocaAyuda(event) {
    if (navegador == 0) {
        var corX = window.event.clientX + document.documentElement.scrollLeft;
        var corY = window.event.clientY + document.documentElement.scrollTop;
    }
    else {
        var corX = event.clientX + window.scrollX;
        var corY = event.clientY + window.scrollY;
    }
    cAyuda.style.top = corY + 20 + "px";
    cAyuda.style.left = corX + 15 + "px";
}
function ocultaAyuda() {
    cAyuda.style.display = "none";
    if (navegador == 0) {
        document.detachEvent("onmousemove", colocaAyuda);
        document.detachEvent("onmouseout", ocultaAyuda);
    }
    else {
        document.removeEventListener("mousemove", colocaAyuda, true);
        document.removeEventListener("mouseout", ocultaAyuda, true);
    }
}
function muestraAyuda(event, campo) {
    colocaAyuda(event);

    if (navegador == 0) {
        document.attachEvent("onmousemove", colocaAyuda);
        document.attachEvent("onmouseout", ocultaAyuda);
    }
    else {
        document.addEventListener("mousemove", colocaAyuda, true);
        document.addEventListener("mouseout", ocultaAyuda, true);
    }

    cNombre.innerHTML = campo;
    cTex.innerHTML = ayuda[campo];
    cAyuda.style.display = "block";
}
function ocultaMensaje() {
    divTransparente = document.getElementById("transparencia");
    divMensaje = document.getElementById("transparenciaMensaje");
    divTransparente.style.display = "none";
}

function muestraMensaje(mensaje) {
    divTransparente = document.getElementById("transparencia");
    divMensaje = document.getElementById("transparenciaMensaje");
    divMensaje.innerHTML = mensaje;
    divTransparente.style.display = "block";
}
