using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    class Strip
    {

        private String data;

        public void SetData(string input)
        {
            data = input;
            addEmtyIfnotThere();
        }

        public String getData()
        {
            return data;
        }

        public char Read(int index)
        {
            if (data.Length > index)
                return data[index];
            else
                return '_';
        }

        public void Write(char c, int index)
        {
            StringBuilder sb = new StringBuilder(data);

            while (sb.Length <= index)
            {
                sb.Append("_");
            }

            sb[index] = c;
            data = sb.ToString();
            addEmtyIfnotThere();
        }


        private void addEmtyIfnotThere()
        {
            if (data.Length == 0)
                data = "_";
            else
            {
                if (data[data.Length - 1] != '_')
                {
                    data += "_";
                }
            }
        }
    }
}
