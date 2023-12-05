using System;
using System.Threading;

namespace Spicy_Invader_Cyril
{
    public class Game
    {
        
        public int playerX = 22; // Position x initiale du joueur
        public int playerY = 35; // Position y initiale du joueur
        public int enemyCount = 10; // Nombre d'ennemis
       

        public int score { get; set; } = 0; // Score du joueur
        public string pseudo { get; set; } // Pseudo du joueur
        public void Play()
        {
            Console.Clear();
      
            int counter = 0; // Compteur de boucle pour mouvements joueur et ennemis

            var sql = new SQL(); //Intégration classe SQL pour enregistrement score et pseudo
            var menu = new Menu(); // intégration classe menu pour fin de jeu

            Console.SetCursorPosition(playerX, playerY);
            Console.Write("<^>"); // Affichage du vaisseau

            
            int[] enemyX = new int[enemyCount]; // Positions x des ennemis
            int[] enemyY = new int[enemyCount]; // Positions y des ennemis
            int[] enemyAppearanceDelay = new int[enemyCount]; // Délai d'apparition des ennemis
            bool[] isEnemyHit = new bool[enemyCount]; // Tableau pour indiquer si un ennemi a été touché

            Random random = new Random(); //implémentation concepte aléatoire

            //Définition des délai^s d'apparition
            for (int i = 0; i < enemyCount; i++)
            {
                enemyAppearanceDelay[i] = random.Next(1, 10); // Délai d'apparition aléatoire des ennemis
            }

            int maxProjectiles = 10; // Nombre maximum de projectiles à la fois
            int[] bulletX = new int[maxProjectiles]; // Positions x des projectiles
            int[] bulletY = new int[maxProjectiles]; // Positions y des projectiles
            bool[] isShooting = new bool[maxProjectiles]; // Tableau pour indiquer si un tir est en cours
            bool[] isProjectileHit = new bool[maxProjectiles]; // Tableau pour l'indication si un projectile a touché

            while (true)
            {
                // Vérifier les collisions entre les projectiles et les ennemis
                for (int i = 0; i < maxProjectiles; i++)
                {
                    if (isShooting[i])
                    {
                        for (int j = 0; j < enemyCount; j++)
                        {
                            if (!isEnemyHit[j] && bulletX[i] == enemyX[j] && bulletY[i] == enemyY[j])
                            {
                                // Marquer l'ennemi comme touché
                                isEnemyHit[j] = true;
                                isShooting[i] = false;
                                isProjectileHit[i] = true;
                                break;
                            }
                        }
                    }
                }

                // Gestion de l'apparition des ennemis
                for (int i = 0; i < enemyCount; i++)
                {
                    if (enemyY[i] == 0)
                    {
                        enemyX[i] = random.Next(3, 45); // Position x aléatoire
                    }

                    if (counter % enemyAppearanceDelay[i] == 0 && counter % 21 == 0)
                    {
                        Console.SetCursorPosition(enemyX[i], enemyY[i]);
                        Console.Write(" ");

                        enemyY[i]++;

                        Console.SetCursorPosition(enemyX[i], enemyY[i]);
                        Console.Write("#");
                    }

                    // Vérifier si l'ennemi a atteint le bas de la fenêtre
                    if (enemyY[i] >= playerY)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over - L'ennemi vous a touché ! \n \nVotre score est de : " + score + " points ! \n");
                        Console.Write("Veuillez entrer votre pseudo : ");
                        pseudo = Console.ReadLine();
                        sql.Insert(score, pseudo);
                        Console.Clear();
                        menu.Show(1);

                        return; // fin du jeu
                    }
                }

                // Gestion des mouvements du joueur
                if (Console.KeyAvailable)
                {
                    //Aller à droite
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        if (playerX < 45) 
                        {
                            Console.SetCursorPosition(playerX, playerY);
                            Console.Write("   ");
                            playerX++;
                        }
                    }
                    //Aller à gauche
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        if (playerX > 1)    
                        {
                            Console.SetCursorPosition(playerX, playerY);
                            Console.Write("   ");
                            playerX--;
                        }
                    }
                    //Tirer projectiles
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        for (int i = 0; i < maxProjectiles; i++)
                        {
                            if (!isShooting[i])
                            {
                                isShooting[i] = true;
                                bulletX[i] = playerX + 1;
                                bulletY[i] = playerY - 1;
                                break;
                            }
                        }
                    }
                }

                // Supprimer les ennemis touchés et les faire respawn
                for (int i = 0; i < enemyCount; i++)
                {
                    if (isEnemyHit[i])
                    {
                        Console.SetCursorPosition(enemyX[i], enemyY[i]);
                        Console.Write(" ");
                        enemyX[i] = random.Next(3, 45);
                        enemyY[i] = 0;
                        isEnemyHit[i] = false;
                        score += 125; //incrémentation du score car ennemi touché
                    }
                }

                // Gestion des tirs du vaisseau
                for (int i = 0; i < maxProjectiles; i++)
                {
                    if (isShooting[i] && !isProjectileHit[i])
                    {
                        Console.SetCursorPosition(bulletX[i], bulletY[i]);
                        Console.Write(" ");
                        
                        //vitesse de déplacement du projectile
                        if (counter % 2 == 0)
                        {
                            bulletY[i]--;
                        }

                        //Suppression du projectile quand arrivé au haut de la fenetre
                        if (bulletY[i] <= 0)
                        {
                            Console.SetCursorPosition(bulletX[i], bulletY[i]);
                            Console.Write(" ");
                            isShooting[i] = false;
                        }
                        else
                        {
                            Console.SetCursorPosition(bulletX[i], bulletY[i]);
                            Console.Write("*");
                        }
                    }
                }

                // Afficher à nouveau le vaisseau du joueur
                Console.SetCursorPosition(playerX, playerY);
                Console.Write("<^>");

                Thread.Sleep(10);
                counter++;
            }
        }
    }
}
