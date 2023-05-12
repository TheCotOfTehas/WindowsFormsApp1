namespace WindowsFormsApp1
{
    partial class AdoptedForm
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
            this.GoToStart = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.lengthMyBox = new System.Windows.Forms.TextBox();
            this.widthMyBox = new System.Windows.Forms.TextBox();
            this.heightMyBox = new System.Windows.Forms.TextBox();
            this.statusMyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // GoToStart
            // 
            this.GoToStart.Location = new System.Drawing.Point(518, 396);
            this.GoToStart.Name = "GoToStart";
            this.GoToStart.Size = new System.Drawing.Size(75, 23);
            this.GoToStart.TabIndex = 1;
            this.GoToStart.Text = "GoToStart";
            this.GoToStart.UseVisualStyleBackColor = true;
            this.GoToStart.Click += new System.EventHandler(this.GoToStart_Click);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(44, 127);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(630, 194);
            this.Table.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.butto_Add);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(44, 371);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(100, 20);
            this.IdBox.TabIndex = 4;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(150, 370);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 5;
            // 
            // lengthMyBox
            // 
            this.lengthMyBox.Location = new System.Drawing.Point(256, 370);
            this.lengthMyBox.Name = "lengthMyBox";
            this.lengthMyBox.Size = new System.Drawing.Size(100, 20);
            this.lengthMyBox.TabIndex = 6;
            // 
            // widthMyBox
            // 
            this.widthMyBox.Location = new System.Drawing.Point(362, 371);
            this.widthMyBox.Name = "widthMyBox";
            this.widthMyBox.Size = new System.Drawing.Size(100, 20);
            this.widthMyBox.TabIndex = 7;
            // 
            // heightMyBox
            // 
            this.heightMyBox.Location = new System.Drawing.Point(468, 370);
            this.heightMyBox.Name = "heightMyBox";
            this.heightMyBox.Size = new System.Drawing.Size(100, 20);
            this.heightMyBox.TabIndex = 8;
            // 
            // statusMyBox
            // 
            this.statusMyBox.Location = new System.Drawing.Point(574, 370);
            this.statusMyBox.Name = "statusMyBox";
            this.statusMyBox.Size = new System.Drawing.Size(100, 20);
            this.statusMyBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Название товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Длина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ширина";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Высота";
            // 
            // AdoptedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusMyBox);
            this.Controls.Add(this.heightMyBox);
            this.Controls.Add(this.widthMyBox);
            this.Controls.Add(this.lengthMyBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.GoToStart);
            this.Name = "AdoptedForm";
            this.Text = "AdoptedForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToStart;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox lengthMyBox;
        private System.Windows.Forms.TextBox widthMyBox;
        private System.Windows.Forms.TextBox heightMyBox;
        private System.Windows.Forms.TextBox statusMyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}