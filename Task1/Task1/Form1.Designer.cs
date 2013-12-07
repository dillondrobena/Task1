namespace Task1
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
            this.revTxtStr = new System.Windows.Forms.TextBox();
            this.swtDigX = new System.Windows.Forms.TextBox();
            this.fndNumStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.revTxtBtn = new System.Windows.Forms.Button();
            this.swtDigBtn = new System.Windows.Forms.Button();
            this.fndNumBtn = new System.Windows.Forms.Button();
            this.swtDigY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // revTxtStr
            // 
            this.revTxtStr.Location = new System.Drawing.Point(95, 61);
            this.revTxtStr.Name = "revTxtStr";
            this.revTxtStr.Size = new System.Drawing.Size(206, 22);
            this.revTxtStr.TabIndex = 0;
            // 
            // swtDigX
            // 
            this.swtDigX.Location = new System.Drawing.Point(129, 120);
            this.swtDigX.Name = "swtDigX";
            this.swtDigX.Size = new System.Drawing.Size(42, 22);
            this.swtDigX.TabIndex = 1;
            // 
            // fndNumStr
            // 
            this.fndNumStr.Location = new System.Drawing.Point(95, 181);
            this.fndNumStr.Name = "fndNumStr";
            this.fndNumStr.Size = new System.Drawing.Size(206, 22);
            this.fndNumStr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "2.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "3.";
            // 
            // revTxtBtn
            // 
            this.revTxtBtn.Location = new System.Drawing.Point(309, 62);
            this.revTxtBtn.Name = "revTxtBtn";
            this.revTxtBtn.Size = new System.Drawing.Size(73, 23);
            this.revTxtBtn.TabIndex = 6;
            this.revTxtBtn.Text = "Reverse";
            this.revTxtBtn.UseVisualStyleBackColor = true;
            this.revTxtBtn.Click += new System.EventHandler(this.revTxtBtn_Click);
            // 
            // swtDigBtn
            // 
            this.swtDigBtn.Location = new System.Drawing.Point(307, 123);
            this.swtDigBtn.Name = "swtDigBtn";
            this.swtDigBtn.Size = new System.Drawing.Size(75, 23);
            this.swtDigBtn.TabIndex = 7;
            this.swtDigBtn.Text = "Switch";
            this.swtDigBtn.UseVisualStyleBackColor = true;
            this.swtDigBtn.Click += new System.EventHandler(this.swtDigBtn_Click);
            // 
            // fndNumBtn
            // 
            this.fndNumBtn.Location = new System.Drawing.Point(307, 183);
            this.fndNumBtn.Name = "fndNumBtn";
            this.fndNumBtn.Size = new System.Drawing.Size(75, 23);
            this.fndNumBtn.TabIndex = 8;
            this.fndNumBtn.Text = "Find";
            this.fndNumBtn.UseVisualStyleBackColor = true;
            this.fndNumBtn.Click += new System.EventHandler(this.fndNumBtn_Click);
            // 
            // swtDigY
            // 
            this.swtDigY.Location = new System.Drawing.Point(259, 120);
            this.swtDigY.Name = "swtDigY";
            this.swtDigY.Size = new System.Drawing.Size(42, 22);
            this.swtDigY.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "X =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 255);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fndNumBtn);
            this.Controls.Add(this.swtDigBtn);
            this.Controls.Add(this.revTxtBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fndNumStr);
            this.Controls.Add(this.swtDigY);
            this.Controls.Add(this.swtDigX);
            this.Controls.Add(this.revTxtStr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox revTxtStr;
        private System.Windows.Forms.TextBox swtDigX;
        private System.Windows.Forms.TextBox fndNumStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button revTxtBtn;
        private System.Windows.Forms.Button swtDigBtn;
        private System.Windows.Forms.Button fndNumBtn;
        private System.Windows.Forms.TextBox swtDigY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

