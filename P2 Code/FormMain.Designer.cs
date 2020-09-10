namespace P2_Code
{
    partial class FormMain
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
            this.SeeFish = new System.Windows.Forms.Button();
            this.listBoxFish = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // SeeFish
            // 
            this.SeeFish.Location = new System.Drawing.Point(316, 365);
            this.SeeFish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeeFish.Name = "SeeFish";
            this.SeeFish.Size = new System.Drawing.Size(112, 35);
            this.SeeFish.TabIndex = 0;
            this.SeeFish.Text = "See Fish";
            this.SeeFish.UseVisualStyleBackColor = true;
            this.SeeFish.Click += new System.EventHandler(this.SeeFish_Click);
            // 
            // listBoxFish
            // 
            this.listBoxFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFish.FormattingEnabled = true;
            this.listBoxFish.Location = new System.Drawing.Point(100, 100);
            this.listBoxFish.Name = "listBoxFish";
            this.listBoxFish.Size = new System.Drawing.Size(271, 257);
            this.listBoxFish.TabIndex = 1;
            this.listBoxFish.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.listBoxFish);
            this.Controls.Add(this.SeeFish);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "CSC470 - P2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SeeFish;
        private System.Windows.Forms.CheckedListBox listBoxFish;
    }
}

