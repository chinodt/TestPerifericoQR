namespace TestLectoraCodigo
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPuerto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 50);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(510, 133);
            this.txtContent.TabIndex = 0;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(447, 189);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 1;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduzca Puerto";
            // 
            // cboPuerto
            // 
            this.cboPuerto.FormattingEnabled = true;
            this.cboPuerto.Location = new System.Drawing.Point(106, 19);
            this.cboPuerto.Name = "cboPuerto";
            this.cboPuerto.Size = new System.Drawing.Size(121, 21);
            this.cboPuerto.TabIndex = 3;
            this.cboPuerto.SelectedIndexChanged += new System.EventHandler(this.cboPuerto_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 222);
            this.Controls.Add(this.cboPuerto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.txtContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPuerto;
    }
}

