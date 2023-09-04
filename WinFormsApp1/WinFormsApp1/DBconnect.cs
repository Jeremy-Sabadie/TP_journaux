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
    }
}
