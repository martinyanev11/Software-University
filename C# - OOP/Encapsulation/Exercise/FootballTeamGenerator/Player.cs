using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int statsMinValue = 0;
        private const int statsMaxValue = 100;
        private const string statsExceptionMessage = "{0} should be between 0 and 100.";

        private string name;
        //Stats probably could be done with dictionary...
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private int skillLevel;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.SkillLevel = CalculateSkillLevel();
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
        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                if (value < statsMinValue || value > statsMaxValue)
                {
                    throw new Exception(string.Format(statsExceptionMessage, nameof(this.Endurance)));
                }
                endurance = value;
            }
        }
        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                if (value < statsMinValue || value > statsMaxValue)
                {
                    throw new Exception(string.Format(statsExceptionMessage, nameof(this.Sprint)));
                }
                sprint = value;
            }
        }
        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                if (value < statsMinValue || value > statsMaxValue)
                {
                    throw new Exception(string.Format(statsExceptionMessage, nameof(this.Dribble)));
                }
                dribble = value;
            }
        }
        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                if (value < statsMinValue || value > statsMaxValue)
                {
                    throw new Exception(string.Format(statsExceptionMessage, nameof(this.Passing)));
                }
                passing = value;
            }
        }
        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                if (value < statsMinValue || value > statsMaxValue)
                {
                    throw new Exception(string.Format(statsExceptionMessage, nameof(this.Shooting)));
                }
                shooting = value;
            }
        }
        public int SkillLevel
        {
            get
            {
                return this.skillLevel;
            }
            private set
            {
                skillLevel = value;
            }
        }

        private int CalculateSkillLevel()
        {
            int result = (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5;
            return result;
        }
    }
}
