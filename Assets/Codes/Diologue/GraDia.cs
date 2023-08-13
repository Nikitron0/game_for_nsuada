using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class GraDia : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Дух коммуникационного дизайна: Здравствуй, юный художник. Я - дух коммуникационного дизайна, ты знаешь об этом направлении?", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Хмм, это что-то про рекламу?", "Чел"));

        dialogTexts.Add(new DialogData("Дух коммуникационного дизайна: Верно! Мы занимаемся не только рекламой, но и журналами, визитками, обложками и другим.", "Чел"));

        dialogTexts.Add(new DialogData("Дух коммуникационного дизайна: Мы работаем с графическими программами и «бумажными» рисунками", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Я всё ещё не совсем понимаю…", "Чел"));

        dialogTexts.Add(new DialogData("Дух коммуникационного дизайна: Хм, давай я всё тебе покажу!", "Чел"));

        dialogTexts.Add(new DialogData("Дух коммуникационного дизайна: Давай попробуем подобрать шрифты под определенную картинку.", "Чел"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
