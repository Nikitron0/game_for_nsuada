using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class MuseDia : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Дух музеологии: Здравствуйте, вы тот самый Егор?", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Угу, а вы?", "Чел"));

        dialogTexts.Add(new DialogData("Дух музеологии: Я дух музеологии, мы знаем все об искусстве, о жанрах, о стилях. О том, как сохранить искусство на долгие года. Мы знаем толк в организации выставок.", "Чел"));

        dialogTexts.Add(new DialogData("Дух музеологии: Кстати, об этом…", "Чел"));

        dialogTexts.Add(new DialogData("Дух музеологии: Мне как раз нужно закончить выставку! Ох, там столько еще нужно сделать! И картины, и вазы, и скульптуры перемешались, а они нужны мне в одном стиле!", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Ого, а можно мне тоже попробовать?", "Чел"));

        dialogTexts.Add(new DialogData("Дух музеологии: Конечно! Будущий деятель искусства всегда должен быть готов к организации своей выставки, правда же?", "Чел"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
