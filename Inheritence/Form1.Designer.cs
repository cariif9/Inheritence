namespace Inheritence
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
            this.PersnInfoBtn = new System.Windows.Forms.Button();
            this.FulInfoBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersnInfoBtn
            // 
            this.PersnInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersnInfoBtn.Location = new System.Drawing.Point(30, 73);
            this.PersnInfoBtn.Name = "PersnInfoBtn";
            this.PersnInfoBtn.Size = new System.Drawing.Size(213, 49);
            this.PersnInfoBtn.TabIndex = 0;
            this.PersnInfoBtn.Text = "AoutoMobile";
            this.PersnInfoBtn.UseVisualStyleBackColor = true;
            this.PersnInfoBtn.Click += new System.EventHandler(this.PersnInfoBtn_Click);
            // 
            // FulInfoBtn
            // 
            this.FulInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FulInfoBtn.Location = new System.Drawing.Point(554, 76);
            this.FulInfoBtn.Name = "FulInfoBtn";
            this.FulInfoBtn.Size = new System.Drawing.Size(144, 46);
            this.FulInfoBtn.TabIndex = 1;
            this.FulInfoBtn.Text = "Car";
            this.FulInfoBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FulInfoBtn);
            this.Controls.Add(this.PersnInfoBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PersnInfoBtn;
        private System.Windows.Forms.Button FulInfoBtn;
        private System.Windows.Forms.Button button3;
    }
}

