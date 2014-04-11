using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace TrafficWonderComparer
{
    public class Player
    {
        private int id = 0;
        private string name = null;
        private bool comparer = false;
        private Dictionary<int, LevelScore> levels = null;
        private int position;
        private int totalScore;
        private int globalRank;

        public Player(int PlayerID, string PlayerName, bool isComparer)
        {
            id = PlayerID;
            name = PlayerName;
            comparer = isComparer;
            WebResponse wr = WebRequest.Create("http://www.trafficwonderapp.com/leaderboard/player_profile/?player_id="+PlayerID).GetResponse();
            StreamReader rsr = new StreamReader(wr.GetResponseStream());
            string content = rsr.ReadToEnd();

            rsr.Close();
            Regex rx = new Regex("<b>SCORE\\s:</b></td>\\s*?<td>(?<Score>(\\d|,)*?)</td>.*?<b>Position\\s:</b></td>\\s*?<td>(?<Position>\\d*?)\\sof(.|\\n)*?<b>Global\\srank\\s:</b></td>\\s*?<td>(?<GlobalRank>\\d*?)\\sof(.|\\n)*?<b>stops</b></td>\\s*?</tr>\\s*?(?<Levels>(.|\\n)*?)</table", RegexOptions.CultureInvariant | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection ms = rx.Matches(content);

            if (ms != null && ms.Count == 1)
            {
                foreach (Match m in ms)
                {
                    position = int.Parse(m.Groups["Position"].Value);
                    globalRank = int.Parse(m.Groups["GlobalRank"].Value);
                    totalScore = int.Parse(m.Groups["Score"].Value.Replace(",", ""));
                    rx = new Regex("<tr>\\s*?<td\\salign=\"center\"><b>#(?<Level>\\d*?)</b></td>\\s*?<td\\salign=\"center\">(?<Score>(\\d|,)*?)</td>\\s*?(<td\\salign=\"center\">.*?</td>\\s*?){2}<td\\salign=\"center\">(?<Stops>\\d*?)</td>\\s*?</tr>", RegexOptions.CultureInvariant | RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    MatchCollection ms2 = rx.Matches(m.Groups["Levels"].Value);

                    if (ms2 != null && ms2.Count > 0)
                    {
                        levels = new Dictionary<int, LevelScore>();
                        foreach (Match m2 in ms2)
                        {
                            int level = int.Parse(m2.Groups["Level"].Value);
                            levels.Add(level, new LevelScore(int.Parse(m2.Groups["Score"].Value.Replace(",", "")), int.Parse(m2.Groups["Stops"].Value), level));
                        }
                    }
                }
            }
        }

        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public bool Comparer
        {
            get { return comparer; }
            set { comparer = value; }
        }

        public Dictionary<int, LevelScore> Levels
        {
            get { return levels; }
            set { levels = value; }
        }

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        public int TotalScore
        {
            get { return totalScore; }
        }

        public int GlobalRank
        {
            get { return globalRank; }
            set { globalRank = value; }
        }

    }
}
