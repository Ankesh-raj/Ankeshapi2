using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
    public class ArticleRepsot : Iarticle
    {

        DBContext _dbContext;
        public ArticleRepsot(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void AddArticle(Article article)
        {
            _dbContext.tbl_article.Add(article);
            _dbContext.SaveChanges();
        }



        public void EditArticle(Article article)
        {
            _dbContext.Entry(article).State = EntityState.Modified;

            _dbContext.SaveChanges();

        }

        public Article GetArticleById(int articleId)
        {
            return _dbContext.tbl_article.Find(articleId);
        }

        public IEnumerable<Article> GetArticles()
        {
            return _dbContext.tbl_article.ToList();
        }

        public void RemoveArticle(int ArticleId)
        {
            var article = _dbContext.tbl_article.Find(ArticleId);
            _dbContext.tbl_article.Remove(article);
            _dbContext.SaveChanges();
        }
    }
}

