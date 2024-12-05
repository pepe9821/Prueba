namespace Viajes
{
    partial class Home
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
            btnSuc = new Button();
            btnViajes = new Button();
            btnTrs = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSuc
            // 
            btnSuc.BackColor = SystemColors.ButtonShadow;
            btnSuc.Cursor = Cursors.Hand;
            btnSuc.FlatStyle = FlatStyle.Popup;
            btnSuc.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuc.ForeColor = SystemColors.Highlight;
            btnSuc.Location = new Point(66, 51);
            btnSuc.Name = "btnSuc";
            btnSuc.Size = new Size(143, 50);
            btnSuc.TabIndex = 1;
            btnSuc.Text = "Sucursales";
            btnSuc.UseVisualStyleBackColor = false;
            btnSuc.Click += btnSuc_Click;
            // 
            // btnViajes
            // 
            btnViajes.BackColor = SystemColors.ButtonShadow;
            btnViajes.Cursor = Cursors.Hand;
            btnViajes.FlatStyle = FlatStyle.Popup;
            btnViajes.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViajes.ForeColor = SystemColors.Highlight;
            btnViajes.Location = new Point(66, 151);
            btnViajes.Name = "btnViajes";
            btnViajes.Size = new Size(143, 50);
            btnViajes.TabIndex = 5;
            btnViajes.Text = "Viajes";
            btnViajes.UseVisualStyleBackColor = false;
            btnViajes.Click += btnViajes_Click;
            // 
            // btnTrs
            // 
            btnTrs.BackColor = SystemColors.ButtonShadow;
            btnTrs.Cursor = Cursors.Hand;
            btnTrs.FlatStyle = FlatStyle.Popup;
            btnTrs.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrs.ForeColor = SystemColors.Highlight;
            btnTrs.Location = new Point(66, 254);
            btnTrs.Name = "btnTrs";
            btnTrs.Size = new Size(143, 50);
            btnTrs.TabIndex = 6;
            btnTrs.Text = "Transportistas";
            btnTrs.UseVisualStyleBackColor = false;
            btnTrs.Click += btnTrs_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(283, 338);
            Controls.Add(label1);
            Controls.Add(btnTrs);
            Controls.Add(btnViajes);
            Controls.Add(btnSuc);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuc;
        private Button btnViajes;
        private Button btnTrs;
        private Label label1;
    }
}