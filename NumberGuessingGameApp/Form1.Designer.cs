namespace NumberGuessingGameApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtEnterNum = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            resources.ApplyResources(this.btnCheck, "btnCheck");
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.checkNumber);
            // 
            // txtEnterNum
            // 
            this.txtEnterNum.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtEnterNum, "txtEnterNum");
            this.txtEnterNum.Name = "txtEnterNum";
            this.txtEnterNum.TextChanged += new System.EventHandler(this.txtEnterNum_TextChanged);
            // 
            // lblQuestion
            // 
            resources.ApplyResources(this.lblQuestion, "lblQuestion");
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblGuessed
            // 
            resources.ApplyResources(this.lblGuessed, "lblGuessed");
            this.lblGuessed.BackColor = System.Drawing.Color.Transparent;
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Click += new System.EventHandler(this.lblGuessed_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtEnterNum);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtEnterNum;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblGuessed;
    }
}

