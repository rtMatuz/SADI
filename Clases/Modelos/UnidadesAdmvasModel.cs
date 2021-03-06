///////////////////////////////////////////////////////////
//  UnidadesAdmvasModel.cs
//  Implementation of the Class UnidadesAdmvasModel
//  Generated by Enterprise Architect
//  Created on:      10-mar.-2017 13:19:07
//  Original author: Ing. Alan Adalberto Ortiz P�rez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace SADI.Clases.Modelos {
	/// <summary>
	/// Modelo de la Tabla UnidadesAdmvas
	/// </summary>
	public class UnidadesAdmvasModel {

		private int _id;// Propiedad de la Identificaci�n del Modelo
		private string _unidad;// Propiedad de la Descripci�n de la Unidad
        /// <summary>
        /// Constructor vac�o de la Clase
        /// </summary>
		public UnidadesAdmvasModel(){

		}
        /// <summary>
        /// Constructor de la Clase con Par�metros
        /// </summary>
        /// <param name="id">Identificador del Modelo</param>
        /// <param name="unidad">Descripci�n de la Unidad del Modelo</param>
        public UnidadesAdmvasModel(int id, string unidad)
        {
            this.Id = id;
            this.Unidad = unidad;
        }
        /// <summary>
        /// Destructor de la Clase
        /// </summary>
		~UnidadesAdmvasModel(){

		}

		/// <summary>
		/// Acceder a la Propiedad Id
		/// </summary>
		public int Id{
            get { return _id; }
            set { _id = value; }
		}

		/// <summary>
		/// Acceder a la propiedad Unidad
		/// </summary>
		public string Unidad{
            get { return _unidad; }
            set { _unidad = value; }
		}

	}//end UnidadesAdmvasModel

}//end namespace Modelos