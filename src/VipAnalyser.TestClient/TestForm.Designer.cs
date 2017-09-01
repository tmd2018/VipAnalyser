﻿namespace VipAnalyser.TestClient
{
    partial class TestForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Excute = new System.Windows.Forms.Button();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.numeric_Timeout = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxt_Param = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtxt_Result = new System.Windows.Forms.RichTextBox();
            this.cmb_Program = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stopkey = new System.Windows.Forms.TextBox();
            this.lb_time = new System.Windows.Forms.Label();
            this.radio_local = new System.Windows.Forms.RadioButton();
            this.radio_remote = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Timeout)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Excute
            // 
            this.btn_Excute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Excute.Location = new System.Drawing.Point(385, 575);
            this.btn_Excute.Name = "btn_Excute";
            this.btn_Excute.Size = new System.Drawing.Size(75, 25);
            this.btn_Excute.TabIndex = 0;
            this.btn_Excute.Text = "调用";
            this.btn_Excute.UseVisualStyleBackColor = true;
            this.btn_Excute.Click += new System.EventHandler(this.btn_Excute_Click);
            // 
            // cmb_Type
            // 
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "GetVersion",
            "FindVehicle",
            "CarRenewal",
            "QuotePrice",
            "SetReqKeyVal",
            "FindReconciliationInfo",
            "GetCarInfos",
            "UpdateConfigInfo",
            "ReStartService",
            "GetVehiclesByName",
            "GetVehiclesByNameStep2"});
            this.cmb_Type.Location = new System.Drawing.Point(77, 70);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(351, 20);
            this.cmb_Type.TabIndex = 1;
            // 
            // numeric_Timeout
            // 
            this.numeric_Timeout.Location = new System.Drawing.Point(77, 96);
            this.numeric_Timeout.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numeric_Timeout.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_Timeout.Name = "numeric_Timeout";
            this.numeric_Timeout.Size = new System.Drawing.Size(351, 21);
            this.numeric_Timeout.TabIndex = 3;
            this.numeric_Timeout.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "超时:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "操作类型:";
            // 
            // rtxt_Param
            // 
            this.rtxt_Param.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtxt_Param.Location = new System.Drawing.Point(77, 128);
            this.rtxt_Param.Name = "rtxt_Param";
            this.rtxt_Param.Size = new System.Drawing.Size(400, 419);
            this.rtxt_Param.TabIndex = 6;
            this.rtxt_Param.Text = "";
            this.rtxt_Param.Leave += new System.EventHandler(this.rtxt_Param_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "参数:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(496, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "连续调用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtxt_Result
            // 
            this.rtxt_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxt_Result.Location = new System.Drawing.Point(496, 45);
            this.rtxt_Result.Name = "rtxt_Result";
            this.rtxt_Result.Size = new System.Drawing.Size(400, 502);
            this.rtxt_Result.TabIndex = 8;
            this.rtxt_Result.Text = "";
            // 
            // cmb_Program
            // 
            this.cmb_Program.FormattingEnabled = true;
            this.cmb_Program.Items.AddRange(new object[] {
            "BiHu.BaoXian.Artificial.RB.JS.vshost",
            "BiHu.BaoXian.Artificial.RB.JS",
            "BiHu.BaoXian.Artificial.SuZhouZhuanDai.RB.vshost",
            "BiHu.BaoXian.Artificial.SuZhouZhuanDai.RB",
            "BiHu.BaoXian.Artificial.ShanDongCheShang.RB.vshost",
            "BiHu.BaoXian.Artificial.ShanDongCheShang.RB",
            "BiHu.BaoXian.Artificial.BeiJingCheShang.RB.vshost",
            "BiHu.BaoXian.Artificial.BeiJingCheShang.RB",
            "BiHu.BaoXian.Artificial.RB",
            "BiHu.BaoXian.Artificial.RB.vshost",
            "BiHu.BaoXian.Artificial.RB.TJ",
            "BiHu.BaoXian.Artificial.RB.TJ.vshost",
            "BiHu.BaoXian.Artificial.TPY",
            "BiHu.BaoXian.Artificial.TPY.vshost",
            "BiHu.BaoXian.Artificial.PA",
            "BiHu.BaoXian.Artificial.PA.vshost",
            "BiHu.BaoXian.Artificial.GSC",
            "BiHu.BaoXian.Artificial.GSC.vshost",
            "BiHu.BaoXian.Artificial.ZHLH",
            "BiHu.BaoXian.Artificial.ZHLH.vshost"});
            this.cmb_Program.Location = new System.Drawing.Point(77, 44);
            this.cmb_Program.Name = "cmb_Program";
            this.cmb_Program.Size = new System.Drawing.Size(351, 20);
            this.cmb_Program.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "执行程序:";
            // 
            // txt_stopkey
            // 
            this.txt_stopkey.Location = new System.Drawing.Point(496, 18);
            this.txt_stopkey.Name = "txt_stopkey";
            this.txt_stopkey.Size = new System.Drawing.Size(254, 21);
            this.txt_stopkey.TabIndex = 11;
            // 
            // lb_time
            // 
            this.lb_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_time.Location = new System.Drawing.Point(75, 581);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(78, 12);
            this.lb_time.TabIndex = 12;
            this.lb_time.Text = "耗时(毫秒):";
            // 
            // radio_local
            // 
            this.radio_local.AutoSize = true;
            this.radio_local.Checked = true;
            this.radio_local.Location = new System.Drawing.Point(77, 19);
            this.radio_local.Name = "radio_local";
            this.radio_local.Size = new System.Drawing.Size(71, 16);
            this.radio_local.TabIndex = 13;
            this.radio_local.TabStop = true;
            this.radio_local.Text = "本地调试";
            this.radio_local.UseVisualStyleBackColor = true;
            // 
            // radio_remote
            // 
            this.radio_remote.AutoSize = true;
            this.radio_remote.Location = new System.Drawing.Point(155, 19);
            this.radio_remote.Name = "radio_remote";
            this.radio_remote.Size = new System.Drawing.Size(71, 16);
            this.radio_remote.TabIndex = 14;
            this.radio_remote.Text = "远程模拟";
            this.radio_remote.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "调用方式:";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 623);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radio_remote);
            this.Controls.Add(this.radio_local);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.txt_stopkey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Program);
            this.Controls.Add(this.rtxt_Result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxt_Param);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_Timeout);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.btn_Excute);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "调用测试";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Timeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Excute;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.NumericUpDown numeric_Timeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxt_Param;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtxt_Result;
        private System.Windows.Forms.ComboBox cmb_Program;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stopkey;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.RadioButton radio_local;
        private System.Windows.Forms.RadioButton radio_remote;
        private System.Windows.Forms.Label label5;
    }
}