namespace lab_1
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
            label1 = new Label();
            labelshow = new Label();
            spanich_btm = new Button();
            Italy_btm = new Button();
            French_btm = new Button();
            Germany_btm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("ACS  Yaqout Extra Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.Location = new Point(118, 83);
            label1.Name = "label1";
            label1.Size = new Size(594, 110);
            label1.TabIndex = 0;
            label1.Text = "Select a language and I will say Good Morning.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // labelshow
            // 
            labelshow.BorderStyle = BorderStyle.FixedSingle;
            labelshow.Location = new Point(150, 184);
            labelshow.Name = "labelshow";
            labelshow.Size = new Size(509, 41);
            labelshow.TabIndex = 1;
            labelshow.TextAlign = ContentAlignment.MiddleCenter;
            labelshow.Click += label2_Click;
            // 
            // spanich_btm
            // 
            spanich_btm.Location = new Point(89, 282);
            spanich_btm.Name = "spanich_btm";
            spanich_btm.Size = new Size(153, 55);
            spanich_btm.TabIndex = 2;
            spanich_btm.Text = "Spanish ";
            spanich_btm.UseVisualStyleBackColor = true;
            spanich_btm.Click += button1_Click;
            // 
            // Italy_btm
            // 
            Italy_btm.Location = new Point(266, 282);
            Italy_btm.Name = "Italy_btm";
            Italy_btm.Size = new Size(153, 55);
            Italy_btm.TabIndex = 3;
            Italy_btm.Text = "Italian";
            Italy_btm.UseVisualStyleBackColor = true;
            Italy_btm.Click += button1_Click_1;
            // 
            // French_btm
            // 
            French_btm.Location = new Point(444, 282);
            French_btm.Name = "French_btm";
            French_btm.Size = new Size(153, 55);
            French_btm.TabIndex = 6;
            French_btm.TabStop = false;
            French_btm.Text = "French";
            French_btm.UseVisualStyleBackColor = true;
            French_btm.Click += French_btm_Click;
            // 
            // Germany_btm
            // 
            Germany_btm.Location = new Point(620, 282);
            Germany_btm.Name = "Germany_btm";
            Germany_btm.Size = new Size(153, 55);
            Germany_btm.TabIndex = 7;
            Germany_btm.TabStop = false;
            Germany_btm.Text = "Germany";
            Germany_btm.UseVisualStyleBackColor = true;
            Germany_btm.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(840, 443);
            Controls.Add(Germany_btm);
            Controls.Add(French_btm);
            Controls.Add(Italy_btm);
            Controls.Add(spanich_btm);
            Controls.Add(labelshow);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Language Translator ";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label labelshow;
        private Button spanich_btm;
        private Button Italy_btm;
        private Button French_btm;
        private Button Germany_btm;
    }
}
