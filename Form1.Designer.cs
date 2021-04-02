namespace PolarCoordinates
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBDown = new System.Windows.Forms.RadioButton();
            this.RBTop = new System.Windows.Forms.RadioButton();
            this.CBMainRange = new System.Windows.Forms.CheckBox();
            this.CBArmRange = new System.Windows.Forms.CheckBox();
            this.CBPlatformRange = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.NUDY2 = new System.Windows.Forms.NumericUpDown();
            this.NUDX2 = new System.Windows.Forms.NumericUpDown();
            this.NUDY1 = new System.Windows.Forms.NumericUpDown();
            this.NUDX1 = new System.Windows.Forms.NumericUpDown();
            this.NUDSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelArmAngle = new System.Windows.Forms.Label();
            this.labelPlatformAngle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBDown);
            this.groupBox1.Controls.Add(this.RBTop);
            this.groupBox1.Controls.Add(this.CBMainRange);
            this.groupBox1.Controls.Add(this.CBArmRange);
            this.groupBox1.Controls.Add(this.CBPlatformRange);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(627, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(329, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // RBDown
            // 
            this.RBDown.AutoSize = true;
            this.RBDown.Location = new System.Drawing.Point(198, 69);
            this.RBDown.Name = "RBDown";
            this.RBDown.Size = new System.Drawing.Size(77, 28);
            this.RBDown.TabIndex = 5;
            this.RBDown.Text = "Down";
            this.RBDown.UseVisualStyleBackColor = true;
            // 
            // RBTop
            // 
            this.RBTop.AutoSize = true;
            this.RBTop.Checked = true;
            this.RBTop.Location = new System.Drawing.Point(198, 35);
            this.RBTop.Name = "RBTop";
            this.RBTop.Size = new System.Drawing.Size(62, 28);
            this.RBTop.TabIndex = 5;
            this.RBTop.TabStop = true;
            this.RBTop.Text = "Top";
            this.RBTop.UseVisualStyleBackColor = true;
            // 
            // CBMainRange
            // 
            this.CBMainRange.AutoSize = true;
            this.CBMainRange.Location = new System.Drawing.Point(15, 103);
            this.CBMainRange.Name = "CBMainRange";
            this.CBMainRange.Size = new System.Drawing.Size(114, 28);
            this.CBMainRange.TabIndex = 4;
            this.CBMainRange.Text = "Show Org";
            this.CBMainRange.UseVisualStyleBackColor = true;
            this.CBMainRange.CheckedChanged += new System.EventHandler(this.CBSettings_CheckedChanged);
            // 
            // CBArmRange
            // 
            this.CBArmRange.AutoSize = true;
            this.CBArmRange.Checked = true;
            this.CBArmRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBArmRange.Location = new System.Drawing.Point(15, 69);
            this.CBArmRange.Name = "CBArmRange";
            this.CBArmRange.Size = new System.Drawing.Size(117, 28);
            this.CBArmRange.TabIndex = 4;
            this.CBArmRange.Text = "Show Arm";
            this.CBArmRange.UseVisualStyleBackColor = true;
            this.CBArmRange.CheckedChanged += new System.EventHandler(this.CBSettings_CheckedChanged);
            // 
            // CBPlatformRange
            // 
            this.CBPlatformRange.AutoSize = true;
            this.CBPlatformRange.Checked = true;
            this.CBPlatformRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBPlatformRange.Location = new System.Drawing.Point(15, 35);
            this.CBPlatformRange.Name = "CBPlatformRange";
            this.CBPlatformRange.Size = new System.Drawing.Size(149, 28);
            this.CBPlatformRange.TabIndex = 4;
            this.CBPlatformRange.Text = "Show Platform";
            this.CBPlatformRange.UseVisualStyleBackColor = true;
            this.CBPlatformRange.CheckedChanged += new System.EventHandler(this.CBSettings_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "X1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Y1:";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(106, 164);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(100, 33);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.NUDY2);
            this.groupBox2.Controls.Add(this.NUDX2);
            this.groupBox2.Controls.Add(this.NUDY1);
            this.groupBox2.Controls.Add(this.NUDX1);
            this.groupBox2.Controls.Add(this.NUDSize);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonConvert);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonSimulate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(630, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 337);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Canvas";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(16, 227);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(296, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // NUDY2
            // 
            this.NUDY2.Location = new System.Drawing.Point(212, 115);
            this.NUDY2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDY2.Name = "NUDY2";
            this.NUDY2.Size = new System.Drawing.Size(100, 29);
            this.NUDY2.TabIndex = 7;
            this.NUDY2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // NUDX2
            // 
            this.NUDX2.Location = new System.Drawing.Point(57, 116);
            this.NUDX2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDX2.Name = "NUDX2";
            this.NUDX2.Size = new System.Drawing.Size(100, 29);
            this.NUDX2.TabIndex = 7;
            this.NUDX2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // NUDY1
            // 
            this.NUDY1.Location = new System.Drawing.Point(212, 78);
            this.NUDY1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDY1.Name = "NUDY1";
            this.NUDY1.Size = new System.Drawing.Size(100, 29);
            this.NUDY1.TabIndex = 7;
            this.NUDY1.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // NUDX1
            // 
            this.NUDX1.Location = new System.Drawing.Point(57, 79);
            this.NUDX1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDX1.Name = "NUDX1";
            this.NUDX1.Size = new System.Drawing.Size(100, 29);
            this.NUDX1.TabIndex = 7;
            this.NUDX1.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // NUDSize
            // 
            this.NUDSize.Location = new System.Drawing.Point(174, 38);
            this.NUDSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUDSize.Name = "NUDSize";
            this.NUDSize.Size = new System.Drawing.Size(100, 29);
            this.NUDSize.TabIndex = 7;
            this.NUDSize.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Platform Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "X2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Y2:";
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Enabled = false;
            this.buttonSimulate.Location = new System.Drawing.Point(106, 278);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(100, 33);
            this.buttonSimulate.TabIndex = 6;
            this.buttonSimulate.Text = "Simulate";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelArmAngle);
            this.groupBox3.Controls.Add(this.labelPlatformAngle);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(630, 508);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 107);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // labelArmAngle
            // 
            this.labelArmAngle.AutoSize = true;
            this.labelArmAngle.Location = new System.Drawing.Point(170, 70);
            this.labelArmAngle.Name = "labelArmAngle";
            this.labelArmAngle.Size = new System.Drawing.Size(30, 24);
            this.labelArmAngle.TabIndex = 1;
            this.labelArmAngle.Text = "90";
            // 
            // labelPlatformAngle
            // 
            this.labelPlatformAngle.AutoSize = true;
            this.labelPlatformAngle.Location = new System.Drawing.Point(170, 32);
            this.labelPlatformAngle.Name = "labelPlatformAngle";
            this.labelPlatformAngle.Size = new System.Drawing.Size(30, 24);
            this.labelPlatformAngle.TabIndex = 1;
            this.labelPlatformAngle.Text = "90";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Arm Angle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Platform Angle:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 631);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUDY1;
        private System.Windows.Forms.NumericUpDown NUDX1;
        private System.Windows.Forms.NumericUpDown NUDSize;
        private System.Windows.Forms.CheckBox CBMainRange;
        private System.Windows.Forms.CheckBox CBArmRange;
        private System.Windows.Forms.CheckBox CBPlatformRange;
        private System.Windows.Forms.NumericUpDown NUDY2;
        private System.Windows.Forms.NumericUpDown NUDX2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelArmAngle;
        private System.Windows.Forms.Label labelPlatformAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton RBDown;
        private System.Windows.Forms.RadioButton RBTop;
    }
}

