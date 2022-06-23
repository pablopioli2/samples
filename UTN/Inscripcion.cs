namespace UTN
{
    public enum Resultado
    {
        Ok,
        LegajoVacio,
        MateriaVacia
    }

    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var legajo = Legajo.Text;
            var idMateria = Materia.Text;

            var controller = new InscripcionController();
            var (resultado, error) = controller.Inscribir(legajo, idMateria, DateOnly.FromDateTime(DateTime.Now.AddDays(2)));

            if (!resultado)
            {
                MessageBox.Show(error);
            }
        }
    }
}