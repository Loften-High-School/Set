using UnityEngine;
using UnityEngine.UI;
using System;
using Unity;
public class ConnectUiScript : MonoBehaviour
{
    [SerializeField] private Button hostButton;
    [SerializeField] private Button clientButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        host.Button.onClick.AddListener(HostButtonOnClick);
        clientButton.onClick.AddListener(ClientButtonOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HostButtonOnClick()
    {
        NetworkManager.Singleton.StartHost;
    }
    private void ClientButtonOnClick()
    {
        NetworkManager.Singleton.StartClient();
    }
}
