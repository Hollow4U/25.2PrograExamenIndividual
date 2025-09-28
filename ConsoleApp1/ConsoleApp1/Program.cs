using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        internal static Bases player = new Bases(0, 100);
        internal static Bases enemy = new Bases(1000000, 100);

        internal static DamageUnit _damageUnit = new DamageUnit(10, true); //Guerrero aliado
        internal static ResourceUnit _resourceUnit = new ResourceUnit(10, true); //Trabajador aliado

        internal static DamageUnit _damageUnitE = new DamageUnit(10, false); //Guerrero enemigo

        internal static List<Units> _allyUnits = new List<Units>();
        internal static List<Units> _enemyUnits = new List<Units>();
       
        static void Main(string[] args)
        {
            int fibPrev = 0; 
            int fibCurr = 1;
            bool turnBegins = true;

            Console.WriteLine("START");

            int turn = 1;
            while (player._hp > 0)
            {
                while (turnBegins)
                {
                    Console.WriteLine($"Turno {turn}");
                    Console.WriteLine("Turno del Jugador");
                    player.RecolectResources();
                    Console.WriteLine("El jugador gano 10 monedas");
                    foreach (Units u in new List<Units>(Program._allyUnits))
                    {
                        if (u is ResourceUnit ru)
                        {
                            ru.Generate();
                            Console.WriteLine($"{ru} generó recursos para el jugador.");
                        }
                    }
                    turnBegins = false;
                }
                bool pasarTurno = false;

                while (!pasarTurno)
                {
                    Console.WriteLine("___________________");
                    Console.WriteLine("1. Reclutar Guerrero (10)");
                    Console.WriteLine("2. Reclutar Trabajador(5)");
                    Console.WriteLine("3. Pasar turno");
                    Console.WriteLine("Elige una opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            if (player._resource >= 10)
                            {
                                player._resource -= 10;
                                _allyUnits.Add(_damageUnit);
                                Console.WriteLine("Has reclutado un Guerrero.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No tienes las monedas necesarias");
                                break;
                            }
                        case "2":
                            if (player._resource >= 5)
                            {
                                player._resource -= 5;
                                _allyUnits.Add(_resourceUnit);
                                Console.WriteLine("Has reclutado un Trabajador.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No tienes las monedas necesarias");
                                break;
                            }
                        case "3":
                            foreach (Units u in new List<Units>(Program._allyUnits))
                            {
                                if (u is DamageUnit duUnit)
                                {
                                    duUnit.Damage();
                                }
                            }
                            pasarTurno = true;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }

                }

                Console.WriteLine("Turno del enemigos");
                int unitsToCreate = fibPrev;
                fibPrev = fibCurr;
                fibCurr = fibCurr + unitsToCreate;

                for (int i = 0; i < unitsToCreate; i++)
                {
                    _enemyUnits.Add(new DamageUnit(10, false));
                    Console.WriteLine("El enemigo ha creado una nueva unidad.");
                }

                foreach (Units e in new List<Units>(_enemyUnits))
                {
                    if (e is DamageUnit du)
                    {
                        if (_allyUnits.Count > 0)
                        {
                            du.Damage(); 
                        }
                    }
                }
                turnBegins = true;
                turn++;
            }
        }
    }   
}
