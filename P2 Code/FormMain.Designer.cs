using System;

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
            this.SeeFish.Location = new System.Drawing.Point(211, 237);
            this.SeeFish.Name = "SeeFish";
            this.SeeFish.Size = new System.Drawing.Size(75, 23);
            this.SeeFish.TabIndex = 0;
            this.SeeFish.Text = "See Fish";
            this.SeeFish.UseVisualStyleBackColor = true;
            this.SeeFish.Click += new System.EventHandler(this.SeeFish_Click);
            // 
            // listBoxFish
            // 
            this.listBoxFish.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFish.FormattingEnabled = true;
            this.listBoxFish.Items.AddRange(new object[] {
            "Crappie",
            "Walleye",
            "Perch"});
            this.listBoxFish.Location = new System.Drawing.Point(67, 65);
            this.listBoxFish.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFish.Name = "listBoxFish";
            this.listBoxFish.Size = new System.Drawing.Size(182, 148);
            this.listBoxFish.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 289);
            this.Controls.Add(this.listBoxFish);
            this.Controls.Add(this.SeeFish);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSC470 - P2";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button SeeFish;
        private System.Windows.Forms.CheckedListBox listBoxFish;
    }
}

