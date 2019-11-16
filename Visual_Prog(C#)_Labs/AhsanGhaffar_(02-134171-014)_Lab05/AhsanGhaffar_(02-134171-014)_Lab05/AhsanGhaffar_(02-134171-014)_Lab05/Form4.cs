using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mohib_121_lab_5__vp_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal wings1 =300,fish1 =300, prawns1=300, fries1 =300, wongtong1 =300,tikka1=300,roll1=300,biharikabab1=300,burger1=300,broast1=300,oreoshake1=300,brownie1=300,waffle1=300,lava1=300,choco1=300;
            decimal wing_total = 0, fish_total = 0, prawns_total=0,fries_total =0,wongtong_total=0,tikka_total=0, roll_total=0, behari_total=0,burger_total =0,broast_total=0,oreo_total =0,brownie_total=0, choco_total=0,waffle_total=0, lava_total=0;
            
            wing_total = wings1 *wingQ.Value;
            fish_total =fish1 *fishQ.Value;
            prawns_total = prawns1 * prawnQ.Value;
            fries_total = fries1 *friesQ.Value;
            wongtong_total = wongtong1 * wongQ.Value;
            tikka_total = tikka1 * tikkaQ.Value;
            roll_total = roll1 * rollQ.Value;
            behari_total = biharikabab1 * behariQ.Value;
            burger_total = burger1 * burgerQ.Value;
            broast_total = broast1* broastQ.Value;
            oreo_total = oreoshake1 * oreoQ.Value;
            brownie_total = brownie1 * brownieQ.Value;
            waffle_total = waffle1 *waffleQ.Value;
            choco_total = choco1 * chocoQ.Value;
            lava_total = lava1 *lavaQ.Value;
            total = wing_total +fish_total + fries_total + prawns_total + wongtong_total + tikka_total + behari_total + roll_total + burger_total + broast_total + brownie_total + oreo_total + waffle_total + choco_total + lava_total;
           // total = wing_total + fish_total+fries_total+prawns_total+wongtong_total+tikka_total+roll_total;
            totalbill.Text = total.ToString();
        }

        private void wingsc_CheckedChanged(object sender, EventArgs e)
        {
            if(wingsc.Checked)
                wingQ.Enabled = true;
            
            else
                wingQ.Enabled = false;
            
        }

        private void fish_CheckedChanged(object sender, EventArgs e)
        {
            if (fish.Checked)
                fishQ.Enabled = true;

            else
                fishQ.Enabled = false;
        }

        private void prawns_CheckedChanged(object sender, EventArgs e)
        {
            if (prawns.Checked)
                prawnQ.Enabled = true;

            else
                prawnQ.Enabled = false;
        }

        private void fries_CheckedChanged(object sender, EventArgs e)
        {

            if (fries.Checked)
                friesQ.Enabled = true;

            else
                friesQ.Enabled = false;
        }

        private void wongtong_CheckedChanged(object sender, EventArgs e)
        {

            if (wongtong.Checked)
                wongQ.Enabled = true;

            else
                wongQ.Enabled = false;
        }

        private void tikka_CheckedChanged(object sender, EventArgs e)
        {

            if (tikka.Checked)
                tikkaQ.Enabled = true;

            else
                tikkaQ.Enabled = false;
        }

        private void roll_CheckedChanged(object sender, EventArgs e)
        {
            if (roll.Checked)
                rollQ.Enabled = true;

            else
                rollQ.Enabled = false;
           
          
        }

        private void biharikebab_CheckedChanged(object sender, EventArgs e)
        {
            if (biharikebab.Checked)
                behariQ.Enabled = true;

            else
                behariQ.Enabled = false;
        }

        private void burger_CheckedChanged(object sender, EventArgs e)
        {

            if (burger.Checked)
                burgerQ.Enabled = true;

            else
                burgerQ.Enabled = false;
        }

        private void broast_CheckedChanged(object sender, EventArgs e)
        {
            if (broast.Checked)
                broastQ.Enabled = true;

            else
                broastQ.Enabled = false;
        }

        private void oreoshake_CheckedChanged(object sender, EventArgs e)
        {
            if (oreoshake.Checked)
                oreoQ.Enabled = true;

            else
                oreoQ.Enabled = false;
        }

        private void wafflecone_CheckedChanged(object sender, EventArgs e)
        {
            if (wafflecone.Checked)
                waffleQ.Enabled = true;

            else
                waffleQ.Enabled = false;
        }

        private void browniefudge_CheckedChanged(object sender, EventArgs e)
        {
            if (browniefudge.Checked)
                brownieQ.Enabled = true;

            else
                brownieQ.Enabled = false;
        }

        private void lavacake_CheckedChanged(object sender, EventArgs e)
        {
            if (lavacake.Checked)
                lavaQ.Enabled = true;

            else
                lavaQ.Enabled = false;

        }

        private void chococone_CheckedChanged(object sender, EventArgs e)
        {
            if (chococone.Checked)
                chocoQ.Enabled = true;

            else
                chocoQ.Enabled = false;
        }

        private void wingQ_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void burgerQ_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lavacake_CheckedChanged_1(object sender, EventArgs e)
        {
            if (lavacake.Checked)
                lavaQ.Enabled = true;

            else
                lavaQ.Enabled = false;
        }

        private void chococone_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chococone.Checked)
                chocoQ.Enabled = true;

            else
                chocoQ.Enabled = false;
        }
    }
}
