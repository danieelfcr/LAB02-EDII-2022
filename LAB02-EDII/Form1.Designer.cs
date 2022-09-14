
namespace LAB02_EDII
{
    partial class Form1
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
            this.gBBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mTBBuscarDPI = new System.Windows.Forms.MaskedTextBox();
            this.gBImportar = new System.Windows.Forms.GroupBox();
            this.tBSource = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.gBDecodificar = new System.Windows.Forms.GroupBox();
            this.btnCOD = new System.Windows.Forms.Button();
            this.lblDPIDecod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mTBDPICod = new System.Windows.Forms.MaskedTextBox();
            this.gBBuscar.SuspendLayout();
            this.gBImportar.SuspendLayout();
            this.gBDecodificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBBuscar
            // 
            this.gBBuscar.Controls.Add(this.label2);
            this.gBBuscar.Controls.Add(this.btnBuscar);
            this.gBBuscar.Controls.Add(this.mTBBuscarDPI);
            this.gBBuscar.Enabled = false;
            this.gBBuscar.Location = new System.Drawing.Point(120, 434);
            this.gBBuscar.Name = "gBBuscar";
            this.gBBuscar.Size = new System.Drawing.Size(784, 190);
            this.gBBuscar.TabIndex = 5;
            this.gBBuscar.TabStop = false;
            this.gBBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(518, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(196, 45);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mTBBuscarDPI
            // 
            this.mTBBuscarDPI.Location = new System.Drawing.Point(175, 83);
            this.mTBBuscarDPI.Mask = "0000000000000";
            this.mTBBuscarDPI.Name = "mTBBuscarDPI";
            this.mTBBuscarDPI.Size = new System.Drawing.Size(308, 35);
            this.mTBBuscarDPI.TabIndex = 0;
            // 
            // gBImportar
            // 
            this.gBImportar.Controls.Add(this.tBSource);
            this.gBImportar.Controls.Add(this.btnImport);
            this.gBImportar.Location = new System.Drawing.Point(111, 151);
            this.gBImportar.Name = "gBImportar";
            this.gBImportar.Size = new System.Drawing.Size(793, 227);
            this.gBImportar.TabIndex = 4;
            this.gBImportar.TabStop = false;
            this.gBImportar.Text = "Importar";
            // 
            // tBSource
            // 
            this.tBSource.Location = new System.Drawing.Point(326, 96);
            this.tBSource.Name = "tBSource";
            this.tBSource.ReadOnly = true;
            this.tBSource.Size = new System.Drawing.Size(397, 35);
            this.tBSource.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(82, 91);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(196, 45);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Importar datos";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Talent Hub Guatemala";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "DPI:";
            // 
            // gBDecodificar
            // 
            this.gBDecodificar.Controls.Add(this.label3);
            this.gBDecodificar.Controls.Add(this.lblDPIDecod);
            this.gBDecodificar.Controls.Add(this.mTBDPICod);
            this.gBDecodificar.Controls.Add(this.btnCOD);
            this.gBDecodificar.Enabled = false;
            this.gBDecodificar.Location = new System.Drawing.Point(120, 685);
            this.gBDecodificar.Name = "gBDecodificar";
            this.gBDecodificar.Size = new System.Drawing.Size(784, 289);
            this.gBDecodificar.TabIndex = 8;
            this.gBDecodificar.TabStop = false;
            this.gBDecodificar.Text = "Codificar/Decodificar";
            // 
            // btnCOD
            // 
            this.btnCOD.Location = new System.Drawing.Point(227, 164);
            this.btnCOD.Name = "btnCOD";
            this.btnCOD.Size = new System.Drawing.Size(317, 45);
            this.btnCOD.TabIndex = 6;
            this.btnCOD.Text = "Codificar/Decodificar";
            this.btnCOD.UseVisualStyleBackColor = true;
            this.btnCOD.Click += new System.EventHandler(this.btnDecod_Click);
            // 
            // lblDPIDecod
            // 
            this.lblDPIDecod.AutoSize = true;
            this.lblDPIDecod.Location = new System.Drawing.Point(222, 235);
            this.lblDPIDecod.Name = "lblDPIDecod";
            this.lblDPIDecod.Size = new System.Drawing.Size(31, 29);
            this.lblDPIDecod.TabIndex = 11;
            this.lblDPIDecod.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "DPI:";
            // 
            // mTBDPICod
            // 
            this.mTBDPICod.Location = new System.Drawing.Point(286, 82);
            this.mTBDPICod.Mask = "0000000000000";
            this.mTBDPICod.Name = "mTBDPICod";
            this.mTBDPICod.Size = new System.Drawing.Size(308, 35);
            this.mTBDPICod.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 1043);
            this.Controls.Add(this.gBDecodificar);
            this.Controls.Add(this.gBBuscar);
            this.Controls.Add(this.gBImportar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBBuscar.ResumeLayout(false);
            this.gBBuscar.PerformLayout();
            this.gBImportar.ResumeLayout(false);
            this.gBImportar.PerformLayout();
            this.gBDecodificar.ResumeLayout(false);
            this.gBDecodificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBBuscar;
        private System.Windows.Forms.GroupBox gBImportar;
        private System.Windows.Forms.TextBox tBSource;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mTBBuscarDPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBDecodificar;
        private System.Windows.Forms.Label lblDPIDecod;
        private System.Windows.Forms.Button btnCOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mTBDPICod;
    }
}

