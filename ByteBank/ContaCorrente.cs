namespace ByteBank {
    public class ContaCorrente {
        public Cliente _Titular { get; set; }
        public int _Agencia { get; set; }
        public int _Numero { get; set; }
        private double _Saldo { get; set; }
        public double Saldo {
            get { return _Saldo; }
        }

        public ContaCorrente (int Agencia, int Numero, Cliente Titular) {
            this._Agencia = Agencia;
            this._Numero = Numero;
            this._Titular = Titular;
            this._Saldo = 0.0;
        }

        public double Deposito (double valor) {
            if (valor > 0) {
                this.Saldo += valor;
                return this._Saldo;
            } else { System.Console.WriteLine ("Impossivel realizar um depósito negativo!"); }

        }
        public bool Saque (double valor) {
            if (valor < 0) {
                System.Console.WriteLine("Impossivel realizar um saque negativo!");
            } else if (valor <= this.Saldo) {
                this._Saldo -= valor;
                return true;
            } else {
                return false;
            }
        }
        public bool Transferencia (ContaCorrente destino, double valor) {
            if (this.Saque (valor)) {
                destino.Deposito (valor);
                return true;
            } else {
                return false;
            }
        }
    }
}