using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace TDD_von_Kopf_bis_Fuss
{
    [Binding]
    public class LebowskiSpecialSteps
    {
        [Given(@"ein Spieler wirft folgende Würfe")]
        public void AngenommenEinSpielerWirftFolgendeWurfe(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"das Programm die Ausgabe berechnet")]
        public void WennDasProgrammDieAusgabeBerechnet()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"soll folgendes Ergebnis herauskommen")]
        public void DannSollFolgendesErgebnisHerauskommen(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
