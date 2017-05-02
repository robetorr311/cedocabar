function returnRefresh(returnVal) {
    window.document.reload();
}

function cargar() {
    cAyuda = document.getElementById("mensajesAyuda");
    cNombre = document.getElementById("ayudaTitulo");
    cTex = document.getElementById("ayudaTexto");
    ayuda = new Array();
    ayuda["Cedula"] = "Indique la cedula del medico";
    ayuda["Nombre"] = "Indique nombre(s) y apellido(s) del medico";
    ayuda["Numero MPPS"] = "Seleccione la situacion conyugal actual del medico";
    ayuda["Numero Colegio de Medicos"] = "Seleccione la ocupacion del medico";
    ayuda["Servicios"] = "Haz clic en el boton servicios para agignarle el servicio, el horario y el turno de trabajo del medico";
    ayuda["Seleccionar Servicio"] = "Selecciones el servicio a los que esta adscrito el medico";
    ayuda["Horario"] = "Indique el horario que en el cual atendera el servicio seleccionado";
    ayuda["Turno"] = "Indique el turno que en el cual atendera el servicio seleccionado";
    ayuda["Pacientes Mañana"] = "Indique la cantidad de personas que atendera para el servicio seleccionado";
    ayuda["Pacientes Tarde"] = "Indique la cantidad de personas que atendera para el servicio seleccionado";
    ayuda["Edad"] = "Indique la edad del medico";
    ayuda["Sexo"] = "Indique el sexo del medico";
    ayuda["Direccion"] = "Indique la direccion del domicilio actual del medico";
    ayuda["Ubicacion"] = "Ubicacion geografica del domicilio actual del medico";
    ayuda["Telefono Fijo"] = "Indique el telefono de domicilio del medico";
    ayuda["Telefono Movil"] = "Indique el telefono celular del medico";
    ayuda["Correo"] = "Correo electronico (email) del medico";
    ayuda["Guardar"] = "Guardar datos del medico";
    ayuda["Modificar"] = "Modificar datos del medico";
    ayuda["Actualizar"] = "Actualizar datos del medico";
    ayuda["Nuevo"] = "Agregar nuevo medico";
    ayuda["Seleccionar"] = "Seleccionar fila para ser modificada, eliminada o editada";
    ayuda["Editar Fila"] = "Editar datos del medico";
    ayuda["Eliminar"] = "Eliminar medico";
    ayuda["Editar Registro"] = "Ver datos del medico para ser modificados";
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
