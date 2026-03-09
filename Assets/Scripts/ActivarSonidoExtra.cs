using UnityEngine;

public class ActivarSonidoExtra : MonoBehaviour
{
    public GameObject post;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("Hola", post.transform.position);
            // AudioManager.Instance.Play2D("Entrar");
        }
    }

}
