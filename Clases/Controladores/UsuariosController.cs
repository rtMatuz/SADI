///////////////////////////////////////////////////////////
//  UsuariosController.cs
//  Implementation of the Class UsuariosController
//  Generated by Enterprise Architect
//  Created on:      10-mar.-2017 13:19:09
//  Original author: Ing. Alan Adalberto Ortiz P�rez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SADI.Clases.Modelos;


namespace SADI.Clases.Controladores {
	/// <summary>
	/// Controlador del Modelo Usuarios
	/// </summary>
	public class UsuariosController : Metodos {
        /// <summary>
        /// Constructor de la Clase
        /// </summary>
		public UsuariosController(){

		}
        /// <summary>
        /// Destructor de la Clase
        /// </summary>
		~UsuariosController(){

		}
        /// <summary>
        /// M�todo para Actualizar el Registro del Modelo Usuario
        /// </summary>
		/// <param name="o">Objeto del Tipo UsuariosModel</param>
        /// <returns>Boleano</returns>
		public override bool ActualizarRegistro(object o){

            if (o.GetType() == typeof(UsuariosModel))// Validar que el objeto dea del Tipo UsuariosModel
            {
                var u = (UsuariosModel)o; // Casteamos el Objeto al tipo UsuariosModel

                if(Abrir()) // Si Abre la conexi�n
                {
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "3"));// Opci�n para actualizar dentro del procedimiento
                        lista.Add(new Parametros(@"id", u.Id.ToString()));// Todos los par�metros deben de ir en string/cadena clase nativa del CLR
                        lista.Add(new Parametros(@"usr", u.Usuario));// Nombre de Usuario
                        lista.Add(new Parametros(@"pwd", u.Contrase�a));// Contrase�a del Usuario
                        lista.Add(new Parametros(@"nom", u.Nombre));// Nombre del Usuario
                        lista.Add(new Parametros(@"pat", u.Paterno));// Apellido Paterno del Usuario
                        lista.Add(new Parametros(@"mat", u.Materno));// Apellido Materno del Usuario
                        lista.Add(new Parametros(@"fondo", u.Fondo.Id.ToString()));// Fondo al que pertence el Usuario
                        lista.Add(new Parametros(@"subf", u.SubFondo.Id.ToString()));// SubFondo al que pertenece el Usuario
                        lista.Add(new Parametros(@"unidad", u.UnidadAdmva.Id.ToString()));// Unidad Administrativa a la que Pertenece el Usuario
                        lista.Add(new Parametros(@"jera", u.Jerarquia.Id.ToString()));// Jerarqu�a del Usuario
                        lista.Add(new Parametros(@"est", (u.Estatus == true ? "1" : "0")));// Si es verdadero = Activo :1; si es Falso = inactivo : 0

                        string proce = "sp_usuarios_crud";// Nombre del Procedimiento

                        if(EjecutarProcedimiento(proce, lista))
                        { return true; }// Se ejecut� el procedimiento exitosamente
                        else { return false; }// No se ejecut� el procedimiento, ver Error
                    }
                    catch(Exception e)// Atrapar el Error
                    {
                        Error = e.Message.ToString(); // guardar el error
                        return false; // Indicar que existe errir
                    }
                    finally { Cerrar(); } // Asegurarnos de que se cierra la conexi�n siempre
                }
                else // Si no abre la conexi�n
                { return false; }
            }
            else // Si no es del tipo UsuariosModel
            { return false; }
		}

		/// <summary>
		/// Consultar un Usuario del Sistema
		/// </summary>
		/// <returns>Boleano</returns>
		/// <param name="o">Objeto del tipo UsuariosModel</param>
		public override bool ConsultarRegistro(object o){

            if (o.GetType() == typeof(UsuariosModel))
            {
                var u = (UsuariosModel)o;
                if (Abrir())
                {
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "4"));// Opcio�n para consultar un registro solamente
                        lista.Add(new Parametros(@"id", u.Id.ToString()));// Identificador del registro
                        lista.Add(new Parametros(@"usr", string.Empty));
                        lista.Add(new Parametros(@"pwd", string.Empty));
                        lista.Add(new Parametros(@"nom", string.Empty));
                        lista.Add(new Parametros(@"pat", string.Empty));
                        lista.Add(new Parametros(@"mat", string.Empty));
                        lista.Add(new Parametros(@"fondo", string.Empty));
                        lista.Add(new Parametros(@"subf", string.Empty));
                        lista.Add(new Parametros(@"unidad", string.Empty));
                        lista.Add(new Parametros(@"jera", string.Empty));
                        lista.Add(new Parametros(@"est", string.Empty));

                        string proce = "sp_usuarios_crud";// Nombre del procedimiento

                        if (ConsultarProcedimiento(proce, lista))
                        {
                            return true;// Consulta exitosa
                        }
                        else
                        { return false; }// Consulta no exitosa
                    }
                    catch(Exception e)// Cachar el error
                    {
                        Error = e.Message.ToString();// Guardar el mensaje de error
                        return false;// Indicar operaci�n No Exitosa
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }//No se pudo Abrir la Conexi�n
            }
            else
            { return false; }// No es del tipo UsuariosModel
		}
        /// <summary>
        /// Consultar El Total de Registros de los Usuarios
        /// </summary>
        /// <returns>Boolean</returns>
		public override bool ConsultarRegistros(){

            if (Abrir())
            {
                try
                {
                    List<Parametros> lista = new List<Parametros>();
                    lista.Add(new Parametros(@"opc", "1"));// Opci�n para actualizar dentro del procedimiento
                    lista.Add(new Parametros(@"id", string.Empty));// Todos los par�metros deben de ir en string/cadena clase nativa del CLR
                    lista.Add(new Parametros(@"usr", string.Empty));
                    lista.Add(new Parametros(@"pwd", string.Empty));
                    lista.Add(new Parametros(@"nom", string.Empty));
                    lista.Add(new Parametros(@"pat", string.Empty));
                    lista.Add(new Parametros(@"mat", string.Empty));
                    lista.Add(new Parametros(@"fondo", string.Empty));
                    lista.Add(new Parametros(@"subf", string.Empty));
                    lista.Add(new Parametros(@"unidad", string.Empty));
                    lista.Add(new Parametros(@"jera", string.Empty));
                    lista.Add(new Parametros(@"est", string.Empty));// Si es verdadero = Activo :1; si es Falso = inactivo : 0

                    string proce = "sp_usuarios_crud";

                    if (ConsultarProcedimiento(proce, lista))
                    { return true; }
                    else
                    { return false; }
                }
                catch (Exception e)
                {
                    Error = e.Message.ToString();// Guardar el mensaje de error
                    return false;// Indicar Operaci�n NO Exitosa
                }
                finally { Cerrar(); }// Cerrar la conexi�n
            }
            else
            { return false; }// No se pudo Abrir la COnexi�n
		}

		/// <summary>
		/// Ingresar un Usuario al Sistema
		/// </summary>
		/// <returns>Boleano</returns>
		/// <param name="o">Objeto de tipo Usuario</param>
		public override bool IngresarRegisto(object o){

            if (o.GetType() == typeof(UsuariosModel))// Validar que el Objeto sea del tipo UsuariosModel
            {
                var u = (UsuariosModel)o;// Castear la variable al tipo UsuariosModel

                if(Abrir())// Intentar Abrir la Conexi�n
                {
                    // Si se estableci� la conexi�n
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "2"));// Opci�n para Ingresar Registro dentro del procedimiento
                        lista.Add(new Parametros(@"id", u.Id.ToString()));
                        lista.Add(new Parametros(@"usr", u.Usuario));
                        lista.Add(new Parametros(@"pwd", u.Contrase�a));
                        lista.Add(new Parametros(@"nom", u.Nombre));
                        lista.Add(new Parametros(@"pat", u.Paterno));
                        lista.Add(new Parametros(@"mat", (!string.IsNullOrEmpty(u.Materno) ? u.Materno : string.Empty)));// Validar que la variable materno no sea nula
                        lista.Add(new Parametros(@"fondo", u.Fondo.Id.ToString()));
                        lista.Add(new Parametros(@"subf", u.SubFondo.Id.ToString()));
                        lista.Add(new Parametros(@"unidad", u.UnidadAdmva.Id.ToString()));
                        lista.Add(new Parametros(@"jera", u.Jerarquia.Id.ToString()));
                        lista.Add(new Parametros(@"est", "1"));// Si se v� a ingresar, siempre ser� activo

                        string proce = "sp_usuarios_crud";

                        if(EjecutarProcedimiento(proce, lista))// Ejecutar el procedimiento
                        { return true; }// Operaci�n Exitosa
                        else
                        { return false; }// Operaci�n NO Exitosa, consultar el Error

                    }
                    catch(Exception e)// Cachar el error
                    {
                        Error = e.Message.ToString();// Guardar el mensaje de error
                        return false;// Indicar que la operaci�n NO fue exitosa
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n

                }
                else
                { return false; }// No Se Pudo Abrir la Conexi�n, ver mensaje de error
            }
            else
            { return false; }// No es del mismo tipo
		}

	}//end UsuariosController

}//end namespace Controladores