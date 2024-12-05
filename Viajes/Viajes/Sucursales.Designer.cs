namespace Viajes
{
    partial class Sucursales
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
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDir = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            sucursalesBindingSource1 = new BindingSource(components);
            comboBox2 = new ComboBox();
            sucursalesBindingSource = new BindingSource(components);
            btnAcceder = new Button();
            label6 = new Label();
            txtDis = new TextBox();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)sucursalesBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sucursalesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.InactiveCaption;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Cursor = Cursors.Hand;
            txtName.ForeColor = SystemColors.InactiveCaptionText;
            txtName.Location = new Point(161, 133);
            txtName.MaxLength = 100;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(93, 136);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(86, 232);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 7;
            label2.Text = "Sucursal";
            // 
            // txtDir
            // 
            txtDir.BackColor = SystemColors.InactiveCaption;
            txtDir.BorderStyle = BorderStyle.FixedSingle;
            txtDir.Cursor = Cursors.Hand;
            txtDir.ForeColor = SystemColors.InactiveCaptionText;
            txtDir.Location = new Point(161, 166);
            txtDir.MaxLength = 250;
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(300, 27);
            txtDir.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(82, 164);
            label3.Name = "label3";
            label3.Size = new Size(73, 24);
            label3.TabIndex = 9;
            label3.Text = "Direccion";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.InactiveCaption;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Cursor = Cursors.Hand;
            txtID.ForeColor = SystemColors.InactiveCaptionText;
            txtID.Location = new Point(161, 100);
            txtID.MaxLength = 13;
            txtID.Name = "txtID";
            txtID.Size = new Size(300, 27);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(84, 103);
            label4.Name = "label4";
            label4.Size = new Size(71, 24);
            label4.TabIndex = 11;
            label4.Text = "Identidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(101, 198);
            label5.Name = "label5";
            label5.Size = new Size(54, 24);
            label5.TabIndex = 13;
            label5.Text = "Ciudad";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 20;
            comboBox1.Location = new Point(161, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // sucursalesBindingSource1
            // 
            sucursalesBindingSource1.DataSource = typeof(Sucursales);
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.InactiveCaption;
            comboBox2.FormattingEnabled = true;
            comboBox2.ItemHeight = 20;
            comboBox2.Location = new Point(161, 233);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(300, 28);
            comboBox2.TabIndex = 5;
            // 
            // sucursalesBindingSource
            // 
            sucursalesBindingSource.DataSource = typeof(Sucursales);
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = SystemColors.ButtonShadow;
            btnAcceder.Cursor = Cursors.Hand;
            btnAcceder.FlatStyle = FlatStyle.Popup;
            btnAcceder.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = SystemColors.Highlight;
            btnAcceder.Location = new Point(318, 316);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(143, 50);
            btnAcceder.TabIndex = 17;
            btnAcceder.Text = "Guardar";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDark;
            label6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(161, 9);
            label6.Name = "label6";
            label6.Size = new Size(281, 24);
            label6.TabIndex = 18;
            label6.Text = "Datos del Empleado y Sucursal Asignada";
            // 
            // txtDis
            // 
            txtDis.BackColor = SystemColors.InactiveCaption;
            txtDis.BorderStyle = BorderStyle.FixedSingle;
            txtDis.Cursor = Cursors.Hand;
            txtDis.ForeColor = SystemColors.InactiveCaptionText;
            txtDis.Location = new Point(161, 267);
            txtDis.MaxLength = 2;
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(300, 27);
            txtDis.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDark;
            label7.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(54, 265);
            label7.Name = "label7";
            label7.Size = new Size(101, 24);
            label7.TabIndex = 19;
            label7.Text = "Distancia(KM)";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(54, 44);
            button1.TabIndex = 20;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Sucursales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(555, 391);
            Controls.Add(button1);
            Controls.Add(txtDis);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnAcceder);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(txtDir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Sucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sucursales";
            Load += Sucursales_Load;
            ((System.ComponentModel.ISupportInitialize)sucursalesBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sucursalesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtDir;
        private Label label3;
        private TextBox txtID;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private BindingSource sucursalesBindingSource1;
        private BindingSource sucursalesBindingSource;
        private Button btnAcceder;
        private Label label6;
        private TextBox txtDis;
        private Label label7;
        private Button button1;
    }
}