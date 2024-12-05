namespace Viajes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAcceder = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtCont = new TextBox();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = SystemColors.ButtonShadow;
            btnAcceder.Cursor = Cursors.Hand;
            btnAcceder.FlatStyle = FlatStyle.Popup;
            btnAcceder.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = SystemColors.Highlight;
            btnAcceder.Location = new Point(98, 223);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(143, 50);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(60, 92);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 215);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(35, 147);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.InactiveCaption;
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Cursor = Cursors.Hand;
            txtUser.ForeColor = SystemColors.InactiveCaptionText;
            txtUser.Location = new Point(125, 89);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 27);
            txtUser.TabIndex = 4;
            // 
            // txtCont
            // 
            txtCont.BackColor = SystemColors.InactiveCaption;
            txtCont.BorderStyle = BorderStyle.FixedSingle;
            txtCont.Cursor = Cursors.Hand;
            txtCont.Location = new Point(125, 147);
            txtCont.Name = "txtCont";
            txtCont.PasswordChar = '*';
            txtCont.Size = new Size(125, 27);
            txtCont.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(314, 333);
            Controls.Add(txtCont);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAcceder);
            Cursor = Cursors.Hand;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceder;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtCont;
    }
}
