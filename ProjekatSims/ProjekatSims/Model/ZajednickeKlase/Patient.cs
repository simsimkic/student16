using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Classes
{
    public class Patient : User
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private DateTime _appointment;
        private User _user;

        public Patient(String jmbg, String name, String surname, String phoneNumber, DateTime appointment)
        {
            Jmbg = jmbg;
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            _appointment = appointment;
        }

        /*public Patient(User user, DateTime appointment)
        {
            _user = user;
            _appointment = appointment;
        }*/

        public Patient()
        {

        }

        public DateTime Appointment
        {
            get
            {
                return _appointment;
            }
            set
            {
                if (value != _appointment)
                {
                    _appointment = value;
                }
            }
        }
    }
}
