using System.Windows.Forms;

namespace KiraKeyPresser
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AuxAtkKeyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MacroKey2TextBox = new System.Windows.Forms.TextBox();
            this.MacroKey1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HotKey2TextBox = new System.Windows.Forms.TextBox();
            this.HotKey1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConfirmButton.Location = new System.Drawing.Point(79, 149);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(88, 27);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "Confirmar";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ataque Auxiliar Key";
            // 
            // AuxAtkKeyTextBox
            // 
            this.AuxAtkKeyTextBox.Location = new System.Drawing.Point(133, 6);
            this.AuxAtkKeyTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AuxAtkKeyTextBox.Name = "AuxAtkKeyTextBox";
            this.AuxAtkKeyTextBox.ReadOnly = true;
            this.AuxAtkKeyTextBox.Size = new System.Drawing.Size(105, 23);
            this.AuxAtkKeyTextBox.TabIndex = 6;
            this.AuxAtkKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewHotKeyTextBox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MacroKey2TextBox);
            this.groupBox1.Controls.Add(this.MacroKey1TextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Macrokeys";
            // 
            // MacroKey2TextBox
            // 
            this.MacroKey2TextBox.Location = new System.Drawing.Point(7, 51);
            this.MacroKey2TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MacroKey2TextBox.Name = "MacroKey2TextBox";
            this.MacroKey2TextBox.ReadOnly = true;
            this.MacroKey2TextBox.Size = new System.Drawing.Size(95, 23);
            this.MacroKey2TextBox.TabIndex = 14;
            this.MacroKey2TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewHotKeyTextBox_KeyDown);
            // 
            // MacroKey1TextBox
            // 
            this.MacroKey1TextBox.Location = new System.Drawing.Point(7, 22);
            this.MacroKey1TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MacroKey1TextBox.Name = "MacroKey1TextBox";
            this.MacroKey1TextBox.ReadOnly = true;
            this.MacroKey1TextBox.Size = new System.Drawing.Size(95, 23);
            this.MacroKey1TextBox.TabIndex = 12;
            this.MacroKey1TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewHotKeyTextBox_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HotKey2TextBox);
            this.groupBox2.Controls.Add(this.HotKey1TextBox);
            this.groupBox2.Location = new System.Drawing.Point(129, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hotkeys";
            // 
            // HotKey2TextBox
            // 
            this.HotKey2TextBox.Location = new System.Drawing.Point(7, 51);
            this.HotKey2TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HotKey2TextBox.Name = "HotKey2TextBox";
            this.HotKey2TextBox.ReadOnly = true;
            this.HotKey2TextBox.Size = new System.Drawing.Size(95, 23);
            this.HotKey2TextBox.TabIndex = 4;
            this.HotKey2TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewHotKeyTextBox_KeyDown);
            // 
            // HotKey1TextBox
            // 
            this.HotKey1TextBox.Location = new System.Drawing.Point(7, 22);
            this.HotKey1TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HotKey1TextBox.Name = "HotKey1TextBox";
            this.HotKey1TextBox.ReadOnly = true;
            this.HotKey1TextBox.Size = new System.Drawing.Size(95, 23);
            this.HotKey1TextBox.TabIndex = 3;
            this.HotKey1TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewHotKeyTextBox_KeyDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 188);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuxAtkKeyTextBox);
            this.Controls.Add(this.ConfirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "KiraKeyPresser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ConfirmButton;
        private Label label1;
        private TextBox AuxAtkKeyTextBox;
        private GroupBox groupBox1;
        private TextBox MacroKey2TextBox;
        private TextBox MacroKey1TextBox;
        private GroupBox groupBox2;
        private TextBox HotKey2TextBox;
        private TextBox HotKey1TextBox;
    }
}

