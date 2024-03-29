﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienRamade.Forms
{
    public partial class profesor_form : Form
    {
        private ClienRamade.ServiceReference1.WebServiceSoapClient service;
        private DataSet materiiDataSet, claseDataSet, eleviDataSet, noteDataSet, absenteDataSet;
        private string username;

        //Configs
        private void configureDataGrid(string dataType, DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            if (dataType.Equals("absente"))
            {

                dgv.DataSource = null;
                dgv.ColumnCount = 3;

                dgv.Columns[0].Name = "NumeMaterie";
                dgv.Columns[0].HeaderText = "Nume Materie";
                dgv.Columns[0].DataPropertyName = "nume_materie";

                dgv.Columns[1].Name = "Data";
                dgv.Columns[1].HeaderText = "Data";
                dgv.Columns[1].DataPropertyName = "data";

                dgv.Columns[2].Name = "Motivatie";
                dgv.Columns[2].HeaderText = "Motivatie";
                dgv.Columns[2].DataPropertyName = "motivatie";
            }

            if (dataType.Equals("note"))
            {
                dgv.DataSource = null;
                dgv.ColumnCount = 3;

                dgv.Columns[0].Name = "Materie";
                dgv.Columns[0].HeaderText = "Materie";
                dgv.Columns[0].DataPropertyName = "materie";

                dgv.Columns[1].Name = "Nota";
                dgv.Columns[1].HeaderText = "nota";
                dgv.Columns[1].DataPropertyName = "nota";

                dgv.Columns[2].Name = "Data";
                dgv.Columns[2].HeaderText = "Data";
                dgv.Columns[2].DataPropertyName = "data";

            }
        }

        //Populate methods
        private void populateDropDown(ComboBox cb, DataSet ds, string fieldName)
        {
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                cb.Items.Add((string)dr[fieldName].ToString());
            }
        }

        private void populateListBox(ListBox lb, DataSet ds, string fieldName)
        {
            lb.DataSource = ds.Tables[0];
            lb.DisplayMember = fieldName;
        }

        private void populateGridView(DataGridView dgw, string dataType)
        {
            try
            {
                if (dataType.Equals("note") && eleviDataSet!= null)
                {
                    noteDataSet = service.getGradesByUser(eleviDataSet.Tables[0].Rows[elevi_box.SelectedIndex]["username"].ToString());
                    if(noteDataSet != null)
                        dgw.DataSource = noteDataSet.Tables[0];
                }
                if (dataType.Equals("absente") && eleviDataSet != null)
                {
                    absenteDataSet = service.getAbsente(eleviDataSet.Tables[0].Rows[elevi_box.SelectedIndex]["username"].ToString());
                    if(absenteDataSet != null)
                        dgw.DataSource = absenteDataSet.Tables[0];
                }
            }
            catch(Exception ex)
            {
                string err = ex.GetType().ToString();
            }
        }

        private void populateNoteDrop(ComboBox cb)
        {
            for(int i = 1; i<11; i++)
            {
                cb.Items.Add(i);
            }
        }

        //Handlers
        private void populateDataGridHandler()
        {
            if (nota_radio.Checked)
            {
                configureDataGrid("note", elev_dataGrid);
                populateGridView(elev_dataGrid, "note");
            }
            if (absenta_radio.Checked)
            {
                configureDataGrid("absente", elev_dataGrid);
                populateGridView(elev_dataGrid, "absente");
            }
        }

        public profesor_form(string username)
        {
            InitializeComponent();
            this.username = username;
            service = new ClienRamade.ServiceReference1.WebServiceSoapClient();

            claseDataSet = service.getClase();
            populateDropDown(clasa_drop,
                             claseDataSet,
                             "nume");

            materiiDataSet = service.getMaterii();
            populateDropDown(materii_drop,
                             materiiDataSet,
                             "nume");

            populateNoteDrop(note_drop);
        }

        //Events
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void elevi_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateDataGridHandler();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRowView item in elevi_box.SelectedItems)
                {
                    if (nota_radio.Checked)
                    {
                        service.insertGrade(username,
                                            eleviDataSet.Tables[0].Rows[elevi_box.FindString(item["nume"].ToString())]["username"].ToString(),
                                            materii_drop.SelectedItem.ToString(),
                                            Convert.ToUInt16(note_drop.SelectedItem),
                                            date_pick.Value.ToString());
                    }
                    if (absenta_radio.Checked)
                    {
                        service.insertAbsenta(eleviDataSet.Tables[0].Rows[elevi_box.FindString(item["nume"].ToString())]["username"].ToString(),
                                              materii_drop.SelectedItem.ToString(),
                                              date_pick.Value.ToString());
                    }
                }
                populateDataGridHandler();
            }
            catch (NullReferenceException ex)
            {
                string error = ex.GetType().ToString();
            }
        }

        private void add_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRowView item in elevi_box.SelectedItems)
                {
                    if (nota_radio.Checked)
                    {
                        service.insertGrade(username,
                                            eleviDataSet.Tables[0].Rows[elevi_box.FindString(item["nume"].ToString())]["username"].ToString(),
                                            materii_drop.SelectedItem.ToString(),
                                            Convert.ToUInt16(note_drop.SelectedItem),
                                            date_pick.Value.ToString());
                    }
                    if (absenta_radio.Checked)
                    {
                        service.insertAbsenta(eleviDataSet.Tables[0].Rows[elevi_box.FindString(item["nume"].ToString())]["username"].ToString(),
                                              materii_drop.SelectedItem.ToString(),
                                              date_pick.Value.ToString());
                    }
                }
                populateDataGridHandler();
            }
            catch (NullReferenceException ex)
            {
                string error = ex.GetType().ToString();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void nota_radio_CheckedChanged(object sender, EventArgs e)
        {
            absenta_radio.Checked = false;
            note_drop.Enabled = true;
            populateDataGridHandler();
        }

        private void absenta_radio_CheckedChanged(object sender, EventArgs e)
        {
            nota_radio.Checked = false;
            note_drop.Enabled = false;
            populateDataGridHandler();
        }

        private void profesor_form_Load(object sender, EventArgs e)
        {

        }

        private void clasa_drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            eleviDataSet = service.getEleviByClasa(Convert.ToInt32(claseDataSet.Tables[0].Rows[clasa_drop.SelectedIndex]["id"]));
            populateListBox(elevi_box,
                            eleviDataSet,
                            "nume");
        }
    }
}
