namespace typing_project
{
    partial class frm_result_session
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
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_result_session));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.studentresultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtspeed2 = new System.Windows.Forms.TextBox();
            this.txtlanguage2 = new System.Windows.Forms.TextBox();
            this.txtWPM = new System.Windows.Forms.TextBox();
            this.txterrorrate = new System.Windows.Forms.TextBox();
            this.txterror2 = new System.Windows.Forms.TextBox();
            this.txtcharacter = new System.Windows.Forms.TextBox();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtlesson = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pic_inst_log = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentresultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_inst_log)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 31);
            this.panel1.TabIndex = 22;
            this.toolTip1.SetToolTip(this.panel1, "Move");
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Red;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_min.Location = new System.Drawing.Point(868, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(31, 31);
            this.btn_min.TabIndex = 18;
            this.btn_min.Text = "─";
            this.toolTip1.SetToolTip(this.btn_min, "Close");
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(378, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ezapiya Typing Master";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 494);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 31);
            this.panel5.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(250, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(459, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "EZAPIYA TYPING MASTER. POWERED BY Ezapiya software research and development LLP.";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Navy;
            this.lineShape3.BorderWidth = 3;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -6;
            this.lineShape3.X2 = 909;
            this.lineShape3.Y1 = 134;
            this.lineShape3.Y2 = 134;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(900, 525);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Navy;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 276;
            this.lineShape1.X2 = 276;
            this.lineShape1.Y1 = 135;
            this.lineShape1.Y2 = 493;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtspeed2
            // 
            this.txtspeed2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtspeed2.Location = new System.Drawing.Point(457, 277);
            this.txtspeed2.Name = "txtspeed2";
            this.txtspeed2.ReadOnly = true;
            this.txtspeed2.Size = new System.Drawing.Size(131, 26);
            this.txtspeed2.TabIndex = 47;
            // 
            // txtlanguage2
            // 
            this.txtlanguage2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlanguage2.Location = new System.Drawing.Point(457, 243);
            this.txtlanguage2.Name = "txtlanguage2";
            this.txtlanguage2.ReadOnly = true;
            this.txtlanguage2.Size = new System.Drawing.Size(131, 26);
            this.txtlanguage2.TabIndex = 48;
            // 
            // txtWPM
            // 
            this.txtWPM.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWPM.Location = new System.Drawing.Point(715, 341);
            this.txtWPM.Name = "txtWPM";
            this.txtWPM.ReadOnly = true;
            this.txtWPM.Size = new System.Drawing.Size(131, 26);
            this.txtWPM.TabIndex = 44;
            // 
            // txterrorrate
            // 
            this.txterrorrate.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterrorrate.Location = new System.Drawing.Point(715, 201);
            this.txterrorrate.Name = "txterrorrate";
            this.txterrorrate.ReadOnly = true;
            this.txterrorrate.Size = new System.Drawing.Size(131, 26);
            this.txterrorrate.TabIndex = 45;
            // 
            // txterror2
            // 
            this.txterror2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterror2.Location = new System.Drawing.Point(457, 313);
            this.txterror2.Name = "txterror2";
            this.txterror2.ReadOnly = true;
            this.txterror2.Size = new System.Drawing.Size(131, 26);
            this.txterror2.TabIndex = 52;
            // 
            // txtcharacter
            // 
            this.txtcharacter.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcharacter.Location = new System.Drawing.Point(717, 305);
            this.txtcharacter.Name = "txtcharacter";
            this.txtcharacter.ReadOnly = true;
            this.txtcharacter.Size = new System.Drawing.Size(131, 26);
            this.txtcharacter.TabIndex = 51;
            // 
            // txtduration
            // 
            this.txtduration.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtduration.Location = new System.Drawing.Point(717, 269);
            this.txtduration.Name = "txtduration";
            this.txtduration.ReadOnly = true;
            this.txtduration.Size = new System.Drawing.Size(131, 26);
            this.txtduration.TabIndex = 49;
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(717, 233);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(131, 26);
            this.txtdate.TabIndex = 50;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Navy;
            this.label20.Location = new System.Drawing.Point(386, 280);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 21);
            this.label20.TabIndex = 43;
            this.label20.Text = "Speed";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Navy;
            this.label19.Location = new System.Drawing.Point(355, 246);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 21);
            this.label19.TabIndex = 37;
            this.label19.Text = "Language";
            // 
            // txtlesson
            // 
            this.txtlesson.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlesson.Location = new System.Drawing.Point(457, 207);
            this.txtlesson.Name = "txtlesson";
            this.txtlesson.ReadOnly = true;
            this.txtlesson.Size = new System.Drawing.Size(131, 26);
            this.txtlesson.TabIndex = 53;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(658, 344);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 21);
            this.label17.TabIndex = 35;
            this.label17.Text = "WPM";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(626, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 21);
            this.label16.TabIndex = 38;
            this.label16.Text = "Error rate";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(401, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 21);
            this.label15.TabIndex = 41;
            this.label15.Text = "Error";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(615, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 21);
            this.label14.TabIndex = 42;
            this.label14.Text = "Character";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(629, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 21);
            this.label13.TabIndex = 39;
            this.label13.Text = "Duration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(657, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(387, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 36;
            this.label11.Text = "Lesson";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(535, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "Student Result";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::typing_project.Properties.Resources.MAIN_LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(264, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "http://ditrpindia.com/typingsoftware");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.LightYellow;
            this.btn_logout.BackgroundImage = global::typing_project.Properties.Resources.back_button;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logout.Location = new System.Drawing.Point(574, 405);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(91, 31);
            this.btn_logout.TabIndex = 54;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pic_inst_log
            // 
            this.pic_inst_log.Image = global::typing_project.Properties.Resources.images2;
            this.pic_inst_log.Location = new System.Drawing.Point(14, 212);
            this.pic_inst_log.Name = "pic_inst_log";
            this.pic_inst_log.Size = new System.Drawing.Size(241, 128);
            this.pic_inst_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_inst_log.TabIndex = 31;
            this.pic_inst_log.TabStop = false;
            // 
            // frm_result_session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(900, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtspeed2);
            this.Controls.Add(this.txtlanguage2);
            this.Controls.Add(this.txtWPM);
            this.Controls.Add(this.txterrorrate);
            this.Controls.Add(this.txterror2);
            this.Controls.Add(this.txtcharacter);
            this.Controls.Add(this.txtduration);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtlesson);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pic_inst_log);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_result_session";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_result_session";
            this.Load += new System.EventHandler(this.frm_result_session_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentresultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_inst_log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pic_inst_log;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
    
        private System.Windows.Forms.BindingSource studentresultBindingSource;
      
        private System.Windows.Forms.TextBox txtspeed2;
        private System.Windows.Forms.TextBox txtlanguage2;
        private System.Windows.Forms.TextBox txtWPM;
        private System.Windows.Forms.TextBox txterrorrate;
        private System.Windows.Forms.TextBox txterror2;
        private System.Windows.Forms.TextBox txtcharacter;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtlesson;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_min;
    }
}