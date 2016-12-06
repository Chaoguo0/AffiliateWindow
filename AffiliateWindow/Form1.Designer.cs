namespace AffiliateWindow
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
            this.btnShowResult = new System.Windows.Forms.Button();
            this.lblMerchants = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnShowProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(12, 341);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(217, 53);
            this.btnShowResult.TabIndex = 0;
            this.btnShowResult.Text = "Show Merchants Results";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // lblMerchants
            // 
            this.lblMerchants.AutoSize = true;
            this.lblMerchants.Location = new System.Drawing.Point(60, 62);
            this.lblMerchants.Name = "lblMerchants";
            this.lblMerchants.Size = new System.Drawing.Size(130, 13);
            this.lblMerchants.TabIndex = 1;
            this.lblMerchants.Text = "Placeholder for merchants";
            this.lblMerchants.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(502, 62);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(122, 13);
            this.lblProducts.TabIndex = 2;
            this.lblProducts.Text = "Placeholder for products";
            // 
            // btnShowProducts
            // 
            this.btnShowProducts.Location = new System.Drawing.Point(505, 341);
            this.btnShowProducts.Name = "btnShowProducts";
            this.btnShowProducts.Size = new System.Drawing.Size(217, 53);
            this.btnShowProducts.TabIndex = 0;
            this.btnShowProducts.Text = "Show Products Results";
            this.btnShowProducts.UseVisualStyleBackColor = true;
            this.btnShowProducts.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 470);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblMerchants);
            this.Controls.Add(this.btnShowProducts);
            this.Controls.Add(this.btnShowResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Label lblMerchants;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnShowProducts;
    }
}

