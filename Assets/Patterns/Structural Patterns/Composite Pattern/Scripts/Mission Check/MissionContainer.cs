using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DesignPatterns
{
    public class MissionContainer : Questable
    {
        public List<Questable> missions;

        public override event UnityAction OnQuestComplete;

        public override void Check()
        {
            bool isAllCompleted = false;
            isAllCompleted = missions.TrueForAll(x => x.isCompleted);

            if (isAllCompleted )
            {
                isCompleted = true;
                gameObject.SetActive(false);
                OnQuestComplete?.Invoke();
            }
        }

        public void AddMission(Questable mission)
        {
            missions.Add(mission);
            mission.OnQuestComplete += Check;
        }

        public void RemoveMission(Questable mission)
        {
            missions.Remove(mission);
        }

        private void Start()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                var mission = transform.GetChild(i).GetComponent<Questable>();
                AddMission(mission);
            }
        }
    }
}
