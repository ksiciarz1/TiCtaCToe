using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiCtaCToe
{
    public partial class TiCtaCToe : Form
    {
        private TiCTaCToeLogicManager LogicManager;

        public TiCtaCToe()
        {
            InitializeComponent();
            setUpGameLogic();
        }
        public void setUpGameLogic()
        {
            Button[] buttonsArrays = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            LogicManager = new TiCTaCToeLogicManager(buttonsArrays);
        }


        #region
        private void button1_Click(object sender, EventArgs e)
        {
            LogicManager.ButtonsClicked(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogicManager.ButtonsClicked(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogicManager.ButtonsClicked(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogicManager.ButtonsClicked(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogicManager.ButtonsClicked(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogicManager.ButtonsClicked(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LogicManager.ButtonsClicked(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LogicManager.ButtonsClicked(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LogicManager.ButtonsClicked(8);
        }
        #endregion
    }
}
