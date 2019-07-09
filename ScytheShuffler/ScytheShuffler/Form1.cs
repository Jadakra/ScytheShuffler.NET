using System;
using System.Linq;
using System.Windows.Forms;

namespace ScytheShuffler
{
    public partial class ScytheShuffler : Form
    {
        string[] Factions = new string[5] { "Crimea", "Nordic", "Polania", "Rusviet", "Saxony" };//"Albion","Togawa"
        string[] PlayMats = new string[5] { "Industrial", "Engineering", "Patriotic", "Mechanical", "Agricultural" }; //Militant 2.5, Innovative 3.5, 
        int found = -1;

        Random random = new Random();

        public ScytheShuffler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Results.Text = "";
            int numberOfPlayers = Convert.ToInt32(Players.SelectedItem);
            int minF = 1, maxF = 5, minP = 1, maxP = 5;
            //int[] usedFactions = new int[numberOfPlayers];
            int[] usedFactions = new int[5] { -1, -1, -1, -1, -1 };
            int[] usedPlaymats = new int[numberOfPlayers];
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                int newRandomFaction = RandomNumber(minF, maxF);
                while (Array.IndexOf(usedFactions, newRandomFaction) != found)
                {

                    newRandomFaction = RandomNumber(minF, maxF);
                    if (Array.IndexOf(usedFactions, minF) != -1)
                    { minF++; }
                    if (Array.IndexOf(usedFactions, maxF) != -1)
                    { maxF--; }
                }
                usedFactions[i - 1] = newRandomFaction;
                int newRandomPlaymat = RandomNumber(1, 5);
                while (Array.IndexOf(usedPlaymats, newRandomPlaymat) != found)
                {
                    newRandomPlaymat = RandomNumber(minP, maxP);
                    if (Array.IndexOf(usedPlaymats, minP) != -1)
                    { minP++; }
                    if (Array.IndexOf(usedPlaymats, maxP) != -1)
                    { maxP--; }
                }
                usedPlaymats[i - 1] = newRandomPlaymat;
                //Consigue dos listados igual al numero de jugadores
                //Que dentro del listado individual no haya repeticiones
                //Asigna esos numeros a los arreglos

                Results.Text += Factions[newRandomFaction - 1] + "," + PlayMats[newRandomPlaymat - 1] + Environment.NewLine;
                //Results.Text += randomFaction + "," + randomPlayMat + Environment.NewLine;
            }


        }
        public int RandomNumber(int min, int max)
        {

            return random.Next(min, max);
        }

        void Start()
        {
        }
    }
}
