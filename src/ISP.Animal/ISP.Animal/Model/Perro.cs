namespace ISP.Animal.Model
{
    public class Perro : Animal
    {
        private bool alimentado;
        private bool acariciado;
        public override void Alimentar()
        {
            alimentado = true;
        }

        public override void Acariciar()
        {
            acariciado = true;
        }

        public override string GetEstado()
        {
            string estado = string.Empty;
            if (alimentado) estado = "no quiero un hueso";
            if (!alimentado) estado = "quiero un hueso";
            if (!acariciado) estado += " y quiero jugar";
            return estado;
        }
    }
}
