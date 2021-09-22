using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace FidelityFX_Assist
{
    public partial class Form1 : Form     
    {
        string resultingText;
        string args;

        public Form1()
        {
            InitializeComponent();

            //Setting default execution directory
            filePathText.Text = Directory.GetCurrentDirectory();
        }

        //Generating the range of images and assembling it as needed on FFX-CLI
        private void GetImageSec()
        {
            string inputPrefix = textPrefix.Text;
            string outputPrefix = prefixOutput.Text;
            int startingNumberInt = (int)startingNum.Value;
            int endingNumberInt = (int)endingNum.Value;


            int i = startingNumberInt;
            resultingText = "";

            while (i <= endingNumberInt)
            {
                resultingText = resultingText + inputPrefix + i + extensionInputText.Text + " " + outputPrefix + i + extensionInputText.Text + " ";
                i++;
            }
        }

        //Copy button
        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outTextBox.Text);
        }

        //Generate CLI Input button
        private void button3_Click(object sender, EventArgs e)
        {
            string options = "";
            if (scaleCheckBox.Checked)
            {
                options = "-Scale " + scaleHeight.Text + " " + scaleWidth.Text + " ";
            }
            if (qualitymodeCheckBox.Checked)
            {
                options = options + "-QualityMode " + qualitymodeText.Text + " ";
            }
            if (modeCheckBox.Checked)
            {
                options = options + "-Mode " + modeText.Text + " ";
            }
            if (sharpnessCheckBox.Checked)
            {
                options = options + "-Sharpness " + sharpnessText.Text + " ";
            }
            if (fp16CheckBox.Checked)
            {
                options = options + "-FP16 ";
            }
            if (linearCheckBox.Checked)
            {
                options = options + "-Linear ";
            }

            GetImageSec();

            args = "FidelityFX_CLI.exe " + options + resultingText;

            outTextBox.Text = args;

        }

        //Execute FFX button
        private void button4_Click(object sender, EventArgs e)
        {
            button3_Click(null, null); //Too lazy to separate it.

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WorkingDirectory = filePathText.Text;
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = "/k " + args;
            Process.Start(ps);
        }

        //General tooltip
        private void ShowToolTip(object sender, string message)
        {
            new ToolTip().Show(message, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 2000);
        }

        //Scale Tooltip
        private void scaleHelpBTN_Click(object sender, EventArgs e)
        {
            ShowToolTip(sender, "Width, Height can be:\nNumber: -Scale 3840 2160\nScale factor: -Scale 2x 2x\nPercent: -Scale 150 % 150 % ");
        }

        //Quality Tooltip
        private void qualityHelpBTN_Click(object sender, EventArgs e)
        {
            ShowToolTip(sender, "Specify instead of -Scale to use one of the predefined scaling factors.\nQuality can be: UltraQuality(1.3x), Quality(1.5x), Balanced(1.7x), Performance(2x)");
        }

        //Mode Tooltip
        private void modeHelpBTN_Click(object sender, EventArgs e)
        {
            ShowToolTip(sender, "Modes from FSR package:\nEASU - Edge Adaptive Spatial Upsampling(default) aliases: FSR, FSR1\nRCAS - Robust Contrast Adaptive Sharpening(doesn't support Scale)\nModes from CAS package:\nCAS - Contrast Adaptive Sharpening\nModes from Windows Imaging Component:\nNearestNeighbor, Linear, Cubic, HighQualityCubic, Fant");
        }

        //Sharpness Tooltip
        private void sharpnessHelpBTN_Click(object sender, EventArgs e)
        {
            ShowToolTip(sender, "-Mode CAS: range from 0.0 (default) to 1.0 (maximum extra sharpness)\n- Mode RCAS: range from 0.0(maximum sharpness) to number of stops(halving) of the reduction of sharpness");
        }

        //FP16 and Linear Tooltip
        private void flHelpBTN_Click(object sender, EventArgs e)
        {
            ShowToolTip(sender, "-FP16\n  If not set(default), uses R8G8B8A8_UNORM GPU texture format.\n  If set, uses R16G16B16A16_FLOAT GPU texture format.\n- Linear\n  If not set(default), treats input and output image as sRGB.\n  If set, treats input and output image as linear.\n  Works only when - FP16 is not specified.");
        }

        //Button to FFX 
        private void ffxLinkBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GPUOpen-Effects/FidelityFX-CLI");
        }

        //Executing directory dialog
        private void browseBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                filePathText.Text = FBD.SelectedPath;
            }
        }

    }
}
