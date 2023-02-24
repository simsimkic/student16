/***********************************************************************
 * Module:  ArticleService.cs
 * Purpose: Definition of the Class Service.ArticleService
 ***********************************************************************/

using Model.Pacijent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class ArticleRepository
   {

        private readonly string _path;
        private readonly string _delimiter;

        public ArticleRepository(string path, string delimiter)
        {
            _path = path;
            _delimiter = delimiter;
        }

        public IEnumerable<Article> GetAll() => readAll();


        private string ConvertEntityToCSVFormat(Article article)
            => string.Join(_delimiter,
                article.Title,
                article.Content);

        public Model.Pacijent.Article GetArticle(String title)
        {

        try
        {
            return readAll().SingleOrDefault(article => article.Title == title);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Article doesn't exist -> Get");
            return null;
        }
      }

        public Article createArticle(Article article)
        {
            appendLineToFile(ConvertEntityToCSVFormat(article));
            return article;
        }

        public void deleteArticle(Article article)
        {
            var articles = readAll().ToList();
            var articleToRemove = articles.SingleOrDefault(tempArticle => tempArticle.Title == article.Title);
            if (articleToRemove != null)
            {
                articles.Remove(articleToRemove);
                saveAll(articles);
            }
            else
            {
                Console.WriteLine("Article doesn't exist -> Delete");
            }
        }

        private Article ConvertCSVFormatToEntity(string articleCSVFormat)
        {
            string[] tokens = articleCSVFormat.Split(_delimiter.ToCharArray());
            return new Article(
                tokens[0], tokens[1]);
                

        }

        public void writeInList(List<Article> articles)
        {
            articles.ToList();
            saveAll(articles);
        }
        public List<Article> GetAllArticles()
      {
         // TODO: implement
         return null;
      }


        private IEnumerable<Article> readAll()
              => File.ReadAllLines(_path).Select(ConvertCSVFormatToEntity).ToList();

        private void saveAll(IEnumerable<Article> articles)
        => writeAllLinesToFile(
            articles.Select(ConvertEntityToCSVFormat).ToList());

        private void appendLineToFile(string line)
            => File.AppendAllText(_path, line + Environment.NewLine);

        private void writeAllLinesToFile(IEnumerable<string> content)
            => File.WriteAllLines(_path, content.ToArray());
    }
}