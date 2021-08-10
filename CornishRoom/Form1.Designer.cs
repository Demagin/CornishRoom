namespace CornishRoom
{
    partial class CornishRoom
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.PictureBox();
            this.buttonRender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sphereMaterial = new System.Windows.Forms.ComboBox();
            this.cube1Material = new System.Windows.Forms.ComboBox();
            this.cube2Material = new System.Windows.Forms.ComboBox();
            this.checkLeftWall = new System.Windows.Forms.CheckBox();
            this.checkRightWall = new System.Windows.Forms.CheckBox();
            this.checkFrontWall = new System.Windows.Forms.CheckBox();
            this.checkBackWall = new System.Windows.Forms.CheckBox();
            this.checkFloor = new System.Windows.Forms.CheckBox();
            this.checkCelling = new System.Windows.Forms.CheckBox();
            this.Light1X = new System.Windows.Forms.NumericUpDown();
            this.Light1Y = new System.Windows.Forms.NumericUpDown();
            this.Light1Z = new System.Windows.Forms.NumericUpDown();
            this.Light2Z = new System.Windows.Forms.NumericUpDown();
            this.Light2Y = new System.Windows.Forms.NumericUpDown();
            this.Light2X = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Light1_on = new System.Windows.Forms.CheckBox();
            this.Light2_on = new System.Windows.Forms.CheckBox();
            this.EyeZ = new System.Windows.Forms.NumericUpDown();
            this.EyeY = new System.Windows.Forms.NumericUpDown();
            this.EyeX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeX)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(0, -1);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 600);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // buttonRender
            // 
            this.buttonRender.Font = new System.Drawing.Font("Consolas", 11F);
            this.buttonRender.Location = new System.Drawing.Point(806, 293);
            this.buttonRender.Name = "buttonRender";
            this.buttonRender.Size = new System.Drawing.Size(120, 34);
            this.buttonRender.TabIndex = 1;
            this.buttonRender.Text = "Render";
            this.buttonRender.UseVisualStyleBackColor = true;
            this.buttonRender.Click += new System.EventHandler(this.buttonRender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F);
            this.label1.Location = new System.Drawing.Point(803, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reflectivity Walls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F);
            this.label2.Location = new System.Drawing.Point(806, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Material Cube1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F);
            this.label3.Location = new System.Drawing.Point(806, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Material Cube2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F);
            this.label4.Location = new System.Drawing.Point(806, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Material Sphere";
            // 
            // sphereMaterial
            // 
            this.sphereMaterial.FormattingEnabled = true;
            this.sphereMaterial.Items.AddRange(new object[] {
            "Matte",
            "Mirror",
            "Transparent"});
            this.sphereMaterial.Location = new System.Drawing.Point(806, 184);
            this.sphereMaterial.Name = "sphereMaterial";
            this.sphereMaterial.Size = new System.Drawing.Size(121, 21);
            this.sphereMaterial.TabIndex = 11;
            // 
            // cube1Material
            // 
            this.cube1Material.FormattingEnabled = true;
            this.cube1Material.Items.AddRange(new object[] {
            "Matte",
            "Mirror",
            "Transparent"});
            this.cube1Material.Location = new System.Drawing.Point(806, 225);
            this.cube1Material.Name = "cube1Material";
            this.cube1Material.Size = new System.Drawing.Size(121, 21);
            this.cube1Material.TabIndex = 12;
            // 
            // cube2Material
            // 
            this.cube2Material.FormattingEnabled = true;
            this.cube2Material.Items.AddRange(new object[] {
            "Matte",
            "Mirror",
            "Transparent"});
            this.cube2Material.Location = new System.Drawing.Point(806, 266);
            this.cube2Material.Name = "cube2Material";
            this.cube2Material.Size = new System.Drawing.Size(121, 21);
            this.cube2Material.TabIndex = 13;
            // 
            // checkLeftWall
            // 
            this.checkLeftWall.AutoSize = true;
            this.checkLeftWall.Location = new System.Drawing.Point(806, 27);
            this.checkLeftWall.Name = "checkLeftWall";
            this.checkLeftWall.Size = new System.Drawing.Size(74, 17);
            this.checkLeftWall.TabIndex = 15;
            this.checkLeftWall.Text = "LeftWall";
            this.checkLeftWall.UseVisualStyleBackColor = true;
            // 
            // checkRightWall
            // 
            this.checkRightWall.AutoSize = true;
            this.checkRightWall.Checked = true;
            this.checkRightWall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRightWall.Location = new System.Drawing.Point(806, 50);
            this.checkRightWall.Name = "checkRightWall";
            this.checkRightWall.Size = new System.Drawing.Size(80, 17);
            this.checkRightWall.TabIndex = 16;
            this.checkRightWall.Text = "RightWall";
            this.checkRightWall.UseVisualStyleBackColor = true;
            // 
            // checkFrontWall
            // 
            this.checkFrontWall.AutoSize = true;
            this.checkFrontWall.Location = new System.Drawing.Point(806, 73);
            this.checkFrontWall.Name = "checkFrontWall";
            this.checkFrontWall.Size = new System.Drawing.Size(80, 17);
            this.checkFrontWall.TabIndex = 17;
            this.checkFrontWall.Text = "FrontWall";
            this.checkFrontWall.UseVisualStyleBackColor = true;
            // 
            // checkBackWall
            // 
            this.checkBackWall.AutoSize = true;
            this.checkBackWall.Location = new System.Drawing.Point(806, 96);
            this.checkBackWall.Name = "checkBackWall";
            this.checkBackWall.Size = new System.Drawing.Size(74, 17);
            this.checkBackWall.TabIndex = 18;
            this.checkBackWall.Text = "BackWall";
            this.checkBackWall.UseVisualStyleBackColor = true;
            // 
            // checkFloor
            // 
            this.checkFloor.AutoSize = true;
            this.checkFloor.Checked = true;
            this.checkFloor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFloor.Location = new System.Drawing.Point(806, 119);
            this.checkFloor.Name = "checkFloor";
            this.checkFloor.Size = new System.Drawing.Size(56, 17);
            this.checkFloor.TabIndex = 19;
            this.checkFloor.Text = "Floor";
            this.checkFloor.UseVisualStyleBackColor = true;
            // 
            // checkCelling
            // 
            this.checkCelling.AutoSize = true;
            this.checkCelling.Location = new System.Drawing.Point(806, 142);
            this.checkCelling.Name = "checkCelling";
            this.checkCelling.Size = new System.Drawing.Size(68, 17);
            this.checkCelling.TabIndex = 20;
            this.checkCelling.Text = "Celling";
            this.checkCelling.UseVisualStyleBackColor = true;
            // 
            // Light1X
            // 
            this.Light1X.Location = new System.Drawing.Point(806, 334);
            this.Light1X.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Light1X.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
            this.Light1X.Name = "Light1X";
            this.Light1X.Size = new System.Drawing.Size(56, 20);
            this.Light1X.TabIndex = 23;
            // 
            // Light1Y
            // 
            this.Light1Y.Location = new System.Drawing.Point(806, 360);
            this.Light1Y.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Light1Y.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
            this.Light1Y.Name = "Light1Y";
            this.Light1Y.Size = new System.Drawing.Size(56, 20);
            this.Light1Y.TabIndex = 24;
            // 
            // Light1Z
            // 
            this.Light1Z.Location = new System.Drawing.Point(806, 386);
            this.Light1Z.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.Light1Z.Minimum = new decimal(new int[] {
            49,
            0,
            0,
            -2147483648});
            this.Light1Z.Name = "Light1Z";
            this.Light1Z.Size = new System.Drawing.Size(56, 20);
            this.Light1Z.TabIndex = 25;
            // 
            // Light2Z
            // 
            this.Light2Z.Location = new System.Drawing.Point(806, 469);
            this.Light2Z.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.Light2Z.Minimum = new decimal(new int[] {
            49,
            0,
            0,
            -2147483648});
            this.Light2Z.Name = "Light2Z";
            this.Light2Z.Size = new System.Drawing.Size(56, 20);
            this.Light2Z.TabIndex = 28;
            // 
            // Light2Y
            // 
            this.Light2Y.Location = new System.Drawing.Point(806, 443);
            this.Light2Y.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Light2Y.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
            this.Light2Y.Name = "Light2Y";
            this.Light2Y.Size = new System.Drawing.Size(56, 20);
            this.Light2Y.TabIndex = 27;
            // 
            // Light2X
            // 
            this.Light2X.Location = new System.Drawing.Point(806, 417);
            this.Light2X.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Light2X.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
            this.Light2X.Name = "Light2X";
            this.Light2X.Size = new System.Drawing.Size(56, 20);
            this.Light2X.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(873, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(873, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(874, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(874, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(873, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(873, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "X";
            // 
            // Light1_on
            // 
            this.Light1_on.AutoSize = true;
            this.Light1_on.Location = new System.Drawing.Point(892, 333);
            this.Light1_on.Name = "Light1_on";
            this.Light1_on.Size = new System.Drawing.Size(62, 17);
            this.Light1_on.TabIndex = 35;
            this.Light1_on.Text = "Light1";
            this.Light1_on.UseVisualStyleBackColor = true;
            // 
            // Light2_on
            // 
            this.Light2_on.AutoSize = true;
            this.Light2_on.Location = new System.Drawing.Point(892, 416);
            this.Light2_on.Name = "Light2_on";
            this.Light2_on.Size = new System.Drawing.Size(62, 17);
            this.Light2_on.TabIndex = 36;
            this.Light2_on.Text = "Light2";
            this.Light2_on.UseVisualStyleBackColor = true;
            // 
            // EyeZ
            // 
            this.EyeZ.Location = new System.Drawing.Point(806, 565);
            this.EyeZ.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.EyeZ.Minimum = new decimal(new int[] {
            49,
            0,
            0,
            -2147483648});
            this.EyeZ.Name = "EyeZ";
            this.EyeZ.Size = new System.Drawing.Size(56, 20);
            this.EyeZ.TabIndex = 39;
            // 
            // EyeY
            // 
            this.EyeY.Location = new System.Drawing.Point(806, 539);
            this.EyeY.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.EyeY.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
            this.EyeY.Name = "EyeY";
            this.EyeY.Size = new System.Drawing.Size(56, 20);
            this.EyeY.TabIndex = 38;
            // 
            // EyeX
            // 
            this.EyeX.Location = new System.Drawing.Point(806, 513);
            this.EyeX.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.EyeX.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
            this.EyeX.Name = "EyeX";
            this.EyeX.Size = new System.Drawing.Size(56, 20);
            this.EyeX.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(875, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(874, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(874, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(893, 513);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "EyePoint";
            // 
            // CornishRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 599);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EyeZ);
            this.Controls.Add(this.EyeY);
            this.Controls.Add(this.EyeX);
            this.Controls.Add(this.Light2_on);
            this.Controls.Add(this.Light1_on);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Light2Z);
            this.Controls.Add(this.Light2Y);
            this.Controls.Add(this.Light2X);
            this.Controls.Add(this.Light1Z);
            this.Controls.Add(this.Light1Y);
            this.Controls.Add(this.Light1X);
            this.Controls.Add(this.checkCelling);
            this.Controls.Add(this.checkFloor);
            this.Controls.Add(this.checkBackWall);
            this.Controls.Add(this.checkFrontWall);
            this.Controls.Add(this.checkRightWall);
            this.Controls.Add(this.checkLeftWall);
            this.Controls.Add(this.cube2Material);
            this.Controls.Add(this.cube1Material);
            this.Controls.Add(this.sphereMaterial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRender);
            this.Controls.Add(this.canvas);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CornishRoom";
            this.Text = "CornushRoom";
            this.Load += new System.EventHandler(this.CornishRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button buttonRender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sphereMaterial;
        private System.Windows.Forms.ComboBox cube1Material;
        private System.Windows.Forms.ComboBox cube2Material;
        private System.Windows.Forms.CheckBox checkLeftWall;
        private System.Windows.Forms.CheckBox checkRightWall;
        private System.Windows.Forms.CheckBox checkFrontWall;
        private System.Windows.Forms.CheckBox checkBackWall;
        private System.Windows.Forms.CheckBox checkFloor;
        private System.Windows.Forms.CheckBox checkCelling;
        private System.Windows.Forms.NumericUpDown Light1X;
        private System.Windows.Forms.NumericUpDown Light1Y;
        private System.Windows.Forms.NumericUpDown Light1Z;
        private System.Windows.Forms.NumericUpDown Light2Z;
        private System.Windows.Forms.NumericUpDown Light2Y;
        private System.Windows.Forms.NumericUpDown Light2X;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox Light1_on;
        private System.Windows.Forms.CheckBox Light2_on;
        private System.Windows.Forms.NumericUpDown EyeZ;
        private System.Windows.Forms.NumericUpDown EyeY;
        private System.Windows.Forms.NumericUpDown EyeX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

