using Dapper;
using MySql.Data.MySqlClient;

namespace articles2
{
    internal class DBqueries
    {
        MySqlConnection DBRequest = new("Server = lab005.2isa.org; Port=33005;Database=Edito;UID=root;PWD=1365lab005");
        #region Article functions
        public async Task<IEnumerable<Article>> GetAllArticlesAsync()
        {
            string query = "select* from article;";
            try
            {
                await DBRequest.OpenAsync();
                var result = await DBRequest.QueryAsync<Article>(query);
                return result;
            }
            finally { await DBRequest.CloseAsync(); }
        }


        public async Task<int> InsertArticleAsync(string titre, string corps, string auteur)
        {
            string query = "Insert into article (Titre, Corps,auteur) values(@titre,@corps,@auteur)";
            try
            {
                await DBRequest.OpenAsync();
                Task<int> result = DBRequest.ExecuteAsync(query, new { titre, corps, auteur });
                return result.Result;
            }
            finally
            {
                await DBRequest.CloseAsync();
            }
        }
        public async Task<int> UpdateArticleAsync(int IDArticle, string newTitle, string newContent, string newAutor)
        {
            string query = "UPDATE article                SET Titre = @NewTitle, Corps=@NewContent, Auteur=@newAutor WHERE  IDArticle = @IDArticle";
            await DBRequest.OpenAsync();
            Task<int> result = DBRequest.ExecuteAsync(query, new { IDArticle, newTitle, newContent, newAutor });
            return result.Result;
        }
        public Task<int> DeleteArticle(int IDArticle)
        {
            try
            {
                string inJournalQuery = "select * from journal JOIN composition on composition.IDJournal = journal.IDJournal JOIN article ON composition.IDArticle= article.IDArticle WHERE article.IDArticle = @IDArticle;";
                DBRequest.Open();

                string deleteQuery = "delete from article  where IDArticle = @IDArticle;";
                Task<int> isIn = DBRequest.ExecuteAsync(inJournalQuery, new { IDArticle });

                int deleteExecute = DBRequest.Execute(deleteQuery, new { IDArticle });
                return isIn;


            }
            finally { DBRequest.Close(); }
        }

        #endregion
        #region composition
        public IEnumerable<Article> IsInJournal(int IDJournal)
        {
            try
            {
                DBRequest.Open();
                string Query = @"select* from article  JOIN composition ON article.IDArticle=composition.IDArticle
                JOIN journal ON composition.IDJournal = journal.IDJournal
               WHERE journal.IDJournal = @IDJournal;";
                IEnumerable<Article> articlesIsIn = DBRequest.Query<Article>(Query, new { IDJournal });
                return articlesIsIn;
            }
            finally { DBRequest.Close(); }
        }
        public IEnumerable<Article> ArticlesNotIn(int IDArticle, int IDJournal)
        {
            try
            {
                DBRequest.Open();
                string query = @" SELECT * FROM article JOIN composition ON article.IDArticle = composition.IDArticle JOIN journal ON composition.IDJournal = journal.IDJournal WHERE IDJournal NOT IN(SELECT * FROM journal JOIN composition ON journal.IDJournal = composition.IDJournal JOIN article ON composition.IDArticle = article.IDArticle WHERE IDJournal = IDJournal;) AND IDJournal = @IDJournal;";
                IEnumerable<Article> notIn = DBRequest.Query<Article>(query, new { IDJournal });
                return notIn;
            }
            finally
            {
                DBRequest.Close();
            }
            //delete article from composition
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
            string query = "UPDATE journal SET Titre =@titre,DtParution = DtParution WHERE IDJournal = @IDJournal;";
            try
            {
                int result = DBRequest.Execute(query, new { IDJournal, titre, dtParution });
                return result;
            }
            finally { DBRequest.Close(); }
        }

        public int DeleteNewspapper(int IDJournal)
        {
            string deleteFromCompoQuery = "DELETE FROM composition INNER JOIN article ON composition.IDArticle = article.IDArticle INNER JOIN journal ON composition.IDJournal = journal.IDJournal WHERE journal.IDJournal = @IDJournal;";

            string deleteFromJournalQuery = "delete from journal where IDJournal = @IDJournal;";
            try
            {
                DBRequest.Open();


                var dialogResult = MessageBox.Show($"Voulez-vous supprimmer le journal: {IDJournal}?", "System message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Pas de suppression.");
                    return 0;
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    var transact = DBRequest.BeginTransaction();
                    var compoResult = DBRequest.Execute(deleteFromCompoQuery, new { IDJournal });

                    int journalDeleted = DBRequest.Execute(deleteFromJournalQuery, new { IDJournal });
                    transact.Commit();
                    return journalDeleted;

                }
            }
            finally { DBRequest.Close(); }
            return -1;







        }
        #endregion

    }
    //"SELECT * FROM journal JOIN composition ON journal.IDJournal = composition.IDJournal JOIN article ON composition.IDArticle = article.IDArticle WHERE IDJournal = @IDJournal;"
}
