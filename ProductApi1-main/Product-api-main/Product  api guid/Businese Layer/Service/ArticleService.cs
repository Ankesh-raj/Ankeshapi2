using DataLayer.Repository;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businese_Layer.Service
{
    public class ArticleService
    {
        Iarticle _iarticle;
        public ArticleService(Iarticle iarticle)
        {
            _iarticle = iarticle;
        }

        public void Addarticle(Article article)
        {
            _iarticle.AddArticle(article);
        }
        public void Editarticle(Article article)
        {
            _iarticle.EditArticle(article);
        }

        public void Removearticle(int articleId)
        {
            _iarticle.RemoveArticle(articleId);
        }

        public Article GetarticlebyId(int articleId)
        {
            return _iarticle.GetArticleById(articleId);
        }

        public IEnumerable<Article> Getarticles()
        {
            return _iarticle.GetArticles();
        }
    }
}
