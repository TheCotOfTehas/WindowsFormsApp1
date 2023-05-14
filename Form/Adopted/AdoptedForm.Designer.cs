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
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttoGoAddAdoptedForm);
            // 
            // AdoptedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.GoToStart);
            this.Name = "AdoptedForm";
            this.Text = "AdoptedForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoToStart;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button button1;
    }
}