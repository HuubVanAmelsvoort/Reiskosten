using System;
using System.Windows.Forms;

namespace RieskostenFormsCSharpvoorbeeld {
  public partial class FormVoorPaulReiskosten : Form {
    HuubsMaatwerk huubsMaatwerk;
    String tekst = "Hoi";
    int geheelgetal = 1;
    decimal decimaaltest ;

    public FormVoorPaulReiskosten() {
      InitializeComponent();
      huubsMaatwerk = new HuubsMaatwerk(this);
    }

    private void Form1_Load(object sender, EventArgs e) {
    }

    private void buttonAfsluiten_Click(object sender, EventArgs e) {
      Application.Exit();

    }

    private void buttonBerekenen_Click(object sender, EventArgs e) {
      huubsMaatwerk.bereken(this);
    }

    private void label6_Click(object sender, EventArgs e) {

    }
  }
}
