using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPiedraPapelTigera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
            string jugador1 = " ";
            string jugador2 = " ";
            string opcion1 = " ";
            string opcion2 = " ";


            Console.WriteLine("Ingrese el nombre del primer jugador:");
            jugador1 = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del segundo jugador:");
            jugador2 = Console.ReadLine();
            // Console.WriteLine("el nombres "+jugador1);
            Console.WriteLine("Ingresen las opciones PIEDRA, PAPEL O TIJERA");
            Console.WriteLine($"{jugador1} Ingresa tu opcion que quieras ");
            opcion1 = Console.ReadLine();
            Console.WriteLine($"{jugador2} Ingresa tu opcion que quieras ");
            opcion2 = Console.ReadLine();

            //logica de juego
            string resultados = resultado(opcion1, opcion2,jugador1,jugador2);
            Console.WriteLine("el resultado es :" + resultados);
            Console.ReadKey();
        }
    }
        //metodo
        static string resultado(string opcion1, string opcion2,string jugador1, string jugador2)
        {
            string res = "";
            if ((opcion1 == "piedra") && (opcion2 == "piedra"))
            {
                res = "Empate";
            }
            else if ((opcion1 == "piedra") && (opcion2 == "papel"))
            {
                res = $"Gano el papel. EL GANADOR ES: {jugador2}";
            } else if ((opcion1 == "piedra") && (opcion2 == "tijera"))
            {
                res = $"Gano la tijera. EL GANADOR ES:{jugador1}";
            } else if ((opcion1 == "papel") && (opcion2 == "papel"))
            {
                res = "Empate";
            } else if ((opcion1 == "papel") && (opcion2 == "tijera"))
            {
                res = $"Gano la tijera. EL GANADOR ES: {jugador2}";
            } else if ((opcion1 == "tijera") && (opcion2 == "tijera"))
            {
                res = " Empate";
            } else if ((opcion1 == "papel") && (opcion2 == "piedra"))
            {
                res = $"Gano el papel. EL GANADOR ES: {jugador1}";
            } else if ((opcion1 == "tijera") && (opcion2 == "piedra"))
            {
                res = $"Gano la piedra. EL GANADOR ES: {jugador2}";
            }
            else if ((opcion1 == "tijera") && (opcion2 == "papel"))
            {
                res = $"Gano la tijera. EL GANADOR ES: {jugador1}";
            }

            return res;
        }
    }

}