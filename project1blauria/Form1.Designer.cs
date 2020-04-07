namespace project1blauria
{
    partial class lblMetricConversionTool
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
            this.btnCalculateLength = new System.Windows.Forms.Button();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtKilometers = new System.Windows.Forms.TextBox();
            this.txtMeters = new System.Windows.Forms.TextBox();
            this.txtKilograms = new System.Windows.Forms.TextBox();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.txtGrams = new System.Windows.Forms.TextBox();
            this.btnCalculateWeight = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMeters = new System.Windows.Forms.Label();
            this.lblKilometers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGrams = new System.Windows.Forms.Label();
            this.lblKilograms = new System.Windows.Forms.Label();
            this.lblPounds = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculateLength
            // 
            this.btnCalculateLength.Location = new System.Drawing.Point(24, 114);
            this.btnCalculateLength.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateLength.Name = "btnCalculateLength";
            this.btnCalculateLength.Size = new System.Drawing.Size(120, 44);
            this.btnCalculateLength.TabIndex = 0;
            this.btnCalculateLength.Text = "Calculate Length";
            this.btnCalculateLength.UseVisualStyleBackColor = true;
            this.btnCalculateLength.Click += new System.EventHandler(this.btnCalculateLength_Click);
            // 
            // txtFeet
            // 
            this.txtFeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeet.Location = new System.Drawing.Point(24, 63);
            this.txtFeet.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(148, 26);
            this.txtFeet.TabIndex = 1;
            // 
            // txtKilometers
            // 
            this.txtKilometers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometers.Location = new System.Drawing.Point(227, 63);
            this.txtKilometers.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilometers.Name = "txtKilometers";
            this.txtKilometers.Size = new System.Drawing.Size(148, 26);
            this.txtKilometers.TabIndex = 2;
            // 
            // txtMeters
            // 
            this.txtMeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeters.Location = new System.Drawing.Point(227, 132);
            this.txtMeters.Margin = new System.Windows.Forms.Padding(4);
            this.txtMeters.Name = "txtMeters";
            this.txtMeters.Size = new System.Drawing.Size(148, 26);
            this.txtMeters.TabIndex = 3;
            // 
            // txtKilograms
            // 
            this.txtKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilograms.Location = new System.Drawing.Point(227, 64);
            this.txtKilograms.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilograms.Name = "txtKilograms";
            this.txtKilograms.Size = new System.Drawing.Size(148, 26);
            this.txtKilograms.TabIndex = 4;
            // 
            // txtPounds
            // 
            this.txtPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPounds.Location = new System.Drawing.Point(24, 64);
            this.txtPounds.Margin = new System.Windows.Forms.Padding(4);
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(148, 26);
            this.txtPounds.TabIndex = 5;
            // 
            // txtGrams
            // 
            this.txtGrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrams.Location = new System.Drawing.Point(227, 134);
            this.txtGrams.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrams.Name = "txtGrams";
            this.txtGrams.Size = new System.Drawing.Size(148, 26);
            this.txtGrams.TabIndex = 6;
            // 
            // btnCalculateWeight
            // 
            this.btnCalculateWeight.Location = new System.Drawing.Point(24, 115);
            this.btnCalculateWeight.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateWeight.Name = "btnCalculateWeight";
            this.btnCalculateWeight.Size = new System.Drawing.Size(120, 45);
            this.btnCalculateWeight.TabIndex = 7;
            this.btnCalculateWeight.Text = "Calculate Weight";
            this.btnCalculateWeight.UseVisualStyleBackColor = true;
            this.btnCalculateWeight.Click += new System.EventHandler(this.btnCalculateWeight_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMeters);
            this.groupBox1.Controls.Add(this.lblKilometers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFeet);
            this.groupBox1.Controls.Add(this.txtKilometers);
            this.groupBox1.Controls.Add(this.btnCalculateLength);
            this.groupBox1.Controls.Add(this.txtMeters);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 176);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance";
            // 
            // lblMeters
            // 
            this.lblMeters.AutoSize = true;
            this.lblMeters.Location = new System.Drawing.Point(227, 110);
            this.lblMeters.Name = "lblMeters";
            this.lblMeters.Size = new System.Drawing.Size(54, 18);
            this.lblMeters.TabIndex = 6;
            this.lblMeters.Text = "Meters";
            // 
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Location = new System.Drawing.Point(227, 31);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(79, 18);
            this.lblKilometers.TabIndex = 5;
            this.lblKilometers.Text = "Kilometers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Feet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGrams);
            this.groupBox2.Controls.Add(this.lblKilograms);
            this.groupBox2.Controls.Add(this.lblPounds);
            this.groupBox2.Controls.Add(this.btnCalculateWeight);
            this.groupBox2.Controls.Add(this.txtPounds);
            this.groupBox2.Controls.Add(this.txtGrams);
            this.groupBox2.Controls.Add(this.txtKilograms);
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 186);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weight";
            // 
            // lblGrams
            // 
            this.lblGrams.AutoSize = true;
            this.lblGrams.Location = new System.Drawing.Point(227, 103);
            this.lblGrams.Name = "lblGrams";
            this.lblGrams.Size = new System.Drawing.Size(54, 18);
            this.lblGrams.TabIndex = 10;
            this.lblGrams.Text = "Grams";
            // 
            // lblKilograms
            // 
            this.lblKilograms.AutoSize = true;
            this.lblKilograms.Location = new System.Drawing.Point(227, 32);
            this.lblKilograms.Name = "lblKilograms";
            this.lblKilograms.Size = new System.Drawing.Size(75, 18);
            this.lblKilograms.TabIndex = 9;
            this.lblKilograms.Text = "Kilograms";
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Location = new System.Drawing.Point(30, 32);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(59, 18);
            this.lblPounds.TabIndex = 8;
            this.lblPounds.Text = "Pounds";
            // 
            // lblMetricConversionTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "lblMetricConversionTool";
            this.Text = "Metric Conversion Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateLength;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtKilometers;
        private System.Windows.Forms.TextBox txtMeters;
        private System.Windows.Forms.TextBox txtKilograms;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.TextBox txtGrams;
        private System.Windows.Forms.Button btnCalculateWeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMeters;
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGrams;
        private System.Windows.Forms.Label lblKilograms;
        private System.Windows.Forms.Label lblPounds;
    }
}

