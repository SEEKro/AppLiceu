namespace ClienRamade.Forms
{
    partial class elev_form
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
            this.check_all = new System.Windows.Forms.CheckBox();
            this.radio_note = new System.Windows.Forms.RadioButton();
            this.radio_absente = new System.Windows.Forms.RadioButton();
            this.box_materii = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.date_pick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // check_all
            // 
            this.check_all.AutoSize = true;
            this.check_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_all.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.check_all.Location = new System.Drawing.Point(94, 485);
            this.check_all.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_all.Name = "check_all";
            this.check_all.Size = new System.Drawing.Size(482, 50);
            this.check_all.TabIndex = 11;
            this.check_all.Text = "Selectati toate materiile";
            this.check_all.UseVisualStyleBackColor = true;
            this.check_all.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radio_note
            // 
            this.radio_note.AutoSize = true;
            this.radio_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_note.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radio_note.Location = new System.Drawing.Point(474, 221);
            this.radio_note.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_note.Name = "radio_note";
            this.radio_note.Size = new System.Drawing.Size(121, 48);
            this.radio_note.TabIndex = 10;
            this.radio_note.TabStop = true;
            this.radio_note.Text = "Note";
            this.radio_note.UseVisualStyleBackColor = true;
            this.radio_note.CheckedChanged += new System.EventHandler(this.radio_note_CheckedChanged);
            // 
            // radio_absente
            // 
            this.radio_absente.AutoSize = true;
            this.radio_absente.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_absente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radio_absente.Location = new System.Drawing.Point(474, 301);
            this.radio_absente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_absente.Name = "radio_absente";
            this.radio_absente.Size = new System.Drawing.Size(180, 48);
            this.radio_absente.TabIndex = 9;
            this.radio_absente.TabStop = true;
            this.radio_absente.Text = "Absente";
            this.radio_absente.UseVisualStyleBackColor = true;
            this.radio_absente.CheckedChanged += new System.EventHandler(this.radio_absente_CheckedChanged);
            // 
            // box_materii
            // 
            this.box_materii.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.box_materii.FormattingEnabled = true;
            this.box_materii.ItemHeight = 16;
            this.box_materii.Location = new System.Drawing.Point(190, 169);
            this.box_materii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.box_materii.Name = "box_materii";
            this.box_materii.Size = new System.Drawing.Size(258, 308);
            this.box_materii.TabIndex = 8;
            this.box_materii.SelectedIndexChanged += new System.EventHandler(this.box_materii_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(697, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 418);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(239, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "-Materii-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(755, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 44);
            this.label2.TabIndex = 13;
            this.label2.Text = "-Informatii-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(189)))), ((int)(((byte)(166)))));
            this.pictureBox1.Image = global::ClienRamade.Properties.Resources.Pingu;
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 148);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(1032, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 38;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // date_pick
            // 
            this.date_pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_pick.Location = new System.Drawing.Point(247, 26);
            this.date_pick.Margin = new System.Windows.Forms.Padding(4);
            this.date_pick.Name = "date_pick";
            this.date_pick.Size = new System.Drawing.Size(612, 49);
            this.date_pick.TabIndex = 39;
            // 
            // elev_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(189)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1143, 576);
            this.Controls.Add(this.date_pick);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_all);
            this.Controls.Add(this.radio_note);
            this.Controls.Add(this.radio_absente);
            this.Controls.Add(this.box_materii);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "elev_form";
            this.Text = "elev_form";
            this.Load += new System.EventHandler(this.elev_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_all;
        private System.Windows.Forms.RadioButton radio_note;
        private System.Windows.Forms.RadioButton radio_absente;
        private System.Windows.Forms.ListBox box_materii;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker date_pick;
    }
}