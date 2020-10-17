using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASTERMIND
{
    public partial class MainControl : UserControl
    {
        #region Properties
        private int[] ArrayNumAleatorios { get; set; }
        private string[] CodigoDigitado { get; set; }
        private string[] CodigoCifrado { get; set; }
        private int ContadorIntentos { get; set; }
        private int NumAciertosTotales { get; set; }
        private int NumAciertosParciales { get; set; }
        private string codCorrecto { get; set; }
        #endregion

        #region constructor
        public MainControl()
        {
            InitializeComponent();
            this.ArrayNumAleatorios = new int[4];
            this.CodigoCifrado = new string[4];
            this.CodigoDigitado = new string[4];
            this.ContadorIntentos = 8;
        }
        #endregion

        #region methods
        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void iniciarJuego_Click(object sender, EventArgs e)
        {
            mostrarJuegoIniciado();
            GenerarCuatroNumAleatorios();
            this.contIntentos.Text = Convert.ToString(this.ContadorIntentos);
            this.aciertosTotales.Text = Convert.ToString(this.NumAciertosTotales);
            this.aciertosParciales.Text = Convert.ToString(this.NumAciertosParciales);
        }

        private void mostrarJuegoIniciado()
        {
            this.lblCodigo.Visible = true;
            this.txtCodigo.Enabled = true;
            this.txtCodigo.Visible = true;
            this.btnComparar.Visible = true;
            this.btnComparar.Enabled = true;
            this.lblDisponible.Visible = true;
            this.contIntentos.Visible = true;
            this.lblATotales.Visible = true;
            this.lblAParciales.Visible = true;
            this.aciertosTotales.Visible = true;
            this.aciertosParciales.Visible = true;
            this.btnReiniciarJuego.Visible = true;
            this.lblInstrucciones.Visible = true;
            this.codigoCorrecto.Visible = false;
            this.ContadorIntentos = 8;
            this.NumAciertosParciales = 0;
            this.NumAciertosTotales = 0;
        }

        private void GenerarCuatroNumAleatorios()
        {
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                int numRandom = rnd.Next(1, 6);
                if (numRandom == 0)
                {
                    numRandom++;
                }
                this.ArrayNumAleatorios[i] = numRandom;
            }
            AsignarLetra(this.ArrayNumAleatorios);
        }

        private void AsignarLetra(int[] numsAleatorios)
        {
            for (int i = 0; i < 4; i++)
            {
                switch (numsAleatorios[i])
                {
                    case 1:
                        this.CodigoCifrado[i] = "A";
                        break;
                    case 2:
                        this.CodigoCifrado[i] = "R";
                        break;
                    case 3:
                        this.CodigoCifrado[i] = "B";
                        break;
                    case 4:
                        this.CodigoCifrado[i] = "N";
                        break;
                    case 5:
                        this.CodigoCifrado[i] = "V";
                        break;
                    case 6:
                        this.CodigoCifrado[i] = "M";
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            this.codCorrecto = string.Join("", this.CodigoCifrado);
            this.codigoCorrecto.Text = this.codCorrecto;
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            SepararCaracteresDeCodigo(this.txtCodigo.Text);
            this.txtCodigo.Text = "";
        }

        private void SepararCaracteresDeCodigo(string codigoUsuario)
        {
            int cont = 0;
            codigoUsuario = codigoUsuario.ToUpper();

            foreach (char c in codigoUsuario)
            {
                this.CodigoDigitado[cont] = Convert.ToString(c);
                cont++;
            }
            ValidarCaracteres(this.CodigoDigitado);
        }

        private void ValidarCaracteres(string[] codigo)
        {
            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigo[i].Equals("A") || codigo[i].Equals("R") ||
                    codigo[i].Equals("B") || codigo[i].Equals("N") ||
                    codigo[i].Equals("V") || codigo[i].Equals("M"))
                {
                    this.lblError.Visible = false;
                    if (i == 3)
                    {
                        MostrarAciertosTotales();
                        MostrarAciertosParciales();
                        this.ContadorIntentos = this.ContadorIntentos - 1;
                        this.contIntentos.Text = Convert.ToString(this.ContadorIntentos);
                    }
                }
                else
                {
                    this.txtCodigo.Text = "";
                    this.lblError.Visible = true;
                    break;
                }
            }
        }

        private void MostrarAciertosTotales()
        {
            this.NumAciertosTotales = 0;
            for (int i = 0; i < 4; i++)
            {
                if (CodigoCifrado[i] == CodigoDigitado[i])
                {
                    this.NumAciertosTotales++;
                }
            }
            this.aciertosTotales.Text = Convert.ToString(this.NumAciertosTotales);
            MostrarGane(this.NumAciertosTotales);
        }

        private void MostrarGane(int aciertos)
        {
            if(aciertos == 4)
            {
                this.lblInstrucciones.Visible = false;
                this.lblGanaste.Visible = true;
                this.codigoCorrecto.Visible = true;
            }
        }

        private void MostrarPerdida()
        {
            if(this.ContadorIntentos == 1)
            {
                this.lblInstrucciones.Visible = false;
                this.lblPerdiste.Visible = true;
                this.txtCodigo.Enabled = false;
                this.btnComparar.Enabled = false;
                this.codigoCorrecto.Visible = true;
            }
        }

        private void MostrarAciertosParciales()
        {
            this.NumAciertosParciales = 0;
            for (int i = 0; i < this.CodigoCifrado.Length; i++)
            {
                for (int j = 0; j < this.CodigoDigitado.Length; j++)
                {
                    if (CodigoCifrado[i] == CodigoDigitado[j])
                    {
                        this.NumAciertosParciales++;
                    }
                }
            }
            if (this.NumAciertosTotales > 0)
            {
                this.NumAciertosParciales = this.NumAciertosParciales - this.NumAciertosTotales;
            }
            this.aciertosParciales.Text = Convert.ToString(this.NumAciertosParciales);
            MostrarPerdida();
        }
        #endregion

        private void btnReiniciarJuego_Click(object sender, EventArgs e)
        {
            mostrarJuegoIniciado();
            GenerarCuatroNumAleatorios();
            this.contIntentos.Text = Convert.ToString(this.ContadorIntentos);
            this.aciertosTotales.Text = Convert.ToString(this.NumAciertosTotales);
            this.aciertosParciales.Text = Convert.ToString(this.NumAciertosParciales);
        }
    }
}
