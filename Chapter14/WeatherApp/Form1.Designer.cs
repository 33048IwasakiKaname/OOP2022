
namespace WeatherApp {
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
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weatherPb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWeatherToday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWindToday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReportTime = new System.Windows.Forms.TextBox();
            this.WeatherMap = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWeatherTomorrow = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbWeatherAfterTomorrow = new System.Windows.Forms.TextBox();
            this.weatherPbTomorrow = new System.Windows.Forms.PictureBox();
            this.weatherPbAfTomorrow = new System.Windows.Forms.PictureBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_6 = new System.Windows.Forms.Label();
            this.label_0 = new System.Windows.Forms.Label();
            this.pb_0 = new System.Windows.Forms.PictureBox();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.pb_2 = new System.Windows.Forms.PictureBox();
            this.pb_3 = new System.Windows.Forms.PictureBox();
            this.pb_4 = new System.Windows.Forms.PictureBox();
            this.pb_5 = new System.Windows.Forms.PictureBox();
            this.pb_6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label_select = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMinTemp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMaxTemp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPbTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPbAfTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_6)).BeginInit();
            this.SuspendLayout();
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeatherGet.Location = new System.Drawing.Point(680, 12);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(159, 65);
            this.btWeatherGet.TabIndex = 0;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(253, 335);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(563, 134);
            this.tbWeatherInfo.TabIndex = 1;
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "北海道(札幌周辺)",
            "青森県",
            "岩手県",
            "宮城県",
            "秋田県",
            "山形県",
            "福島県",
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県",
            "山梨県",
            "長野県",
            "岐阜県",
            "静岡県",
            "愛知県",
            "三重県",
            "新潟県",
            "富山県",
            "石川県",
            "福井県",
            "滋賀県",
            "京都府",
            "大阪府",
            "兵庫県",
            "奈良県",
            "和歌山県",
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "徳島県",
            "香川県",
            "愛媛県",
            "高知県",
            "山口県",
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "鹿児島県",
            "沖縄本島"});
            this.cbRegion.Location = new System.Drawing.Point(134, 12);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(157, 20);
            this.cbRegion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "地域選択：";
            // 
            // weatherPb
            // 
            this.weatherPb.Location = new System.Drawing.Point(658, 169);
            this.weatherPb.Name = "weatherPb";
            this.weatherPb.Size = new System.Drawing.Size(138, 102);
            this.weatherPb.TabIndex = 4;
            this.weatherPb.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(66, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "天気概要：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(37, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "今日の天気：";
            // 
            // tbWeatherToday
            // 
            this.tbWeatherToday.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherToday.Location = new System.Drawing.Point(253, 175);
            this.tbWeatherToday.Multiline = true;
            this.tbWeatherToday.Name = "tbWeatherToday";
            this.tbWeatherToday.Size = new System.Drawing.Size(377, 61);
            this.tbWeatherToday.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(101, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "風情報：";
            // 
            // tbWindToday
            // 
            this.tbWindToday.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWindToday.Location = new System.Drawing.Point(253, 254);
            this.tbWindToday.Multiline = true;
            this.tbWindToday.Name = "tbWindToday";
            this.tbWindToday.Size = new System.Drawing.Size(377, 61);
            this.tbWindToday.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(448, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "更新日：";
            // 
            // tbReportTime
            // 
            this.tbReportTime.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbReportTime.Location = new System.Drawing.Point(500, 6);
            this.tbReportTime.Multiline = true;
            this.tbReportTime.Name = "tbReportTime";
            this.tbReportTime.Size = new System.Drawing.Size(151, 26);
            this.tbReportTime.TabIndex = 5;
            // 
            // WeatherMap
            // 
            this.WeatherMap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.WeatherMap.Location = new System.Drawing.Point(884, 33);
            this.WeatherMap.Name = "WeatherMap";
            this.WeatherMap.Size = new System.Drawing.Size(355, 274);
            this.WeatherMap.TabIndex = 4;
            this.WeatherMap.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(37, 593);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "明日の天気：";
            // 
            // tbWeatherTomorrow
            // 
            this.tbWeatherTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherTomorrow.Location = new System.Drawing.Point(253, 593);
            this.tbWeatherTomorrow.Multiline = true;
            this.tbWeatherTomorrow.Name = "tbWeatherTomorrow";
            this.tbWeatherTomorrow.Size = new System.Drawing.Size(377, 61);
            this.tbWeatherTomorrow.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(2, 689);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 35);
            this.label8.TabIndex = 3;
            this.label8.Text = "明後日の天気：";
            // 
            // tbWeatherAfterTomorrow
            // 
            this.tbWeatherAfterTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherAfterTomorrow.Location = new System.Drawing.Point(253, 680);
            this.tbWeatherAfterTomorrow.Multiline = true;
            this.tbWeatherAfterTomorrow.Name = "tbWeatherAfterTomorrow";
            this.tbWeatherAfterTomorrow.Size = new System.Drawing.Size(377, 61);
            this.tbWeatherAfterTomorrow.TabIndex = 5;
            // 
            // weatherPbTomorrow
            // 
            this.weatherPbTomorrow.Location = new System.Drawing.Point(658, 595);
            this.weatherPbTomorrow.Name = "weatherPbTomorrow";
            this.weatherPbTomorrow.Size = new System.Drawing.Size(138, 102);
            this.weatherPbTomorrow.TabIndex = 4;
            this.weatherPbTomorrow.TabStop = false;
            // 
            // weatherPbAfTomorrow
            // 
            this.weatherPbAfTomorrow.Location = new System.Drawing.Point(659, 683);
            this.weatherPbAfTomorrow.Name = "weatherPbAfTomorrow";
            this.weatherPbAfTomorrow.Size = new System.Drawing.Size(138, 102);
            this.weatherPbAfTomorrow.TabIndex = 4;
            this.weatherPbAfTomorrow.TabStop = false;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_1.Location = new System.Drawing.Point(923, 390);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(103, 35);
            this.label_1.TabIndex = 3;
            this.label_1.Text = "明日：";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_2.Location = new System.Drawing.Point(923, 458);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(103, 35);
            this.label_2.TabIndex = 3;
            this.label_2.Text = "明日：";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_3.Location = new System.Drawing.Point(923, 518);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(103, 35);
            this.label_3.TabIndex = 3;
            this.label_3.Text = "明日：";
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_4.Location = new System.Drawing.Point(923, 580);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(103, 35);
            this.label_4.TabIndex = 3;
            this.label_4.Text = "明日：";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_5.Location = new System.Drawing.Point(923, 647);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(103, 35);
            this.label_5.TabIndex = 3;
            this.label_5.Text = "明日：";
            // 
            // label_6
            // 
            this.label_6.AutoSize = true;
            this.label_6.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_6.Location = new System.Drawing.Point(923, 716);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(103, 35);
            this.label_6.TabIndex = 3;
            this.label_6.Text = "明日：";
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_0.Location = new System.Drawing.Point(923, 324);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(103, 35);
            this.label_0.TabIndex = 3;
            this.label_0.Text = "今日：";
            // 
            // pb_0
            // 
            this.pb_0.Location = new System.Drawing.Point(1032, 313);
            this.pb_0.Name = "pb_0";
            this.pb_0.Size = new System.Drawing.Size(80, 57);
            this.pb_0.TabIndex = 4;
            this.pb_0.TabStop = false;
            // 
            // pb_1
            // 
            this.pb_1.Location = new System.Drawing.Point(1032, 383);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(80, 57);
            this.pb_1.TabIndex = 4;
            this.pb_1.TabStop = false;
            // 
            // pb_2
            // 
            this.pb_2.Location = new System.Drawing.Point(1032, 451);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(80, 57);
            this.pb_2.TabIndex = 4;
            this.pb_2.TabStop = false;
            // 
            // pb_3
            // 
            this.pb_3.Location = new System.Drawing.Point(1031, 511);
            this.pb_3.Name = "pb_3";
            this.pb_3.Size = new System.Drawing.Size(79, 57);
            this.pb_3.TabIndex = 4;
            this.pb_3.TabStop = false;
            // 
            // pb_4
            // 
            this.pb_4.Location = new System.Drawing.Point(1031, 574);
            this.pb_4.Name = "pb_4";
            this.pb_4.Size = new System.Drawing.Size(80, 57);
            this.pb_4.TabIndex = 4;
            this.pb_4.TabStop = false;
            // 
            // pb_5
            // 
            this.pb_5.Location = new System.Drawing.Point(1033, 640);
            this.pb_5.Name = "pb_5";
            this.pb_5.Size = new System.Drawing.Size(79, 57);
            this.pb_5.TabIndex = 4;
            this.pb_5.TabStop = false;
            // 
            // pb_6
            // 
            this.pb_6.Location = new System.Drawing.Point(1032, 708);
            this.pb_6.Name = "pb_6";
            this.pb_6.Size = new System.Drawing.Size(80, 57);
            this.pb_6.TabIndex = 4;
            this.pb_6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(118, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 35);
            this.label9.TabIndex = 3;
            this.label9.Text = "選択地域";
            // 
            // label_select
            // 
            this.label_select.AutoSize = true;
            this.label_select.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_select.Location = new System.Drawing.Point(279, 83);
            this.label_select.Name = "label_select";
            this.label_select.Size = new System.Drawing.Size(0, 35);
            this.label_select.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(186, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "最低気温：";
            // 
            // tbMinTemp
            // 
            this.tbMinTemp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMinTemp.Location = new System.Drawing.Point(337, 507);
            this.tbMinTemp.Multiline = true;
            this.tbMinTemp.Name = "tbMinTemp";
            this.tbMinTemp.Size = new System.Drawing.Size(88, 61);
            this.tbMinTemp.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(471, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 33);
            this.label10.TabIndex = 3;
            this.label10.Text = "最高気温：";
            // 
            // tbMaxTemp
            // 
            this.tbMaxTemp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMaxTemp.Location = new System.Drawing.Point(621, 507);
            this.tbMaxTemp.Multiline = true;
            this.tbMaxTemp.Name = "tbMaxTemp";
            this.tbMaxTemp.Size = new System.Drawing.Size(88, 61);
            this.tbMaxTemp.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 810);
            this.Controls.Add(this.tbWindToday);
            this.Controls.Add(this.tbReportTime);
            this.Controls.Add(this.tbWeatherAfterTomorrow);
            this.Controls.Add(this.tbMaxTemp);
            this.Controls.Add(this.tbMinTemp);
            this.Controls.Add(this.tbWeatherTomorrow);
            this.Controls.Add(this.tbWeatherToday);
            this.Controls.Add(this.WeatherMap);
            this.Controls.Add(this.weatherPbAfTomorrow);
            this.Controls.Add(this.pb_6);
            this.Controls.Add(this.pb_5);
            this.Controls.Add(this.pb_4);
            this.Controls.Add(this.pb_3);
            this.Controls.Add(this.pb_2);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.pb_0);
            this.Controls.Add(this.weatherPbTomorrow);
            this.Controls.Add(this.weatherPb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_6);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_select);
            this.Controls.Add(this.label_0);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.tbWeatherInfo);
            this.Controls.Add(this.btWeatherGet);
            this.Name = "Form1";
            this.Text = "お天気アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPbTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPbAfTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox weatherPb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWeatherToday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWindToday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReportTime;
        private System.Windows.Forms.PictureBox WeatherMap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbWeatherTomorrow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbWeatherAfterTomorrow;
        private System.Windows.Forms.PictureBox weatherPbTomorrow;
        private System.Windows.Forms.PictureBox weatherPbAfTomorrow;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_6;
        private System.Windows.Forms.Label label_0;
        private System.Windows.Forms.PictureBox pb_0;
        private System.Windows.Forms.PictureBox pb_1;
        private System.Windows.Forms.PictureBox pb_2;
        private System.Windows.Forms.PictureBox pb_3;
        private System.Windows.Forms.PictureBox pb_4;
        private System.Windows.Forms.PictureBox pb_5;
        private System.Windows.Forms.PictureBox pb_6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_select;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMinTemp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMaxTemp;
    }
}

