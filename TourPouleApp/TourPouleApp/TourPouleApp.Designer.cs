namespace TourPouleApp
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneralInfo = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabTeams = new System.Windows.Forms.TabPage();
            this.tabLeaderboard = new System.Windows.Forms.TabPage();
            this.tabStage = new System.Windows.Forms.TabPage();
            this.dgvStageResult = new System.Windows.Forms.DataGridView();
            this.pbStageProfile = new System.Windows.Forms.PictureBox();
            this.pbStageMap = new System.Windows.Forms.PictureBox();
            this.lblStageInfo = new System.Windows.Forms.Label();
            this.cbStageSelector = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabGeneralInfo.SuspendLayout();
            this.tabStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStageResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStageProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStageMap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneralInfo);
            this.tabControl.Controls.Add(this.tabTeams);
            this.tabControl.Controls.Add(this.tabLeaderboard);
            this.tabControl.Controls.Add(this.tabStage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1343, 652);
            this.tabControl.TabIndex = 0;
            // 
            // tabGeneralInfo
            // 
            this.tabGeneralInfo.Controls.Add(this.textBox1);
            this.tabGeneralInfo.Location = new System.Drawing.Point(4, 22);
            this.tabGeneralInfo.Name = "tabGeneralInfo";
            this.tabGeneralInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralInfo.Size = new System.Drawing.Size(1119, 490);
            this.tabGeneralInfo.TabIndex = 0;
            this.tabGeneralInfo.Text = "General Info";
            this.tabGeneralInfo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(905, 418);
            this.textBox1.TabIndex = 0;
            // 
            // tabTeams
            // 
            this.tabTeams.Location = new System.Drawing.Point(4, 22);
            this.tabTeams.Name = "tabTeams";
            this.tabTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeams.Size = new System.Drawing.Size(1119, 490);
            this.tabTeams.TabIndex = 1;
            this.tabTeams.Text = "Teams";
            this.tabTeams.UseVisualStyleBackColor = true;
            // 
            // tabLeaderboard
            // 
            this.tabLeaderboard.Location = new System.Drawing.Point(4, 22);
            this.tabLeaderboard.Name = "tabLeaderboard";
            this.tabLeaderboard.Size = new System.Drawing.Size(1119, 490);
            this.tabLeaderboard.TabIndex = 2;
            this.tabLeaderboard.Text = "Leaderboard";
            this.tabLeaderboard.UseVisualStyleBackColor = true;
            // 
            // tabStage
            // 
            this.tabStage.Controls.Add(this.dgvStageResult);
            this.tabStage.Controls.Add(this.pbStageProfile);
            this.tabStage.Controls.Add(this.pbStageMap);
            this.tabStage.Controls.Add(this.lblStageInfo);
            this.tabStage.Controls.Add(this.cbStageSelector);
            this.tabStage.Location = new System.Drawing.Point(4, 22);
            this.tabStage.Name = "tabStage";
            this.tabStage.Size = new System.Drawing.Size(1335, 626);
            this.tabStage.TabIndex = 3;
            this.tabStage.Text = "Stages";
            this.tabStage.UseVisualStyleBackColor = true;
            // 
            // dgvStageResult
            // 
            this.dgvStageResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStageResult.Location = new System.Drawing.Point(9, 86);
            this.dgvStageResult.Name = "dgvStageResult";
            this.dgvStageResult.Size = new System.Drawing.Size(911, 534);
            this.dgvStageResult.TabIndex = 4;
            // 
            // pbStageProfile
            // 
            this.pbStageProfile.Location = new System.Drawing.Point(926, 320);
            this.pbStageProfile.Name = "pbStageProfile";
            this.pbStageProfile.Size = new System.Drawing.Size(400, 300);
            this.pbStageProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStageProfile.TabIndex = 3;
            this.pbStageProfile.TabStop = false;
            // 
            // pbStageMap
            // 
            this.pbStageMap.Location = new System.Drawing.Point(926, 14);
            this.pbStageMap.Name = "pbStageMap";
            this.pbStageMap.Size = new System.Drawing.Size(400, 300);
            this.pbStageMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStageMap.TabIndex = 2;
            this.pbStageMap.TabStop = false;
            // 
            // lblStageInfo
            // 
            this.lblStageInfo.AutoSize = true;
            this.lblStageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStageInfo.Location = new System.Drawing.Point(3, 37);
            this.lblStageInfo.Name = "lblStageInfo";
            this.lblStageInfo.Size = new System.Drawing.Size(653, 31);
            this.lblStageInfo.TabIndex = 1;
            this.lblStageInfo.Text = "Hier komt de stage info (start/finish city en aantal km)";
            // 
            // cbStageSelector
            // 
            this.cbStageSelector.FormattingEnabled = true;
            this.cbStageSelector.Items.AddRange(new object[] {
            "Stage 1",
            "Stage 2",
            "Stage 3",
            "Stage 4",
            "Stage 5",
            "Stage 6",
            "Stage 7",
            "Stage 8",
            "Stage 9",
            "Stage 10",
            "Stage 11",
            "Stage 12",
            "Stage 13",
            "Stage 14",
            "Stage 15",
            "Stage 16",
            "Stage 17",
            "Stage 18",
            "Stage 19",
            "Stage 20",
            "Stage 21"});
            this.cbStageSelector.Location = new System.Drawing.Point(9, 13);
            this.cbStageSelector.Name = "cbStageSelector";
            this.cbStageSelector.Size = new System.Drawing.Size(391, 21);
            this.cbStageSelector.TabIndex = 0;
            this.cbStageSelector.SelectedIndexChanged += new System.EventHandler(this.cbStageSelector_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 675);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "TourPouleApp";
            this.tabControl.ResumeLayout(false);
            this.tabGeneralInfo.ResumeLayout(false);
            this.tabGeneralInfo.PerformLayout();
            this.tabStage.ResumeLayout(false);
            this.tabStage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStageResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStageProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStageMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneralInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabTeams;
        private System.Windows.Forms.TabPage tabLeaderboard;
        private System.Windows.Forms.TabPage tabStage;
        private System.Windows.Forms.DataGridView dgvStageResult;
        private System.Windows.Forms.PictureBox pbStageProfile;
        private System.Windows.Forms.PictureBox pbStageMap;
        private System.Windows.Forms.Label lblStageInfo;
        private System.Windows.Forms.ComboBox cbStageSelector;
    }
}

