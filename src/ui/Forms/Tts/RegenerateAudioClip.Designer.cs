﻿namespace Nikse.SubtitleEdit.Forms.Tts
{
    sealed partial class RegenerateAudioClip
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReGenerate = new System.Windows.Forms.Button();
            this.labelVoice = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.nikseComboBoxVoice = new Nikse.SubtitleEdit.Controls.NikseComboBox();
            this.TextBoxReGenerate = new Nikse.SubtitleEdit.Controls.NikseTextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(730, 208);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 24);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "C&ancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReGenerate
            // 
            this.buttonReGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReGenerate.Location = new System.Drawing.Point(362, 208);
            this.buttonReGenerate.Name = "buttonReGenerate";
            this.buttonReGenerate.Size = new System.Drawing.Size(171, 24);
            this.buttonReGenerate.TabIndex = 21;
            this.buttonReGenerate.Text = "Regenerate ";
            this.buttonReGenerate.UseVisualStyleBackColor = true;
            this.buttonReGenerate.Click += new System.EventHandler(this.buttonReGenerate_Click);
            // 
            // labelVoice
            // 
            this.labelVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVoice.AutoSize = true;
            this.labelVoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVoice.Location = new System.Drawing.Point(38, 213);
            this.labelVoice.Name = "labelVoice";
            this.labelVoice.Size = new System.Drawing.Size(34, 13);
            this.labelVoice.TabIndex = 24;
            this.labelVoice.Text = "Voice";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(13, 21);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 25;
            this.labelText.Text = "Text";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(640, 208);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(84, 24);
            this.buttonOK.TabIndex = 26;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPlay.Location = new System.Drawing.Point(539, 208);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(95, 24);
            this.buttonPlay.TabIndex = 27;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // nikseComboBoxVoice
            // 
            this.nikseComboBoxVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nikseComboBoxVoice.BackColor = System.Drawing.SystemColors.Window;
            this.nikseComboBoxVoice.BackColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nikseComboBoxVoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.nikseComboBoxVoice.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.nikseComboBoxVoice.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.nikseComboBoxVoice.ButtonForeColorDown = System.Drawing.Color.Orange;
            this.nikseComboBoxVoice.ButtonForeColorOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.nikseComboBoxVoice.DropDownHeight = 400;
            this.nikseComboBoxVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nikseComboBoxVoice.DropDownWidth = 0;
            this.nikseComboBoxVoice.FormattingEnabled = false;
            this.nikseComboBoxVoice.Location = new System.Drawing.Point(78, 208);
            this.nikseComboBoxVoice.MaxLength = 32767;
            this.nikseComboBoxVoice.Name = "nikseComboBoxVoice";
            this.nikseComboBoxVoice.SelectedIndex = -1;
            this.nikseComboBoxVoice.SelectedItem = null;
            this.nikseComboBoxVoice.SelectedText = "";
            this.nikseComboBoxVoice.Size = new System.Drawing.Size(278, 23);
            this.nikseComboBoxVoice.TabIndex = 23;
            this.nikseComboBoxVoice.UsePopupWindow = false;
            // 
            // TextBoxReGenerate
            // 
            this.TextBoxReGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxReGenerate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.TextBoxReGenerate.Location = new System.Drawing.Point(12, 40);
            this.TextBoxReGenerate.Multiline = true;
            this.TextBoxReGenerate.Name = "TextBoxReGenerate";
            this.TextBoxReGenerate.Size = new System.Drawing.Size(802, 162);
            this.TextBoxReGenerate.TabIndex = 22;
            // 
            // RegenerateAudioClip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 243);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelVoice);
            this.Controls.Add(this.nikseComboBoxVoice);
            this.Controls.Add(this.TextBoxReGenerate);
            this.Controls.Add(this.buttonReGenerate);
            this.Controls.Add(this.buttonCancel);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "RegenerateAudioClip";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Regenerate audio clip";
            this.Shown += new System.EventHandler(this.RegenerateAudioClip_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private Controls.NikseTextBox TextBoxReGenerate;
        private System.Windows.Forms.Button buttonReGenerate;
        private System.Windows.Forms.Label labelVoice;
        private Controls.NikseComboBox nikseComboBoxVoice;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonPlay;
    }
}