using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform target; // Takip edilecek hedef (oyuncu)
    public float disappearTime = 5f; // D��man�n kaybolaca�� s�re
    public float reappearTime = 10f; // D��man�n yeniden g�r�nece�i s�re
    private NavMeshAgent agent;
    private Animator animator;
    private Renderer[] renderers;
    private bool isDisappearing = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        renderers = GetComponentsInChildren<Renderer>();
        StartCoroutine(DisappearAndReappear());
    }

    void Update()
    {
        if (target != null && !isDisappearing)
        {
            float distanceToTarget = Vector3.Distance(transform.position, target.position);

            if (distanceToTarget <= agent.stoppingDistance)
            {
                // Sald�r� animasyonunu tetikle
                animator.SetBool("isWalking", false);
                animator.SetBool("isRunning", false);
                int randomAttack = Random.Range(1, 4);
                animator.SetTrigger("st_attack" + randomAttack);
            }
            else
            {
                agent.SetDestination(target.position);
                if (distanceToTarget > 10f) // 10 birimden fazla uzaktaysa ko�
                {
                    animator.SetBool("isRunning", true);
                    animator.SetBool("isWalking", false);
                }
                else // Yak�nsa y�r�
                {
                    animator.SetBool("isRunning", false);
                    animator.SetBool("isWalking", true);
                }
            }
        }
        else
        {
            // Y�r�y�� ve ko�ma animasyonlar�n� durdur
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", false);
        }
    }

    IEnumerator DisappearAndReappear()
    {
        while (true)
        {
            yield return new WaitForSeconds(disappearTime);
            SetRenderersActive(false); // D��man� devre d��� b�rak
            isDisappearing = true;
            agent.isStopped = true;

            yield return new WaitForSeconds(reappearTime);
            SetRenderersActive(true); // D��man� tekrar etkinle�tir
            isDisappearing = false;
            agent.isStopped = false;
        }
    }

    void SetRenderersActive(bool isActive)
    {
        foreach (Renderer renderer in renderers)
        {
            renderer.enabled = isActive;
        }
    }
}


