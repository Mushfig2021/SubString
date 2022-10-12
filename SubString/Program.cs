using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Team> teams = new List<Team>()
            {
                new Team { Name = "Бавария", Country ="Германия" },
                new Team { Name = "Барселона", Country ="Испания" }
            };

            List<Player> players = new List<Player>()
            {
                new Player {Name="Месси", Team="Барселона"},
                new Player {Name="Неймар", Team="Барселона"},
                new Player {Name="Роббен", Team="Бавария"}
            };

           
            //Метод Zip
            //Метод Zip позволяет объединять две последовательности таким образом, что первый элемент из первой последовательности
            //объединяется с первым элементом из второй последовательности, второй элемент из первой последовательности
            //соединяется со вторым элементом из второй последовательности и так далее:

            var result2 = players.Zip(teams,
                                      (player, team) => new
                                      {
                                          Name = player.Name,
                                          Team = team.Name,
                                          Country = team.Country
                                      });
            foreach (var player in result2)
            {
                Console.WriteLine($"{player.Name} - {player.Team} ({player.Country})");

                Console.WriteLine();
            }

            //Метод Zip в качестве первого параметра принимает вторую последовательность,
            //с которой надо соединяться, а в качестве второго параметра -делегат для создания нового объекта.

            //Консольный вывод программы:

            //Роббен - Бавария(Германия)

            //Неймар - Барселона(Испания)
            Console.ReadLine();
        }
    }

    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
    }
    class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
