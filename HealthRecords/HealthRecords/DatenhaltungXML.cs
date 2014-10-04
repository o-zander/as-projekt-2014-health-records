using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace HealthRecords
{
    class DatenhaltungXML : IDatenhaltung
    {
        private int lastPatientID = 0;
        private int lastIllnessID = 0;

        public DatenhaltungXML()
        {
            GetLastPatientId();    
        }

        private void GetLastPatientId()
        {
            int currentPatientID = 0;
            if (File.Exists("Patients.xml"))
            {
                XElement patients = XElement.Load("Patients.xml");
                XName patient = XName.Get("Patient");
                XName patientsID = XName.Get("PatientsID");
                foreach (XElement item in patients.Elements(patient))
                {
                    try
                    {
                        XElement patientsIDElement = item.Element(patientsID);
                        currentPatientID = Int32.Parse(patientsIDElement.Value);
                        if (currentPatientID > lastPatientID)
                        {
                            lastPatientID = currentPatientID;
                        }
                    }
                    catch (Exception) { }
                }
            }
        }

        public Patient[] GetPatientsData(int setSize, int lastID)
        {
            Patient[] patients = new Patient[setSize];
            if (File.Exists("Patients.xml"))
            {
                XElement patientsElement = XElement.Load("Patients.xml");
                XName xPatient = XName.Get("Patient");
                XName xPatientsID = XName.Get("PatientsID");
                XName xFirstName = XName.Get("FirstName");
                XName xLastName = XName.Get("LastName");
                XName xBirthday = XName.Get("Birthday");
                int CountPatients = 0;
                foreach (XElement item in patientsElement.Elements(xPatient))
                {
                    try
                    {
                        int curPatientID = Int32.Parse(item.Element(xPatientsID).Value);
                        string curFirstName = item.Element(xFirstName).Value;
                        string curLastName = item.Element(xLastName).Value;
                        DateTime curBirthday = String.IsNullOrWhiteSpace(item.Element(xBirthday).Value) ? default(DateTime) : DateTime.Parse(item.Element(xBirthday).Value);
                        if (curPatientID > lastID)
                        {
                            Patient patient = new Patient() { PatientID = curPatientID, FirstName = curFirstName, LastName = curLastName, Birthday = curBirthday };
                            if (CountPatients < setSize)
                            {
                                patients[CountPatients] = patient;
                                CountPatients++;
                            }
                        };
                    }
                    catch (Exception) { }
                }
            }

            return patients;
        }

        public Illness[] GetIllnessesData(int setSize, int lastID)
        {
            Illness[] illnesses = new Illness[setSize];
            return illnesses;
        }

        public Patient GetPatientData(int patientID)
        {
            Patient patient = new Patient();
            int currentPatientID;
            bool getPatientNode = false;
            using (XmlReader reader = XmlReader.Create("Patients.xml"))
            {
                while (reader.Read())
                {
                    while (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Patients":
                                reader.Read();
                                break;
                            case "Patient":
                                reader.Read();
                                break; 
                            case "PatientsID":
                                if (reader.Read())
                                {
                                    try
                                    {
                                        currentPatientID = Int32.Parse(reader.Value.Trim());
                                        if (currentPatientID == patientID)
                                        {
                                            patient.PatientID = patientID;
                                            getPatientNode = true;
                                        }
                                    }
                                    catch (Exception) { }                                    
                                }
                                break;
                            case "FirstName":
                                if (reader.Read())
                                {
                                    try
                                    {
                                        if (getPatientNode)
                                        {
                                            patient.FirstName = reader.Value.Trim();
                                        }
                                    }
                                    catch (Exception) { }
                                }
                                break;
                            case "LastName":
                                if (reader.Read())
                                {
                                    try
                                    {
                                        if (getPatientNode)
                                        {
                                            patient.LastName = reader.Value.Trim();                                            
                                        }
                                    }
                                    catch (Exception) { }
                                }
                                break;
                            case "Birthday":
                                if (reader.Read())
                                {
                                    try
                                    {
                                        if (getPatientNode)
                                        {
                                            getPatientNode = false;
                                            DateTime birthdate = DateTime.Parse(reader.Value.Trim());
                                            patient.Birthday = birthdate;
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        getPatientNode = false;                                           
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            return patient;
        }

        public Illness GetIllnessData(int illnessID)
        {
            Illness illness = new Illness();
            return illness;
        }

        public Boolean CreatePatientData(Patient patient)
        {
            //Patient patient1 = new Patient(){ FirstName="Max", LastName="Mustermann", Birthday=DateTime.Today, PatientID=1}

            if (File.Exists("Patients.xml"))
            {
                //XDocument xDoc = XDocument.Load("Patients.xml");
                //XName patients = XName.Get("Patients");
                //XElement patientsElement = xDoc.Element(patients);
                XElement patientsElement = XElement.Load("Patients.xml");
                patientsElement.Add(new XElement("Patient",
                                                                  new XElement("PatientsID",++lastPatientID ),
                                                                  new XElement("FirstName",patient.FirstName),
                                                                  new XElement("LastName",patient.LastName),
                                                                  new XElement("Birthday",patient.Birthday.ToShortDateString())
                                                      )
                                    );
                patientsElement.Save("Patients.xml");

                
                
            }
            else
            {
                using (XmlWriter writer = XmlWriter.Create("Patients.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Patients");

                    writer.WriteStartElement("Patient");
                    writer.WriteElementString("PatientsID", (++lastPatientID).ToString());
                    writer.WriteElementString("FirstName", patient.FirstName.ToString());
                    writer.WriteElementString("LastName", patient.LastName.ToString());
                    writer.WriteElementString("Birthday", patient.Birthday.ToShortDateString());
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }

            return true;
        }

        public Boolean CreateIllnessData(Illness illness)
        {
            return true;
        }

        public Boolean UpdatePatientData(Patient patient)
        {
            return true;
        }

        public Boolean UpdateIllnessData(Illness illness)
        {
            return true;
        }

        public Boolean LinkPatientIllnessData(Patient patient, Illness illness)
        {
            return true;
        }

        public Boolean DeletePatientData(Patient patient)
        {
            return true;
        }

        public Boolean DeleteIllnessData(Illness illness)
        {
            return true;
        }

        
    }
}
