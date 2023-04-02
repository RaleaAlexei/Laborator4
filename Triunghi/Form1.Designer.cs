namespace Triunghi
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSide1 = new System.Windows.Forms.TextBox();
            this.tbSide2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSide3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latura 1:";
            // 
            // tbSide1
            // 
            this.tbSide1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSide1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSide1.Location = new System.Drawing.Point(97, 15);
            this.tbSide1.Name = "tbSide1";
            this.tbSide1.PlaceholderText = "1 cm";
            this.tbSide1.Size = new System.Drawing.Size(69, 25);
            this.tbSide1.TabIndex = 1;
            this.tbSide1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSide2
            // 
            this.tbSide2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSide2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSide2.Location = new System.Drawing.Point(97, 53);
            this.tbSide2.Name = "tbSide2";
            this.tbSide2.PlaceholderText = "1 cm";
            this.tbSide2.Size = new System.Drawing.Size(69, 25);
            this.tbSide2.TabIndex = 3;
            this.tbSide2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Latura 2:";
            // 
            // tbSide3
            // 
            this.tbSide3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSide3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSide3.Location = new System.Drawing.Point(97, 91);
            this.tbSide3.Name = "tbSide3";
            this.tbSide3.PlaceholderText = "1 cm";
            this.tbSide3.Size = new System.Drawing.Size(69, 25);
            this.tbSide3.TabIndex = 5;
            this.tbSide3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Latura 3:";
            // 
            // btCalculate
            // 
            this.btCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btCalculate.FlatAppearance.BorderSize = 0;
            this.btCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCalculate.ForeColor = System.Drawing.Color.White;
            this.btCalculate.Location = new System.Drawing.Point(7, 132);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(159, 42);
            this.btCalculate.TabIndex = 6;
            this.btCalculate.Text = "Calculeaza";
            this.btCalculate.UseVisualStyleBackColor = false;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResult.ForeColor = System.Drawing.Color.White;
            this.lbResult.Location = new System.Drawing.Point(172, 9);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(124, 165);
            this.lbResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(308, 180);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbSide3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSide2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSide1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.Name = "Form1";
            this.Text = "Heron\'s Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbSide1;
        private TextBox tbSide2;
        private Label label2;
        private TextBox tbSide3;
        private Label label3;
        private Button btCalculate;
        private Label lbResult;
    }
}