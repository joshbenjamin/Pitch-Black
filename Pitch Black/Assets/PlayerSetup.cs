using UnityEngine;
using UnityEngine.Networking;

public class PlayerSetup : NetworkBehaviour {

    [SerializeField]
    Behaviour[] componentsToDisable;

    Camera sceneCamera;

    public GameObject below;

    Transform originalTransform;

    void Start()
    {
        if (!isLocalPlayer)
        {
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
        }
        else
        {
            sceneCamera = Camera.main;
            if(sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
        }

        originalTransform = this.transform;
    }

    void OnDisable()
    {
        if(sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }        
    }

    void Update()
    {
        Debug.Log(this.transform.position);
        Debug.Log(originalTransform.position);
        Debug.Log(below.transform.position);
        Debug.Log(" ");
        //this.transform.position = originalTransform.position + below.transform.position;
    }

}
