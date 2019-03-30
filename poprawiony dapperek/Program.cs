using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace poprawiony_dapperek 
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection("Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=uzytkownicy;Integrated Security=True"))
            {

                //connection.Execute("INSERT INTO dbo.pracownicy (imie, nazwisko) Values(@imie, @nazwisko)", new[] {
                //  new {imie = "lidka", nazwisko="drobisz" },
                //new { imie = "mania", nazwisko="kupinska" },
                //new { imie = "nina", nazwisko="kupinska" }
                //});
                string sql = "delete dbo.pracownicy where id=@id and nazwisko=@nazwisko";
                //connection.Execute("update dbo.pracownicy set imie=@imie where id=@id ", new { imie = "mirek", id = 25 });

                //connection.Execute(sql, new { id = 21, nazwisko = "rafalska" });
                //string sql1 = "select * from dbo.Pracownicy where nazwisko=@nazwisko";

                //var pracownicy = connection.Query<Pracownik>(sql1, new { nazwisko = "nowak" }).ToList();

                //connection.Execute("INSERT INTO dbo.pracownicy (imie, nazwisko) Values(@imie, @nazwisko)", new { imie = "zosia", nazwisko = "kupinska" });
                var pracownicy = connection.Query<Pracownik>("select * from dbo.Pracownicy").ToList();
                //var pracownicy = connection.QueryFirst("select * from dbo.Pracownicy where imie=@imie", new { imie = "wacek" });
                //var pracownicy = connection.Query<Pracownik>("wyswietl", new { imie = "lidka" }, commandType:System.Data.CommandType.StoredProcedure).ToList();
                //Console.WriteLine(pracownicy);
                foreach (var worker in pracownicy)
                {
                    Console.WriteLine(worker.id + " " + worker.imie + " " + worker.nazwisko);
                }


            }
            Console.ReadKey();
        }

       


    }
    



}


