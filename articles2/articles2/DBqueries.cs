using Dapper;
using MySql.Data.MySqlClient;

namespace articles2
{
    internal class DBqueries
    {

        object _verrou = new object();
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
            try
            {
                await DBRequest.OpenAsync();
                var q = "INSERT INTO article (Titre,Corps,Auteur) VALUES (@titre, @corps, @auteur); SELECT LAST_INSERT_ID()";
                var result = await DBRequest.QueryAsync<int>(q, new { titre, corps, auteur });
                return result.Single();
            }
            finally { await DBRequest.CloseAsync(); }
        }

        public async Task<int> UpdateArticleAsync(int id, string titre, string corps, string auteur)
        {
            try
            {
                await DBRequest.OpenAsync();
                var q = "UPDATE article SET Titre = @titre, Corps = @corps, Auteur = @auteur WHERE IDArticle = @id";
                var result = await DBRequest.ExecuteAsync(q, new { id, titre, corps, auteur });
                return result;
            }
            finally { await DBRequest.CloseAsync(); }
        }

        public async Task<int> DeleteArticleIfNotCompositionAsync(int id)
        {
            try
            {
                await DBRequest.OpenAsync();
                var q = "DELETE from Article WHERE IDArticle = @id AND NOT EXISTS (SELECT IDArticle FROM composition where IDArticle = @id)";
                var result = await DBRequest.ExecuteAsync(q, new { id });
                return result;
            }
            finally { await DBRequest.CloseAsync(); }
        }

        public async Task<int> DeleteArticleAsync(int IDArticle)
        {
            try
            {
                string inJournalQuery = "select * from journal JOIN composition on composition.IDJournal = journal.IDJournal JOIN article ON composition.IDArticle= article.IDArticle WHERE article.IDArticle = @IDArticle;";
                await DBRequest.OpenAsync();

                string deleteQuery = "delete from article  where IDArticle = @IDArticle;";
                var isIn = await DBRequest.ExecuteAsync(inJournalQuery, new { IDArticle });

                var deleteExecute = await DBRequest.ExecuteAsync(deleteQuery, new { IDArticle });
                return isIn;


            }
            finally { await DBRequest.CloseAsync(); }
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
        public async Task<IEnumerable<Newspapper>> GetAllNewspappersAsync()
        {
            string query = "select* from journal;";
            try
            {
                await DBRequest.OpenAsync();
                Task<IEnumerable<Newspapper>> newspappers = DBRequest.QueryAsync<Newspapper>(query);

                return newspappers.Result;
            }
            finally { await DBRequest.CloseAsync(); }
        }
        public async Task<int> InsertNewspapperAsync(string title, DateTime? dtParution)
        {
            string query = "insert into journal(Titre,DtParution) values(@title,@dtParution)";
            try
            {
                Task<int> result = DBRequest.ExecuteAsync(query, new { title, dtParution });
                return result.Result;
            }
            finally { await DBRequest.CloseAsync(); }
        }
        public async Task<int> UpdateNewspapperAsync(int IDJournal, string titre, DateTime? dtParution)
        {
            string query = "UPDATE journal SET Titre =@titre,DtParution = DtParution WHERE IDJournal = @IDJournal;";
            try
            {
                await DBRequest.OpenAsync();
                Task<int> result = DBRequest.ExecuteAsync(query, new { IDJournal, titre, dtParution });
                return result.Result;
            }
            finally { await DBRequest.CloseAsync(); }
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
