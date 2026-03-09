using UnityEngine;

public class ActivarSonidosExplosion : MonoBehaviour
{
    public GameObject post;
    public GameObject pret;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("Explosion", post.transform.position);
            // AudioManager.Instance.Play2D("Entrar");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("Rocas", pret.transform.position);
            // AudioManager.Instance.Play2D("Salir");

        }

    }
}
