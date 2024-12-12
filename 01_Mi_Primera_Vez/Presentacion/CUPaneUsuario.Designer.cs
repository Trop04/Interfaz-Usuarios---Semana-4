namespace _01_Mi_Primera_Vez.Presentacion
{
    partial class CUPaneUsuario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBusquedaU = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 913);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 989);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(8, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnBusquedaU
            // 
            this.btnBusquedaU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusquedaU.BackColor = System.Drawing.Color.Indigo;
            this.btnBusquedaU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusquedaU.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaU.ForeColor = System.Drawing.Color.White;
            this.btnBusquedaU.Location = new System.Drawing.Point(198, 23);
            this.btnBusquedaU.Name = "btnBusquedaU";
            this.btnBusquedaU.Size = new System.Drawing.Size(135, 26);
            this.btnBusquedaU.TabIndex = 1;
            this.btnBusquedaU.Text = "Buscar Usuario";
            this.btnBusquedaU.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Indigo;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(62, 29);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(135, 26);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir Usuario";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnBusquedaU);
            this.panel2.Location = new System.Drawing.Point(286, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 64);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(1020, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 989);
            this.panel3.TabIndex = 3;
            // 
            // CUPaneUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Name = "CUPaneUsuario";
            this.Size = new System.Drawing.Size(1101, 989);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBusquedaU;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
