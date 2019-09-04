// using _05_ByteBank;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;
        private int _numero;
        private int _agencia;
        private double _saldo;

        //Getter
        public Cliente GetTitular()
        {
            return this._titular;
        }

        //Setter
        public void SetTitular(Cliente titular)
        {
            this._titular = titular;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
