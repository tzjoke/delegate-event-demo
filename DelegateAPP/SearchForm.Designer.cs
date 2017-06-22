using System;

namespace DelegateAPP
{
    partial class SearchForm
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
            this.criteriaUc1 = new DelegateAPP.CriteriaUc();
            this.resultUc1 = new DelegateAPP.ResultUc();
            this.SuspendLayout();
            // 
            // criteriaUc1
            // 
            this.criteriaUc1.Dock = System.Windows.Forms.DockStyle.Top;
            this.criteriaUc1.Location = new System.Drawing.Point(0, 0);
            this.criteriaUc1.Name = "criteriaUc1";
            this.criteriaUc1.Size = new System.Drawing.Size(571, 116);
            this.criteriaUc1.TabIndex = 0;
            this.criteriaUc1.RuleChanged += new CriteriaUc.RuleChangedEventHandler(this.criteriaUc1_RuleChanged);
            // 
            // resultUc1
            // 
            this.resultUc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultUc1.Location = new System.Drawing.Point(0, 116);
            this.resultUc1.Name = "resultUc1";
            this.resultUc1.Size = new System.Drawing.Size(571, 125);
            this.resultUc1.TabIndex = 1;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 241);
            this.Controls.Add(this.resultUc1);
            this.Controls.Add(this.criteriaUc1);
            this.Name = "SearchForm";
            this.Text = "Form1";
            this.Load += new EventHandler(this.searchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CriteriaUc criteriaUc1;
        private ResultUc resultUc1;
    }
}

