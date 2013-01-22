namespace TesteProcess
{
    partial class Frm_TesteProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Process = new System.Windows.Forms.Button();
            this.Btn_KillProcess = new System.Windows.Forms.Button();
            this.Dgv_Process = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_ProcessSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Process)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Process
            // 
            this.Btn_Process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Process.Location = new System.Drawing.Point(12, 12);
            this.Btn_Process.Name = "Btn_Process";
            this.Btn_Process.Size = new System.Drawing.Size(568, 36);
            this.Btn_Process.TabIndex = 0;
            this.Btn_Process.Text = "Lista Process";
            this.Btn_Process.UseVisualStyleBackColor = true;
            this.Btn_Process.Click += new System.EventHandler(this.Btn_Process_Click);
            // 
            // Btn_KillProcess
            // 
            this.Btn_KillProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_KillProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_KillProcess.Location = new System.Drawing.Point(12, 495);
            this.Btn_KillProcess.Name = "Btn_KillProcess";
            this.Btn_KillProcess.Size = new System.Drawing.Size(169, 36);
            this.Btn_KillProcess.TabIndex = 2;
            this.Btn_KillProcess.Text = "Kill Process";
            this.Btn_KillProcess.UseVisualStyleBackColor = true;
            this.Btn_KillProcess.Click += new System.EventHandler(this.Btn_KillProcess_Click);
            // 
            // Dgv_Process
            // 
            this.Dgv_Process.AllowUserToOrderColumns = true;
            this.Dgv_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Process.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Process.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProcessName,
            this.StartTime});
            this.Dgv_Process.Location = new System.Drawing.Point(12, 54);
            this.Dgv_Process.Name = "Dgv_Process";
            this.Dgv_Process.RowHeadersVisible = false;
            this.Dgv_Process.Size = new System.Drawing.Size(568, 398);
            this.Dgv_Process.TabIndex = 3;
            this.Dgv_Process.SelectionChanged += new System.EventHandler(this.Dgv_Process_SelectionChanged);
            this.Dgv_Process.Click += new System.EventHandler(this.Dgv_Process_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // ProcessName
            // 
            this.ProcessName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProcessName.DataPropertyName = "ProcessName";
            this.ProcessName.HeaderText = "ProcessName";
            this.ProcessName.Name = "ProcessName";
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            // 
            // Lbl_ProcessSelect
            // 
            this.Lbl_ProcessSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ProcessSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProcessSelect.Location = new System.Drawing.Point(10, 455);
            this.Lbl_ProcessSelect.Name = "Lbl_ProcessSelect";
            this.Lbl_ProcessSelect.Size = new System.Drawing.Size(568, 30);
            this.Lbl_ProcessSelect.TabIndex = 4;
            this.Lbl_ProcessSelect.Text = "...";
            this.Lbl_ProcessSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_TesteProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 538);
            this.Controls.Add(this.Lbl_ProcessSelect);
            this.Controls.Add(this.Dgv_Process);
            this.Controls.Add(this.Btn_KillProcess);
            this.Controls.Add(this.Btn_Process);
            this.Name = "Frm_TesteProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Process";
            this.Load += new System.EventHandler(this.Frm_TesteProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Process)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Process;
        private System.Windows.Forms.Button Btn_KillProcess;
        private System.Windows.Forms.DataGridView Dgv_Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.Label Lbl_ProcessSelect;
    }
}

