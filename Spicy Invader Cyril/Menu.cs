using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spicy_Invader_Cyril
{
    internal class Menu
    {
        //Menu du jeu (boutons + style)
        public void Show(int selection)
        {

            if (selection == 0)
            {
                Console.WriteLine(@"                                 *             
   *                *                          
                                               
            *     *              *             
                              *         *      
   *             *                  *          
                     *                         
            *                  *               
  *     *             *    *                 *
    *       *                    *     *       
  *                *           *              *
      ╔═══╗      *   ╔══╗          ╔╗    * *         
 *    ║╔═╗║  *       ╚╣╠╝   *   *  ║║            *
      ║╚══╦══╦╦══╦╗ ╔╗║║╔═╗╔╗╔╦══╦═╝╠══╦═╗    *     *
   *  ╚══╗║╔╗╠╣╔═╣║ ║║║║║╔╗╣╚╝║╔╗║╔╗║║═╣╔╝*
*     ║╚═╝║╚╝║║╚═╣╚═╝╠╣╠╣║║╠╗╔╣╔╗║╚╝║║═╣║      *     
      ╚═══╣╔═╩╩══╩═╗╔╩══╩╝╚╝╚╝╚╝╚╩══╩══╣║            
          ║║  *    ║║                  ║║  *     *  *
    *     ║║     ╔═╝║                  ║║
       *  ║║ *   ╚══╝                  ║║        *
          ║╚═══════════════════════════╝║
*         ╚═════════════════════════════╝
     *        *   *       *  *      *    *     
   *              *        *                   *
      *                *          *            
          *                               *    
  *                      *                     
                                              
            *         *                        
      *                                      * 
                                *              
                                               
                         *                  *
                                               
      *             *                        
                                               
                                               
                                    *          ");
                Console.SetCursorPosition(24, 17);
                Console.WriteLine("Jouer", Console.BackgroundColor = ConsoleColor.Black);
                Console.SetCursorPosition(24, 18);
                Console.WriteLine("Classement", Console.BackgroundColor = ConsoleColor.Black);
                Console.SetCursorPosition(24, 19);
                Console.WriteLine("Quitter", Console.BackgroundColor = ConsoleColor.Black);
            }
            if (selection == 1)
            {
                Console.WriteLine(@"                                 *             
   *                *                          
                                               
            *     *              *             
                              *         *      
   *             *                  *          
                     *                         
            *                  *               
  *     *             *    *                 *
    *       *                    *     *       
  *                *           *              *
      ╔═══╗      *   ╔══╗          ╔╗    * *         
 *    ║╔═╗║  *       ╚╣╠╝   *   *  ║║            *
      ║╚══╦══╦╦══╦╗ ╔╗║║╔═╗╔╗╔╦══╦═╝╠══╦═╗    *     *
   *  ╚══╗║╔╗╠╣╔═╣║ ║║║║║╔╗╣╚╝║╔╗║╔╗║║═╣╔╝*
*     ║╚═╝║╚╝║║╚═╣╚═╝╠╣╠╣║║╠╗╔╣╔╗║╚╝║║═╣║      *     
      ╚═══╣╔═╩╩══╩═╗╔╩══╩╝╚╝╚╝╚╝╚╩══╩══╣║            
          ║║  *    ║║                  ║║  *     *  *
    *     ║║     ╔═╝║                  ║║
       *  ║║ *   ╚══╝                  ║║        *
          ║╚═══════════════════════════╝║
*         ╚═════════════════════════════╝
     *        *   *       *  *      *    *     
   *              *        *                   *
      *                *          *            
          *                               *    
  *                      *                     
                                              
            *         *                        
      *                                      * 
                                *              
                                               
                         *                  *
                                               
      *             *                        
                                               
                                               
                                    *          ");
                Console.SetCursorPosition(24, 17);
                Console.WriteLine("\u25A0 Jouer", Console.BackgroundColor = ConsoleColor.DarkRed);
                Console.SetCursorPosition(24, 18);
                Console.WriteLine("□ Classement", Console.BackgroundColor = ConsoleColor.Black);
                Console.SetCursorPosition(24, 19);
                Console.WriteLine("□ Quitter", Console.BackgroundColor = ConsoleColor.Black);
            }

            if (selection == 2)
            {
                Console.WriteLine(@"                                 *             
   *                *                          
                                               
            *     *              *             
                              *         *      
   *             *                  *          
                     *                         
            *                  *               
  *     *             *    *                 *
    *       *                    *     *       
  *                *           *              *
      ╔═══╗      *   ╔══╗          ╔╗    * *         
 *    ║╔═╗║  *       ╚╣╠╝   *   *  ║║            *
      ║╚══╦══╦╦══╦╗ ╔╗║║╔═╗╔╗╔╦══╦═╝╠══╦═╗    *     *
   *  ╚══╗║╔╗╠╣╔═╣║ ║║║║║╔╗╣╚╝║╔╗║╔╗║║═╣╔╝*
*     ║╚═╝║╚╝║║╚═╣╚═╝╠╣╠╣║║╠╗╔╣╔╗║╚╝║║═╣║      *     
      ╚═══╣╔═╩╩══╩═╗╔╩══╩╝╚╝╚╝╚╝╚╩══╩══╣║            
          ║║  *    ║║                  ║║  *     *  *
    *     ║║     ╔═╝║                  ║║
       *  ║║ *   ╚══╝                  ║║        *
          ║╚═══════════════════════════╝║
*         ╚═════════════════════════════╝
     *        *   *       *  *      *    *     
   *              *        *                   *
      *                *          *            
          *                               *    
  *                      *                     
                                              
            *         *                        
      *                                      * 
                                *              
                                               
                         *                  *
                                               
      *             *                        
                                               
                                               
                                    *          ");
                Console.SetCursorPosition(24, 17);
                Console.WriteLine("□ Jouer", Console.BackgroundColor = ConsoleColor.Black);
                Console.SetCursorPosition(24, 18);
                Console.WriteLine("\u25A0 Classement", Console.BackgroundColor = ConsoleColor.DarkRed);
                Console.SetCursorPosition(24, 19);
                Console.WriteLine("□ Quitter", Console.BackgroundColor = ConsoleColor.Black);


            }
            if (selection == 3)
            {
                Console.WriteLine(@"                                 *             
   *                *                          
                                               
            *     *              *             
                              *         *      
   *             *                  *          
                     *                         
            *                  *               
  *     *             *    *                 *
    *       *                    *     *       
  *                *           *              *
      ╔═══╗      *   ╔══╗          ╔╗    * *         
 *    ║╔═╗║  *       ╚╣╠╝   *   *  ║║            *
      ║╚══╦══╦╦══╦╗ ╔╗║║╔═╗╔╗╔╦══╦═╝╠══╦═╗    *     *
   *  ╚══╗║╔╗╠╣╔═╣║ ║║║║║╔╗╣╚╝║╔╗║╔╗║║═╣╔╝*
*     ║╚═╝║╚╝║║╚═╣╚═╝╠╣╠╣║║╠╗╔╣╔╗║╚╝║║═╣║      *     
      ╚═══╣╔═╩╩══╩═╗╔╩══╩╝╚╝╚╝╚╝╚╩══╩══╣║            
          ║║  *    ║║                  ║║  *     *  *
    *     ║║     ╔═╝║                  ║║
       *  ║║ *   ╚══╝                  ║║        *
          ║╚═══════════════════════════╝║
*         ╚═════════════════════════════╝
     *        *   *       *  *      *    *     
   *              *        *                   *
      *                *          *            
          *                               *    
  *                      *                     
                                              
            *         *                        
      *                                      * 
                                *              
                                               
                         *                  *
                                               
      *             *                        
                                               
                                               
                                    *          ");
                Console.SetCursorPosition(24, 17);
                Console.WriteLine("□ Jouer", Console.BackgroundColor = ConsoleColor.Black);
                Console.SetCursorPosition(24, 18);
                Console.WriteLine("□ Classement", Console.BackgroundColor = ConsoleColor.Black);
                Console.SetCursorPosition(24, 19);
                Console.WriteLine("\u25A0 Quitter", Console.BackgroundColor = ConsoleColor.DarkRed);
                Console.BackgroundColor = ConsoleColor.Black;


            }
        }
    }
}
