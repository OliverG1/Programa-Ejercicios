using System;

namespace Software_ejercicios
{
    class Program
    {
        //Login

        string usuario;
        string contraseña;

        public void Login()

        {
            Console.WriteLine("---------Login---------");
            Console.WriteLine("ingrese el usuario");
            usuario = (Console.ReadLine());
            Console.WriteLine("Ingrese su contraseña");
            contraseña = (Console.ReadLine());
            Console.Clear();
        }
        public void Proceso()
        {
            if (usuario == "Jhon" && contraseña == "1234")
            {
                Console.WriteLine("Bienvenido " + usuario);
            }
            else
            {
                Console.WriteLine("Acsseso Denegado");
            }
            Console.ReadKey();
        }
        
            static void Main(string[] args)
            {
            Program pro = new Program();
            pro.Login();
            pro.Proceso();
            int opcion = 0;
            do
            {
                Console.WriteLine("¿Que desea?");
                Console.WriteLine("\n" +
                    "\n 1.- Informaciones Nutritivas? " +
                    "\n 2.- Aumentar masa corporea? " +
                    "\n 3.- Adelgazar masa corporea?" +
                    "\n 4.- Trabajar alguna area en Especifico" +              
                "\n5.-Salir \n");
                Console.WriteLine("Digite una opcion : ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    // Informaciones Nutritivas
                    case 1:
                        Console.WriteLine("Indicaciones Nutritivas");

                        break;
                    case 2:
                        Console.WriteLine("Indicaciones para umentar masa corporea");
                        // Aumentar masa corporea

                        break;
                    case 3:
                        Console.WriteLine("Adelgazar masa corporea");
                        // Aldegazar masa corporea

                        break; 

                    case 4:
                        Console.WriteLine("Trabajar alguna area en Especifico");
                        // Area de Trabajo

                        break;

                }
                Console.ReadKey();



            }
            while (opcion != 5);
        }
        }
    
}
