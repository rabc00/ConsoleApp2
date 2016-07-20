using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{

    public class BlogPost {

        public int id; public string post; public int userid; public string date;

        

        }




    







    class Program
    {
        static void Main(string[] args)
        {
           

            var blogpost = new BlogPost();
            blogpost.id = 6;
            blogpost.post = "Out Of an Object";
            blogpost.userid = 6;
            blogpost.date = "07/19/2016";
            InsertBlogPost(blogpost);
            ReadFromBlogPosts();

            ReadFromBankAccounts();
            
            Console.ReadLine();
            
        }


        static void InsertBlogPost(BlogPost blogpost) {
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=(LocalDb)\\v11.0;Initial Catalog=aspnet-firstProject-20160628191625;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO [dbo].[BlogPosts] VALUES(" + blogpost.id + ",'" + blogpost.post + "'," + blogpost.userid + ",'" + blogpost.date + "')";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

        }



        static void InsertBlogPost(int id, string post, int userid, string date)
        {

            SqlConnection sqlConnection1 = new SqlConnection("Data Source=(LocalDb)\\v11.0;Initial Catalog=aspnet-firstProject-20160628191625;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO [dbo].[BlogPosts] VALUES("+id+",'"+post+"',"+userid+",'"+date+"')";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }




        static void InsertBlogPost(){

            SqlConnection sqlConnection1 = new SqlConnection("Data Source=(LocalDb)\\v11.0;Initial Catalog=aspnet-firstProject-20160628191625;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO [dbo].[BlogPosts] VALUES(4,'this is my post today', 3,' 07/19/2016')";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }




            static void ReadFromBlogPosts(){
                    
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=(LocalDb)\\v11.0;Initial Catalog=aspnet-firstProject-20160628191625;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM BlogPosts";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.

            while (reader.Read()){
                Console.WriteLine(reader["BlogPostId"] +" "+
                reader["BlogPost"]+" "+
                reader["UserId"] + " " +
                reader["DatePosted"]);
            }

            sqlConnection1.Close();
            Console.ReadLine();
            }            
            




         static void ReadFromBankAccounts(){
                       
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=(LocalDb)\\v11.0;Initial Catalog=aspnet-firstProject-20160628191625;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM BankAccounts";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.

            while (reader.Read()){
                Console.WriteLine(reader["Id"] +" "+
                reader["fName"]+" "+
                reader["lName"] + " " +
                reader["AccNo"]+" "+
                reader["RoutingNo"]+" "+
                reader["Address"]+" "+
                reader["Balance"]+" "+ 
                reader["isActive"]);
            }

            sqlConnection1.Close();



            Console.ReadLine();
         }
            
            
            
            
            
            
            
            
            
            
            
        
   }//Class Program
}//Namespace 

