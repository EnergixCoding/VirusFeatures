
namespace VirusFeatures
{
    partial class MalwareFeatures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalwareFeatures));
            this.uncloseableForm = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hideInTaskBar = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.SuspendLayout();
            // 
            // uncloseableForm
            // 
            this.uncloseableForm.BackColor = System.Drawing.Color.Transparent;
            this.uncloseableForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uncloseableForm.BackgroundImage")));
            this.uncloseableForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uncloseableForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uncloseableForm.Location = new System.Drawing.Point(120, 69);
            this.uncloseableForm.Name = "uncloseableForm";
            this.uncloseableForm.OffColor = System.Drawing.Color.Gray;
            this.uncloseableForm.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.uncloseableForm.Size = new System.Drawing.Size(35, 20);
            this.uncloseableForm.TabIndex = 0;
            this.uncloseableForm.Value = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unclosable Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hide In TaskBar";
            // 
            // hideInTaskBar
            // 
            this.hideInTaskBar.BackColor = System.Drawing.Color.Transparent;
            this.hideInTaskBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hideInTaskBar.BackgroundImage")));
            this.hideInTaskBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideInTaskBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideInTaskBar.Location = new System.Drawing.Point(120, 119);
            this.hideInTaskBar.Name = "hideInTaskBar";
            this.hideInTaskBar.OffColor = System.Drawing.Color.Gray;
            this.hideInTaskBar.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.hideInTaskBar.Size = new System.Drawing.Size(35, 20);
            this.hideInTaskBar.TabIndex = 3;
            this.hideInTaskBar.Value = false;
            this.hideInTaskBar.OnValueChange += new System.EventHandler(this.hideInTaskBar_OnValueChange);
            // 
            // MalwareFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 337);
            this.Controls.Add(this.hideInTaskBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uncloseableForm);
            this.Name = "MalwareFeatures";
            this.Text = "Malware Features v1.0 - By EnergixCoding";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MalwareFeatures_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MalwareFeatures_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuiOSSwitch uncloseableForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuiOSSwitch hideInTaskBar;
    }
}

