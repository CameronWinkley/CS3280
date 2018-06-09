using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_3280_Assignment3_CWinkley
{
    public class Client
    {
        private string _clientName;
        private string _company;
        private string _position;
        
        public List<Address> Addresses { get; set; }


        public Client(string client, string business, string jobTitle)
        {
            ClientName = client;
            Company = business;
            Position = jobTitle;

        }

        public string ClientName
        {
            
            get => _clientName;

            set
            {
                if (value.Length == 0)
                    throw new ArgumentOutOfRangeException("A value needs to be entered");
                _clientName = value;
            }
        }

        public string Company
        {
            
             get => _company;
 
             set
             {
                 if (value.Length == 0)
                     throw new ArgumentOutOfRangeException("please enter in a company name");
                 _company = value;
            }
        }

        public string Position
        {
            

            get => _position;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("please enter in a position");
                }

                _position = value;
                
            }
        }

        
    }
}
