namespace Enemy
{
    /*using Pathfinding;
    using UnityEngine;

    public class AirborneEnemy : EnemyBase
    {
        [SerializeField] private Seeker _seeker;
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private Transform target;
        [SerializeField] private Transform _enemyGFXTransform;

        [SerializeField] private float _speed;
        [SerializeField] private float _nextWaypointDistance = 3f;

        private Path _path;
        private int _currentWaypoint = 0;
        private bool _reachedEndOfPath = false;


        private void Start()
        {
            InvokeRepeating(nameof(UpdatePath), 0f, 0.5f);
        }

        private void UpdatePath()
        {
            if (_seeker.IsDone())
            {
                _seeker.StartPath(_rigidbody.position, target.position, OnPathComplete);
            }
        }

        private void OnPathComplete(Path p)
        {
            if (p.error)
            {
                return;
            }

            _path = p;
            _currentWaypoint = 0;
        }

        private void FixedUpdate()
        {
            if (_path == null)
            {
                return;
            }

            if (_currentWaypoint >= _path.vectorPath.Count)
            {
                _reachedEndOfPath = true;
                return;
            }
            
            _reachedEndOfPath = false;

            Vector2 dir = ((Vector2)_path.vectorPath[_currentWaypoint] - _rigidbody.position).normalized;
            Vector2 force = dir * (_speed * Time.deltaTime);
            _rigidbody.AddForce(force);
            float distance = Vector2.Distance(_rigidbody.position, _path.vectorPath[_currentWaypoint]);
            if (distance < _nextWaypointDistance)
            {
                _currentWaypoint++;
            }

            FlipEnemyGFX(force);
        }

        private void FlipEnemyGFX(Vector2 forceDirection)
        {
            _enemyGFXTransform.localScale = forceDirection.x switch
            {
                >= 0.01f => new Vector3(1f, 1f, 1f),
                <= -0.01f => new Vector3(-1f, 1f, 1f),
                _ => _enemyGFXTransform.localScale,
            };
        }
    }*/
}