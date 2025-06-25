using AccesoDatosWinForm.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosWinForm.data
{
    class DAOCategory
    {
        AccesoDatosMySql  _ad = null;

        public bool insert(Category category) {
            var resultado = false;
            using (_ad = new
                AccesoDatosMySql("localhost", "nwind",
                "root", "700r", 3306))
            {
                var parm = new Dictionary<string, object>
                {
                    { "@CategoryName", category.CategoryName },
                    { "@Description", category.Description }
                };
                var sentenciaSQL = "INSERT INTO Categories (CategoryName, Description) " +
                                   "VALUES (@CategoryName, @Description);";
                resultado = 
                    (_ad.ejecutarSentencia(sentenciaSQL, parm)>0);
            }

            return resultado;
        }

        public bool delete(int id)
        {
            using (_ad = new AccesoDatosMySql("localhost", "nwind",
                "root", "700r", 3306))
            {
                var parametro = new Dictionary<string, object>
                {
                    { "@CategoryID", id }
                };
                var sentenciaSQL = "DELETE FROM Categories WHERE " +
                    "CategoryID = @CategoryID;";
                return _ad.ejecutarSentencia(sentenciaSQL, parametro) > 0;
            }
        }

        public bool update(Category obj)
        {
            using (_ad = new AccesoDatosMySql("localhost", "nwind",
                "root", "700r", 3306))
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@CategoryID", obj.CategoryID },
                    { "@CategoryName", obj.CategoryName },
                    { "@Description", obj.Description }
                };
                var sentenciaSQL = "UPDATE Categories SET " +
                    "CategoryName = @CategoryName, " +
                    "Description = @Description " +
                    "WHERE CategoryID = @CategoryID;";
                return _ad.ejecutarSentencia(sentenciaSQL, parametros) > 0;
            }
        }

        public Category getOneById(int id)
        {
            using (_ad = new AccesoDatosMySql("localhost", "nwind",
                "root", "700r", 3306))
            {
                var parametro = new Dictionary<string, object>
                {
                    { "@CategoryID", id }
                };
                var sentencia = "Select * from Categories where CategoryID=@CategoryID";
                _ad.queryTable(sentencia, parametro);
                var dt = _ad.queryTable(sentencia, parametro);

                return new Category
                {
                    CategoryID = (int)dt.Rows[0]["CategoryID"],
                    CategoryName = dt.Rows[0]["CategoryName"].ToString(),
                    Description = dt.Rows[0]["Description"].ToString()
                };
            }
            }

        public List<Category> getAll() { 
            var lst = new List<Category>();
            
            using (_ad = new AccesoDatosMySql("localhost", "nwind",
                "root", "700r", 3306))
            {
                var query = "SELECT CategoryID, CategoryName, Description FROM Categories";
                var dt = _ad.queryTable(query, null);
                foreach (DataRow row in dt.Rows)
                {
                    lst.Add(new Category
                    {
                        CategoryID = Convert.ToInt32(row["CategoryID"]),
                        CategoryName = row["CategoryName"].ToString(),
                        Description = row["Description"].ToString()
                    });
                }
            }
            return lst;
        }
    }
}
