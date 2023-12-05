using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spicy_Invader_Cyril;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Spicy_Invader_Cyril.Tests
{
    [TestClass()]
    public class GameTests
    {
        //Test la position initial du vaisseau
        [TestMethod()]
        public void Test_PlayerInitialPosition()
        {
            Game game = new Game();

            Assert.AreEqual(22, game.playerX);
            Assert.AreEqual(35, game.playerY);
        }

        //test le score au lancement du jeu
        [TestMethod()]
        public void Test_InitialScore()
        {
            Game game = new Game();
            Assert.AreEqual(0, game.score);
        }

        //test qu'il y aie bien le bon nombre d'ennemis
        [TestMethod()]
        public void Test_EnemyCount()
        {
            Game game = new Game();
            Assert.AreEqual(10, game.enemyCount);
        }
    }
}