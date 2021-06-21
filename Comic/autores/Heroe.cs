using System.Collections.Generic;
using System;

namespace autores
{
    public class Heroe : Personaje
    {
        public string Apellido { get; set; }  
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaFallecimiento { get; set; }
        public bool Musico { get; set; }    
        public void salto()
        {
            var salto = $"";
            Console.WriteLine(salto);
        }

        public void id()
        {
            var id = $"Canserbero";
            Console.WriteLine(id);
        }
        public void crearPersonaje()
        {
            var presentacion = $"Mi nombre es {this.Nombre} {this.Apellido}, mas conocido como {this.Apelativo}, tengo {this.Edad} años y soy {this.Nacionalidad}, nacido el {this.FechaNacimiento} y felleci hoy {this.FechaFallecimiento}. es por eso que estoy frente a ti.";
            Console.WriteLine(presentacion);
        }

        public void respuestaPersonaje()
        {
            var presentacion = $"Me desperté ya sentado sobre un estrado, Y un jurado de malvados decidirían mi suerte";
            Console.WriteLine(presentacion);
        }

        public void trasladoPersonaje()
        {
            var presentacion = $"Despues de la sentencia solo recuerdo que fui golpeado y trasladado a un sitio en uno de los círculos con un montón de gente";
            Console.WriteLine(presentacion);
        }

        public void dueloPersonaje()
        {
            var presentacion = $"Debo hallar ahora una manera de huir de la muerte, recordé que en la tierra donde había nacido, existía una leyenda del Diablo con un tal Florentino, obviamente un cuento pero inteligente, para irme de este infierno, infierno literalmente, vociferé durante meses que podía con el jefe, recitando versos entre fuego y heces, hasta que un día apareció un viejo con traje que dijo";
            Console.WriteLine(presentacion);
        }

        public void duelo1Personaje()
        {
            var presentacion = $"Había compuesto demasiados versos, que más la improvisación harían templar al universo empieza";
            Console.WriteLine(presentacion);
        }

        public void dueloInicioPersonaje()
        {
            var presentacion = $"Con más razón tu deberías avergonzarte, perder un combate con un homosapiens. Además te explico, se llama Venezuela donde nació este tipo. Y tú no puedes maldecirme porque ya yo estoy maldito";
            Console.WriteLine(presentacion);
        }
    }
}
