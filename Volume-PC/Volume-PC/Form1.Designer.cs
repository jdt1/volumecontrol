namespace Volume_PC
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
            this.btnHarder = new System.Windows.Forms.Button();
            this.btnZachter = new System.Windows.Forms.Button();
            this.btnVeelharder = new System.Windows.Forms.Button();
            this.btnVeelzachter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHarder
            // 
            this.btnHarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHarder.Location = new System.Drawing.Point(3, 2);
            this.btnHarder.Name = "btnHarder";
            this.btnHarder.Size = new System.Drawing.Size(153, 84);
            this.btnHarder.TabIndex = 0;
            this.btnHarder.Text = "Harder";
            this.btnHarder.UseVisualStyleBackColor = true;
            this.btnHarder.Click += new System.EventHandler(this.btnHarder_Click);
            // 
            // btnZachter
            // 
            this.btnZachter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZachter.Location = new System.Drawing.Point(3, 88);
            this.btnZachter.Name = "btnZachter";
            this.btnZachter.Size = new System.Drawing.Size(153, 88);
            this.btnZachter.TabIndex = 0;
            this.btnZachter.Text = "Zachter";
            this.btnZachter.UseVisualStyleBackColor = true;
            this.btnZachter.Click += new System.EventHandler(this.btnZachter_Click);
            // 
            // btnVeelharder
            // 
            this.btnVeelharder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeelharder.Location = new System.Drawing.Point(158, 2);
            this.btnVeelharder.Name = "btnVeelharder";
            this.btnVeelharder.Size = new System.Drawing.Size(112, 84);
            this.btnVeelharder.TabIndex = 1;
            this.btnVeelharder.Text = "Veel harder";
            this.btnVeelharder.UseVisualStyleBackColor = true;
            this.btnVeelharder.Click += new System.EventHandler(this.btnVeelharder_Click);
            // 
            // btnVeelzachter
            // 
            this.btnVeelzachter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeelzachter.Location = new System.Drawing.Point(158, 88);
            this.btnVeelzachter.Name = "btnVeelzachter";
            this.btnVeelzachter.Size = new System.Drawing.Size(112, 88);
            this.btnVeelzachter.TabIndex = 1;
            this.btnVeelzachter.Text = "Veel zachter";
            this.btnVeelzachter.UseVisualStyleBackColor = true;
            this.btnVeelzachter.Click += new System.EventHandler(this.btnVeelzachter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 179);
            this.Controls.Add(this.btnVeelzachter);
            this.Controls.Add(this.btnVeelharder);
            this.Controls.Add(this.btnZachter);
            this.Controls.Add(this.btnHarder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Volume";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHarder;
        private System.Windows.Forms.Button btnZachter;
        private System.Windows.Forms.Button btnVeelharder;
        private System.Windows.Forms.Button btnVeelzachter;
    }
}

