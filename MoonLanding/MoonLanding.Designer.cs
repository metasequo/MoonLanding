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
            this.初期高度 = new System.Windows.Forms.Label();
            this.噴射推進剤 = new System.Windows.Forms.Label();
            this.現在高度 = new System.Windows.Forms.Label();
            this.現在落下速度 = new System.Windows.Forms.Label();
            this.残推進剤 = new System.Windows.Forms.Label();
            this.InitialAltitude = new System.Windows.Forms.NumericUpDown();
            this.UsePropellant = new System.Windows.Forms.NumericUpDown();
            this.NowAltitude = new System.Windows.Forms.TextBox();
            this.NowVelocity = new System.Windows.Forms.TextBox();
            this.RemainingPropellant = new System.Windows.Forms.TextBox();
            this.初期高度m = new System.Windows.Forms.Label();
            this.使用推進剤単位 = new System.Windows.Forms.Label();
            this.現在高度m = new System.Windows.Forms.Label();
            this.現在落下速度ms = new System.Windows.Forms.Label();
            this.残推進剤単位 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.InjectionButton = new System.Windows.Forms.Button();
            this.NonInjectionButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InitialAltitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsePropellant)).BeginInit();
            this.SuspendLayout();
            // 
            // 初期高度
            // 
            this.初期高度.AutoSize = true;
            this.初期高度.Location = new System.Drawing.Point(27, 25);
            this.初期高度.Name = "初期高度";
            this.初期高度.Size = new System.Drawing.Size(53, 12);
            this.初期高度.TabIndex = 0;
            this.初期高度.Text = "初期高度";
            // 
            // 噴射推進剤
            // 
            this.噴射推進剤.AutoSize = true;
            this.噴射推進剤.Location = new System.Drawing.Point(21, 84);
            this.噴射推進剤.Name = "噴射推進剤";
            this.噴射推進剤.Size = new System.Drawing.Size(65, 12);
            this.噴射推進剤.TabIndex = 1;
            this.噴射推進剤.Text = "噴射推進剤";
            // 
            // 現在高度
            // 
            this.現在高度.AutoSize = true;
            this.現在高度.Location = new System.Drawing.Point(27, 172);
            this.現在高度.Name = "現在高度";
            this.現在高度.Size = new System.Drawing.Size(53, 12);
            this.現在高度.TabIndex = 2;
            this.現在高度.Text = "現在高度";
            // 
            // 現在落下速度
            // 
            this.現在落下速度.AutoSize = true;
            this.現在落下速度.Location = new System.Drawing.Point(15, 201);
            this.現在落下速度.Name = "現在落下速度";
            this.現在落下速度.Size = new System.Drawing.Size(77, 12);
            this.現在落下速度.TabIndex = 3;
            this.現在落下速度.Text = "現在落下速度";
            // 
            // 残推進剤
            // 
            this.残推進剤.AutoSize = true;
            this.残推進剤.Location = new System.Drawing.Point(27, 230);
            this.残推進剤.Name = "残推進剤";
            this.残推進剤.Size = new System.Drawing.Size(53, 12);
            this.残推進剤.TabIndex = 4;
            this.残推進剤.Text = "残推進剤";
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
            // 初期高度m
            // 
            this.初期高度m.AutoSize = true;
            this.初期高度m.Location = new System.Drawing.Point(177, 25);
            this.初期高度m.Name = "初期高度m";
            this.初期高度m.Size = new System.Drawing.Size(14, 12);
            this.初期高度m.TabIndex = 10;
            this.初期高度m.Text = "m";
            // 
            // 使用推進剤単位
            // 
            this.使用推進剤単位.AutoSize = true;
            this.使用推進剤単位.Location = new System.Drawing.Point(177, 84);
            this.使用推進剤単位.Name = "使用推進剤単位";
            this.使用推進剤単位.Size = new System.Drawing.Size(29, 12);
            this.使用推進剤単位.TabIndex = 11;
            this.使用推進剤単位.Text = "単位";
            // 
            // 現在高度m
            // 
            this.現在高度m.AutoSize = true;
            this.現在高度m.Location = new System.Drawing.Point(177, 172);
            this.現在高度m.Name = "現在高度m";
            this.現在高度m.Size = new System.Drawing.Size(14, 12);
            this.現在高度m.TabIndex = 12;
            this.現在高度m.Text = "m";
            // 
            // 現在落下速度ms
            // 
            this.現在落下速度ms.AutoSize = true;
            this.現在落下速度ms.Location = new System.Drawing.Point(177, 201);
            this.現在落下速度ms.Name = "現在落下速度ms";
            this.現在落下速度ms.Size = new System.Drawing.Size(26, 12);
            this.現在落下速度ms.TabIndex = 13;
            this.現在落下速度ms.Text = "m/s";
            // 
            // 残推進剤単位
            // 
            this.残推進剤単位.AutoSize = true;
            this.残推進剤単位.Location = new System.Drawing.Point(177, 230);
            this.残推進剤単位.Name = "残推進剤単位";
            this.残推進剤単位.Size = new System.Drawing.Size(29, 12);
            this.残推進剤単位.TabIndex = 14;
            this.残推進剤単位.Text = "単位";
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
            this.Controls.Add(this.残推進剤単位);
            this.Controls.Add(this.現在落下速度ms);
            this.Controls.Add(this.現在高度m);
            this.Controls.Add(this.使用推進剤単位);
            this.Controls.Add(this.初期高度m);
            this.Controls.Add(this.RemainingPropellant);
            this.Controls.Add(this.NowVelocity);
            this.Controls.Add(this.NowAltitude);
            this.Controls.Add(this.UsePropellant);
            this.Controls.Add(this.InitialAltitude);
            this.Controls.Add(this.残推進剤);
            this.Controls.Add(this.現在落下速度);
            this.Controls.Add(this.現在高度);
            this.Controls.Add(this.噴射推進剤);
            this.Controls.Add(this.初期高度);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoonLanding";
            this.Text = "月面着陸";
            ((System.ComponentModel.ISupportInitialize)(this.InitialAltitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsePropellant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 初期高度;
        private System.Windows.Forms.Label 噴射推進剤;
        private System.Windows.Forms.Label 現在高度;
        private System.Windows.Forms.Label 現在落下速度;
        private System.Windows.Forms.Label 残推進剤;
        private System.Windows.Forms.NumericUpDown InitialAltitude;
        private System.Windows.Forms.NumericUpDown UsePropellant;
        private System.Windows.Forms.TextBox NowAltitude;
        private System.Windows.Forms.TextBox NowVelocity;
        private System.Windows.Forms.TextBox RemainingPropellant;
        private System.Windows.Forms.Label 初期高度m;
        private System.Windows.Forms.Label 使用推進剤単位;
        private System.Windows.Forms.Label 現在高度m;
        private System.Windows.Forms.Label 現在落下速度ms;
        private System.Windows.Forms.Label 残推進剤単位;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button InjectionButton;
        private System.Windows.Forms.Button NonInjectionButton;
        private System.Windows.Forms.Button EndButton;
    }
}

