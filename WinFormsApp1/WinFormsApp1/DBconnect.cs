using Dapper;
using MySql.Data.MySqlClient;
using WinFormsApp1.Properties;


namespace WinFormsApp1
{

    internal class DBconnect
    {
        MySqlConnection RequestConnect = new(Settings.Default.stringConnectionnection);
        #region [article queries]
        public IEnumerable<Article> GetAllArticles()
        {
            try
            {
                string Query = "select * from article;";
                RequestConnect.Open();
                var Articles = RequestConnect.Query<Article>(Query);
                return Articles;
            }
            finally
            {
                RequestConnect.Close();
            }
        }

        public int InsertArticle(string titre, string corps, string auteur)
        {
            try
            {
                RequestConnect.Open();
                //var transaction = RequestConnect.BeginTransaction();
                //var compositionQuery = "\"INSERT INTO composition (IDArticle) VALUES (lastinsertid);";
                var articleQuery = "INSERT ignore INTO article (Titre,Corps,Auteur) VALUES (@titre, @corps, @auteur); SELECT LAST_INSERT_ID()";

                var result = RequestConnect.Query<int>(articleQuery, new { GetInsertId = true, titre, corps, auteur, });
                //var compositionInsert = RequestConnect.Query<int>(compositionQuery, new { id });
                //transaction.Commit();
                if (result.Single() > 0)
                {
                    MessageBox.Show($"l'article de: {auteur} intitulé: {titre} à bien été enregistré.");

                    return result.Single();
                }
                else
                {
                    MessageBox.Show($"l'article de: {auteur} intitulé: {titre} n'à pas été enregistré.");
                    return result.Single();
                }
            }
            finally { RequestConnect.Close(); }
        }
        public int UpdateArticle(int id, string old_titre, string old_corps, string old_auteur, string new_titre, string new_corps, string new_auteur)
        {
            try
            {
                RequestConnect.Open();
                string query = "UPDATE article SET Titre = @new_titre, Corps=@new_corps, Auteur=@new_auteur WHERE  Titre = @old_titre AND Corps=@old_corps;";
                var updated = RequestConnect.Execute(query, new { id, old_titre, old_corps, old_auteur, new_titre, new_corps, new_auteur });
                if (updated > 0)
                {
                    MessageBox.Show($"article: {old_titre} de:{old_auteur} à bien été mis à jour avec comme titre: {new_titre} et auteur: {new_auteur}.");
                }
                else
                {
                    MessageBox.Show($"la mise à jour de l'article: {old_titre} de:{old_auteur} n'a pas réussie.");
                }
                return updated;
            }
            finally
            {
                RequestConnect.Close();
            }


        }

        public int DeleteArticle(int id)
        {
            try
            {
                RequestConnect.Open();

                string delete_article_query = "DELETE FROM article WHERE IDArticle = @id";


                string delete_composition_query = "DELETE FROM composition WHERE IDArticle = @id";
                // Start a transaction
                var transaction = RequestConnect.BeginTransaction();
                var compositionDeletedRow = RequestConnect.Execute(delete_composition_query, new { id });

                var articleDeletedRow = RequestConnect.Execute(delete_article_query, new { id });
                // Commit the transaction
                transaction.Commit();
                return articleDeletedRow;
            }
            finally
            {
            }
        }

        #endregion


        #region [newspaper queries]
        public IEnumerable<Newspapers> GetAllNewspapers()
        {
            try
            {
                string Query = "select * from journal;";
                RequestConnect.Open();
                var Newspapers = RequestConnect.Query<Newspapers>(Query);
                return Newspapers;
            }
            finally
            {
                RequestConnect.Close();
            }
        }
        public int InsertNewspaper(string titre, DateTime DtParution)
        {
            try
            {
                RequestConnect.Open();

                var query = "INSERT ignore INTO journal (Titre,DtParution) VALUES (@titre, @corps, @DtParution);";

                var result = RequestConnect.Query<int>(query, new { titre, DtParution });
                if (result.Single() > 0)
                {
                    MessageBox.Show($"le journal: {titre} à bien été enregistré.");

                    return result.Single();
                }
                else
                {
                    MessageBox.Show($"le journarl: {titre} n'à pas été enregistré.");
                    return result.Single();
                }
            }
            finally { RequestConnect.Close(); }
        }
        public int DeleteNewspaper(int id)
        {
            try
            {
                RequestConnect.Open();

                string delete_article_query = "DELETE FROM jornal WHERE IDJournal = @id";


                string delete_composition_query = "DELETE FROM composition WHERE IDJournal = @id";
                // Start a transaction
                var transaction = RequestConnect.BeginTransaction();
                var compositionDeletedRow = RequestConnect.Execute(delete_composition_query, new { id });

                var articleDeletedRow = RequestConnect.Execute(delete_article_query, new { id });
                // Commit the transaction
                transaction.Commit();
                return articleDeletedRow;
            }
            finally
            {
                RequestConnect.Close();
            }
        }
        public int UpdateNewspaper(int id, string old_titre, DateTime? old_DtParution, string new_titre, DateTime new_DtParution)
        {
            try
            {
                RequestConnect.Open();
                string query = "UPDATE journal SET Titre = @new_titre, DtParution= new_DtParution  WHERE  Titre = @old_titre AND DtParution= old_DtParution;";
                var updated = RequestConnect.Execute(query, new { id, old_titre, old_DtParution, new_titre, new_DtParution });
                if (updated > 0)
                {
                    MessageBox.Show($"le journal numéro: {id} de:{old_titre} à bien été mis à jour avec comme titre: {new_titre}.");
                }
                else
                {
                    MessageBox.Show($"la mise à jour du jornal: {old_titre} n°:{id} n'a pas réussie.");
                }
                return updated;
            }
            finally
            {
                RequestConnect.Close();
            }


        }
        #endregion

    }
}

