namespace Viajes
{
    partial class RTrans
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
            txtID = new TextBox();
            label4 = new Label();
            txtNom = new TextBox();
            label1 = new Label();
            txtTar = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.InactiveCaption;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Cursor = Cursors.Hand;
            txtID.ForeColor = SystemColors.InactiveCaptionText;
            txtID.Location = new Point(200, 80);
            txtID.MaxLength = 13;
            txtID.Name = "txtID";
            txtID.Size = new Size(300, 27);
            txtID.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(30, 83);
            label4.Name = "label4";
            label4.Size = new Size(164, 24);
            label4.TabIndex = 32;
            label4.Text = "Codigo de Transportista";
            // 
            // txtNom
            // 
            txtNom.BackColor = SystemColors.InactiveCaption;
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.Cursor = Cursors.Hand;
            txtNom.ForeColor = SystemColors.InactiveCaptionText;
            txtNom.Location = new Point(200, 113);
            txtNom.MaxLength = 100;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(300, 27);
            txtNom.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(132, 116);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 34;
            label1.Text = "Nombre";
            // 
            // txtTar
            // 
            txtTar.BackColor = SystemColors.InactiveCaption;
            txtTar.BorderStyle = BorderStyle.FixedSingle;
            txtTar.Cursor = Cursors.Hand;
            txtTar.ForeColor = SystemColors.InactiveCaptionText;
            txtTar.Location = new Point(200, 146);
            txtTar.MaxLength = 5;
            txtTar.Name = "txtTar";
            txtTar.Size = new Size(300, 27);
            txtTar.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(97, 149);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 36;
            label2.Text = "Tarifa por KM";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(404, 193);
            button2.Name = "button2";
            button2.Size = new Size(96, 44);
            button2.TabIndex = 37;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button1.TabIndex = 38;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RTrans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(540, 275);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(txtTar);
            Controls.Add(label2);
            Controls.Add(txtNom);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(label4);
            Name = "RTrans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RTrans";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label label4;
        private TextBox txtNom;
        private Label label1;
        private TextBox txtTar;
        private Label label2;
        private Button button2;
        private Button button1;
    }
}