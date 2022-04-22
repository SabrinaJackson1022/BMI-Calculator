
namespace BMI_Calculator
{
    partial class frmPhoneAndAddress
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
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAddPhoneAndAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(24, 36);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 17);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(24, 84);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(108, 33);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(151, 22);
            this.txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(108, 79);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(208, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // btnAddPhoneAndAddress
            // 
            this.btnAddPhoneAndAddress.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddPhoneAndAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.btnAddPhoneAndAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPhoneAndAddress.Location = new System.Drawing.Point(338, 31);
            this.btnAddPhoneAndAddress.Name = "btnAddPhoneAndAddress";
            this.btnAddPhoneAndAddress.Size = new System.Drawing.Size(135, 70);
            this.btnAddPhoneAndAddress.TabIndex = 4;
            this.btnAddPhoneAndAddress.Text = "ADD";
            this.btnAddPhoneAndAddress.UseVisualStyleBackColor = false;
            this.btnAddPhoneAndAddress.Click += new System.EventHandler(this.btnAddPhoneAndAddress_Click);
            // 
            // frmPhoneAndAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 134);
            this.Controls.Add(this.btnAddPhoneAndAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhoneAndAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddPhoneAndAddress;
    }
}