namespace ProjetoZero3
{
    partial class Form1
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
            lblId = new Label();
            lblNome = new Label();
            lblCpf = new Label();
            lblEmail = new Label();
            dgPessoa = new DataGridView();
            txtId = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPessoa).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(27, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 64);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(27, 108);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(26, 15);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "Cpf";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(27, 152);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // dgPessoa
            // 
            dgPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPessoa.Location = new Point(5, 219);
            dgPessoa.Name = "dgPessoa";
            dgPessoa.RowTemplate.Height = 25;
            dgPessoa.Size = new Size(779, 138);
            dgPessoa.TabIndex = 4;
            dgPessoa.CellClick += dgPessoa_CellClick;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(27, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(203, 23);
            txtId.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(27, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(27, 126);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(203, 23);
            txtCpf.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(27, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(203, 23);
            txtNome.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(307, 180);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(433, 180);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(566, 180);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNome);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Controls.Add(dgPessoa);
            Controls.Add(lblEmail);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "ProjetoZero3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgPessoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblCpf;
        private Label lblEmail;
        private DataGridView dgPessoa;
        private TextBox txtId;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtNome;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnRemover;
    }
}