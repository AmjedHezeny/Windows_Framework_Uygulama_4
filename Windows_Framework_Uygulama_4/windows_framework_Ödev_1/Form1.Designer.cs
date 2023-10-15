namespace windows_framework_Ödev_1
{
    partial class windows_framework_Ödev_1
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
            this.List_Box_Ödevi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // List_Box_Ödevi
            // 
            this.List_Box_Ödevi.BackColor = System.Drawing.Color.MediumPurple;
            this.List_Box_Ödevi.Font = new System.Drawing.Font("Segoe Print", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_Box_Ödevi.ForeColor = System.Drawing.Color.White;
            this.List_Box_Ödevi.Location = new System.Drawing.Point(288, 344);
            this.List_Box_Ödevi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.List_Box_Ödevi.Name = "List_Box_Ödevi";
            this.List_Box_Ödevi.Size = new System.Drawing.Size(340, 187);
            this.List_Box_Ödevi.TabIndex = 0;
            this.List_Box_Ödevi.Text = "List Box Ödevi";
            this.List_Box_Ödevi.UseVisualStyleBackColor = false;
            this.List_Box_Ödevi.Click += new System.EventHandler(this.List_Box_Ödevi_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Algerian", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 228);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hos Geldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windows_framework_Ödev_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(910, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_Box_Ödevi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "windows_framework_Ödev_1";
            this.Text = "windows_framework_Ödev_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button List_Box_Ödevi;
        private System.Windows.Forms.Label label1;
    }
}

