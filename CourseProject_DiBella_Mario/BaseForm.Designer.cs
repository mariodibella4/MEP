namespace FinalProjectMEP
{
    partial class BaseForm
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
            this.companyName = new System.Windows.Forms.Label();
            this.acronym = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.companyName.Location = new System.Drawing.Point(344, 238);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(109, 9);
            this.companyName.TabIndex = 4;
            this.companyName.Text = "Making Executives Personable";
            // 
            // acronym
            // 
            this.acronym.AutoSize = true;
            this.acronym.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acronym.Location = new System.Drawing.Point(338, 203);
            this.acronym.Name = "acronym";
            this.acronym.Size = new System.Drawing.Size(125, 33);
            this.acronym.TabIndex = 3;
            this.acronym.Text = "M   E   P";
            // 
            // copy
            // 
            this.copy.AutoSize = true;
            this.copy.Location = new System.Drawing.Point(8, 433);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(154, 13);
            this.copy.TabIndex = 5;
            this.copy.Text = "Copywrite 2020 of G.C.F. Labs ";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.acronym);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label companyName;
        protected System.Windows.Forms.Label acronym;
        private System.Windows.Forms.Label copy;
    }
}