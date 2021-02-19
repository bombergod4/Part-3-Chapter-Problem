namespace Part_3_Chapter_Problem
{
    partial class FrmMain
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
            this.trkbarAge = new System.Windows.Forms.TrackBar();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarAge)).BeginInit();
            this.SuspendLayout();
            // 
            // trkbarAge
            // 
            this.trkbarAge.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trkbarAge.LargeChange = 1;
            this.trkbarAge.Location = new System.Drawing.Point(12, 27);
            this.trkbarAge.Maximum = 120;
            this.trkbarAge.Name = "trkbarAge";
            this.trkbarAge.Size = new System.Drawing.Size(747, 45);
            this.trkbarAge.TabIndex = 0;
            this.trkbarAge.TickFrequency = 2;
            this.trkbarAge.Value = 60;
            this.trkbarAge.Scroll += new System.EventHandler(this.trkbarAge_Scroll);
            // 
            // lblAge
            // 
            this.lblAge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAge.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Blue;
            this.lblAge.Location = new System.Drawing.Point(312, 75);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(150, 33);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age = 60";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(12, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 40);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Please enter your name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(199, 152);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 23);
            this.txtName.TabIndex = 3;
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.Blue;
            this.lblHeight.Location = new System.Drawing.Point(372, 141);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(146, 40);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Please enter your height in meters (2 decimal spots)";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(524, 152);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(143, 23);
            this.txtHeight.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(330, 235);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 48);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit Data";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.ForeColor = System.Drawing.Color.Blue;
            this.lblGreetings.Location = new System.Drawing.Point(327, 108);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(36, 15);
            this.lblGreetings.TabIndex = 7;
            this.lblGreetings.Text = "label1";
            this.lblGreetings.Visible = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.Blue;
            this.lblOutput.Location = new System.Drawing.Point(327, 136);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(38, 15);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "label2";
            this.lblOutput.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 295);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.trkbarAge);
            this.Name = "FrmMain";
            this.Text = "Basic Input";
            ((System.ComponentModel.ISupportInitialize)(this.trkbarAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TrackBar trkbarAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblOutput;
    }
}

