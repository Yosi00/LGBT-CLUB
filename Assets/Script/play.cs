using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("drop")) 
        {
            // ��������� ��������� � �������� �������
            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<Renderer>().enabled = false;

            // �������� ��������
            anim.SetTrigger("TriggerAnimation");
        }
    }
}
