namespace HashVerifier
{
    partial class Window
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
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSupplierMD5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSupplierSHA1 = new System.Windows.Forms.TextBox();
            this.textBoxGeneratedMD5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGeneratedSHA1 = new System.Windows.Forms.TextBox();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(109, 10);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(349, 20);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(464, 8);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSupplierMD5
            // 
            this.textBoxSupplierMD5.Location = new System.Drawing.Point(109, 36);
            this.textBoxSupplierMD5.Name = "textBoxSupplierMD5";
            this.textBoxSupplierMD5.Size = new System.Drawing.Size(349, 20);
            this.textBoxSupplierMD5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier MD5:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supplier SHA1:";
            // 
            // textBoxSupplierSHA1
            // 
            this.textBoxSupplierSHA1.Location = new System.Drawing.Point(109, 62);
            this.textBoxSupplierSHA1.Name = "textBoxSupplierSHA1";
            this.textBoxSupplierSHA1.Size = new System.Drawing.Size(349, 20);
            this.textBoxSupplierSHA1.TabIndex = 6;
            // 
            // textBoxGeneratedMD5
            // 
            this.textBoxGeneratedMD5.Enabled = false;
            this.textBoxGeneratedMD5.Location = new System.Drawing.Point(109, 88);
            this.textBoxGeneratedMD5.Name = "textBoxGeneratedMD5";
            this.textBoxGeneratedMD5.Size = new System.Drawing.Size(349, 20);
            this.textBoxGeneratedMD5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Generated MD5:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Generated SHA1:";
            // 
            // textBoxGeneratedSHA1
            // 
            this.textBoxGeneratedSHA1.Enabled = false;
            this.textBoxGeneratedSHA1.Location = new System.Drawing.Point(109, 115);
            this.textBoxGeneratedSHA1.Name = "textBoxGeneratedSHA1";
            this.textBoxGeneratedSHA1.Size = new System.Drawing.Size(349, 20);
            this.textBoxGeneratedSHA1.TabIndex = 10;
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(464, 140);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(75, 23);
            this.buttonVerify.TabIndex = 11;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 145);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 12;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 169);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.textBoxGeneratedSHA1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGeneratedMD5);
            this.Controls.Add(this.textBoxSupplierSHA1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSupplierMD5);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilePath);
            this.Name = "Window";
            this.Text = "Hash Verifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSupplierMD5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSupplierSHA1;
        private System.Windows.Forms.TextBox textBoxGeneratedMD5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGeneratedSHA1;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Label labelResult;
    }
}

