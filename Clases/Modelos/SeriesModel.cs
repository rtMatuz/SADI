///////////////////////////////////////////////////////////
//  SeriesModel.cs
//  Implementation of the Class SeriesModel
//  Generated by Enterprise Architect
//  Created on:      10-mar.-2017 13:18:57
//  Original author: Ing. Alan Adalberto Ortiz P�rez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using SADI.Clases.Modelos;
namespace SADI.Clases.Modelos {
	/// <summary>
	/// Modelo de la Tabla Series
	/// </summary>
	public class SeriesModel {

		/// <summary>
		/// Identificador, llave
		/// </summary>
		private int _id;
		/// <summary>
		/// Identificador de la Serie
		/// </summary>
		private int _idserie;
		/// <summary>
		/// Identificador de la Secci�n
		/// </summary>
		private SeccionesModel _seccion;
		/// <summary>
		/// Descripci�n de la Serie
		/// </summary>
		private string _serie;

		public SeriesModel(){

		}

		/// <summary>
        /// Constructor de la Clase que recibe par�metros
        /// </summary>
        /// <param name="idserie">Identificador de la Serie</param>
        /// <param name="seccion">Secci�n a la que Pertenece</param>
        /// <param name="serie">Descripci�n de la Serie</param>
		public SeriesModel(int idserie, SeccionesModel seccion, string serie){

            this.IdSerie = idserie;
            this.Seccion = seccion;
            this.Serie = serie;
		}

		~SeriesModel(){

		}

		/// <summary>
		/// Acceder a la llave de la Serie
		/// </summary>
		public int Id{
            get { return _id; }
            set { _id = value; }
		}

		/// <summary>
		/// Acceder al Identificador de la Serie
		/// </summary>
		public int IdSerie{
            get { return _idserie; }
            set { _idserie = value; }
		}

		/// <summary>
		/// Acceder a la Propiedad Secci�n
		/// </summary>
		public SeccionesModel Seccion{
            get { return _seccion; }
            set { _seccion = value; }
		}

		/// <summary>
		/// Acceder a la Propiedad Serie
		/// </summary>
		public string Serie{
            get { return _serie; }
            set { _serie = value; }
		}

	}//end SeriesModel

}//end namespace Modelos