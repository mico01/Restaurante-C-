using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace Restaurante_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a mi resturante!");
            Console.WriteLine("Esto es el menu de hoy:");
            /*
            var euro5 = 5;
            var euro10 = 10;
            var euro20 = 20;
            var euro50 = 50;
            var euro100 = 100;
            var euro200 = 200;
            var euro500 = 500;
            var precioTotPagar = 0;
            */
            string [] menuRestaurante = { "carbonara", "lasagna", "gnocchi", "spaghetti", "tiramisu" };
            int[] precioPlatos = { 10, 15, 20, 25, 5 };

            List<string> menu = new List<string>();
            List <int> precio = new List<int>();
            //  ciclo foreach x insertar valores
            foreach (var i in menuRestaurante)
            { 
                menu.Add(i);
            }
             
            foreach (var i in precioPlatos)
            { 
                precio.Add(i);
            }
 
            //  console menu y precio
            Console.WriteLine(menu[0]+"..."+precio[0]+" euro");
            Console.WriteLine(menu[1]+"...  "+precio[1]+ " euro");
            Console.WriteLine(menu[2]+"...  "+precio[2]+ " euro");
            Console.WriteLine(menu[3]+"..."+precio[3]+" euro");
            Console.WriteLine(menu[4]+"... "+precio[4]+" euro");

            Console.WriteLine("Hace tu pedido, premi Q por terminar: ");
            // pedido con ciclo WHILE         
            var pedido = new List<string>();
            var finePedido = true;
            while (finePedido)
            {
                var x = Console.ReadLine();
                if (x == "Q")
                {
                    break;
                }
                else
                {

                }
                pedido.Add(x);
            }        
            //  console pedido
            Console.WriteLine(" has pedido:");
            foreach (var i in pedido)
            {
                Console.WriteLine("-" + i);
            }
            //  > hacer una function x confirmar  
            Console.WriteLine(" Confirmar el pedido:  s/n");
            var confirmaPedido = Console.ReadLine();
            if (confirmaPedido == "s")
            {
                Console.WriteLine(" Muy bien!");
            }
            else
            {
                Console.WriteLine(" Confirmar el pedido:  S/N");

            }
            
            Console.WriteLine("--------");
            //  pedido no corecto
            var pedidoNo = pedido.Except(menu).ToList();
            foreach (var i in pedidoNo)
            {
                Console.WriteLine("Estos platos no estan en el menu: " + i);
            }
            //  pedido corecto
            var pedidoSi = pedido.Where(i => menu.Contains(i)).ToList();

            var cuenta = new List<int>();
            //  insertar indice precio
            foreach (var x in pedidoSi)
            {
                if(x == menu[0])
                {   var indice = precio[0];
                    cuenta.Add(indice); 
                }
                if (x == menu[1])
                {
                    var indice = precio[1];
                    cuenta.Add(indice);
                }
                if (x == menu[2])
                {
                    var indice = precio[2];
                    cuenta.Add(indice);
                }
                if (x == menu[3])
                {
                    var indice = precio[3];
                    cuenta.Add(indice);
                }
                if (x == menu[4])
                {
                    var indice = precio[4];
                    cuenta.Add(indice);
                }
            }
             
            foreach (var j in pedidoSi)
            {
                Console.WriteLine("Has pedido: "+ j);
 
            }
            
            Console.WriteLine("Tu cuenta a pagar es: "+ cuenta.Sum());

        }
    }
}
