using Dapper;
using MySql.Data.MySqlClient;

namespace articles2
{
    internal class DBqueries
    {
        MySqlConnection DBRequest = new("Server = lab005.2isa.org; Port=33005;Database=dbWinForm;UID=root;PWD=1365lab005");
        #region Article functions
        public IEnumerable<Article> GetAllArticles()
        {
            string query = "select* from article;";
            try
            {
                DBRequest.Open();
                var result = DBRequest.Query<Article>(query);
                return result;
            }
            finally { DBRequest.Close(); }
        }


        public int InsertArticle(string titre, string corps, string auteur)
        {
            string query = "Insert into article (titre, Corps,auteur) values(@titre,@corps,@auteur)";
            try
            {
                DBRequest.Open();
                int result = DBRequest.Execute(query, new { titre, corps, auteur });
                return result;
            }
            finally
            {
                DBRequest.Close();
            }
        }
        public int UpdateArticle(int IDArticle, string oldTitre, string oldContent, string oldAutor, string newTitle, string newContent, string newAutor)
        {
            string query = "update article set(Titre,Corps, Auteur) values(@newTitle,@newContent,@newAutor);";
            int result = DBRequest.Execute(query, new { IDArticle, oldTitre, oldContent, oldAutor, newTitle, newContent, newAutor });
            return result;
        }
        public int DeleteArticleIfNotExit(int IDArticle)
        {
            try
            {
                DBRequest.Open();
                string isInQuery = "delete from article join composition on IDArticle = IDArticle join journal on IDJournal = IDJounal  where IDArticle = @IDArticle";
                int result = DBRequest.Execute(isInQuery, new { IDArticle });
                return result;
            }
            finally { DBRequest.Close(); }
        }
        #endregion
        #region Newspapper functions
        public IEnumerable<Newspapper> GetAllNewspappers()
        {
            string query = "select* from journal;";
            try
            {
                DBRequest.Open();
                var newspappers = DBRequest.Query<Newspapper>(query);


                return newspappers;
            }
            finally { DBRequest.Close(); }
        }
        public int InsertNewspapper(string title, DateTime? dtParution)
        {
            string query = "insert into journal(Titre,DtParution) values(@title,@dtParution)";
            try
            {
                int result = DBRequest.Execute(query, new { title, dtParution });
                return result;
            }
            finally { DBRequest.Close(); }
        }
        public int UpdateNewspapper(int IDJournal, string titre, DateTime? dtParution)
        {
            string query = "update journal set(Titre,DtParution) values(titre,dtParution;";
            try
            {
                int result = DBRequest.Execute(query, new { titre, dtParution });
                return result;
            }
            finally { DBRequest.Close(); }
        }

        public int DeleteNewspapper(int IDJournal)
        {
            string query = "delete from journal where IDJournal = @IDJournal;";
            try
            {
                int result = DBRequest.Execute(query, new { IDJournal });
                return result;
            }
            finally { DBRequest.Close(); }
        }
        #endregion

    }
}
