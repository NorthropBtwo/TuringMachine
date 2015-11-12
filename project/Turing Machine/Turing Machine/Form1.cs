using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Turing_Machine
{

    public partial class Form1 : Form
    {

        private TuMa tuma = new TuMa();

        bool resetState = false;
        string resetInput = "101#101";

        Control[] saveControls;

    public Form1()
        {
            InitializeComponent();

            cmd_reset_Click(null, null);
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            saveControls = new Control[] {txt_strip, txt_startState , txt_acceptState, txt_rejectState, txt_transitions};

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip_testStrip_Click(object sender, EventArgs e)
        {
            Strip strip = new Strip();
            String outd = "";
            strip.SetData("0123456");
            outd = strip.getData();
            strip.Write('9', 2);
            outd = strip.getData();
            strip.Write('8', 6);
            outd = strip.getData();
            strip.Write('7', 7);
            outd = strip.getData();
            strip.Write('0', 20);
            outd = strip.getData();
        }


        // input and View --------------------------------------------------------------------------------------------------

        private void UpdateView()
        {

            int backupSelectTxt_strip = txt_strip.SelectionStart;
            txt_strip.Text = tuma.Strip.getData();


            txt_aktState.Text = tuma.State;
            txt_aktStripPos.Text = tuma.StripPos.ToString();

            char wc;
            char move;
            int startCmd, lengthCmd;
            int backupSelect = txt_transitions.SelectionStart;
            string nextState;

            txt_transitions.SuspendPainting();
            try
            {
                txt_transitions.SelectAll();
                txt_transitions.SelectionColor = txt_transitions.ForeColor;
                tuma.TransMgr.GetTans(txt_aktState.Text, tuma.Strip.Read(Convert.ToInt32(txt_aktStripPos.Text)), out wc, out move, out nextState, out startCmd, out lengthCmd);
                txt_transitions.SelectionStart = startCmd;
                txt_transitions.SelectionLength = lengthCmd;
                txt_transitions.SelectionColor = Color.Red;
            }
            catch (Exception) { };
            txt_transitions.Select(backupSelect, 0);
            txt_transitions.ResumePainting();



            txt_strip.SelectAll();
            txt_strip.SelectionColor = txt_strip.ForeColor;

            txt_strip.Select(tuma.StripPos, 1);
            txt_strip.SelectionColor = Color.Red;
            txt_strip.Select(backupSelectTxt_strip, 0);
        }

        private void txt_transitions_TextChanged(object sender, EventArgs e)
        {
            tuma.TransMgr.SetTransitions(txt_transitions.Lines);
            UpdateView();
        }



        private void cmd_step_Click(object sender, EventArgs e)
        {
            if (resetState)
            {
                resetState = false;
                resetInput = txt_strip.Text;
            }

            try
            {
                tuma.Step();

                if (tuma.State == txt_acceptState.Text)
                {
                    MessageBox.Show("input is accepted");
                }
                else if (tuma.State == txt_rejectState.Text)
                {
                    MessageBox.Show("input is rejected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

            UpdateView();
        }

        private void cmd_reset_Click(object sender, EventArgs e)
        {
            tuma.State = txt_startState.Text;
            tuma.StripPos = 0;

            tuma.Strip.SetData(resetInput);
            resetState = true;


            UpdateView();
        }


        // testing --------------------------------------------------------------------------------------------------

        private void cmd_test1_Click(object sender, EventArgs e)
        {
            int inputlength = Convert.ToInt32(txt_test1InputLength.Text);
            char[] inputAlphabet = { '0', '1', '#' };
            TuMa testTuma = new TuMa();
            testTuma.TransMgr.SetTransitions(txt_transitions.Lines);

            string sAcc = txt_acceptState.Text;
            string sRej = txt_rejectState.Text;

            int iMax = 0;
            for (int i = 1; i <= inputlength; i++)
            {
                iMax += (int)(Math.Pow(inputAlphabet.Length, i) + 0.001f);
            }

            try
            {
                for (int i = 0; i <= iMax; i++) //-1 = emty , 0 = '0' , 1='1' , 2='#' ....
                {
                    string aktInput = generateInput(inputAlphabet, i);
                    testTuma.StripPos = 0;
                    testTuma.State = txt_startState.Text;
                    testTuma.Strip.SetData(aktInput);

                    while (testTuma.State != sAcc && testTuma.State != sRej)
                    {
                        testTuma.Step();
                    }

                    if (testTuma.State != simulateTest1(aktInput, sAcc, sRej))
                    {
                        throw new Exception("Input: " + aktInput + ". Your Turing Machine returns a wrong result!!!");
                    }

                }

                MessageBox.Show("your Turing Machine is ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cmd_test2_Click(object sender, EventArgs e)
        {
            int inputlength = Convert.ToInt32(txt_test2InputLength.Text);
            char[] inputAlphabet = { '0', '1' };
            TuMa testTuma = new TuMa();
            testTuma.TransMgr.SetTransitions(txt_transitions.Lines);

            string sAcc = txt_acceptState.Text;
            string sRej = txt_rejectState.Text;

            int iMax = 0;
            for(int i=1;i <= inputlength;i++)
            {
                iMax += (int)(Math.Pow(inputAlphabet.Length, i) + 0.001f);
            }

            try
            {
                for (int i = 0; i <= iMax; i++) 
                {
                    string aktInput = generateInput(inputAlphabet, i);
                    testTuma.StripPos = 0;
                    testTuma.State = txt_startState.Text;
                    testTuma.Strip.SetData(aktInput);

                    while (testTuma.State != sAcc && testTuma.State != sRej)
                    {
                        testTuma.Step();
                    }

                    if (testTuma.State != simulateTest2(aktInput, sAcc, sRej))
                    {
                        throw new Exception("Input: " + aktInput + ". Your Turing Machine returns a wrong result!!!");
                    }

                }

                MessageBox.Show("your Turing Machine is ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private string generateInput(char[] inputAlphabet, int i)
        {
            string retval = "";
            int aLength = inputAlphabet.Length;
            StringBuilder sb = new StringBuilder();

            int outLength = 0;
            int power = (int)(Math.Pow(aLength, outLength)+0.001f);
            while(i >= power)
            {
                outLength++;
                i -= power;
                power = (int)(Math.Pow(aLength, outLength) + 0.001f);
            }

            while(outLength > 0)
            {
                retval += inputAlphabet[i % aLength];
                i /= aLength;

                outLength--;
            }
           
            return retval;
        }

        private string simulateTest1(string input, string sAcc, string sRej)
        {
            string[] split = input.Split('#');
            if (split.Length == 2 && split[0] == split[1])
            {
                return sAcc;
            }
            else
            {
                return sRej;
            }
        }

        private string simulateTest2(string input, string sAcc, string sRej)
        {
            int half = input.Length / 2;
            string p1 = input.Substring(0, half);
            string p2 = input.Substring(half, input.Length - half);

            if (p1 == p2)
            {
                return sAcc;
            }
            else
            {
                return sRej;
            }
        }

        //text changed -------------------------------------------------------------------------

        private void txt_aktState_TextChanged(object sender, EventArgs e)
        {
            if (tuma.State != txt_aktState.Text)
            {
                tuma.State = txt_aktState.Text;
                UpdateView();
            }
        }

        private void txt_aktStripPos_TextChanged(object sender, EventArgs e)
        {
            int newStripPos = 0;
            try
            {
                newStripPos = Convert.ToInt32(txt_aktStripPos.Text);
            }
            catch (Exception) { };

            if (tuma.StripPos != newStripPos)
            {
                tuma.StripPos = newStripPos;
                UpdateView();
            }
        }

        private void txt_strip_TextChanged(object sender, EventArgs e)
        {
            if (tuma.Strip.getData() != txt_strip.Text)
            {
                tuma.Strip.SetData(txt_strip.Text);
                UpdateView();
            }
        }

        //save--------------------------------------------------------------------------------------

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {

                Stream stream = File.Open(saveFileDialog1.FileName, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();

                foreach(Control con in saveControls)
                {
                    bformatter.Serialize(stream, con.Text);
                }

                stream.Close();

                
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {

                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();

                foreach (Control con in saveControls)
                {
                    con.Text = (String)bformatter.Deserialize(stream);

                }

                stream.Close();
            }

            resetInput = txt_strip.Text;
            cmd_reset_Click(sender, e);


        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
