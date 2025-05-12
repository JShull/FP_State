namespace FuzzPhyte.FSM.Samples
{
    using UnityEngine;
    
    public class FPEnemySightSensor : MonoBehaviour
    {
        public Transform Player { get; private set; }

        [SerializeField] private LayerMask _ignoreMask;
        public string PlayerTag = "Player";
        public string PlayerRefName = "FP_Player";
        private Ray _ray;
        [SerializeField]
        protected bool havePlayer = false;
        protected void Awake()
        {
            var PlayerGO = GameObject.Find(PlayerRefName);
            if (PlayerGO != null) 
            {
                Player = PlayerGO.transform;
            }
            if (Player == null)
            {
                //no player
                havePlayer = false;
            }
            else
            {
                havePlayer = true;
            }
        }

        public bool Ping()
        {
            if (Player == null)
            {
                var PlayerGO = GameObject.Find(PlayerRefName);
                if (PlayerGO != null)
                {
                    Player = PlayerGO.transform;
                }
                
                if (Player == null)
                {
                    return false;
                }
                else
                {
                    havePlayer = true;
                }
            }

            _ray = new Ray(this.transform.position, Player.position - this.transform.position);

            var dir = new Vector3(_ray.direction.x, 0, _ray.direction.z);

            var angle = Vector3.Angle(dir, this.transform.forward);

            if (angle > 60)
                return false;

            if (!Physics.Raycast(_ray, out var hit, 100, ~_ignoreMask))
            {
                return false;
            }

            if (hit.collider.tag == PlayerTag)
            {
                return true;
            }

            return false;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(_ray.origin, _ray.origin + _ray.direction * 100);
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(this.transform.position, this.transform.position + this.transform.forward * 100);
        }
    }
}
