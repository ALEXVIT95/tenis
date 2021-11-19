using System;

namespace Tenis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] puntos = { "0", "15", "30", "40", "40+1", "40+2" };
            bool ganador = false;
            int jugador1 = 0, jugador2 = 0;

            while (!ganador)
            {
                Random rand = new();
                int JugadorPunto = rand.Next(3);
                if (JugadorPunto != 0 || JugadorPunto != 3)
                {
                    if (JugadorPunto == 1)
                    {
                        jugador1++;
                    }
                    if (JugadorPunto == 2)
                    {
                        jugador2++;
                    }
                    Console.WriteLine("Jugador1: " + puntos[jugador1]);
                    Console.WriteLine("Jugador2: " + puntos[jugador2]);
                    if (jugador1 > jugador2 + 1)
                    {
                        Console.WriteLine("Jugador1 Ganador");
                        ganador = true;
                    }
                    if (jugador2 > jugador1 + 1)
                    {
                        Console.WriteLine("Jugador2 Ganador");
                        ganador = true;
                    }
                    if (jugador2 == jugador1 + 1 && jugador1 == 3)
                    {
                        Console.WriteLine("Jugador2 Avantage");

                    }
                    if (jugador1 == jugador2 + 1 && jugador2 == 3)
                    {
                        Console.WriteLine("Jugador1 Avantage");
                    }
                    if (jugador1 == jugador2 && jugador1 == 3)
                    {
                        Console.WriteLine("Deuce");
                        if (jugador1 == 4)
                        {
                            jugador1 = jugador2 = 3;
                        }
                    }
                }

            }
        }
    }
}
