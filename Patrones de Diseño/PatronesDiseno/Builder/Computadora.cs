///////////////////////////////////////////////////////////
//  Computadora.cs
//  Implementation of the Class Computadora
//  Generated by Enterprise Architect
//  Created on:      15-sep-2009 22:11:33
//  Original author: nbortolotti
///////////////////////////////////////////////////////////




using System.Collections;
using System.Windows.Forms;


namespace Builder {
	public class Computadora {
        //Producto 

        private Hashtable partes = new Hashtable();

        public Hashtable Partes
        {
            get { return partes; }
            set { partes = value; }
        }

        public void MostrarPartes()
        {
            //
            MessageBox.Show("Monitor: " + partes["Monitor"]);
            MessageBox.Show("Disco: " + partes["Disco"]);
            MessageBox.Show("Memoria: " + partes["Memoria"]);
        }


		public Computadora(){

		}

		~Computadora(){

		}

		public virtual void Dispose(){

		}

	}//end Computadora

}//end namespace Builder