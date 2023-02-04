namespace Tarea_I_Parcial
{
    partial class Tarea_Par_Impar
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
            this.label1 = new System.Windows.Forms.Label();
            this.Num1textBox = new System.Windows.Forms.TextBox();
            this.verbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero :";
            // 
            // Num1textBox
            // 
            this.Num1textBox.Location = new System.Drawing.Point(169, 46);
            this.Num1textBox.Name = "Num1textBox";
            this.Num1textBox.Size = new System.Drawing.Size(100, 20);
            this.Num1textBox.TabIndex = 1;
            // 
            // verbutton
            // 
            this.verbutton.Location = new System.Drawing.Point(109, 115);
            this.verbutton.Name = "verbutton";
            this.verbutton.Size = new System.Drawing.Size(87, 23);
            this.verbutton.TabIndex = 4;
            this.verbutton.Text = "ver";
            this.verbutton.UseVisualStyleBackColor = true;
            this.verbutton.Click += new System.EventHandler(this.verbutton_Click);
            // 
            // Tarea_Par_Impar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verbutton);
            this.Controls.Add(this.Num1textBox);
            this.Controls.Add(this.label1);
            this.Name = "Tarea_Par_Impar";
            this.Text = "Tarea_Par_Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Num1textBox;
        private System.Windows.Forms.Button verbutton;
    }
}