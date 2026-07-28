using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private short Hours;
        private short Minutes;
        private short Seconds;

       
        public Form1()
        {
            InitializeComponent();
        }
      
        private void UpDateToTimer()
        {
            char Prefix = '0';

            if(Hours <= 9)
                mtbHours.Text = Prefix + Hours.ToString();
            else
                mtbHours.Text =  Hours.ToString();

            if (Minutes <= 9)
                mtbMinutes.Text = Prefix + Minutes.ToString();
            else
                mtbMinutes.Text = Minutes.ToString();

            if (Seconds <= 9)
                mtbSeconds.Text = Prefix + Seconds.ToString();
            else
                mtbSeconds.Text = Seconds.ToString();

         }
        private void SetTimer()
        {
            if (Hours > 0)
            {
                if (Minutes == 0)
                {
                    --Hours;
                    Minutes = 59;
                    Seconds = 60;
                }

            }
            if (Minutes > 0)
            {
                if (Seconds == 0)
                {
                    --Minutes;
                    Seconds = 60;
                }


            }
            if (Hours == 0 && Minutes == 0 && Seconds == 0)
            {
                timer1.Enabled = false;
                return;
            }
            
            UpDateToTimer();
            --Seconds;
        }
        private void GetInput()
        {
            Hours = Convert.ToInt16(mtbHours.Text);
            Minutes = Convert.ToInt16(mtbMinutes.Text);
            Seconds = Convert.ToInt16(mtbSeconds.Text);
        }
        private void Reset()
        {
            timer1.Enabled = false;

            mtbHours.Text = "00";
            mtbMinutes.Text = "00";
            mtbSeconds.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetTimer();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            GetInput();
            timer1.Enabled = true;
        }

        private void Rest_Clickt(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
    }

