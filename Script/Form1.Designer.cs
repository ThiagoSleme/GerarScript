namespace Script
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.scriptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siglaTextBox = new System.Windows.Forms.TextBox();
            this.storeIdTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.exibeListBox = new System.Windows.Forms.ListBox();
            this.criarServiceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 286);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // scriptButton
            // 
            this.scriptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptButton.Location = new System.Drawing.Point(9, 12);
            this.scriptButton.Name = "scriptButton";
            this.scriptButton.Size = new System.Drawing.Size(90, 39);
            this.scriptButton.TabIndex = 1;
            this.scriptButton.Tag = "";
            this.scriptButton.Text = "&Rodar Script";
            this.scriptButton.UseVisualStyleBackColor = true;
            this.scriptButton.Click += new System.EventHandler(this.scriptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Sigla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&StoreId";
            // 
            // siglaTextBox
            // 
            this.siglaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.siglaTextBox.Location = new System.Drawing.Point(9, 82);
            this.siglaTextBox.Name = "siglaTextBox";
            this.siglaTextBox.Size = new System.Drawing.Size(100, 20);
            this.siglaTextBox.TabIndex = 2;
            this.siglaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // storeIdTextBox
            // 
            this.storeIdTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.storeIdTextBox.Location = new System.Drawing.Point(138, 82);
            this.storeIdTextBox.Name = "storeIdTextBox";
            this.storeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.storeIdTextBox.TabIndex = 3;
            this.storeIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.estadoTextBox.Location = new System.Drawing.Point(9, 133);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 4;
            this.estadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // exibeListBox
            // 
            this.exibeListBox.FormattingEnabled = true;
            this.exibeListBox.Location = new System.Drawing.Point(9, 179);
            this.exibeListBox.Name = "exibeListBox";
            this.exibeListBox.Size = new System.Drawing.Size(417, 95);
            this.exibeListBox.TabIndex = 5;
            // 
            // criarServiceButton
            // 
            this.criarServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarServiceButton.Location = new System.Drawing.Point(105, 12);
            this.criarServiceButton.Name = "criarServiceButton";
            this.criarServiceButton.Size = new System.Drawing.Size(90, 39);
            this.criarServiceButton.TabIndex = 6;
            this.criarServiceButton.Tag = "";
            this.criarServiceButton.Text = "&Criar serviço";
            this.criarServiceButton.UseVisualStyleBackColor = true;
            this.criarServiceButton.Click += new System.EventHandler(this.criarServiceButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(201, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Gerar script";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.criarServiceButton);
            this.Controls.Add(this.exibeListBox);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.storeIdTextBox);
            this.Controls.Add(this.siglaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scriptButton);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button scriptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox siglaTextBox;
        private System.Windows.Forms.TextBox storeIdTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox exibeListBox;
        private System.Windows.Forms.Button criarServiceButton;
        private System.Windows.Forms.Button button1;
    }
}

