using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrafficWonderComparer
{
    public class LevelScore
    {
        private int score = 0;
        private int stops = 0;
        private int level = 0;

        public LevelScore(int pScore,int pStops,int pLevel)
        {
            score = pScore;
            stops = pStops;
            level = pLevel;
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        
        public int Stops
        {
            get { return stops; }
            set { stops = value; }
        }

        public int Level
        {
            get { return level; }
        }

    }
}
