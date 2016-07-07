using System;
using System.Windows.Forms;

using TestTravelerSorted;


namespace TestTraveler
{
    public partial class Form1 : Form
    {
        LoadCards load;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bLoadCards_Click(object sender, EventArgs e)
        {
            load = new LoadCards();
            load.Load();

            lbUnsortedItems.Items.Clear();

            foreach (var c in load.CardsInFrom)
                lbUnsortedItems.Items.Add((lbUnsortedItems.Items.Count + 1).ToString() + " : " + c.Value.pointFrom + " -> " + c.Value.pointTo);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bSorted_Click(object sender, EventArgs e)
        {
            lbSortedItems.Items.Clear();
            Sorted sort = new Sorted(load.CardsInFrom, load.CardsInTo);
            sort.Sort();
            foreach (var c in sort.CardSorted)
                lbSortedItems.Items.Add((lbSortedItems.Items.Count+1).ToString()+ " : " + c.pointFrom + " -> " + c.pointTo);
        }
    }
}
