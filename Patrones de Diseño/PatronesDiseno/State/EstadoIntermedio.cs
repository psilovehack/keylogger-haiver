///////////////////////////////////////////////////////////
//  EstadoIntermedio.cs
//  Implementation of the Class EstadoIntermedio
//  Generated by Enterprise Architect
//  Created on:      16-sep-2009 12:18:50
//  Original author: nbortolotti
///////////////////////////////////////////////////////////




using State;
namespace State {
	public class EstadoIntermedio : Estado {

		public EstadoIntermedio(Estado e):this(e.Balance,e.m_Cuenta)
        {

		}
        public EstadoIntermedio(int pBalance, Cuenta pCuenta)
        {
            this.balance = pBalance;
            this.m_Cuenta = pCuenta;
            intereses = 10;
            limiteInferior = 2;
            limiteSuperior = 50;
        }

		~EstadoIntermedio(){

		}

		public override void Dispose(){

		}

		public override void Depositar(int monto)
        {
            balance += monto;
            //valida el estado.

            if (balance > 100)
                m_Cuenta.m_Estado = new EstadoCritico(this);

		}

	}//end EstadoIntermedio

}//end namespace State