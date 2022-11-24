
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WeatherMap = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.weatherPbTomorrow = new System.Windows.Forms.PictureBox();
            this.weatherPbAfTomorrow = new System.Windows.Forms.PictureBox();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_6 = new System.Windows.Forms.Label();
            this.pb_2 = new System.Windows.Forms.PictureBox();
            this.pb_3 = new System.Windows.Forms.PictureBox();
            this.pb_4 = new System.Windows.Forms.PictureBox();
            this.pb_5 = new System.Windows.Forms.PictureBox();
            this.pb_6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label_select = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelTmLow = new System.Windows.Forms.Label();
            this.labelNTmLow = new System.Windows.Forms.Label();
            this.labelTmHigh = new System.Windows.Forms.Label();
            this.labelNTmHigh = new System.Windows.Forms.Label();
            this.label02Low = new System.Windows.Forms.Label();
            this.label02High = new System.Windows.Forms.Label();
            this.label03Low = new System.Windows.Forms.Label();
            this.label03High = new System.Windows.Forms.Label();
            this.label04Low = new System.Windows.Forms.Label();
            this.label04High = new System.Windows.Forms.Label();
            this.label05Low = new System.Windows.Forms.Label();
            this.label05High = new System.Windows.Forms.Label();
            this.label06Low = new System.Windows.Forms.Label();
            this.label06High = new System.Windows.Forms.Label();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.labelMaxTemp = new System.Windows.Forms.Label();
            this.labelWeatherToday = new System.Windows.Forms.Label();
            this.labelWindToday = new System.Windows.Forms.Label();
            this.labelWeatherTomorrow = new System.Windows.Forms.Label();
            this.labelReportTime = new System.Windows.Forms.Label();
            this.btChange = new System.Windows.Forms.Button();
            this.label_selected = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPbTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPbAfTomorrow)).BeginInit();
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
            this.tbWeatherInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.ForeColor = System.Drawing.Color.White;
            this.tbWeatherInfo.Location = new System.Drawing.Point(245, 335);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(548, 224);
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "地域選択：";
            // 
            // weatherPb
            // 
            this.weatherPb.Location = new System.Drawing.Point(604, 150);
            this.weatherPb.Name = "weatherPb";
            this.weatherPb.Size = new System.Drawing.Size(138, 102);
            this.weatherPb.TabIndex = 4;
            this.weatherPb.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "今日の天気：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(101, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "風情報：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(448, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "更新日：";
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
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 593);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "明日の天気：";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_1.ForeColor = System.Drawing.Color.White;
            this.label_1.Location = new System.Drawing.Point(884, 334);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(103, 35);
            this.label_1.TabIndex = 3;
            this.label_1.Text = "明日：";
            // 
            // weatherPbTomorrow
            // 
            this.weatherPbTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.weatherPbTomorrow.Location = new System.Drawing.Point(522, 587);
            this.weatherPbTomorrow.Name = "weatherPbTomorrow";
            this.weatherPbTomorrow.Size = new System.Drawing.Size(108, 102);
            this.weatherPbTomorrow.TabIndex = 4;
            this.weatherPbTomorrow.TabStop = false;
            // 
            // weatherPbAfTomorrow
            // 
            this.weatherPbAfTomorrow.Location = new System.Drawing.Point(994, 323);
            this.weatherPbAfTomorrow.Name = "weatherPbAfTomorrow";
            this.weatherPbAfTomorrow.Size = new System.Drawing.Size(80, 57);
            this.weatherPbAfTomorrow.TabIndex = 4;
            this.weatherPbAfTomorrow.TabStop = false;
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_2.ForeColor = System.Drawing.Color.White;
            this.label_2.Location = new System.Drawing.Point(884, 396);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(103, 35);
            this.label_2.TabIndex = 3;
            this.label_2.Text = "明日：";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_3.ForeColor = System.Drawing.Color.White;
            this.label_3.Location = new System.Drawing.Point(884, 456);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(103, 35);
            this.label_3.TabIndex = 3;
            this.label_3.Text = "明日：";
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_4.ForeColor = System.Drawing.Color.White;
            this.label_4.Location = new System.Drawing.Point(884, 518);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(103, 35);
            this.label_4.TabIndex = 3;
            this.label_4.Text = "明日：";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_5.ForeColor = System.Drawing.Color.White;
            this.label_5.Location = new System.Drawing.Point(884, 585);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(103, 35);
            this.label_5.TabIndex = 3;
            this.label_5.Text = "明日：";
            // 
            // label_6
            // 
            this.label_6.AutoSize = true;
            this.label_6.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_6.ForeColor = System.Drawing.Color.White;
            this.label_6.Location = new System.Drawing.Point(884, 654);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(103, 35);
            this.label_6.TabIndex = 3;
            this.label_6.Text = "明日：";
            // 
            // pb_2
            // 
            this.pb_2.Location = new System.Drawing.Point(991, 386);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(80, 57);
            this.pb_2.TabIndex = 4;
            this.pb_2.TabStop = false;
            // 
            // pb_3
            // 
            this.pb_3.Location = new System.Drawing.Point(992, 449);
            this.pb_3.Name = "pb_3";
            this.pb_3.Size = new System.Drawing.Size(79, 57);
            this.pb_3.TabIndex = 4;
            this.pb_3.TabStop = false;
            // 
            // pb_4
            // 
            this.pb_4.Location = new System.Drawing.Point(992, 512);
            this.pb_4.Name = "pb_4";
            this.pb_4.Size = new System.Drawing.Size(80, 57);
            this.pb_4.TabIndex = 4;
            this.pb_4.TabStop = false;
            // 
            // pb_5
            // 
            this.pb_5.Location = new System.Drawing.Point(994, 578);
            this.pb_5.Name = "pb_5";
            this.pb_5.Size = new System.Drawing.Size(79, 57);
            this.pb_5.TabIndex = 4;
            this.pb_5.TabStop = false;
            // 
            // pb_6
            // 
            this.pb_6.Location = new System.Drawing.Point(993, 646);
            this.pb_6.Name = "pb_6";
            this.pb_6.Size = new System.Drawing.Size(80, 57);
            this.pb_6.TabIndex = 4;
            this.pb_6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(118, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 35);
            this.label9.TabIndex = 3;
            this.label9.Text = "選択地域：";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(671, 605);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 40);
            this.label11.TabIndex = 6;
            this.label11.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1133, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 40);
            this.label12.TabIndex = 6;
            this.label12.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1130, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 40);
            this.label13.TabIndex = 6;
            this.label13.Text = "/";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1130, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 40);
            this.label14.TabIndex = 6;
            this.label14.Text = "/";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1130, 589);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 40);
            this.label15.TabIndex = 6;
            this.label15.Text = "/";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1130, 456);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 40);
            this.label16.TabIndex = 6;
            this.label16.Text = "/";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1130, 660);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 40);
            this.label17.TabIndex = 6;
            this.label17.Text = "/";
            // 
            // labelTmLow
            // 
            this.labelTmLow.AutoSize = true;
            this.labelTmLow.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTmLow.ForeColor = System.Drawing.Color.Cyan;
            this.labelTmLow.Location = new System.Drawing.Point(639, 609);
            this.labelTmLow.Name = "labelTmLow";
            this.labelTmLow.Size = new System.Drawing.Size(40, 27);
            this.labelTmLow.TabIndex = 7;
            this.labelTmLow.Text = "15";
            // 
            // labelNTmLow
            // 
            this.labelNTmLow.AutoSize = true;
            this.labelNTmLow.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNTmLow.ForeColor = System.Drawing.Color.Cyan;
            this.labelNTmLow.Location = new System.Drawing.Point(1100, 340);
            this.labelNTmLow.Name = "labelNTmLow";
            this.labelNTmLow.Size = new System.Drawing.Size(40, 27);
            this.labelNTmLow.TabIndex = 7;
            this.labelNTmLow.Text = "15";
            // 
            // labelTmHigh
            // 
            this.labelTmHigh.AutoSize = true;
            this.labelTmHigh.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTmHigh.ForeColor = System.Drawing.Color.Red;
            this.labelTmHigh.Location = new System.Drawing.Point(702, 609);
            this.labelTmHigh.Name = "labelTmHigh";
            this.labelTmHigh.Size = new System.Drawing.Size(40, 27);
            this.labelTmHigh.TabIndex = 7;
            this.labelTmHigh.Text = "15";
            // 
            // labelNTmHigh
            // 
            this.labelNTmHigh.AutoSize = true;
            this.labelNTmHigh.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNTmHigh.ForeColor = System.Drawing.Color.Red;
            this.labelNTmHigh.Location = new System.Drawing.Point(1163, 340);
            this.labelNTmHigh.Name = "labelNTmHigh";
            this.labelNTmHigh.Size = new System.Drawing.Size(40, 27);
            this.labelNTmHigh.TabIndex = 7;
            this.labelNTmHigh.Text = "15";
            // 
            // label02Low
            // 
            this.label02Low.AutoSize = true;
            this.label02Low.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label02Low.ForeColor = System.Drawing.Color.Cyan;
            this.label02Low.Location = new System.Drawing.Point(1096, 396);
            this.label02Low.Name = "label02Low";
            this.label02Low.Size = new System.Drawing.Size(40, 27);
            this.label02Low.TabIndex = 7;
            this.label02Low.Text = "15";
            // 
            // label02High
            // 
            this.label02High.AutoSize = true;
            this.label02High.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label02High.ForeColor = System.Drawing.Color.Red;
            this.label02High.Location = new System.Drawing.Point(1166, 396);
            this.label02High.Name = "label02High";
            this.label02High.Size = new System.Drawing.Size(40, 27);
            this.label02High.TabIndex = 7;
            this.label02High.Text = "15";
            // 
            // label03Low
            // 
            this.label03Low.AutoSize = true;
            this.label03Low.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label03Low.ForeColor = System.Drawing.Color.Cyan;
            this.label03Low.Location = new System.Drawing.Point(1096, 463);
            this.label03Low.Name = "label03Low";
            this.label03Low.Size = new System.Drawing.Size(40, 27);
            this.label03Low.TabIndex = 7;
            this.label03Low.Text = "15";
            // 
            // label03High
            // 
            this.label03High.AutoSize = true;
            this.label03High.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label03High.ForeColor = System.Drawing.Color.Red;
            this.label03High.Location = new System.Drawing.Point(1166, 463);
            this.label03High.Name = "label03High";
            this.label03High.Size = new System.Drawing.Size(40, 27);
            this.label03High.TabIndex = 7;
            this.label03High.Text = "15";
            // 
            // label04Low
            // 
            this.label04Low.AutoSize = true;
            this.label04Low.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label04Low.ForeColor = System.Drawing.Color.Cyan;
            this.label04Low.Location = new System.Drawing.Point(1096, 520);
            this.label04Low.Name = "label04Low";
            this.label04Low.Size = new System.Drawing.Size(40, 27);
            this.label04Low.TabIndex = 7;
            this.label04Low.Text = "15";
            // 
            // label04High
            // 
            this.label04High.AutoSize = true;
            this.label04High.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label04High.ForeColor = System.Drawing.Color.Red;
            this.label04High.Location = new System.Drawing.Point(1166, 520);
            this.label04High.Name = "label04High";
            this.label04High.Size = new System.Drawing.Size(40, 27);
            this.label04High.TabIndex = 7;
            this.label04High.Text = "15";
            // 
            // label05Low
            // 
            this.label05Low.AutoSize = true;
            this.label05Low.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label05Low.ForeColor = System.Drawing.Color.Cyan;
            this.label05Low.Location = new System.Drawing.Point(1096, 593);
            this.label05Low.Name = "label05Low";
            this.label05Low.Size = new System.Drawing.Size(40, 27);
            this.label05Low.TabIndex = 7;
            this.label05Low.Text = "15";
            // 
            // label05High
            // 
            this.label05High.AutoSize = true;
            this.label05High.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label05High.ForeColor = System.Drawing.Color.Red;
            this.label05High.Location = new System.Drawing.Point(1166, 593);
            this.label05High.Name = "label05High";
            this.label05High.Size = new System.Drawing.Size(40, 27);
            this.label05High.TabIndex = 7;
            this.label05High.Text = "15";
            // 
            // label06Low
            // 
            this.label06Low.AutoSize = true;
            this.label06Low.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label06Low.ForeColor = System.Drawing.Color.Cyan;
            this.label06Low.Location = new System.Drawing.Point(1096, 671);
            this.label06Low.Name = "label06Low";
            this.label06Low.Size = new System.Drawing.Size(40, 27);
            this.label06Low.TabIndex = 7;
            this.label06Low.Text = "15";
            // 
            // label06High
            // 
            this.label06High.AutoSize = true;
            this.label06High.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label06High.ForeColor = System.Drawing.Color.Red;
            this.label06High.Location = new System.Drawing.Point(1166, 671);
            this.label06High.Name = "label06High";
            this.label06High.Size = new System.Drawing.Size(40, 27);
            this.label06High.TabIndex = 7;
            this.label06High.Text = "15";
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.Font = new System.Drawing.Font("MS UI Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMinTemp.ForeColor = System.Drawing.Color.Cyan;
            this.labelMinTemp.Location = new System.Drawing.Point(743, 177);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(32, 33);
            this.labelMinTemp.TabIndex = 8;
            this.labelMinTemp.Text = "0";
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.Font = new System.Drawing.Font("MS UI Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMaxTemp.ForeColor = System.Drawing.Color.Red;
            this.labelMaxTemp.Location = new System.Drawing.Point(795, 177);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(32, 33);
            this.labelMaxTemp.TabIndex = 8;
            this.labelMaxTemp.Text = "0";
            // 
            // labelWeatherToday
            // 
            this.labelWeatherToday.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWeatherToday.ForeColor = System.Drawing.Color.White;
            this.labelWeatherToday.Location = new System.Drawing.Point(232, 177);
            this.labelWeatherToday.Name = "labelWeatherToday";
            this.labelWeatherToday.Size = new System.Drawing.Size(358, 88);
            this.labelWeatherToday.TabIndex = 9;
            this.labelWeatherToday.Text = "晴れ";
            // 
            // labelWindToday
            // 
            this.labelWindToday.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWindToday.ForeColor = System.Drawing.Color.White;
            this.labelWindToday.Location = new System.Drawing.Point(226, 269);
            this.labelWindToday.Name = "labelWindToday";
            this.labelWindToday.Size = new System.Drawing.Size(547, 50);
            this.labelWindToday.TabIndex = 10;
            this.labelWindToday.Text = "東風";
            // 
            // labelWeatherTomorrow
            // 
            this.labelWeatherTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWeatherTomorrow.ForeColor = System.Drawing.Color.White;
            this.labelWeatherTomorrow.Location = new System.Drawing.Point(247, 592);
            this.labelWeatherTomorrow.Name = "labelWeatherTomorrow";
            this.labelWeatherTomorrow.Size = new System.Drawing.Size(254, 91);
            this.labelWeatherTomorrow.TabIndex = 11;
            this.labelWeatherTomorrow.Text = "晴れ";
            // 
            // labelReportTime
            // 
            this.labelReportTime.AutoSize = true;
            this.labelReportTime.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelReportTime.ForeColor = System.Drawing.Color.White;
            this.labelReportTime.Location = new System.Drawing.Point(501, 10);
            this.labelReportTime.Name = "labelReportTime";
            this.labelReportTime.Size = new System.Drawing.Size(69, 15);
            this.labelReportTime.TabIndex = 12;
            this.labelReportTime.Text = "2022年～";
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(330, 12);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 13;
            this.btChange.Text = "表示変更";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // label_selected
            // 
            this.label_selected.AutoSize = true;
            this.label_selected.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_selected.ForeColor = System.Drawing.Color.White;
            this.label_selected.Location = new System.Drawing.Point(285, 77);
            this.label_selected.Name = "label_selected";
            this.label_selected.Size = new System.Drawing.Size(164, 48);
            this.label_selected.TabIndex = 14;
            this.label_selected.Text = "東京都";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(767, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 33);
            this.label18.TabIndex = 8;
            this.label18.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1294, 720);
            this.Controls.Add(this.label_selected);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.labelReportTime);
            this.Controls.Add(this.labelWeatherTomorrow);
            this.Controls.Add(this.labelWindToday);
            this.Controls.Add(this.labelWeatherToday);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelMaxTemp);
            this.Controls.Add(this.labelMinTemp);
            this.Controls.Add(this.labelNTmHigh);
            this.Controls.Add(this.labelTmHigh);
            this.Controls.Add(this.labelNTmLow);
            this.Controls.Add(this.label06High);
            this.Controls.Add(this.label06Low);
            this.Controls.Add(this.label05High);
            this.Controls.Add(this.label05Low);
            this.Controls.Add(this.label04High);
            this.Controls.Add(this.label04Low);
            this.Controls.Add(this.label03High);
            this.Controls.Add(this.label03Low);
            this.Controls.Add(this.label02High);
            this.Controls.Add(this.label02Low);
            this.Controls.Add(this.labelTmLow);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.WeatherMap);
            this.Controls.Add(this.weatherPbAfTomorrow);
            this.Controls.Add(this.pb_6);
            this.Controls.Add(this.pb_5);
            this.Controls.Add(this.pb_4);
            this.Controls.Add(this.pb_3);
            this.Controls.Add(this.pb_2);
            this.Controls.Add(this.weatherPbTomorrow);
            this.Controls.Add(this.weatherPb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_6);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_select);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox WeatherMap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.PictureBox weatherPbTomorrow;
        private System.Windows.Forms.PictureBox weatherPbAfTomorrow;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_6;
        private System.Windows.Forms.PictureBox pb_2;
        private System.Windows.Forms.PictureBox pb_3;
        private System.Windows.Forms.PictureBox pb_4;
        private System.Windows.Forms.PictureBox pb_5;
        private System.Windows.Forms.PictureBox pb_6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_select;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelTmLow;
        private System.Windows.Forms.Label labelNTmLow;
        private System.Windows.Forms.Label labelTmHigh;
        private System.Windows.Forms.Label labelNTmHigh;
        private System.Windows.Forms.Label label02Low;
        private System.Windows.Forms.Label label02High;
        private System.Windows.Forms.Label label03Low;
        private System.Windows.Forms.Label label03High;
        private System.Windows.Forms.Label label04Low;
        private System.Windows.Forms.Label label04High;
        private System.Windows.Forms.Label label05Low;
        private System.Windows.Forms.Label label05High;
        private System.Windows.Forms.Label label06Low;
        private System.Windows.Forms.Label label06High;
        private System.Windows.Forms.Label labelMinTemp;
        private System.Windows.Forms.Label labelMaxTemp;
        private System.Windows.Forms.Label labelWeatherToday;
        private System.Windows.Forms.Label labelWindToday;
        private System.Windows.Forms.Label labelWeatherTomorrow;
        private System.Windows.Forms.Label labelReportTime;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Label label_selected;
        private System.Windows.Forms.Label label18;
    }
}

