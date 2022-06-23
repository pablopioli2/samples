namespace UTN
{
    internal class InscripcionController
    {
        internal (bool, string) Inscribir(string legajo, string idMateria, DateOnly fechaInscripcion)
        {
            if (string.IsNullOrEmpty(legajo))
            {
                return (false, "El legajo te falto");
            }

            var alumno = Persistencia.BuscarAlumnoPorLegajo(legajo);

            if (alumno == null)
            {
                return (false, "Alumno inexistente");
            }

            if (!Validar())
            {
                return (false, "No te podes inscribir");
            }

            var inscripcion = new InscripcionExamen();

            Persistencia.GuadarInscripcion(inscripcion);

            return (true, "");
        }

        private bool Validar()
        {
            return true;
        }

    }
}
