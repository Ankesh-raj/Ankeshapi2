using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public  interface Iarticle
    {
        void AddArticle(Article article);

        void RemoveArticle(int articleId);

        void EditArticle(Article article);

        Article GetArticleById(int articleId);

        IEnumerable<Article> GetArticles();
    }
}
