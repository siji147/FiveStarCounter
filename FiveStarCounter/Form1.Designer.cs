namespace FiveStarCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOneStar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTwoStar = new System.Windows.Forms.TextBox();
            this.txtThreeStar = new System.Windows.Forms.TextBox();
            this.txtFourStar = new System.Windows.Forms.TextBox();
            this.txtFiveStar = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of 1*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOneStar
            // 
            this.txtOneStar.Location = new System.Drawing.Point(315, 145);
            this.txtOneStar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOneStar.Name = "txtOneStar";
            this.txtOneStar.Size = new System.Drawing.Size(265, 38);
            this.txtOneStar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of 2*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of 3*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of 4*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of 5*";
            // 
            // txtTwoStar
            // 
            this.txtTwoStar.Location = new System.Drawing.Point(315, 211);
            this.txtTwoStar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTwoStar.Name = "txtTwoStar";
            this.txtTwoStar.Size = new System.Drawing.Size(265, 38);
            this.txtTwoStar.TabIndex = 6;
            // 
            // txtThreeStar
            // 
            this.txtThreeStar.Location = new System.Drawing.Point(315, 283);
            this.txtThreeStar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThreeStar.Name = "txtThreeStar";
            this.txtThreeStar.Size = new System.Drawing.Size(265, 38);
            this.txtThreeStar.TabIndex = 7;
            // 
            // txtFourStar
            // 
            this.txtFourStar.Location = new System.Drawing.Point(315, 345);
            this.txtFourStar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFourStar.Name = "txtFourStar";
            this.txtFourStar.Size = new System.Drawing.Size(265, 38);
            this.txtFourStar.TabIndex = 8;
            // 
            // txtFiveStar
            // 
            this.txtFiveStar.Location = new System.Drawing.Point(316, 421);
            this.txtFiveStar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiveStar.Name = "txtFiveStar";
            this.txtFiveStar.Size = new System.Drawing.Size(265, 38);
            this.txtFiveStar.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(216, 616);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(253, 108);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Target";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(315, 529);
            this.txtTarget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(265, 38);
            this.txtTarget.TabIndex = 12;
            this.txtTarget.Text = "4.5";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Green;
            this.lblResult.Location = new System.Drawing.Point(273, 866);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(196, 104);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 790);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(512, 39);
            this.label7.TabIndex = 14;
            this.label7.Text = "Five stars needed to meet target:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(207, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 78);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(12, 989);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(0, 32);
            this.lblCopyright.TabIndex = 16;
            this.lblCopyright.Click += new System.EventHandler(this.lblCopyright_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 1030);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFiveStar);
            this.Controls.Add(this.txtFourStar);
            this.Controls.Add(this.txtThreeStar);
            this.Controls.Add(this.txtTwoStar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOneStar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(760, 1118);
            this.MinimumSize = new System.Drawing.Size(760, 1118);
            this.Name = "Form1";
            this.Text = "Five Star Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOneStar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTwoStar;
        private System.Windows.Forms.TextBox txtThreeStar;
        private System.Windows.Forms.TextBox txtFourStar;
        private System.Windows.Forms.TextBox txtFiveStar;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCopyright;
    }
}

