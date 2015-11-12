using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Turing_Machine
{


    class TransitionManager
    {

        private string[] transitions;

      


        public void SetTransitions(string[] transitions)
        {
            this.transitions = transitions;
        }

        public void GetTans(string state, char rc, out char wc, out char move,out string nextState, out int startCmd, out int lengthCmd)
        {
            startCmd = 0;
            for (int i=0;i<transitions.Length;i++)
            {
                string[] splitter = transitions[i].Split('\t');
                if(splitter.Length > 3 && !splitter[0].StartsWith("//") && splitter[0] == state && splitter[1][0] == rc)
                {
                    wc = splitter[2][0];
                    move = splitter[3][0];
                    lengthCmd = transitions[i].Length;
                    nextState = splitter[4];
                    return;
                }

                startCmd += transitions[i].Length +1;
            }
            throw new Exception("Transitions not found");
        }

    }
}
