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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBMainRange = new System.Windows.Forms.CheckBox();
            this.CBArmRange = new System.Windows.Forms.CheckBox();
            this.CBPlatformRange = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NUDY = new System.Windows.Forms.NumericUpDown();
            this.NUDX = new System.Windows.Forms.NumericUpDown();
            this.NUDSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSize)).BeginInit();
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
            this.groupBox1.Controls.Add(this.CBMainRange);
            this.groupBox1.Controls.Add(this.CBArmRange);
            this.groupBox1.Controls.Add(this.CBPlatformRange);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(627, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(329, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // CBMainRange
            // 
            this.CBMainRange.AutoSize = true;
            this.CBMainRange.Checked = true;
            this.CBMainRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBMainRange.Location = new System.Drawing.Point(31, 112);
            this.CBMainRange.Name = "CBMainRange";
            this.CBMainRange.Size = new System.Drawing.Size(184, 28);
            this.CBMainRange.TabIndex = 4;
            this.CBMainRange.Text = "Show Main Range";
            this.CBMainRange.UseVisualStyleBackColor = true;
            this.CBMainRange.CheckedChanged += new System.EventHandler(this.CBSettings_CheckedChanged);
            // 
            // CBArmRange
            // 
            this.CBArmRange.AutoSize = true;
            this.CBArmRange.Checked = true;
            this.CBArmRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBArmRange.Location = new System.Drawing.Point(31, 78);
            this.CBArmRange.Name = "CBArmRange";
            this.CBArmRange.Size = new System.Drawing.Size(178, 28);
            this.CBArmRange.TabIndex = 4;
            this.CBArmRange.Text = "Show Arm Range";
            this.CBArmRange.UseVisualStyleBackColor = true;
            this.CBArmRange.CheckedChanged += new System.EventHandler(this.CBSettings_CheckedChanged);
            // 
            // CBPlatformRange
            // 
            this.CBPlatformRange.AutoSize = true;
            this.CBPlatformRange.Checked = true;
            this.CBPlatformRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBPlatformRange.Location = new System.Drawing.Point(31, 44);
            this.CBPlatformRange.Name = "CBPlatformRange";
            this.CBPlatformRange.Size = new System.Drawing.Size(210, 28);
            this.CBPlatformRange.TabIndex = 4;
            this.CBPlatformRange.Text = "Show Platform Range";
            this.CBPlatformRange.UseVisualStyleBackColor = true;
            this.CBPlatformRange.CheckedChanged += new System.EventHandler(this.CBSettings_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Y:";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(174, 95);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(100, 33);
            this.buttonDraw.TabIndex = 6;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(174, 141);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(100, 33);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NUDY);
            this.groupBox2.Controls.Add(this.NUDX);
            this.groupBox2.Controls.Add(this.NUDSize);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonConvert);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonDraw);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(630, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 199);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Canvas";
            // 
            // NUDY
            // 
            this.NUDY.Location = new System.Drawing.Point(59, 142);
            this.NUDY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDY.Name = "NUDY";
            this.NUDY.Size = new System.Drawing.Size(100, 29);
            this.NUDY.TabIndex = 7;
            this.NUDY.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // NUDX
            // 
            this.NUDX.Location = new System.Drawing.Point(59, 96);
            this.NUDX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDX.Name = "NUDX";
            this.NUDX.Size = new System.Drawing.Size(100, 29);
            this.NUDX.TabIndex = 7;
            this.NUDX.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // NUDSize
            // 
            this.NUDSize.Location = new System.Drawing.Point(174, 46);
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
            this.label8.Location = new System.Drawing.Point(24, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Platform Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 631);
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
            ((System.ComponentModel.ISupportInitialize)(this.NUDY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUDY;
        private System.Windows.Forms.NumericUpDown NUDX;
        private System.Windows.Forms.NumericUpDown NUDSize;
        private System.Windows.Forms.CheckBox CBMainRange;
        private System.Windows.Forms.CheckBox CBArmRange;
        private System.Windows.Forms.CheckBox CBPlatformRange;
    }
}

