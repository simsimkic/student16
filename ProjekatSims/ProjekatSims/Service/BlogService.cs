/***********************************************************************
 * Module:  BlogService.cs
 * Purpose: Definition of the Class Service.BlogService
 ***********************************************************************/

using Model.Pacijent;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
   public class BlogService
   {
        private readonly ArticleRepository repository;

        public BlogService(ArticleRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Article> getAll()
        {
            var articles = repository.GetAll();
            return articles;
        }

       public Article getArticle(string title)
        {
            var article = repository.GetArticle(title);
            return article;
        }
        public Model.Pacijent.Article addArticle(Model.Pacijent.Article article)
      {
           Article newArticle = repository.createArticle(article);
           newArticle.Title = article.Title;
           newArticle.Content = article.Content;

           return newArticle;
      }
      
      public Model.Pacijent.Article updateArticle(Model.Pacijent.Article article, string content)
      {
         var articles = repository.GetAll();
            if (articles.Contains(article))
            {
                article.Content = content;
            }
            else
            {
                return null;
            }
         return article;
      }
      
      public void deleteArticle(Model.Pacijent.Article article)
      {
            repository.deleteArticle(article);
         
      }

      public void writeInList(List<Article> articles)
      {
           repository.writeInList(articles);
      }

    }
}