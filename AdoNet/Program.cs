namespace AdoNet
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new Form1PrimerAdo());
            // Application.Run(new Form2BuscadorEmpleados());
            // Application.Run(new Form3EliminarEnfermo
            // Application.Run(new Form4ModificarSalas());
            // Application.Run(new Form5DepartamentosEmp());
            Application.Run(new Form6AccionDepartamentos());
        }
    }
}