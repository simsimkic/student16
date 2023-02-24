/***********************************************************************
 * Module:  Doctor.cs
 * Purpose: Definition of the Class Sekretar.Doctor
 ***********************************************************************/

using System;

namespace Model.ZajednickeKlase
{
   public class Doctor
    {
        public enum DoctorType
        {
            Doctor,
            Specialist
        }

        private string _name;
        private string _surname;
        private DoctorType _typeOfDoctor;
        private string _workHourBegin;
        private string _workHourEnd;
        private string _shift;

        public Doctor(string name, string surname, DoctorType typeOfDoctor, string hourBegin, string hourEnd, string shift)
        {
            _name = name;
            _surname = surname;
            _typeOfDoctor = typeOfDoctor;
            _workHourBegin = hourBegin;
            _workHourEnd = hourEnd;
            _shift = shift;
        }

        public Doctor() { }

        public string Name
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

        public string Surname
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

        public DoctorType TypeOfDoctor
        {
            get
            {
                return _typeOfDoctor;
            }
            set
            {
                if (value != _typeOfDoctor)
                {
                    _typeOfDoctor = value;
                }
            }
        }

        public string WorkHourBegin
        {
            get
            {
                return _workHourBegin;
            }
            set
            {
                if (value != _workHourBegin)
                {
                    _workHourBegin = value;
                }
            }
        }

        public string WorkHourEnd
        {
            get
            {
                return _workHourEnd;
            }
            set
            {
                if (value != _workHourEnd)
                {
                    _workHourEnd = value;
                }
            }
        }

        public string Shift
        {
            get
            {
                return _shift;
            }
            set
            {
                if (value != _shift)
                {
                    _shift = value;
                }
            }
        }

    }
}