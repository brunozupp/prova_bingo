using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BingoProva
{
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        private void generateBingoButton_Click(object sender, EventArgs e)
        {
            bingoDataGridView.DataSource = typeof(List<BingoBusiness>);
            bingoDataGridView.DataSource = new BingoBusiness().GenerateBingoCard();
        }
    }
}
