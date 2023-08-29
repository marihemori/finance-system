using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notifications
{
    public class Notify
    {
        public Notify() {
            notifications = new List<Notify> ();
        }

        [NotMapped]
        public string PropName {  get; set; }

        [NotMapped]
        public string message { get; set; }

        [NotMapped]
        public List<Notify> notifications;

        public bool ValidateStringProp(string value, string propName)
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propName)) {
                notifications.Add(new Notify
                {
                    message = "Required field",
                    PropName = propName
                });
                return false;
            }

            return true;
        }

        public bool ValidateIntProp(int value, string propName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propName))
            {
                notifications.Add(new Notify
                {
                    message = "Required field",
                    PropName = propName
                });
                return false;
            }

            return true;
        }
    }
}
