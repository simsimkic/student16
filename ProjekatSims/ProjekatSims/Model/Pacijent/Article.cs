/***********************************************************************
 * Module:  Article.cs
 * Purpose: Definition of the Class Model.Pacijent.Article
 ***********************************************************************/

using System;

namespace Model.Pacijent
{
   public class Article
   {
      private String _title;
      private String _content;


      public Article() { }

      public Article(String title, String content)
      {
            _title = title;
            _content = content;
      }

      public String Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;
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