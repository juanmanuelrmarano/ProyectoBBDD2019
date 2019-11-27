using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Proyecto
{
    public class SQL
    {
        SqlConnection conn = new SqlConnection();
        public SQL()
        {
            conn.ConnectionString = "Data Source=DESKTOP-E31OHRC;Initial Catalog=paquete;Integrated Security=True";
            conn.Open();
        }

        public Boolean buscarUsuario(String NUsuario, String Contrasena)
        {
            SqlCommand consultaUsuario = new SqlCommand("SELECT Nombre_Apellido FROM usuario where Nombre_Apellido = @Usuario AND Contrasena = @Contra", conn);
            consultaUsuario.Parameters.Add(new SqlParameter("Contra", Contrasena));
            consultaUsuario.Parameters.Add(new SqlParameter("Usuario", NUsuario));
            consultaUsuario.ExecuteNonQuery();
            if (consultaUsuario.ExecuteScalar() == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public String obtenerPermiso(String NUsuario)
        {
            String permiso = "";
            SqlCommand consultaPermiso = new SqlCommand("SELECT Permiso FROM usuario where Nombre_Apellido = @Usuario", conn);
            consultaPermiso.Parameters.Add(new SqlParameter("Usuario", NUsuario));
            using (SqlDataReader reader = consultaPermiso.ExecuteReader())
            {
                while (reader.Read())
                {
                    permiso = reader[0].ToString();
                    Console.WriteLine(permiso);
                }
            }
            return permiso;
        }

        public int obtenerUltimoPaqueteID()
        {
            int ID = 0;
            SqlCommand consulta = new SqlCommand("SELECT MAX(ID_Paq) FROM paquete", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return ID;
        }

        public int obtenerUltimopaq_excID()
        {
            int ID = 0;
            SqlCommand consulta = new SqlCommand("SELECT MAX(ID) FROM paq_exc", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return ID;
        }
        
        public int obtenerUltimoClienteID()
        {
            int ID = 0;
            SqlCommand consulta = new SqlCommand("SELECT MAX(N_Clie) FROM cliente", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return ID;
        }

        public int obtenerUltimoPresupuestoID()
        {
            int ID = 0;
            SqlCommand consulta = new SqlCommand("SELECT MAX(N_Pres) FROM presupuesto", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return ID;
        }

        public int obtenerUltimaReservaID()
        {
            int ID = 0;
            SqlCommand consulta = new SqlCommand("SELECT MAX(Cod_Res) FROM reserva", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return ID;
        }

        public void agregarCliente(String Nombre, String Apellido, String Direccion, String Tel, String Email)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO cliente VALUES(@ID,@Nombre_Apellido,@Direccion,@Tel,@Email)", conn);
            insert.Parameters.Add(new SqlParameter("ID", obtenerUltimoClienteID() + 1));
            insert.Parameters.Add(new SqlParameter("Nombre_Apellido", Nombre + " " + Apellido));
            insert.Parameters.Add(new SqlParameter("Direccion", Direccion));
            insert.Parameters.Add(new SqlParameter("Tel", Tel));
            insert.Parameters.Add(new SqlParameter("Email", Email));
            insert.ExecuteNonQuery();
        }

        public void borrarExc(int IDexc)
        {
            SqlCommand delete = new SqlCommand("DELETE FROM paq_exc WHERE ID_Excur = @IDExc AND ID_Paq = @IDPaq", conn);
            delete.Parameters.Add(new SqlParameter("IDExc", IDexc));
            delete.Parameters.Add(new SqlParameter("IDPaq", Globales.IDpaquete));
            delete.ExecuteNonQuery();
        }

        public void agregarExc(int IDexc)
        {
            SqlCommand delete = new SqlCommand("INSERT INTO paq_exc VALUES (@ID,@IDPaq,@IDExc)", conn);
            delete.Parameters.Add(new SqlParameter("ID", obtenerUltimopaq_excID() + 1));
            delete.Parameters.Add(new SqlParameter("IDExc", IDexc));
            delete.Parameters.Add(new SqlParameter("IDPaq", Globales.IDpaquete));
            delete.ExecuteNonQuery();
        }

        public int crearPaquete(int ID_Dest, int ID_Hotel, int ID_Transp, DateTime fchSal, DateTime fchLle)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO paquete VALUES(@ID,@IDDest,@IDHotel,@IDTransp,@fechaSal,@fechaLle)", conn);
            insert.Parameters.Add(new SqlParameter("ID", obtenerUltimoPaqueteID() + 1));
            insert.Parameters.Add(new SqlParameter("IDDest", ID_Dest));
            insert.Parameters.Add(new SqlParameter("IDHotel", ID_Hotel));
            insert.Parameters.Add(new SqlParameter("IDTransp", ID_Transp));
            insert.Parameters.Add(new SqlParameter("fechaSal", fchSal));
            insert.Parameters.Add(new SqlParameter("fechaLle", fchLle));
            insert.ExecuteNonQuery();
            Globales.IDpaquete = obtenerUltimoPaqueteID();
            return obtenerUltimoPaqueteID();
        }

        public void crearPresupuesto(int N_Clie, int ID_Paq)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO presupuesto VALUES(@ID,@NClie,@IDPaq,@FEmision,@Vigencia,@Costo)", conn);
            insert.Parameters.Add(new SqlParameter("ID", obtenerUltimoPresupuestoID() + 1));
            insert.Parameters.Add(new SqlParameter("NClie", N_Clie));
            insert.Parameters.Add(new SqlParameter("IDPaq", ID_Paq));
            insert.Parameters.Add(new SqlParameter("FEmision", DateTime.Today));
            insert.Parameters.Add(new SqlParameter("Vigencia", DateTime.Today.AddDays(10)));
            insert.Parameters.Add(new SqlParameter("Costo", Globales.precioPaquete));
            insert.ExecuteNonQuery();
        }

        public Boolean verificarCliente(int NroCliente)
        {
            SqlCommand consulta = new SqlCommand("SELECT N_Clie FROM cliente", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public Boolean verificarPres(int NroPres)
        {
            SqlCommand consulta = new SqlCommand("SELECT N_Pres FROM presupuesto", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public Boolean verificarDestino(int IDest)
        {
            SqlCommand consulta = new SqlCommand("SELECT ID_Dest, Plazas FROM destino", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (IDest == reader.GetInt32(0))
                        {
                            if (reader.GetInt32(1) == 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public int devolverPrecioHotel(int IdHotel)
        { 
            SqlCommand consulta = new SqlCommand("SELECT ID_Hotel, Precio FROM hotel", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (IdHotel == reader.GetInt32(0))
                    {
                        return reader.GetInt32(1);
                    }
                }
            }
            return 0;
        }

        public int devolverPrecioTrans(int IdTrans)
        {
            SqlCommand consulta = new SqlCommand("SELECT ID_Trans, Precio FROM transporte", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (IdTrans == reader.GetInt32(0))
                    {
                        return reader.GetInt32(1);
                    }
                }
            }
            return 0;
        }

        public int obtenerPaqueteID(int N_Pres)
        {
            SqlCommand consulta = new SqlCommand("SELECT N_Pres, ID_Paq FROM presupuesto", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (N_Pres == reader.GetInt32(0))
                    {
                        return reader.GetInt32(1);
                    }
                }
            }
            return 0;
        }

        public int obtenerPrecioPaquete(int IDPres)
        {
            SqlCommand consulta = new SqlCommand("SELECT N_pres, ID_Paq FROM presupuesto", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (IDPres == reader.GetInt32(0))
                    {
                        return reader.GetInt32(1);
                    }
                }
            }
            return 0;
        }

        public void crearReserva_Comprobante(int N_Pres, int Sena, int NroCliente)
        {
            int precio = obtenerPrecioPaquete(N_Pres);
            int IDPaq = obtenerPaqueteID(N_Pres);

            SqlCommand insert = new SqlCommand("INSERT INTO reserva VALUES(@Cod_Res,@N_Pres,@Sena,@Total,@Fecha)", conn);
            insert.Parameters.Add(new SqlParameter("Cod_Res", obtenerUltimaReservaID() + 1));
            insert.Parameters.Add(new SqlParameter("N_Pres", N_Pres));
            insert.Parameters.Add(new SqlParameter("Sena", Sena));
            insert.Parameters.Add(new SqlParameter("Total", precio));
            insert.Parameters.Add(new SqlParameter("Fecha", DateTime.Today));
            insert.ExecuteNonQuery();

            insert.CommandText = ("INSERT INTO comprobante VALUES(@Cod_Res1,@IDPaq,@Cliente)");
            insert.Parameters.Add(new SqlParameter("Cod_Res1", obtenerUltimaReservaID()));
            insert.Parameters.Add(new SqlParameter("IDPaq", IDPaq));
            insert.Parameters.Add(new SqlParameter("Cliente", NroCliente));
            insert.ExecuteNonQuery();
        }

        public void actualizarPlazas(int IDest)
        {
            SqlCommand update = new SqlCommand("UPDATE destino SET Plazas = Plazas - 1 WHERE ID_Dest = @IDest", conn);
            update.Parameters.Add(new SqlParameter("IDest", IDest));
            update.ExecuteNonQuery();
        }

        public void crearUsuario(String Nombre, String Contra)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO usuario VALUES(@ID,@Nombre,@Contra,@Permiso)", conn);
            insert.Parameters.Add(new SqlParameter("ID", obtenerUltimousuarioID() + 1));
            insert.Parameters.Add(new SqlParameter("Nombre", Nombre));
            insert.Parameters.Add(new SqlParameter("Contra", Contra));
            insert.Parameters.Add(new SqlParameter("Permiso", "Empleado"));
            insert.ExecuteNonQuery();
        }

        public int obtenerUltimousuarioID()
        {
            int ID = 0;
            SqlCommand consulta = new SqlCommand("SELECT MAX(ID) FROM usuario", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return ID;
        }

        public int obtenerUltimoDestinoID()
        {
            int ID = 0;
            SqlCommand consulta = new SqlCommand("SELECT MAX(ID_Dest) FROM destino", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return ID;
        }

        public int obtenerUltimaExcursionID()
        {
            int ID = 0;
            SqlCommand consulta = new SqlCommand("SELECT MAX(ID_Excur) FROM excursion", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return ID;
        }

        public int obtenerUltimoHotelID()
        {
            int ID = 0;
            SqlCommand consulta = new SqlCommand("SELECT MAX(ID_Hotel) FROM hotel", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return ID;
        }

        public int obtenerUltimoTransporteID()
        {
            int ID = 0;
            SqlCommand consulta = new SqlCommand("SELECT MAX(ID_Hotel) FROM hotel", conn);
            using (SqlDataReader reader = consulta.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[0]))
                    {
                        ID = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return ID;
        }


        //ABM

        public void crearDestino(String nombreLoc)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO destino VALUES(@ID_Dest,@Nombre_Localidad,@Plazas)", conn);
            insert.Parameters.Add(new SqlParameter("ID_Dest", obtenerUltimoDestinoID() + 1));
            insert.Parameters.Add(new SqlParameter("Nombre_Localidad", nombreLoc));
            insert.Parameters.Add(new SqlParameter("Plazas", 20));
            insert.ExecuteNonQuery();
        }

        public void modificarDestino(int IDest, String nombreLoc)
        {
            SqlCommand update = new SqlCommand("UPDATE destino SET Nombre_Localidad = @Nombre_Localidad WHERE ID_Dest = @IDest", conn);
            update.Parameters.Add(new SqlParameter("IDest", IDest));
            update.Parameters.Add(new SqlParameter("Nombre_Localidad", nombreLoc));
            update.ExecuteNonQuery();
        }

        public void crearExcursion(int ID_Dest, String Actividad, String Duracion, int Precio, int Plazas, DateTime Fecha)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO excursion VALUES(@ID_Excur,@ID_Dest,@Actividad,@Duracion,@Precio,@Plazas,@Fecha_Realizacion)", conn);
            insert.Parameters.Add(new SqlParameter("ID_Excur", obtenerUltimaExcursionID() + 1));
            insert.Parameters.Add(new SqlParameter("ID_Dest", ID_Dest));
            insert.Parameters.Add(new SqlParameter("Actividad", Actividad));
            insert.Parameters.Add(new SqlParameter("Duracion", Duracion));
            insert.Parameters.Add(new SqlParameter("Precio", Precio));
            insert.Parameters.Add(new SqlParameter("Plazas", Plazas));
            insert.Parameters.Add(new SqlParameter("Fecha_Realizacion", Fecha));
            insert.ExecuteNonQuery();
        }

        public void modificarExcursion(int ID_Excur, int ID_Dest, String Actividad, String Duracion, int Precio, int Plazas, DateTime Fecha)
        {
            SqlCommand insert = new SqlCommand("UPDATE excursion SET ID_Dest = @ID_Dest, Actividad = @Actividad, Duracion = @Duracion, Precio = @Precio, Plazas = @Plazas, Fecha_Realizacion = @Fecha_Realizacion WHERE ID_Excur = @ID_Excur", conn);
            insert.Parameters.Add(new SqlParameter("ID_Excur", ID_Excur));
            insert.Parameters.Add(new SqlParameter("ID_Dest", ID_Dest));
            insert.Parameters.Add(new SqlParameter("Actividad", Actividad));
            insert.Parameters.Add(new SqlParameter("Duracion", Duracion));
            insert.Parameters.Add(new SqlParameter("Precio", Precio));
            insert.Parameters.Add(new SqlParameter("Plazas", Plazas));
            insert.Parameters.Add(new SqlParameter("Fecha_Realizacion", Fecha));
            insert.ExecuteNonQuery();
        }

        public void crearHotel(String Nombre, String TipoHotel, int ID_Dest, int Precio, int Plazas, int Categoria, String Descripcion)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO hotel VALUES(@ID_Hotel,@Nombre,@Tipo_Hotel,@ID_Dest,@Precio,@Plazas,@Categoria,@Descripcion)", conn);
            insert.Parameters.Add(new SqlParameter("ID_Hotel", obtenerUltimoHotelID() + 1));
            insert.Parameters.Add(new SqlParameter("Nombre", Nombre));
            insert.Parameters.Add(new SqlParameter("Tipo_Hotel", TipoHotel));
            insert.Parameters.Add(new SqlParameter("ID_Dest", ID_Dest));
            insert.Parameters.Add(new SqlParameter("Precio", Precio));
            insert.Parameters.Add(new SqlParameter("Plazas", Plazas));
            insert.Parameters.Add(new SqlParameter("Categoria", Categoria));
            insert.Parameters.Add(new SqlParameter("Descripcion", Descripcion));
            insert.ExecuteNonQuery();
        }

        public void modificarHotel(int ID_Hotel, String Nombre, String TipoHotel, int ID_Dest, int Precio, int Plazas, int Categoria, String Descripcion)
        {
            SqlCommand insert = new SqlCommand("UPDATE hotel SET Nombre = @Nombre, Tipo_Hotel = @Tipo_Hotel, ID_Dest = @ID_Dest, Precio = @Precio, Plazas = @Plazas, Categoria = @Categoria, Descripcion = @Descripcion WHERE ID_Hotel = @ID_Hotel", conn);
            insert.Parameters.Add(new SqlParameter("ID_Hotel", ID_Hotel));
            insert.Parameters.Add(new SqlParameter("Nombre", Nombre));
            insert.Parameters.Add(new SqlParameter("Tipo_Hotel", TipoHotel));
            insert.Parameters.Add(new SqlParameter("ID_Dest", ID_Dest));
            insert.Parameters.Add(new SqlParameter("Precio", Precio));
            insert.Parameters.Add(new SqlParameter("Plazas", Plazas));
            insert.Parameters.Add(new SqlParameter("Categoria", Categoria));
            insert.Parameters.Add(new SqlParameter("Descripcion", Descripcion));
            insert.ExecuteNonQuery();
        }

        public void crearTransporte(String Medio, int ID_Dest, String Descripcion, String Empresa, int Precio, int Plazas)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO transporte VALUES(@ID_Trans,@Medio,@ID_Dest,@Descripcion,@Empresa,@Precio,@Plazas)", conn);
            insert.Parameters.Add(new SqlParameter("ID_Trans", obtenerUltimoTransporteID() + 1));
            insert.Parameters.Add(new SqlParameter("Medio", Medio));
            insert.Parameters.Add(new SqlParameter("ID_Dest", ID_Dest));
            insert.Parameters.Add(new SqlParameter("Descripcion", Descripcion));
            insert.Parameters.Add(new SqlParameter("Empresa", Empresa));
            insert.Parameters.Add(new SqlParameter("Precio", Precio));
            insert.Parameters.Add(new SqlParameter("Plazas", Plazas));
            insert.ExecuteNonQuery();
        }

        public void modificarTransporte(int ID_Trans, String Medio, int ID_Dest, String Descripcion, String Empresa, int Precio, int Plazas)
        {
            SqlCommand insert = new SqlCommand("UPDATE transporte SET Medio = @Medio, ID_Dest = @ID_Dest, Descripcion = @Descripcion, Empresa = @Empresa, Precio = @Precio, Plazas = @Plazas WHERE ID_Trans = @ID_Trans", conn);
            insert.Parameters.Add(new SqlParameter("ID_Trans", ID_Trans));
            insert.Parameters.Add(new SqlParameter("Medio", Medio));
            insert.Parameters.Add(new SqlParameter("ID_Dest", ID_Dest));
            insert.Parameters.Add(new SqlParameter("Descripcion", Descripcion));
            insert.Parameters.Add(new SqlParameter("Empresa", Empresa));
            insert.Parameters.Add(new SqlParameter("Precio", Precio));
            insert.Parameters.Add(new SqlParameter("Plazas", Plazas));
            insert.ExecuteNonQuery();
        }

        public void borrarTupla(String tabla, String nombreCol, int ID)
        {
            SqlCommand delete = new SqlCommand("DELETE FROM "+ tabla +" WHERE ID_"+nombreCol+" = @ID", conn);
            delete.Parameters.Add(new SqlParameter("ID", ID));
            delete.ExecuteNonQuery();
        }
    }
}
