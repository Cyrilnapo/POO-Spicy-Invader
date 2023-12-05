using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Spicy_Invader_Cyril
{
    internal class SQL
    {
        const string connectionString = "Server=localhost;Port=6033;Database=db_space_invaders;User=root;Password=root;";   //identifiants de connexion à la base de données
        MySqlConnection connection = new MySqlConnection(connectionString); //Objet de connection à la base de donnée


        

        //Code sql permettant l'insert des données du joueur à la fin du jeu (pseudo et score)
        public void Insert(int score, string pseudo)
        {

            try
            {
                //connection à la base de donnée
                connection.Open();

                //Requête
                String query = "INSERT INTO t_joueur (jouPseudo, jouNombrePoints) VALUES (@pseudo, @score)";    

                //Insertion
                MySqlCommand insertCommand = new MySqlCommand(query, connection);
                insertCommand.Parameters.AddWithValue("@pseudo", pseudo);
                insertCommand.Parameters.AddWithValue("@score", score);
                insertCommand.ExecuteNonQuery();

            }
            
            catch (MySqlException ex)
            {
                //Si erreur
                Console.WriteLine("Erreur de connexion : " + ex.Message);
            }
            finally
            {
                //Déconnection de la base de donnée
                connection.Close(); 
            }
        }

        //Code SQL permettant d'afficher les données du classement (pseudos et points, top 5 décroissant)
        public void Select()
        {
            Console.Clear();

            //Affichage
            Console.Write(@"                                 *             
   *                *                          
                                               
            *     *              *             
                              *         *      
   *             *                  *          
                     *                         
            *                  *               
  *     *             *    *                 *
    *       *                    *     *       
  *                *           *              *
         ╔═══╦╗            *     *  ╔╗   
  *      ║╔═╗║║   *    *       *   ╔╝╚╗*          *
         ║║*╚╣║╔══╦══╦══╦══╦╗╔╦══╦═╬╗╔╝     *
     *   ║║ ╔╣║║╔╗║══╣══╣║═╣╚╝║║═╣╔╗╣║         *
 *       ║╚═╝║╚╣╔╗╠══╠══║║═╣║║║║═╣║║║║  *      
         ║╔══╩═╩╝╚╩══╩══╩══╩╩╩╩══╩╝╚╣║   *
  *      ║║                         ║║*        *
        *║║                         ║║       *   *
    *    ║║                         ║║
         ║║                         ║║  *
 *       ║║                         ║║
       * ║╚═════════════════════════╝║       *          
         ╚═══════════════════════════╝
                              *                  *
      *             *           *            
                                               
                                                  *
            *       *     *                    
                                               
                                   *        *  
           *                                   
*                     *
                                               
                                   *           
                  *                            
                                               
                                   *        * ");   

            int x = 30; //Position x des données qui seront affichées
            int y = 17; //Position y des données qui seront affichées (score)
            int y2 = 17; //deuxième position pour les peudo

            



            try
            {
                connection.Open();


                string query = "SELECT * FROM t_joueur order by jouNombrePoints desc limit 5;";     //Requête
                MySqlCommand command = new MySqlCommand(query, connection);  //Objet de requête avec connection

                
                int i = 1;
                //Requête et mise en page
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.SetCursorPosition(12, y2);
                        Console.WriteLine("\u25A0 " + i.ToString() + ". " + reader["jouPseudo"].ToString());
                        i++;
                        y2++;
                    }
                }
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(reader["jouNombrePoints"].ToString());
                        y++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Si erreur
                Console.WriteLine("Erreur de connexion : " + ex.Message);
            }
            finally
            {
                //Déconnection
                connection.Close();
            }

        }

    }

}

