using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Enums
{
    [Flags]
    public enum MystemExecuteOptions
    {
        /// <summary>
        /// Построчный режим; каждое слово печатается на новой строке.
        /// </summary>
        WordPerLineOutput = 1 << 0, // -n

        /// <summary>
        /// Копировать весь ввод на вывод. То есть, не только слова, но и межсловные промежутки
        /// </summary>
        SaveInputFormat = 1 << 1, // -c

        /// <summary>
        /// Печатать только словарные слова
        /// </summary>
        OnlyDictionaryWords = 1 << 2, // -w

        /// <summary>
        /// Не печатать исходные словоформы, только леммы и граммемы.
        /// </summary>
        OnlyLems = 1 << 3, // -l

        /// <summary>
        /// Печатать грамматическую информацию, расшифровка ниже.
        /// </summary>
        GetGramms = 1 << 4, // -i

        /// <summary>
        /// Склеивать информацию словоформ при одной лемме (только при включенной опции <see cref="GetGramms"/>).
        /// </summary>
        GroupGramms = 1 << 5, // -g

        /// <summary>
        /// Печатать маркер конца предложения (только при включенной опции <see cref="SaveInputFormat"/>).
        /// </summary>
        MarkSentenceEnd = 1 << 6, // -s

        /// <summary>
        /// Кодировка ввода/вывода. Возможные варианты: cp866, cp1251, koi8-r, utf-8 (по умолчанию).
        /// </summary>
        Encoding = 1 << 7, // -e

        /// <summary>
        /// рименить контекстное снятие омонимии.
        /// </summary>
        AutoHomonym = 1 << 8, // -d

        /// <summary>
        /// Печатать английские обозначения граммем.
        /// </summary>
        LatGramms = 1 << 9, // --eng-gr

        /// <summary>
        /// Строить разборы только с указанными граммемами.
        /// </summary>
        FilterGramms = 1 << 10, // --filter-gram

        /// <summary>
        /// Использовать файл с пользовательским словарём.
        /// </summary>
        UseUserDictionary = 1 << 11, // --fixlist

        /// <summary>
        /// Формат вывода. Возможные варианты: text, xml, json. Значение по умолчанию — text.
        /// </summary>
        UseFormat = 1 << 12, // --format

        /// <summary>
        /// Генерировать все возможные гипотезы для несловарных слов.
        /// </summary>
        UnknowWordHypothesis = 1 << 13, // --generate-all

        /// <summary>
        /// Печатать бесконтекстную вероятность леммы.
        /// </summary>
        ShowWeights = 1 << 14 // --weight
    }
}
