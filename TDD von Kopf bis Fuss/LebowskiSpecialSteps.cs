﻿using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TDD_von_Kopf_bis_Fuss
{
    [Binding]
    public class LebowskiSpecialSteps
    {
        [Given(@"ein Spieler wirft folgende Würfe")]
        public void AngenommenEinSpielerWirftFolgendeWurfe(Table table)
        {
            var programm = new LebowskiSpecial();
            ScenarioContext.Current.Set(programm);
            var game = table.CreateSet<WurfInBindings>();
            var max = game.Max(f => f.Nummer);
            for(int index = 1; index <= max; index += 2)
            {
                var frame = new Frame();
                frame.Roll1 = game.First(f => f.Nummer == index).Punkte;
                frame.Roll2 = game.First(f => f.Nummer == index+1).Punkte;
                programm.Add(frame);
            }
        }
        
        [When(@"das Programm die Ausgabe berechnet")]
        public void WennDasProgrammDieAusgabeBerechnet()
        {
            var programm = ScenarioContext.Current.Get<LebowskiSpecial>();
            programm.CalculateGame();
        }
        
        [Then(@"soll folgendes Ergebnis herauskommen")]
        public void DannSollFolgendesErgebnisHerauskommen(Table table)
        {
            var programm = ScenarioContext.Current.Get<LebowskiSpecial>();
            List<byte> result = programm.GetLatestResult();
            var expectedPoints = table.CreateSet<FrameInBinding>();
            var max = expectedPoints.Max(f => f.Frame);
            for (int index = 0; index <= max; index++)
            {
                var expected = expectedPoints.First(f => f.Frame == index+1);
                result[index].Should().Be(expected.Punkte);
            }
        }
    }
}