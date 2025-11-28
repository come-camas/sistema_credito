using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;
using Capa_entidad;
using Capa_datos;
using System.Data.SqlClient;

namespace Capa_negocio
{
    public class CN_Cliente
    {
        private readonly CD_Cliente _datos = new CD_Cliente();

        
        public int BuscarIdClientePorCedula(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
                throw new ApplicationException("La cédula no puede estar vacía.");

            try
            {
               
                int idCliente = _datos.BuscarIdClientePorCedula(cedula);

                return idCliente;
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error al buscar el ID del cliente: " + ex.Message);
            }
        }

        private static readonly HashSet<string> CodigosValidos = new HashSet<string>
        {
            "001", "002", "003", "004", "005", "006", "007", "008", "009",
             "041", "042", "043", "044", "045", "046", "047", "048",
            "081", "082", "083", "084", "085", "086", "087", "088", "089", "090", "091", "092", "093",
            "121", "122", "123", "124", "125", "126", "127", "128", "129", "130",
             "161", "162", "163", "164", "165", "166",
            "201", "202", "203", "204",
            "241", "242", "243", "244", "245", "246", "247",
            "281", "283", "284", "285", "286", "287", "288", "289", "290", "291",
             "321", "322", "323", "324", "325", "326", "327", "328", "329",
             "361", "362", "363", "364", "365", "366",
             "401", "402", "403", "404", "405", "406", "407", "408", "409",
             "441", "442", "443", "444", "445", "446", "447", "448", "449", "450", "451", "452", "453", "454",
            "481", "482", "483", "484", "485", "486", "487", "488", "489", "490", "491", "492", "493",
             "521", "522", "523", "524", "525", "526",
              "561", "562", "563", "564", "565", "566", "567", "568", "569", "570",
            "601", "602", "603", "604", "605", "606", "607", "608", "610", "611", "612", "613", "615", "616", "619",
             "624", "626", "627", "628"
        };

        public static bool EsCodigoMunicipioValido(string codigo)
        {
            // .Contains() en un HashSet es increíblemente rápido
            return CodigosValidos.Contains(codigo);
        }

        public bool validar_cedula(string cedula) {

            string cedulaLimpia = cedula.Replace("-", "").ToUpper();//likpiamos la cedula le quitamos todos los signos y espacios vacios 
            string codigoMuni = cedulaLimpia.Substring(0, 3);// agarramos los primero 3 digitos 

            if (!Regex.IsMatch(cedulaLimpia, @"^\d{13}[A-Y]$"))
            {
                return false;
            }

            if (!EsCodigoMunicipioValido(codigoMuni))
            {
                //si no se encuentra un codigo valido se crea una excepcion 
                return false;
            }

            // 3. Extracción de Fecha (DDMMAA)
            // Usamos índices seguros porque el Regex ya garantizó la longitud
            // substring(indice_inicio, longitud)
            int dia = int.Parse(cedulaLimpia.Substring(3, 2));
            int mes = int.Parse(cedulaLimpia.Substring(5, 2));
            int anio = int.Parse(cedulaLimpia.Substring(7, 2));

            // --- VALIDACIÓN DE FECHA REAL (BISIESTOS) ---

            // Validación básica de mes
            if (mes < 1 || mes > 12)
            {
                return false;
            }
            // Días máximos por mes (Índice 0 = Enero, 1 = Febrero, etc.)
            int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Verificación de Año Bisiesto
            // Regla simplificada: Si el año (2 dígitos) es divisible entre 4, asumimos bisiesto.
            // Esto es válido para todos los años que cubre la cédula actual (1900-2099).
            bool esBisiesto = false;
            if (anio % 4 == 0)
            {
                diasPorMes[1] = 29; // Febrero pasa a tener 29 días
                esBisiesto = true;
            }

            // Validar que el día no exceda el máximo permitido para ese mes
            if (dia < 1 || dia > diasPorMes[mes - 1])
            {
                // Estimación del siglo solo para mostrar un mensaje claro
                string anioCompleto = (anio < 30 ? "20" : "19") + anio.ToString("00");
                return false;
            }


            // 4. El "Truco" de la Letra (Algoritmo Modulo 23)

            // CORRECCIÓN IMPORTANTE:
            // Tomamos los primeros 13 dígitos (índice 0, longitud 13).
            // Usamos 'long' (Int64) porque 13 dígitos superan la capacidad de 'int' (Int32).
            string parteNumericaString = cedulaLimpia.Substring(0, 13);

            if (!long.TryParse(parteNumericaString, out long numeros))
            {
                return false;
            }

            // La letra está en el índice 13 (el caracter número 14)
            char letraUsuario = cedulaLimpia[13];

            // Tabla oficial de letras (Sin I, O, Ñ, Z)
            const string letrasValidas = "ABCDEFGHJKLMNPQRSTUVWXY";

            // Calculamos el índice matemático
            int indice = (int)(numeros % 23);
            char letraCorrecta = letrasValidas[indice];

            if (letraCorrecta == letraUsuario)
            {
                return true;
            }

            return false;
        }




        public int InsertarCliente(Clientes c)
        {
                if (string.IsNullOrWhiteSpace(c.nombre))
                    throw new ApplicationException("El nombre es obligatorio.");

                if (!System.Text.RegularExpressions.Regex.IsMatch(c.nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                    throw new ApplicationException("El nombre solo puede contener letras y espacios.");

                if (string.IsNullOrWhiteSpace(c.identificacion))
                    throw new ApplicationException("La cédula es obligatoria.");

                if (!Regex.IsMatch(c.identificacion, @"^\d{3}-\d{6}-\d{4}[A-Z]$")){
                    throw new ApplicationException("La cedula debe de llevar el siguiente formato: 000-DDMMAA-0000L");
                }

                if (!validar_cedula(c.identificacion))
                    throw new ApplicationException("La cedula digitada no es válida");

                if(string.IsNullOrWhiteSpace(c.telefono)) {
                throw new ApplicationException("El numero telefonico es obligatorio.");
                }       

                if (!string.IsNullOrWhiteSpace(c.telefono))
                {
                    if (!Regex.IsMatch(c.telefono, @"^(?:\+505|505)?[578]\d{7}$"))
                        throw new ApplicationException("El teléfono no es válido");
                }

                if (!string.IsNullOrWhiteSpace(c.identificacion))
                {
                    if (_datos.CedulaExiste(c.identificacion))
                        throw new ApplicationException("La identificación ya está registrada.");
                }

                if (c.creado_por == null || c.creado_por <= 0)
                    throw new ApplicationException("No se pudo determinar el usuario que crea el registro.");

           
           

            try
            {
                // Llamar al método InsertarCliente en la Capa de Datos y obtener el ID del cliente insertado
                return _datos.InsertarCliente(c);  // Devuelve el ID del cliente insertado
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.Message, ex);
            }
        }
    }
}
