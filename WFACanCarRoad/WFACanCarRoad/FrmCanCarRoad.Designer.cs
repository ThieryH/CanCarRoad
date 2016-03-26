namespace WFACanCarRoad
{
    partial class FrmCanCarRoad
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.mtxTime = new System.Windows.Forms.MaskedTextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.mtxDate = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.mtxPlate = new System.Windows.Forms.MaskedTextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.erPError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erPError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(43, 145);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 16;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(433, 29);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(180, 93);
            this.btnValidate.TabIndex = 15;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // mtxTime
            // 
            this.mtxTime.Location = new System.Drawing.Point(270, 100);
            this.mtxTime.Mask = "90:00";
            this.mtxTime.Name = "mtxTime";
            this.mtxTime.Size = new System.Drawing.Size(100, 22);
            this.mtxTime.TabIndex = 14;
            this.mtxTime.ValidatingType = typeof(System.DateTime);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(43, 100);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 17);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Time";
            // 
            // mtxDate
            // 
            this.mtxDate.Location = new System.Drawing.Point(270, 63);
            this.mtxDate.Mask = "00/00/0000";
            this.mtxDate.Name = "mtxDate";
            this.mtxDate.Size = new System.Drawing.Size(100, 22);
            this.mtxDate.TabIndex = 12;
            this.mtxDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(43, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date";
            // 
            // mtxPlate
            // 
            this.mtxPlate.Location = new System.Drawing.Point(270, 29);
            this.mtxPlate.Mask = "LLL-0000";
            this.mtxPlate.Name = "mtxPlate";
            this.mtxPlate.Size = new System.Drawing.Size(100, 22);
            this.mtxPlate.TabIndex = 10;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Location = new System.Drawing.Point(43, 34);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(147, 17);
            this.lblPlate.TabIndex = 9;
            this.lblPlate.Text = "License Plate Number";
            // 
            // erPError
            // 
            this.erPError.ContainerControl = this;
            // 
            // FrmCanCarRoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 269);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.mtxTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mtxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.mtxPlate);
            this.Controls.Add(this.lblPlate);
            this.Name = "FrmCanCarRoad";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.erPError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.MaskedTextBox mtxTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MaskedTextBox mtxDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox mtxPlate;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.ErrorProvider erPError;
    }
}

