using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    public class QuestArbiter : MonoBehaviour
    {
        public void MissionComplete(Questable targetMission)
        {
            targetMission.Check();
        }
    }
}
