namespace Event
{
    partial class Form1
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
            labelResult = new Label();
            textBoxInput = new TextBox();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelResult.AutoSize = true;
            labelResult.Location = new Point(45, 41);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(85, 15);
            labelResult.TabIndex = 0;
            labelResult.Text = "Enter Your Text";
            labelResult.Click += label1_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInput.BackColor = Color.FromArgb(255, 128, 255);
            textBoxInput.Location = new Point(45, 91);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(430, 23);
            textBoxInput.TabIndex = 1;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSubmit.BackColor = Color.FromArgb(255, 128, 255);
            buttonSubmit.Enabled = false;
            buttonSubmit.Location = new Point(45, 272);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(207, 33);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Click Me !";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(769, 450);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxInput);
            Controls.Add(labelResult);
            Name = "Form1";
            Text = "G";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResult;
        private TextBox textBoxInput;
        private Button buttonSubmit;
    }
}
