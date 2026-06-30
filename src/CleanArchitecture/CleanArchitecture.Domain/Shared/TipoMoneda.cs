namespace CleanArchitecture.Domain.Shared
{
   public record TipoMoneda{

    public static readonly TipoMoneda None = new("");
    public static readonly TipoMoneda Dolar = new("USD");
    public static readonly TipoMoneda Euro = new("EUR");


    private TipoMoneda(string codigo) => Codigo = codigo;
    public string? Codigo { get; init; }


    public static readonly IReadOnlyCollection<TipoMoneda> All = new[] {Dolar, Euro };

    public static TipoMoneda FromCodigo(string codigo)
    {
        return All.FirstOrDefault(c => c.Codigo == codigo) ?? 
            throw new ApplicationException($"Tipo de moneda con codigo '{codigo}' no encontrado.");
    }
   }
}   