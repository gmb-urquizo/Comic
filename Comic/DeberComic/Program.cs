using System.Collections.Generic;
using System;
using autores;

namespace DeberComic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ES EPICO");
            Console.WriteLine("CASERBERO");

            
            var personaje = new Heroe
            {
                Nombre = "Tirone",
                Apellido = "González",
                Apelativo = "Canserbero",
                Edad = 26,
                Nacionalidad = "venezolano",
                FechaNacimiento = "11 de marzo de 1988",
                FechaFallecimiento = "20 de enero de 2015",
                Musico = true,
                
            };
            personaje.salto();
            personaje.id();
            personaje.crearPersonaje();

            var sentencia = new Villano
            {
                Nombre = "culpable"
            };

            var traslado = new Villano
            {
                Lugar = "infierno"
            };

            var contrincante = new Villano
            {
                Nombre = "Satanas",
                Apelativo = "Diablo",
                
            };
            contrincante.salto();
            contrincante.id();
            contrincante.crearVillano();

            personaje.salto();
            personaje.id();
            personaje.respuestaPersonaje();

            contrincante.salto();
            contrincante.id();
            sentencia.sentenciaVillano();

            personaje.salto();
            personaje.id();
            personaje.trasladoPersonaje();

            contrincante.salto();
            contrincante.id();
            traslado.trasladoVillano();

            personaje.salto();
            personaje.id();
            personaje.dueloPersonaje();

            contrincante.salto();
            contrincante.id();
            contrincante.dueloVillano();

            personaje.salto();
            personaje.id();
            personaje.duelo1Personaje();

            contrincante.salto();
            contrincante.id();
            contrincante.dueloInicioVillano();

            personaje.salto();
            personaje.id();
            personaje.dueloInicioPersonaje();
        }
    }
}
