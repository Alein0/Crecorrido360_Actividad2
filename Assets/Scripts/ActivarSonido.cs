using UnityEngine;

public class ActivarSonido : MonoBehaviour
{
    public GameObject post;
    public GameObject pret;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("Minando",post.transform.position);
           // AudioManager.Instance.Play2D("Entrar");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("Explosion",pret.transform.position);
           // AudioManager.Instance.Play2D("Salir");

        }

    }
}
