using System;
using System.Collections.Generic;
namespace StriingsPK
{
    class Program
    {

        static void Main() //Procedimiento principal para iniciar el código
        {
            IniciarPrograma();
        }
        static void IniciarPrograma() //Procedimiento que inicia el programa, mientras el programa esté encendido hará los siguientes apartados
        {

            bool apagar = false;
            bool ensenarMenu = true;

            while (!apagar)
            {
                if (ensenarMenu)
                    Menu();
                Console.WriteLine("Seleccione la opción deseada: ");
                int opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1: //Si seleccionamos la primera opción, entraremos en artículos
                        Articulos();
                        ensenarMenu = false;
                        apagar = true;
                        break;

                    case 2: //Si seleccionamos la segunda opción, entraremos en como contactar a la tienda
                        Contacto();
                        ensenarMenu = false;
                        apagar = true;
                        break;

                    case 3: //Si seleccionamos la tercera opción, saldremos del programa
                        Salida();
                        apagar = true;
                        break;
                    default: //Si seleccionamos cualquier caracter diferente a 1, 2 o 3, el programa volverá a mostrar el menú
                        Invalido();
                        ensenarMenu = true;
                        break;
                }
            }
        }


        static void Menu() //Procedimiento en el que se muestra las opciones disponibles a seleccionar del programa
        {
            Console.WriteLine("Menú principal:");
            Console.WriteLine("1. Artículos disponibles");
            Console.WriteLine("2. Documentación de contacto");
            Console.WriteLine("3. Salida del programa");

        }

        static void Articulos()//Procedimiento en el que se muestra los articulos de toda nuestra tienda disponible actualmente
        {
            
            bool volver = false;
            while (!volver)
            //Procedimiento que enseña la lista de articulos
            {
                Console.WriteLine("Lista de caracteres");
                Console.WriteLine("1. Guitarra Yamaha Pacifica 112V");
                Console.WriteLine("2. Amplificador Marshall MG10 Gold");
                Console.WriteLine("3. Púas Dunlop Tortex cualquier modelo");
                Console.WriteLine("4. Pedal CH-1 Super Chorus Marca Boss");
                Console.WriteLine("5. Cuerdas de guitarra eléctrica");
                Console.WriteLine("6. Pastillas Fender");
                Console.WriteLine("7. Guitarras Fender");
                Console.WriteLine("Seleccione el artículo de su interés: ");
                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)//Estructura alternativa 
                    {
                        case 1:
                            Console.WriteLine("Guitarra eléctrica económica con configuración de pastillas HSS y acabado negro, con palanca de tremolo a un precio de 320 euros.");
                            break;

                        case 2:
                            Console.WriteLine("Amplificador de guitarra eléctrica con canal limpio y otro de overdrive, se le puede configurar volumen, ganancia y contorno. Su precio es de 80 euros.");
                            break;

                        case 3:
                            Console.WriteLine("Modelos de púas Dunlop de mayor grosor a menor: ");
                            Console.WriteLine("Púas Dunlop Tortex Rojas de 0.50 mm a precio de 0.6 euros");
                            Console.WriteLine("Púas Dunlop Tortex Naranjas de 0.60 mm a precio de 0.6 euros");
                            Console.WriteLine("Púas Dunlop Tortex Amarillas de 0.73 mm a precio de 0.6 euros");
                            Console.WriteLine("Púas Dunlop Tortex Verdes de 0.88 mm a precio de 0.6 euros");
                            Console.WriteLine("Púas Dunlop Tortex Azules de 1 mm a precio de 0.6 euros");
                            Console.WriteLine("Púas Dunlop Tortex Moradas de 1.14 mm a precio de 0.6 euros");
                            break;

                        case 4:
                            Console.WriteLine("Pedal de efecto chorus capaz de moldear su velocidad, nivel y profundidad. Precio de 115 euros");
                            break;

                        case 5:
                            Console.WriteLine("Cuerdas de guitarra eléctrica calibre 0.8 por un precio de 7 euros.");
                            Console.WriteLine("Cuerdas de guitarra eléctrica calibre 0.9 por un precio de 7 euros.");
                            Console.WriteLine("Cuerdas de guitarra eléctrica calibre 0.10 por un precio de 7 euros.");
                            Console.WriteLine("Cuerdas de guitarra eléctrica calibre 0.11 por un precio de 7 euros.");
                            Console.WriteLine("Cuerdas de guitarra eléctrica calibre 0.12 por un precio de 7 euros.");
                            break;

                        case 6:
                            Console.WriteLine("Fender Custom Fat '50s Strat Pickups: Pastillas que single-coil con un sonido cálido y vintage de los años 50. Precio de 240 euros 3 pastillas. ");
                            Console.WriteLine("Fender Texas Special Strat Pickups: Pastillas diseñadas con un tono más agresivo para enfocarse en blues y rock. Precio de 200 euros. ");
                            Console.WriteLine("Fender Player Series Pickups: Pastillas con un equilibrio entre sonido vintage y más versátil. Precio de 130 euros por 3 pastillas.");
                            Console.WriteLine("Fender Noiseless Pickups: Pastillas Pastillas con el sonido clásico de las single-coil pero eliminando el sonido muerto que tiene. Precio de 180 euros.");
                            Console.WriteLine("Fender Vintage Noiseless Pickups: Pastillas de versión mejorada a las Noiseless. Precio de 220 euros. ");
                            Console.WriteLine("Fender Wide Range Humbucker: Pastillas humbucker con un tono sonido limpio pero potente. Precio de 130 euros por pastilla. ");
                            Console.WriteLine("Fender Enforcer Active Humbucker: Pastillas humbucker con un sonido agresivo y gran potencia de salida. Precio de 250 euros por pastilla. ");
                            break;
                        case 7:
                            Console.WriteLine("Fender Stratocaster Player II: Precio de 833 euros. ");
                            Console.WriteLine("Fender Telecaster Standard: Precio de 600 euros. ");
                            Console.WriteLine("Fender Player II Jaguar: Precio de 849 euros. ");
                            Console.WriteLine("Fender Player II Jazzmaster: Precio de 859 euros. ");
                            Console.WriteLine("Fender Player Mustang: Precio de 659 euros. ");
                            Console.WriteLine("Fender Player Duo-Sonic HS: Precio de 689 euros. ");
                            break;
                        default:
                            Invalido();
                            volver = true;
                            break;
                    }
                }
            }
        }
        static void Contacto() //Procedimiento que indica la información de contacto
        {
            Console.WriteLine("Le atendemos a través de striingspk@gmail.com");
            Console.WriteLine("Nos ubicamos en C/ Nueva, 85, 31001 Pamplona, Navarra");
            Console.WriteLine("Cualquier información se encuentra en nuestra página web www.striingspk.es");
        }

        static void Salida() //Procedimiento que indica la salida del programa
        {

            Console.WriteLine("El programa está siendo cerrado a solicitud del cliente...");

        }

        static void Invalido() //Procedimiento en el que la opcion señalada no existe y no es detectada por el programa
        {
            Console.WriteLine("La opción señalada no existe");
        }
    }
}














































        
          
    

