using UnityEngine;

public class chickencontrol : MonoBehaviour
{
    private Animator ani;
    private void Start()
    {
        ani = GetComponent<Animator>();
    }

    private void Update()

    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            ani.SetTrigger("吃飯觸發器");
        }
        if(Input.GetKey(KeyCode.R))
        {
            ani.SetBool("跑步開關", true);
        }
        else
        {
            ani.SetBool("跑步開關", false);
        }
    }
}
