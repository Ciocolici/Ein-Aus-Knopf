namespace EinAusKnopf
{
    partial class Knopf
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            klickButton = new Button();
            zustandLabel = new Label();
            codewortText = new TextBox();
            SuspendLayout();
            // 
            // klickButton
            // 
            klickButton.BackColor = SystemColors.ControlLight;
            klickButton.Cursor = Cursors.Cross;
            klickButton.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            klickButton.Location = new Point(48, 138);
            klickButton.Name = "klickButton";
            klickButton.Size = new Size(120, 44);
            klickButton.TabIndex = 0;
            klickButton.Text = "KLICK";
            klickButton.UseVisualStyleBackColor = true;
            klickButton.Click += klickButtonClick;
            // 
            // zustandLabel
            // 
            zustandLabel.AutoSize = true;
            zustandLabel.Font = new Font("Mistral", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            zustandLabel.Location = new Point(74, 24);
            zustandLabel.Name = "zustandLabel";
            zustandLabel.Size = new Size(66, 42);
            zustandLabel.TabIndex = 1;
            zustandLabel.Text = "AUS";
            // 
            // codewortText
            // 
            codewortText.BackColor = SystemColors.Window;
            codewortText.Location = new Point(57, 85);
            codewortText.Name = "codewortText";
            codewortText.Size = new Size(100, 23);
            codewortText.TabIndex = 2;
            // 
            // Knopf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(219, 215);
            Controls.Add(codewortText);
            Controls.Add(zustandLabel);
            Controls.Add(klickButton);
            Name = "Knopf";
            Text = "Knopf";
            FormClosing += kreuzClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button klickButton;
        private Label zustandLabel;
        private TextBox codewortText;
    }
}