using System;
using System.Runtime.InteropServices;
namespace SMHCalculator
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_ActiveSME = new System.Windows.Forms.Label();
            this.lab_LAYER = new System.Windows.Forms.Label();
            this.lab_EPOCH = new System.Windows.Forms.Label();
            this.lab_SME = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_accounts = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Size = new System.Windows.Forms.TextBox();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lb_MouthlyUSD = new System.Windows.Forms.Label();
            this.lb_DaliyUSD = new System.Windows.Forms.Label();
            this.lb_MonthlySMH = new System.Windows.Forms.Label();
            this.lb_DailySMH = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_USD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spacemesh Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_ActiveSME);
            this.groupBox1.Controls.Add(this.lab_LAYER);
            this.groupBox1.Controls.Add(this.lab_EPOCH);
            this.groupBox1.Controls.Add(this.lab_SME);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lab_accounts);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network";
            // 
            // lab_ActiveSME
            // 
            this.lab_ActiveSME.AutoSize = true;
            this.lab_ActiveSME.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ActiveSME.ForeColor = System.Drawing.Color.Magenta;
            this.lab_ActiveSME.Location = new System.Drawing.Point(516, 70);
            this.lab_ActiveSME.Name = "lab_ActiveSME";
            this.lab_ActiveSME.Size = new System.Drawing.Size(18, 19);
            this.lab_ActiveSME.TabIndex = 13;
            this.lab_ActiveSME.Text = "0";
            // 
            // lab_LAYER
            // 
            this.lab_LAYER.AutoSize = true;
            this.lab_LAYER.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_LAYER.ForeColor = System.Drawing.Color.Magenta;
            this.lab_LAYER.Location = new System.Drawing.Point(406, 70);
            this.lab_LAYER.Name = "lab_LAYER";
            this.lab_LAYER.Size = new System.Drawing.Size(18, 19);
            this.lab_LAYER.TabIndex = 12;
            this.lab_LAYER.Text = "0";
            // 
            // lab_EPOCH
            // 
            this.lab_EPOCH.AutoSize = true;
            this.lab_EPOCH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_EPOCH.ForeColor = System.Drawing.Color.Magenta;
            this.lab_EPOCH.Location = new System.Drawing.Point(315, 70);
            this.lab_EPOCH.Name = "lab_EPOCH";
            this.lab_EPOCH.Size = new System.Drawing.Size(18, 19);
            this.lab_EPOCH.TabIndex = 11;
            this.lab_EPOCH.Text = "0";
            // 
            // lab_SME
            // 
            this.lab_SME.AutoSize = true;
            this.lab_SME.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SME.ForeColor = System.Drawing.Color.Magenta;
            this.lab_SME.Location = new System.Drawing.Point(134, 70);
            this.lab_SME.Name = "lab_SME";
            this.lab_SME.Size = new System.Drawing.Size(54, 19);
            this.lab_SME.TabIndex = 10;
            this.lab_SME.Text = "0 SMH";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "|";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "|";
            // 
            // lab_accounts
            // 
            this.lab_accounts.AutoSize = true;
            this.lab_accounts.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_accounts.ForeColor = System.Drawing.Color.Magenta;
            this.lab_accounts.Location = new System.Drawing.Point(18, 70);
            this.lab_accounts.Name = "lab_accounts";
            this.lab_accounts.Size = new System.Drawing.Size(18, 19);
            this.lab_accounts.TabIndex = 5;
            this.lab_accounts.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "ACTIVE SMESHERS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "SECURITY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "EPOCH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "SMESHING REWARDS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ACCOUNTS";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 215);
            this.trackBar1.Maximum = 1024;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(540, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Number of Post Data";
            // 
            // tb_Size
            // 
            this.tb_Size.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Size.Location = new System.Drawing.Point(554, 215);
            this.tb_Size.Name = "tb_Size";
            this.tb_Size.Size = new System.Drawing.Size(54, 26);
            this.tb_Size.TabIndex = 5;
            // 
            // cb_size
            // 
            this.cb_size.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Items.AddRange(new object[] {
            "GiB",
            "TiB",
            "PiB"});
            this.cb_size.Location = new System.Drawing.Point(614, 214);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(57, 27);
            this.cb_size.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lb_MouthlyUSD);
            this.groupBox2.Controls.Add(this.lb_DaliyUSD);
            this.groupBox2.Controls.Add(this.lb_MonthlySMH);
            this.groupBox2.Controls.Add(this.lb_DailySMH);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 111);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estimated Earnings";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(472, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 19);
            this.label20.TabIndex = 12;
            this.label20.Text = "|";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(303, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 19);
            this.label19.TabIndex = 11;
            this.label19.Text = "|";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(108, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 19);
            this.label18.TabIndex = 10;
            this.label18.Text = "|";
            // 
            // lb_MouthlyUSD
            // 
            this.lb_MouthlyUSD.AutoSize = true;
            this.lb_MouthlyUSD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MouthlyUSD.ForeColor = System.Drawing.Color.Red;
            this.lb_MouthlyUSD.Location = new System.Drawing.Point(518, 64);
            this.lb_MouthlyUSD.Name = "lb_MouthlyUSD";
            this.lb_MouthlyUSD.Size = new System.Drawing.Size(18, 19);
            this.lb_MouthlyUSD.TabIndex = 9;
            this.lb_MouthlyUSD.Text = "0";
            // 
            // lb_DaliyUSD
            // 
            this.lb_DaliyUSD.AutoSize = true;
            this.lb_DaliyUSD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DaliyUSD.ForeColor = System.Drawing.Color.Red;
            this.lb_DaliyUSD.Location = new System.Drawing.Point(356, 64);
            this.lb_DaliyUSD.Name = "lb_DaliyUSD";
            this.lb_DaliyUSD.Size = new System.Drawing.Size(18, 19);
            this.lb_DaliyUSD.TabIndex = 8;
            this.lb_DaliyUSD.Text = "0";
            // 
            // lb_MonthlySMH
            // 
            this.lb_MonthlySMH.AutoSize = true;
            this.lb_MonthlySMH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MonthlySMH.ForeColor = System.Drawing.Color.Red;
            this.lb_MonthlySMH.Location = new System.Drawing.Point(154, 64);
            this.lb_MonthlySMH.Name = "lb_MonthlySMH";
            this.lb_MonthlySMH.Size = new System.Drawing.Size(18, 19);
            this.lb_MonthlySMH.TabIndex = 7;
            this.lb_MonthlySMH.Text = "0";
            // 
            // lb_DailySMH
            // 
            this.lb_DailySMH.AutoSize = true;
            this.lb_DailySMH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DailySMH.ForeColor = System.Drawing.Color.Red;
            this.lb_DailySMH.Location = new System.Drawing.Point(6, 64);
            this.lb_DailySMH.Name = "lb_DailySMH";
            this.lb_DailySMH.Size = new System.Drawing.Size(18, 19);
            this.lb_DailySMH.TabIndex = 6;
            this.lb_DailySMH.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(510, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "Monthly USD";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(357, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "Daily USD";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(155, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Monthly SMH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Daily SMH";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.tb_USD);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 508);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 119);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exchange Rate";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(15, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(228, 14);
            this.label22.TabIndex = 12;
            this.label22.Text = "Default exchange rate from coinmarketcap";
            // 
            // tb_USD
            // 
            this.tb_USD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_USD.Location = new System.Drawing.Point(41, 57);
            this.tb_USD.Name = "tb_USD";
            this.tb_USD.Size = new System.Drawing.Size(65, 26);
            this.tb_USD.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "USD per SMH";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(654, 75);
            this.label21.TabIndex = 11;
            this.label21.Text = resources.GetString("label21.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 668);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cb_size);
            this.Controls.Add(this.tb_Size);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMH Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_ActiveSME;
        private System.Windows.Forms.Label lab_LAYER;
        private System.Windows.Forms.Label lab_EPOCH;
        private System.Windows.Forms.Label lab_SME;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_accounts;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Size;
        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_USD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_MouthlyUSD;
        private System.Windows.Forms.Label lb_DaliyUSD;
        private System.Windows.Forms.Label lb_MonthlySMH;
        private System.Windows.Forms.Label lb_DailySMH;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

