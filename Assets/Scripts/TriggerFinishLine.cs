using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                print("☆*: .｡. o(≧▽≦)o .｡.:*☆     ○( ＾皿＾)っ Hehehe…");
            }
            else
            {
                print("Cheater (¬_¬)");
            }
        }
    }
}
