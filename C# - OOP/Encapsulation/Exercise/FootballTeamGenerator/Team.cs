using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private List<Player> players;
        private string name;
        private int rating;

        private Team()
        {
            players = new List<Player>();
        }

        public Team(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get 
            {
                return name; 
            }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("A name should not be empty.");
                }
                name = value; 
            }
        }
        public int Rating
        {
            get
            {
                return this.rating;
            }
            private set
            {
                this.rating = value;
            }
        }
        public IReadOnlyCollection<Player> Players
        {
            get { return this.players; }
        }

        private int CalculateTeamRating()
        {
            double result = 0;

            foreach (Player player in players)
            {
                result += player.SkillLevel;
            }
            result /= players.Count;
            int roundedResult = (int)Math.Round(result);

            return roundedResult;
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
            this.Rating = CalculateTeamRating();
        }

        public void RemovePlayer(string name)
        {
            bool playerFound = false;
            int indexToRemove = 0;
            foreach (Player p in players)
            {
                if (p.Name == name)
                {
                    indexToRemove = this.players.IndexOf(p);
                    playerFound = true;
                    break;
                }
            }

            if (playerFound == true)
            {
                this.players.RemoveAt(indexToRemove);
                this.Rating = CalculateTeamRating();
            }
            else
            {
                Console.WriteLine($"Player {name} is not in {this.Name} team.");
            }
        }
    }
}
