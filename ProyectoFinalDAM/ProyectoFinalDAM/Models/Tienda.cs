namespace ProyectoFinalDAM.Models
{
    public class Tienda
    {
        public string? codigo_tienda { get; set; }
        public string? nombre_tienda { get; set; }
        public string? ciudad { get; set; }
        public string? fuente { get; set; }

        // Mapeamos el objeto de meses
        public Dictionary<string, double>? ventas_mes { get; set; }

        // Propiedad calculada: Sumamos los valores del diccionario para obtener el total
        public double ventas_anuales => ventas_mes?.Values.Sum() ?? 0;
    }
}