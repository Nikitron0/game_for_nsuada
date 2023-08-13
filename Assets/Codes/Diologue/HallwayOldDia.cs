using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class HallwayOldDia : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Так странно, тут совсем никого?", "Чел"));

        dialogTexts.Add(new DialogData("Ауу??", "Чел"));

        dialogTexts.Add(new DialogData("Тут есть кто-нибудь?", "Чел"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
