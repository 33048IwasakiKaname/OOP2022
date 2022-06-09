
namespace NumberGame {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.nuNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAns = new System.Windows.Forms.Label();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton50 = new System.Windows.Forms.RadioButton();
            this.radioButton100 = new System.Windows.Forms.RadioButton();
            this.settingCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "1～50の中から当ててね";
            // 
            // nuNum
            // 
            this.nuNum.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nuNum.Location = new System.Drawing.Point(109, 119);
            this.nuNum.Name = "nuNum";
            this.nuNum.Size = new System.Drawing.Size(182, 71);
            this.nuNum.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(389, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "決定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAns.Location = new System.Drawing.Point(135, 304);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(0, 64);
            this.labelAns.TabIndex = 3;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton10.Location = new System.Drawing.Point(768, 92);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(126, 28);
            this.radioButton10.TabIndex = 4;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "1～10まで";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton50
            // 
            this.radioButton50.AutoSize = true;
            this.radioButton50.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton50.Location = new System.Drawing.Point(768, 144);
            this.radioButton50.Name = "radioButton50";
            this.radioButton50.Size = new System.Drawing.Size(126, 28);
            this.radioButton50.TabIndex = 4;
            this.radioButton50.TabStop = true;
            this.radioButton50.Text = "1～50まで";
            this.radioButton50.UseVisualStyleBackColor = true;
            this.radioButton50.CheckedChanged += new System.EventHandler(this.radioButton50_CheckedChanged);
            // 
            // radioButton100
            // 
            this.radioButton100.AutoSize = true;
            this.radioButton100.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton100.Location = new System.Drawing.Point(768, 200);
            this.radioButton100.Name = "radioButton100";
            this.radioButton100.Size = new System.Drawing.Size(138, 28);
            this.radioButton100.TabIndex = 4;
            this.radioButton100.TabStop = true;
            this.radioButton100.Text = "1～100まで";
            this.radioButton100.UseVisualStyleBackColor = true;
            this.radioButton100.CheckedChanged += new System.EventHandler(this.radioButton100_CheckedChanged);
            // 
            // settingCheck
            // 
            this.settingCheck.AutoSize = true;
            this.settingCheck.Location = new System.Drawing.Point(746, 34);
            this.settingCheck.Name = "settingCheck";
            this.settingCheck.Size = new System.Drawing.Size(72, 16);
            this.settingCheck.TabIndex = 7;
            this.settingCheck.Text = "詳細設定";
            this.settingCheck.UseVisualStyleBackColor = true;
            this.settingCheck.CheckedChanged += new System.EventHandler(this.settingCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(800, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "答え";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.settingCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton100);
            this.Controls.Add(this.radioButton50);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nuNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton50;
        private System.Windows.Forms.RadioButton radioButton100;
        private System.Windows.Forms.CheckBox settingCheck;
        private System.Windows.Forms.Label label2;
    }
}

