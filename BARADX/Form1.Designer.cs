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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel3 = new System.Windows.Forms.AGaugeLabel();
            this.maps_w = new System.Windows.Forms.WebBrowser();
            this.latitude_disp = new System.Windows.Forms.TextBox();
            this.longitude_disp = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.Get_Port_1 = new System.Windows.Forms.ComboBox();
            this.Get_Port_2 = new System.Windows.Forms.ComboBox();
            this.gauge_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.th_disp = new System.Windows.Forms.Label();
            this.al_disp = new System.Windows.Forms.Label();
            this.sp_disp = new System.Windows.Forms.Label();
            this.sat_img = new System.Windows.Forms.PictureBox();
            this.time_disp = new System.Windows.Forms.TextBox();
            this.battery_voltage = new System.Windows.Forms.TextBox();
            this.testpacket_field = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.test_packet = new System.Windows.Forms.TreeView();
            this.logbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.thrust_gauge = new System.Windows.Forms.AGauge();
            this.altitude_gauge = new System.Windows.Forms.AGauge();
            this.speed_gauge = new System.Windows.Forms.AGauge();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sat_img)).BeginInit();
            this.SuspendLayout();
            // 
            // maps_w
            // 
            this.maps_w.AllowWebBrowserDrop = false;
            this.maps_w.CausesValidation = false;
            this.maps_w.Location = new System.Drawing.Point(5, 5);
            this.maps_w.MinimumSize = new System.Drawing.Size(20, 20);
            this.maps_w.Name = "maps_w";
            this.maps_w.ScriptErrorsSuppressed = true;
            this.maps_w.ScrollBarsEnabled = false;
            this.maps_w.Size = new System.Drawing.Size(578, 545);
            this.maps_w.TabIndex = 0;
            this.maps_w.Url = new System.Uri("https://www.google.co.in/maps/@?api=1&map_action=map", System.UriKind.Absolute);
            this.maps_w.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.maps_w_DocumentCompleted);
            // 
            // latitude_disp
            // 
            this.latitude_disp.Location = new System.Drawing.Point(589, 529);
            this.latitude_disp.Name = "latitude_disp";
            this.latitude_disp.Size = new System.Drawing.Size(89, 20);
            this.latitude_disp.TabIndex = 7;
            this.latitude_disp.TextChanged += new System.EventHandler(this.latitude_TextChanged);
            // 
            // longitude_disp
            // 
            this.longitude_disp.Location = new System.Drawing.Point(684, 529);
            this.longitude_disp.Name = "longitude_disp";
            this.longitude_disp.Size = new System.Drawing.Size(88, 20);
            this.longitude_disp.TabIndex = 8;
            this.longitude_disp.TextChanged += new System.EventHandler(this.longitude_TextChanged);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(594, 243);
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
            this.Get_Port_1.Location = new System.Drawing.Point(594, 174);
            this.Get_Port_1.Name = "Get_Port_1";
            this.Get_Port_1.Size = new System.Drawing.Size(71, 21);
            this.Get_Port_1.TabIndex = 12;
            // 
            // Get_Port_2
            // 
            this.Get_Port_2.FormattingEnabled = true;
            this.Get_Port_2.Location = new System.Drawing.Point(594, 201);
            this.Get_Port_2.Name = "Get_Port_2";
            this.Get_Port_2.Size = new System.Drawing.Size(71, 21);
            this.Get_Port_2.TabIndex = 19;
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
            this.panel1.Location = new System.Drawing.Point(594, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 127);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // th_disp
            // 
            this.th_disp.AutoSize = true;
            this.th_disp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.th_disp.Location = new System.Drawing.Point(903, 116);
            this.th_disp.Name = "th_disp";
            this.th_disp.Size = new System.Drawing.Size(15, 13);
            this.th_disp.TabIndex = 24;
            this.th_disp.Text = "N";
            // 
            // al_disp
            // 
            this.al_disp.AutoSize = true;
            this.al_disp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.al_disp.Location = new System.Drawing.Point(772, 116);
            this.al_disp.Name = "al_disp";
            this.al_disp.Size = new System.Drawing.Size(21, 13);
            this.al_disp.TabIndex = 25;
            this.al_disp.Text = "km";
            // 
            // sp_disp
            // 
            this.sp_disp.AutoSize = true;
            this.sp_disp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sp_disp.Location = new System.Drawing.Point(637, 116);
            this.sp_disp.Name = "sp_disp";
            this.sp_disp.Size = new System.Drawing.Size(33, 13);
            this.sp_disp.TabIndex = 26;
            this.sp_disp.Text = "kmph";
            // 
            // sat_img
            // 
            this.sat_img.Image = ((System.Drawing.Image)(resources.GetObject("sat_img.Image")));
            this.sat_img.Location = new System.Drawing.Point(780, 516);
            this.sat_img.Name = "sat_img";
            this.sat_img.Size = new System.Drawing.Size(38, 26);
            this.sat_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sat_img.TabIndex = 32;
            this.sat_img.TabStop = false;
            // 
            // time_disp
            // 
            this.time_disp.Location = new System.Drawing.Point(804, 8);
            this.time_disp.Name = "time_disp";
            this.time_disp.ReadOnly = true;
            this.time_disp.Size = new System.Drawing.Size(129, 20);
            this.time_disp.TabIndex = 33;
            // 
            // battery_voltage
            // 
            this.battery_voltage.Location = new System.Drawing.Point(804, 168);
            this.battery_voltage.Name = "battery_voltage";
            this.battery_voltage.ReadOnly = true;
            this.battery_voltage.Size = new System.Drawing.Size(129, 20);
            this.battery_voltage.TabIndex = 34;
            // 
            // testpacket_field
            // 
            this.testpacket_field.Location = new System.Drawing.Point(594, 461);
            this.testpacket_field.Name = "testpacket_field";
            this.testpacket_field.Size = new System.Drawing.Size(162, 20);
            this.testpacket_field.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "TEST PACKET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // test_packet
            // 
            this.test_packet.BackColor = System.Drawing.SystemColors.Control;
            this.test_packet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.test_packet.ItemHeight = 34;
            this.test_packet.Location = new System.Drawing.Point(809, 205);
            this.test_packet.Name = "test_packet";
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
            this.test_packet.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
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
            this.test_packet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.test_packet.RightToLeftLayout = true;
            this.test_packet.Scrollable = false;
            this.test_packet.Size = new System.Drawing.Size(385, 350);
            this.test_packet.TabIndex = 31;
            // 
            // logbox
            // 
            this.logbox.Location = new System.Drawing.Point(594, 272);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logbox.Size = new System.Drawing.Size(162, 183);
            this.logbox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "TIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "BATTERY VOLTAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(939, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "V";
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testpacket_field);
            this.Controls.Add(this.battery_voltage);
            this.Controls.Add(this.time_disp);
            this.Controls.Add(this.sat_img);
            this.Controls.Add(this.sp_disp);
            this.Controls.Add(this.al_disp);
            this.Controls.Add(this.th_disp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Get_Port_2);
            this.Controls.Add(this.Get_Port_1);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.longitude_disp);
            this.Controls.Add(this.latitude_disp);
            this.Controls.Add(this.maps_w);
            this.Controls.Add(this.test_packet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sat_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser maps_w;
        private System.Windows.Forms.TextBox latitude_disp;
        private System.Windows.Forms.TextBox longitude_disp;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.ComboBox Get_Port_1;
        private System.Windows.Forms.ComboBox Get_Port_2;
        private System.Windows.Forms.Timer gauge_timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.AGauge thrust_gauge;
        private System.Windows.Forms.AGauge altitude_gauge;
        private System.Windows.Forms.AGauge speed_gauge;
        private System.Windows.Forms.Label th_disp;
        private System.Windows.Forms.Label al_disp;
        private System.Windows.Forms.Label sp_disp;
        private System.Windows.Forms.PictureBox sat_img;
        private System.Windows.Forms.TextBox time_disp;
        private System.Windows.Forms.TextBox battery_voltage;
        private System.Windows.Forms.TextBox testpacket_field;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView test_packet;
        private System.Windows.Forms.TextBox logbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

