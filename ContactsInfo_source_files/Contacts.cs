using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ContactsInfoApp
{
    public partial class Contacts : Form
    {
        // Init. person for handling Person type object(s)
        private Person person;
        private int memberCount = 0;

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
            monitor_Process();
        }

        // Shows total cpu and memory usage of the system after start
        private void monitor_Process()
        {
            
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            cpuCounter.NextValue();
            ramCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            cpu_usage.Text = "CPU usage: " + cpuCounter.NextValue() + "%";
            memory_usage.Text = "Memory usage: " + ramCounter.NextValue() + "MB";
        }

        // Clear all textbox and the listbox
        public void clearBoxes()
        {
            listBox.Items.Clear();
            nameBox.Text = "";
            addressBox.Text = "";
            ageBox.Text = "";
            mobileBox.Text = "";
            typeBox.Text = "";
        }

        // Read data from phonebook.dat file when clicking on save button
        // Checks if the entered data is valid or not and warns the user accordingly
        // Clears the textboxes after clicking on the button
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                person._name.GetType();
                person._address.GetType();

                if (person._name == " " || person._address == " " || person._age <= 0 || person._age.ToString().Length > 2)
                {
                    throw new Exception();
                }
                TelephoneDirectory.SavePersonToList(person);
                TelephoneDirectory.CreateOrOpenTelephoneDirectory(person);
                MessageBox.Show("Contact saved!" + "\n" + person, "Confirm", MessageBoxButtons.OK);
                memberCount += 1;
            }
            catch(Exception exception)
            {
                MessageBox.Show("Missing or invalid property! Contact won't get saved!\n" + exception.Message, "Contact Error", MessageBoxButtons.OK);
            }
            listLabel.Text = "Contact list (" + memberCount + "):";
            clearBoxes();
        }

        // Put data in a phonebook.dat file when clicking on list button
        // Clears the textboxes after clicking on the button
        private void list_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string[] personListStrings = TelephoneDirectory.ListPersonsFromPhoneBook();
            foreach (string personString in personListStrings)
            {
                listBox.Items.Add(personString);
                memberCount += 1;
            }
            listLabel.Text = "Contact list (" + memberCount + "):";
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
            else
            {
                person._age = 0;
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
            else
            {
                person._mobilenumber = 0;
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

        //Refresh the CPU and RAM usage
        private void button1_Click(object sender, EventArgs e)
        {
            monitor_Process();
            clearBoxes();
        }
    }
}
