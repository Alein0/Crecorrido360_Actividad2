using UnityEngine;

public class ActivarSonidoGetOut : MonoBehaviour
{
    public GameObject post;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("GetOut", post.transform.position);
            // AudioManager.Instance.Play2D("Entrar");
        }
    }

}
