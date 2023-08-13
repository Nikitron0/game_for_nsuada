using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class ArchDia : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Дух архитектуры: Привет, Егор! Духи уже рассказали о тебе, ты ведь с некоторыми уже познакомился, верно?", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Здравствуйте, ага.", "Чел"));

        dialogTexts.Add(new DialogData("Дух архитектуры: Ну что? Понравилось?", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Очень!", "Чел"));

        dialogTexts.Add(new DialogData("Егор: А у Вас пропали части здания!!!", "Чел"));

        dialogTexts.Add(new DialogData("Дух архитектуры: Да, иногда такое случается. Нет ничего лучше, чем вспоминать старое и творить новое. Хочешь проверить свою внимательность и собрать здание в единое целое?", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Я?", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Мне кажется это очень сложно и боюсь не справлюсь!", "Чел"));

        dialogTexts.Add(new DialogData("Дух архитектуры: Нужно только попробовать и ты удивишься на что способен!", "Чел"));

        dialogTexts.Add(new DialogData("Дух архитектуры: Всегда верь в себя!", "Чел"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
