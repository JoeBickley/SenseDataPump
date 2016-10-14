namespace SenseDataPump
{
    partial class DataPump
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtLogpath = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerURL = new System.Windows.Forms.TextBox();
            this.chkProxy = new System.Windows.Forms.CheckBox();
            this.chkApps = new System.Windows.Forms.CheckBox();
            this.chkTasks = new System.Windows.Forms.CheckBox();
            this.chkUsers = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAttributes = new System.Windows.Forms.TextBox();
            this.txtNumApps = new System.Windows.Forms.TextBox();
            this.chkStreams = new System.Windows.Forms.CheckBox();
            this.chkTags = new System.Windows.Forms.CheckBox();
            this.chkCustomProps = new System.Windows.Forms.CheckBox();
            this.chkDataConnections = new System.Windows.Forms.CheckBox();
            this.chkLicenceRules = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumchains = new System.Windows.Forms.TextBox();
            this.txtnumusers = new System.Windows.Forms.TextBox();
            this.txtnumstreams = new System.Windows.Forms.TextBox();
            this.txtnumdataconns = new System.Windows.Forms.TextBox();
            this.txtnumtags = new System.Windows.Forms.TextBox();
            this.txtnumcustomprops = new System.Windows.Forms.TextBox();
            this.txtchainsize = new System.Windows.Forms.TextBox();
            this.txtnumlicencerules = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "DO ALL THE THINGS!";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLogpath
            // 
            this.txtLogpath.Location = new System.Drawing.Point(69, 32);
            this.txtLogpath.Name = "txtLogpath";
            this.txtLogpath.Size = new System.Drawing.Size(192, 20);
            this.txtLogpath.TabIndex = 1;
            this.txtLogpath.Text = "c:\\testresults.txt";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(11, 300);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(382, 108);
            this.txtStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Test App";
            // 
            // txtAppPath
            // 
            this.txtAppPath.Location = new System.Drawing.Point(290, 84);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(100, 20);
            this.txtAppPath.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "QRS URL";
            // 
            // txtServerURL
            // 
            this.txtServerURL.Location = new System.Drawing.Point(69, 7);
            this.txtServerURL.Name = "txtServerURL";
            this.txtServerURL.Size = new System.Drawing.Size(122, 20);
            this.txtServerURL.TabIndex = 11;
            this.txtServerURL.Text = "https://localhost";
            // 
            // chkProxy
            // 
            this.chkProxy.AutoSize = true;
            this.chkProxy.Location = new System.Drawing.Point(197, 9);
            this.chkProxy.Name = "chkProxy";
            this.chkProxy.Size = new System.Drawing.Size(74, 17);
            this.chkProxy.TabIndex = 13;
            this.chkProxy.Text = "Use Proxy";
            this.chkProxy.UseVisualStyleBackColor = true;
            // 
            // chkApps
            // 
            this.chkApps.AutoSize = true;
            this.chkApps.Location = new System.Drawing.Point(11, 87);
            this.chkApps.Name = "chkApps";
            this.chkApps.Size = new System.Drawing.Size(50, 17);
            this.chkApps.TabIndex = 14;
            this.chkApps.Text = "Apps";
            this.chkApps.UseVisualStyleBackColor = true;
            // 
            // chkTasks
            // 
            this.chkTasks.AutoSize = true;
            this.chkTasks.Location = new System.Drawing.Point(11, 110);
            this.chkTasks.Name = "chkTasks";
            this.chkTasks.Size = new System.Drawing.Size(85, 17);
            this.chkTasks.TabIndex = 15;
            this.chkTasks.Text = "Task Chains";
            this.chkTasks.UseVisualStyleBackColor = true;
            // 
            // chkUsers
            // 
            this.chkUsers.AutoSize = true;
            this.chkUsers.Location = new System.Drawing.Point(11, 133);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.Size = new System.Drawing.Size(56, 17);
            this.chkUsers.TabIndex = 16;
            this.chkUsers.Text = "Users ";
            this.chkUsers.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Attributes per user";
            // 
            // txtAttributes
            // 
            this.txtAttributes.Location = new System.Drawing.Point(290, 130);
            this.txtAttributes.Name = "txtAttributes";
            this.txtAttributes.Size = new System.Drawing.Size(100, 20);
            this.txtAttributes.TabIndex = 19;
            this.txtAttributes.Text = "100";
            // 
            // txtNumApps
            // 
            this.txtNumApps.Location = new System.Drawing.Point(128, 85);
            this.txtNumApps.Name = "txtNumApps";
            this.txtNumApps.Size = new System.Drawing.Size(40, 20);
            this.txtNumApps.TabIndex = 17;
            this.txtNumApps.Text = "100";
            // 
            // chkStreams
            // 
            this.chkStreams.AutoSize = true;
            this.chkStreams.Location = new System.Drawing.Point(11, 174);
            this.chkStreams.Name = "chkStreams";
            this.chkStreams.Size = new System.Drawing.Size(64, 17);
            this.chkStreams.TabIndex = 21;
            this.chkStreams.Text = "Streams";
            this.chkStreams.UseVisualStyleBackColor = true;
            // 
            // chkTags
            // 
            this.chkTags.AutoSize = true;
            this.chkTags.Location = new System.Drawing.Point(11, 195);
            this.chkTags.Name = "chkTags";
            this.chkTags.Size = new System.Drawing.Size(50, 17);
            this.chkTags.TabIndex = 22;
            this.chkTags.Text = "Tags";
            this.chkTags.UseVisualStyleBackColor = true;
            // 
            // chkCustomProps
            // 
            this.chkCustomProps.AutoSize = true;
            this.chkCustomProps.Location = new System.Drawing.Point(11, 218);
            this.chkCustomProps.Name = "chkCustomProps";
            this.chkCustomProps.Size = new System.Drawing.Size(111, 17);
            this.chkCustomProps.TabIndex = 23;
            this.chkCustomProps.Text = "Custom Properties";
            this.chkCustomProps.UseVisualStyleBackColor = true;
            // 
            // chkDataConnections
            // 
            this.chkDataConnections.AutoSize = true;
            this.chkDataConnections.Location = new System.Drawing.Point(11, 241);
            this.chkDataConnections.Name = "chkDataConnections";
            this.chkDataConnections.Size = new System.Drawing.Size(111, 17);
            this.chkDataConnections.TabIndex = 24;
            this.chkDataConnections.Text = "Data Connections";
            this.chkDataConnections.UseVisualStyleBackColor = true;
            // 
            // chkLicenceRules
            // 
            this.chkLicenceRules.AutoSize = true;
            this.chkLicenceRules.Location = new System.Drawing.Point(11, 264);
            this.chkLicenceRules.Name = "chkLicenceRules";
            this.chkLicenceRules.Size = new System.Drawing.Size(94, 17);
            this.chkLicenceRules.TabIndex = 25;
            this.chkLicenceRules.Text = "Licence Rules";
            this.chkLicenceRules.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(120, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 220);
            this.label5.TabIndex = 26;
            // 
            // txtnumchains
            // 
            this.txtnumchains.Location = new System.Drawing.Point(128, 107);
            this.txtnumchains.Name = "txtnumchains";
            this.txtnumchains.Size = new System.Drawing.Size(40, 20);
            this.txtnumchains.TabIndex = 27;
            this.txtnumchains.Text = "100";
            // 
            // txtnumusers
            // 
            this.txtnumusers.Location = new System.Drawing.Point(128, 130);
            this.txtnumusers.Name = "txtnumusers";
            this.txtnumusers.Size = new System.Drawing.Size(40, 20);
            this.txtnumusers.TabIndex = 28;
            this.txtnumusers.Text = "100";
            // 
            // txtnumstreams
            // 
            this.txtnumstreams.Location = new System.Drawing.Point(128, 172);
            this.txtnumstreams.Name = "txtnumstreams";
            this.txtnumstreams.Size = new System.Drawing.Size(40, 20);
            this.txtnumstreams.TabIndex = 29;
            this.txtnumstreams.Text = "100";
            // 
            // txtnumdataconns
            // 
            this.txtnumdataconns.Location = new System.Drawing.Point(128, 239);
            this.txtnumdataconns.Name = "txtnumdataconns";
            this.txtnumdataconns.Size = new System.Drawing.Size(40, 20);
            this.txtnumdataconns.TabIndex = 30;
            this.txtnumdataconns.Text = "100";
            // 
            // txtnumtags
            // 
            this.txtnumtags.Location = new System.Drawing.Point(128, 194);
            this.txtnumtags.Name = "txtnumtags";
            this.txtnumtags.Size = new System.Drawing.Size(40, 20);
            this.txtnumtags.TabIndex = 31;
            this.txtnumtags.Text = "100";
            // 
            // txtnumcustomprops
            // 
            this.txtnumcustomprops.Location = new System.Drawing.Point(128, 216);
            this.txtnumcustomprops.Name = "txtnumcustomprops";
            this.txtnumcustomprops.Size = new System.Drawing.Size(40, 20);
            this.txtnumcustomprops.TabIndex = 32;
            this.txtnumcustomprops.Text = "100";
            // 
            // txtchainsize
            // 
            this.txtchainsize.Location = new System.Drawing.Point(290, 107);
            this.txtchainsize.Name = "txtchainsize";
            this.txtchainsize.Size = new System.Drawing.Size(40, 20);
            this.txtchainsize.TabIndex = 33;
            this.txtchainsize.Text = "3";
            // 
            // txtnumlicencerules
            // 
            this.txtnumlicencerules.Location = new System.Drawing.Point(128, 262);
            this.txtnumlicencerules.Name = "txtnumlicencerules";
            this.txtnumlicencerules.Size = new System.Drawing.Size(40, 20);
            this.txtnumlicencerules.TabIndex = 34;
            this.txtnumlicencerules.Text = "100";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(177, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 220);
            this.label6.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Chain size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Other Settings";
            // 
            // DataPump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 419);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnumlicencerules);
            this.Controls.Add(this.txtchainsize);
            this.Controls.Add(this.txtnumcustomprops);
            this.Controls.Add(this.txtnumtags);
            this.Controls.Add(this.txtnumdataconns);
            this.Controls.Add(this.txtnumstreams);
            this.Controls.Add(this.txtnumusers);
            this.Controls.Add(this.txtnumchains);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkLicenceRules);
            this.Controls.Add(this.chkDataConnections);
            this.Controls.Add(this.chkCustomProps);
            this.Controls.Add(this.chkTags);
            this.Controls.Add(this.chkStreams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAttributes);
            this.Controls.Add(this.txtNumApps);
            this.Controls.Add(this.chkUsers);
            this.Controls.Add(this.chkTasks);
            this.Controls.Add(this.chkApps);
            this.Controls.Add(this.chkProxy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAppPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtLogpath);
            this.Controls.Add(this.button1);
            this.Name = "DataPump";
            this.Text = "DataPump";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLogpath;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAppPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerURL;
        private System.Windows.Forms.CheckBox chkProxy;
        private System.Windows.Forms.CheckBox chkApps;
        private System.Windows.Forms.CheckBox chkTasks;
        private System.Windows.Forms.CheckBox chkUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAttributes;
        private System.Windows.Forms.TextBox txtNumApps;
        private System.Windows.Forms.CheckBox chkStreams;
        private System.Windows.Forms.CheckBox chkTags;
        private System.Windows.Forms.CheckBox chkCustomProps;
        private System.Windows.Forms.CheckBox chkDataConnections;
        private System.Windows.Forms.CheckBox chkLicenceRules;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumchains;
        private System.Windows.Forms.TextBox txtnumusers;
        private System.Windows.Forms.TextBox txtnumstreams;
        private System.Windows.Forms.TextBox txtnumdataconns;
        private System.Windows.Forms.TextBox txtnumtags;
        private System.Windows.Forms.TextBox txtnumcustomprops;
        private System.Windows.Forms.TextBox txtchainsize;
        private System.Windows.Forms.TextBox txtnumlicencerules;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}