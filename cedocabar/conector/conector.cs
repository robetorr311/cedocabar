using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Npgsql;
using System.Collections.Generic;
using System.Text;
class DBConnect
{
    static NpgsqlConnection connection = new NpgsqlConnection();
    static string CadenaDeConexion = "server=localhost; port=5432; User Id=cedocabar; Password=c3d0c4b4r; Database=cedocabar;";
    private void OpenConnection()
    {
        if (connection.State != ConnectionState.Open)
        {
            connection.ConnectionString = CadenaDeConexion;
            //Abrimos la conexión.
            connection.Open();
        }
    }
    public static void CloseConnection()
    {
        //Cerramos la conexión.
        connection.Close();
    }
    public DataTable Smenu(int hpadre)
    {
        string sql = "";
        OpenConnection();
        if (hpadre == 0)
        {
        }
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        if (hpadre == 0)
        {
            sql = "select * from menu where hpadre is null and estatus=1 order by id;";
        }
        else
        {
            sql = "select * from menu where hpadre=" + hpadre + " and estatus=1 order by id;";
        }
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable menu = new DataTable();
        menu.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return menu;
    }
    public DataTable Susuariosmedico(string log, string pass)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from medicos " + "where " +
            "loggin='" + log +
            "' and password=md5('" + pass + "');";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Susuarios(string log, string pass)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from usuario " + "where " +
            "loggin='" + log +
            "' and password=md5('" + pass + "');";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Svgterapiaresp()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vgterapiaresp;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Svterapiaresp(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vterapiaresp " + "where " +
            "hpaciente=" + id +
            ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Svgmorbilidad()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vgmorbilidad;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Svmorbilidad(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vmorbilidad " + "where " +
            "hpaciente=" + id +
            ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Svgmedicinainterna()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vgmedicinainterna;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Svmedicinainterna(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vmedicinainterna " + "where " +
            "hpaciente=" + id +
            ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Sterapiaresp(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from terapiarespiratoria " + "where " +
            "id=" + id +
            ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Smedicinainterna(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from medicinainterna " + "where " +
            "id=" + id +
            ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Smorbilidad(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from morbilidad " + "where " +
            "id=" + id +
            ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Stipousuario()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from tipousuario order by id;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Sestatus()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from estatus where codigo in (4,5);";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SestatusP()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from estatus where codigo in (6,7,8,9,10,11,12);";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SDocumento(string iddoc)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from documento where id=" + iddoc + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SPacCardADADMIND(string numero, string hservicio, string fecha)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select numero as numero, iddoc as hdocumento, idpaciente as hpaciente, paciente.nombre as nombre,paciente.cedula as cedula, paciente.edad as edad, paciente.sexo as sexo from vnumeroscupoadm(" + hservicio + ",'" + fecha + "'), paciente where idpaciente=paciente.id and numero=" + numero + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SPacCardADIND(string numero,string hservicio, string hmedico, string fecha)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select numero as numero,  iddoc as hdocumento, idpaciente as hpaciente, paciente.nombre as nombre,paciente.cedula as cedula, paciente.edad as edad, paciente.sexo as sexo from vnumeroscupo(" + hservicio + "," + hmedico + ",'" + fecha + "'), paciente where idpaciente=paciente.id and numero="+ numero +";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SPacCardAD(string hservicio,string hmedico, string fecha)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select numero as numero, iddoc as hdocumento, idpaciente as hpaciente, paciente.nombre as nombre,paciente.cedula as cedula, paciente.edad as edad, paciente.sexo as sexo from vnumeroscupo(" + hservicio + "," + hmedico + ",'" + fecha + "'), paciente where idpaciente=paciente.id";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SPacCardADADM(string hservicio, string fecha)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select numero as numero, iddoc as hdocumento, paciente.nombre as nombre,paciente.cedula as cedula, paciente.edad as edad, paciente.sexo as sexo from vnumeroscupoadm(" + hservicio + ",'" + fecha + "'), paciente where idpaciente=paciente.id;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SExamenf(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from examenfisico where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SMorbilidad(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from morbilidad where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SExamenes()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from examenes;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SOcupacion()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from profesion;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable medicoserv(string hservicio)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select idmed as id, nombre as nombre from medicoserv(" + hservicio + ");";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SConyugal()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from conyugal;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SServiciosC()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from servicios where id between 1 and 18 order by id;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SServiciosE()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from servicios where id between 23 and 69 order by id;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SPruebas()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from pruebas;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SServicios()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from servicios;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Sserviciosmedico(string hmedico)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vstsrvmedico where hmedico=" + hmedico + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SHorarios()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from horario;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable STurnos()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from turno;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Sorg_geografica(string region_precedente)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from org_geografica where region_precedente=" + region_precedente + " order by num_region;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Svistamedicos()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vistamedicos;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Svistacajeros()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vistacajeros;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Svistapacientes()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vistapacientes;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable SLISTApacientes()
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select id, cedula, historia, nombre, edad, sexo from paciente;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Scupos(string iddoc)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from cupos where hdocumento=" + iddoc + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Sservicio_IND(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from servicios where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Sprueba_IND(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from pruebas where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Sexamenes_IND(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from examenes where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Scajeros(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vistacajeros where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Smedicos(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vistamedicos where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Scedpaciente(string cedula)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vistapacientes where cedula='" + cedula + "';";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public DataTable Spaciente(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from vistapacientes where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public string SHORA(string hservicio, string hmedico,string hturno)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select hora from serviciosmedico where hservicio=" + hservicio + " and hmedico=" + hmedico + " and hturno=" + hturno + ";";  
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("hora")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Svnumcupprueba(string hservicio, string fecha, string hpaciente)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select numero from vnumcupprueba(" + hservicio + ",'" + fecha + "') where idpaciente=" + hpaciente + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("numero")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Snumerocupo(string hservicio, string hmedico, string fecha, string hpaciente)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select numero from vnumeroscupo(" + hservicio + "," + hmedico + ",'" + fecha +"') where idpaciente=" + hpaciente + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("numero")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Snombrelargo(string num_region)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from org_geografica where num_region=" + num_region + " order by num_region;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("nombrelargo")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public int SVasignadosp(string idpaciente, string hservicio)
    {
        OpenConnection();
        int nombrelargo = 0;
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select vasignadosp(" + idpaciente + "," + hservicio + ");";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = Convert.ToInt16(reader.GetValue(reader.GetOrdinal("vasignadosp")).ToString());
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public int SVasignados(string idpaciente, string hservicio)
    {
        OpenConnection();
        int nombrelargo = 0;
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select vasignados(" + idpaciente + "," + hservicio + ");";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = Convert.ToInt16(reader.GetValue(reader.GetOrdinal("vasignados")).ToString());
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Sid_medicos()
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select nextval('id_medicos');";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("nextval")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Snhistoria()
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select nextval('id_historia');";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("nextval")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Snfactura(string codigo)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select nextval('id_" + codigo + "');";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("nextval")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Shconyugal(string nombre)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from conyugal where nombre='" + nombre + "';";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("id")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string ScodServicio(string id)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from servicios where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("codigo")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string ScodPrueba(string id)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from pruebas where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("codigo")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Shservicio(string nombre)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from servicios where nombre='" + nombre + "';";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("id")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Shestatus(string nombre)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from estatus where nombre='" + nombre + "';";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("codigo")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Shhorario(string nombre)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from horario where nombre='" + nombre + "';";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("id")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Shturno(string nombre)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from turno where nombre='" + nombre + "';";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("id")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Snum_region(string nombrelargo)
    {
        OpenConnection();
        string num_region = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from org_geografica where nombrelargo='" + nombrelargo + "' order by num_region;";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            num_region = reader.GetValue(reader.GetOrdinal("num_region")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return num_region;
    }
    public void icajeros( string nombre,
                          string cedula,
                          string telefonod,
                          string telefonom,
                          string direcciond,
                          string horg_geografica,
                          string correo,
                          string estatus,
                          string loggin,
                          string password)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "insert into cajeros " +
                     "(nombre, cedula,telefonodomicilio, telefonomovil," +
                     " direcciondomicilio, horg_geografica, correo," +
                     " estatus,loggin,password) values " +
                        "('" + nombre + "','" +
                          cedula + "','" +
                          telefonod + "','" +
                          telefonom + "','" +
                          direcciond + "'," +
                          horg_geografica + ",'" +
                          correo + "'," +
                          estatus + ",'" +
                          loggin + "',md5('" + password + "'));";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void imedicos( string id,
                          string nombre,
                          string cedula,
                          string mpps,
                          string colegio,
                          string telefonod,
                          string telefonom,
                          string direcciond,
                          string horg_geografica,
                          string correo,
                          string estatus)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "insert into medicos " +
                     "(id,nombre, cedula, mpps, colegio, telefonodomicilio, telefonomovil," +
                     " direcciondomicilio, horg_geografica, correo," +
                     " estatus) values " + 
                        "("+ id + ",'" + nombre + "','" +
                          cedula + "','" +
                          mpps + "','" +
                          colegio + "','" +
                          telefonod + "','" +
                          telefonom + "','" +
                          direcciond + "'," +
                          horg_geografica + ",'" +
                          correo + "'," +
                          estatus + ");";

        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
     }
    public string inssolicitud(
                            string numero,
                            string horigen,
                            string hdestino,
                            string htipodocumento,
                            string estatus,
                            string observaciones,
                            string hmedico,
                            string hservicio)
      {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from proc001('" +
                                      numero + "'," +
                                      horigen + "," +
                                      hdestino + "," +
                                      htipodocumento + "," +
                                      estatus + ",'" +
                                      observaciones + "'," +
                                      hmedico + "," +
                                      hservicio + ");";

        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        string iddoc = "";
        for (int i = 0; reader.Read(); i++)
        {
            iddoc = reader.GetValue(reader.GetOrdinal("proc001")).ToString();
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        CloseConnection();
        return iddoc;
    }
    public string insolprueba(string numero,
                            string horigen,
                            string hdestino,
                            string htipodocumento,
                            string estatus,
                            string observaciones)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from proc002('" +
                                      numero + "'," +
                                      horigen + "," +
                                      hdestino + "," +
                                      htipodocumento + "," +
                                      estatus + ",'" +
                                      observaciones + "');";

        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        string iddoc = "";
        for (int i = 0; reader.Read(); i++)
        {
            iddoc = reader.GetValue(reader.GetOrdinal("proc002")).ToString();
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        CloseConnection();
        return iddoc;
    }
    public void iservicios(string codigo,
                          string nombre)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "insert into servicios " +
                     "(codigo, nombre) values " +
                        "('" + codigo + "','" +
                          nombre + "');";

        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void iExamenes(string codigo,
                          string nombre)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "insert into examenes " +
                     "(codigo, nombre) values " +
                        "('" + codigo + "','" +
                          nombre + "');";

        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void dmedicos(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "delete from medicos where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void dcajeros(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "delete from cajeros where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void dservicios(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "delete from medicos where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void dserviciosmedico(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "delete from serviciosmedico where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void dpacientes(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "delete from paciente where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void docupacion(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "delete from profesion where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void dexamenes(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "delete from medicos where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void dexamenf(string hpaciente)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "delete from examenf where hpaciente=" + hpaciente + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void umedicos(string id,
                          string nombre,
                          string cedula,
                          string mpps,
                          string colegio,
                          string telefonod,
                          string telefonom,
                          string direcciond,
                          string num_region, 
                          string correo,
                          string estatus)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update medicos set " +
                     "nombre='" + nombre + "', " +
                     "cedula='" + cedula + "', " +
                     "mpps='" + mpps + "', " +
                     "colegio='" + colegio + "', " +
                     "telefonodomicilio='" + telefonod + "', " +
                     "telefonomovil='" + telefonom + "', " +
                     "direcciondomicilio='" + direcciond + "', " +
                     "horg_geografica=" + num_region + ", " +
                     "correo='" + correo + "' " + " where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void uGmedicos(string id,
                          string nombre,
                          string cedula,
                          string mpps,
                          string colegio,
                          string estatus)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update medicos set " +
                     "nombre='" + nombre + "', " +
                     "cedula='" + cedula + "', " +
                     "mpps='" + mpps + "', " +
                     "colegio='" + colegio + "', " +
                     "estatus=" + estatus + " where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }

    public void uservicios(string id,
                          string nombre,
                          string codigo)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update servicios set " +
                     "nombre='" + nombre + "', " +
                     "codigo='" + codigo + "' where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void uGservicios(string id,
                          string nombre,
                          string codigo)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update servicios set " +
                     "nombre='" + nombre + "', " +
                     "codigo='" + codigo + "' where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void uOcupacion(string id,
                          string nombre,
                          string codigo)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update profesion set " +
                     "nombre='" + nombre + "', " +
                     "codigo='" + codigo + "' where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void uExamenes(string id,
                          string nombre,
                          string codigo)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update examenes set " +
                     "nombre='" + nombre + "', " +
                     "codigo='" + codigo + "' where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void uGOcupacion(string id,
                          string nombre,
                          string codigo)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update profesion set " +
                     "nombre='" + nombre + "', " +
                     "codigo='" + codigo + "' where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void uGExamenes(string id,
                          string nombre,
                          string codigo)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update examenes set " +
                     "nombre='" + nombre + "', " +
                     "codigo='" + codigo + "' where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void uGExamenf(string id,
                          string hpaciente,
                          string ta,
                          string fc,
                          string fr,
                          string peso,
                          string talla,
                          string temperatura
                          )
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update examenfisico set " +
                     "tensionarterial='" + ta + "', " +
                     "frecuenciacardiaca='" + fc + "', " +
                     "frecuenciarespiratoria='" + fr + "', " +
                     "peso='" + peso + "', " +
                     "talla='" + talla + "', " +
                     "temperatura='" + temperatura + 
                     "' where hpaciente=" + hpaciente + " and id=" +  id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void ipacientes(string historia,
                           string cedula,
                           string nombre,
                           string fechanac,
                           string edad,
                           string sexo,
                           string direccion,
                           string correo,
                           string telefonov,
                           string telefonom,
                           string horg_geografica,
                           string herenciap,
                           string herenciam,
                           string herenciah,
                           string hprofesion,
                           string hestadocivil,
                           string tabaquismo,
                           string estatus)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "insert into paciente " +
                     "(historia,cedula,nombre,fechanacimiento,edad,sexo,direcciondomicilio, correo," +
                     " telefonodomicilio,telefonomovil,horg_geografica,herenciapadre, herenciamadre, herenciahermanos," +
                     "hprofesion,hestadocivil,tabaquismo,estatus) values ('" +
                           historia + "','" +
                           cedula + "','" +
                           nombre + "','" +
                           fechanac + "','" +
                           edad + "','" +
                           sexo + "','" +
                           direccion + "','" +
                           correo + "','" +
                           telefonov + "','" +
                           telefonom + "'," +
                           horg_geografica + ",'" +
                           herenciap + "','" +
                           herenciam + "','" +
                           herenciah + "'," +
                           hprofesion + "," +
                           hestadocivil + ",'" +
                           tabaquismo + "'," +
                           estatus + ");";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public string Shprofesion(string nombre)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from profesion where nombre='" + nombre + "';";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("id")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string Shestcivil(string nombre)
    {
        OpenConnection();
        string nombrelargo = "";
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from conyugal where nombre='" + nombre + "';";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            nombrelargo = reader.GetValue(reader.GetOrdinal("id")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return nombrelargo;
    }
    public string upacientes(string id,
                           string historia,
                           string cedula,
                           string nombre,
                           string fechanac,
                           string edad,
                           string sexo,
                           string direccion,
                           string correo,
                           string telefonov,
                           string telefonom,
                           string horg_geografica,
                           string herenciap,
                           string herenciam,
                           string herenciah,
                           string hprofesion,
                           string hestadocivil,
                           string tabaquismo,
                           string estatus)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update paciente set " +
                     "historia='" + historia + "', " +
                     "cedula='" + cedula + "', " +
                     "nombre='" + nombre + "', " +
                     "fechanacimiento='" + fechanac + "', " +
                     "edad='" + edad + "', " +
                     "sexo='" + sexo + "', " +
                     "direcciondomicilio='" + direccion + "', " +
                     "correo='" + correo + "', " +
                     "telefonodomicilio='" + telefonov + "', " +
                     "telefonomovil='" + telefonom + "', " +
                     "horg_geografica=" + horg_geografica + ", " +
                     "herenciapadre='" + herenciap + "', " +
                     "herenciamadre='" + herenciam + "', " +
                     "herenciahermanos='" + herenciah + "', " +
                     "hprofesion=" + hprofesion + ", " +
                     "hestadocivil=" + hestadocivil + 
                     " where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return sql;
    }
    public string uGpacientes(string id,
                          string nombre,
                          string cedula,
                          string edad,
                          string sexo,
                          string estatus)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update paciente set " +
                     "nombre='" + nombre + "', " +
                     "cedula='" + cedula + "', " +
                     "edad='" + edad + "', " +
                     "sexo='" + sexo + "', " +
                     "estatus=" + estatus + " where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return sql;
    }
    public void uEnEpera(string hpaciente)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update paciente set estatus=8 where id=" + hpaciente + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
     }
    public void uEnConsulta(string hpaciente)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update paciente set estatus=9 where id=" + hpaciente + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void uEnProceso(string hdocumento)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update documento set estatus=1 where id=" + hdocumento + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void uProcesado(string hdocumento)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update documento set estatus=2 where id=" + hdocumento + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void iserviciosmedico(string hmedico,
                          string hservicio,
                          string hhorario,
                          string hturno,
                          string npersonasm,
                          string npersonast)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "insert into serviciosmedico " +
                     "(hmedico, hservicio, hhorario, hturno, npersonasm, npersonast) values " +
                        "(" + hmedico + "," +
                          hservicio + "," +
                          hhorario + "," +
                          hturno + ",'" +
                          npersonasm + "','" +
                          npersonast + "');";

        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public string insexamenf(
        string hpaciente,
        string in_fecha ,
        string in_ta ,
        string in_fc ,
        string in_fr ,
        string in_peso ,
        string in_talla ,
        string in_temperatura ,
        string in_ecg ,
        string in_aspecto,
        string hdocumento,
        string hservicio,
        string sao2)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from insertexamenf(" +
                                      hpaciente + ",'" +
                                      in_fecha + "','" +
                                      in_ta + "','" +
                                      in_fc + "','" +
                                      in_fr + "','" +
                                      in_peso + "','" +
                                      in_talla + "','" +
                                      in_temperatura + "','" +
                                      in_ecg + "','" +
                                      in_aspecto + "'," +
                                      hdocumento + "," + hservicio + ",'" + sao2 +"');";

        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        string iddoc = "";
        for (int i = 0; reader.Read(); i++)
        {
            iddoc = reader.GetValue(reader.GetOrdinal("insertexamenf")).ToString();
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        CloseConnection();
        return iddoc;
    }
    public string imorbilidad(
        string hpaciente,
        string motivo,
        string enfermedad,
        string diagnostico,
        string tratamiento,
        string hdocumento,
        string hexamenf,
        string hmedico)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from imorbilidad(" +
                                      hpaciente + ",'" +
                                      motivo + "','" +
                                      enfermedad + "','" +
                                      diagnostico + "','" +
                                      tratamiento + "'," +
                                      hdocumento +  "," +
                                      hexamenf + "," +
                                      hmedico + ");";

        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        string iddoc = "";
        for (int i = 0; reader.Read(); i++)
        {
            iddoc = reader.GetValue(reader.GetOrdinal("imorbilidad")).ToString();
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        CloseConnection();
        return iddoc;
    }
    public string iantecedente( string id,
                              string has,
                              string diabetes,
                              string dislipidemias,
                              string tabaquismo,
                              string sedentarismo,
                              string obesidad,
                              string historiafm60,
                              string diagnosticoeac,
                              string anginaest,
                              string cf,
                              string im,
                              string angioplastia,
                              string cirugia,
                              string arritmias,
                              string sv,
                              string bloqueoav,
                              string mpd,
                              string acv,
                              string enfcarotidea,
                              string enfperiferica,
                              string chagas,
                              string cardreumatica,
                              string hpaciente,
                              string hmotivo)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "insert into antecedentes (id,has,diabetes,dislipidemias,tabaquismo,sedentarismo,obesidad,historiafm60,diagnosticoeac," +
                               "anginaest,cf,im,angioplastia,cirugia,arritmias,sv,bloqueoav,mpd,acv,enfcarotidea," +
                               "enfperiferica,chagas,cardreumatica,hpaciente,hmotivo) values (" +
                                id + "," +
                                has + "," +
                                diabetes + "," +
                                dislipidemias + "," +
                                tabaquismo + "," +
                                sedentarismo + "," +
                                obesidad + "," +
                                historiafm60 + "," +
                                diagnosticoeac + "," +
                                anginaest + "," +
                                cf + "," +
                                im + "," +
                                angioplastia + "," +
                                cirugia + "," +
                                arritmias + "," +
                                sv + "," +
                                bloqueoav + "," +
                                mpd + "," +
                                acv + "," +
                                enfcarotidea + "," +
                                enfperiferica + "," +
                                chagas + "," +
                                cardreumatica + "," +
                                hpaciente + "," +
                                hmotivo + ");";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        CloseConnection();
        return sql;
      }
    public DataTable Santecedente(string id)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from antecedentes where hpaciente=" + id +";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public string uantecedente( string id ,
                                string has ,
                                string diabetes ,
                                string dislipidemias ,
                                string tabaquismo ,
                                string sedentarismo ,
                                string obesidad,
                                string historiafm60 ,
                                string diagnosticoeac,
                                string anginaest,
                                string cf ,
                                string im ,
                                string angioplastia ,
                                string cirugia ,
                                string arritmias,
                                string sv,
                                string bloqueoav,
                                string mpd,
                                string acv,
                                string enfcarotidea,
                                string enfperiferica,
                                string chagas,
                                string cardreumatica,
                                string hpaciente,
                                string hmotivo
                                )
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update antecedentes set " +
                                "has=" + has +
                                ", diabetes=" + diabetes +
                                ", dislipidemias=" + dislipidemias +
                                ", tabaquismo=" + tabaquismo +
                                ", sedentarismo=" + sedentarismo +
                                ", obesidad=" + obesidad +
                                ", historiafm60=" + historiafm60 +
                                ", diagnosticoeac=" + diagnosticoeac +
                                ", anginaest=" + anginaest +
                                ", cf=" + cf +
                                ", im=" + im +
                                ", angioplastia=" + angioplastia +
                                ", cirugia=" + cirugia +
                                ", arritmias=" + arritmias +
                                ", sv=" + sv +
                                ", bloqueoav=" + bloqueoav +
                                ", mpd=" + mpd +
                                ", acv=" + acv +
                                ", enfcarotidea=" + enfcarotidea +
                                ", enfperiferica=" + enfperiferica +
                                ", chagas=" + chagas +
                                ", cardreumatica=" + cardreumatica +
                                ", hmotivo=" + hmotivo  +
                                " where hpaciente=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return sql;
    }
    public DataTable SExamenesf(string hpaciente)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from examenfisico where hpaciente=" + hpaciente + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        DataTable usuario = new DataTable();
        usuario.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return usuario;
    }
    public string uexamenf(string id,
                           string ta,
                           string fc,
                           string fr,
                           string peso,
                           string talla,
                           string temperatura,
                           string aspecto)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update examenfisico set " +
                                "tensionarterial='" + ta +
                                "', frecuenciacardiaca='" + fc +
                                "', frecuenciarespiratoria='" + fr +
                                "', peso='" + peso +
                                "', talla='" + talla +
                                "', temperatura='" + temperatura +
                                "', aspecto='" + aspecto +
                                "' where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return sql;
    }
    public string umedicinainterna(string id,
                           string diagnostico,
                           string tratamiento)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update medicinainterna set " +
                                "diagnostico='" + diagnostico +
                                "', tratamiento='" + tratamiento +
                                "' where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return sql;
    }
    public string umorbilidad(string id,
                           string diagnostico,
                           string tratamiento)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update morbilidad set " +
                                "diagnostico='" + diagnostico +
                                "', tratamiento='" + tratamiento +
                                "' where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return sql;
    }
    public string GuardarImagen(string hpaciente, string archivo, string tipo, string size)
    {
        archivo = archivo.Replace("\\", "\\\\");
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string query = "select * from ielectrocardio(" + hpaciente +", '" + tipo + "','" + size + "')";
        dbcmd.CommandText = query;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        string iddoc = "";
        for (int i = 0; reader.Read(); i++)
        {
            iddoc = reader.GetValue(reader.GetOrdinal("ielectrocardio")).ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return iddoc;
    }

    public DataTable GetImagenList()
    {
        OpenConnection();
        DataTable ekg = new DataTable();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string query = "select * from velectrocardiograma;";
        dbcmd.CommandText = query;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        ekg.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return ekg;
    }
    public DataTable GetImagenesByhpaciente(string hpaciente)
    {
        DataTable ekg = new DataTable();
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string query = "select * from velectrocardiograma where hpaciente=" + hpaciente + ";";
        dbcmd.CommandText = query;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        ekg.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return ekg;
    }
    public DataTable GetImgById(string id)
    {
        DataTable ekg = new DataTable();
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string query = "select * from electrocardiogramas where id=" + id + ";";
        dbcmd.CommandText = query;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        ekg.Load(reader);
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return ekg;
    }
    public string GetArchivoId(string Id)
    {
        string ekg = "";
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string query = "select archivo from electrocardiogramas where id=" + Id + ";";
        dbcmd.CommandText = query;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        if (reader.Read())
        {
            ekg = reader["archivo"].ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        CloseConnection();
        return ekg;
    }
    public string GetFileOid(string Id)
    {
        string ekg = "";
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string query = "select imagen from electrocardiogramas where id=" + Id + ";";
        dbcmd.CommandText = query;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        if (reader.Read())
        {
            ekg = reader["imagen"].ToString();
        }
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        CloseConnection();
        return ekg;
    }
    public void ucajeros(string id,
                          string nombre,
                          string cedula,
                          string telefonod,
                          string telefonom,
                          string direcciond,
                          string num_region,
                          string correo,
                          string estatus)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update cajeros set " +
                     "nombre='" + nombre + "', " +
                     "cedula='" + cedula + "', " +
                     "telefonodomicilio='" + telefonod + "', " +
                     "telefonomovil='" + telefonom + "', " +
                     "direcciondomicilio='" + direcciond + "', " +
                     "horg_geografica=" + num_region + ", " +
                     "correo='" + correo + "' " + " where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    public void uGcajeros(string id,
                          string nombre,
                          string cedula,
                          string estatus)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update medicos set " +
                     "nombre='" + nombre + "', " +
                     "cedula='" + cedula + "', " +
                     "estatus=" + estatus + " where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
    }
    //itrespiratoria(in_hpaciente bigint, in_hmedico bigint, in_hdocumento bigint, in_hexamenfisico bigint, in_diagnostico text, in_fisioterapia text, in_ejercicios text, in_espirometria text, in_inhaloterapia text, in_tecnicas text, in_entrenamiento text, in_sugerencias text)
    public string itrespiratoria(string hpaciente,
                                string hmedico, 
                                string hdocumento, 
                                string hexamenfisico, 
                                string diagnostico, 
                                string fisioterapia, 
                                string ejercicios, 
                                string espirometria, 
                                string inhaloterapia, 
                                string tecnicas, 
                                string entrenamiento, 
                                string sugerencias)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from itrespiratoria(" + hpaciente + "," +
                                                    hmedico + "," +
                                                    hdocumento + "," +
                                                    hexamenfisico + ",'" +
                                                    diagnostico + "','" +
                                                    fisioterapia + "','" +
                                                    ejercicios + "','" +
                                                    espirometria + "','" +
                                                    inhaloterapia + "','" +
                                                    tecnicas + "','" +
                                                    entrenamiento + "','" +
                                                    sugerencias + "');";

        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        string iddoc = "";
        for (int i = 0; reader.Read(); i++)
        {
            iddoc = reader.GetValue(reader.GetOrdinal("itrespiratoria")).ToString();
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        CloseConnection();
        return iddoc;
    }
    public string imedicinainterna(
        string hpaciente,
        string motivo,
        string enfermedad,
        string diagnostico,
        string tratamiento,
        string hdocumento,
        string hexamenf,
        string hmedico)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "select * from imedicinainterna(" +
                                      hpaciente + ",'" +
                                      motivo + "','" +
                                      enfermedad + "','" +
                                      diagnostico + "','" +
                                      tratamiento + "'," +
                                      hdocumento + "," +
                                      hexamenf + "," +
                                      hmedico + ");";

        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        string iddoc = "";
        for (int i = 0; reader.Read(); i++)
        {
            iddoc = reader.GetValue(reader.GetOrdinal("imedicinainterna")).ToString();
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        CloseConnection();
        return iddoc;
    }
    public string uterapiaresp(string id,
                                string strdiagnostico,
                                string strsugerencias,
                                string strterapia,
                                string strejercicios,
                                string strespirometria,
                                string strinhaloterapia,
                                string strtecnicas,
                                string strentrenamiento)
    {
        OpenConnection();
        System.Data.IDbCommand dbcmd = connection.CreateCommand();
        string sql = "update terapiarespiratoria set " +
                                "diagnostico='" + strdiagnostico +
                                "', sugerencias='" + strsugerencias +
                                "', inhaloterapia='" + strinhaloterapia +
                                "', fisioterapiatorax='" + strterapia +
                                "', ejerciciosrespiratorios='" + strejercicios +
                                "', espirometriaincentiva='" + strespirometria +
                                "', tecnicasrelajacion='" + strtecnicas +
                                "', entrenamientofisico='" + strentrenamiento +
                                "' where id=" + id + ";";
        dbcmd.CommandText = sql;
        System.Data.IDataReader reader = dbcmd.ExecuteReader();
        CloseConnection();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        return sql;
    }
}