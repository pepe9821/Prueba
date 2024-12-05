namespace Viajes
{
    partial class Transportistas
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
            button1 = new Button();
            btnRVD = new Button();
            btnRV = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(54, 44);
            button1.TabIndex = 24;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRVD
            // 
            btnRVD.BackColor = SystemColors.ButtonShadow;
            btnRVD.Cursor = Cursors.Hand;
            btnRVD.FlatStyle = FlatStyle.Popup;
            btnRVD.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRVD.ForeColor = SystemColors.Highlight;
            btnRVD.Location = new Point(74, 152);
            btnRVD.Name = "btnRVD";
            btnRVD.Size = new Size(226, 50);
            btnRVD.TabIndex = 23;
            btnRVD.Text = "Estadisticas Conductores";
            btnRVD.UseVisualStyleBackColor = false;
            btnRVD.Click += btnRVD_Click;
            // 
            // btnRV
            // 
            btnRV.BackColor = SystemColors.ButtonShadow;
            btnRV.Cursor = Cursors.Hand;
            btnRV.FlatStyle = FlatStyle.Popup;
            btnRV.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRV.ForeColor = SystemColors.Highlight;
            btnRV.Location = new Point(74, 74);
            btnRV.Name = "btnRV";
            btnRV.Size = new Size(226, 50);
            btnRV.TabIndex = 22;
            btnRV.Text = "Registrar Conductor";
            btnRV.UseVisualStyleBackColor = false;
            btnRV.Click += btnRV_Click;
            // 
            // Transportistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(357, 268);
            Controls.Add(button1);
            Controls.Add(btnRVD);
            Controls.Add(btnRV);
            Name = "Transportistas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transportistas";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnRVD;
        private Button btnRV;
    }
}