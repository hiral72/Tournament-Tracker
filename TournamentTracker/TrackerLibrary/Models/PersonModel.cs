using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int PersonId { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber{ get; set; }
        public PersonModel()
        {
                
        }



        public String FullName
        {
            get 
            {
                //string r = String.Format("{0} {1}", FirstName, LastName);
                return (FirstName+" "+LastName); 
            }

        }
        
       
    }
}
