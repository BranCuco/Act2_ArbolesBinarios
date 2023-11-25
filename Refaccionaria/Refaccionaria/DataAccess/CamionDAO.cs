using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refaccionaria.DataAccess
{
    public class CamionDAO
    {
        private string _conexion = "Data Source=RICARDO\\SQLEXPRESS;Initial Catalog=Refaccionaria;Integrated Security=True;Connect Timeout=30";


        public Camion[] RegresaCamiones()
        {
           List<Camion> camiones = new List<Camion>();

            using (SqlConnection conexion = new SqlConnection(_conexion))
            {
                string consulta = "SELECT Idcamion, Nombre, Totalmacenaje, Marca, Placas FROM Camion";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while(lector.Read())
                        {
                            Camion camion = new Camion
                            {
                                Clave = Convert.ToInt32(lector["Idcamion"]),
                                Nombre = lector["Nombre"].ToString(),
                                Tonelaje = Convert.ToDecimal(lector["Totalmacenaje"]),
                                Marca = lector["Marca"].ToString(),
                                Placas = lector["Placas"].ToString()
                            };

                            camiones.Add(camion);
                        }
                    }
                }

                return camiones.ToArray();
            }
        }

    }
}
