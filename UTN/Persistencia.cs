namespace UTN
{
    internal class Persistencia
    {
        private static List<Alumno> Alumnos = new()
        {
            new Alumno { Legajo = "123", Nombre = "Juan"},
            new Alumno { Legajo = "452", Nombre = "Irma" },
        };

        public static Alumno? BuscarAlumnoPorLegajo(string legajo)
        {
            return Alumnos.FirstOrDefault(alumno => alumno.Legajo == legajo);
        }

        internal static void GuadarInscripcion(InscripcionExamen inscripcion)
        {
            // Tengo que tener la lista creada
            // Agrego la inscripcion a la lista
        }
    }
}
