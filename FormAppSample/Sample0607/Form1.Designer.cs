﻿
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
            this.btRandom = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.minNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btRandom
            // 
            this.btRandom.Location = new System.Drawing.Point(12, 42);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(163, 323);
            this.btRandom.TabIndex = 0;
            this.btRandom.Text = "乱数呼び出し";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(298, 294);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(272, 71);
            this.Number.TabIndex = 1;
            // 
            // minNum
            // 
            this.minNum.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minNum.Location = new System.Drawing.Point(456, 22);
            this.minNum.Name = "minNum";
            this.minNum.Size = new System.Drawing.Size(138, 55);
            this.minNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(260, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "最小値：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(262, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "最大値：";
            // 
            // maxNum
            // 
            this.maxNum.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxNum.Location = new System.Drawing.Point(456, 83);
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(138, 55);
            this.maxNum.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(647, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxNum);
            this.Controls.Add(this.minNum);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.btRandom);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "乱数アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.NumericUpDown minNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxNum;
    }
}

