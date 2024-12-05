
namespace Viajes
{
    partial class Rviajes
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
            dataGridView1 = new DataGridView();
            txtPre = new TextBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            txtID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtDist = new TextBox();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            txtFil = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(431, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(623, 218);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtPre
            // 
            txtPre.BackColor = SystemColors.InactiveCaption;
            txtPre.BorderStyle = BorderStyle.FixedSingle;
            txtPre.Cursor = Cursors.Hand;
            txtPre.ForeColor = SystemColors.InactiveCaptionText;
            txtPre.Location = new Point(119, 241);
            txtPre.MaxLength = 3;
            txtPre.Name = "txtPre";
            txtPre.Size = new Size(300, 27);
            txtPre.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDark;
            label7.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(60, 239);
            label7.Name = "label7";
            label7.Size = new Size(53, 24);
            label7.TabIndex = 31;
            label7.Text = "Precio";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.InactiveCaption;
            comboBox2.FormattingEnabled = true;
            comboBox2.ItemHeight = 20;
            comboBox2.Location = new Point(119, 140);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(300, 28);
            comboBox2.TabIndex = 24;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 20;
            comboBox1.Location = new Point(119, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 28);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(59, 172);
            label5.Name = "label5";
            label5.Size = new Size(49, 24);
            label5.TabIndex = 30;
            label5.Text = "Fecha";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.InactiveCaption;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Cursor = Cursors.Hand;
            txtID.ForeColor = SystemColors.InactiveCaptionText;
            txtID.Location = new Point(119, 74);
            txtID.MaxLength = 13;
            txtID.Name = "txtID";
            txtID.Size = new Size(300, 27);
            txtID.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(3, 77);
            label4.Name = "label4";
            label4.Size = new Size(110, 24);
            label4.TabIndex = 29;
            label4.Text = "Codigo de Viaje";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(44, 138);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 28;
            label3.Text = "Sucursal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(37, 110);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 25;
            label1.Text = "Empleado";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDark;
            label6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(119, 12);
            label6.Name = "label6";
            label6.Size = new Size(281, 24);
            label6.TabIndex = 32;
            label6.Text = "Datos del Empleado y Sucursal Asignada";
            label6.Click += label6_Click;
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
            button1.TabIndex = 33;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(323, 310);
            button2.Name = "button2";
            button2.Size = new Size(96, 44);
            button2.TabIndex = 34;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.ActiveCaption;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.ActiveCaption;
            dateTimePicker1.Location = new Point(119, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 27);
            dateTimePicker1.TabIndex = 36;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtDist
            // 
            txtDist.BackColor = SystemColors.InactiveCaption;
            txtDist.BorderStyle = BorderStyle.FixedSingle;
            txtDist.Cursor = Cursors.Hand;
            txtDist.ForeColor = SystemColors.InactiveCaptionText;
            txtDist.Location = new Point(119, 208);
            txtDist.MaxLength = 2;
            txtDist.Name = "txtDist";
            txtDist.Size = new Size(300, 27);
            txtDist.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(42, 206);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 39;
            label2.Text = "Distancia";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(431, 10);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(329, 204);
            dataGridView2.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlDark;
            label8.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(839, 192);
            label8.Name = "label8";
            label8.Size = new Size(45, 24);
            label8.TabIndex = 42;
            label8.Text = "Filtro";
            // 
            // txtFil
            // 
            txtFil.BackColor = SystemColors.InactiveCaption;
            txtFil.BorderStyle = BorderStyle.FixedSingle;
            txtFil.Cursor = Cursors.Hand;
            txtFil.ForeColor = SystemColors.InactiveCaptionText;
            txtFil.Location = new Point(890, 187);
            txtFil.MaxLength = 50;
            txtFil.Name = "txtFil";
            txtFil.Size = new Size(164, 27);
            txtFil.TabIndex = 43;
            txtFil.TextChanged += txtFil_TextChanged;
            // 
            // Rviajes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1066, 450);
            Controls.Add(txtFil);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(txtDist);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtPre);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Rviajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rviajes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtPre;
        private Label label7;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label6;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtDist;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label8;
        private TextBox txtFil;
    }
}