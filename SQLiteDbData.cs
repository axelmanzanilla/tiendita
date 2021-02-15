using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDb
{
    public class Usuario
    {
        public string Id { get; }
        public string FName { get; }
        public string LName { get; }
        public string Email { get; }
        public string Password { get; }
        public string Street { get; }
        public int CP { get; }
        public bool State { get; }
        public bool Active { get; }
        public string FullName { get { return $"{FName} {LName}"; } }
        public string Address { get { return $"{Street} {CP}"; } }

        public Usuario(string id, string fname, string lname, string email, string pass, string street, int cp, bool state, bool active)
        {
            Id = id;
            FName = fname;
            LName = lname;
            Email = email;
            Password = pass;
            Street = street;
            CP = cp;
            State = state;
            Active = active;
        }
    }

    public class Tarjeta
    {
        public string Id { get; }
        public string Description { get; }
        public decimal Price { get; }
        public int Quan { get; }
        public string Type { get; }
        public string Brand { get; }

        public Tarjeta(string id, string description, decimal price, int quan, string type, string brand)
        {
            Id = id;
            Description = description;
            Price = price;
            Quan = quan;
            Type = type;
            Brand = brand;
        }
    }

    public class CreditCard
    {
        public string Id { get; }
        public string IdUser { get; }
        public string Number { get; }
        public int Month { get; }
        public int Year { get; }
        public int Cvv { get; }

        public CreditCard(string id, string idUser, string number, int month, int year, int cvv)
        {
            Id = id;
            IdUser = idUser;
            Number = number;
            Month = month;
            Year = year;
            Cvv = cvv;
        }
    }

    public class Carrito
    {
        public string IdUser { get; }
        public string IdProducto { get; }
        public int Cantidad { get; }

        public Carrito(string idUser, string idProducto, int cantidad)
        {
            IdUser = idUser;
            IdProducto = idProducto;
            Cantidad = cantidad;
        }
    }


    public partial class SQLiteConn
    {
        public List<Usuario> GetUsers()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SQLiteRecordSet rs = ExecuteQuery("SELECT " +
                "u.id, u.fname, u.lname, u.correo, u.contraseña, " +
                "d.direccion, d.codigopostal, u.estado, u.active " +
                "FROM Usuario u " +
                "INNER JOIN Direcciones d ON (u.id = d.id);"))
            {
                while (rs.NextRecord())
                {
                    usuarios.Add(new Usuario(rs.GetString("id"),
                                             rs.GetString("fname"),
                                             rs.GetString("lname"),
                                             rs.GetString("correo"),
                                             rs.GetString("contraseña"),
                                             rs.GetString("direccion"),
                                             rs.GetInt32("codigopostal"),
                                             Convert.ToBoolean(rs.GetInt32("estado")),
                                             Convert.ToBoolean(rs.GetInt32("active"))));
                }
            }
            return usuarios;
        }

        public List<Tarjeta> GetTarjetas()
        {
            List<Tarjeta> tarjetas = new List<Tarjeta>();

            using (SQLiteRecordSet rs = ExecuteQuery("SELECT " +
                "p.codigo, p.descripcion, p.precio, p.cantidad, t.Tipo, m.marca " +
                "FROM Productos p " +
                "INNER JOIN Tipo_Producto t ON (p.tipo_id = t.id) " +
                "INNER JOIN Marca m ON (p.marca_id = m.id);"))
            {
                while (rs.NextRecord())
                {
                    tarjetas.Add(new Tarjeta(rs.GetString("codigo"),
                                             rs.GetString("descripcion"),
                                             Convert.ToDecimal(rs.GetDouble("precio")),
                                             rs.GetInt32("cantidad"),
                                             rs.GetString("Tipo"),
                                             rs.GetString("marca")));
                }
            }
            return tarjetas;
        }

        public Tarjeta GetTarjeta(string id)
        {
            Tarjeta tarjeta = null;

            using (SQLiteRecordSet rs = ExecuteQuery("SELECT " +
                "p.codigo, p.descripcion, p.precio, p.cantidad, t.Tipo, m.marca " +
                "FROM Productos p " +
                "INNER JOIN Tipo_Producto t ON (p.tipo_id = t.id) " +
                "INNER JOIN Marca m ON (p.marca_id = m.id) " +
                $"WHERE p.codigo = {id};"))
            {
                while (rs.NextRecord())
                {
                    tarjeta = new Tarjeta(Convert.ToString(rs.GetString("codigo")),
                                             rs.GetString("descripcion"),
                                             Convert.ToDecimal(rs.GetDouble("precio")),
                                             rs.GetInt32("cantidad"),
                                             rs.GetString("tipo"),
                                             rs.GetString("marca"));
                }
            }
            return tarjeta;
        }

        public List<CreditCard> GetCreditCardsById(string id)
        {
            List<CreditCard> tarjetas = new List<CreditCard>();

            using (SQLiteRecordSet rs = ExecuteQuery("SELECT " +
                "t.id, t.usuario_id, t.numero_tarjeta, " +
                "t.mes_exp, t.año_exp, t.cvv " +
                "FROM Tarjetas t " +
                $"WHERE t.usuario_id = {id};"))
            {
                while (rs.NextRecord())
                {
                    tarjetas.Add(new CreditCard(rs.GetString("id"),
                                             rs.GetString("usuario_id"),
                                             rs.GetString("numero_tarjeta"),
                                             rs.GetInt32("mes_exp"),
                                             rs.GetInt32("año_exp"),
                                             rs.GetInt32("cvv")));
                }
            }
            return tarjetas;
        }

        public List<CreditCard> GetCreditCards()
        {
            List<CreditCard> tarjetas = new List<CreditCard>();

            using (SQLiteRecordSet rs = ExecuteQuery("SELECT * FROM Tarjetas"))
            {
                while (rs.NextRecord())
                {
                    tarjetas.Add(new CreditCard(rs.GetString("id"),
                                       rs.GetString("usuario_id"),
                                       rs.GetString("numero_tarjeta"),
                                       rs.GetInt32("mes_exp"),
                                       rs.GetInt32("año_exp"),
                                       rs.GetInt32("cvv")));
                }
            }
            return tarjetas;
        }

        public List<Carrito> GetCompras()
        {
            List<Carrito> carritos = new List<Carrito>();

            using (SQLiteRecordSet rs = ExecuteQuery("SELECT * FROM Carrito;"))
            {
                while (rs.NextRecord())
                {
                    carritos.Add(new Carrito(rs.GetString("id_user"),
                                             rs.GetString("id_producto"),
                                             rs.GetInt32("cantidad")));
                }
            }
            return carritos;
        }
        public List<Carrito> GetComprasById(string id)
        {
            List<Carrito> carritos = new List<Carrito>();

            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT * FROM Carrito WHERE id_user = {id};"))
            {
                while (rs.NextRecord())
                {
                    carritos.Add(new Carrito(rs.GetString("id_user"),
                                             rs.GetString("id_producto"),
                                             rs.GetInt32("cantidad")));
                }
            }
            return carritos;
        }

        //public List<Tarjeta> SearchTarjetas(string text)
        //{
        //    List<Tarjeta> tarjetas = new List<Tarjeta>();

        //    using (SQLiteRecordSet rs = ExecuteQuery($"SELECT * FROM Productos WHERE descripcion LIKE = '%{text}%';"))
        //    {
        //        while (rs.NextRecord())
        //        {
        //            tarjetas.Add(new Tarjeta(rs.GetString("codigo"),
        //                                     rs.GetString("descripcion"),
        //                                     rs.GetDecimal("precio"),
        //                                     rs.GetInt32()));
        //        }
        //    }
        //    return tarjetas;
        //}
    }
}
