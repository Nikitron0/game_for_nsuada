using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class LedderTopDia : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Егор: АААААА", "Чел"));

        dialogTexts.Add(new DialogData("Девочка: Ну, не пугайся ты так! Не призрак я, никто тебя не тронет", "Чел"));

        dialogTexts.Add(new DialogData("Егор: А кто тогда?", "Чел"));

        dialogTexts.Add(new DialogData("Девочка: Дух этого места!", "Чел"));

        dialogTexts.Add(new DialogData("Девочка: Ты попал в НГУАДИ, замечательный творческий вуз, обитель креативных идей и лучшее место для наших учеников!", "Чел"));

        dialogTexts.Add(new DialogData("Девочка: Ты ведь здесь не просто так — это место притянуло тебя, потому что в тебе тоже есть творческая искра. Пойдём в главный зал, я всё тебе расскажу", "Чел"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
