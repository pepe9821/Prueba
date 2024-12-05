namespace Viajes
{
    partial class Estadisticas
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
            button1 = new Button();
            txtFil = new TextBox();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 168);
            dataGridView1.TabIndex = 0;
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
            button1.TabIndex = 39;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtFil
            // 
            txtFil.BackColor = SystemColors.InactiveCaption;
            txtFil.BorderStyle = BorderStyle.FixedSingle;
            txtFil.Cursor = Cursors.Hand;
            txtFil.ForeColor = SystemColors.InactiveCaptionText;
            txtFil.Location = new Point(624, 68);
            txtFil.MaxLength = 50;
            txtFil.Name = "txtFil";
            txtFil.Size = new Size(164, 27);
            txtFil.TabIndex = 45;
            txtFil.TextChanged += txtFil_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlDark;
            label8.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(492, 71);
            label8.Name = "label8";
            label8.Size = new Size(126, 24);
            label8.TabIndex = 44;
            label8.Text = "Filtro por nombre";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 285);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(776, 153);
            dataGridView2.TabIndex = 46;
            // 
            // Estadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(txtFil);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Estadisticas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtFil;
        private Label label8;
        private DataGridView dataGridView2;
    }
}