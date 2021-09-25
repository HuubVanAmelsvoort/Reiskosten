using System;

namespace RieskostenFormsCSharpvoorbeeld {
  class HuubsMaatwerk {
    private FormVoorPaulReiskosten formulier;

    public HuubsMaatwerk(FormVoorPaulReiskosten formulier) {
      this.formulier = formulier;
    }

    internal void bereken(FormVoorPaulReiskosten formVoorPaulReiskosten) {
      decimal kilometer = decimal.Parse(formulier.textBoxKilometer.Text);
      decimal benzineprijs = decimal.Parse(formulier.textBoxbenzineprijs.Text);
      decimal gemiddelde = Math.Round(decimal.Parse(formulier.textBoxGemiddelde.Text), 2);


      decimal kosten = kilometer / gemiddelde * benzineprijs;
      decimal uitkomst = Math.Round(kosten / kilometer, 2);

      String deTekst = String.Format("Ok, je rit van {0} kilometer kostte {1:C2} (afgerond op 2 decimalen).\n De kosten per kilometer waren {2:C2}."
              , kilometer, kosten, uitkomst);

      formulier.textBoxUitkomst.Text = deTekst;
      formulier.label6.Text = "Ha die Paul";
    }
  }
}
