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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_button = new System.Windows.Forms.Button();
            this.clasa_drop = new System.Windows.Forms.ComboBox();
            this.absenta_radio = new System.Windows.Forms.RadioButton();
            this.nota_radio = new System.Windows.Forms.RadioButton();
            this.date_pick = new System.Windows.Forms.DateTimePicker();
            this.materii_drop = new System.Windows.Forms.ComboBox();
            this.elev_dataGrid = new System.Windows.Forms.DataGridView();
            this.elevi_box = new System.Windows.Forms.ListBox();
            this.note_drop = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elev_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Sienna;
            this.tabPage1.Controls.Add(this.note_drop);
            this.tabPage1.Controls.Add(this.elevi_box);
            this.tabPage1.Controls.Add(this.add_button);
            this.tabPage1.Controls.Add(this.clasa_drop);
            this.tabPage1.Controls.Add(this.absenta_radio);
            this.tabPage1.Controls.Add(this.nota_radio);
            this.tabPage1.Controls.Add(this.date_pick);
            this.tabPage1.Controls.Add(this.materii_drop);
            this.tabPage1.Controls.Add(this.elev_dataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(197, 189);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(167, 122);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "Insert";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // clasa_drop
            // 
            this.clasa_drop.FormattingEnabled = true;
            this.clasa_drop.Location = new System.Drawing.Point(300, 17);
            this.clasa_drop.Name = "clasa_drop";
            this.clasa_drop.Size = new System.Drawing.Size(64, 21);
            this.clasa_drop.TabIndex = 17;
            this.clasa_drop.SelectedIndexChanged += new System.EventHandler(this.clasa_drop_SelectedIndexChanged);
            // 
            // absenta_radio
            // 
            this.absenta_radio.AutoSize = true;
            this.absenta_radio.Location = new System.Drawing.Point(300, 153);
            this.absenta_radio.Name = "absenta_radio";
            this.absenta_radio.Size = new System.Drawing.Size(64, 17);
            this.absenta_radio.TabIndex = 16;
            this.absenta_radio.TabStop = true;
            this.absenta_radio.Text = "Absenta";
            this.absenta_radio.UseVisualStyleBackColor = true;
            this.absenta_radio.CheckedChanged += new System.EventHandler(this.absenta_radio_CheckedChanged);
            // 
            // nota_radio
            // 
            this.nota_radio.AutoSize = true;
            this.nota_radio.Location = new System.Drawing.Point(197, 153);
            this.nota_radio.Name = "nota_radio";
            this.nota_radio.Size = new System.Drawing.Size(48, 17);
            this.nota_radio.TabIndex = 15;
            this.nota_radio.TabStop = true;
            this.nota_radio.Text = "Nota";
            this.nota_radio.UseVisualStyleBackColor = true;
            this.nota_radio.CheckedChanged += new System.EventHandler(this.nota_radio_CheckedChanged);
            // 
            // date_pick
            // 
            this.date_pick.Location = new System.Drawing.Point(197, 113);
            this.date_pick.Name = "date_pick";
            this.date_pick.Size = new System.Drawing.Size(167, 20);
            this.date_pick.TabIndex = 14;
            // 
            // materii_drop
            // 
            this.materii_drop.FormattingEnabled = true;
            this.materii_drop.Location = new System.Drawing.Point(197, 62);
            this.materii_drop.Name = "materii_drop";
            this.materii_drop.Size = new System.Drawing.Size(167, 21);
            this.materii_drop.TabIndex = 12;
            // 
            // elev_dataGrid
            // 
            this.elev_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elev_dataGrid.Location = new System.Drawing.Point(393, 14);
            this.elev_dataGrid.Name = "elev_dataGrid";
            this.elev_dataGrid.Size = new System.Drawing.Size(240, 383);
            this.elev_dataGrid.StandardTab = true;
            this.elev_dataGrid.TabIndex = 11;
            // 
            // elevi_box
            // 
            this.elevi_box.FormattingEnabled = true;
            this.elevi_box.Location = new System.Drawing.Point(24, 17);
            this.elevi_box.MultiColumn = true;
            this.elevi_box.Name = "elevi_box";
            this.elevi_box.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.elevi_box.Size = new System.Drawing.Size(148, 381);
            this.elevi_box.TabIndex = 19;
            this.elevi_box.SelectedIndexChanged += new System.EventHandler(this.elevi_box_SelectedIndexChanged);
            // 
            // note_drop
            // 
            this.note_drop.FormattingEnabled = true;
            this.note_drop.Location = new System.Drawing.Point(197, 17);
            this.note_drop.Name = "note_drop";
            this.note_drop.Size = new System.Drawing.Size(64, 21);
            this.note_drop.TabIndex = 20;
            // 
            // profesor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "profesor_form";
            this.Text = "profesor_form";
            this.Load += new System.EventHandler(this.profesor_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elev_dataGrid)).EndInit();
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
    }
}