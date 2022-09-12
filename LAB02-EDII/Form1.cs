using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace LAB02_EDII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string[] Data = new string[2];

            //Open File Dialog
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;

                GetData(file, Data);
                MessageBox.Show("Se ha agregado la información del archivo CSV correctamente en la estructura de datos.");
                tBSource.Text = file;
                btnImport.Enabled = false;
                gBBuscar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se ha podido abrir el archivo correctamente");
            }
        }

        public void GetData(string file, string[] data)
        {
            //Reads data in each line and make the needed operation in the tree
            foreach (string line in File.ReadLines(file))
            {
                data = line.Split(';');

                if (data[0].Contains("INSERT"))
                {
                    InsertJSON(data[1]);
                }
                else if (data[0].Contains("PATCH"))
                {
                    PatchJSON(data[1]);
                }
                else
                {
                    DeleteJSON(data[1]);
                }

            }
        }

        //Deserialize object in JSON format to a CS object format
        public static void InsertJSON(string personJSON)
        {
            Person person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(personJSON);
            InsertData(person);
        }

        public static void PatchJSON(string personJSON)
        {
            Person person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(personJSON);
            EditData(person);
        }

        public static void DeleteJSON(string personJSON)
        {
            Person person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(personJSON);
            DeleteData(person);
        }

        //Inserts a person to tree
        public static void InsertData(Person person)
        {
            Node<Person> NewNodeDPI = new Node<Person>(person);

            if (!Data.Instance.DPITree.Contains(Data.Instance.DPITree.Root, NewNodeDPI))
            {
                Data.Instance.DPITree.Root = Data.Instance.DPITree.Insert(Data.Instance.DPITree.Root, NewNodeDPI);

            }
            else
            {
                MessageBox.Show("Una persona ingresada tiene el mismo DPI que otra persona. Por favor, corrige el error.");
            }
        }

        //Edits a person's info in the tree
        public static void EditData(Person person)
        {
            //Creates a new node to search in the DPI tree, using DPI as the ID.
            Person auxPerson = new Person
            {
                name = person.name,
                dpi = person.dpi,
                datebirth = person.datebirth,
                address = person.address
            };

            Node<Person> PatchNodeDPI = new Node<Person>(auxPerson);

            Data.Instance.DPITree.EditData(Data.Instance.DPITree.Root, PatchNodeDPI);

        }

        //Deletes a person in the tree
        public static void DeleteData(Person person)
        {
            Person auxPerson = new Person
            {
                name = person.name,
                dpi = person.dpi,
            };
            Node<Person> DeleteNodeDPI = new Node<Person>(auxPerson);

            Data.Instance.DPITree.Delete(Data.Instance.DPITree.Root, DeleteNodeDPI);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mTBBuscarDPI.Text.Length == 13)
            {

            }
            else
            {
                MessageBox.Show("Ingresa un DPI válido.");
            }
        }
    }
    
}
