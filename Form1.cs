using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
  public partial class Form1 : Form
  {
    private enum Entrada
    {
      NINGUNA,
      DIGITO,
      OPERADOR,
      CE
    }

    private Entrada ultimaEntrada;
    private bool comaDecimal;
    private char operador;
    private byte numOperandos;
    private double operando1;
    private double operando2;

    public Form1()
    {
      InitializeComponent();
      ultimaEntrada = Entrada.NINGUNA;
      comaDecimal = false;
      operador = '\0';
      numOperandos = 0;
      operando1 = 0;
      operando2 = 0;
    }

    private void btDigito_Click(object sender, EventArgs e)
    {
      Button objButton = (Button)sender;

      if (ultimaEntrada != Entrada.DIGITO)
      {
        if (objButton.Text == "0") return;
        etPantalla.Text = "";
        ultimaEntrada = Entrada.DIGITO;
        comaDecimal = false; 
      }
      etPantalla.Text += objButton.Text;
    }

    private void btComaDec_Click(object sender, EventArgs e)
    {
      if (ultimaEntrada != Entrada.DIGITO)
      {
        etPantalla.Text = "0,";
        ultimaEntrada = Entrada.DIGITO;
      }
      else if (comaDecimal == false)
        etPantalla.Text = etPantalla.Text + ",";

      comaDecimal = true;
    }

    private void btOperacion_Click(object sender, EventArgs e)
    {
      // Obtener el id del botón que generó el evento
      Button objButton = (Button)sender;
      // Obtener el texto del botón pulsado
      string textoBoton = objButton.Text;

      if ((numOperandos == 0) && (textoBoton[0] == '-'))
        ultimaEntrada = Entrada.DIGITO;

      if (ultimaEntrada == Entrada.DIGITO)
        numOperandos += 1;

      if (numOperandos == 1)
        operando1 = double.Parse(etPantalla.Text);
      else if (numOperandos == 2)
      {
        operando2 = double.Parse(etPantalla.Text);
        switch (operador)
        {
          case '+':
            operando1 += operando2;
            break;
          case '-':
            operando1 -= operando2;
            break;
          case 'x':
            operando1 *= operando2;
            break;
          case '/':
            operando1 /= operando2;
            break;
          case '=':
            operando1 = operando2;
            break;
        }
        // Visualizar el resultado
        etPantalla.Text = operando1.ToString();
        numOperandos = 1;
      }
      operador = textoBoton[0]; // carácter de la posición 0
      ultimaEntrada = Entrada.OPERADOR;
    }

    private void btTantoPorCiento_Click(object sender, EventArgs e)
    {
      double resultado;
      if (ultimaEntrada == Entrada.DIGITO)
      {
        resultado = operando1 * double.Parse(etPantalla.Text) / 100;
        // Visualizar el resultado
        etPantalla.Text = resultado.ToString();
        // Simular que se ha hecho clic en "="
        btIgual.PerformClick();
        // Enfocar la tecla %
        btTantoPorCiento.Focus();
      }
    }

    private void btIniciar_Click(object sender, EventArgs e)
    {
      etPantalla.Text = "0,";
      ultimaEntrada = Entrada.NINGUNA;
      comaDecimal = false;
      operador = '\0';
      numOperandos = 0;
      operando1 = 0;
      operando2 = 0;
    }

    private void btBorrarEntrada_Click(object sender, EventArgs e)
    {
      etPantalla.Text = "0,";
      ultimaEntrada = Entrada.CE;
      comaDecimal = false;
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(240, 450);
            etPantalla.Size = new Size(200, 50);
            NumApp.Size = new Size(225, 16);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(480, 450);
            etPantalla.Size = new Size(420, 50);
            NumApp.Size = new Size(475, 16);
        }

        private void cbInvertirColores_CheckedChanged(object sender, EventArgs e)
        {
            Color_Invert();
        }

        private void Color_Invert()
        {
            lblITA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            lblITA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            etTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            etTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDigito0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDigito0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDigito1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDigito1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDigito2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDigito2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDigito3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDigito3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDigito4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDigito4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDigito5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDigito5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDigito6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDigito6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDigito7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDigito7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDigito8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDigito8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDigito9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDigito9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btComaDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btComaDec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btBorrarEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btBorrarEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btTantoPorCiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btTantoPorCiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btDividir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btMenos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btMas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            btIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            btIgual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(139)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

            etPantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));
            etPantalla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

            NumApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            NumApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(000)))), ((int)(((byte)(000)))), ((int)(((byte)(000)))));

        }

        private void btComaDec_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
