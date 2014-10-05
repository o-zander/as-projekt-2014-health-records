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
        private List<Illness> illnesses = new List<Illness>();
        private List<Illness> matchingIllnesses = new List<Illness>();
        private List<Patient> matchingPatients = new List<Patient>();
        private bool linkingActive = false;
        private bool lockTab = false;

        public OverviewForm(IFachkonzept fachkonzept)
        {
            this.fachkonzept = fachkonzept;
            InitializeComponent();
            GetPatients();
            GetIllnesses(); 
        }

        private void GetIllnesses()
        {
            int setSize = 5;
            long lastID = 0;
            illnesses.Clear();
            Illness[] results;
            results = fachkonzept.GetIllnesses(setSize, lastID);
            while (results.Length > 0)
            {
                lastID = results.Last().IllnessID;
                illnesses.AddRange(results);
                results = fachkonzept.GetIllnesses(setSize, lastID);
            }
            illnesses.AddRange(results);                  
            illnessBindingSource.DataSource = illnesses;
            illnessBindingSource.ResetBindings(false);

            // get matching patients
            Illness illness = illnesses.First();
            matchingPatients = fachkonzept.GetIllnessPatients(illness).ToList();
            matchingPatientBindingSource.DataSource = matchingPatients;
            matchingPatientBindingSource.ResetBindings(false);
        }

        private void GetPatients()
        {
            int setSize = 5;
            long lastID = 0;
            patients.Clear();
            // get all patients
            Patient[] results;
            results = fachkonzept.GetPatients(setSize, lastID);
            while (results.Length > 0)
            {
                lastID = results.Last().PatientID;
                patients.AddRange(results);                
                results = fachkonzept.GetPatients(setSize, lastID);
            }
            patients.AddRange(results);                
            patientBindingSource.DataSource = patients;
            patientBindingSource.ResetBindings(false);

            // get matching illnesses to first patient
            Patient patient = patients.First();
            matchingIllnesses = fachkonzept.GetPatientIllnesses(patient).ToList();
            matchingIllnessBindingSource.DataSource = matchingIllnesses;
            matchingIllnessBindingSource.ResetBindings(false);
        }

        private void OverviewForm_Load(object sender, EventArgs e)
        {    
            // events for patient
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // events for illness
            this.dataGridView3.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView3_CellValidating);
            this.dataGridView3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellValueChanged);
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
              DataGridViewRow currRow = ((DataGridView)sender).CurrentRow;
              try
              {           	        
                    long patientID = Int64.Parse(currRow.Cells[0].Value.ToString());
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
            matchingIllnesses.RemoveAll(x => x.IllnessID > 0);
            matchingIllnesses.AddRange(fachkonzept.GetPatientIllnesses(new Patient() { PatientID = Int64.Parse(currRow.Cells[0].Value.ToString()) }));            
            matchingIllnessBindingSource.ResetBindings(false);           
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = "";
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";            
            
            DateTime newDate;            
            if (dataGridView1.Rows[e.RowIndex].IsNewRow) { return; }

            // Check string length
            if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) && !String.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
            {
                if (e.FormattedValue.ToString().Length > 100)
                {
                    e.Cancel = true;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText =
                        String.Format("Es sind nur 100 Zeichen erlaubt. Zeichen: {0}", e.FormattedValue.ToString().Length);
                    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SendKeys.Send("{ESC}");

                }
            }

            // Check date
            if (e.ColumnIndex == 3 && !String.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
            {
                if (!DateTime.TryParse(e.FormattedValue.ToString(), out newDate))
                {
                    e.Cancel = true;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = String.Format("Der Wert {0} ist kein gültiges Datum.", e.FormattedValue);                    
                    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText,"Eingabefehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    SendKeys.Send("{ESC}");
                }
            }
        }

        private void createPatientBtn_Click(object sender, EventArgs e)
        {        
            Patient patient = new Patient();
            long patientsID = fachkonzept.CreatePatient(patient);
            patients.Add(new Patient() { PatientID = patientsID });
            patientBindingSource.ResetBindings(false);
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
            dataGridView1.BeginEdit(false);
        }

        private void editPatientBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].ColumnIndex == 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1];                 
            }
            else
            {
                dataGridView1.CurrentCell = dataGridView1.SelectedCells[0];                 
            }
            dataGridView1.BeginEdit(false);  
         
        }

        private void deletePatientBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = getSelectedRow(dataGridView1);
            long currPatientID = (long)dataGridView1.Rows[selectedRow].Cells[0].Value;
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

        private void createIllnessBtn_Click(object sender, EventArgs e)
        {
            Illness illness = new Illness();
            long illnessID = fachkonzept.CreateIllness(illness);
            illnesses.Add(new Illness() { IllnessID = illnessID });
            illnessBindingSource.ResetBindings(false);
            dataGridView3.CurrentCell = dataGridView3.Rows[dataGridView3.Rows.Count - 1].Cells[1];
            dataGridView3.BeginEdit(false);
        }

        private void editIllnessBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedCells[0].ColumnIndex == 0)
            {
                dataGridView3.CurrentCell = dataGridView3.Rows[dataGridView3.SelectedCells[0].RowIndex].Cells[1];
            }
            else
            {
                dataGridView3.CurrentCell = dataGridView3.SelectedCells[0];
            }
            dataGridView3.BeginEdit(false);  
        }

        private void deleteIllnessBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = getSelectedRow(dataGridView3);
            long currIllnessID = (long)dataGridView3.Rows[selectedRow].Cells[0].Value;
            string currName = (string)dataGridView3.Rows[selectedRow].Cells[1].Value;
            string currLastName = (string)dataGridView1.Rows[selectedRow].Cells[2].Value;
            string message = String.Format("Möchten sie Krankheit {0} mit der ID {1} wirklich löschen?", currName, currIllnessID);
            if (MessageBox.Show(message, "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fachkonzept.DeleteIllness(new Illness() { IllnessID = currIllnessID });
                illnesses.RemoveAll(x => x.IllnessID == currIllnessID);
                illnessBindingSource.ResetBindings(false);
            }     
        }

        private int getSelectedRow(DataGridView dataGridView)
        {
            switch (dataGridView.SelectionMode)
            {
                case DataGridViewSelectionMode.CellSelect:
                    return (int)dataGridView.SelectedCells[0].RowIndex;                    
                case DataGridViewSelectionMode.FullRowSelect:
                    return (int)dataGridView.SelectedRows[0].Index;                    
                default:
                    return -1;
            }
        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currRow = ((DataGridView)sender).CurrentRow;
            try
            {
                long illnessID = Int64.Parse(currRow.Cells[0].Value.ToString());
                string name = currRow.Cells[1].Value == null ? "" : currRow.Cells[1].Value.ToString();
                bool contagious = currRow.Cells[2].Value == null ? false : (bool)currRow.Cells[2].Value;
                bool lethal = currRow.Cells[3].Value == null ? false : (bool)currRow.Cells[3].Value;
                bool curable = currRow.Cells[4].Value == null ? false : (bool)currRow.Cells[4].Value;
                DateTime birthdate;
                DateTime.TryParse(currRow.Cells[3].Value.ToString(), out birthdate);
                Illness illness = new Illness() { IllnessID = illnessID, Name = name, Contagious=contagious, Lethal=lethal, Curable=curable };
                fachkonzept.UpdateIllness(illness);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView3.Rows[e.RowIndex].ErrorText = "";
            dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
            
            if (dataGridView3.Rows[e.RowIndex].IsNewRow) { return; }

            // Check string length
            if ((e.ColumnIndex == 1) && !String.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
            {
                if (e.FormattedValue.ToString().Length > 100)
                {
                    e.Cancel = true;
                    dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText =
                        String.Format("Es sind nur 100 Zeichen erlaubt. Zeichen: {0}", e.FormattedValue.ToString().Length);
                    MessageBox.Show(dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SendKeys.Send("{ESC}");
                }
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currRow = ((DataGridView)sender).CurrentRow;
            matchingPatients.RemoveAll(x => x.PatientID > 0);
            matchingPatients.AddRange(fachkonzept.GetIllnessPatients(new Illness() { IllnessID = Int64.Parse(currRow.Cells[0].Value.ToString()) }));
            matchingPatientBindingSource.ResetBindings(false); 
        }

        private void matchPatientWithIllnessBtn_Click(object sender, EventArgs e)
        {
            if (linkingActive)
            {
                executeLinking(UpdateDGV.Illness);
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }
            else
            {
                linkingActive = true;
                ChangeToLinkButtons(matchIllnessBtn);                
                tabControl1.SelectedTab = tabControl1.TabPages[1];
                lockTab = true;
            }            
        }

        private void matchIllnessWithPatientBtn_Click(object sender, EventArgs e)
        {
            if (linkingActive)
            {
                executeLinking(UpdateDGV.Patient);
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
            else
            {
                linkingActive = true;
                ChangeToLinkButtons(matchPatientBtn);               
                tabControl1.SelectedTab = tabControl1.TabPages[0];
                lockTab = true;
            }   
        }

        private void ChangeToLinkButtons(Button confirmLinkBtn)
        {
            foreach (Button item in patientBtnTableLayoutPanel.Controls)
	        {
		        item.Visible = false;
	        }
            foreach (Button item in illnessBtnTableLayoutPanel.Controls)
	        {
		        item.Visible = false;
	        }
            confirmLinkBtn.Visible = true;
            confirmLinkBtn.Text = "Zuordnung bestätigen";            
        }

        private void MakeButtonVisible()
        {
            foreach (Button item in patientBtnTableLayoutPanel.Controls)
            {
                item.Visible = true;
            }
            foreach (Button item in illnessBtnTableLayoutPanel.Controls)
            {
                item.Visible = true;
            }
            matchIllnessBtn.Text = "Krankheit zuordnen";
            matchPatientBtn.Text = "Patient zuordnen";
        }

        enum UpdateDGV { Illness, Patient }

        private void executeLinking(UpdateDGV value)
        {
            int selectedPatientRow = getSelectedRow(dataGridView1);
            int selectedIllnessRow = getSelectedRow(dataGridView3);
            Patient patient = fachkonzept.GetPatient(Int64.Parse(dataGridView1.Rows[selectedPatientRow].Cells[0].Value.ToString()));
            Illness illness = fachkonzept.GetIllness(Int64.Parse(dataGridView3.Rows[selectedIllnessRow].Cells[0].Value.ToString()));
            fachkonzept.LinkPatientIllness(patient, illness); 
         
            matchingIllnesses.Add(illness);
            matchingIllnessBindingSource.ResetBindings(false);          
            matchingPatients.Add(patient);
            matchingPatientBindingSource.ResetBindings(false);

            linkingActive = false;
            lockTab = false;
            MakeButtonVisible();
        }

        private void reverseLinking()
        {
            linkingActive = false;
            lockTab = false;
            matchIllnessBtn.Text = "Krankheit zuordnen";
            matchPatientBtn.Text = "Patient zuordnen";
            MakeButtonVisible();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (linkingActive && lockTab)
            {
                e.Cancel = true;
                if (MessageBox.Show("Zuordnung beenden?", "Auswahl", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                    reverseLinking();
                };
            }
        }
    }
}
