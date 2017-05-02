function cargar() {
    cAyuda = document.getElementById("mensajesAyuda");
    cNombre = document.getElementById("ayudaTitulo");
    cTex = document.getElementById("ayudaTexto");
    ayuda = new Array();
    ayuda["Historia"] = "Numero de historia medica del paciente";
    ayuda["Cedula"] = "Indique la cedula del paciente";
    ayuda["Nombre"] = "Indique nombre(s) y apellido(s) del paciente";
    ayuda["Conyugal"] = "Seleccione la situacion conyugal actual del paciente";
    ayuda["Ocupacion"] = "Seleccione la ocupacion del paciente";
    ayuda["Fecha"] = "Fecha de nacimiento del paciente";
    ayuda["Edad"] = "Indique la edad del paciente";
    ayuda["Sexo"] = "Indique el sexo del paciente";
    ayuda["Direccion"] = "Indique la direccion del domicilio actual del paciente";
    ayuda["Ubicacion"] = "Ubicacion geografica del domicilio actual del paciente";
    ayuda["Telefono Fijo"] = "Indique el telefono de domicilio del paciente";
    ayuda["Telefono Movil"] = "Indique el telefono celular del paciente";
    ayuda["Correo"] = "Correo electronico (email) del paciente";
    ayuda["Herencia Padre"] = "Enfermedad que padece o haya padecido el padre que pueda ser hereditaria o adquirida por el paciente.";
    ayuda["Herencia Madre"] = "Enfermedad que padece o haya padecido la madre que pueda ser hereditaria o adquirida por el paciente.";
    ayuda["Herencia Hermanos"] = "Enfermedad que padece o haya padecido el hermano que pueda ser hereditaria o adquirida por el paciente.";
    ayuda["Tabaquismo"] = "Indique si el paciente es fumador";
    ayuda["Guardar"] = "Guardar datos del paciente";
    ayuda["Modificar"] = "Modificar datos del paciente";
    ayuda["Actualizar"] = "Actualizar datos del paciente";
    ayuda["Nuevo"] = "Agregar nuevo paciente";
    ayuda["Seleccionar"] = "Seleccionar fila para ser modificada, eliminada o editada";
    ayuda["Editar Fila"] = "Editar datos del paciente";
    ayuda["Eliminar"] = "Eliminar paciente";
    ayuda["Editar Registro"] = "Ver datos del paciente para ser modificados";
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