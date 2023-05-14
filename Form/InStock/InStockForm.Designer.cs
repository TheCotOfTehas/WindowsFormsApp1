using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class InStockForm
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

        //Для этй кнопки я использовал дизайнер. Я ознакомился со структурой и некст я сделела без дизайнера
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.GoToStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(85, 79);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(630, 194);
            this.Table.TabIndex = 5;
            // 
            // GoToStart
            // 
            this.GoToStart.Location = new System.Drawing.Point(559, 348);
            this.GoToStart.Name = "GoToStart";
            this.GoToStart.Size = new System.Drawing.Size(75, 23);
            this.GoToStart.TabIndex = 4;
            this.GoToStart.Text = "GoToStart";
            this.GoToStart.UseVisualStyleBackColor = true;
            this.GoToStart.Click += new System.EventHandler(this.GoToStart_Click);
            // 
            // InStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.GoToStart);
            this.Name = "InStockForm";
            this.Text = "InStockForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }
             
        #endregion
        private System.Windows.Forms.Button AddViews;
        private Button button1;
        private DataGridView Table;
        private Button GoToStart;
    }
}