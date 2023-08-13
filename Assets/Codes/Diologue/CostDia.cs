using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class CostDia : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Дух дизайна костюма: Ого, это ты у нас новенький? Ты в чём это пришёл…. Мда, тебе очень повезло, что ты пришёл ко мне - на кафедру дизайна костюма, мы тут как раз одеждой занимаемся. Если ты собираешься учиться у нас – значит у тебя должно быть чувство стиля! Давай-ка ты поможешь мне собрать наряды для показа!", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Как-то много информации сразу...", "Чел"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
