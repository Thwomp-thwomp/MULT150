using UnityEngine;

public class chaosgoal: MonoBehaviour
{
    public int requiredBalls = 6;
    private int currentBalls = 0;

    public bool isSolved = false;

    void OnTriggerEnter(Collider collider)
    {
        if (isSolved) return;

        if (collider.CompareTag(tag))
        {
            currentBalls++;
            Destroy(collider.gameObject);

            if (currentBalls >= requiredBalls)
            {
                SolveGoal();
            }
        }
    }

    void SolveGoal()
    {
        isSolved = true;

        Light lightComp = GetComponent<Light>();
        if (lightComp != null)
        {
            lightComp.enabled = false;
        }
    }
}