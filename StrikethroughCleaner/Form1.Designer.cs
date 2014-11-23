namespace StrikethroughCleaner {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxFileLocation = new System.Windows.Forms.TextBox();
            this.buttonSelectExcelWorksheet = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFileLocation
            // 
            this.textBoxFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileLocation.Location = new System.Drawing.Point(13, 13);
            this.textBoxFileLocation.Name = "textBoxFileLocation";
            this.textBoxFileLocation.ReadOnly = true;
            this.textBoxFileLocation.Size = new System.Drawing.Size(393, 23);
            this.textBoxFileLocation.TabIndex = 0;
            // 
            // buttonSelectExcelWorksheet
            // 
            this.buttonSelectExcelWorksheet.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSelectExcelWorksheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectExcelWorksheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectExcelWorksheet.Location = new System.Drawing.Point(13, 42);
            this.buttonSelectExcelWorksheet.Name = "buttonSelectExcelWorksheet";
            this.buttonSelectExcelWorksheet.Size = new System.Drawing.Size(167, 30);
            this.buttonSelectExcelWorksheet.TabIndex = 1;
            this.buttonSelectExcelWorksheet.Text = "Select Excel Worksheet";
            this.buttonSelectExcelWorksheet.UseVisualStyleBackColor = false;
            this.buttonSelectExcelWorksheet.Click += new System.EventHandler(this.buttonSelectExcelWorksheet_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Enabled = false;
            this.buttonClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.Location = new System.Drawing.Point(186, 42);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(220, 77);
            this.buttonClean.TabIndex = 2;
            this.buttonClean.Text = "Clean Strikethrough Characters";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 130);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(418, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 152);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonSelectExcelWorksheet);
            this.Controls.Add(this.textBoxFileLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strikethrough Cleaner";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileLocation;
        private System.Windows.Forms.Button buttonSelectExcelWorksheet;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

