namespace FuzzPhyte.FSM.Samples
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "FPInLineOfSightDecision", menuName = "FuzzPhyte/FSM/Decision/FPInLineOfSightDecision")]
    public class FPInLineOfSightDecision : FSM_BaseDecision
    {
        public override bool Decide(FP_BaseStateMachine stateMachine)
        {
            var enemyInLineOfSight = stateMachine.GetComponent<FPEnemySightSensor>();
            if (enemyInLineOfSight != null) 
            {
                return enemyInLineOfSight.Ping();
            }
            else
            {
                return false;
            }
            
        }
    }
}
