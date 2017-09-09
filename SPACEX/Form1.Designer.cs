namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Deploy success");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("successful insertion into orbit");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("stage-3 ignition");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("stage-2 separation");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("stage-2 ignition");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("stage-1 separation");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("roll sequence initiated");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Lift Off!");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Boost Ignition");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Ignition Start");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel3 = new System.Windows.Forms.AGaugeLabel();
            this.maps_w = new System.Windows.Forms.WebBrowser();
            this.latitude = new System.Windows.Forms.TextBox();
            this.longitude = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.Get_Port_1 = new System.Windows.Forms.ComboBox();
            this.Get_Port_2 = new System.Windows.Forms.ComboBox();
            this.locate = new System.Windows.Forms.Button();
            this.gauge_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.th_disp = new System.Windows.Forms.Label();
            this.al_disp = new System.Windows.Forms.Label();
            this.sp_disp = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.midway_indicator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zero_indicator = new System.Windows.Forms.Label();
            this.cent_indicator = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.sat_img = new System.Windows.Forms.PictureBox();
            this.thrust_gauge = new System.Windows.Forms.AGauge();
            this.altitude_gauge = new System.Windows.Forms.AGauge();
            this.speed_gauge = new System.Windows.Forms.AGauge();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sat_img)).BeginInit();
            this.SuspendLayout();
            // 
            // maps_w
            // 
            this.maps_w.AllowWebBrowserDrop = false;
            this.maps_w.CausesValidation = false;
            this.maps_w.Location = new System.Drawing.Point(384, 3);
            this.maps_w.MinimumSize = new System.Drawing.Size(20, 20);
            this.maps_w.Name = "maps_w";
            this.maps_w.ScriptErrorsSuppressed = true;
            this.maps_w.ScrollBarsEnabled = false;
            this.maps_w.Size = new System.Drawing.Size(581, 541);
            this.maps_w.TabIndex = 0;
            this.maps_w.Url = new System.Uri("https://www.google.co.in/maps/@?api=1&map_action=map", System.UriKind.Absolute);
            this.maps_w.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.maps_w_DocumentCompleted);
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(200, 441);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(77, 20);
            this.latitude.TabIndex = 7;
            this.latitude.TextChanged += new System.EventHandler(this.latitude_TextChanged);
            // 
            // longitude
            // 
            this.longitude.Location = new System.Drawing.Point(297, 441);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(77, 20);
            this.longitude.TabIndex = 8;
            this.longitude.TextChanged += new System.EventHandler(this.longitude_TextChanged);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(257, 303);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 11;
            this.connect_button.Text = "CONNECT";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // Get_Port_1
            // 
            this.Get_Port_1.FormattingEnabled = true;
            this.Get_Port_1.Location = new System.Drawing.Point(257, 234);
            this.Get_Port_1.Name = "Get_Port_1";
            this.Get_Port_1.Size = new System.Drawing.Size(71, 21);
            this.Get_Port_1.TabIndex = 12;
            // 
            // Get_Port_2
            // 
            this.Get_Port_2.FormattingEnabled = true;
            this.Get_Port_2.Location = new System.Drawing.Point(257, 261);
            this.Get_Port_2.Name = "Get_Port_2";
            this.Get_Port_2.Size = new System.Drawing.Size(71, 21);
            this.Get_Port_2.TabIndex = 19;
            // 
            // locate
            // 
            this.locate.Location = new System.Drawing.Point(253, 410);
            this.locate.Name = "locate";
            this.locate.Size = new System.Drawing.Size(75, 23);
            this.locate.TabIndex = 21;
            this.locate.Text = "Locate";
            this.locate.UseVisualStyleBackColor = true;
            this.locate.Click += new System.EventHandler(this.button1_Click);
            // 
            // gauge_timer
            // 
            this.gauge_timer.Enabled = true;
            this.gauge_timer.Interval = 500;
            this.gauge_timer.Tick += new System.EventHandler(this.gauge_timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.thrust_gauge);
            this.panel1.Controls.Add(this.altitude_gauge);
            this.panel1.Controls.Add(this.speed_gauge);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 127);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // th_disp
            // 
            this.th_disp.AutoSize = true;
            this.th_disp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.th_disp.Location = new System.Drawing.Point(310, 85);
            this.th_disp.Name = "th_disp";
            this.th_disp.Size = new System.Drawing.Size(15, 13);
            this.th_disp.TabIndex = 24;
            this.th_disp.Text = "N";
            // 
            // al_disp
            // 
            this.al_disp.AutoSize = true;
            this.al_disp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.al_disp.Location = new System.Drawing.Point(179, 85);
            this.al_disp.Name = "al_disp";
            this.al_disp.Size = new System.Drawing.Size(21, 13);
            this.al_disp.TabIndex = 25;
            this.al_disp.Text = "km";
            // 
            // sp_disp
            // 
            this.sp_disp.AutoSize = true;
            this.sp_disp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sp_disp.Location = new System.Drawing.Point(44, 85);
            this.sp_disp.Name = "sp_disp";
            this.sp_disp.Size = new System.Drawing.Size(33, 13);
            this.sp_disp.TabIndex = 26;
            this.sp_disp.Text = "kmph";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 515);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(311, 23);
            this.progressBar1.TabIndex = 27;
            this.progressBar1.Value = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.midway_indicator);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 475);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 76);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // midway_indicator
            // 
            this.midway_indicator.AutoSize = true;
            this.midway_indicator.Location = new System.Drawing.Point(170, 65);
            this.midway_indicator.Name = "midway_indicator";
            this.midway_indicator.Size = new System.Drawing.Size(13, 13);
            this.midway_indicator.TabIndex = 31;
            this.midway_indicator.Text = "^";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Battery";
            // 
            // zero_indicator
            // 
            this.zero_indicator.AutoSize = true;
            this.zero_indicator.Location = new System.Drawing.Point(13, 520);
            this.zero_indicator.Name = "zero_indicator";
            this.zero_indicator.Size = new System.Drawing.Size(13, 13);
            this.zero_indicator.TabIndex = 29;
            this.zero_indicator.Text = "0";
            // 
            // cent_indicator
            // 
            this.cent_indicator.AutoSize = true;
            this.cent_indicator.Location = new System.Drawing.Point(339, 520);
            this.cent_indicator.Name = "cent_indicator";
            this.cent_indicator.Size = new System.Drawing.Size(25, 13);
            this.cent_indicator.TabIndex = 30;
            this.cent_indicator.Text = "100";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ItemHeight = 34;
            this.treeView1.Location = new System.Drawing.Point(35, 132);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "139";
            treeNode1.Text = "Deploy success";
            treeNode2.Name = "123";
            treeNode2.Text = "successful insertion into orbit";
            treeNode3.Name = "106";
            treeNode3.Text = "stage-3 ignition";
            treeNode4.Name = "103";
            treeNode4.Text = "stage-2 separation";
            treeNode5.Name = "091";
            treeNode5.Text = "stage-2 ignition";
            treeNode6.Name = "088";
            treeNode6.Text = "stage-1 separation";
            treeNode7.Name = "048";
            treeNode7.Text = "roll sequence initiated";
            treeNode8.Name = "013";
            treeNode8.Text = "Lift Off!";
            treeNode9.Name = "009";
            treeNode9.Text = "Boost Ignition";
            treeNode10.Name = "001";
            treeNode10.Text = "Ignition Start";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.treeView1.Scrollable = false;
            this.treeView1.Size = new System.Drawing.Size(204, 350);
            this.treeView1.TabIndex = 31;
            // 
            // sat_img
            // 
            this.sat_img.Image = ((System.Drawing.Image)(resources.GetObject("sat_img.Image")));
            this.sat_img.Location = new System.Drawing.Point(6, 443);
            this.sat_img.Name = "sat_img";
            this.sat_img.Size = new System.Drawing.Size(38, 26);
            this.sat_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sat_img.TabIndex = 32;
            this.sat_img.TabStop = false;
            // 
            // thrust_gauge
            // 
            this.thrust_gauge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thrust_gauge.BaseArcColor = System.Drawing.Color.Gray;
            this.thrust_gauge.BaseArcRadius = 35;
            this.thrust_gauge.BaseArcStart = 135;
            this.thrust_gauge.BaseArcSweep = 270;
            this.thrust_gauge.BaseArcWidth = 2;
            this.thrust_gauge.Center = new System.Drawing.Point(60, 60);
            aGaugeLabel1.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel1.Name = "Thrust";
            aGaugeLabel1.Position = new System.Drawing.Point(45, 100);
            aGaugeLabel1.Text = "Thrust";
            this.thrust_gauge.GaugeLabels.Add(aGaugeLabel1);
            this.thrust_gauge.Location = new System.Drawing.Point(253, 2);
            this.thrust_gauge.MaxValue = 400F;
            this.thrust_gauge.MinValue = -100F;
            this.thrust_gauge.Name = "thrust_gauge";
            this.thrust_gauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.thrust_gauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.thrust_gauge.NeedleRadius = 47;
            this.thrust_gauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.thrust_gauge.NeedleWidth = 2;
            this.thrust_gauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.thrust_gauge.ScaleLinesInterInnerRadius = 35;
            this.thrust_gauge.ScaleLinesInterOuterRadius = 30;
            this.thrust_gauge.ScaleLinesInterWidth = 1;
            this.thrust_gauge.ScaleLinesMajorColor = System.Drawing.SystemColors.Control;
            this.thrust_gauge.ScaleLinesMajorInnerRadius = 40;
            this.thrust_gauge.ScaleLinesMajorOuterRadius = 35;
            this.thrust_gauge.ScaleLinesMajorStepValue = 50F;
            this.thrust_gauge.ScaleLinesMajorWidth = 2;
            this.thrust_gauge.ScaleLinesMinorColor = System.Drawing.SystemColors.Desktop;
            this.thrust_gauge.ScaleLinesMinorInnerRadius = 40;
            this.thrust_gauge.ScaleLinesMinorOuterRadius = 37;
            this.thrust_gauge.ScaleLinesMinorTicks = 9;
            this.thrust_gauge.ScaleLinesMinorWidth = 1;
            this.thrust_gauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.thrust_gauge.ScaleNumbersFormat = null;
            this.thrust_gauge.ScaleNumbersRadius = 52;
            this.thrust_gauge.ScaleNumbersRotation = 0;
            this.thrust_gauge.ScaleNumbersStartScaleLine = 0;
            this.thrust_gauge.ScaleNumbersStepScaleLines = 1;
            this.thrust_gauge.Size = new System.Drawing.Size(123, 119);
            this.thrust_gauge.TabIndex = 25;
            this.thrust_gauge.Text = "Thrust";
            this.thrust_gauge.Value = 0F;
            // 
            // altitude_gauge
            // 
            this.altitude_gauge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altitude_gauge.BaseArcColor = System.Drawing.Color.Gray;
            this.altitude_gauge.BaseArcRadius = 35;
            this.altitude_gauge.BaseArcStart = 135;
            this.altitude_gauge.BaseArcSweep = 270;
            this.altitude_gauge.BaseArcWidth = 2;
            this.altitude_gauge.Center = new System.Drawing.Point(60, 60);
            aGaugeLabel2.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel2.Name = "Altitude";
            aGaugeLabel2.Position = new System.Drawing.Point(45, 100);
            aGaugeLabel2.Text = "Altitude";
            this.altitude_gauge.GaugeLabels.Add(aGaugeLabel2);
            this.altitude_gauge.Location = new System.Drawing.Point(124, 2);
            this.altitude_gauge.MaxValue = 400F;
            this.altitude_gauge.MinValue = -100F;
            this.altitude_gauge.Name = "altitude_gauge";
            this.altitude_gauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.altitude_gauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.altitude_gauge.NeedleRadius = 47;
            this.altitude_gauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.altitude_gauge.NeedleWidth = 2;
            this.altitude_gauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.altitude_gauge.ScaleLinesInterInnerRadius = 35;
            this.altitude_gauge.ScaleLinesInterOuterRadius = 30;
            this.altitude_gauge.ScaleLinesInterWidth = 1;
            this.altitude_gauge.ScaleLinesMajorColor = System.Drawing.SystemColors.Control;
            this.altitude_gauge.ScaleLinesMajorInnerRadius = 40;
            this.altitude_gauge.ScaleLinesMajorOuterRadius = 35;
            this.altitude_gauge.ScaleLinesMajorStepValue = 50F;
            this.altitude_gauge.ScaleLinesMajorWidth = 2;
            this.altitude_gauge.ScaleLinesMinorColor = System.Drawing.SystemColors.Desktop;
            this.altitude_gauge.ScaleLinesMinorInnerRadius = 40;
            this.altitude_gauge.ScaleLinesMinorOuterRadius = 37;
            this.altitude_gauge.ScaleLinesMinorTicks = 9;
            this.altitude_gauge.ScaleLinesMinorWidth = 1;
            this.altitude_gauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.altitude_gauge.ScaleNumbersFormat = null;
            this.altitude_gauge.ScaleNumbersRadius = 52;
            this.altitude_gauge.ScaleNumbersRotation = 0;
            this.altitude_gauge.ScaleNumbersStartScaleLine = 0;
            this.altitude_gauge.ScaleNumbersStepScaleLines = 1;
            this.altitude_gauge.Size = new System.Drawing.Size(123, 119);
            this.altitude_gauge.TabIndex = 24;
            this.altitude_gauge.Text = "Altitude";
            this.altitude_gauge.Value = 0F;
            // 
            // speed_gauge
            // 
            this.speed_gauge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speed_gauge.BaseArcColor = System.Drawing.Color.Gray;
            this.speed_gauge.BaseArcRadius = 35;
            this.speed_gauge.BaseArcStart = 135;
            this.speed_gauge.BaseArcSweep = 270;
            this.speed_gauge.BaseArcWidth = 2;
            this.speed_gauge.Center = new System.Drawing.Point(60, 60);
            aGaugeLabel3.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel3.Name = "Speed";
            aGaugeLabel3.Position = new System.Drawing.Point(45, 100);
            aGaugeLabel3.Text = "Speed";
            this.speed_gauge.GaugeLabels.Add(aGaugeLabel3);
            this.speed_gauge.Location = new System.Drawing.Point(-1, 4);
            this.speed_gauge.MaxValue = 400F;
            this.speed_gauge.MinValue = -100F;
            this.speed_gauge.Name = "speed_gauge";
            this.speed_gauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.speed_gauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.speed_gauge.NeedleRadius = 47;
            this.speed_gauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.speed_gauge.NeedleWidth = 2;
            this.speed_gauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.speed_gauge.ScaleLinesInterInnerRadius = 35;
            this.speed_gauge.ScaleLinesInterOuterRadius = 30;
            this.speed_gauge.ScaleLinesInterWidth = 1;
            this.speed_gauge.ScaleLinesMajorColor = System.Drawing.SystemColors.Control;
            this.speed_gauge.ScaleLinesMajorInnerRadius = 40;
            this.speed_gauge.ScaleLinesMajorOuterRadius = 35;
            this.speed_gauge.ScaleLinesMajorStepValue = 50F;
            this.speed_gauge.ScaleLinesMajorWidth = 2;
            this.speed_gauge.ScaleLinesMinorColor = System.Drawing.SystemColors.Desktop;
            this.speed_gauge.ScaleLinesMinorInnerRadius = 40;
            this.speed_gauge.ScaleLinesMinorOuterRadius = 37;
            this.speed_gauge.ScaleLinesMinorTicks = 9;
            this.speed_gauge.ScaleLinesMinorWidth = 1;
            this.speed_gauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.speed_gauge.ScaleNumbersFormat = null;
            this.speed_gauge.ScaleNumbersRadius = 52;
            this.speed_gauge.ScaleNumbersRotation = 0;
            this.speed_gauge.ScaleNumbersStartScaleLine = 0;
            this.speed_gauge.ScaleNumbersStepScaleLines = 1;
            this.speed_gauge.Size = new System.Drawing.Size(123, 119);
            this.speed_gauge.TabIndex = 23;
            this.speed_gauge.Text = "Speed";
            this.speed_gauge.Value = 0F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 556);
            this.Controls.Add(this.sat_img);
            this.Controls.Add(this.cent_indicator);
            this.Controls.Add(this.zero_indicator);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sp_disp);
            this.Controls.Add(this.al_disp);
            this.Controls.Add(this.th_disp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.locate);
            this.Controls.Add(this.Get_Port_2);
            this.Controls.Add(this.Get_Port_1);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.maps_w);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sat_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser maps_w;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.ComboBox Get_Port_1;
        private System.Windows.Forms.ComboBox Get_Port_2;
        private System.Windows.Forms.Button locate;
        private System.Windows.Forms.Timer gauge_timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.AGauge thrust_gauge;
        private System.Windows.Forms.AGauge altitude_gauge;
        private System.Windows.Forms.AGauge speed_gauge;
        private System.Windows.Forms.Label th_disp;
        private System.Windows.Forms.Label al_disp;
        private System.Windows.Forms.Label sp_disp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label midway_indicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zero_indicator;
        private System.Windows.Forms.Label cent_indicator;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox sat_img;
    }
}

