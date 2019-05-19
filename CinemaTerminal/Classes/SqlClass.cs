using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CinemaTerminal.Classes
{
    class SqlClass
    {

        public int Element { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Настройка БД
        public void Select()
        {
            //Подключаем БД
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Запись SQL Query
                string sql = "SELECT * FROM Film";
                //Созданин команды используя sql и conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Создание SqlAdapter испльзуя cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        //Ввод данных в БД
        public bool Insert(SqlClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO Film (Element, Name, Description, Rating) VALUES (@Element, @Name, @Description, @Rating)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Element", c.Element);
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@Description", c.Description);
                cmd.Parameters.AddWithValue("@Rating", c.Rating);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //public bool Update(SqlClass c)
        //{
        //    bool isSuccess = false;

        //    SqlConnection conn = new SqlConnection(myconnstrng);

        //    try
        //    {
        //        string sql = "UPDATE tbl_snifferdog SET FirstName = @FirstName, LastName = @LastName, Ocupation = @Ocupation, ContactNo = @ContactNo, Gender = @Gender, Experience = @Experience, Status = @Status WHERE ContactID = @ContactID";

        //        SqlCommand cmd = new SqlCommand(sql, conn);

        //        cmd.Parameters.AddWithValue("@Element", c.Element);
        //        cmd.Parameters.AddWithValue("@Name", c.Name);
        //        cmd.Parameters.AddWithValue("@Description", c.Description);
        //        cmd.Parameters.AddWithValue("@Rating", c.Rating);

        //        conn.Open();

        //        int rows = cmd.ExecuteNonQuery();

        //        if (rows > 0)
        //        {
        //            isSuccess = true;
        //        }
        //        else
        //        {
        //            isSuccess = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return isSuccess;
        //}

        //public bool Delete(SqlClass c)
        //{
        //    bool isSuccess = false;

        //    SqlConnection conn = new SqlConnection(myconnstrng);
        //    try
        //    {
        //        string sql = "DELETE FROM tbl_snifferdog WHERE ContactID = @ContactID";

        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

        //        conn.Open();
        //        int rows = cmd.ExecuteNonQuery();

        //        if (rows > 0)
        //        {
        //            isSuccess = true;
        //        }
        //        else
        //        {
        //            isSuccess = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {


        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return isSuccess;

        //}
    }
}