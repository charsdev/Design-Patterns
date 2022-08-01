using System.Collections.Generic;

namespace Factory
{
    //EJEMPLO OPEN CLOSE

    public class Conexiones
    {
        protected readonly Dictionary<string, IConexion> ConexionesContainer;

        public Dictionary<string, IConexion> GetConexionesContainer()
        {
            return ConexionesContainer;
        }

        public Conexiones()
        {
            ConexionesContainer = new Dictionary<string, IConexion>();
            ConexionesContainer.Add("MYSQL", new ConexionMySQL());
            ConexionesContainer.Add("ORACLE", new ConexionOracle());
            ConexionesContainer.Add("SQLSERVER", new ConexionSQLServer());
            ConexionesContainer.Add("POSTGRESQL", new ConexionPostgreSQL());
        }
    }

    public class Conexiones2 : Conexiones
    {
        public Conexiones2()
        {
            ConexionesContainer.Add("MYSQL2", new ConexionMySQL2());
        }
    }

	public class ConexionFabrica
	{
        private readonly Dictionary<string, IConexion> _conexiones;

        public ConexionFabrica(Dictionary<string, IConexion> conexiones)
        {
            _conexiones = conexiones;
        }

        public ConexionFabrica(Conexiones conexiones)
        {
            _conexiones = conexiones.GetConexionesContainer();
        }

        public IConexion GetConexion(string motor) 
        {
            return !_conexiones.TryGetValue(motor, out IConexion conexion) ? new ConexionVacia() : conexion;
        }
    }
}