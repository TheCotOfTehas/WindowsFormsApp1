namespace WindowsFormsApp1
{
    partial class AddInStockForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusMyBox = new System.Windows.Forms.TextBox();
            this.heightMyBox = new System.Windows.Forms.TextBox();
            this.widthMyBox = new System.Windows.Forms.TextBox();
            this.lengthMyBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GoToStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Высота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ширина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Название товара";
            // 
            // statusMyBox
            // 
            this.statusMyBox.Location = new System.Drawing.Point(481, 68);
            this.statusMyBox.Name = "statusMyBox";
            this.statusMyBox.Size = new System.Drawing.Size(100, 20);
            this.statusMyBox.TabIndex = 33;
            // 
            // heightMyBox
            // 
            this.heightMyBox.Location = new System.Drawing.Point(375, 68);
            this.heightMyBox.Name = "heightMyBox";
            this.heightMyBox.Size = new System.Drawing.Size(100, 20);
            this.heightMyBox.TabIndex = 32;
            // 
            // widthMyBox
            // 
            this.widthMyBox.Location = new System.Drawing.Point(269, 69);
            this.widthMyBox.Name = "widthMyBox";
            this.widthMyBox.Size = new System.Drawing.Size(100, 20);
            this.widthMyBox.TabIndex = 31;
            // 
            // lengthMyBox
            // 
            this.lengthMyBox.Location = new System.Drawing.Point(163, 68);
            this.lengthMyBox.Name = "lengthMyBox";
            this.lengthMyBox.Size = new System.Drawing.Size(100, 20);
            this.lengthMyBox.TabIndex = 30;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(57, 68);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddProductInStrockButon);
            // 
            // GoToStart
            // 
            this.GoToStart.Location = new System.Drawing.Point(425, 94);
            this.GoToStart.Name = "GoToStart";
            this.GoToStart.Size = new System.Drawing.Size(75, 23);
            this.GoToStart.TabIndex = 27;
            this.GoToStart.Text = "GoToStart";
            this.GoToStart.UseVisualStyleBackColor = true;
            this.GoToStart.Click += new System.EventHandler(this.GoToStart_Click);
            // 
            // AddInStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 167);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusMyBox);
            this.Controls.Add(this.heightMyBox);
            this.Controls.Add(this.widthMyBox);
            this.Controls.Add(this.lengthMyBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoToStart);
            this.Name = "AddInStockForm";
            this.Text = "AddInStockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statusMyBox;
        private System.Windows.Forms.TextBox heightMyBox;
        private System.Windows.Forms.TextBox widthMyBox;
        private System.Windows.Forms.TextBox lengthMyBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GoToStart;
    }
}