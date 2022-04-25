using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro_prueba_3.Clase
{
    
    
        public class Carro
        {
            public string Marca { get; }
            public int Modelo { get; }

            public String Color { get; set; }

            private int Encendido = 0;
            private int velocidad_actual = 0;
            //private const int MAXVELOCIDAD = 250;
            public int MAXVELOCIDAD { get;  }


        public Carro(string _marca, int _modelo, string _color, int _maxvel)
            {
                Marca = _marca;
                Modelo = _modelo;
                Color = _color;
                Encendido = 0;
            MAXVELOCIDAD = _maxvel;
                this.velocidad_actual = 0;
            }



            public string acelerar()
            {
                if (Encendido == 0)
                {
                    return $"El carro esta apagado, asi no se puede";
                }


                string mensaje = "";
                if (velocidad_actual <= MAXVELOCIDAD)
                {
                    velocidad_actual += 20;
                    mensaje = $" {velocidad_actual} KPH";
                }
                else
                {
                    velocidad_actual = MAXVELOCIDAD;
                    mensaje = "Vas muy Rapido!!";
                }

                Console.WriteLine(mensaje);
                return mensaje;

            }



            public string acelerar(int AcekerarAkph)
            {
                if (Encendido == 0)
                {
                    return $"El carro esta apagado, asi no se puede";
                }


                string mensaje = "";
                if (velocidad_actual <= MAXVELOCIDAD)
                {
                    velocidad_actual += AcekerarAkph;
                    mensaje = $"vas a {velocidad_actual} KPH";
                }
                else
                {
                    velocidad_actual = MAXVELOCIDAD;
                    mensaje = "Exceso de Velocidad!!";
                }

                Console.WriteLine(mensaje);
                return mensaje;

            }



            public string GetVelocidadActual()
            {
                return $"VAmos a {velocidad_actual}KPH";
            }


            public string EncenderMotor()
            {
                if (Encendido == 0)
                {
                    Encendido = 1;
                    return"Encendiendo el auto !!";
                    return"Empezando a acelerar !!";
                    velocidad_actual = 0;

                }
                else
                {
                    return"ups el carro ya estaba encendido";
                }
            }






            public string DameInformacion()
            {
                return($"Soy un carro marca {Marca} y mi modelo es {Modelo}");
            }


            public string disminuir()
            {


                string mensaje = "";


                velocidad_actual -= 15;
                mensaje = $"vas a {velocidad_actual} KPH";






                //Console.WriteLine(mensaje);
                return mensaje;



            }

            public string Frenado()
            {


                string mensaje = "";
                if (velocidad_actual <= MAXVELOCIDAD)
                {
                    velocidad_actual = 0;
                    mensaje = $"vas a {velocidad_actual} KPH";
                }
                else
                {
                    velocidad_actual = MAXVELOCIDAD;
                    mensaje = "Frenando Auto";
                }

                //Console.WriteLine(mensaje);
                return mensaje;



            }





            public string Bocina()
            {


                string mensaje = "";



                mensaje = "beep!! beeeeep!!";


                //Console.WriteLine(mensaje);
                return mensaje;



            }

            public string apagado()//funcion de apagado
            {


                string mensaje = "";


                if (Encendido == 1)
                {
                    Encendido = 0;
                    mensaje = $"Has apagdo el motor del auto";
                }


                //Console.WriteLine(mensaje);//mensaje
                return mensaje;

            }


            public string marcamodelo()//caracteristicas
            {


                string mensaje = "";

                mensaje = "Caracateristicas del Automovinl: \nMarca: BMW M2 \nModelo: 2022 \nColor: Rojo \nVelocidad Maxima: 250 KP/H";

                //Console.WriteLine(mensaje);//mensaje
                return mensaje;



            }
        }


    
}
