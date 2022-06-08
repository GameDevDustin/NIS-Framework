using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Scripts.LiveObjects
{
    public class EndZone : MonoBehaviour
    {
        [SerializeField] private ZoneInteractions _endZoneInteraction;
        
        private void OnEnable()
        {
            //InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;
            ZoneInteractions.onZoneInteractionComplete += ZoneInteractions_OnZoneInteractionComplete;
        }

        private void ZoneInteractions_OnZoneInteractionComplete(ZoneInteractions zone)
        {
            if (zone.GetZoneID() == 7)
            {
                ZoneInteractions.CurrentZoneID = 0;
                SceneManager.LoadScene(0);
            }
        }

        // private void InteractableZone_onZoneInteractionComplete(InteractableZone zone)
        // {
        //     if (zone.GetZoneID() == 7)
        //     {
        //         InteractableZone.CurrentZoneID = 0;
        //         SceneManager.LoadScene(0);
        //     }
        // }

        private void OnDisable()
        {
            // InteractableZone.onZoneInteractionComplete -= InteractableZone_onZoneInteractionComplete;
            ZoneInteractions.onZoneInteractionComplete -= ZoneInteractions_OnZoneInteractionComplete;
        }
    }
}