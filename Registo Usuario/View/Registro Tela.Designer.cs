namespace Registo_Usuario
{
    partial class Registro_Tela
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Tela));
            this.TxTBox_Enderço = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_Nome = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label_CPF = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label_Endereço = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxTBox_CPF = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxTBox_Nome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_Registro = new Bunifu.UI.WinForms.BunifuLabel();
            this.Exit_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Cadastrar_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Limpar_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Register_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Form_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label_Error = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TestaConexao_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Label_UsuarioCadastrado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // TxTBox_Enderço
            // 
            this.TxTBox_Enderço.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxTBox_Enderço.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxTBox_Enderço.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxTBox_Enderço.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBox_Enderço.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxTBox_Enderço.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxTBox_Enderço.HintForeColor = System.Drawing.Color.DarkGray;
            this.TxTBox_Enderço.HintText = "Av. Fulaninho de Tal, Qd. 00 Lt. 00";
            this.TxTBox_Enderço.isPassword = false;
            this.TxTBox_Enderço.LineFocusedColor = System.Drawing.Color.DarkGray;
            this.TxTBox_Enderço.LineIdleColor = System.Drawing.Color.Gray;
            this.TxTBox_Enderço.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.TxTBox_Enderço.LineThickness = 3;
            this.TxTBox_Enderço.Location = new System.Drawing.Point(36, 335);
            this.TxTBox_Enderço.Margin = new System.Windows.Forms.Padding(4);
            this.TxTBox_Enderço.MaxLength = 60;
            this.TxTBox_Enderço.Name = "TxTBox_Enderço";
            this.TxTBox_Enderço.Size = new System.Drawing.Size(379, 33);
            this.TxTBox_Enderço.TabIndex = 3;
            this.TxTBox_Enderço.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxTBox_Enderço.OnValueChanged += new System.EventHandler(this.TxTBox_Enderço_OnValueChanged);
            // 
            // Label_Nome
            // 
            this.Label_Nome.AutoSize = true;
            this.Label_Nome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nome.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Nome.Location = new System.Drawing.Point(32, 130);
            this.Label_Nome.Name = "Label_Nome";
            this.Label_Nome.Size = new System.Drawing.Size(53, 20);
            this.Label_Nome.TabIndex = 3;
            this.Label_Nome.Text = "Nome";
            // 
            // Label_CPF
            // 
            this.Label_CPF.AutoSize = true;
            this.Label_CPF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CPF.ForeColor = System.Drawing.Color.DimGray;
            this.Label_CPF.Location = new System.Drawing.Point(32, 220);
            this.Label_CPF.Name = "Label_CPF";
            this.Label_CPF.Size = new System.Drawing.Size(37, 20);
            this.Label_CPF.TabIndex = 4;
            this.Label_CPF.Text = "CPF";
            // 
            // Label_Endereço
            // 
            this.Label_Endereço.AutoSize = true;
            this.Label_Endereço.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Endereço.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Endereço.Location = new System.Drawing.Point(32, 311);
            this.Label_Endereço.Name = "Label_Endereço";
            this.Label_Endereço.Size = new System.Drawing.Size(81, 20);
            this.Label_Endereço.TabIndex = 5;
            this.Label_Endereço.Text = "Endereço";
            // 
            // TxTBox_CPF
            // 
            this.TxTBox_CPF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxTBox_CPF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxTBox_CPF.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxTBox_CPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBox_CPF.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxTBox_CPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxTBox_CPF.HintForeColor = System.Drawing.Color.DarkGray;
            this.TxTBox_CPF.HintText = "000.000.000-00";
            this.TxTBox_CPF.isPassword = false;
            this.TxTBox_CPF.LineFocusedColor = System.Drawing.Color.DarkGray;
            this.TxTBox_CPF.LineIdleColor = System.Drawing.Color.Gray;
            this.TxTBox_CPF.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.TxTBox_CPF.LineThickness = 3;
            this.TxTBox_CPF.Location = new System.Drawing.Point(36, 244);
            this.TxTBox_CPF.Margin = new System.Windows.Forms.Padding(4);
            this.TxTBox_CPF.MaxLength = 11;
            this.TxTBox_CPF.Name = "TxTBox_CPF";
            this.TxTBox_CPF.Size = new System.Drawing.Size(379, 33);
            this.TxTBox_CPF.TabIndex = 2;
            this.TxTBox_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxTBox_CPF.OnValueChanged += new System.EventHandler(this.TxTBox_CPF_OnValueChanged);
            this.TxTBox_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTBox_CPF_KeyPress);
            this.TxTBox_CPF.Leave += new System.EventHandler(this.TxTBox_CPF_Leave);
            // 
            // TxTBox_Nome
            // 
            this.TxTBox_Nome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxTBox_Nome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxTBox_Nome.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxTBox_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBox_Nome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxTBox_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxTBox_Nome.HintForeColor = System.Drawing.Color.DarkGray;
            this.TxTBox_Nome.HintText = "Fulaninho de Tal da Silva Pereira";
            this.TxTBox_Nome.isPassword = false;
            this.TxTBox_Nome.LineFocusedColor = System.Drawing.Color.DarkGray;
            this.TxTBox_Nome.LineIdleColor = System.Drawing.Color.Gray;
            this.TxTBox_Nome.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.TxTBox_Nome.LineThickness = 3;
            this.TxTBox_Nome.Location = new System.Drawing.Point(36, 154);
            this.TxTBox_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.TxTBox_Nome.MaxLength = 70;
            this.TxTBox_Nome.Name = "TxTBox_Nome";
            this.TxTBox_Nome.Size = new System.Drawing.Size(379, 33);
            this.TxTBox_Nome.TabIndex = 1;
            this.TxTBox_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxTBox_Nome.OnValueChanged += new System.EventHandler(this.TxTBox_Nome_OnValueChanged);
            // 
            // Label_Registro
            // 
            this.Label_Registro.AutoEllipsis = false;
            this.Label_Registro.CursorType = null;
            this.Label_Registro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Registro.Location = new System.Drawing.Point(166, 40);
            this.Label_Registro.Name = "Label_Registro";
            this.Label_Registro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Registro.Size = new System.Drawing.Size(128, 42);
            this.Label_Registro.TabIndex = 8;
            this.Label_Registro.Text = "Registro";
            this.Label_Registro.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Label_Registro.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Active = false;
            this.Exit_Btn.Activecolor = System.Drawing.Color.Gray;
            this.Exit_Btn.BackColor = System.Drawing.Color.Silver;
            this.Exit_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_Btn.BorderRadius = 0;
            this.Exit_Btn.ButtonText = "x";
            this.Exit_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.Exit_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit_Btn.Iconimage = null;
            this.Exit_Btn.Iconimage_right = null;
            this.Exit_Btn.Iconimage_right_Selected = null;
            this.Exit_Btn.Iconimage_Selected = null;
            this.Exit_Btn.IconMarginLeft = 0;
            this.Exit_Btn.IconMarginRight = 0;
            this.Exit_Btn.IconRightVisible = true;
            this.Exit_Btn.IconRightZoom = 0D;
            this.Exit_Btn.IconVisible = true;
            this.Exit_Btn.IconZoom = 90D;
            this.Exit_Btn.IsTab = false;
            this.Exit_Btn.Location = new System.Drawing.Point(405, 1);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Normalcolor = System.Drawing.Color.Silver;
            this.Exit_Btn.OnHovercolor = System.Drawing.Color.DimGray;
            this.Exit_Btn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Exit_Btn.selected = false;
            this.Exit_Btn.Size = new System.Drawing.Size(38, 25);
            this.Exit_Btn.TabIndex = 1000;
            this.Exit_Btn.Text = "x";
            this.Exit_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_Btn.Textcolor = System.Drawing.Color.White;
            this.Exit_Btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Cadastrar_Btn
            // 
            this.Cadastrar_Btn.Active = false;
            this.Cadastrar_Btn.Activecolor = System.Drawing.Color.Gray;
            this.Cadastrar_Btn.BackColor = System.Drawing.Color.Silver;
            this.Cadastrar_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cadastrar_Btn.BorderRadius = 0;
            this.Cadastrar_Btn.ButtonText = "Cadastrar";
            this.Cadastrar_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cadastrar_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.Cadastrar_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Cadastrar_Btn.Iconimage = null;
            this.Cadastrar_Btn.Iconimage_right = null;
            this.Cadastrar_Btn.Iconimage_right_Selected = null;
            this.Cadastrar_Btn.Iconimage_Selected = null;
            this.Cadastrar_Btn.IconMarginLeft = 0;
            this.Cadastrar_Btn.IconMarginRight = 0;
            this.Cadastrar_Btn.IconRightVisible = true;
            this.Cadastrar_Btn.IconRightZoom = 0D;
            this.Cadastrar_Btn.IconVisible = true;
            this.Cadastrar_Btn.IconZoom = 90D;
            this.Cadastrar_Btn.IsTab = false;
            this.Cadastrar_Btn.Location = new System.Drawing.Point(288, 426);
            this.Cadastrar_Btn.Name = "Cadastrar_Btn";
            this.Cadastrar_Btn.Normalcolor = System.Drawing.Color.Silver;
            this.Cadastrar_Btn.OnHovercolor = System.Drawing.Color.DimGray;
            this.Cadastrar_Btn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Cadastrar_Btn.selected = false;
            this.Cadastrar_Btn.Size = new System.Drawing.Size(117, 35);
            this.Cadastrar_Btn.TabIndex = 4;
            this.Cadastrar_Btn.Text = "Cadastrar";
            this.Cadastrar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cadastrar_Btn.Textcolor = System.Drawing.Color.White;
            this.Cadastrar_Btn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar_Btn.Click += new System.EventHandler(this.Cadastrar_Btn_Click);
            // 
            // Limpar_Btn
            // 
            this.Limpar_Btn.Active = false;
            this.Limpar_Btn.Activecolor = System.Drawing.Color.Gray;
            this.Limpar_Btn.BackColor = System.Drawing.Color.Silver;
            this.Limpar_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Limpar_Btn.BorderRadius = 0;
            this.Limpar_Btn.ButtonText = "Limpar";
            this.Limpar_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpar_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.Limpar_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Limpar_Btn.Iconimage = null;
            this.Limpar_Btn.Iconimage_right = null;
            this.Limpar_Btn.Iconimage_right_Selected = null;
            this.Limpar_Btn.Iconimage_Selected = null;
            this.Limpar_Btn.IconMarginLeft = 0;
            this.Limpar_Btn.IconMarginRight = 0;
            this.Limpar_Btn.IconRightVisible = true;
            this.Limpar_Btn.IconRightZoom = 0D;
            this.Limpar_Btn.IconVisible = true;
            this.Limpar_Btn.IconZoom = 90D;
            this.Limpar_Btn.IsTab = false;
            this.Limpar_Btn.Location = new System.Drawing.Point(36, 426);
            this.Limpar_Btn.Name = "Limpar_Btn";
            this.Limpar_Btn.Normalcolor = System.Drawing.Color.Silver;
            this.Limpar_Btn.OnHovercolor = System.Drawing.Color.DimGray;
            this.Limpar_Btn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Limpar_Btn.selected = false;
            this.Limpar_Btn.Size = new System.Drawing.Size(117, 35);
            this.Limpar_Btn.TabIndex = 5;
            this.Limpar_Btn.Text = "Limpar";
            this.Limpar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Limpar_Btn.Textcolor = System.Drawing.Color.White;
            this.Limpar_Btn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar_Btn.Click += new System.EventHandler(this.Limpar_Btn_Click);
            // 
            // Register_Drag
            // 
            this.Register_Drag.Fixed = true;
            this.Register_Drag.Horizontal = true;
            this.Register_Drag.TargetControl = this;
            this.Register_Drag.Vertical = true;
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.ElipseRadius = 3;
            this.Form_Elipse.TargetControl = this;
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_Error.Location = new System.Drawing.Point(77, 85);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(328, 21);
            this.Label_Error.TabIndex = 1001;
            this.Label_Error.Text = "Todos os Campos devem ser Preenchidos";
            this.Label_Error.Visible = false;
            // 
            // TestaConexao_btn
            // 
            this.TestaConexao_btn.Active = false;
            this.TestaConexao_btn.Activecolor = System.Drawing.Color.Gray;
            this.TestaConexao_btn.BackColor = System.Drawing.Color.Silver;
            this.TestaConexao_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TestaConexao_btn.BorderRadius = 0;
            this.TestaConexao_btn.ButtonText = "Conexão";
            this.TestaConexao_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestaConexao_btn.DisabledColor = System.Drawing.Color.Gray;
            this.TestaConexao_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.TestaConexao_btn.Iconimage = null;
            this.TestaConexao_btn.Iconimage_right = null;
            this.TestaConexao_btn.Iconimage_right_Selected = null;
            this.TestaConexao_btn.Iconimage_Selected = null;
            this.TestaConexao_btn.IconMarginLeft = 0;
            this.TestaConexao_btn.IconMarginRight = 0;
            this.TestaConexao_btn.IconRightVisible = true;
            this.TestaConexao_btn.IconRightZoom = 0D;
            this.TestaConexao_btn.IconVisible = true;
            this.TestaConexao_btn.IconZoom = 90D;
            this.TestaConexao_btn.IsTab = false;
            this.TestaConexao_btn.Location = new System.Drawing.Point(161, 426);
            this.TestaConexao_btn.Name = "TestaConexao_btn";
            this.TestaConexao_btn.Normalcolor = System.Drawing.Color.Silver;
            this.TestaConexao_btn.OnHovercolor = System.Drawing.Color.DimGray;
            this.TestaConexao_btn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.TestaConexao_btn.selected = false;
            this.TestaConexao_btn.Size = new System.Drawing.Size(117, 35);
            this.TestaConexao_btn.TabIndex = 1002;
            this.TestaConexao_btn.Text = "Conexão";
            this.TestaConexao_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TestaConexao_btn.Textcolor = System.Drawing.Color.White;
            this.TestaConexao_btn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestaConexao_btn.Click += new System.EventHandler(this.TestaConexao_btn_Click);
            // 
            // Label_UsuarioCadastrado
            // 
            this.Label_UsuarioCadastrado.AutoSize = true;
            this.Label_UsuarioCadastrado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UsuarioCadastrado.ForeColor = System.Drawing.Color.Green;
            this.Label_UsuarioCadastrado.Location = new System.Drawing.Point(134, 85);
            this.Label_UsuarioCadastrado.Name = "Label_UsuarioCadastrado";
            this.Label_UsuarioCadastrado.Size = new System.Drawing.Size(195, 23);
            this.Label_UsuarioCadastrado.TabIndex = 1003;
            this.Label_UsuarioCadastrado.Text = "Usuário Cadastrado";
            this.Label_UsuarioCadastrado.Visible = false;
            // 
            // Registro_Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(443, 500);
            this.Controls.Add(this.Label_UsuarioCadastrado);
            this.Controls.Add(this.TestaConexao_btn);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.Limpar_Btn);
            this.Controls.Add(this.Cadastrar_Btn);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.Label_Registro);
            this.Controls.Add(this.TxTBox_Nome);
            this.Controls.Add(this.TxTBox_CPF);
            this.Controls.Add(this.Label_Endereço);
            this.Controls.Add(this.Label_CPF);
            this.Controls.Add(this.Label_Nome);
            this.Controls.Add(this.TxTBox_Enderço);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Tela";
            this.Text = "Registro Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxTBox_Enderço;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Nome;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_CPF;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Endereço;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxTBox_CPF;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxTBox_Nome;
        private Bunifu.UI.WinForms.BunifuLabel Label_Registro;
        private Bunifu.Framework.UI.BunifuFlatButton Exit_Btn;
        private Bunifu.Framework.UI.BunifuFlatButton Cadastrar_Btn;
        private Bunifu.Framework.UI.BunifuFlatButton Limpar_Btn;
        private Bunifu.Framework.UI.BunifuDragControl Register_Drag;
        private Bunifu.Framework.UI.BunifuElipse Form_Elipse;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_Error;
        private Bunifu.Framework.UI.BunifuFlatButton TestaConexao_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_UsuarioCadastrado;
    }
}

