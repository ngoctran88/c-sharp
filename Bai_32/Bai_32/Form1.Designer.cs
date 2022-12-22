namespace Bai_32
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
            this.chklstLeft = new System.Windows.Forms.CheckedListBox();
            this.btnMoveOneFormLeftToRight = new System.Windows.Forms.Button();
            this.btnMoveAllFormLeftToRight = new System.Windows.Forms.Button();
            this.btnMoveOneFormRighToLeft = new System.Windows.Forms.Button();
            this.btnMoveAllFormRightToLeft = new System.Windows.Forms.Button();
            this.chklstRight = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // chklstLeft
            // 
            this.chklstLeft.FormattingEnabled = true;
            this.chklstLeft.Location = new System.Drawing.Point(12, 12);
            this.chklstLeft.Name = "chklstLeft";
            this.chklstLeft.Size = new System.Drawing.Size(139, 214);
            this.chklstLeft.TabIndex = 0;
            // 
            // btnMoveOneFormLeftToRight
            // 
            this.btnMoveOneFormLeftToRight.Location = new System.Drawing.Point(171, 23);
            this.btnMoveOneFormLeftToRight.Name = "btnMoveOneFormLeftToRight";
            this.btnMoveOneFormLeftToRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveOneFormLeftToRight.TabIndex = 1;
            this.btnMoveOneFormLeftToRight.Text = ">";
            this.btnMoveOneFormLeftToRight.UseVisualStyleBackColor = true;
            this.btnMoveOneFormLeftToRight.Click += new System.EventHandler(this.btnMoveOneFormLeftToRight_Click);
            // 
            // btnMoveAllFormLeftToRight
            // 
            this.btnMoveAllFormLeftToRight.Location = new System.Drawing.Point(171, 64);
            this.btnMoveAllFormLeftToRight.Name = "btnMoveAllFormLeftToRight";
            this.btnMoveAllFormLeftToRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveAllFormLeftToRight.TabIndex = 2;
            this.btnMoveAllFormLeftToRight.Text = ">>";
            this.btnMoveAllFormLeftToRight.UseVisualStyleBackColor = true;
            this.btnMoveAllFormLeftToRight.Click += new System.EventHandler(this.btnMoveAllFormLeftToRight_Click);
            // 
            // btnMoveOneFormRighToLeft
            // 
            this.btnMoveOneFormRighToLeft.Location = new System.Drawing.Point(171, 101);
            this.btnMoveOneFormRighToLeft.Name = "btnMoveOneFormRighToLeft";
            this.btnMoveOneFormRighToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveOneFormRighToLeft.TabIndex = 3;
            this.btnMoveOneFormRighToLeft.Text = "<";
            this.btnMoveOneFormRighToLeft.UseVisualStyleBackColor = true;
            this.btnMoveOneFormRighToLeft.Click += new System.EventHandler(this.btnMoveOneFormRighToLeft_Click);
            // 
            // btnMoveAllFormRightToLeft
            // 
            this.btnMoveAllFormRightToLeft.Location = new System.Drawing.Point(171, 140);
            this.btnMoveAllFormRightToLeft.Name = "btnMoveAllFormRightToLeft";
            this.btnMoveAllFormRightToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveAllFormRightToLeft.TabIndex = 4;
            this.btnMoveAllFormRightToLeft.Text = "<<";
            this.btnMoveAllFormRightToLeft.UseVisualStyleBackColor = true;
            this.btnMoveAllFormRightToLeft.Click += new System.EventHandler(this.btnMoveAllFormRightToLeft_Click);
            // 
            // chklstRight
            // 
            this.chklstRight.FormattingEnabled = true;
            this.chklstRight.Location = new System.Drawing.Point(264, 12);
            this.chklstRight.Name = "chklstRight";
            this.chklstRight.Size = new System.Drawing.Size(139, 214);
            this.chklstRight.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 244);
            this.Controls.Add(this.chklstRight);
            this.Controls.Add(this.btnMoveAllFormRightToLeft);
            this.Controls.Add(this.btnMoveOneFormRighToLeft);
            this.Controls.Add(this.btnMoveAllFormLeftToRight);
            this.Controls.Add(this.btnMoveOneFormLeftToRight);
            this.Controls.Add(this.chklstLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstLeft;
        private System.Windows.Forms.Button btnMoveOneFormLeftToRight;
        private System.Windows.Forms.Button btnMoveAllFormLeftToRight;
        private System.Windows.Forms.Button btnMoveOneFormRighToLeft;
        private System.Windows.Forms.Button btnMoveAllFormRightToLeft;
        private System.Windows.Forms.CheckedListBox chklstRight;
    }
}

