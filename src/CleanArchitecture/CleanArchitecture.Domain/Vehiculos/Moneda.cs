namespace CleanArchitecture.Domain.Vehiculos
{
    public record Moneda(decimal Monto,  TipoMoneda TipoMoneda){

        public static Moneda operador +(Moneda primero, Moneda segundo){
            if(primero.TipoMoneda != segundo.TipoMoneda){
                throw new InvalidOperationException("No se pueden sumar monedas de diferentes tipos");
            }
            return new Moneda(primero.Monto + segundo.Monto, primero.TipoMoneda);
        }

        public static Moneda Zero() => new (0, TipoMoneda.None);
        public static Moneda Zero(TipoMoneda tipoMoneda) => new (0, tipoMoneda);
        public bool IsZero() => this == Zero(tipoMoneda);

    };
}