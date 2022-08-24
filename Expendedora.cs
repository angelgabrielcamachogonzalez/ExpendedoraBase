using System;
using System.Threading;
namespace ExpendedoraBase
{
    class Expendedora
    {
        //atributos
        string marca;
        byte temperatura;
        string codigo;
        float precio;
        public Expendedora()
            {
                Saludar();
                marca = "\t \tAMS";
                Console.WriteLine("\t \tMarca :" + marca);
                ControlarTiempoDisplay();
                temperatura = 14;
                Console.WriteLine("\t \tLa temperatura es: " + temperatura+"°C");
                ControlarTiempoDisplay();
                codigo = MostrarCodigoDeProductos();
                MostrarPrecio(codigo);

            }
        //Aquí crearemos los métodos con un VOID
        void ControlarTiempoDisplay()
            {
            Thread.Sleep(1500);
            Console.Clear();
            }
        
        void Saludar()
            {
                Console.WriteLine("\t \tBienvenido");
                //Cómo le hago para que el ususario vea el saludo? , cuándo lo debe mostrar?
                //se necesita un constructor, que debe llamarse igual que la clase 
            }
        string MostrarCodigoDeProductos()
            {
               Console.WriteLine("\n\tA1: Kinder Delice \tB2: Takis Fuego \tC3: Donitas"); 
               Console.WriteLine("\n \tEscribe el código del producto que desea adquirir"); 
               string codigo = Console.ReadLine(); //Aquí tenemos dos "codigos", ero ahora el primero es un atributo, este de aquí es una variable
                                                   //de tipo local,que se encuentra dentro del método ( o en su caso ciclo de control)
               return codigo;
            } 
        void MostrarPrecio(string codigo)
            {
                switch (codigo)
                {
                    case "A1":
                        Console.WriteLine("\t \tEl precio es {0}", precio);
                        break;
                    case "B2":
                        Console.WriteLine("\t \tEl precio es {0}", precio);
                        break;
                    case "C3":
                        Console.WriteLine("\t \tEl precio es {0}", precio);
                        break;
                    default:
                        Console.WriteLine("\t \tProducto NO reconocido");
                        break;

                }
            }
    }
 }                                          
