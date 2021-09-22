
namespace FidelityFX_Assist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textPrefix = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.prefixOutput = new System.Windows.Forms.TextBox();
            this.startingNum = new System.Windows.Forms.NumericUpDown();
            this.endingNum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.extensionInputText = new System.Windows.Forms.TextBox();
            this.outTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.scaleWidth = new System.Windows.Forms.TextBox();
            this.scaleHeight = new System.Windows.Forms.TextBox();
            this.scaleCheckBox = new System.Windows.Forms.CheckBox();
            this.qualitymodeCheckBox = new System.Windows.Forms.CheckBox();
            this.qualitymodeText = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.scaleHelpBTN = new System.Windows.Forms.Button();
            this.qualityHelpBTN = new System.Windows.Forms.Button();
            this.modeCheckBox = new System.Windows.Forms.CheckBox();
            this.modeText = new System.Windows.Forms.TextBox();
            this.modeHelpBTN = new System.Windows.Forms.Button();
            this.sharpnessCheckBox = new System.Windows.Forms.CheckBox();
            this.sharpnessText = new System.Windows.Forms.TextBox();
            this.sharpnessHelpBTN = new System.Windows.Forms.Button();
            this.fp16CheckBox = new System.Windows.Forms.CheckBox();
            this.linearCheckBox = new System.Windows.Forms.CheckBox();
            this.flHelpBTN = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ffxLinkBTN = new System.Windows.Forms.Button();
            this.filePathText = new System.Windows.Forms.TextBox();
            this.browseBTN = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startingNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingNum)).BeginInit();
            this.SuspendLayout();
            // 
            // textPrefix
            // 
            this.textPrefix.Location = new System.Drawing.Point(17, 43);
            this.textPrefix.Name = "textPrefix";
            this.textPrefix.Size = new System.Drawing.Size(100, 20);
            this.textPrefix.TabIndex = 0;
            this.textPrefix.Text = "pic";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(14, 23);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(35, 14);
            this.lblPrefix.TabIndex = 1;
            this.lblPrefix.Text = "Prefix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "Starting Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ending Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 14);
            this.label9.TabIndex = 7;
            this.label9.Text = "Output Prefix";
            // 
            // prefixOutput
            // 
            this.prefixOutput.Location = new System.Drawing.Point(438, 44);
            this.prefixOutput.Name = "prefixOutput";
            this.prefixOutput.Size = new System.Drawing.Size(100, 20);
            this.prefixOutput.TabIndex = 4;
            this.prefixOutput.Text = "out";
            // 
            // startingNum
            // 
            this.startingNum.Location = new System.Drawing.Point(143, 44);
            this.startingNum.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
            this.startingNum.Name = "startingNum";
            this.startingNum.Size = new System.Drawing.Size(120, 20);
            this.startingNum.TabIndex = 2;
            // 
            // endingNum
            // 
            this.endingNum.Location = new System.Drawing.Point(286, 45);
            this.endingNum.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
            this.endingNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endingNum.Name = "endingNum";
            this.endingNum.Size = new System.Drawing.Size(120, 20);
            this.endingNum.TabIndex = 3;
            this.endingNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(556, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "Input Extension";
            // 
            // extensionInputText
            // 
            this.extensionInputText.Location = new System.Drawing.Point(555, 44);
            this.extensionInputText.Name = "extensionInputText";
            this.extensionInputText.Size = new System.Drawing.Size(100, 20);
            this.extensionInputText.TabIndex = 5;
            this.extensionInputText.Text = ".png";
            // 
            // outTextBox
            // 
            this.outTextBox.Location = new System.Drawing.Point(16, 393);
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.Size = new System.Drawing.Size(636, 20);
            this.outTextBox.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 14);
            this.label11.TabIndex = 14;
            this.label11.Text = "Output Text";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Generate CLI Input";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(198, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 14);
            this.label12.TabIndex = 18;
            this.label12.Text = "Scale Width";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(338, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 14);
            this.label13.TabIndex = 19;
            this.label13.Text = "Scale Height";
            // 
            // scaleWidth
            // 
            this.scaleWidth.Location = new System.Drawing.Point(182, 155);
            this.scaleWidth.Name = "scaleWidth";
            this.scaleWidth.Size = new System.Drawing.Size(100, 20);
            this.scaleWidth.TabIndex = 7;
            // 
            // scaleHeight
            // 
            this.scaleHeight.Location = new System.Drawing.Point(326, 155);
            this.scaleHeight.Name = "scaleHeight";
            this.scaleHeight.Size = new System.Drawing.Size(100, 20);
            this.scaleHeight.TabIndex = 8;
            // 
            // scaleCheckBox
            // 
            this.scaleCheckBox.AutoSize = true;
            this.scaleCheckBox.Location = new System.Drawing.Point(29, 155);
            this.scaleCheckBox.Name = "scaleCheckBox";
            this.scaleCheckBox.Size = new System.Drawing.Size(53, 18);
            this.scaleCheckBox.TabIndex = 6;
            this.scaleCheckBox.Text = "Scale";
            this.scaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // qualitymodeCheckBox
            // 
            this.qualitymodeCheckBox.AutoSize = true;
            this.qualitymodeCheckBox.Location = new System.Drawing.Point(29, 200);
            this.qualitymodeCheckBox.Name = "qualitymodeCheckBox";
            this.qualitymodeCheckBox.Size = new System.Drawing.Size(88, 18);
            this.qualitymodeCheckBox.TabIndex = 9;
            this.qualitymodeCheckBox.Text = "Quality Mode";
            this.qualitymodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // qualitymodeText
            // 
            this.qualitymodeText.Location = new System.Drawing.Point(182, 200);
            this.qualitymodeText.Name = "qualitymodeText";
            this.qualitymodeText.Size = new System.Drawing.Size(100, 20);
            this.qualitymodeText.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 439);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Execute FFX";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // scaleHelpBTN
            // 
            this.scaleHelpBTN.Location = new System.Drawing.Point(442, 153);
            this.scaleHelpBTN.Name = "scaleHelpBTN";
            this.scaleHelpBTN.Size = new System.Drawing.Size(21, 23);
            this.scaleHelpBTN.TabIndex = 19;
            this.scaleHelpBTN.Text = "?";
            this.scaleHelpBTN.UseVisualStyleBackColor = true;
            this.scaleHelpBTN.Click += new System.EventHandler(this.scaleHelpBTN_Click);
            // 
            // qualityHelpBTN
            // 
            this.qualityHelpBTN.Location = new System.Drawing.Point(442, 198);
            this.qualityHelpBTN.Name = "qualityHelpBTN";
            this.qualityHelpBTN.Size = new System.Drawing.Size(21, 23);
            this.qualityHelpBTN.TabIndex = 20;
            this.qualityHelpBTN.Text = "?";
            this.qualityHelpBTN.UseVisualStyleBackColor = true;
            this.qualityHelpBTN.Click += new System.EventHandler(this.qualityHelpBTN_Click);
            // 
            // modeCheckBox
            // 
            this.modeCheckBox.AutoSize = true;
            this.modeCheckBox.Location = new System.Drawing.Point(29, 244);
            this.modeCheckBox.Name = "modeCheckBox";
            this.modeCheckBox.Size = new System.Drawing.Size(52, 18);
            this.modeCheckBox.TabIndex = 11;
            this.modeCheckBox.Text = "Mode";
            this.modeCheckBox.UseVisualStyleBackColor = true;
            // 
            // modeText
            // 
            this.modeText.Location = new System.Drawing.Point(182, 244);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(100, 20);
            this.modeText.TabIndex = 12;
            // 
            // modeHelpBTN
            // 
            this.modeHelpBTN.Location = new System.Drawing.Point(442, 242);
            this.modeHelpBTN.Name = "modeHelpBTN";
            this.modeHelpBTN.Size = new System.Drawing.Size(21, 23);
            this.modeHelpBTN.TabIndex = 21;
            this.modeHelpBTN.Text = "?";
            this.modeHelpBTN.UseVisualStyleBackColor = true;
            this.modeHelpBTN.Click += new System.EventHandler(this.modeHelpBTN_Click);
            // 
            // sharpnessCheckBox
            // 
            this.sharpnessCheckBox.AutoSize = true;
            this.sharpnessCheckBox.Location = new System.Drawing.Point(29, 289);
            this.sharpnessCheckBox.Name = "sharpnessCheckBox";
            this.sharpnessCheckBox.Size = new System.Drawing.Size(79, 18);
            this.sharpnessCheckBox.TabIndex = 13;
            this.sharpnessCheckBox.Text = "Sharpness";
            this.sharpnessCheckBox.UseVisualStyleBackColor = true;
            // 
            // sharpnessText
            // 
            this.sharpnessText.Location = new System.Drawing.Point(182, 289);
            this.sharpnessText.Name = "sharpnessText";
            this.sharpnessText.Size = new System.Drawing.Size(100, 20);
            this.sharpnessText.TabIndex = 14;
            // 
            // sharpnessHelpBTN
            // 
            this.sharpnessHelpBTN.Location = new System.Drawing.Point(442, 285);
            this.sharpnessHelpBTN.Name = "sharpnessHelpBTN";
            this.sharpnessHelpBTN.Size = new System.Drawing.Size(21, 23);
            this.sharpnessHelpBTN.TabIndex = 22;
            this.sharpnessHelpBTN.Text = "?";
            this.sharpnessHelpBTN.UseVisualStyleBackColor = true;
            this.sharpnessHelpBTN.Click += new System.EventHandler(this.sharpnessHelpBTN_Click);
            // 
            // fp16CheckBox
            // 
            this.fp16CheckBox.AutoSize = true;
            this.fp16CheckBox.Location = new System.Drawing.Point(29, 331);
            this.fp16CheckBox.Name = "fp16CheckBox";
            this.fp16CheckBox.Size = new System.Drawing.Size(50, 18);
            this.fp16CheckBox.TabIndex = 27;
            this.fp16CheckBox.Text = "FP16";
            this.fp16CheckBox.UseVisualStyleBackColor = true;
            // 
            // linearCheckBox
            // 
            this.linearCheckBox.AutoSize = true;
            this.linearCheckBox.Location = new System.Drawing.Point(182, 331);
            this.linearCheckBox.Name = "linearCheckBox";
            this.linearCheckBox.Size = new System.Drawing.Size(56, 18);
            this.linearCheckBox.TabIndex = 28;
            this.linearCheckBox.Text = "Linear";
            this.linearCheckBox.UseVisualStyleBackColor = true;
            // 
            // flHelpBTN
            // 
            this.flHelpBTN.Location = new System.Drawing.Point(442, 327);
            this.flHelpBTN.Name = "flHelpBTN";
            this.flHelpBTN.Size = new System.Drawing.Size(21, 23);
            this.flHelpBTN.TabIndex = 29;
            this.flHelpBTN.Text = "?";
            this.flHelpBTN.UseVisualStyleBackColor = true;
            this.flHelpBTN.Click += new System.EventHandler(this.flHelpBTN_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(35, 352);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "You can select either FP16 or Linear";
            // 
            // ffxLinkBTN
            // 
            this.ffxLinkBTN.Location = new System.Drawing.Point(261, 439);
            this.ffxLinkBTN.Name = "ffxLinkBTN";
            this.ffxLinkBTN.Size = new System.Drawing.Size(75, 23);
            this.ffxLinkBTN.TabIndex = 31;
            this.ffxLinkBTN.Text = "FFX Github";
            this.ffxLinkBTN.UseVisualStyleBackColor = true;
            this.ffxLinkBTN.Click += new System.EventHandler(this.ffxLinkBTN_Click);
            // 
            // filePathText
            // 
            this.filePathText.Location = new System.Drawing.Point(17, 98);
            this.filePathText.Name = "filePathText";
            this.filePathText.Size = new System.Drawing.Size(521, 20);
            this.filePathText.TabIndex = 32;
            this.filePathText.Text = "C:\\Program Files (x86)";
            // 
            // browseBTN
            // 
            this.browseBTN.Location = new System.Drawing.Point(555, 97);
            this.browseBTN.Name = "browseBTN";
            this.browseBTN.Size = new System.Drawing.Size(100, 23);
            this.browseBTN.TabIndex = 33;
            this.browseBTN.Text = "Browse";
            this.browseBTN.UseVisualStyleBackColor = true;
            this.browseBTN.Click += new System.EventHandler(this.browseBTN_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 14);
            this.label16.TabIndex = 34;
            this.label16.Text = "FidelityFX Directory";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 476);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.browseBTN);
            this.Controls.Add(this.filePathText);
            this.Controls.Add(this.ffxLinkBTN);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.flHelpBTN);
            this.Controls.Add(this.linearCheckBox);
            this.Controls.Add(this.fp16CheckBox);
            this.Controls.Add(this.sharpnessHelpBTN);
            this.Controls.Add(this.sharpnessText);
            this.Controls.Add(this.sharpnessCheckBox);
            this.Controls.Add(this.modeHelpBTN);
            this.Controls.Add(this.modeText);
            this.Controls.Add(this.modeCheckBox);
            this.Controls.Add(this.qualityHelpBTN);
            this.Controls.Add(this.scaleHelpBTN);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.qualitymodeText);
            this.Controls.Add(this.qualitymodeCheckBox);
            this.Controls.Add(this.scaleCheckBox);
            this.Controls.Add(this.scaleHeight);
            this.Controls.Add(this.scaleWidth);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.outTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.extensionInputText);
            this.Controls.Add(this.endingNum);
            this.Controls.Add(this.startingNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.prefixOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.textPrefix);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FidelityFX Assist";
            ((System.ComponentModel.ISupportInitialize)(this.startingNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prefixText;
        private System.Windows.Forms.Button folderBrowse;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startingNoText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox endingNoText;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outputPrefixText;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.TextBox textPrefix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox prefixOutput;
        private System.Windows.Forms.NumericUpDown startingNum;
        private System.Windows.Forms.NumericUpDown endingNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox extensionInputText;
        private System.Windows.Forms.TextBox outTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox scaleWidth;
        private System.Windows.Forms.TextBox scaleHeight;
        private System.Windows.Forms.CheckBox scaleCheckBox;
        private System.Windows.Forms.CheckBox qualitymodeCheckBox;
        private System.Windows.Forms.TextBox qualitymodeText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button scaleHelpBTN;
        private System.Windows.Forms.Button qualityHelpBTN;
        private System.Windows.Forms.CheckBox modeCheckBox;
        private System.Windows.Forms.TextBox modeText;
        private System.Windows.Forms.Button modeHelpBTN;
        private System.Windows.Forms.CheckBox sharpnessCheckBox;
        private System.Windows.Forms.TextBox sharpnessText;
        private System.Windows.Forms.Button sharpnessHelpBTN;
        private System.Windows.Forms.CheckBox fp16CheckBox;
        private System.Windows.Forms.CheckBox linearCheckBox;
        private System.Windows.Forms.Button flHelpBTN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ffxLinkBTN;
        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.Button browseBTN;
        private System.Windows.Forms.Label label16;
    }
}

