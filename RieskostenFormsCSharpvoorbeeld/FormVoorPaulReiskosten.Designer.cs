namespace RieskostenFormsCSharpvoorbeeld {
  partial class FormVoorPaulReiskosten {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVoorPaulReiskosten));
      this.buttonBerekenen = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxKilometer = new System.Windows.Forms.TextBox();
      this.textBoxbenzineprijs = new System.Windows.Forms.TextBox();
      this.textBoxGemiddelde = new System.Windows.Forms.TextBox();
      this.buttonAfsluiten = new System.Windows.Forms.Button();
      this.textBoxUitkomst = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttonBerekenen
      // 
      this.buttonBerekenen.Location = new System.Drawing.Point(312, 116);
      this.buttonBerekenen.Name = "buttonBerekenen";
      this.buttonBerekenen.Size = new System.Drawing.Size(75, 23);
      this.buttonBerekenen.TabIndex = 0;
      this.buttonBerekenen.Text = "Berekenen";
      this.buttonBerekenen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonBerekenen.UseVisualStyleBackColor = true;
      this.buttonBerekenen.Click += new System.EventHandler(this.buttonBerekenen_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(101, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(178, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Hoeveel kilometer heb je gereden? :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(50, 59);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(231, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Wat is op dit moment de benzineprijs per liter?  :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 93);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(267, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Hoeveel kilometer per liter brandstof verbruikt je auto? :";
      // 
      // textBoxKilometer
      // 
      this.textBoxKilometer.Location = new System.Drawing.Point(287, 33);
      this.textBoxKilometer.Name = "textBoxKilometer";
      this.textBoxKilometer.Size = new System.Drawing.Size(100, 20);
      this.textBoxKilometer.TabIndex = 4;
      this.textBoxKilometer.Text = "20";
      // 
      // textBoxbenzineprijs
      // 
      this.textBoxbenzineprijs.Location = new System.Drawing.Point(287, 59);
      this.textBoxbenzineprijs.Name = "textBoxbenzineprijs";
      this.textBoxbenzineprijs.Size = new System.Drawing.Size(100, 20);
      this.textBoxbenzineprijs.TabIndex = 5;
      this.textBoxbenzineprijs.Text = "1,75";
      // 
      // textBoxGemiddelde
      // 
      this.textBoxGemiddelde.Location = new System.Drawing.Point(285, 90);
      this.textBoxGemiddelde.Name = "textBoxGemiddelde";
      this.textBoxGemiddelde.Size = new System.Drawing.Size(100, 20);
      this.textBoxGemiddelde.TabIndex = 6;
      this.textBoxGemiddelde.Text = "14";
      // 
      // buttonAfsluiten
      // 
      this.buttonAfsluiten.Location = new System.Drawing.Point(15, 202);
      this.buttonAfsluiten.Name = "buttonAfsluiten";
      this.buttonAfsluiten.Size = new System.Drawing.Size(75, 23);
      this.buttonAfsluiten.TabIndex = 7;
      this.buttonAfsluiten.Text = "Afsluiten";
      this.buttonAfsluiten.UseVisualStyleBackColor = true;
      this.buttonAfsluiten.Click += new System.EventHandler(this.buttonAfsluiten_Click);
      // 
      // textBoxUitkomst
      // 
      this.textBoxUitkomst.Location = new System.Drawing.Point(15, 145);
      this.textBoxUitkomst.Multiline = true;
      this.textBoxUitkomst.Name = "textBoxUitkomst";
      this.textBoxUitkomst.ReadOnly = true;
      this.textBoxUitkomst.Size = new System.Drawing.Size(372, 51);
      this.textBoxUitkomst.TabIndex = 9;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(463, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Gebruik een punt/komma voor cijfers achter de komma afhankelijk van uw regionale " +
    "instellingen.";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(391, 93);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(421, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "( Het gemiddelde is 14 kilometer per liter voor een personenauto. Typ in dat geva" +
    "l 14 in )";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(514, 167);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(35, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "label6";
      this.label6.Click += new System.EventHandler(this.label6_Click);
      // 
      // FormVoorPaulReiskosten
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(822, 246);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxUitkomst);
      this.Controls.Add(this.buttonAfsluiten);
      this.Controls.Add(this.textBoxGemiddelde);
      this.Controls.Add(this.textBoxbenzineprijs);
      this.Controls.Add(this.textBoxKilometer);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonBerekenen);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormVoorPaulReiskosten";
      this.Text = "Reiskosten berekenen";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonBerekenen;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button buttonAfsluiten;
    public System.Windows.Forms.TextBox textBoxKilometer;
    public System.Windows.Forms.TextBox textBoxbenzineprijs;
    public System.Windows.Forms.TextBox textBoxGemiddelde;
    public System.Windows.Forms.TextBox textBoxUitkomst;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    public System.Windows.Forms.Label label6;
  }
}

