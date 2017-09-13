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
            this.latitude_disp = new System.Windows.Forms.TextBox();
            this.longitude_disp = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.Get_Port_1 = new System.Windows.Forms.ComboBox();
            this.Get_Port_2 = new System.Windows.Forms.ComboBox();
            this.gauge_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thrust_gauge = new System.Windows.Forms.AGauge();
            this.altitude_gauge = new System.Windows.Forms.AGauge();
            this.speed_gauge = new System.Windows.Forms.AGauge();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sat_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // latitude_disp
            // 
            this.latitude_disp.Location = new System.Drawing.Point(524, 469);
            this.latitude_disp.Name = "latitude_disp";
            this.latitude_disp.ReadOnly = true;
            this.latitude_disp.Size = new System.Drawing.Size(89, 20);
            this.latitude_disp.TabIndex = 7;
            this.latitude_disp.TextChanged += new System.EventHandler(this.latitude_TextChanged);
            // 
            // longitude_disp
            // 
            this.longitude_disp.Location = new System.Drawing.Point(619, 469);
            this.longitude_disp.Name = "longitude_disp";
            this.longitude_disp.ReadOnly = true;
            this.longitude_disp.Size = new System.Drawing.Size(88, 20);
            this.longitude_disp.TabIndex = 8;
            this.longitude_disp.TextChanged += new System.EventHandler(this.longitude_TextChanged);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(674, 152);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(33, 23);
            this.connect_button.TabIndex = 11;
            this.connect_button.Text = "GO";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // Get_Port_1
            // 
            this.Get_Port_1.FormattingEnabled = true;
            this.Get_Port_1.Location = new System.Drawing.Point(529, 153);
            this.Get_Port_1.Name = "Get_Port_1";
            this.Get_Port_1.Size = new System.Drawing.Size(71, 21);
            this.Get_Port_1.TabIndex = 12;
            // 
            // Get_Port_2
            // 
            this.Get_Port_2.FormattingEnabled = true;
            this.Get_Port_2.Location = new System.Drawing.Point(602, 153);
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
            this.panel1.Location = new System.Drawing.Point(529, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 117);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sat_img
            // 
            this.sat_img.Image = ((System.Drawing.Image)(resources.GetObject("sat_img.Image")));
            this.sat_img.Location = new System.Drawing.Point(726, 463);
            this.sat_img.Name = "sat_img";
            this.sat_img.Size = new System.Drawing.Size(51, 26);
            this.sat_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sat_img.TabIndex = 32;
            this.sat_img.TabStop = false;
            // 
            // time_disp
            // 
            this.time_disp.Location = new System.Drawing.Point(570, 8);
            this.time_disp.Name = "time_disp";
            this.time_disp.ReadOnly = true;
            this.time_disp.Size = new System.Drawing.Size(60, 20);
            this.time_disp.TabIndex = 33;
            // 
            // battery_voltage
            // 
            this.battery_voltage.Location = new System.Drawing.Point(838, 7);
            this.battery_voltage.Name = "battery_voltage";
            this.battery_voltage.ReadOnly = true;
            this.battery_voltage.Size = new System.Drawing.Size(55, 20);
            this.battery_voltage.TabIndex = 34;
            // 
            // testpacket_field
            // 
            this.testpacket_field.Location = new System.Drawing.Point(529, 416);
            this.testpacket_field.Name = "testpacket_field";
            this.testpacket_field.Size = new System.Drawing.Size(162, 20);
            this.testpacket_field.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 442);
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
            this.test_packet.Location = new System.Drawing.Point(755, 152);
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
            this.test_packet.Size = new System.Drawing.Size(161, 350);
            this.test_packet.TabIndex = 31;
            // 
            // logbox
            // 
            this.logbox.Location = new System.Drawing.Point(529, 181);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logbox.Size = new System.Drawing.Size(178, 229);
            this.logbox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "TIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(780, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "BATTERY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(895, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "V";
            // 
            // gmap
            // 
            this.gmap.AutoSize = true;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = false;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.Enabled = false;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(4, 4);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 0;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(515, 487);
            this.gmap.TabIndex = 41;
            this.gmap.Zoom = 0D;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // thrust_gauge
            // 
            this.thrust_gauge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thrust_gauge.BaseArcColor = System.Drawing.Color.Gray;
            this.thrust_gauge.BaseArcRadius = 35;
            this.thrust_gauge.BaseArcStart = 135;
            this.thrust_gauge.BaseArcSweep = 270;
            this.thrust_gauge.BaseArcWidth = 2;
            this.thrust_gauge.Center = new System.Drawing.Point(64, 64);
            this.thrust_gauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel1.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel1.Name = "Thrust";
            aGaugeLabel1.Position = new System.Drawing.Point(45, 100);
            aGaugeLabel1.Text = "Thrust";
            this.thrust_gauge.GaugeLabels.Add(aGaugeLabel1);
            this.thrust_gauge.Location = new System.Drawing.Point(251, -2);
            this.thrust_gauge.MaxValue = 3200F;
            this.thrust_gauge.MinValue = 0F;
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
            this.thrust_gauge.ScaleLinesMajorStepValue = 300F;
            this.thrust_gauge.ScaleLinesMajorWidth = 2;
            this.thrust_gauge.ScaleLinesMinorColor = System.Drawing.SystemColors.Desktop;
            this.thrust_gauge.ScaleLinesMinorInnerRadius = 40;
            this.thrust_gauge.ScaleLinesMinorOuterRadius = 37;
            this.thrust_gauge.ScaleLinesMinorTicks = 9;
            this.thrust_gauge.ScaleLinesMinorWidth = 1;
            this.thrust_gauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.thrust_gauge.ScaleNumbersFormat = null;
            this.thrust_gauge.ScaleNumbersRadius = 53;
            this.thrust_gauge.ScaleNumbersRotation = 0;
            this.thrust_gauge.ScaleNumbersStartScaleLine = 0;
            this.thrust_gauge.ScaleNumbersStepScaleLines = 1;
            this.thrust_gauge.Size = new System.Drawing.Size(142, 119);
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
            this.altitude_gauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel2.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel2.Name = "Altitude";
            aGaugeLabel2.Position = new System.Drawing.Point(45, 100);
            aGaugeLabel2.Text = "Altitude";
            this.altitude_gauge.GaugeLabels.Add(aGaugeLabel2);
            this.altitude_gauge.Location = new System.Drawing.Point(126, -3);
            this.altitude_gauge.MaxValue = 100F;
            this.altitude_gauge.MinValue = 0F;
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
            this.altitude_gauge.ScaleLinesMajorStepValue = 10F;
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
            this.altitude_gauge.Size = new System.Drawing.Size(150, 126);
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
            this.speed_gauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel3.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel3.Name = "Speed";
            aGaugeLabel3.Position = new System.Drawing.Point(45, 100);
            aGaugeLabel3.Text = "Speed";
            this.speed_gauge.GaugeLabels.Add(aGaugeLabel3);
            this.speed_gauge.Location = new System.Drawing.Point(4, -2);
            this.speed_gauge.MaxValue = 100F;
            this.speed_gauge.MinValue = 0F;
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
            this.speed_gauge.ScaleLinesMajorStepValue = 10F;
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
            this.speed_gauge.Size = new System.Drawing.Size(138, 122);
            this.speed_gauge.TabIndex = 23;
            this.speed_gauge.Text = "Speed";
            this.speed_gauge.Value = 0F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testpacket_field);
            this.Controls.Add(this.battery_voltage);
            this.Controls.Add(this.time_disp);
            this.Controls.Add(this.sat_img);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Get_Port_2);
            this.Controls.Add(this.Get_Port_1);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.longitude_disp);
            this.Controls.Add(this.latitude_disp);
            this.Controls.Add(this.test_packet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BARADX";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sat_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

