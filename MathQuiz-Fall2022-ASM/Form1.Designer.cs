namespace MathQuiz_Fall2022_ASM
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
            this.components = new System.ComponentModel.Container();
            this.label_name = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.Location = new System.Drawing.Point(307, 65);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(320, 50);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Your Name";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(310, 159);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(200, 25);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Timer timer1;
    }
}

