using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TiCtaCToe
{
    class TiCTaCToeLogicManager
    {
        private Zone[] zoneArray = new Zone[9];

        public enum STATE
        {
            EMPTY,
            X,
            O
        }
        public class Zone
        {
            private System.Windows.Forms.Button button;
            public System.Windows.Forms.Button Button
            {
                get { return button; }
                set { button = value; }
            }
            private STATE state;
            public STATE State
            {
                get { return state; }
                set { state = value; }
            }

            public Zone(System.Windows.Forms.Button button, STATE state = STATE.EMPTY)
            {
                this.button = button;
                this.state = state;
            }
        }

        public TiCTaCToeLogicManager(System.Windows.Forms.Button[] buttonArray)
        {
            for (int i = 0; i < buttonArray.Length; i++)
            {
                zoneArray[i] = new Zone(buttonArray[i]);
            }
        }

        /// <param name="zoneId">id of the object</param>
        /// <param name = "state">state changed to</param>
        private void ChangeZoneState(Zone zone, STATE state = STATE.X)
        {
            zone.State = state;
            if (state == STATE.X)
            {
                zone.Button.Text = "X";
            }
            else
            {
                zone.Button.Text = "O";
            }
        }

        private void ChangeTextForAllButtons(String text)
        {
            foreach (Zone zone in zoneArray)
            {
                zone.Button.Text = text;
            }
        }

        public void ButtonsClicked(int clickedButtonNumber)
        {
            System.Console.WriteLine("Klik1");
            ChangeZoneState(zoneArray[clickedButtonNumber]);
            BotAction();
        }

        private void CheckForWinner()
        {
            int wonIndex = -1;
            // if else checks
            #region
            if (zoneArray[0].State == zoneArray[1].State && zoneArray[0].State == zoneArray[2].State)
            {
                wonIndex = 0;

            }
            else if (zoneArray[0].State == zoneArray[3].State && zoneArray[0].State == zoneArray[6].State)
            {
                wonIndex = 0;

            }
            else if (zoneArray[0].State == zoneArray[4].State && zoneArray[0].State == zoneArray[8].State)
            {
                wonIndex = 0;

            }
            else if (zoneArray[1].State == zoneArray[4].State && zoneArray[1].State == zoneArray[7].State)
            {
                wonIndex = 1;
            }
            else if (zoneArray[2].State == zoneArray[5].State && zoneArray[2].State == zoneArray[8].State)
            {
                wonIndex = 2;
            }
            else if (zoneArray[3].State == zoneArray[4].State && zoneArray[3].State == zoneArray[5].State)
            {
                wonIndex = 3;
            }
            else if (zoneArray[6].State == zoneArray[7].State && zoneArray[6].State == zoneArray[8].State)
            {
                wonIndex = 6;
            }
            else if (zoneArray[6].State == zoneArray[4].State && zoneArray[6].State == zoneArray[2].State)
            {
                wonIndex = 6;
            }
            #endregion

            if (wonIndex != -1)
            {
                switch (zoneArray[wonIndex].State)
                {
                    case STATE.X:
                        {
                            ChangeTextForAllButtons("Wygrałeś!");
                            break;
                        }
                    case STATE.O:
                        {
                            ChangeTextForAllButtons("Przegrałeś!");
                            break;
                        }
                }
            }
        }

        private void BotAction()
        {
            ArrayList arrayList = new ArrayList();
            foreach (Zone zone in zoneArray)
            {
                if (zone.State == STATE.EMPTY)
                {
                    arrayList.Add(zone);
                }
            }

            if (arrayList.Count != 0)
            {
                Random random = new Random();
                ChangeZoneState((Zone)arrayList[random.Next(arrayList.Count)], STATE.O);
            }
            else
            {
                CheckForWinner();
                ChangeTextForAllButtons("Remis!");
            }
            CheckForWinner();
        }
    }
}
