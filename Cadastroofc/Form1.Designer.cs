namespace Cadastroofc
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
            Usuário = new Label();
            txtusuario = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Usuário
            // 
            Usuário.AutoSize = true;
            Usuário.Location = new Point(175, 84);
            Usuário.Name = "Usuário";
            Usuário.Size = new Size(38, 15);
            Usuário.TabIndex = 0;
            Usuário.Text = "label1";
            Usuário.Click += label1_Click;
            // 
            // txtusuario
            // 
            txtusuario.BackColor = SystemColors.Info;
            txtusuario.Location = new Point(241, 76);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(309, 23);
            txtusuario.TabIndex = 1;
            txtusuario.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(229, 139);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(309, 199);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(556, 76);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 3;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(556, 128);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 4;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(556, 169);
            button3.Name = "button3";
            button3.Size = new Size(87, 24);
            button3.TabIndex = 5;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(txtusuario);
            Controls.Add(Usuário);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Usuário;
        private TextBox txtusuario;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
