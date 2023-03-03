namespace SandwichShopKios
{
    partial class Form3Checkout
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
            this.lstBReviewItems = new System.Windows.Forms.ListBox();
            this.lblLast4Digits = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnBackwards = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBReviewItems
            // 
            this.lstBReviewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBReviewItems.FormattingEnabled = true;
            this.lstBReviewItems.ItemHeight = 55;
            this.lstBReviewItems.Location = new System.Drawing.Point(52, 175);
            this.lstBReviewItems.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lstBReviewItems.Name = "lstBReviewItems";
            this.lstBReviewItems.Size = new System.Drawing.Size(1011, 939);
            this.lstBReviewItems.TabIndex = 17;
            // 
            // lblLast4Digits
            // 
            this.lblLast4Digits.AutoSize = true;
            this.lblLast4Digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast4Digits.Location = new System.Drawing.Point(772, 1223);
            this.lblLast4Digits.Name = "lblLast4Digits";
            this.lblLast4Digits.Size = new System.Drawing.Size(326, 64);
            this.lblLast4Digits.TabIndex = 16;
            this.lblLast4Digits.Text = "Last 4 digits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 1223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(501, 64);
            this.label5.TabIndex = 15;
            this.label5.Text = "XXXX XXXX XXXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 1123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 64);
            this.label4.TabIndex = 14;
            this.label4.Text = "Payment method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 1223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 64);
            this.label3.TabIndex = 13;
            this.label3.Text = "VISA";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(896, 73);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(167, 64);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "£0:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 64);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total price:";
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProcessPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPayment.Location = new System.Drawing.Point(52, 1331);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(1011, 136);
            this.btnProcessPayment.TabIndex = 10;
            this.btnProcessPayment.Text = "Process payment";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click);
            // 
            // btnBackwards
            // 
            this.btnBackwards.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackwards.Location = new System.Drawing.Point(17, 8);
            this.btnBackwards.Name = "btnBackwards";
            this.btnBackwards.Size = new System.Drawing.Size(237, 129);
            this.btnBackwards.TabIndex = 9;
            this.btnBackwards.Text = "←";
            this.btnBackwards.UseVisualStyleBackColor = true;
            this.btnBackwards.Click += new System.EventHandler(this.btnBackwards_Click);
            // 
            // Form3Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 1479);
            this.Controls.Add(this.lstBReviewItems);
            this.Controls.Add(this.lblLast4Digits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcessPayment);
            this.Controls.Add(this.btnBackwards);
            this.Name = "Form3Checkout";
            this.Text = "Form2Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBReviewItems;
        private System.Windows.Forms.Label lblLast4Digits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnBackwards;
    }
}