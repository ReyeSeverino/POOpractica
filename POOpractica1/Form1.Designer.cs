namespace POOpractica1
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
            this.btn_Leer = new System.Windows.Forms.Button();
            this.btn_Escribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Leer
            // 
            this.btn_Leer.Location = new System.Drawing.Point(78, 200);
            this.btn_Leer.Name = "btn_Leer";
            this.btn_Leer.Size = new System.Drawing.Size(199, 83);
            this.btn_Leer.TabIndex = 1;
            this.btn_Leer.Text = "Leer";
            this.btn_Leer.UseVisualStyleBackColor = true;
            // 
            // btn_Escribir
            // 
            this.btn_Escribir.Location = new System.Drawing.Point(78, 60);
            this.btn_Escribir.Name = "btn_Escribir";
            this.btn_Escribir.Size = new System.Drawing.Size(199, 70);
            this.btn_Escribir.TabIndex = 2;
            this.btn_Escribir.Text = "Escribir";
            this.btn_Escribir.UseVisualStyleBackColor = true;
            this.btn_Escribir.Click += new System.EventHandler(this.btn_Escribir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 351);
            this.Controls.Add(this.btn_Escribir);
            this.Controls.Add(this.btn_Leer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Leer;
        private System.Windows.Forms.Button btn_Escribir;
    }
}

