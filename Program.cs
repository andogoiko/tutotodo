using static System.Console; //te ahorras poner Console siempre

WriteLine("Hello World!");


var sistema = new Sistema();
var vista = new Vista();
var controlador = new Controlador(sistema, vista);