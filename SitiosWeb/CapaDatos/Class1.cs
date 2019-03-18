using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class Class1
    {
			DataTable dt = new DataTable();
			DataBaseDataContext Db = new DataBaseDataContext();
			public DataTable retrr(string User, string password)
			{
				 var o = Db.inser(User, password);
				 /*foreach (var dato in o)
				 {
					 this.dt.Rows.Add(dato.id, dato.nombre, dato.sexo);
				 }*/
				return this.dt;
            
			}
    }
}
