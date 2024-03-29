///////////////////////////////////////////////////////////
//  EmpresarialDiseņoBuilder.cs
//  Implementation of the Class EmpresarialDiseņoBuilder
//  Generated by Enterprise Architect
//  Created on:      15-sep-2009 22:11:33
//  Original author: nbortolotti
///////////////////////////////////////////////////////////




using Builder;
namespace Builder {
	public class EmpresarialDiseņoBuilder : ComputadoraBuilder {

		public EmpresarialDiseņoBuilder(){

		}

		~EmpresarialDiseņoBuilder(){

		}

		public override void Dispose(){
            
		}

        public override void ConstruirEquipo()
        {
            m_Computadora = new Computadora();


        }

		public override void ConstruirDisco()
        {
            m_Computadora.Partes["Disco"] = "1600rpm";
		}

		public override void ConstruirMemoria()
        {
            m_Computadora.Partes["Memoria"] = "2Gb";
		}

		public override void ConstruirMonitor()
        {
            m_Computadora.Partes["Monitor"] = "15pulgadas";
		}

	}//end EmpresarialDiseņoBuilder

}//end namespace Builder