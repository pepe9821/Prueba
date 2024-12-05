namespace Viajes
{
    partial class ViajeG
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
            label6 = new Label();
            comboBox1 = new ComboBox();
            txtID = new TextBox();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(12, 16);
            button1.Name = "button1";
            button1.Size = new Size(54, 44);
            button1.TabIndex = 40;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDark;
            label6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(119, 26);
            label6.Name = "label6";
            label6.Size = new Size(124, 24);
            label6.TabIndex = 39;
            label6.Text = "Creacion de Viaje";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 20;
            comboBox1.Location = new Point(119, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 28);
            comboBox1.TabIndex = 36;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.InactiveCaption;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Cursor = Cursors.Hand;
            txtID.ForeColor = SystemColors.InactiveCaptionText;
            txtID.Location = new Point(119, 78);
            txtID.MaxLength = 13;
            txtID.Name = "txtID";
            txtID.Size = new Size(300, 27);
            txtID.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(3, 81);
            label4.Name = "label4";
            label4.Size = new Size(110, 24);
            label4.TabIndex = 38;
            label4.Text = "Codigo de Viaje";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(17, 114);
            label1.Name = "label1";
            label1.Size = new Size(96, 24);
            label1.TabIndex = 37;
            label1.Text = "Transportista";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(436, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(365, 237);
            dataGridView1.TabIndex = 34;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(323, 205);
            button2.Name = "button2";
            button2.Size = new Size(96, 44);
            button2.TabIndex = 41;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ViajeG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(825, 283);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ViajeG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViajeG";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox txtID;
        private Label label4;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}