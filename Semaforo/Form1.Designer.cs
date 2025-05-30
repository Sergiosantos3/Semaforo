namespace Semaforo
{
    partial class Semáforo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Semáforo));
            openFileDialog1 = new OpenFileDialog();
            pibSemaforo = new PictureBox();
            btnIniciar = new Button();
            btnParar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pibSemaforo).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pibSemaforo
            // 
            pibSemaforo.Image = Properties.Resources.Apagado;
            pibSemaforo.Location = new Point(3, 1);
            pibSemaforo.Name = "pibSemaforo";
            pibSemaforo.Size = new Size(211, 329);
            pibSemaforo.SizeMode = PictureBoxSizeMode.StretchImage;
            pibSemaforo.TabIndex = 0;
            pibSemaforo.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(3, 336);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(211, 39);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(3, 381);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(211, 39);
            btnParar.TabIndex = 2;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Semáforo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 428);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Controls.Add(pibSemaforo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Semáforo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Semáforo";
            ((System.ComponentModel.ISupportInitialize)pibSemaforo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private PictureBox pibSemaforo;
        private Button btnIniciar;
        private Button btnParar;
        private System.Windows.Forms.Timer timer1;
    }
}
