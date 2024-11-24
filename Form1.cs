using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecTuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e) //Execute the script in the Text Box
        {
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void Clear_Click(object sender, EventArgs e) //Clears the Text Box
        {
            richTextBox1?.Clear();
        }

        private void KillRoblox_Click(object sender, EventArgs e) //Kills roblox, can be useful if needing to quickly kill roblox for injection problem
        {
            ForlornApi.Api.KillRoblox();
        }

        private void Inject_Click(object sender, EventArgs e) //Injects the DLL/API into Roblox
        {
            ForlornApi.Api.Inject();
        }
    }
}
