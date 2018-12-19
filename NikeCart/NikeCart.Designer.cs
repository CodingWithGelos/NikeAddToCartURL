namespace NikeCart
{
    partial class NikeCart
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
            this.grpBoxShoeDetail = new System.Windows.Forms.GroupBox();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSize = new System.Windows.Forms.TextBox();
            this.lblSku = new System.Windows.Forms.Label();
            this.txtBoxSku = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtBoxProductID = new System.Windows.Forms.TextBox();
            this.grpBoxShoeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxShoeDetail
            // 
            this.grpBoxShoeDetail.Controls.Add(this.txtBoxURL);
            this.grpBoxShoeDetail.Controls.Add(this.btnGenerate);
            this.grpBoxShoeDetail.Controls.Add(this.label1);
            this.grpBoxShoeDetail.Controls.Add(this.txtBoxSize);
            this.grpBoxShoeDetail.Controls.Add(this.lblSku);
            this.grpBoxShoeDetail.Controls.Add(this.txtBoxSku);
            this.grpBoxShoeDetail.Controls.Add(this.lblPrice);
            this.grpBoxShoeDetail.Controls.Add(this.txtBoxPrice);
            this.grpBoxShoeDetail.Controls.Add(this.lblProductID);
            this.grpBoxShoeDetail.Controls.Add(this.txtBoxProductID);
            this.grpBoxShoeDetail.Location = new System.Drawing.Point(13, 13);
            this.grpBoxShoeDetail.Name = "grpBoxShoeDetail";
            this.grpBoxShoeDetail.Size = new System.Drawing.Size(568, 233);
            this.grpBoxShoeDetail.TabIndex = 0;
            this.grpBoxShoeDetail.TabStop = false;
            this.grpBoxShoeDetail.Text = "Generate AddToCart URL";
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(9, 205);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(553, 20);
            this.txtBoxURL.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(9, 176);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(553, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Size";
            // 
            // txtBoxSize
            // 
            this.txtBoxSize.Location = new System.Drawing.Point(9, 149);
            this.txtBoxSize.Name = "txtBoxSize";
            this.txtBoxSize.Size = new System.Drawing.Size(553, 20);
            this.txtBoxSize.TabIndex = 6;
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Location = new System.Drawing.Point(6, 94);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(26, 13);
            this.lblSku.TabIndex = 5;
            this.lblSku.Text = "Sku";
            // 
            // txtBoxSku
            // 
            this.txtBoxSku.Location = new System.Drawing.Point(9, 110);
            this.txtBoxSku.Name = "txtBoxSku";
            this.txtBoxSku.Size = new System.Drawing.Size(553, 20);
            this.txtBoxSku.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 55);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(9, 71);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(553, 20);
            this.txtBoxPrice.TabIndex = 2;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(6, 16);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(55, 13);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "ProductID";
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.Location = new System.Drawing.Point(9, 32);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.Size = new System.Drawing.Size(553, 20);
            this.txtBoxProductID.TabIndex = 0;
            // 
            // NikeCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 257);
            this.Controls.Add(this.grpBoxShoeDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NikeCart";
            this.Text = "NikeCart";
            this.grpBoxShoeDetail.ResumeLayout(false);
            this.grpBoxShoeDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxShoeDetail;
        private System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSize;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtBoxSku;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtBoxProductID;
    }
}

