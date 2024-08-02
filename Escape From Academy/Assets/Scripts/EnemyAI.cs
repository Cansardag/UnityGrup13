using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform target; // Takip edilecek hedef (oyuncu)
    public float disappearTime = 5f; // Düþmanýn kaybolacaðý süre
    public float reappearTime = 10f; // Düþmanýn yeniden görüneceði süre
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
                // Saldýrý animasyonunu tetikle
                animator.SetBool("isWalking", false);
                animator.SetBool("isRunning", false);
                int randomAttack = Random.Range(1, 4);
                animator.SetTrigger("st_attack" + randomAttack);
            }
            else
            {
                agent.SetDestination(target.position);
                if (distanceToTarget > 10f) // 10 birimden fazla uzaktaysa koþ
                {
                    animator.SetBool("isRunning", true);
                    animator.SetBool("isWalking", false);
                }
                else // Yakýnsa yürü
                {
                    animator.SetBool("isRunning", false);
                    animator.SetBool("isWalking", true);
                }
            }
        }
        else
        {
            // Yürüyüþ ve koþma animasyonlarýný durdur
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", false);
        }
    }

    IEnumerator DisappearAndReappear()
    {
        while (true)
        {
            yield return new WaitForSeconds(disappearTime);
            SetRenderersActive(false); // Düþmaný devre dýþý býrak
            isDisappearing = true;
            agent.isStopped = true;

            yield return new WaitForSeconds(reappearTime);
            SetRenderersActive(true); // Düþmaný tekrar etkinleþtir
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


