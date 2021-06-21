using System.Collections.Generic;
using System;


namespace autores
{ 
    public class Villano: Personaje
    {

        public Sentencia sentencia { get; set; }
        public Traslado traslado { get; set; }

        public void salto()
        {
            var salto = $"";
            Console.WriteLine(salto);
        }

        public void id()
        {
            var id = $"Satanas";
            Console.WriteLine(id);
        }

        public void crearVillano()
        {
            var presentacion = $"Bienvenido yo soy {this.Nombre}, ustedes los humanos me conocen como el {this.Apelativo} y si Dios no te acepto con el, es por que te mereces estar aqui en mi paraiso JAJAJA";
            Console.WriteLine(presentacion);
        }

        public void sentenciaVillano()
        {
            var presentacion = $"Por vengativo y asesino te quemarás por siempre por toda la eternidad como castigo, lo declaro {this.Nombre}"; 
            Console.WriteLine(presentacion);
        }

        public void trasladoVillano()
        {
            var presentacion = $"Se quedara en el {this.Lugar} por el resto de la eternidad";
            Console.WriteLine(presentacion);
        }

        public void dueloVillano()
        {
            var presentacion = $"Pierde y me llevó a tu padre de homenaje";
            Console.WriteLine(presentacion);
        }
        public void dueloInicioVillano()
        {
            var presentacion = $"Antes que nada te maldigo voy a hacer que sufras el peor de todos los castigos. Cómo te atreves a retarme en castellano y en este ritmo tan pobre. Como el suelo donde te has criado";
            Console.WriteLine(presentacion);
        }
    }
}
