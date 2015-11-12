using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Turing_Machine
{
    class TuMa
    {

        public Strip Strip = new Strip();
        public TransitionManager TransMgr = new TransitionManager();

        public string State = "Q1";
        public int StripPos = 0;

        public void Step()
        {

            char wc;
            char move;
            int startCmd, lengthCmd;
            string nextState;
            TransMgr.GetTans(State, Strip.Read(Convert.ToInt32(StripPos)), out wc, out move, out nextState, out startCmd, out lengthCmd);
            Strip.Write(wc, StripPos);
            State = nextState;
            if (move == 'L')
            {
                if (StripPos > 0)
                    StripPos--;
            }
            else if (move == 'R')
            {
                StripPos++;
            }
            else
            {
                throw new Exception("no valid R/L command");
            }

        }

    }
}
