using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class NotePad : Form
    {
        string path;
        public NotePad()
        {
            InitializeComponent();
            path = null;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFD.ShowDialog() == DialogResult.OK)
            {
                rtb_data.SaveFile(saveFD.FileName);
                rtb_data.Clear();
                path = null;
            }
        }

        private void openFD_Click(object sender, EventArgs e)
        {
           if(openFD.ShowDialog() == DialogResult.OK)
            {
                rtb_data.LoadFile(openFD.FileName);
                path = openFD.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                rtb_data.SaveFile(path);
                rtb_data.Clear();
                path = null;
            }
            else
                saveAsToolStripMenuItem_Click(null, null);
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (rtb_data.Text != "")
            {
                DialogResult = MessageBox.Show("Do you need to save edits ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DialogResult == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }

            path = null;
            rtb_data.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontD.ShowDialog() == DialogResult.OK)
            {
                if (rtb_data.SelectedText != "")
                    rtb_data.SelectionFont = fontD.Font;
                else
                    rtb_data.Font = fontD.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorD.ShowDialog() == DialogResult.OK)
            {
                if(rtb_data.SelectedText != "")
                    rtb_data.SelectionColor = colorD.Color;
                else
                    rtb_data.ForeColor = colorD.Color;
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtb_data.SelectedText != "")
                    rtb_data.SelectionBackColor = colorD.Color;
                else
                    rtb_data.BackColor = colorD.Color;
            }
        }
    }
}
