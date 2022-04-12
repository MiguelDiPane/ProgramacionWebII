using System;
using Microsoft.AspNetCore.Mvc;

namespace proyecto.Controllers
{
    [Route("")] //Ruta raiz /
    public class AppController: Controller{
            
        [HttpGet] //verbo
        public IActionResult Form(){
            return View();
        }

        [HttpPost]
        public IActionResult Respuesta([FromForm] string nombre, [FromForm] string apellido){
            if(String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido)){
                string error = "Error: ";
                if(String.IsNullOrEmpty(nombre)){
                    error += "No ingresó el nombre. ";
                }
                if(String.IsNullOrEmpty(apellido)){
                    error += "No ingresó el apellido. ";
                }
                ViewBag.mensaje = error;
            } 
            else{
                string mensaje =  $"Nombre: {nombre} - Apellido: {apellido}";
                ViewBag.mensaje = mensaje;
            } 
            return View();
        }        
    }
}

