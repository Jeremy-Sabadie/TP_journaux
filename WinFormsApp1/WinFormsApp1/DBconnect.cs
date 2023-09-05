using Dapper;
using MySql.Data.MySqlClient;
using WinFormsApp1.Properties;


namespace WinFormsApp1
{

    internal class DBconnect
    {
        MySqlConnection RequestConnect = new(Settings.Default.stringConnectionnection);
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
        public int InsertArticle(string titre, string corps, string auteur)
        {
            try
            {
                RequestConnect.Open();


                var Request = "INSERT ignore INTO article (Titre,Corps,Auteur) VALUES (@titre, @corps, @auteur); SELECT LAST_INSERT_ID()";
                var result = RequestConnect.Query<int>(Request, new { titre, corps, auteur });
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
        public int DeleteArticle(int id)
        {
            try
            {
                RequestConnect.Open();

                string query = "DELETE FROM  article WHERE IDArticle = @id;";

                var deletedRow = RequestConnect.Execute(query, new { id });
                return deletedRow;
            }
            finally
            {
                RequestConnect.Close();
            }
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
                    MessageBox.Show($"article: {old_titre} de:{old_auteur} à bien été mis à jour.");
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
    }
}

