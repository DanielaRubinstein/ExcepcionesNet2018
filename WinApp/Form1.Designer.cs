namespace WinApp
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
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroUno
            // 
            this.txtNumeroUno.Location = new System.Drawing.Point(87, 41);
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroUno.TabIndex = 0;
            // 
            // txtNumeroDos
            // 
            this.txtNumeroDos.Location = new System.Drawing.Point(87, 95);
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDos.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(98, 141);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 212);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNumeroDos);
            this.Controls.Add(this.txtNumeroUno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.Button btnAceptar;
    }
}

