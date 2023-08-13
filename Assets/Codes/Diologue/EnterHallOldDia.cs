using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class EnterHallOldDia : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Ого, это здание такое огромное!", "Чел"));

        dialogTexts.Add(new DialogData("Оно будто притягивает", "Чел"));

        dialogTexts.Add(new DialogData("Интересно, что это такое?", "Чел"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
