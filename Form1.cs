using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_3280_Assignment3_CWinkley
{
    public partial class Assignment3 : Form
    {   
        

        private List<Client> clientList;
        private List<Address> addressList;

        private readonly BindingList<Client> BoundsClientList;
        private readonly BindingList<Address> BoundsAddressList;
        
        
    public Assignment3()
        {
            InitializeComponent();
            clientList = new List<Client>();
            BoundsClientList = new BindingList<Client>();
            addressList = new List<Address>();
            BoundsAddressList = new BindingList<Address>();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //loading the options for positions within the company
            PositionComboBx.Items.Add(Enum.Position.DataAnalyst);
            PositionComboBx.Items.Add(Enum.Position.Associate);
            PositionComboBx.Items.Add(Enum.Position.Manager);
            PositionComboBx.Items.Add(Enum.Position.TeamLead);
        }


        private void Submit_Client_btn_click(object sender, EventArgs e)
        {
            
            
        }

        private void Submit_Address_btn_click(object sender, EventArgs e)
        {
            

        }
        private void Cli_Click(object sender, EventArgs e)
        {
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientTabt_Click(object sender, EventArgs e)
        {

        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        public void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             

        }

        private void Addresses_Click(object sender, EventArgs e)
        {
            
        }

        

        private void ClientlistTxtbx(object sender, EventArgs e)
        {
            //var Client = ClientListBox.SelectedItem as Client;
        }

        private void SubmitClientBtn_Click(object sender, EventArgs e)
        {
            var client = ClientNametxtbx.Text;
            var company = CompanyTxtBx.Text;
            var position = PositionComboBx.Text;

            var newClient = new Client(client, company, position);
            clientList.Add(newClient);
            BoundsClientList.Add(newClient);
            
            //ClientListTxtBx.datasource = BoundsAddressList;
            //set message box txt with clientlist
           
           
                ClientListTxtBx.AppendText($"Client name: {newClient.ClientName} "+ Environment.NewLine);
                ClientListTxtBx.AppendText($"Company Name: {newClient.Company}" + Environment.NewLine);
                ClientListTxtBx.AppendText($"Position: {newClient.Position}" + Environment.NewLine);
                ClientListBox.DataSource = BoundsClientList;
                ClientListBox.DisplayMember = "ClientName";
                ClientListBox.Update();
            

            //clears out the ClientNametxtbx and Companytxtbx
                ClientNametxtbx.Clear();
                CompanyTxtBx.Clear();
            
        }

        private void ClientListTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_Submit_btn_Click(object sender, EventArgs e)
        {
            //allows user to enter in the client address
            //try
            //{
                var street = StreetTxtBx.Text;
                var city = CityTxtbx.Text;
                var state = Statetxtbx.Text;
                var zip = ZipTxtBx.Text;
                //creates Address object to pass entered values into the clientaddress
                Address clientAddress = new Address(street, city, zip, state);
                addressList.Add(clientAddress);
                BoundsAddressList.Add(clientAddress);



                //sets the knownaddresstxtbx with the client address vvalues
                KnownAddresstxtbx.AppendText($"{street}" + $" {city}" + $" {state}" + $" {zip}");
                //clears the information entered into the field after submitting
                StreetTxtBx.Clear();
                CityTxtbx.Clear();
                Statetxtbx.Clear();
                ZipTxtBx.Clear();
            //}
            //catch (Exception invalid
            //error)
            //{
            //    Console.Write(error.StackTrace);
            //}


        }

        private void PositionListBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KnownAddresstxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {       

                

        }
    }
}
