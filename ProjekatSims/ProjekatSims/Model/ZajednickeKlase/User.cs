using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Classes
{
    public class User
    {
        public enum Gender
        {
            Male,
            Female,
            Other
        }

        private String _jmbg;
        private String _name;
        private String _surname;
        private DateTime _dateOfBirth;
        private Gender _genderType;      
        private String _address;
        private String _city;
        private String _country;
        private String _phoneNumber;
        private String _emailAddress;
        private String _password;

        public User(String jmbg, String name, String surname, DateTime dateOfBirth, Gender gender, String address, String phoneNumber, String email, String password)
        {
            _jmbg = jmbg;
            _name = name;
            _surname = surname;
            _dateOfBirth = dateOfBirth;
            _genderType = gender;
            if (gender.Equals("Male"))
                _genderType = Gender.Male;
            else if (gender.Equals("Female"))
                _genderType = Gender.Female;
            else
                _genderType = Gender.Other;
            _address = address;
            _phoneNumber = phoneNumber;

            if((email != null && email != "") && (password != null && password != ""))
            {
                _emailAddress = email;
                _password = password;
            }
            else
            {
                _emailAddress = "GUEST";
                _password = "GUEST";
            }
        }
        public User()
        {
        }

        public String Jmbg
        {
            get
            {
                return _jmbg;
            }
            set
            {
                if (value != _jmbg)
                {
                    _jmbg = value;
                    //OnPropertyChanged();
                }
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    _name = value;                   
                }
            }
        }

        public String Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value != _surname)
                {
                    _surname = value;
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value != _dateOfBirth)
                {
                    _dateOfBirth = value;
                }
            }
        }

        public Gender GenderType
        {
            get
            {
                return _genderType;
            }
            set
            {
                if (value != _genderType)
                {
                    _genderType = value;
                }
            }
        }

        public String Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value != _address)
                {
                    _address = value;
                }
            }
        }

        public String City
        {
            get
            {
                return _city;
            }
            set
            {
                if (value != _city)
                {
                    _city = value;
                }
            }
        }

        public String Country
        {
            get
            {
                return _country;
            }
            set
            {
                if (value != _country)
                {
                    _country = value;
                }
            }
        }

        public String PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value != _phoneNumber)
                {
                    _phoneNumber = value;
                }
            }
        }

        public String EmailAddress
        {
            get
            {
                return _emailAddress;
            }
            set
            {
                if (value != _emailAddress)
                {
                    _emailAddress = value;
                }
            }
        }

        public String Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value != _password)
                {
                    _password = value;
                }
            }
        }

    }
}
