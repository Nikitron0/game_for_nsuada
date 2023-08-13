using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class LedderBottomDia1 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Дух: О нет, зал закрыт…", "Чел"));

        dialogTexts.Add(new DialogData("Дух: Придётся сходить в кабинет промышленного дизайна за ключом", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Промышленный дизайн?", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Это типа дизайн заводов, да?", "Чел"));

        dialogTexts.Add(new DialogData("Дух: Ха-ха-ха, конечно же нет!", "Чел"));

        dialogTexts.Add(new DialogData("Дух: Ну же, пошли, дух кафедры сам тебе всё расскажет!", "Чел"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
