using Dapper;
using MySql.Data.MySqlClient;
using WinFormsApp1.Properties;


namespace WinFormsApp1
{

    internal class DBconnect
    {
        MySqlConnection RequestConnect = new(Settings.Default.stringConnectionnection);

        #region article queries
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

                var articleQuery = "INSERT ignore INTO article (Titre,Corps,Auteur) VALUES (@titre, @corps, @auteur); SELECT LAST_INSERT_ID()";

                var lastinsertid = RequestConnect.Query<int>(articleQuery, new { titre, corps, auteur, });

                if (lastinsertid.Single() > 0)
                {
                    MessageBox.Show($"l'article de: {auteur} intitulé: {titre} à bien été enregistré.");

                    return lastinsertid.Single();
                }
                else
                {
                    MessageBox.Show($"l'article de: {auteur} intitulé: {titre} n'à pas été enregistré.");
                    return lastinsertid.Single();
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

                return updated;
            }
            finally
            {
                RequestConnect.Close();
            }


        }

        public bool DeleteArticle(int id)
        {
            {
                try
                {

                    RequestConnect.Open();



                    var isInComposition = RequestConnect.QuerySingle<int>("SELECT COUNT(*) FROM composition WHERE IDArticle = @id;", new { id });
                    if (isInComposition > 0)
                    {
                        MessageBox.Show($"L'article n°{id} est impossible à supprimer car il appartient au moins à un journal.");
                        return false;
                        RequestConnect.Close();
                    }
                    int rowsAffected = RequestConnect.Execute("DELETE FROM article WHERE IDArticle = @id;", new { id });
                    RequestConnect.Close();

                    return rowsAffected > 0;
                }
                catch (Exception)
                {

                    MessageBox.Show("Erreur lors de la suppression!");
                    return false;
                }
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

                var query = "INSERT  ignore INTO journal (Titre,DtParution) VALUES (@titre, @DtParution);";

                var res = RequestConnect.Execute(query, new { titre, DtParution });

                return res;
            }

            finally { RequestConnect.Close(); }
        }
        public int DeleteNewspaper(int id)
        {
            try
            {
                string delete_journal_query = "DELETE FROM journal WHERE IDJournal = @id";
                RequestConnect.Execute(delete_journal_query, new { id });
                RequestConnect.Open();



                var journalDeletedRow = RequestConnect.Execute(delete_journal_query, new { id });

                return journalDeletedRow;
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
                string query = "UPDATE journal SET Titre = @new_titre, DtParution= @new_DtParution  WHERE  Titre = @old_titre AND DtParution= @old_DtParution;";
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

