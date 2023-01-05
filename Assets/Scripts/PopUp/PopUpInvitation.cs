using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUpInvitation : MonoBehaviour
{
    public GameObject panel;
    public Button acceptButton;
    public Button declineButton;
    public Text inviteText;
    public string inviterName;
    public bool buttonClicked;

    void Start()
    {
        panel.SetActive(false);
        acceptButton.onClick.AddListener(AcceptInvitation);
        declineButton.onClick.AddListener(DeclineInvitation);
    }

    public void ShowInvitation(string name)
    {
        inviterName = name;
        inviteText.text = inviterName + " has invited you";
        panel.SetActive(true);
        // You just need to put a return that give you the buttonClicked
    }

    void AcceptInvitation()
    {
        // Add your code here to handle the acceptance of the invitation
        buttonClicked = true;
        panel.SetActive(false);
    }

    void DeclineInvitation()
    {
        // Add your code here to handle the decline of the invitation
        buttonClicked = false;
        panel.SetActive(false);
    }
}
