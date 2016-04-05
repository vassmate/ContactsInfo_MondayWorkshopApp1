using System;
using System.Windows.Forms;

namespace WorkshopApp1
{
    public partial class Contacts : Form
    {
        // Init. person for handling Person type object(s)
        Person person;

        // Constructor for Form
        public Contacts()
        {
            InitializeComponent();
        }

        // Load up form and it's starting properties
        // This will add the enum Type values to the combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            typeBox.Items.Add(Person.Type.Workplace);
            typeBox.Items.Add(Person.Type.Home);
            typeBox.Items.Add(Person.Type.Mobile);
        }

        // Do action when clicking on save button
        // Adds the persons to a list as well as writes them into a file
        // Clears the textboxes after clicking on the button
        private void save_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            TelephoneDirectory.SavePersonToList(person);
            TelephoneDirectory.CreateOrOpenTelephoneDirectory(person);
            listBox.Items.Add("Added to phonebook: " + person);

            nameBox.Text = "";
            addressBox.Text = "";
            ageBox.Text = "";
            mobileBox.Text = "";
            typeBox.Text = "";
        }

        // Do action when clicking on list button
        // Clears the textboxes after clicking on the button
        // ***Add below codesnippet to list_Click method for reading from file***
        /* string[] personListStrings = TelephoneDirectory.ListPersonsFromPhoneBook();
           foreach (string personString in personListStrings)
            {
                listBox.Items.Add(personString);
            } */
        private void list_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            addressBox.Text = "";
            ageBox.Text = "";
            mobileBox.Text = "";
            typeBox.Text = "";
            listBox.Items.Clear();

            string[] personListStrings = TelephoneDirectory.ListPersonsFromPhoneBook();
            foreach (string personString in personListStrings)
            {
                listBox.Items.Add(personString);
            }

            /*foreach (Person personInList in TelephoneDirectory.LoadPersonFromList())
            {
                listBox.Items.Add(personInList);
            }*/
        }

        // Set person._name parameter in the name textbox
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            person._name = nameBox.Text;
        }

        // Set the person._address parameter in the adress textbox
        private void addressBox_TextChanged(object sender, EventArgs e)
        {
            person._address = addressBox.Text;
        }

        // Set the person._age parameter in the age textbox after converting it from string to integer
        private void ageBox_TextChanged(object sender, EventArgs e)
        {
            int ageNum;
            if (int.TryParse(ageBox.Text, out ageNum))
            {
                person._age = ageNum;
            }
        }

        // Set the person._mobilenumber parameter in the mobilenumber textbox after converting it
        private void mobileBox_TextChanged(object sender, EventArgs e)
        {
            int mobilenumber;
            if (int.TryParse(mobileBox.Text, out mobilenumber))
            {
                person._mobilenumber = mobilenumber;
            }
        }

        // Set the mobile/phonenumber enum Type from the combobox to person._type after converting it
        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person.Type phoneType = (Person.Type) typeBox.SelectedItem;
            person._type = phoneType;
        }

        // This function does nothing for now
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // This function does nothing for now
        private void mobile_Click(object sender, EventArgs e)
        {
            
        }
    }
}
