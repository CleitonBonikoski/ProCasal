using Model;

namespace Controller
{
    public class MesController
    {
        private Context context = new Context();

        #region CadastrarMes

        public void CadastrarMes(string diaEspecial, string lugarTop, string NivelFelicidade)
        {
            Mes mesAtual = new Mes();

            mesAtual.DiaEspecial = diaEspecial;
            mesAtual.LugarTop = lugarTop;
            mesAtual.NivelFelicidade = NivelFelicidade;

            context.dBmes.Add(mesAtual);
            context.SaveChanges();

        }

        #endregion

    }
}
