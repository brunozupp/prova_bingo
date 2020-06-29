using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
