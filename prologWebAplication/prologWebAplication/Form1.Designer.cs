namespace prologWebAplication
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
      this.btnResolver = new System.Windows.Forms.Button();
      this.btnEnvio = new System.Windows.Forms.Button();
      this.cbRespuestas = new System.Windows.Forms.ComboBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnDel = new System.Windows.Forms.Button();
      this.lblPregunta = new System.Windows.Forms.Label();
      this.lbrespuestasEnvio = new System.Windows.Forms.ListBox();
      this.lbRespuestasProlog = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnResolver
      // 
      this.btnResolver.Location = new System.Drawing.Point(9, 307);
      this.btnResolver.Name = "btnResolver";
      this.btnResolver.Size = new System.Drawing.Size(75, 23);
      this.btnResolver.TabIndex = 0;
      this.btnResolver.Text = "resolver";
      this.btnResolver.UseVisualStyleBackColor = true;
      this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
      // 
      // btnEnvio
      // 
      this.btnEnvio.Location = new System.Drawing.Point(163, 307);
      this.btnEnvio.Name = "btnEnvio";
      this.btnEnvio.Size = new System.Drawing.Size(114, 23);
      this.btnEnvio.TabIndex = 1;
      this.btnEnvio.Text = "enviar respuesta";
      this.btnEnvio.UseVisualStyleBackColor = true;
      // 
      // cbRespuestas
      // 
      this.cbRespuestas.FormattingEnabled = true;
      this.cbRespuestas.Location = new System.Drawing.Point(9, 143);
      this.cbRespuestas.Name = "cbRespuestas";
      this.cbRespuestas.Size = new System.Drawing.Size(198, 21);
      this.cbRespuestas.TabIndex = 2;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(183, 170);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(24, 23);
      this.btnAdd.TabIndex = 3;
      this.btnAdd.Text = "<-";
      this.btnAdd.UseVisualStyleBackColor = true;
      // 
      // btnDel
      // 
      this.btnDel.Location = new System.Drawing.Point(183, 199);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new System.Drawing.Size(24, 23);
      this.btnDel.TabIndex = 4;
      this.btnDel.Text = "->";
      this.btnDel.UseVisualStyleBackColor = true;
      // 
      // lblPregunta
      // 
      this.lblPregunta.AutoSize = true;
      this.lblPregunta.Location = new System.Drawing.Point(12, 167);
      this.lblPregunta.Name = "lblPregunta";
      this.lblPregunta.Size = new System.Drawing.Size(0, 13);
      this.lblPregunta.TabIndex = 5;
      // 
      // lbrespuestasEnvio
      // 
      this.lbrespuestasEnvio.FormattingEnabled = true;
      this.lbrespuestasEnvio.Location = new System.Drawing.Point(9, 167);
      this.lbrespuestasEnvio.Name = "lbrespuestasEnvio";
      this.lbrespuestasEnvio.Size = new System.Drawing.Size(168, 134);
      this.lbrespuestasEnvio.TabIndex = 6;
      // 
      // lbRespuestasProlog
      // 
      this.lbRespuestasProlog.FormattingEnabled = true;
      this.lbRespuestasProlog.Location = new System.Drawing.Point(213, 167);
      this.lbRespuestasProlog.Name = "lbRespuestasProlog";
      this.lbRespuestasProlog.Size = new System.Drawing.Size(64, 134);
      this.lbRespuestasProlog.TabIndex = 7;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(352, 337);
      this.Controls.Add(this.lbRespuestasProlog);
      this.Controls.Add(this.lbrespuestasEnvio);
      this.Controls.Add(this.lblPregunta);
      this.Controls.Add(this.btnDel);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.cbRespuestas);
      this.Controls.Add(this.btnEnvio);
      this.Controls.Add(this.btnResolver);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnResolver;
    private System.Windows.Forms.Button btnEnvio;
    private System.Windows.Forms.ComboBox cbRespuestas;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDel;
    private System.Windows.Forms.Label lblPregunta;
    private System.Windows.Forms.ListBox lbrespuestasEnvio;
    private System.Windows.Forms.ListBox lbRespuestasProlog;
  }
}

