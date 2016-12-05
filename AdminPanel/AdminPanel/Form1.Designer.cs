namespace AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNothing = new System.Windows.Forms.Button();
            this.buttonFakta = new System.Windows.Forms.Button();
            this.buttonSporgsmalAdmin = new System.Windows.Forms.Button();
            this.buttonDash = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 62);
            this.panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Roboto Lt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelTitle.Location = new System.Drawing.Point(367, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(96, 29);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Overblik";
            // 
            // AddBtn
            // 
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.Location = new System.Drawing.Point(312, 18);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(29, 25);
            this.AddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddBtn.TabIndex = 3;
            this.AddBtn.TabStop = false;
            this.AddBtn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1296, 18);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(48, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(259, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(19)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 62);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSTP System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.buttonNothing);
            this.panel2.Controls.Add(this.buttonFakta);
            this.panel2.Controls.Add(this.buttonSporgsmalAdmin);
            this.panel2.Controls.Add(this.buttonDash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 604);
            this.panel2.TabIndex = 1;
            // 
            // buttonNothing
            // 
            this.buttonNothing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.buttonNothing.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonNothing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNothing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.buttonNothing.FlatAppearance.BorderSize = 0;
            this.buttonNothing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.buttonNothing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.buttonNothing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNothing.Font = new System.Drawing.Font("RomanS_IV25", 12F);
            this.buttonNothing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonNothing.Location = new System.Drawing.Point(0, 500);
            this.buttonNothing.Name = "buttonNothing";
            this.buttonNothing.Size = new System.Drawing.Size(246, 104);
            this.buttonNothing.TabIndex = 3;
            this.buttonNothing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNothing.UseVisualStyleBackColor = false;
            // 
            // buttonFakta
            // 
            this.buttonFakta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFakta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFakta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonFakta.FlatAppearance.BorderSize = 0;
            this.buttonFakta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonFakta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.buttonFakta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFakta.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFakta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonFakta.Location = new System.Drawing.Point(0, 128);
            this.buttonFakta.Name = "buttonFakta";
            this.buttonFakta.Size = new System.Drawing.Size(246, 64);
            this.buttonFakta.TabIndex = 2;
            this.buttonFakta.Text = " Fakta";
            this.buttonFakta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFakta.UseVisualStyleBackColor = true;
            this.buttonFakta.Click += new System.EventHandler(this.buttonFakta_Click);
            // 
            // buttonSporgsmalAdmin
            // 
            this.buttonSporgsmalAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSporgsmalAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSporgsmalAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonSporgsmalAdmin.FlatAppearance.BorderSize = 0;
            this.buttonSporgsmalAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonSporgsmalAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.buttonSporgsmalAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSporgsmalAdmin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSporgsmalAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSporgsmalAdmin.Location = new System.Drawing.Point(0, 64);
            this.buttonSporgsmalAdmin.Name = "buttonSporgsmalAdmin";
            this.buttonSporgsmalAdmin.Size = new System.Drawing.Size(246, 64);
            this.buttonSporgsmalAdmin.TabIndex = 1;
            this.buttonSporgsmalAdmin.Text = " Spørgsmål";
            this.buttonSporgsmalAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSporgsmalAdmin.UseVisualStyleBackColor = true;
            this.buttonSporgsmalAdmin.Click += new System.EventHandler(this.buttonSporgsmalAdmin_Click);
            // 
            // buttonDash
            // 
            this.buttonDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonDash.FlatAppearance.BorderSize = 0;
            this.buttonDash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.buttonDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDash.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonDash.Location = new System.Drawing.Point(0, 0);
            this.buttonDash.Name = "buttonDash";
            this.buttonDash.Size = new System.Drawing.Size(246, 64);
            this.buttonDash.TabIndex = 0;
            this.buttonDash.Text = " Overblik";
            this.buttonDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDash.UseVisualStyleBackColor = false;
            this.buttonDash.Click += new System.EventHandler(this.buttonDash_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(246, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1101, 604);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 666);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminstations Panel - MSTP System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDash;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonNothing;
        private System.Windows.Forms.Button buttonFakta;
        private System.Windows.Forms.Button buttonSporgsmalAdmin;
        private System.Windows.Forms.PictureBox AddBtn;
        private System.Windows.Forms.Label labelTitle;
    }
}

