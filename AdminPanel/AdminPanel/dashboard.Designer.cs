namespace AdminPanel
{
    partial class dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelCountS1 = new System.Windows.Forms.Label();
            this.labelSpor2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelCountS2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSpor1 = new System.Windows.Forms.Label();
            this.Divider = new System.Windows.Forms.Panel();
            this.labelFejlErrorFraSql = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(51, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 85);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 85);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(19)))));
            this.panel3.Controls.Add(this.labelCountS1);
            this.panel3.Controls.Add(this.labelSpor2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(51, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 95);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelCountS1
            // 
            this.labelCountS1.AutoSize = true;
            this.labelCountS1.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Italic);
            this.labelCountS1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelCountS1.Location = new System.Drawing.Point(269, 62);
            this.labelCountS1.Name = "labelCountS1";
            this.labelCountS1.Size = new System.Drawing.Size(19, 20);
            this.labelCountS1.TabIndex = 1;
            this.labelCountS1.Text = "0";
            this.labelCountS1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCountS1.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelSpor2
            // 
            this.labelSpor2.AutoSize = true;
            this.labelSpor2.Font = new System.Drawing.Font("Roboto Cn", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelSpor2.Location = new System.Drawing.Point(15, 24);
            this.labelSpor2.Name = "labelSpor2";
            this.labelSpor2.Size = new System.Drawing.Size(102, 23);
            this.labelSpor2.TabIndex = 0;
            this.labelSpor2.Text = "Spørgsmål 2";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(341, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(152, 95);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Antal svar";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(19)))));
            this.panel4.Controls.Add(this.labelCountS2);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.labelSpor1);
            this.panel4.Location = new System.Drawing.Point(562, 237);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 95);
            this.panel4.TabIndex = 2;
            // 
            // labelCountS2
            // 
            this.labelCountS2.AutoSize = true;
            this.labelCountS2.Font = new System.Drawing.Font("Roboto Bk", 10F, System.Drawing.FontStyle.Italic);
            this.labelCountS2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelCountS2.Location = new System.Drawing.Point(191, 62);
            this.labelCountS2.Name = "labelCountS2";
            this.labelCountS2.Size = new System.Drawing.Size(19, 20);
            this.labelCountS2.TabIndex = 4;
            this.labelCountS2.Text = "0";
            this.labelCountS2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(157, 95);
            this.panel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Antal svar";
            // 
            // labelSpor1
            // 
            this.labelSpor1.AutoSize = true;
            this.labelSpor1.Font = new System.Drawing.Font("Roboto Cn", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelSpor1.Location = new System.Drawing.Point(175, 24);
            this.labelSpor1.Name = "labelSpor1";
            this.labelSpor1.Size = new System.Drawing.Size(102, 23);
            this.labelSpor1.TabIndex = 3;
            this.labelSpor1.Text = "Spørgsmål 1";
            this.labelSpor1.Click += new System.EventHandler(this.label6_Click);
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Divider.Location = new System.Drawing.Point(47, 187);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(1010, 1);
            this.Divider.TabIndex = 3;
            // 
            // labelFejlErrorFraSql
            // 
            this.labelFejlErrorFraSql.AutoSize = true;
            this.labelFejlErrorFraSql.Location = new System.Drawing.Point(515, 561);
            this.labelFejlErrorFraSql.Name = "labelFejlErrorFraSql";
            this.labelFejlErrorFraSql.Size = new System.Drawing.Size(0, 17);
            this.labelFejlErrorFraSql.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.Location = new System.Drawing.Point(47, 388);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1010, 1);
            this.panel7.TabIndex = 4;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.labelFejlErrorFraSql);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(1101, 604);
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelCountS1;
        private System.Windows.Forms.Label labelSpor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountS2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSpor1;
        private System.Windows.Forms.Panel Divider;
        private System.Windows.Forms.Label labelFejlErrorFraSql;
        private System.Windows.Forms.Panel panel7;
    }
}
