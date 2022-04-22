
namespace BMI_Calculator
{
    partial class frmBMICalc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBMICalc));
            this.lblPromo = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneAndAddress = new System.Windows.Forms.Label();
            this.lblRoundMeasurements = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblFeet = new System.Windows.Forms.Label();
            this.lblInches = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtYourBMI = new System.Windows.Forms.TextBox();
            this.txtRecommendedBMI = new System.Windows.Forms.TextBox();
            this.grpbxMeasurements = new System.Windows.Forms.GroupBox();
            this.rdbtnMetric = new System.Windows.Forms.RadioButton();
            this.rdbtnEnglishMeasurements = new System.Windows.Forms.RadioButton();
            this.btnPhoneAndAddress = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblLBS = new System.Windows.Forms.Label();
            this.lblYourBMI = new System.Windows.Forms.Label();
            this.lblRecommendedBMI = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblAsterisk = new System.Windows.Forms.Label();
            this.grpbxMeasurements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromo.Location = new System.Drawing.Point(214, 38);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(401, 17);
            this.lblPromo.TabIndex = 0;
            this.lblPromo.Text = "This BMI calculator is provided by IWishICouldLoseWeight.com";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(214, 77);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 22);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "*First Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.lblEmail.Location = new System.Drawing.Point(214, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "*Email:";
            // 
            // lblPhoneAndAddress
            // 
            this.lblPhoneAndAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.lblPhoneAndAddress.Location = new System.Drawing.Point(52, 167);
            this.lblPhoneAndAddress.Name = "lblPhoneAndAddress";
            this.lblPhoneAndAddress.Size = new System.Drawing.Size(369, 63);
            this.lblPhoneAndAddress.TabIndex = 3;
            this.lblPhoneAndAddress.Text = "Help up help you stay healthy by entering your phone number and address so we can" +
    " stay in contact with you:";
            // 
            // lblRoundMeasurements
            // 
            this.lblRoundMeasurements.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundMeasurements.ForeColor = System.Drawing.Color.Red;
            this.lblRoundMeasurements.Location = new System.Drawing.Point(37, 253);
            this.lblRoundMeasurements.Name = "lblRoundMeasurements";
            this.lblRoundMeasurements.Size = new System.Drawing.Size(395, 24);
            this.lblRoundMeasurements.TabIndex = 4;
            this.lblRoundMeasurements.Text = "Please round all measurements to the nearest whole number";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.lblHeight.Location = new System.Drawing.Point(41, 294);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(59, 16);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "*Height";
            // 
            // lblFeet
            // 
            this.lblFeet.AutoSize = true;
            this.lblFeet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.lblFeet.Location = new System.Drawing.Point(211, 296);
            this.lblFeet.Name = "lblFeet";
            this.lblFeet.Size = new System.Drawing.Size(22, 16);
            this.lblFeet.TabIndex = 6;
            this.lblFeet.Text = "ft.";
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.lblInches.Location = new System.Drawing.Point(356, 296);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(24, 16);
            this.lblInches.TabIndex = 7;
            this.lblInches.Text = "in.";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(308, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 22);
            this.txtName.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(271, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(397, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(250, 292);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(100, 22);
            this.txtInches.TabIndex = 12;
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(118, 290);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(87, 22);
            this.txtFeet.TabIndex = 13;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(121, 332);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(84, 22);
            this.txtWeight.TabIndex = 14;
            // 
            // txtYourBMI
            // 
            this.txtYourBMI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtYourBMI.Location = new System.Drawing.Point(238, 373);
            this.txtYourBMI.Name = "txtYourBMI";
            this.txtYourBMI.ReadOnly = true;
            this.txtYourBMI.Size = new System.Drawing.Size(156, 22);
            this.txtYourBMI.TabIndex = 15;
            // 
            // txtRecommendedBMI
            // 
            this.txtRecommendedBMI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtRecommendedBMI.Location = new System.Drawing.Point(238, 408);
            this.txtRecommendedBMI.Name = "txtRecommendedBMI";
            this.txtRecommendedBMI.ReadOnly = true;
            this.txtRecommendedBMI.Size = new System.Drawing.Size(156, 22);
            this.txtRecommendedBMI.TabIndex = 16;
            // 
            // grpbxMeasurements
            // 
            this.grpbxMeasurements.Controls.Add(this.rdbtnMetric);
            this.grpbxMeasurements.Controls.Add(this.rdbtnEnglishMeasurements);
            this.grpbxMeasurements.Location = new System.Drawing.Point(461, 257);
            this.grpbxMeasurements.Name = "grpbxMeasurements";
            this.grpbxMeasurements.Size = new System.Drawing.Size(217, 136);
            this.grpbxMeasurements.TabIndex = 17;
            this.grpbxMeasurements.TabStop = false;
            this.grpbxMeasurements.Text = "Measurement Options:";
            // 
            // rdbtnMetric
            // 
            this.rdbtnMetric.AutoSize = true;
            this.rdbtnMetric.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.rdbtnMetric.Location = new System.Drawing.Point(6, 45);
            this.rdbtnMetric.Name = "rdbtnMetric";
            this.rdbtnMetric.Size = new System.Drawing.Size(175, 20);
            this.rdbtnMetric.TabIndex = 18;
            this.rdbtnMetric.TabStop = true;
            this.rdbtnMetric.Text = "Metric Measurements";
            this.rdbtnMetric.UseVisualStyleBackColor = true;
            // 
            // rdbtnEnglishMeasurements
            // 
            this.rdbtnEnglishMeasurements.AutoSize = true;
            this.rdbtnEnglishMeasurements.Checked = true;
            this.rdbtnEnglishMeasurements.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.rdbtnEnglishMeasurements.Location = new System.Drawing.Point(6, 85);
            this.rdbtnEnglishMeasurements.Name = "rdbtnEnglishMeasurements";
            this.rdbtnEnglishMeasurements.Size = new System.Drawing.Size(182, 20);
            this.rdbtnEnglishMeasurements.TabIndex = 19;
            this.rdbtnEnglishMeasurements.TabStop = true;
            this.rdbtnEnglishMeasurements.Text = "English Measurements";
            this.rdbtnEnglishMeasurements.UseVisualStyleBackColor = true;
            // 
            // btnPhoneAndAddress
            // 
            this.btnPhoneAndAddress.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPhoneAndAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.btnPhoneAndAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPhoneAndAddress.Location = new System.Drawing.Point(427, 164);
            this.btnPhoneAndAddress.Name = "btnPhoneAndAddress";
            this.btnPhoneAndAddress.Size = new System.Drawing.Size(157, 66);
            this.btnPhoneAndAddress.TabIndex = 18;
            this.btnPhoneAndAddress.Text = "Add more contact information";
            this.btnPhoneAndAddress.UseVisualStyleBackColor = false;
            this.btnPhoneAndAddress.Click += new System.EventHandler(this.btnPhoneAndAddress_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.lblWeight.Location = new System.Drawing.Point(39, 336);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(61, 16);
            this.lblWeight.TabIndex = 19;
            this.lblWeight.Text = "*Weight";
            // 
            // lblLBS
            // 
            this.lblLBS.AutoSize = true;
            this.lblLBS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.lblLBS.Location = new System.Drawing.Point(225, 336);
            this.lblLBS.Name = "lblLBS";
            this.lblLBS.Size = new System.Drawing.Size(33, 16);
            this.lblLBS.TabIndex = 20;
            this.lblLBS.Text = "lbs.";
            // 
            // lblYourBMI
            // 
            this.lblYourBMI.AutoSize = true;
            this.lblYourBMI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.lblYourBMI.Location = new System.Drawing.Point(105, 377);
            this.lblYourBMI.Name = "lblYourBMI";
            this.lblYourBMI.Size = new System.Drawing.Size(113, 16);
            this.lblYourBMI.TabIndex = 21;
            this.lblYourBMI.Text = "Your BMI Index:";
            // 
            // lblRecommendedBMI
            // 
            this.lblRecommendedBMI.AutoSize = true;
            this.lblRecommendedBMI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.lblRecommendedBMI.Location = new System.Drawing.Point(41, 412);
            this.lblRecommendedBMI.Name = "lblRecommendedBMI";
            this.lblRecommendedBMI.Size = new System.Drawing.Size(177, 16);
            this.lblRecommendedBMI.TabIndex = 22;
            this.lblRecommendedBMI.Text = "Your Recommended BMI:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(479, 412);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 70);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // picboxLogo
            // 
            this.picboxLogo.ErrorImage = null;
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.InitialImage = null;
            this.picboxLogo.Location = new System.Drawing.Point(25, 29);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(180, 120);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLogo.TabIndex = 24;
            this.picboxLogo.TabStop = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblLastName.Location = new System.Drawing.Point(441, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(92, 22);
            this.lblLastName.TabIndex = 25;
            this.lblLastName.Text = "*Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(539, 78);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(129, 22);
            this.txtLastName.TabIndex = 26;
            // 
            // lblAsterisk
            // 
            this.lblAsterisk.AutoSize = true;
            this.lblAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.lblAsterisk.Location = new System.Drawing.Point(37, 465);
            this.lblAsterisk.Name = "lblAsterisk";
            this.lblAsterisk.Size = new System.Drawing.Size(172, 17);
            this.lblAsterisk.TabIndex = 27;
            this.lblAsterisk.Text = "* Indicates a required field";
            // 
            // frmBMICalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 512);
            this.Controls.Add(this.lblAsterisk);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.picboxLogo);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRecommendedBMI);
            this.Controls.Add(this.lblYourBMI);
            this.Controls.Add(this.lblLBS);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.btnPhoneAndAddress);
            this.Controls.Add(this.grpbxMeasurements);
            this.Controls.Add(this.txtRecommendedBMI);
            this.Controls.Add(this.txtYourBMI);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtFeet);
            this.Controls.Add(this.txtInches);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblInches);
            this.Controls.Add(this.lblFeet);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblRoundMeasurements);
            this.Controls.Add(this.lblPhoneAndAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPromo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBMICalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.frmBMICalc_Load);
            this.grpbxMeasurements.ResumeLayout(false);
            this.grpbxMeasurements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneAndAddress;
        private System.Windows.Forms.Label lblRoundMeasurements;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblFeet;
        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtYourBMI;
        private System.Windows.Forms.TextBox txtRecommendedBMI;
        private System.Windows.Forms.GroupBox grpbxMeasurements;
        private System.Windows.Forms.RadioButton rdbtnMetric;
        private System.Windows.Forms.RadioButton rdbtnEnglishMeasurements;
        private System.Windows.Forms.Button btnPhoneAndAddress;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblLBS;
        private System.Windows.Forms.Label lblYourBMI;
        private System.Windows.Forms.Label lblRecommendedBMI;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAsterisk;
    }
}

