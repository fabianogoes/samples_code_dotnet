using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TesteProcess
{
    public partial class Frm_TesteProcess : Form
    {
        public Frm_TesteProcess()
        {
            InitializeComponent();
        }

        private void Btn_Process_Click(object sender, EventArgs e)
        {
            this.Dgv_Process.AutoGenerateColumns = false;
            this.Dgv_Process.DataSource = Process.GetProcesses();
        }

        private void Btn_KillProcess_Click(object sender, EventArgs e)
        {
            string processName = this.Dgv_Process.Rows[this.Dgv_Process.CurrentRow.Index].Cells[1].Value.ToString();
            Process[] lista = Process.GetProcessesByName(processName);
            foreach (Process process in lista)
            {
                process.Kill();
            }
        }

        private void Dgv_Process_Click(object sender, EventArgs e)
        {
            if (this.Dgv_Process.Rows != null && this.Dgv_Process.Rows.Count > 0)
            {
                this.Lbl_ProcessSelect.Text = ">>> " + this.Dgv_Process.Rows[this.Dgv_Process.CurrentRow.Index].Cells[1].Value.ToString() + " <<<";
            }
        }

        private void Dgv_Process_SelectionChanged(object sender, EventArgs e)
        {
            this.Dgv_Process_Click(sender, e);
        }

        private void Frm_TesteProcess_Load(object sender, EventArgs e)
        {
            this.Btn_Process_Click(sender, e);
        }

               
    }
}
