
namespace WeatherApp
{
    partial class Form2
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
            this.pbJapan = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbJapan)).BeginInit();
            this.SuspendLayout();
            // 
            // pbJapan
            // 
            this.pbJapan.Location = new System.Drawing.Point(-3, 0);
            this.pbJapan.Name = "pbJapan";
            this.pbJapan.Size = new System.Drawing.Size(889, 838);
            this.pbJapan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbJapan.TabIndex = 0;
            this.pbJapan.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "北海道(札幌周辺)"});
            this.comboBox1.Location = new System.Drawing.Point(499, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "北海道";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.index_change);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "青森県",
            "岩手県",
            "宮城県",
            "秋田県",
            "山形県",
            "福島県"});
            this.comboBox2.Location = new System.Drawing.Point(651, 322);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 20);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "東北";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.index_change);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県"});
            this.comboBox3.Location = new System.Drawing.Point(629, 531);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(65, 20);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.Text = "関東";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.index_change);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(454, 633);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(77, 20);
            this.comboBox4.TabIndex = 1;
            this.comboBox4.Text = "東海";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.index_change);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "新潟県",
            "富山県",
            "石川県",
            "福井県"});
            this.comboBox5.Location = new System.Drawing.Point(422, 376);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(77, 20);
            this.comboBox5.TabIndex = 1;
            this.comboBox5.Text = "北陸";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.index_change);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "滋賀県",
            "京都府",
            "大阪府",
            "兵庫県",
            "奈良県",
            "和歌山県"});
            this.comboBox6.Location = new System.Drawing.Point(335, 486);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(73, 20);
            this.comboBox6.TabIndex = 1;
            this.comboBox6.Text = "関西";
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.index_change);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "山口県"});
            this.comboBox7.Location = new System.Drawing.Point(184, 541);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(80, 20);
            this.comboBox7.TabIndex = 1;
            this.comboBox7.Text = "中国";
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.index_change);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "鹿児島県"});
            this.comboBox8.Location = new System.Drawing.Point(27, 633);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(80, 20);
            this.comboBox8.TabIndex = 1;
            this.comboBox8.Text = "九州";
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.index_change);
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "愛媛県",
            "香川県",
            "徳島県",
            "高知県"});
            this.comboBox9.Location = new System.Drawing.Point(285, 711);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(80, 20);
            this.comboBox9.TabIndex = 1;
            this.comboBox9.Text = "四国";
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.index_change);
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "沖縄本島"});
            this.comboBox10.Location = new System.Drawing.Point(184, 265);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(97, 20);
            this.comboBox10.TabIndex = 1;
            this.comboBox10.Text = "沖縄";
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.index_change);
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOk.Location = new System.Drawing.Point(12, 12);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(134, 70);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "決定";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(868, 836);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pbJapan);
            this.Name = "Form2";
            this.Text = "日本地図表記";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJapan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbJapan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Button btOk;
    }
}