/***********************************************************************
 * Module:  BlogController.cs
 * Purpose: Definition of the Class Controller.BlogController
 ***********************************************************************/

using Model.Pacijent;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class BlogController
   {
      private readonly BlogService service;

      public BlogController(BlogService service)
        {
            this.service = service;
        }

        public IEnumerable<Article> GetAll() => service.getAll();
        public Model.Pacijent.Article AddArticle(Model.Pacijent.Article article) => service.addArticle(article);

        public Model.Pacijent.Article UpdateArticle(Model.Pacijent.Article article, string content) => service.updateArticle(article, content);

        public void DeleteArticle(Model.Pacijent.Article article) => service.deleteArticle(article);

        public void WriteIn(List<Article> articles) => service.writeInList(articles);

    }
}