using AccesoDatosWinForm.model;
using System;
using System.Collections.Generic;
using System.Data;
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
