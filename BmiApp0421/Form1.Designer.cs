namespace BmiApp0421
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
            label2 = new Label();
            heightTxt = new TextBox();
            weightTxt = new TextBox();
            computeBtn = new Button();
            clearBtn = new Button();
            bmiResult = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16F);
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 0;
            label1.Text = "身高:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16F);
            label2.Location = new Point(27, 78);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 1;
            label2.Text = "體重:";
            // 
            // heightTxt
            // 
            heightTxt.Font = new Font("Microsoft JhengHei UI", 16F);
            heightTxt.Location = new Point(94, 26);
            heightTxt.Name = "heightTxt";
            heightTxt.PlaceholderText = "cm";
            heightTxt.Size = new Size(165, 35);
            heightTxt.TabIndex = 2;
            // 
            // weightTxt
            // 
            weightTxt.Font = new Font("Microsoft JhengHei UI", 16F);
            weightTxt.Location = new Point(94, 75);
            weightTxt.Name = "weightTxt";
            weightTxt.PlaceholderText = "kg";
            weightTxt.Size = new Size(165, 35);
            weightTxt.TabIndex = 3;
            // 
            // computeBtn
            // 
            computeBtn.Font = new Font("Microsoft JhengHei UI", 14F);
            computeBtn.Location = new Point(278, 26);
            computeBtn.Name = "computeBtn";
            computeBtn.Size = new Size(93, 35);
            computeBtn.TabIndex = 4;
            computeBtn.Text = "計算";
            computeBtn.UseVisualStyleBackColor = true;
            computeBtn.Click += computeBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Microsoft JhengHei UI", 14F);
            clearBtn.Location = new Point(278, 75);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(93, 35);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "清除";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // bmiResult
            // 
            bmiResult.AutoSize = true;
            bmiResult.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
            bmiResult.Location = new Point(94, 128);
            bmiResult.Name = "bmiResult";
            bmiResult.Size = new Size(0, 28);
            bmiResult.TabIndex = 6;
            bmiResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bmi_bg;
            pictureBox1.Location = new Point(6, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 415);
            Controls.Add(pictureBox1);
            Controls.Add(bmiResult);
            Controls.Add(clearBtn);
            Controls.Add(computeBtn);
            Controls.Add(weightTxt);
            Controls.Add(heightTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox heightTxt;
        private TextBox weightTxt;
        private Button computeBtn;
        private Button clearBtn;
        private Label bmiResult;
        private PictureBox pictureBox1;
    }
}
