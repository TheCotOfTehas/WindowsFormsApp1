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
            this.GoToStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToStart
            // 
            this.GoToStart.Location = new System.Drawing.Point(624, 391);
            this.GoToStart.Name = "GoToStart";
            this.GoToStart.Size = new System.Drawing.Size(75, 23);
            this.GoToStart.TabIndex = 1;
            this.GoToStart.Text = "GoToStart";
            this.GoToStart.UseVisualStyleBackColor = true;
            this.GoToStart.Click += new System.EventHandler(this.GoToStart_Click);
            // 
            // InStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoToStart);
            this.Name = "InStockForm";
            this.Text = "InStockForm";
            this.ResumeLayout(false);

        }
             
        #endregion

        private System.Windows.Forms.Button GoToStart;
        private System.Windows.Forms.Button AddViews;
    }
}