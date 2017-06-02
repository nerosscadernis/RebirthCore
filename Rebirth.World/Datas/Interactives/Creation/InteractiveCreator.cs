using Rebirth.World.Datas.Interactives.Types;
using Rebirth.World.Datas.Interactives.Types.Classic;
using Rebirth.World.Datas.Maps;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Creation
{
    public class InteractiveCreator
    {
        #region Zaaps
        [Interactive("34681")]
        private void HandleZaapPorteAstrub(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("38003")]
        private void HandleZaapAstrub(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("37410")]
        private void HandleZaapSufokia(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("15362")]
        private void HandleZaapChateauAmakna(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("15363")]
        private void HandleZaapKrakleur(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("21830")]
        private void HandleZaapFrigost(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("16971")]
        private void HandleZaapPandala(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("19804")]
        private void HandleZaapCanope(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("17268")]
        private void HandleZaapBonta(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("16982")]
        private void HandleZaapBrakmar(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("24193")]
        private void HandleZaapKoalak(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("30091")]
        private void HandleZaapMasterdam(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("39045")]
        private void HandleZaapWabbit(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        [Interactive("41724")]
        private void HandleZaapAlliance(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaap(identifier, cellid));
        }
        #endregion

        #region Zaapis
        [Interactive("9541")]
        private void HandleZaapiBonta(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            var interactive = new InteractiveZaapi(identifier, cellid, subArea, map.Id, onMap);
            map.AddInteractive(interactive);
            if (!onMap)
                MapManager.Instance.AddZaapi(interactive as InteractiveZaapi);
        }
        [Interactive("15004")]
        private void HandleZaapiBrak(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveZaapi(identifier, cellid, subArea, map.Id, onMap));
        }
        #endregion
        
        #region Couture
        [Interactive("9797")]
        private void HandleAtelierCouture1(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 86, new uint[] { 63 }, map.Id));
        }
        [Interactive("9798")]
        private void HandleAtelierCouture2(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 86, new uint[] { 63 }, map.Id));
        }
        #endregion

        #region Sculteur
        [Interactive("9796")]
        private void HandleAtelierSculteur(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 13, new uint[] { 15 }, map.Id));
        }
        #endregion

        #region Coordonnier
        [Interactive("38188")]
        private void HandleAtelierCoordonnier(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 11, new uint[] { 13 }, map.Id));
        }
        #endregion

        #region Bricoleur
        [Interactive("49504")]
        private void HandleAtelierBricoleur(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 122, new uint[] { 171 }, map.Id));
        }
        [Interactive("14604")]
        private void HandleAtelierBricoleur1(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 122, new uint[] { 171 }, map.Id));
        }
        #endregion

        #region Boucher
        [Interactive("14601")]
        private void HandleAtelierBoucher(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 97, new uint[] { 134 }, map.Id));
        }
        #endregion

        #region Idole - Bouclier - Trophee
        [Interactive("49574")]
        private void HandleAtelierIdole(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 12, new uint[] { 297 }, map.Id));
        }
        [Interactive("49573")]
        private void HandleAtelierIdole1(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 12, new uint[] { 297 }, map.Id));
        }
        [Interactive("49503")]
        private void HandleAtelierBouclier(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 138, new uint[] { 201 }, map.Id));
        }
        [Interactive("32494")]
        private void HandleAtelierTrophe(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            map.AddInteractive(new InteractiveAtelier(identifier, cellid, 97, new uint[] { 156 }, map.Id));
        }
        #endregion
    }
}
