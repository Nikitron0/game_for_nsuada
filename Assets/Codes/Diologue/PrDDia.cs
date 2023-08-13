using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class PrDDia : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

    dialogTexts.Add(new DialogData("Дух промышленного дизайна: О, к нам забрёл новый деятель искусства? Как же приятно видеть новичков у нас! Я - дух промышленного дизайна!", "Чел"));

    dialogTexts.Add(new DialogData("Егор: Это дизайн…?", "Чел"));

    dialogTexts.Add(new DialogData("Дух промышленного дизайна: Нет - нет, не дизайн заводов.", "Чел"));

    dialogTexts.Add(new DialogData("Дух промышленного дизайна: Мы создаём всю предметную среду вокруг тебя. Стулья, столы, элементы декора и внешний вид инструментов!", "Чел"));

    dialogTexts.Add(new DialogData("Дух промышленного дизайна: Всё, что ты можешь себе представить от игрушки до твоего телефона — это мы", "Чел"));

    dialogTexts.Add(new DialogData("Егор: Огооо, не думал, что человек одной специальности может охватывать столько предметов разом…", "Чел"));

    dialogTexts.Add(new DialogData("Дух промышленного дизайна: Всё хорошо, тебе ещё многое предстоит узнать сегодня! Ты уже был в большом зале?", "Чел"));

    dialogTexts.Add(new DialogData("Дух: Он заперт, ключ должен быть где-то у тебя", "Чел"));

    dialogTexts.Add(new DialogData("Дух промышленного дизайна: ох...ого где-то…здесь?", "Чел"));

    dialogTexts.Add(new DialogData("Дух промышленного дизайна: Давай ты поможешь мне навести здесь порядок, может и ключ найдётся. Найди мне предметы, которые я скажу, я расставлю их по местам", "Чел"));

    DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
