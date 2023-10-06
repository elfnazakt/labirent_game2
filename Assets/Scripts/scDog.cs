using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class scDog : MonoBehaviour
{
    public Transform target;  //Karakterim target'e baksýn
    public float speed;
    NavMeshAgent agent;
    Animator animator;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (target != null)
        {
            Vector3 projection=new Vector3(target.position.x, 0,target.position.z);
            agent.SetDestination(projection);

            animator.SetBool("moving", agent.remainingDistance > agent.stoppingDistance); //kalan mesafe durma mesafesinden büyük olursa ekrana true yazdýr aksi halde false
        }
    }
}
