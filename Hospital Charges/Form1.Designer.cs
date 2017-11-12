namespace Hospital_Charges
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
            this.lblNumDays = new System.Windows.Forms.Label();
            this.lblMedCharge = new System.Windows.Forms.Label();
            this.lblSurCharge = new System.Windows.Forms.Label();
            this.lblLabFee = new System.Windows.Forms.Label();
            this.lblPhysicalRehabCharge = new System.Windows.Forms.Label();
            this.tbxNumDays = new System.Windows.Forms.TextBox();
            this.tbxSurgicalCharge = new System.Windows.Forms.TextBox();
            this.tbxLabFee = new System.Windows.Forms.TextBox();
            this.tbxPhysicalRehabCharge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxBaseStayCharge = new System.Windows.Forms.TextBox();
            this.tbxSubtotal = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.lblBaseStayCharge = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbxMedCharge = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumDays
            // 
            this.lblNumDays.AutoSize = true;
            this.lblNumDays.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDays.Location = new System.Drawing.Point(23, 43);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(204, 15);
            this.lblNumDays.TabIndex = 0;
            this.lblNumDays.Text = "Number of days spent in the hospital";
            // 
            // lblMedCharge
            // 
            this.lblMedCharge.AutoSize = true;
            this.lblMedCharge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedCharge.Location = new System.Drawing.Point(112, 75);
            this.lblMedCharge.Name = "lblMedCharge";
            this.lblMedCharge.Size = new System.Drawing.Size(115, 15);
            this.lblMedCharge.TabIndex = 0;
            this.lblMedCharge.Text = "Medication Charges";
            // 
            // lblSurCharge
            // 
            this.lblSurCharge.AutoSize = true;
            this.lblSurCharge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurCharge.Location = new System.Drawing.Point(130, 108);
            this.lblSurCharge.Name = "lblSurCharge";
            this.lblSurCharge.Size = new System.Drawing.Size(97, 15);
            this.lblSurCharge.TabIndex = 0;
            this.lblSurCharge.Text = "Surgical Charges";
            // 
            // lblLabFee
            // 
            this.lblLabFee.AutoSize = true;
            this.lblLabFee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabFee.Location = new System.Drawing.Point(172, 144);
            this.lblLabFee.Name = "lblLabFee";
            this.lblLabFee.Size = new System.Drawing.Size(55, 15);
            this.lblLabFee.TabIndex = 0;
            this.lblLabFee.Text = "Lab Fees";
            // 
            // lblPhysicalRehabCharge
            // 
            this.lblPhysicalRehabCharge.AutoSize = true;
            this.lblPhysicalRehabCharge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicalRehabCharge.Location = new System.Drawing.Point(51, 174);
            this.lblPhysicalRehabCharge.Name = "lblPhysicalRehabCharge";
            this.lblPhysicalRehabCharge.Size = new System.Drawing.Size(176, 15);
            this.lblPhysicalRehabCharge.TabIndex = 0;
            this.lblPhysicalRehabCharge.Text = "Physical Rehabilitation Charges";
            // 
            // tbxNumDays
            // 
            this.tbxNumDays.Location = new System.Drawing.Point(247, 42);
            this.tbxNumDays.Name = "tbxNumDays";
            this.tbxNumDays.Size = new System.Drawing.Size(77, 22);
            this.tbxNumDays.TabIndex = 1;
            this.tbxNumDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxNumDays.TextChanged += new System.EventHandler(this.tbxNumDays_TextChanged);
            // 
            // tbxSurgicalCharge
            // 
            this.tbxSurgicalCharge.Location = new System.Drawing.Point(247, 107);
            this.tbxSurgicalCharge.Name = "tbxSurgicalCharge";
            this.tbxSurgicalCharge.Size = new System.Drawing.Size(101, 22);
            this.tbxSurgicalCharge.TabIndex = 1;
            this.tbxSurgicalCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxSurgicalCharge.TextChanged += new System.EventHandler(this.tbxSurgicalCharge_TextChanged);
            // 
            // tbxLabFee
            // 
            this.tbxLabFee.Location = new System.Drawing.Point(247, 143);
            this.tbxLabFee.Name = "tbxLabFee";
            this.tbxLabFee.Size = new System.Drawing.Size(101, 22);
            this.tbxLabFee.TabIndex = 1;
            this.tbxLabFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxLabFee.TextChanged += new System.EventHandler(this.tbxLabFee_TextChanged);
            // 
            // tbxPhysicalRehabCharge
            // 
            this.tbxPhysicalRehabCharge.Location = new System.Drawing.Point(247, 173);
            this.tbxPhysicalRehabCharge.Name = "tbxPhysicalRehabCharge";
            this.tbxPhysicalRehabCharge.Size = new System.Drawing.Size(101, 22);
            this.tbxPhysicalRehabCharge.TabIndex = 1;
            this.tbxPhysicalRehabCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxPhysicalRehabCharge.TextChanged += new System.EventHandler(this.tbxPhysicalRehabCharge_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(129, 267);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(102, 15);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal Charges";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(147, 299);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Charges";
            // 
            // tbxBaseStayCharge
            // 
            this.tbxBaseStayCharge.Enabled = false;
            this.tbxBaseStayCharge.Location = new System.Drawing.Point(247, 232);
            this.tbxBaseStayCharge.Name = "tbxBaseStayCharge";
            this.tbxBaseStayCharge.Size = new System.Drawing.Size(101, 22);
            this.tbxBaseStayCharge.TabIndex = 2;
            this.tbxBaseStayCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxSubtotal
            // 
            this.tbxSubtotal.Enabled = false;
            this.tbxSubtotal.Location = new System.Drawing.Point(247, 266);
            this.tbxSubtotal.Name = "tbxSubtotal";
            this.tbxSubtotal.Size = new System.Drawing.Size(101, 22);
            this.tbxSubtotal.TabIndex = 2;
            this.tbxSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Enabled = false;
            this.tbxTotal.Location = new System.Drawing.Point(247, 298);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(101, 22);
            this.tbxTotal.TabIndex = 2;
            this.tbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBaseStayCharge
            // 
            this.lblBaseStayCharge.AutoSize = true;
            this.lblBaseStayCharge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseStayCharge.Location = new System.Drawing.Point(11, 233);
            this.lblBaseStayCharge.Name = "lblBaseStayCharge";
            this.lblBaseStayCharge.Size = new System.Drawing.Size(220, 15);
            this.lblBaseStayCharge.TabIndex = 0;
            this.lblBaseStayCharge.Text = "Base Hospital Stay Charges ($350/day)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.Location = new System.Drawing.Point(166, 350);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(349, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbxMedCharge
            // 
            this.tbxMedCharge.Location = new System.Drawing.Point(247, 74);
            this.tbxMedCharge.Name = "tbxMedCharge";
            this.tbxMedCharge.Size = new System.Drawing.Size(101, 22);
            this.tbxMedCharge.TabIndex = 1;
            this.tbxMedCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxMedCharge.TextChanged += new System.EventHandler(this.tbxMedCharge_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(268, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = " Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 395);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbxSubtotal);
            this.Controls.Add(this.tbxBaseStayCharge);
            this.Controls.Add(this.tbxPhysicalRehabCharge);
            this.Controls.Add(this.tbxLabFee);
            this.Controls.Add(this.tbxMedCharge);
            this.Controls.Add(this.tbxSurgicalCharge);
            this.Controls.Add(this.tbxNumDays);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblBaseStayCharge);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhysicalRehabCharge);
            this.Controls.Add(this.lblLabFee);
            this.Controls.Add(this.lblSurCharge);
            this.Controls.Add(this.lblMedCharge);
            this.Controls.Add(this.lblNumDays);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumDays;
        private System.Windows.Forms.Label lblMedCharge;
        private System.Windows.Forms.Label lblSurCharge;
        private System.Windows.Forms.Label lblLabFee;
        private System.Windows.Forms.Label lblPhysicalRehabCharge;
        private System.Windows.Forms.TextBox tbxNumDays;
        private System.Windows.Forms.TextBox tbxSurgicalCharge;
        private System.Windows.Forms.TextBox tbxLabFee;
        private System.Windows.Forms.TextBox tbxPhysicalRehabCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbxBaseStayCharge;
        private System.Windows.Forms.TextBox tbxSubtotal;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label lblBaseStayCharge;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbxMedCharge;
        private System.Windows.Forms.Button btnClear;
    }
}

