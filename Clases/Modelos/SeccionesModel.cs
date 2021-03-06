///////////////////////////////////////////////////////////
//  SeccionesModel.cs
//  Implementation of the Class SeccionesModel
//  Generated by Enterprise Architect
//  Created on:      10-mar.-2017 13:18:55
//  Original author: Ing. Alan Adalberto Ortiz P�rez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace SADI.Clases.Modelos {
	/// <summary>
	/// Modelo de la Tabla Secciones
	/// </summary>
	public class SeccionesModel {

		private int _id;
		private string _seccion;
        /// <summary>
        /// Construcrtor de la Clase que no recibe par�metros
        /// </summary>
		public SeccionesModel(){

		}

		/// <summary>
		/// Constructor de la Clase que recibe dos par�metros
		/// </summary>
		/// <param name="id"></param>
		/// <param name="secc"></param>
		public SeccionesModel(int id, string secc){
            this.Id = id;
            this.Seccion = secc;
		}

		~SeccionesModel(){

		}

		/// <summary>
		/// Acceder a la Propiedad Id
		/// </summary>
		public int Id{
            get { return _id; }
            set { _id = value; }
		}

		/// <summary>
		/// Acceder a la Propiedad Secci�n
		/// </summary>
		public string Seccion{
            get { return _seccion; }
            set { _seccion = value; }
		}

	}//end SeccionesModel

}//end namespace Modelos