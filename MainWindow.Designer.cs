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
            this.HotKeyTextBox = new System.Windows.Forms.TextBox();
            this.HotKeyLabel = new System.Windows.Forms.Label();
            this.MacroKey1Label = new System.Windows.Forms.Label();
            this.MacroKey1TextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AuxAtkKeyTextBox = new System.Windows.Forms.TextBox();
            this.MacroKey2Label = new System.Windows.Forms.Label();
            this.MacroKey2TextBox = new System.Windows.Forms.TextBox();
            this.MacroDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MacroDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // HotKeyTextBox
            // 
            this.HotKeyTextBox.Location = new System.Drawing.Point(134, 21);
            this.HotKeyTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HotKeyTextBox.Name = "HotKeyTextBox";
            this.HotKeyTextBox.ReadOnly = true;
            this.HotKeyTextBox.Size = new System.Drawing.Size(126, 23);
            this.HotKeyTextBox.TabIndex = 1;
            this.HotKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewHotKeyTextBox_KeyDown);
            // 
            // HotKeyLabel
            // 
            this.HotKeyLabel.AutoSize = true;
            this.HotKeyLabel.Location = new System.Drawing.Point(14, 24);
            this.HotKeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotKeyLabel.Name = "HotKeyLabel";
            this.HotKeyLabel.Size = new System.Drawing.Size(46, 15);
            this.HotKeyLabel.TabIndex = 2;
            this.HotKeyLabel.Text = "HotKey";
            // 
            // MacroKey1Label
            // 
            this.MacroKey1Label.AutoSize = true;
            this.MacroKey1Label.Location = new System.Drawing.Point(13, 82);
            this.MacroKey1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MacroKey1Label.Name = "MacroKey1Label";
            this.MacroKey1Label.Size = new System.Drawing.Size(72, 15);
            this.MacroKey1Label.TabIndex = 4;
            this.MacroKey1Label.Text = "Macro Key 1";
            // 
            // MacroKey1TextBox
            // 
            this.MacroKey1TextBox.Location = new System.Drawing.Point(133, 79);
            this.MacroKey1TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MacroKey1TextBox.Name = "MacroKey1TextBox";
            this.MacroKey1TextBox.ReadOnly = true;
            this.MacroKey1TextBox.Size = new System.Drawing.Size(127, 23);
            this.MacroKey1TextBox.TabIndex = 3;
            this.MacroKey1TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewHotKeyTextBox_KeyDown);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConfirmButton.Location = new System.Drawing.Point(91, 179);
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
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ataque Auxiliar Key";
            // 
            // AuxAtkKeyTextBox
            // 
            this.AuxAtkKeyTextBox.Location = new System.Drawing.Point(133, 50);
            this.AuxAtkKeyTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AuxAtkKeyTextBox.Name = "AuxAtkKeyTextBox";
            this.AuxAtkKeyTextBox.ReadOnly = true;
            this.AuxAtkKeyTextBox.Size = new System.Drawing.Size(127, 23);
            this.AuxAtkKeyTextBox.TabIndex = 6;
            this.AuxAtkKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewHotKeyTextBox_KeyDown);
            // 
            // MacroKey2Label
            // 
            this.MacroKey2Label.AutoSize = true;
            this.MacroKey2Label.Location = new System.Drawing.Point(13, 111);
            this.MacroKey2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MacroKey2Label.Name = "MacroKey2Label";
            this.MacroKey2Label.Size = new System.Drawing.Size(72, 15);
            this.MacroKey2Label.TabIndex = 9;
            this.MacroKey2Label.Text = "Macro Key 2";
            // 
            // MacroKey2TextBox
            // 
            this.MacroKey2TextBox.Location = new System.Drawing.Point(133, 108);
            this.MacroKey2TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MacroKey2TextBox.Name = "MacroKey2TextBox";
            this.MacroKey2TextBox.ReadOnly = true;
            this.MacroKey2TextBox.Size = new System.Drawing.Size(126, 23);
            this.MacroKey2TextBox.TabIndex = 8;
            this.MacroKey2TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewHotKeyTextBox_KeyDown);
            // 
            // MacroDelay
            // 
            this.MacroDelay.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MacroDelay.Location = new System.Drawing.Point(134, 137);
            this.MacroDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MacroDelay.Name = "MacroDelay";
            this.MacroDelay.Size = new System.Drawing.Size(125, 23);
            this.MacroDelay.TabIndex = 10;
            this.MacroDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Delay entre macros";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MacroDelay);
            this.Controls.Add(this.MacroKey2Label);
            this.Controls.Add(this.MacroKey2TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuxAtkKeyTextBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.MacroKey1Label);
            this.Controls.Add(this.MacroKey1TextBox);
            this.Controls.Add(this.HotKeyLabel);
            this.Controls.Add(this.HotKeyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "KiraKeyPresser";
            ((System.ComponentModel.ISupportInitialize)(this.MacroDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox HotKeyTextBox;
        private Label HotKeyLabel;
        private Label MacroKey1Label;
        private TextBox MacroKey1TextBox;
        private Button ConfirmButton;
        private Label label1;
        private TextBox AuxAtkKeyTextBox;
        private Label MacroKey2Label;
        private TextBox MacroKey2TextBox;
        private NumericUpDown MacroDelay;
        private Label label2;
    }
}

