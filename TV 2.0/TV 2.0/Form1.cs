﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_2._0
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            label1.BackColor = System.Drawing.Color.Transparent;
            
        }
        
        int c = 1;
        string s = " ";
        int gr =15;
        int per = 0;
        int volume = 15;
        int yark = 50;
        int kontr = 50;
        int contr = 0;
        int yarc = 0;
        int menu = 0;

        private void Button3_Click(object sender, EventArgs e)
        {
            timer8.Interval = 2000;
            timer8.Start();
            label1.Visible = true;
            if (s.Length > 2)
                s = s;
            else
                s = s + '1';
            label1.Text = s;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            timer8.Interval = 2000;
            timer8.Start();
            label1.Visible = true;
            if (s.Length > 2)
                s = s;
            else
                s = s + '2';
            label1.Text = s;
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            timer8.Interval = 2000;
            timer8.Start();
            label1.Visible = true;
            if (s.Length > 2)
                s = s;
            else
                s = s + '3';
            label1.Text = s;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            timer8.Interval = 2000;
            timer8.Start();
            label1.Visible = true;
            if (s.Length > 2)
                s = s;
            else
                s = s + '4';
            label1.Text = s;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            timer8.Interval = 2000;
            timer8.Start();
            label1.Visible = true;
            if (s.Length > 2)
                s = s;
            else
                s = s + '5';
            label1.Text = s;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            timer8.Interval = 2000;
            timer8.Start();
            label1.Visible = true;
            if (s.Length > 2)
                s = s;
            else
                s = s + '6';
            label1.Text = s;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            timer8.Interval = 2000;
            timer8.Start();
            label1.Visible = true;
            if (s.Length > 2)
                s = s;
            else
                s = s + '7';
            label1.Text = s;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            timer8.Interval = 2000;
            timer8.Start();
            label1.Visible = true;
            if (s.Length > 2)
                s = s;
            else
                s = s + '8';
            label1.Text = s;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            timer8.Interval = 2000;
            timer8.Start();
            label1.Visible = true;
            if (s.Length > 2)
                s = s;
            else
                s = s + '9';
            label1.Text = s;
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            if (s.Length > 2)
                s = s;
            else
                s = s + '0';
            label1.Text = s;
        }
        public void Canal(int c)
        {
            if (c == 1)
                pictureBox2.Image = Properties.Resources.imgonline_com_ua_Resize_CH6TIf9CpHEX4V;
            if (c == 2)
                pictureBox2.Image = Properties.Resources._10;
            if (c == 3)
                pictureBox2.Image = Properties.Resources._13;
            if (c == 4)
                pictureBox2.Image = Properties.Resources._14;
            if (c == 5)
                pictureBox2.Image = Properties.Resources._15;
            if (c == 6)
                pictureBox2.Image = Properties.Resources._16;
            if (c == 7)
                pictureBox2.Image = Properties.Resources._17;
            if (c == 8)
                pictureBox2.Image = Properties.Resources._18;
            if (c == 9)
                pictureBox2.Image = Properties.Resources._19;
            if (c == 10)
                pictureBox2.Image = Properties.Resources._3;
            if (c == 11)
                pictureBox2.Image = Properties.Resources._4;
            if (c == 12)
                pictureBox2.Image = Properties.Resources._6;
            if (c == 13)
                pictureBox2.Image = Properties.Resources._7;
            if (c == 14)
                pictureBox2.Image = Properties.Resources._8;
            if (c == 15)
                pictureBox2.Image = Properties.Resources._9;
            if(c==16)
                pictureBox2.Image = Properties.Resources._7;
            if (c == 17)
                pictureBox2.Image = Properties.Resources._19;
            if (c == 18)
                pictureBox2.Image = Properties.Resources._3;
            if (c == 19)
                pictureBox2.Image = Properties.Resources._15;
            if (c == 20)
                pictureBox2.Image = Properties.Resources._16;
            if (c == 0)
                pictureBox2.Image = Properties.Resources._3;
                
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(per==0)
            {
                pictureBox3.Visible = false;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button19.Enabled = true;
                button22.Enabled = true;
                button2.Enabled = true;
                pictureBox2.Image = Properties.Resources.imgonline_com_ua_Resize_CH6TIf9CpHEX4V;
                timer1.Enabled = true;
                per++;
                canal = 1;
            }
            else
            {

                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button19.Enabled = false;
                button2.Enabled = false;
                button22.Enabled = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                textBox2.Visible = false;

                pictureBox2.BackColor = Color.Black;
                pictureBox3.Visible = true;
                per = 0;
            }
            textBox1.Visible = false;
            int volume = 15;


        }

     

        private void Button16_Click_1(object sender, EventArgs e)
        {
            timer8.Interval = 2000;
            timer8.Start();
            label1.Visible = true;
            s = s + '0';
            label1.Text = s;
        }
        int canal;
        int countOK = 0;
        private void Button17_Click(object sender, EventArgs e)
        {
            if(menu==1)
            {
                countOK++;
                switch (countOK)
                {
                    case 1:
                        if (marker == 1)
                        {
                            radioButton1.Visible = false;
                            radioButton2.Visible = false;
                            radioButton3.Visible = false;
                            textBox2.Visible = true;
                            pictureBox2.Image = Properties.Resources.tekstura_siniy_fon_ten_50468_1440x900;
                            textBox2.Text = "Поиск каналов";
                            timer3.Interval = 5000;
                            timer3.Start();
                            timer4.Interval = 5000;
                            timer4.Start();
                            button22.Enabled = false;
                            countOK = 0;
                        }
                        if (marker == 2)
                        {
                            textBox2.Visible = true;
                            radioButton1.Visible = false;
                            radioButton2.Visible = false;
                            radioButton3.Visible = false;
                            button22.Enabled = false;
                            yarc = 1;
                            textBox2.Text = "Яркость: " + yark;
                        }
                        if (marker == 3)
                        {
                            textBox2.Visible = true;
                            button22.Enabled = false;
                            radioButton1.Visible = false;
                            radioButton2.Visible = false;
                            radioButton3.Visible = false;
                            textBox2.Text = "Контрастность" + kontr;
                            contr = 1;
                        }
                        break;
                    case 2:
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                        button6.Enabled = true;
                        button7.Enabled = true;
                        button8.Enabled = true;
                        button9.Enabled = true;
                        button10.Enabled = true;
                        button11.Enabled = true;
                        button12.Enabled = true;
                        button13.Enabled = true;
                        button14.Enabled = true;
                        button15.Enabled = true;
                        button16.Enabled = true;
                        button17.Enabled = true;
                        button20.Enabled = true;
                        button21.Enabled = true;
                        button19.Enabled = true;
                        button22.Enabled = true;
                        button2.Enabled = true;
                        button22.Enabled = true;
                        textBox2.Visible = false;
                        menu = 0;
                        countOK = 0;
                        Canal(1);
                        break;
                }

            }
           

           

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            label2.Text = Convert.ToString(gr);
            
        }
        int p = 0;
        int marker = 1;
        

        
        private void Button11_Click(object sender, EventArgs e)
        {
            if(menu==1)
            {
                ++p;
                switch (p)
                {
                    case 1:
                        radioButton1.Checked = false;
                        radioButton2.Checked = true;
                        marker = 2;
                        break;
                    case 2:
                        radioButton2.Checked = false;
                        radioButton3.Checked = true;
                        marker = 3;
                        break;
                    case 3:
                        radioButton1.Checked = true;
                        radioButton3.Checked = false;
                        marker = 1;
                       
                        p = 0;
                        break;


                }
            }
            else
            {
                label1.Visible = false;
                if (canal > 59)
                    canal = 0;
                else
                    canal++;
                Canal(canal);
            }
        }
        int y = 0;
        private void Button12_Click(object sender, EventArgs e)
        {
            if(menu==1)
            {
                ++y;
               


                switch (marker)
                {
                    case 1:
                        radioButton1.Checked = false;
                        radioButton3.Checked = true;
                        marker = 3;
                        break;
                    case 2:
                        radioButton2.Checked = false;
                        radioButton1.Checked = true;
                        marker = 1;
                        break;
                    case 3:
                        radioButton3.Checked = false;
                        radioButton2.Checked = true;
                        marker = 2;
                        break;
                        


                }
            }
            else
            {
                label1.Visible = false;
                if (canal < 0)
                    canal = 59;
                else
                    canal--;
                Canal(canal);
            }


            
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            
            if (per == 0)
            {
                pictureBox3.Visible = false;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button19.Enabled = true;
                button22.Enabled = true;
                button2.Enabled = true;
                pictureBox2.Image = Properties.Resources.imgonline_com_ua_Resize_CH6TIf9CpHEX4V;
                timer1.Enabled = true;
                per++;
                canal = 1;
            }
            else
            {

                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button22.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button19.Enabled = false;
                button2.Enabled = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                textBox2.Visible = false;

                pictureBox3.Visible = true;
                per = 0;
            }
          
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.tekstura_siniy_fon_ten_50468_1440x900;
            textBox2.Text = "Поиск каналов";
            timer3.Interval = 5000;
            timer3.Start();
            timer4.Interval=5000;
            timer4.Start();

        }

        private void Button20_Click(object sender, EventArgs e)
        {
            canal++;
            Canal(canal);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            canal--;
            Canal(canal);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            timer2.Stop();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if(yarc==1)
            {
                yark++;
                if (yark >= 100)
                    yark = 100;
                textBox2.Text = "Яркость: " + yark;

            }
            if(contr==1)
            {
                kontr++;
                if (kontr >= 100)
                    kontr = 100;
                textBox2.Text = "Контрастность: " + kontr;
            }
            if(menu==0)
            {
                if (volume >= 50)
                    volume = 50;
                else
                    volume++;
                textBox1.Text = "Громкость: " + volume;
                textBox1.Visible = true;
                timer2.Interval = 5000;
                timer2.Start();

            }
                
                
            
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (yarc == 1)
            {
                yark--;
                if (yark <= 0)
                    yark = 0;
                textBox2.Text = "Яркость: " + yark;

            }
            if(contr==1)
            {
                kontr--;
                if (kontr <= 0)
                    kontr = 0;
                textBox2.Text = "Контрастность: " + kontr;
            }
            if(menu==0)
            {
                if (volume <= 0)
                    volume = 0;
                else
                    volume--;

                textBox1.Text = "Громкость: " + volume;
                textBox1.Visible = true;
                timer2.Interval = 5000;
                timer2.Start();

            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.tekstura_siniy_fon_ten_50468_1440x900;
            textBox2.Text = "Поиск каналов";
            timer3.Interval = 5000;
            timer3.Start();
            timer4.Interval = 5000;
            timer4.Start();
        }
        int clickCount = 0;
        
        private void Button22_Click(object sender, EventArgs e)
        {
            
            ++clickCount;
            switch (clickCount)
            {
                case 1:
                    
                    menu = 1;
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton1.Checked = true;
                    pictureBox2.Image = Properties.Resources.tekstura_siniy_fon_ten_50468_1440x900;
                    yarc = 1;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                  
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button20.Enabled = false;
                    button21.Enabled = false;
                    button19.Enabled = false;

                    break;
                case 2:
                    menu = 0;
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button16.Enabled = true;
                    button17.Enabled = true;
                    button20.Enabled = true;
                    button21.Enabled = true;
                    button19.Enabled = true;
                    button22.Enabled = true;
                    button2.Enabled = true;
                    yarc = 0;
                    clickCount = 0;
                    menu = 0;
                    break;


            }

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            textBox2.Text = "Загрузка каналов";
            timer4.Stop();
            timer5.Interval = 5000;
            timer5.Start();

        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            textBox2.Text = "Поиск завершен";
            timer5.Stop();
            timer6.Interval = 2000;
            timer6.Start();
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            timer6.Stop();
            Canal(1);
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button23_Click(object sender, EventArgs e)
        {
            
        }

        private void Button24_Click(object sender, EventArgs e)
        {
           
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            if (yarc == 1 && contr==0)
            {
                if (yark >= 100)
                    yark = 100;
                else
                    yark++;
                textBox2.Text = "Яркость " + yark;
                textBox2.Visible = true;
                timer7.Interval = 5000;
                timer7.Start();
            }
            else
            {
                if (kontr >= 100)
                    kontr = 100;
                else
                    kontr++;
                textBox2.Text = "Контрастность " + kontr;
                textBox2.Visible = true;
                timer7.Interval = 5000;
                timer7.Start();
            }
           
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            if (yarc == 1 && contr == 0)
            {
                if (yark >= 100)
                    yark = 100;
                else
                    yark--;
                textBox2.Text = "Яркость " + yark;
                textBox2.Visible = true;
                timer7.Interval = 5000;
                timer7.Start();
            }
            else
            {
                if (kontr >= 100)
                    kontr = 100;
                else
                    kontr--;
                textBox2.Text = "Контрастность " + kontr;
                textBox2.Visible = true;
                timer7.Interval = 5000;
                timer7.Start();
            }
        }

        private void Timer7_Tick(object sender, EventArgs e)
        {
        
            timer7.Start();
            Canal(1);
            textBox2.Visible = false;
            yarc = 0;
            contr = 0;
           

        }

        private void Button25_Click(object sender, EventArgs e)
        {
      
            
        }

        private void Timer8_Tick(object sender, EventArgs e)
        {
            try
            {
                canal = Convert.ToInt32(label1.Text);


                if (canal < 20)
                {
                    Canal(canal);

                }
                else
                {
                    canal = 0;
                    Canal(canal);
                }
            }
            catch
            {
                Canal(canal);
            }



            label1.Visible = false;
            s = " ";
            timer8.Stop();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
