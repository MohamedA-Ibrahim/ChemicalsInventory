using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace ChemicalsInventory.Logic
{
    public class SqliteDataAccess
    {
        #region Database

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        #endregion

        #region Users

        public static List<UserModel> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("Select * from User", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void AddUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Insert into User (UserName, UserPassword) values (@UserName, @UserPassword)", user);
            }
        }

        public static void UpdateUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Update User set UserName=@UserName, UserPassword=@UserPassword  where UserId=@UserId", user);
            }
        }

        public static UserModel GetUserByUserName(string userName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("Select * from User where UserName =@UserName", new {UserName= userName }).FirstOrDefault();
                return output;
            }
        }

        #endregion

        #region Chemicals

        public static List<ChemicalModel> LoadChemicals()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ChemicalModel>("Select * from Chemical", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void AddChemical(ChemicalModel chemical)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Insert into Chemical (ChemicalName, ChemicalQuantity) values (@ChemicalName, @ChemicalQuantity)", chemical);
            }
        }

        public static void RemoveChemical(ChemicalModel chemical)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Delete from Chemical where ChemicalId=@ChemicalId", chemical);
            }
        }


        public static void UpdateChemical(ChemicalModel chemical)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Update Chemical set ChemicalName = @ChemicalName, ChemicalQuantity = @ChemicalQuantity", chemical);
            }

        }

        public static ChemicalModel GetChemicalById(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ChemicalModel>("Select * from Chemical where ChemicalId =@ChemicalId", new { ChemicalId = id }).FirstOrDefault();
                return output;
            }
        }

        #endregion


    }
}
