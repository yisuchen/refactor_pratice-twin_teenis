using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TennisTests
    {
        private Tennis tennis;

        [TestInitialize]
        public void Init()
        {
            tennis = new Tennis();
        }

        [TestMethod]
        public void love_all()
        {
            scoreShouldBe("love all");
        }

        [TestMethod]
        public void fifteen_love()
        {
            givenFirstPlayerScore(1);
            scoreShouldBe("fifteen love");
        }

        [TestMethod]
        public void thirty_love()
        {
            givenFirstPlayerScore(2);
            scoreShouldBe("thirty love");
        }

        [TestMethod]
        public void forty_love()
        {
            givenFirstPlayerScore(3);
            scoreShouldBe("forty love");
        }

        [TestMethod]
        public void love_fifteen()
        {
            givenSecondPlayerScore(1);
            scoreShouldBe("love fifteen");
        }

        [TestMethod]
        public void love_thirty()
        {
            givenSecondPlayerScore(2);
            scoreShouldBe("love thirty");
        }

        [TestMethod]
        public void fifteen_all()
        {
            givenFirstPlayerScore(1);
            givenSecondPlayerScore(1);
            scoreShouldBe("fifteen all");
        }

        [TestMethod]
        public void thirty_all()
        {
            givenFirstPlayerScore(2);
            givenSecondPlayerScore(2);
            scoreShouldBe("thirty all");
        }

        [TestMethod]
        public void deuce()
        {
            givenDeuce();
            scoreShouldBe("deuce");
        }

        [TestMethod]
        public void first_player_adv()
        {
            givenDeuce();
            givenFirstPlayerScore(1);
            scoreShouldBe("Joey adv");
        }

        [TestMethod]
        public void second_player_adv()
        {
            givenDeuce();
            givenSecondPlayerScore(1);
            scoreShouldBe("Tom adv");
        }

        [TestMethod]
        public void second_player_win()
        {
            givenDeuce();
            givenSecondPlayerScore(2);
            scoreShouldBe("Tom win");
        }

        [TestMethod]
        public void first_player_win()
        {
            givenDeuce();
            givenFirstPlayerScore(2);
            scoreShouldBe("Joey win");
        }



        private void givenDeuce()
        {
            givenFirstPlayerScore(3);
            givenSecondPlayerScore(3);
        }

        private void givenSecondPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennis.secondPlayerScore();
            }
        }

        private void givenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennis.firstPlayerScore();
            }
        }

        private void scoreShouldBe(String expected)
        {
            Assert.AreEqual(expected, tennis.score());
        }

    }
}