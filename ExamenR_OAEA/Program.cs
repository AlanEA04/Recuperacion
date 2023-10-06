namespace ExamenR_OAEA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu Curp");
            string Curp = (Console.ReadLine());

            CurpPersona curpPersona= new CurpPersona();





           // string sexo = curpPersona.ObtenerSexo(Curp);

            string fechaNaciminto = curpPersona.ObtenerFechaNacimiento(Curp);


          //  Console.WriteLine("Sexo" + sexo);
            Console.WriteLine("FechaNacimiento: " + fechaNaciminto);









        }
    }
}