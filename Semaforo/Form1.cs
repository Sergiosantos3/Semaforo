using Semaforo.Properties;

namespace Semaforo
{
    public partial class Semáforo : Form
    {
        private int estadoAtual = 1;
        private bool semafaroAtivo;

        public Semáforo()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            semafaroAtivo = true;
            estadoAtual = 1;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Muda o estado e atualiza a imagem
            switch (estadoAtual)
            {
                case 1:
                    pibSemaforo.Image = Properties.Resources.Verde; ;
                    timer1.Interval = 5000; // 5 segundos para verde
                    estadoAtual = 2;
                    break;
                case 2:
                    pibSemaforo.Image = Properties.Resources.Amarelo; ;
                    timer1.Interval = 2000; // 2 segundos para amarelo
                    estadoAtual = 3;
                    break;
                case 3:
                    pibSemaforo.Image = Properties.Resources.Vermelho;
                    timer1.Interval = 5000; // 5 segundos para vermelho
                    estadoAtual = 1;
                    break;
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            // Serve para Apagar o Semáforo
            pibSemaforo.Image = Properties.Resources.Apagado;
            timer1.Stop();
        }
    }
}
