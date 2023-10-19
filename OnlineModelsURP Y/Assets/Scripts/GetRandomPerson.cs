using UnityEngine;

public class GetRandomPerson : MonoBehaviour
{
    public Transform mask;
    public int peoples;
    int maskNum = 0;
    int childNum = 0;
    public int hehe;
    public Animator animator;
    private void OnEnable()
    {
        Change();
        if (hehe == 1)
        {
            animator.SetBool("hehe", true);
        }
    }
    void Change()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        mask.GetChild(0).gameObject.SetActive(false);

        childNum = Random.Range(0, peoples - 1);
        transform.GetChild(childNum).gameObject.SetActive(true);

        if (1 == 1)
        {
            maskNum = Random.Range(2, mask.childCount - 1);

            Transform maskNew = mask.GetChild(maskNum);
            maskNew.gameObject.SetActive(true);
            if (maskNew.tag == "EditorOnly")
            {
                if (childNum < 3)
                {
                    mask.GetChild(1).gameObject.SetActive(true);
                }
                else
                {
                    mask.GetChild(0).gameObject.SetActive(true);
                }
            }
        }
    }
}
