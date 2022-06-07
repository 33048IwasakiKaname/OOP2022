
namespace Sample0607 {
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
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numUD1 = new System.Windows.Forms.NumericUpDown();
            this.numUD2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numAns = new System.Windows.Forms.NumericUpDown();
            this.numMod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMod)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNum1
            // 
            this.tbNum1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNum1.Location = new System.Drawing.Point(64, 48);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(99, 55);
            this.tbNum1.TabIndex = 0;
            // 
            // tbNum2
            // 
            this.tbNum2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNum2.Location = new System.Drawing.Point(277, 48);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(99, 55);
            this.tbNum2.TabIndex = 0;
            // 
            // tbAns
            // 
            this.tbAns.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAns.Location = new System.Drawing.Point(541, 48);
            this.tbAns.Name = "tbAns";
            this.tbAns.Size = new System.Drawing.Size(99, 55);
            this.tbAns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(177, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "÷";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(421, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "＝";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(679, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "余り";
            // 
            // tbMod
            // 
            this.tbMod.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMod.Location = new System.Drawing.Point(801, 48);
            this.tbMod.Name = "tbMod";
            this.tbMod.Size = new System.Drawing.Size(99, 55);
            this.tbMod.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(610, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numUD1
            // 
            this.numUD1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numUD1.Location = new System.Drawing.Point(52, 252);
            this.numUD1.Name = "numUD1";
            this.numUD1.Size = new System.Drawing.Size(121, 71);
            this.numUD1.TabIndex = 3;
            // 
            // numUD2
            // 
            this.numUD2.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numUD2.Location = new System.Drawing.Point(277, 252);
            this.numUD2.Name = "numUD2";
            this.numUD2.Size = new System.Drawing.Size(121, 71);
            this.numUD2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(177, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 64);
            this.label4.TabIndex = 1;
            this.label4.Text = "÷";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(421, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 64);
            this.label5.TabIndex = 1;
            this.label5.Text = "＝";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(679, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 48);
            this.label6.TabIndex = 1;
            this.label6.Text = "余り";
            // 
            // numAns
            // 
            this.numAns.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numAns.Location = new System.Drawing.Point(519, 254);
            this.numAns.Name = "numAns";
            this.numAns.Size = new System.Drawing.Size(121, 71);
            this.numAns.TabIndex = 3;
            // 
            // numMod
            // 
            this.numMod.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numMod.Location = new System.Drawing.Point(801, 254);
            this.numMod.Name = "numMod";
            this.numMod.Size = new System.Drawing.Size(121, 71);
            this.numMod.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(966, 463);
            this.Controls.Add(this.numMod);
            this.Controls.Add(this.numAns);
            this.Controls.Add(this.numUD2);
            this.Controls.Add(this.numUD1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMod);
            this.Controls.Add(this.tbAns);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "計算アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.numUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numUD1;
        private System.Windows.Forms.NumericUpDown numUD2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAns;
        private System.Windows.Forms.NumericUpDown numMod;
    }
}

