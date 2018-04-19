namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.note1 = new System.Windows.Forms.TextBox();
            this.note2 = new System.Windows.Forms.TextBox();
            this.note3 = new System.Windows.Forms.TextBox();
            this.note4 = new System.Windows.Forms.TextBox();
            this.note5 = new System.Windows.Forms.TextBox();
            this.note6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notendurchschnitt berechnen:";
            // 
            // note1
            // 
            this.note1.Location = new System.Drawing.Point(16, 60);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(44, 20);
            this.note1.TabIndex = 1;
            // 
            // note2
            // 
            this.note2.Location = new System.Drawing.Point(66, 60);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(44, 20);
            this.note2.TabIndex = 2;
            // 
            // note3
            // 
            this.note3.Location = new System.Drawing.Point(116, 60);
            this.note3.Name = "note3";
            this.note3.Size = new System.Drawing.Size(44, 20);
            this.note3.TabIndex = 3;
            // 
            // note4
            // 
            this.note4.Location = new System.Drawing.Point(166, 60);
            this.note4.Name = "note4";
            this.note4.Size = new System.Drawing.Size(44, 20);
            this.note4.TabIndex = 4;
            // 
            // note5
            // 
            this.note5.Location = new System.Drawing.Point(216, 60);
            this.note5.Name = "note5";
            this.note5.Size = new System.Drawing.Size(44, 20);
            this.note5.TabIndex = 5;
            // 
            // note6
            // 
            this.note6.Location = new System.Drawing.Point(266, 60);
            this.note6.Name = "note6";
            this.note6.Size = new System.Drawing.Size(44, 20);
            this.note6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "6";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(12, 113);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(144, 23);
            this.btn_calc.TabIndex = 13;
            this.btn_calc.Text = "Berechnen";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(174, 113);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(144, 23);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 143);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.note6);
            this.Controls.Add(this.note5);
            this.Controls.Add(this.note4);
            this.Controls.Add(this.note3);
            this.Controls.Add(this.note2);
            this.Controls.Add(this.note1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(346, 182);
            this.MinimumSize = new System.Drawing.Size(346, 182);
            this.Name = "Form1";
            this.Text = "Notendurchschnitt berechnen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox note1;
        private System.Windows.Forms.TextBox note2;
        private System.Windows.Forms.TextBox note3;
        private System.Windows.Forms.TextBox note4;
        private System.Windows.Forms.TextBox note5;
        private System.Windows.Forms.TextBox note6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_close;
    }
}

