namespace SimpleReplacer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtConvFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(12, 47);
            this.txtBefore.MaxLength = 0;
            this.txtBefore.Multiline = true;
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(290, 310);
            this.txtBefore.TabIndex = 1;
            this.txtBefore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBefore_KeyDown);
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(389, 49);
            this.txtAfter.MaxLength = 0;
            this.txtAfter.Multiline = true;
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(290, 310);
            this.txtAfter.TabIndex = 2;
            this.txtAfter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAfter_KeyDown);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(308, 47);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtConvFileName
            // 
            this.txtConvFileName.Location = new System.Drawing.Point(12, 12);
            this.txtConvFileName.MaxLength = 0;
            this.txtConvFileName.Name = "txtConvFileName";
            this.txtConvFileName.Size = new System.Drawing.Size(669, 19);
            this.txtConvFileName.TabIndex = 3;
            this.txtConvFileName.Text = "replace_data.tsv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 369);
            this.Controls.Add(this.txtConvFileName);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.txtBefore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtConvFileName;
    }
}
