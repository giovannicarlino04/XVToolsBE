using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AURTool
{
    public partial class Form1 : Form
    {
        string File;
        AUR aur = new AUR();
        public Form1()
        {
            InitializeComponent();
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".aur Files | *.aur";
            ofd.Multiselect = false;
            ofd.Title = "Select AUR File";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            File = ofd.FileName;

            if (File == null)
                return;  // Totally redundant error checking lmao

            aur.Load(File);

            foreach (Char c in aur.chars)
            {
                comboBox1.Items.Add($"Character {c.id} - Costume {c.costume}");
            }
            for (int i = 0; i < aur.auraCount; i++)
            {
                comboBox2.Items.Add("Aura " + i.ToString());
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File == null)
                return;
            aur.Save(File);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (File == null && comboBox1.SelectedIndex == -1)
                return;

            switch (checkBox1.Checked)
            {
                case true: aur.chars[comboBox1.SelectedIndex].glare = 1; break;
                case false: aur.chars[comboBox1.SelectedIndex].glare = 0; break;

            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File == null)
                return;

            comboBox2.SelectedItem = "Aura " + aur.chars[comboBox1.SelectedIndex].aurId;

            switch (aur.chars[comboBox1.SelectedIndex].glare)
            {
                case 1: checkBox1.Checked = true; break;
                case 0: checkBox1.Checked = false; break;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (File == null && comboBox1.SelectedIndex == -1)
                return;


                aur.chars[comboBox1.SelectedIndex].aurId = short.Parse(comboBox2.SelectedItem.ToString().Replace("Aura ", ""));
        }
    }
}
