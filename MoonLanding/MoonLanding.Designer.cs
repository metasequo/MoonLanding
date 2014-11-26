namespace MoonLanding
{
    partial class MoonLanding
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoonLanding));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InitialAltitude = new System.Windows.Forms.NumericUpDown();
            this.UsePropellant = new System.Windows.Forms.NumericUpDown();
            this.NowAltitude = new System.Windows.Forms.TextBox();
            this.NowVelocity = new System.Windows.Forms.TextBox();
            this.RemainingPropellant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.InjectionButton = new System.Windows.Forms.Button();
            this.NonInjectionButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InitialAltitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsePropellant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "初期高度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "噴射推進剤";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "現在高度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "現在落下速度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "残推進剤";
            // 
            // InitialAltitude
            // 
            this.InitialAltitude.Location = new System.Drawing.Point(106, 23);
            this.InitialAltitude.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.InitialAltitude.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.InitialAltitude.Name = "InitialAltitude";
            this.InitialAltitude.Size = new System.Drawing.Size(65, 19);
            this.InitialAltitude.TabIndex = 5;
            this.InitialAltitude.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // UsePropellant
            // 
            this.UsePropellant.Location = new System.Drawing.Point(106, 82);
            this.UsePropellant.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UsePropellant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UsePropellant.Name = "UsePropellant";
            this.UsePropellant.Size = new System.Drawing.Size(65, 19);
            this.UsePropellant.TabIndex = 6;
            this.UsePropellant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NowAltitude
            // 
            this.NowAltitude.Location = new System.Drawing.Point(106, 169);
            this.NowAltitude.Name = "NowAltitude";
            this.NowAltitude.ReadOnly = true;
            this.NowAltitude.Size = new System.Drawing.Size(65, 19);
            this.NowAltitude.TabIndex = 7;
            // 
            // NowVelocity
            // 
            this.NowVelocity.Location = new System.Drawing.Point(106, 198);
            this.NowVelocity.Name = "NowVelocity";
            this.NowVelocity.ReadOnly = true;
            this.NowVelocity.Size = new System.Drawing.Size(65, 19);
            this.NowVelocity.TabIndex = 8;
            // 
            // RemainingPropellant
            // 
            this.RemainingPropellant.Location = new System.Drawing.Point(106, 227);
            this.RemainingPropellant.Name = "RemainingPropellant";
            this.RemainingPropellant.ReadOnly = true;
            this.RemainingPropellant.Size = new System.Drawing.Size(65, 19);
            this.RemainingPropellant.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "単位";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "m";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "m/s";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "単位";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(230, 20);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 15;
            this.StartButton.Text = "スタート";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // InjectionButton
            // 
            this.InjectionButton.Location = new System.Drawing.Point(230, 79);
            this.InjectionButton.Name = "InjectionButton";
            this.InjectionButton.Size = new System.Drawing.Size(75, 23);
            this.InjectionButton.TabIndex = 16;
            this.InjectionButton.Text = "ロケット噴射";
            this.InjectionButton.UseVisualStyleBackColor = true;
            this.InjectionButton.Click += new System.EventHandler(this.InjectionButton_Click);
            // 
            // NonInjectionButton
            // 
            this.NonInjectionButton.Location = new System.Drawing.Point(230, 108);
            this.NonInjectionButton.Name = "NonInjectionButton";
            this.NonInjectionButton.Size = new System.Drawing.Size(75, 23);
            this.NonInjectionButton.TabIndex = 0;
            this.NonInjectionButton.Text = "噴射せず";
            this.NonInjectionButton.UseVisualStyleBackColor = true;
            this.NonInjectionButton.Click += new System.EventHandler(this.NonInjectionButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(230, 225);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 23);
            this.EndButton.TabIndex = 17;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // MoonLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 265);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.NonInjectionButton);
            this.Controls.Add(this.InjectionButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RemainingPropellant);
            this.Controls.Add(this.NowVelocity);
            this.Controls.Add(this.NowAltitude);
            this.Controls.Add(this.UsePropellant);
            this.Controls.Add(this.InitialAltitude);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoonLanding";
            this.Text = "月面着陸";
            ((System.ComponentModel.ISupportInitialize)(this.InitialAltitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsePropellant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown InitialAltitude;
        private System.Windows.Forms.NumericUpDown UsePropellant;
        private System.Windows.Forms.TextBox NowAltitude;
        private System.Windows.Forms.TextBox NowVelocity;
        private System.Windows.Forms.TextBox RemainingPropellant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button InjectionButton;
        private System.Windows.Forms.Button NonInjectionButton;
        private System.Windows.Forms.Button EndButton;
    }
}

