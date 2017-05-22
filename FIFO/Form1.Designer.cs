namespace FIFO
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
            this.btnProceso = new System.Windows.Forms.Button();
            this.txtResultadoProcesos = new System.Windows.Forms.TextBox();
            this.txtCiclos = new System.Windows.Forms.TextBox();
            this.txtInformación = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProceso
            // 
            this.btnProceso.Location = new System.Drawing.Point(18, 357);
            this.btnProceso.Name = "btnProceso";
            this.btnProceso.Size = new System.Drawing.Size(136, 56);
            this.btnProceso.TabIndex = 0;
            this.btnProceso.Text = "Proceso";
            this.btnProceso.UseVisualStyleBackColor = true;
            this.btnProceso.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultadoProcesos
            // 
            this.txtResultadoProcesos.Location = new System.Drawing.Point(12, 70);
            this.txtResultadoProcesos.Multiline = true;
            this.txtResultadoProcesos.Name = "txtResultadoProcesos";
            this.txtResultadoProcesos.Size = new System.Drawing.Size(316, 228);
            this.txtResultadoProcesos.TabIndex = 1;
            // 
            // txtCiclos
            // 
            this.txtCiclos.Location = new System.Drawing.Point(540, 70);
            this.txtCiclos.Multiline = true;
            this.txtCiclos.Name = "txtCiclos";
            this.txtCiclos.Size = new System.Drawing.Size(458, 228);
            this.txtCiclos.TabIndex = 2;
            this.txtCiclos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtInformación
            // 
            this.txtInformación.Location = new System.Drawing.Point(265, 357);
            this.txtInformación.Multiline = true;
            this.txtInformación.Name = "txtInformación";
            this.txtInformación.Size = new System.Drawing.Size(474, 113);
            this.txtInformación.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Procesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciclos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(983, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 56);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1131, 546);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInformación);
            this.Controls.Add(this.txtCiclos);
            this.Controls.Add(this.txtResultadoProcesos);
            this.Controls.Add(this.btnProceso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProceso;
        private System.Windows.Forms.TextBox txtResultadoProcesos;
        private System.Windows.Forms.TextBox txtCiclos;
        private System.Windows.Forms.TextBox txtInformación;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
    }
}

