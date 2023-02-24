using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Upravnik
{
    public class Survey
    {

        public enum SurveyAuthor
        {
            Doctor,
            Patient
        }

        protected Boolean _anonymity;
        protected SurveyAuthor _author;
        protected String _name;
        protected String _surname;
        protected String _content;

        public Survey() { }

        public Survey(Boolean anonymity,  SurveyAuthor author, String name, String surname, String content)
        {
            _anonymity = anonymity;
            _author = author;
            _name = name;
            _surname = surname;
            _content = content;
        }


        public Boolean Anonymity
        {
            get
            {
                return _anonymity;
            }
            set
            {
                if (value != _anonymity)
                {
                    _anonymity = value;
                }
            }
        }

        public SurveyAuthor Author
        {
            get
            {
                return _author;
            }
            set
            {
                if (value != _author)
                {
                    _author = value;
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

        public String Content
        {
            get
            {
                return _content;
            }
            set
            {
                if (value != _content)
                {
                    _content = value;
                }
            }
        }
    }
}
