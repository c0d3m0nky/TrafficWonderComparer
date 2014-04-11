using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace TrafficWonderComparer
{
    public partial class Form1 : Form
    {
        private bool foundComparer = false;

        public Form1()
        {
            InitializeComponent();
            cmbStopSelector.SelectedIndex = 1;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            dgvComparison.Rows.Clear();
            Refresh();
            Dictionary<int, Player> players = new Dictionary<int, Player>();
            int pagecount = 0;
            foundComparer = false;

            while (!getPlayers(players, pagecount))
            {
                pagecount++;
            }
            Player comparer = players.Values.First(p => p.Comparer);
            Dictionary<string, LevelScore> levelscores = new Dictionary<string, LevelScore>();

            tsslMain.Text = string.Format("{0}({4})    Position: {1}    Global Rank: {2}    Total Score: {3}", comparer.Name, comparer.Position, comparer.GlobalRank, comparer.TotalScore.ToString("###,###"), comparer.ID);
            Refresh();
            foreach (KeyValuePair<int, Player> p in players)
            {
                foreach (KeyValuePair<int, LevelScore> ls in p.Value.Levels)
                {
                    levelscores.Add(p.Key + "|" + ls.Key, ls.Value);
                }
            }
            Dictionary<int, LevelScore> LevelTopScores = new Dictionary<int, LevelScore>();

            for (int i = 1; i < 61; i++)
            {
                int topScore = levelscores.Where(l => l.Value.Level == i && l.Value.Stops <= nudMaxStops.Value).Max(l => l.Value.Score);
                Dictionary<string, LevelScore> TopScores = levelscores.Where(l => l.Value.Level == i && l.Value.Score == topScore).ToDictionary(l => l.Key, l => l.Value);
                int leastStop = TopScores.Min(l => l.Value.Stops);
                if (topScore - comparer.Levels[i].Score > 0 || cbShowAllLevels.Checked)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    int dif = topScore - comparer.Levels[i].Score;

                    r.CreateCells(dgvComparison);
                    r.Cells[0].Value = i;
                    r.Cells[1].Value = topScore;
                    r.Cells[2].Value = comparer.Levels[i].Score;
                    r.Cells[3].Value = dif;
                    if (dif < 0) { r.Cells[3].Style.ForeColor = Color.Red; }
                    r.Cells[4].Value = leastStop;
                    r.Cells[5].Value = comparer.Levels[i].Stops;
                    dgvComparison.Rows.Add(r);
                }
            }
            if (dgvComparison.Rows.Count > 0) { dgvComparison.Sort(dgvComparison.Columns["Dif"], ListSortDirection.Descending); }
        }

        private bool getPlayers(Dictionary<int, Player> players, int i)
        {
            WebResponse wr = WebRequest.Create("http://www.trafficwonderapp.com/leaderboard/?index=" + (45 * i).ToString()).GetResponse();
            StreamReader rsr = new StreamReader(wr.GetResponseStream());
            string content = rsr.ReadToEnd();

            rsr.Close();
            Regex rx = new Regex("<tr\\sstyle=\"background-color:(.|\\n)*?<a href=\"\\./player_profile/\\?player_id=(?<PID>\\d*?)&.*?>(?<PN>.*?)</a>", RegexOptions.CultureInvariant | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection ms = rx.Matches(content);

            if (ms != null && ms.Count > 0)
            {
                foreach (Match m in ms)
                {
                    Player p = new Player(int.Parse(m.Groups["PID"].Value), m.Groups["PN"].Value, false);
                    bool iscomparer = p.Name.Trim().ToLower() == txtPlayer.Text.Trim().ToLower();

                    p.Comparer = iscomparer;
                    if (p.Levels == null)
                    {
                        if (p.Comparer) { throw new Exception("Couldn't read Comparer profile"); }
                        continue;
                    }
                    if (iscomparer) { foundComparer = true; }
                    switch (cmbStopSelector.SelectedIndex)
                    {
                        case 0:
                            players.Add(p.ID, p);
                            if (p.Comparer)
                            {
                                return true;
                            }
                            break;
                        case 1:
                            if (players.Count < nudPlayerCnt.Value || p.Comparer)
                            {
                                players.Add(p.ID, p);
                            }
                            if (players.Count == nudPlayerCnt.Value && foundComparer) { return true; }
                            break;
                    }
                }
            }
            else { throw new Exception("Couldn't read response"); }
            return false;
        }
    }
}
