//Auteur : Cyril Napoleone
//Date : 05.11.2023
//Jeu Spicy Invader

using System.Threading;
using MySql.Data.MySqlClient;
using Spicy_Invader_Cyril;

namespace Spicy_invader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Permet d'afficher les caractères spéciaux (puces menu)
            Console.SetWindowSize(50, 40); // Taille de la fenêtre
            Console.CursorVisible = false; // curseur invisible pour propreté

            var game = new Game(); // Intégration classe Jeu pour lancer la partie
            var sql = new SQL(); // intégration classe SQL pour classement
            var menu = new Menu(); // Intégration Menu pour la navigation dans le menu

            byte option = 1; // Option sélectionnée du menu

            menu.Show(option); // Affiche le menu principal

            
            while (true)
            {
                // Navigation dans le menu
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow && option != 3)
                {
                    option++;
                }
                else if (key.Key == ConsoleKey.UpArrow && option != 1)
                {
                    option--;
                }

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        menu.Show(option); // Affiche le menu avec la nouvelle option sélectionnée
                        if (key.Key == ConsoleKey.Enter)
                        {
                            // Commencement jeu
                            game.Play();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        menu.Show(option); // Affiche le menu avec la nouvelle option sélectionnée
                        if (key.Key == ConsoleKey.Enter)
                        {
                            // Affichage classement 
                            sql.Select();
                        }
                        break;

                    case 3:
                        Console.Clear();
                        menu.Show(option); // Affiche le menu avec la nouvelle option sélectionnée
                        if (key.Key == ConsoleKey.Enter)
                        {
                            // Quitter le jeu
                            System.Environment.Exit(0);
                        }
                        break;
                }
            }
        }
    }
}
