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

        #region Items

        public static List<ItemModel> LoadItems()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ItemModel>("Select ItemName, ItemQuantity,Category.CategoryId,Category.CategoryName,ItemUnit from Item inner join Category on Item.CategoryId = Category.CategoryId ", new DynamicParameters());

                return output.ToList();
            }
        }

        public static List<ItemModel> LoadItemsByCategory(int categoryId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ItemModel>("select ItemId, ItemName,Category.CategoryId, Category.CategoryName from Item inner join Category on Item.CategoryId = Category.CategoryId where Item.CategoryId = @CategoryId", new { CategoryId = categoryId });

                return output.ToList();
            }
        }


        public static void AddItem(ItemModel Item)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Insert into Item (ItemName, ItemQuantity,CategoryId,ItemUnit) values (@ItemName, @ItemQuantity,@CategoryId,@ItemUnit)", Item);
            }
        }

        public static void RemoveItem(ItemModel Item)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Delete from Item where ItemId=@ItemId", Item);
            }
        }


        public static void UpdateItem(ItemModel Item)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Update Item set ItemQuantity = @ItemQuantity where ItemID =@ItemId", Item);
            }

        }

        public static ItemModel GetItemById(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ItemModel>("Select * from Item where ItemId =@ItemId", new { ItemId = id }).FirstOrDefault();
                return output;
            }
        }

        #endregion

        #region Category

        public static List<CategoryModel> LoadCategory()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("Select * from Category", new DynamicParameters());

                return output.ToList();
            }
        }

        public static void AddCategory(CategoryModel Category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Insert into Category (CategoryName) values (@CategoryName)", Category);
            }
        }

        public static void RemoveCategory(CategoryModel Category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Delete from Category where CategoryId=@CategoryId", Category);
            }
        }


        public static void UpdateCategory(CategoryModel Category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Update Category set CategoryName = @CategoryName where CategoryID =@CategoryId", Category);
            }

        }

        public static CategoryModel GetCategoryById(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("Select * from Category where CategoryId =@CategoryId", new { CategoryId = id }).FirstOrDefault();
                return output;
            }
        }
        #endregion

    }
}
