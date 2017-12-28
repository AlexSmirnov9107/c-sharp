using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public List<Karta> Cards { get; set; }

        public Game()
        {
            Players = new List<Player>();
            Player player = new Player();
            Player player2 = new Player();
            Cards = new List<Karta>();
            List<Karta> tmpList = new List<Karta>();
            for (int i = 6; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tmpList.Add(new Karta { CardLevel = i, Mast = j });
                }
            }

            Random rnd1 = new Random();
            //перемешиваем
            for (int i = 0; i < 36; i++)
            {
                int randomIndex = rnd1.Next(0, tmpList.Count);
                Karta card = tmpList.ElementAt(randomIndex);
                tmpList.RemoveAt(randomIndex);
                Cards.Add(card);
            }

            //раздача карт игроку №1
            for (int i = 0; i < 18; i++)
            {
                int randomIndex = rnd1.Next(0, Cards.Count);
                Karta card = Cards.ElementAt(randomIndex);
                Cards.RemoveAt(randomIndex);
                player.Cards.Add(card);
            }
            //раздача карт игроку №2
            player2.Cards.InsertRange(0, Cards);

            Players.Add(player);
            Players.Add(player2);

        }
        public void Play()
        {
            bool isOver = false;
            do
            {
                Dictionary<Player, Karta> playerCard = new Dictionary<Player, Karta>();


                foreach (var player in Players)
                {
                    playerCard.Add(player, player.Cards.First());
                    player.Cards.RemoveAt(0);
                }

                int maxCard = playerCard.Max(card => card.Value.CardLevel);

                Player firstWinPlayer = (playerCard.First(card => card.Value.CardLevel == maxCard).Key);

                foreach (var player in playerCard)
                {
                    firstWinPlayer.Cards.Add(player.Value);
                }


                foreach (var player in Players)
                {
                    if (player.Cards.Count == 36)
                    {
                        isOver = true;
                        break;
                    }
                }
                
            } while (!isOver);
        }
    }
}
