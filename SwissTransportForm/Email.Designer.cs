namespace SwissTransportForm
{
    partial class Email
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
            this.adresse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox21 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betreff1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zieladresse";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(80, 37);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(206, 20);
            this.adresse.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox21
            // 
            this.textbox21.Location = new System.Drawing.Point(16, 111);
            this.textbox21.Name = "textbox21";
            this.textbox21.Size = new System.Drawing.Size(604, 295);
            this.textbox21.TabIndex = 4;
            this.textbox21.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Betreff";
            // 
            // betreff1
            // 
            this.betreff1.Location = new System.Drawing.Point(80, 73);
            this.betreff1.Name = "betreff1";
            this.betreff1.Size = new System.Drawing.Size(206, 20);
            this.betreff1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "Schliessen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 418);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.betreff1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.label1);
            this.Name = "Email";
            this.Text = "Email";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textbox21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox betreff1;
        private System.Windows.Forms.Button button2;
    }
}