namespace abcd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoa = new System.Windows.Forms.TextBox();
            this.txtsob = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ket qua";
            // 
            // txtsoa
            // 
            this.txtsoa.Location = new System.Drawing.Point(215, 54);
            this.txtsoa.Name = "txtsoa";
            this.txtsoa.Size = new System.Drawing.Size(100, 20);
            this.txtsoa.TabIndex = 3;
            // 
            // txtsob
            // 
            this.txtsob.Location = new System.Drawing.Point(215, 114);
            this.txtsob.Name = "txtsob";
            this.txtsob.Size = new System.Drawing.Size(100, 20);
            this.txtsob.TabIndex = 4;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(215, 173);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 113);
            this.button1.TabIndex = 6;
            this.button1.Text = " cộng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtsob);
            this.Controls.Add(this.txtsoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoa;
        private System.Windows.Forms.TextBox txtsob;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button button1;
    }
}

