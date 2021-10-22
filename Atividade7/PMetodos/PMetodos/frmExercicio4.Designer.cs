
namespace PMetodos
{
    partial class frmExercicio4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnnumero = new System.Windows.Forms.Button();
            this.btnEspaco = new System.Windows.Forms.Button();
            this.btnCaracteres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(134, 46);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(512, 158);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnnumero
            // 
            this.btnnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnumero.Location = new System.Drawing.Point(111, 293);
            this.btnnumero.Name = "btnnumero";
            this.btnnumero.Size = new System.Drawing.Size(145, 71);
            this.btnnumero.TabIndex = 1;
            this.btnnumero.Text = "Quantidade de caracteres Numericos";
            this.btnnumero.UseVisualStyleBackColor = true;
            this.btnnumero.Click += new System.EventHandler(this.btnnumero_Click);
            // 
            // btnEspaco
            // 
            this.btnEspaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspaco.Location = new System.Drawing.Point(313, 293);
            this.btnEspaco.Name = "btnEspaco";
            this.btnEspaco.Size = new System.Drawing.Size(145, 71);
            this.btnEspaco.TabIndex = 2;
            this.btnEspaco.Text = "Primeiro branco";
            this.btnEspaco.UseVisualStyleBackColor = true;
            this.btnEspaco.Click += new System.EventHandler(this.btnEspaco_Click);
            // 
            // btnCaracteres
            // 
            this.btnCaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaracteres.Location = new System.Drawing.Point(527, 293);
            this.btnCaracteres.Name = "btnCaracteres";
            this.btnCaracteres.Size = new System.Drawing.Size(145, 71);
            this.btnCaracteres.TabIndex = 3;
            this.btnCaracteres.Text = "Quantidades de caracteres alfabeticos";
            this.btnCaracteres.UseVisualStyleBackColor = true;
            this.btnCaracteres.Click += new System.EventHandler(this.btnCaracteres_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCaracteres);
            this.Controls.Add(this.btnEspaco);
            this.Controls.Add(this.btnnumero);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnnumero;
        private System.Windows.Forms.Button btnEspaco;
        private System.Windows.Forms.Button btnCaracteres;
    }
}