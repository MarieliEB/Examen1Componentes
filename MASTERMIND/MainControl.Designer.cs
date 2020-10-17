namespace MASTERMIND
{
    partial class MainControl
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.MASTERMIND = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnReiniciarJuego = new System.Windows.Forms.Button();
            this.lblATotales = new System.Windows.Forms.Label();
            this.lblAParciales = new System.Windows.Forms.Label();
            this.aciertosTotales = new System.Windows.Forms.Label();
            this.aciertosParciales = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.contIntentos = new System.Windows.Forms.Label();
            this.codigoCorrecto = new System.Windows.Forms.Label();
            this.lblGanaste = new System.Windows.Forms.Label();
            this.lblPerdiste = new System.Windows.Forms.Label();
            this.JuegoIniciadoPanel = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.JuegoIniciadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuPanel.Controls.Add(this.btnIniciarJuego);
            this.MenuPanel.Controls.Add(this.MASTERMIND);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(211, 450);
            this.MenuPanel.TabIndex = 1;
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.BackColor = System.Drawing.Color.Teal;
            this.btnIniciarJuego.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarJuego.Location = new System.Drawing.Point(0, 123);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(211, 44);
            this.btnIniciarJuego.TabIndex = 1;
            this.btnIniciarJuego.Text = "Iniciar Juego";
            this.btnIniciarJuego.UseVisualStyleBackColor = false;
            this.btnIniciarJuego.Click += new System.EventHandler(this.iniciarJuego_Click);
            // 
            // MASTERMIND
            // 
            this.MASTERMIND.AutoSize = true;
            this.MASTERMIND.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MASTERMIND.Location = new System.Drawing.Point(31, 64);
            this.MASTERMIND.Name = "MASTERMIND";
            this.MASTERMIND.Size = new System.Drawing.Size(147, 22);
            this.MASTERMIND.TabIndex = 0;
            this.MASTERMIND.Text = "MASTERMIND";
            this.MASTERMIND.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.Location = new System.Drawing.Point(74, 34);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(425, 96);
            this.lblInstrucciones.TabIndex = 2;
            this.lblInstrucciones.Text = "Instrucciones:\r\n\r\n     1. Ingrese un código de 4 letras.\r\n     2. Solo podra ingr" +
    "esar las letras que se mencionarán a continuación:\r\n      \r\n      A, R, B, N, V," +
    " M.";
            this.lblInstrucciones.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(74, 151);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(114, 16);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Ingrese su código:";
            this.lblCodigo.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(235, 147);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(154, 20);
            this.txtCodigo.TabIndex = 12;
            this.txtCodigo.Visible = false;
            // 
            // btnComparar
            // 
            this.btnComparar.BackColor = System.Drawing.Color.Turquoise;
            this.btnComparar.Location = new System.Drawing.Point(274, 187);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(83, 25);
            this.btnComparar.TabIndex = 13;
            this.btnComparar.Text = "Comparar ";
            this.btnComparar.UseVisualStyleBackColor = false;
            this.btnComparar.Visible = false;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnReiniciarJuego
            // 
            this.btnReiniciarJuego.BackColor = System.Drawing.Color.Turquoise;
            this.btnReiniciarJuego.Location = new System.Drawing.Point(263, 373);
            this.btnReiniciarJuego.Name = "btnReiniciarJuego";
            this.btnReiniciarJuego.Size = new System.Drawing.Size(109, 23);
            this.btnReiniciarJuego.TabIndex = 14;
            this.btnReiniciarJuego.Text = "Reiniciar juego";
            this.btnReiniciarJuego.UseVisualStyleBackColor = false;
            this.btnReiniciarJuego.Visible = false;
            this.btnReiniciarJuego.Click += new System.EventHandler(this.btnReiniciarJuego_Click);
            // 
            // lblATotales
            // 
            this.lblATotales.AutoSize = true;
            this.lblATotales.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATotales.Location = new System.Drawing.Point(232, 295);
            this.lblATotales.Name = "lblATotales";
            this.lblATotales.Size = new System.Drawing.Size(103, 16);
            this.lblATotales.TabIndex = 15;
            this.lblATotales.Text = "Aciertos totales:";
            this.lblATotales.Visible = false;
            // 
            // lblAParciales
            // 
            this.lblAParciales.AutoSize = true;
            this.lblAParciales.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAParciales.Location = new System.Drawing.Point(232, 335);
            this.lblAParciales.Name = "lblAParciales";
            this.lblAParciales.Size = new System.Drawing.Size(116, 16);
            this.lblAParciales.TabIndex = 16;
            this.lblAParciales.Text = "Aciertos parciales:";
            this.lblAParciales.Visible = false;
            // 
            // aciertosTotales
            // 
            this.aciertosTotales.AutoSize = true;
            this.aciertosTotales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aciertosTotales.Location = new System.Drawing.Point(382, 293);
            this.aciertosTotales.Name = "aciertosTotales";
            this.aciertosTotales.Size = new System.Drawing.Size(17, 18);
            this.aciertosTotales.TabIndex = 17;
            this.aciertosTotales.Text = "0";
            this.aciertosTotales.Visible = false;
            // 
            // aciertosParciales
            // 
            this.aciertosParciales.AutoSize = true;
            this.aciertosParciales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aciertosParciales.Location = new System.Drawing.Point(382, 333);
            this.aciertosParciales.Name = "aciertosParciales";
            this.aciertosParciales.Size = new System.Drawing.Size(17, 18);
            this.aciertosParciales.TabIndex = 18;
            this.aciertosParciales.Text = "0";
            this.aciertosParciales.Visible = false;
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.Location = new System.Drawing.Point(74, 242);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(131, 16);
            this.lblDisponible.TabIndex = 19;
            this.lblDisponible.Text = "Intentos disponibles: ";
            this.lblDisponible.Visible = false;
            // 
            // contIntentos
            // 
            this.contIntentos.AutoSize = true;
            this.contIntentos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contIntentos.Location = new System.Drawing.Point(235, 240);
            this.contIntentos.Name = "contIntentos";
            this.contIntentos.Size = new System.Drawing.Size(17, 18);
            this.contIntentos.TabIndex = 20;
            this.contIntentos.Text = "8";
            this.contIntentos.Visible = false;
            // 
            // codigoCorrecto
            // 
            this.codigoCorrecto.AutoSize = true;
            this.codigoCorrecto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoCorrecto.Location = new System.Drawing.Point(418, 145);
            this.codigoCorrecto.Name = "codigoCorrecto";
            this.codigoCorrecto.Size = new System.Drawing.Size(54, 22);
            this.codigoCorrecto.TabIndex = 21;
            this.codigoCorrecto.Text = "0000";
            this.codigoCorrecto.Visible = false;
            // 
            // lblGanaste
            // 
            this.lblGanaste.AutoSize = true;
            this.lblGanaste.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanaste.Location = new System.Drawing.Point(139, 61);
            this.lblGanaste.Name = "lblGanaste";
            this.lblGanaste.Size = new System.Drawing.Size(300, 24);
            this.lblGanaste.TabIndex = 22;
            this.lblGanaste.Text = "Código correcto, Ganaste!!!!";
            this.lblGanaste.Visible = false;
            // 
            // lblPerdiste
            // 
            this.lblPerdiste.AutoSize = true;
            this.lblPerdiste.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerdiste.Location = new System.Drawing.Point(186, 61);
            this.lblPerdiste.Name = "lblPerdiste";
            this.lblPerdiste.Size = new System.Drawing.Size(212, 24);
            this.lblPerdiste.TabIndex = 23;
            this.lblPerdiste.Text = "Vuelve a intentarlo!!";
            this.lblPerdiste.Visible = false;
            // 
            // JuegoIniciadoPanel
            // 
            this.JuegoIniciadoPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.JuegoIniciadoPanel.Controls.Add(this.lblError);
            this.JuegoIniciadoPanel.Controls.Add(this.lblInstrucciones);
            this.JuegoIniciadoPanel.Controls.Add(this.lblPerdiste);
            this.JuegoIniciadoPanel.Controls.Add(this.lblGanaste);
            this.JuegoIniciadoPanel.Controls.Add(this.codigoCorrecto);
            this.JuegoIniciadoPanel.Controls.Add(this.contIntentos);
            this.JuegoIniciadoPanel.Controls.Add(this.lblDisponible);
            this.JuegoIniciadoPanel.Controls.Add(this.aciertosParciales);
            this.JuegoIniciadoPanel.Controls.Add(this.aciertosTotales);
            this.JuegoIniciadoPanel.Controls.Add(this.lblAParciales);
            this.JuegoIniciadoPanel.Controls.Add(this.lblATotales);
            this.JuegoIniciadoPanel.Controls.Add(this.btnReiniciarJuego);
            this.JuegoIniciadoPanel.Controls.Add(this.btnComparar);
            this.JuegoIniciadoPanel.Controls.Add(this.txtCodigo);
            this.JuegoIniciadoPanel.Controls.Add(this.lblCodigo);
            this.JuegoIniciadoPanel.Location = new System.Drawing.Point(207, 0);
            this.JuegoIniciadoPanel.Name = "JuegoIniciadoPanel";
            this.JuegoIniciadoPanel.Size = new System.Drawing.Size(593, 450);
            this.JuegoIniciadoPanel.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(405, 147);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(151, 45);
            this.lblError.TabIndex = 24;
            this.lblError.Text = "Código incorrecto!!!\r\nFavor ingrese solo las \r\nletras permitidas!!";
            this.lblError.Visible = false;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.JuegoIniciadoPanel);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.JuegoIniciadoPanel.ResumeLayout(false);
            this.JuegoIniciadoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnIniciarJuego;
        private System.Windows.Forms.Label MASTERMIND;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel JuegoIniciadoPanel;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblPerdiste;
        private System.Windows.Forms.Label lblGanaste;
        private System.Windows.Forms.Label codigoCorrecto;
        private System.Windows.Forms.Label contIntentos;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label aciertosParciales;
        private System.Windows.Forms.Label aciertosTotales;
        private System.Windows.Forms.Label lblAParciales;
        private System.Windows.Forms.Label lblATotales;
        private System.Windows.Forms.Button btnReiniciarJuego;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblError;
    }
}
