using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HealthRecords
{
    partial class OverviewForm : Form
    {
        private IFachkonzept fachkonzept;
        private List<Patient> patients = new List<Patient>();        

        public OverviewForm(IFachkonzept fachkonzept)
        {
            this.fachkonzept = fachkonzept;
            InitializeComponent();
            GetAllPatients();                  
        }

        private void GetAllPatients()
        {
            int setSize = 5;
            int lastID = 0;
            patients.Clear();
            Patient[] results;
            results = fachkonzept.GetPatients(setSize, lastID);
            while (results.Length > 0)
            {
                lastID = results.Last().PatientID;
                patients.AddRange(results);                
                results = fachkonzept.GetPatients(setSize, lastID);
            }
            patients.AddRange(results);
            //patientBindingSource.Clear();           
            patientBindingSource.DataSource = patients;
            patientBindingSource.ResetBindings(false);
              
        }

        private void OverviewForm_Load(object sender, EventArgs e)
        {    
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);  
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
              DataGridViewRow currRow = ((DataGridView)sender).CurrentRow;
              try
              {           	        
                    int patientID = Int32.Parse(currRow.Cells[0].Value.ToString());
                    string firstName = currRow.Cells[1].Value == null ? "" : currRow.Cells[1].Value.ToString();
                    string lastName = currRow.Cells[2].Value == null ? "" : currRow.Cells[2].Value.ToString();
                    DateTime birthdate;
                    DateTime.TryParse(currRow.Cells[3].Value.ToString(),out birthdate);
                    Patient patient = new Patient() { PatientID = patientID, FirstName = firstName, LastName = lastName, Birthday = birthdate };
                    fachkonzept.UpdatePatient(patient);               
	            }
	            catch (Exception ex)
	            {
                    MessageBox.Show(ex.Message);		            
	            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {            
            DataGridViewRow currRow = ((DataGridView)sender).CurrentRow;

            //MessageBox.Show(currRow.Cells[0].Value.ToString());
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = "";
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";            
            
            DateTime newDate;            
            if (dataGridView1.Rows[e.RowIndex].IsNewRow) { return; }
            // if not Date, then exit
            if (e.ColumnIndex == 3 && !String.IsNullOrWhiteSpace(e.FormattedValue.ToString()) )
            {
                if (!DateTime.TryParse(e.FormattedValue.ToString(), out newDate))
                {
                    e.Cancel = true;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = String.Format("Der Wert {0} ist kein gültiges Datum.", e.FormattedValue);
                    dataGridView1.Refresh();
                    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText,"Eingabefehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    SendKeys.Send("{ESC}");
                }
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {        
            Patient patient = new Patient();
            int patientsID = fachkonzept.CreatePatient(patient);
            patients.Add(new Patient() { PatientID = patientsID });
            patientBindingSource.ResetBindings(false);
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
            dataGridView1.BeginEdit(false);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.SelectedCells[0];
            dataGridView1.BeginEdit(false);
            //MessageBox.Show("Zum Bearbeiten der Patienten verwenden Sie bitte die obige Tabelle.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRow;
            switch (dataGridView1.SelectionMode)
            {
                case DataGridViewSelectionMode.CellSelect:
                    selectedRow = (int)dataGridView1.SelectedCells[0].RowIndex;                    
                    break;
                case DataGridViewSelectionMode.FullRowSelect:
                    selectedRow = (int)dataGridView1.SelectedRows[0].Index;
                    break;
                default:
                    return;                    
            }              
   
            int currPatientID = (int)dataGridView1.Rows[selectedRow].Cells[0].Value;
            string currFirstName = (string)dataGridView1.Rows[selectedRow].Cells[1].Value;
            string currLastName = (string)dataGridView1.Rows[selectedRow].Cells[2].Value;
            string message = String.Format("Möchten sie Patient {0} {1} mit der ID {2} wirklich löschen?", currFirstName, currLastName, currPatientID);
            if (MessageBox.Show(message,"Löschen",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fachkonzept.DeletePatient(new Patient() { PatientID = currPatientID });
                patients.RemoveAll(x => x.PatientID == currPatientID);
                patientBindingSource.ResetBindings(false);              
            }           
        }
    }
}
