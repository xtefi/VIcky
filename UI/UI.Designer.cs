
namespace UI
{
    partial class UI
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
            this.dgrPersonas = new System.Windows.Forms.DataGridView();
            this.dgrAdelantos = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxLegajo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLejago = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.numSueldo = new System.Windows.Forms.NumericUpDown();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAdelantos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrPersonas
            // 
            this.dgrPersonas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPersonas.GridColor = System.Drawing.Color.Black;
            this.dgrPersonas.Location = new System.Drawing.Point(13, 15);
            this.dgrPersonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrPersonas.Name = "dgrPersonas";
            this.dgrPersonas.RowTemplate.Height = 25;
            this.dgrPersonas.Size = new System.Drawing.Size(468, 222);
            this.dgrPersonas.TabIndex = 0;
            // 
            // dgrAdelantos
            // 
            this.dgrAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrAdelantos.Location = new System.Drawing.Point(13, 267);
            this.dgrAdelantos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrAdelantos.Name = "dgrAdelantos";
            this.dgrAdelantos.RowTemplate.Height = 25;
            this.dgrAdelantos.Size = new System.Drawing.Size(541, 189);
            this.dgrAdelantos.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(13, 488);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(726, 219);
            this.dataGridView3.TabIndex = 2;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(605, 15);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(114, 26);
            this.tbxNombre.TabIndex = 3;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(605, 54);
            this.tbxApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(114, 26);
            this.tbxApellido.TabIndex = 4;
            // 
            // tbxLegajo
            // 
            this.tbxLegajo.Location = new System.Drawing.Point(605, 95);
            this.tbxLegajo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxLegajo.Name = "tbxLegajo";
            this.tbxLegajo.Size = new System.Drawing.Size(114, 26);
            this.tbxLegajo.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(517, 15);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 18);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(517, 54);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 18);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblLejago
            // 
            this.lblLejago.AutoSize = true;
            this.lblLejago.Location = new System.Drawing.Point(517, 95);
            this.lblLejago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLejago.Name = "lblLejago";
            this.lblLejago.Size = new System.Drawing.Size(56, 18);
            this.lblLejago.TabIndex = 9;
            this.lblLejago.Text = "Legajo:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(517, 137);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(57, 18);
            this.lblSueldo.TabIndex = 10;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(655, 220);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(148, 42);
            this.btnNuevoEmpleado.TabIndex = 11;
            this.btnNuevoEmpleado.Text = "Ingresar empleado";
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // numSueldo
            // 
            this.numSueldo.Location = new System.Drawing.Point(605, 137);
            this.numSueldo.Name = "numSueldo";
            this.numSueldo.Size = new System.Drawing.Size(120, 26);
            this.numSueldo.TabIndex = 12;
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(604, 178);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(121, 26);
            this.cbxCategorias.TabIndex = 13;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(517, 177);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoria:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(815, 735);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.numSueldo);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblLejago);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxLegajo);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dgrAdelantos);
            this.Controls.Add(this.dgrPersonas);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UI";
            this.Text = "Administrador de adelantos";
            ((System.ComponentModel.ISupportInitialize)(this.dgrPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAdelantos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrPersonas;
        private System.Windows.Forms.DataGridView dgrAdelantos;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxLegajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblLejago;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Button btnNuevoEmpleado;
        private System.Windows.Forms.NumericUpDown numSueldo;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button button1;
    }
}

