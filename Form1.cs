using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using TheGeogeoLibrarie;

namespace Anti_Deco_LostArk
{
    public partial class Form1 : Form
    {
        private bool onOff = false;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logTB.ScrollBars = ScrollBars.Both;

            Thread getKeyT = new Thread(GetKey) { IsBackground = true };
            getKeyT.Start();
            Thread afkT = new Thread(SimuleAntiAfk) { IsBackground = true };
            afkT.Start();
        }

        private void SimuleAntiAfk()
        {
            Point center = new Point(958, 531);
            int addPixel = 25;
            Point up = new Point(center.X, center.Y + addPixel);
            Point down = new Point(center.X, center.Y - addPixel);
            Point left = new Point(center.X - addPixel, center.Y);
            Point right = new Point(center.X + addPixel, center.Y);
            while (true)
            {
                if (onOff)
                {
                    try
                    {
                        if (rand.Next(2) == 1)
                        {
                            TheGeogeo.mouseEventMoveTo(up.X, up.Y);
                            BothClick();
                            Thread.Sleep(500);
                            TheGeogeo.mouseEventMoveTo(down.X, down.Y);
                            BothClick();
                            Thread.Sleep(500);
                        }
                        else
                        {
                            TheGeogeo.mouseEventMoveTo(left.X, left.Y);
                            BothClick();
                            Thread.Sleep(500);
                            TheGeogeo.mouseEventMoveTo(right.X, right.Y);
                            BothClick();
                            Thread.Sleep(500);
                        }
                        if (rand.Next(2) == 1)
                        {
                            BothClick(true);
                        }

                        SendLog("Done at " + DateTime.Now);
                    }
                    catch (Exception ex)
                    {
                        SendLog(ex.Message + " at " + DateTime.Now);
                    }
                }
                try
                {
                    Thread.Sleep((int)timeActionNum.Value * 1000);
                }
                catch (Exception ex)
                {
                    SendLog(ex.Message);
                    Thread.Sleep(300000);
                }
            }
        }

        private void BothClick(bool inverse = false)
        {
            if (leftRB.Checked)
            {
                if (!inverse) TheGeogeo.mouseEventLeftClick();
                else TheGeogeo.mouseEventRightClick();
            }
            else
            {
                if (!inverse) TheGeogeo.mouseEventRightClick();
                else TheGeogeo.mouseEventLeftClick();
            }
        }

        private void GetKey()
        {
            while (true)
            {
                if (TheGeogeo.GetAsyncKeyState(Keys.F8) < 0)
                {
                    onOff = !onOff;
                    if (onOff) ChangeLabel("ON", Color.Green);
                    else ChangeLabel("OFF", Color.Red);
                }
                Thread.Sleep(120);
            }
        }

        private void ChangeLabel(string str, Color color)
        {
            onOffL.Invoke(new MethodInvoker(delegate
            {
                onOffL.Text = str;
                onOffL.ForeColor = color;
            }));
        }

        private void SendLog(string str)
        {
            logTB.Invoke(new MethodInvoker(delegate
            {
                logTB.AppendText(str);
                logTB.AppendText(Environment.NewLine);
            }));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }
    }
}