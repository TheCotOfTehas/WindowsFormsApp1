namespace WindowsFormsApp1
{
    partial class StartForm
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
            this.GoAdopted = new System.Windows.Forms.Button();
            this.InStock = new System.Windows.Forms.Button();
            this.Sold = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoAdopted
            // 
            this.GoAdopted.Location = new System.Drawing.Point(41, 35);
            this.GoAdopted.Name = "GoAdopted";
            this.GoAdopted.Size = new System.Drawing.Size(75, 23);
            this.GoAdopted.TabIndex = 0;
            this.GoAdopted.Text = "GoAdopted";
            this.GoAdopted.UseVisualStyleBackColor = true;
            this.GoAdopted.Click += new System.EventHandler(this.Adopted_Click);
            // 
            // InStock
            // 
            this.InStock.Location = new System.Drawing.Point(122, 35);
            this.InStock.Name = "InStock";
            this.InStock.Size = new System.Drawing.Size(75, 23);
            this.InStock.TabIndex = 1;
            this.InStock.Text = "InStock";
            this.InStock.UseVisualStyleBackColor = true;
            this.InStock.Click += new System.EventHandler(this.InStock_Click);
            // 
            // Sold
            // 
            this.Sold.Location = new System.Drawing.Point(203, 35);
            this.Sold.Name = "Sold";
            this.Sold.Size = new System.Drawing.Size(75, 23);
            this.Sold.TabIndex = 2;
            this.Sold.Text = "Sold";
            this.Sold.UseVisualStyleBackColor = true;
            this.Sold.Click += new System.EventHandler(this.Sold_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sold);
            this.Controls.Add(this.InStock);
            this.Controls.Add(this.GoAdopted);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoAdopted;
        private System.Windows.Forms.Button InStock;
        private System.Windows.Forms.Button Sold;
    }
}