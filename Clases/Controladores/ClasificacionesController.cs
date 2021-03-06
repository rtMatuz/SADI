///////////////////////////////////////////////////////////
//  ClasificacionesController.cs
//  Implementation of the Class ClasificacionesController
//  Generated by Enterprise Architect
//  Created on:      10-mar.-2017 13:18:30
//  Original author: Ing. Alan Adalberto Ortiz P�rez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SADI.Clases.Modelos;



using SADI.Clases;
namespace SADI.Clases.Controladores {
	/// <summary>
	/// Controlador para la el Modelo Clasificaciones
	/// </summary>
	public class ClasificacionesController : Metodos {
        /// <summary>
        /// Constructor de la Clase
        /// </summary>
		public ClasificacionesController(){

		}
        /// <summary>
        /// Destructor de la Clase
        /// </summary>
		~ClasificacionesController(){

		}

		/// <summary>
		/// M�todo Para Consultar un Registro
		/// </summary>
		/// <returns>Boleano</returns>
		/// <param name="o">Objeto del Tipo class</param>
		public override bool ConsultarRegistro(Object o){

			if(o.GetType()==typeof(ClasificacionesModel))// Validar que el Objeto sea del Modelo ClasificacionesModel
            {
                var c = (ClasificacionesModel)o;// Castear la variable "c" al tipo ClasificacionesModel

                if(Abrir())// Intentar Abrir la Conexi�n
                {
                    // Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();// Crear lista de par�metros
                        lista.Add(new Parametros(@"opc", "4"));// Enviar opci�n a Procedimiento
                        lista.Add(new Parametros(@"id", c.Id.ToString()));// Identificador de la Clasificaci�n
                        lista.Add(new Parametros(@"clasi", string.Empty));// Descripci�n de la Clasificaci�n

                        string proce = "sp_clasificaciones_crud";// Nombre del par�metro

                        if(ConsultarProcedimiento(proce, lista))// Intentar la Consulta en el Procedimiento
                        { return true; }// Consulta Exitosa, Consulta Tabla
                        else
                        { return false; }// Consulta NO Exitosa, Consulte Error
                    }
                    catch(Exception e)// Cachar el error
                    {
                        Error = e.Message.ToString(); // Guardar el Error
                        return false;// Indicar que existe el error
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }// Error al intentar abrir la conexi�n, consultar Error
            }
            else
            { return false; }// No es del miismo tipo
		}

		/// <summary>
		/// M�todo Para Actualizar los Registros
		/// </summary>
		/// <returns>Boleano</returns>
		/// <param name="o">Objeto del Tipo class</param>
		public override bool ActualizarRegistro(Object o){

            if (o.GetType() == typeof(ClasificacionesModel))// Validar que el Objeto sea del Modelo ClasificacionesModel
            {
                var c = (ClasificacionesModel)o;// Castear la variable "c" al tipo ClasificacionesModel

                if (Abrir())// Intentar Abrir la Conexi�n
                {
                    // Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();// Crear lista de par�metros
                        lista.Add(new Parametros(@"opc", "4"));// Enviar opci�n a Procedimiento
                        lista.Add(new Parametros(@"id", c.Id.ToString()));// Identificador de la Clasificaci�n
                        lista.Add(new Parametros(@"clasi", c.Clasificacion));// Descripci�n de la Clasificaci�n

                        string proce = "sp_clasificaciones_crud";// Nombre del par�metro

                        if (EjecutarProcedimiento(proce, lista))// Intentar la Ejecuci�n en el Procedimiento
                        { return true; }// Ejecuci�n Exitosa, Consulta Tabla
                        else
                        { return false; }// Ejecuci�n NO Exitosa, Consulte Error
                    }
                    catch (Exception e)// Cachar el error
                    {
                        Error = e.Message.ToString(); // Guardar el Error
                        return false;// Indicar que existe el error
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }// Error al intentar abrir la conexi�n, consultar Error
            }
            else
            { return false; }// No es del miismo tipo
        }

		/// <summary>
		/// M�todo para Ingresar un Registro
		/// </summary>
		/// <returns>Boleano</returns>
		/// <param name="o">Objeto del Tipo Class</param>
		public override bool IngresarRegisto(Object o){

            if (o.GetType() == typeof(ClasificacionesModel))// Validar que el Objeto sea del Modelo ClasificacionesModel
            {
                var c = (ClasificacionesModel)o;// Castear la variable "c" al tipo ClasificacionesModel

                if (Abrir())// Intentar Abrir la Conexi�n
                {
                    // Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();// Crear lista de par�metros
                        lista.Add(new Parametros(@"opc", "4"));// Enviar opci�n a Procedimiento
                        lista.Add(new Parametros(@"id", c.Id.ToString()));// Identificador de la Clasificaci�n
                        lista.Add(new Parametros(@"clasi", c.Clasificacion));// Descripci�n de la Clasificaci�n

                        string proce = "sp_clasificaciones_crud";// Nombre del par�metro

                        if (EjecutarProcedimiento(proce, lista))// Intentar la Ejecuci�n en el Procedimiento
                        { return true; }// Ejecuci�n Exitosa, Consulta Tabla
                        else
                        { return false; }// Ejecuci�n NO Exitosa, Consulte Error
                    }
                    catch (Exception e)// Cachar el error
                    {
                        Error = e.Message.ToString(); // Guardar el Error
                        return false;// Indicar que existe el error
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }// Error al intentar abrir la conexi�n, consultar Error
            }
            else
            { return false; }// No es del miismo tipo
        }

		/// <summary>
		/// M�todo para Consultar Todos los Registros
		/// </summary>
		/// <returns>Boleano</returns>
		public override bool ConsultarRegistros(){

                if (Abrir())// Intentar Abrir la Conexi�n
                {
                    // Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();// Crear lista de par�metros
                        lista.Add(new Parametros(@"opc", "4"));// Enviar opci�n a Procedimiento
                        lista.Add(new Parametros(@"id", string.Empty));// Vac�o
                        lista.Add(new Parametros(@"clasi", string.Empty));// Vac�o

                        string proce = "sp_clasificaciones_crud";// Nombre del par�metro

                        if (ConsultarProcedimiento(proce, lista))// Intentar la Consulta en el Procedimiento
                        { return true; }// Consulta Exitosa, Consulta Tabla
                        else
                        { return false; }// Consulta NO Exitosa, Consulte Error
                    }
                    catch (Exception e)// Cachar el error
                    {
                        Error = e.Message.ToString(); // Guardar el Error
                        return false;// Indicar que existe el error
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }// Error al intentar abrir la conexi�n, consultar Error
            }
            
        }

	}//end ClasificacionesController

}//end namespace Controladores