
namespace Sample0603 {
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbSuu1 = new System.Windows.Forms.TextBox();
            this.tbsuu2 = new System.Windows.Forms.TextBox();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.nuUD1 = new System.Windows.Forms.NumericUpDown();
            this.nuUD2 = new System.Windows.Forms.NumericUpDown();
            this.nuAns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUD2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(81, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 185);
            this.button1.TabIndex = 0;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSuu1
            // 
            this.tbSuu1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSuu1.Location = new System.Drawing.Point(45, 65);
            this.tbSuu1.Name = "tbSuu1";
            this.tbSuu1.Size = new System.Drawing.Size(84, 55);
            this.tbSuu1.TabIndex = 1;
            // 
            // tbsuu2
            // 
            this.tbsuu2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbsuu2.Location = new System.Drawing.Point(239, 65);
            this.tbsuu2.Name = "tbsuu2";
            this.tbsuu2.Size = new System.Drawing.Size(82, 55);
            this.tbsuu2.TabIndex = 1;
            // 
            // tbAns
            // 
            this.tbAns.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAns.Location = new System.Drawing.Point(421, 65);
            this.tbAns.Name = "tbAns";
            this.tbAns.Size = new System.Drawing.Size(85, 55);
            this.tbAns.TabIndex = 1;
            this.tbAns.TextChanged += new System.EventHandler(this.tbAns_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(332, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "＝";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(406, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 117);
            this.button2.TabIndex = 4;
            this.button2.Text = "クリア";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nuUD1
            // 
            this.nuUD1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nuUD1.Location = new System.Drawing.Point(30, 228);
            this.nuUD1.Name = "nuUD1";
            this.nuUD1.Size = new System.Drawing.Size(113, 55);
            this.nuUD1.TabIndex = 5;
            // 
            // nuUD2
            // 
            this.nuUD2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nuUD2.Location = new System.Drawing.Point(225, 228);
            this.nuUD2.Name = "nuUD2";
            this.nuUD2.Size = new System.Drawing.Size(113, 55);
            this.nuUD2.TabIndex = 5;
            // 
            // nuAns
            // 
            this.nuAns.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nuAns.Location = new System.Drawing.Point(421, 228);
            this.nuAns.Name = "nuAns";
            this.nuAns.Size = new System.Drawing.Size(85, 55);
            this.nuAns.TabIndex = 1;
            this.nuAns.TextChanged += new System.EventHandler(this.tbAns_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(332, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "＝";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(344, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "＝";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(159, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 64);
            this.label7.TabIndex = 2;
            this.label7.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(159, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 665);
            this.Controls.Add(this.nuUD2);
            this.Controls.Add(this.nuUD1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nuAns);
            this.Controls.Add(this.tbAns);
            this.Controls.Add(this.tbsuu2);
            this.Controls.Add(this.tbSuu1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nuUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUD2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSuu1;
        private System.Windows.Forms.TextBox tbsuu2;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nuUD1;
        private System.Windows.Forms.NumericUpDown nuUD2;
        private System.Windows.Forms.TextBox nuAns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}

