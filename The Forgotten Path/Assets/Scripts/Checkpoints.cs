using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG
{
    public class Checkpoints : MonoBehaviour
    {
        private Vector3 Respawn;
        [SerializeField]
        private Collider BoxCollider;
        private GameObject Player;
        [SerializeField]
        private GameObject CheckBox;
        [SerializeField]
        private int HealthInc;
        [SerializeField]
        private int XPInc;
        private void Start()
        {
            Player = GameObject.FindGameObjectWithTag("Player");
        }
        private void OnTriggerEnter(Collider other)
        {
            
            //Player.GetComponent<LevelSystem>().IncreaseXP(XPInc);
            Destroy(CheckBox);
        }
        public void SetCheckpoint(Vector3 CheckpointPosition)
        {
            Instantiate(CheckBox, CheckpointPosition, Quaternion.identity);
        }
        public void SetRespawnPosition(Vector3 RespawnPosition)
        {
            Respawn = RespawnPosition;
            Debug.Log(Respawn);
        }
        public void SetCheckpointName(string name)
        {
            CheckBox.name = name;
        }
    }
}
