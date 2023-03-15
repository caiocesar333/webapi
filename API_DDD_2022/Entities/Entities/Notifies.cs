using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Notifies
    {

        public Notifies() 
        {   
            
            Notitycoes = new List<Notifies>();

        }   

        [NotMapped]
        public string NameProperty { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notifies> Notitycoes { get; set; }


        public bool ValidatePropertyString(string value, string NameProperty)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(NameProperty)) 
            {
                Notitycoes.Add(new Notifies
                {
                    Message = "Required field",
                    NameProperty = NameProperty
                });
                return false;
            }

            return true;
        }

        public bool ValidatePropertyInt(int value, string NameProperty)
        {
            if ( value < 1 || string.IsNullOrWhiteSpace(NameProperty))
            {
                Notitycoes.Add(new Notifies
                {
                    Message = "Required field",
                    NameProperty = NameProperty
                });
                return false;
            }

            return true;
        }
    }
}
