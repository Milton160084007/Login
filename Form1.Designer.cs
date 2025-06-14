using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        private AuthController auth = new AuthController();
        private int intentosRestantes = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (auth.Login(txtNombreUsuario.Text, txtClaveAcceso.Text))
            {
                MessageBox.Show("¡Acceso concedido!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                intentosRestantes--;

                if (intentosRestantes > 0)
                {
                    lblNotificacion.Text = $"Credenciales incorrectas. Te quedan {intentosRestantes} intentos.";
                    lblNotificacion.Visible = true;
                    txtClaveAcceso.Clear();
                    txtClaveAcceso.Focus();
                }
                else
                {
                    MessageBox.Show("Has superado el número máximo de intentos. El programa se cerrará.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Código generado automáticamente
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtClaveAcceso;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNotificacion;
        private System.Windows.Forms.Panel panelContenedor;

        private void InitializeComponent()
        {
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtClaveAcceso = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();

            // txtNombreUsuario
            this.txtNombreUsuario.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreUsuario.Location = new System.Drawing.Point(40, 100);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(280, 27);
            this.txtNombreUsuario.TabIndex = 0;

            // txtClaveAcceso
            this.txtClaveAcceso.BackColor = System.Drawing.Color.AliceBlue;
            this.txtClaveAcceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaveAcceso.Location = new System.Drawing.Point(40, 160);
            this.txtClaveAcceso.Name = "txtClaveAcceso";
            this.txtClaveAcceso.PasswordChar = '•';
            this.txtClaveAcceso.Size = new System.Drawing.Size(280, 27);
            this.txtClaveAcceso.TabIndex = 1;

            // btnAcceder
            this.btnAcceder.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Location = new System.Drawing.Point(40, 210);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(120, 35);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);

            // btnSalir
            this.btnSalir.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(200, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Location = new System.Drawing.Point(85, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 30);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Acceso al Sistema";

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.SlateGray;
            this.lblUsuario.Location = new System.Drawing.Point(36, 75);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(137, 20);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Nombre de usuario";

            // lblClave
            this.lblClave.AutoSize = true;
            this.lblClave.ForeColor = System.Drawing.Color.SlateGray;
            this.lblClave.Location = new System.Drawing.Point(36, 135);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(49, 20);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Clave";

            // lblNotificacion
            this.lblNotificacion.AutoSize = true;
            this.lblNotificacion.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNotificacion.Location = new System.Drawing.Point(36, 270);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(0, 20);
            this.lblNotificacion.TabIndex = 7;

            // panelContenedor
            this.panelContenedor.BackColor = System.Drawing.Color.Azure;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedor.Controls.Add(this.lblTitulo);
            this.panelContenedor.Controls.Add(this.lblNotificacion);
            this.panelContenedor.Controls.Add(this.txtNombreUsuario);
            this.panelContenedor.Controls.Add(this.lblClave);
            this.panelContenedor.Controls.Add(this.txtClaveAcceso);
            this.panelContenedor.Controls.Add(this.lblUsuario);
            this.panelContenedor.Controls.Add(this.btnAcceder);
            this.panelContenedor.Controls.Add(this.btnSalir);
            this.panelContenedor.Location = new System.Drawing.Point(20, 20);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(360, 320);
            this.panelContenedor.TabIndex = 8;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.panelContenedor);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticación";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }

    public class AuthController
    {
        private List<Usuario> usuarios = new List<Usuario>();
        public int IntentosFallidos { get; private set; }

        public AuthController()
        {
            // Usuario de prueba
            usuarios.Add(new Usuario
            {
                NombreUsuario = "admin",
                Contrasena = "123"
            });
        }

        public bool Login(string usuario, string contrasena)
        {
            foreach (var user in usuarios)
            {
                if (user.NombreUsuario == usuario && user.Contrasena == contrasena)
                {
                    return true;
                }
            }
            IntentosFallidos++;
            return false;
        }
    }

    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
    }
}
