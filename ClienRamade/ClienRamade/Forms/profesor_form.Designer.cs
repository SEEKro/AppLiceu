namespace ClienRamade.Forms
{
    partial class profesor_form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.note_drop = new System.Windows.Forms.ComboBox();
            this.elevi_box = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.clasa_drop = new System.Windows.Forms.ComboBox();
            this.absenta_radio = new System.Windows.Forms.RadioButton();
            this.nota_radio = new System.Windows.Forms.RadioButton();
            this.date_pick = new System.Windows.Forms.DateTimePicker();
            this.materii_drop = new System.Windows.Forms.ComboBox();
            this.elev_dataGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elev_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 717);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(189)))), ((int)(((byte)(166)))));
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.note_drop);
            this.tabPage1.Controls.Add(this.elevi_box);
            this.tabPage1.Controls.Add(this.add_button);
            this.tabPage1.Controls.Add(this.clasa_drop);
            this.tabPage1.Controls.Add(this.absenta_radio);
            this.tabPage1.Controls.Add(this.nota_radio);
            this.tabPage1.Controls.Add(this.date_pick);
            this.tabPage1.Controls.Add(this.materii_drop);
            this.tabPage1.Controls.Add(this.elev_dataGrid);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1069, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(941, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 37;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(721, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = "Informatii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(117, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Elevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(74, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Clasa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(458, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(248, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Materii";
            // 
            // note_drop
            // 
            this.note_drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_drop.FormattingEnabled = true;
            this.note_drop.Location = new System.Drawing.Point(464, 219);
            this.note_drop.Margin = new System.Windows.Forms.Padding(4);
            this.note_drop.Name = "note_drop";
            this.note_drop.Size = new System.Drawing.Size(84, 39);
            this.note_drop.TabIndex = 20;
            // 
            // elevi_box
            // 
            this.elevi_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elevi_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.elevi_box.FormattingEnabled = true;
            this.elevi_box.ItemHeight = 36;
            this.elevi_box.Location = new System.Drawing.Point(54, 330);
            this.elevi_box.Margin = new System.Windows.Forms.Padding(4);
            this.elevi_box.MultiColumn = true;
            this.elevi_box.Name = "elevi_box";
            this.elevi_box.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.elevi_box.Size = new System.Drawing.Size(284, 328);
            this.elevi_box.TabIndex = 19;
            this.elevi_box.SelectedIndexChanged += new System.EventHandler(this.elevi_box_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add_button.Location = new System.Drawing.Point(374, 537);
            this.add_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(223, 73);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "Insert";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click_1);
            // 
            // clasa_drop
            // 
            this.clasa_drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clasa_drop.FormattingEnabled = true;
            this.clasa_drop.Location = new System.Drawing.Point(80, 219);
            this.clasa_drop.Margin = new System.Windows.Forms.Padding(4);
            this.clasa_drop.Name = "clasa_drop";
            this.clasa_drop.Size = new System.Drawing.Size(84, 39);
            this.clasa_drop.TabIndex = 17;
            this.clasa_drop.SelectedIndexChanged += new System.EventHandler(this.clasa_drop_SelectedIndexChanged);
            // 
            // absenta_radio
            // 
            this.absenta_radio.AutoSize = true;
            this.absenta_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absenta_radio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.absenta_radio.Location = new System.Drawing.Point(402, 360);
            this.absenta_radio.Margin = new System.Windows.Forms.Padding(4);
            this.absenta_radio.Name = "absenta_radio";
            this.absenta_radio.Size = new System.Drawing.Size(146, 40);
            this.absenta_radio.TabIndex = 16;
            this.absenta_radio.TabStop = true;
            this.absenta_radio.Text = "Absenta";
            this.absenta_radio.UseVisualStyleBackColor = true;
            this.absenta_radio.CheckedChanged += new System.EventHandler(this.absenta_radio_CheckedChanged);
            // 
            // nota_radio
            // 
            this.nota_radio.AutoSize = true;
            this.nota_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota_radio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nota_radio.Location = new System.Drawing.Point(402, 440);
            this.nota_radio.Margin = new System.Windows.Forms.Padding(4);
            this.nota_radio.Name = "nota_radio";
            this.nota_radio.Size = new System.Drawing.Size(99, 40);
            this.nota_radio.TabIndex = 15;
            this.nota_radio.TabStop = true;
            this.nota_radio.Text = "Nota";
            this.nota_radio.UseVisualStyleBackColor = true;
            this.nota_radio.CheckedChanged += new System.EventHandler(this.nota_radio_CheckedChanged);
            // 
            // date_pick
            // 
            this.date_pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_pick.Location = new System.Drawing.Point(275, 37);
            this.date_pick.Margin = new System.Windows.Forms.Padding(4);
            this.date_pick.Name = "date_pick";
            this.date_pick.Size = new System.Drawing.Size(612, 49);
            this.date_pick.TabIndex = 14;
            // 
            // materii_drop
            // 
            this.materii_drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materii_drop.FormattingEnabled = true;
            this.materii_drop.Location = new System.Drawing.Point(190, 219);
            this.materii_drop.Margin = new System.Windows.Forms.Padding(4);
            this.materii_drop.Name = "materii_drop";
            this.materii_drop.Size = new System.Drawing.Size(240, 39);
            this.materii_drop.TabIndex = 12;
            // 
            // elev_dataGrid
            // 
            this.elev_dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.elev_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elev_dataGrid.Location = new System.Drawing.Point(633, 149);
            this.elev_dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.elev_dataGrid.Name = "elev_dataGrid";
            this.elev_dataGrid.Size = new System.Drawing.Size(324, 509);
            this.elev_dataGrid.StandardTab = true;
            this.elev_dataGrid.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(189)))), ((int)(((byte)(166)))));
            this.pictureBox1.Image = global::ClienRamade.Properties.Resources.Pingu;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 148);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1069, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // profesor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 715);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "profesor_form";
            this.Text = "profesor_form";
            this.Load += new System.EventHandler(this.profesor_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elev_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox clasa_drop;
        private System.Windows.Forms.RadioButton absenta_radio;
        private System.Windows.Forms.RadioButton nota_radio;
        private System.Windows.Forms.DateTimePicker date_pick;
        private System.Windows.Forms.ComboBox materii_drop;
        private System.Windows.Forms.DataGridView elev_dataGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox elevi_box;
        private System.Windows.Forms.ComboBox note_drop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}