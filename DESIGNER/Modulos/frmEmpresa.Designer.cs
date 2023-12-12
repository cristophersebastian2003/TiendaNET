
namespace DESIGNER.Modulos
{
    partial class frmEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.gridEmpresa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtRazonsocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnCerrar1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpresa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar datos a Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(15, 28);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(998, 20);
            this.txtBuscar1.TabIndex = 1;
            this.txtBuscar1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBuscar1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar1_KeyUp);
            // 
            // gridEmpresa
            // 
            this.gridEmpresa.AllowUserToAddRows = false;
            this.gridEmpresa.AllowUserToDeleteRows = false;
            this.gridEmpresa.AllowUserToResizeColumns = false;
            this.gridEmpresa.AllowUserToResizeRows = false;
            this.gridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpresa.Location = new System.Drawing.Point(15, 54);
            this.gridEmpresa.Name = "gridEmpresa";
            this.gridEmpresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridEmpresa.Size = new System.Drawing.Size(998, 356);
            this.gridEmpresa.TabIndex = 2;
            this.gridEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gridEmpresa.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridEmpresa_DataBindingComplete);
            this.gridEmpresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridEmpresa_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWebsite);
            this.groupBox1.Controls.Add(this.txtEmail1);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.txtRazonsocial);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Empresa";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(525, 74);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(140, 20);
            this.txtWebsite.TabIndex = 4;
            this.txtWebsite.TextChanged += new System.EventHandler(this.textWebsite_TextChanged);
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(525, 28);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(140, 20);
            this.txtEmail1.TabIndex = 10;
            this.txtEmail1.TextChanged += new System.EventHandler(this.textEmail1_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(312, 75);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.TextChanged += new System.EventHandler(this.textTelefono_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(312, 28);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(140, 20);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TextChanged += new System.EventHandler(this.textDireccion_TextChanged);
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(95, 68);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(136, 20);
            this.txtRuc.TabIndex = 7;
            this.txtRuc.TextChanged += new System.EventHandler(this.textRuc_TextChanged);
            // 
            // txtRazonsocial
            // 
            this.txtRazonsocial.Location = new System.Drawing.Point(95, 28);
            this.txtRazonsocial.Name = "txtRazonsocial";
            this.txtRazonsocial.Size = new System.Drawing.Size(136, 20);
            this.txtRazonsocial.TabIndex = 6;
            this.txtRazonsocial.TextChanged += new System.EventHandler(this.txtRazonsocial_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Website";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ruc";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Razon Social";
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(873, 444);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(121, 23);
            this.btnGuardar1.TabIndex = 4;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar1_Click);
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Location = new System.Drawing.Point(873, 482);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(121, 23);
            this.btnCancelar1.TabIndex = 5;
            this.btnCancelar1.Text = "Cancelar";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            // 
            // btnCerrar1
            // 
            this.btnCerrar1.Location = new System.Drawing.Point(873, 520);
            this.btnCerrar1.Name = "btnCerrar1";
            this.btnCerrar1.Size = new System.Drawing.Size(121, 23);
            this.btnCerrar1.TabIndex = 6;
            this.btnCerrar1.Text = "Cerrar";
            this.btnCerrar1.UseVisualStyleBackColor = true;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 566);
            this.Controls.Add(this.btnCerrar1);
            this.Controls.Add(this.btnCancelar1);
            this.Controls.Add(this.btnGuardar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridEmpresa);
            this.Controls.Add(this.txtBuscar1);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpresa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar1;
        private System.Windows.Forms.DataGridView gridEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtRazonsocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.Button btnCerrar1;
    }
}