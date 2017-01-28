using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Enums
{
    public enum GramPartsEnum
    {
        /// <summary>
        /// Прилагательное
        /// </summary>
        Adjective, // A

        /// <summary>
        /// Наречие
        /// </summary>
        Adverb, // ADV

        /// <summary>
        /// Местоименное наречие
        /// </summary>
        PronominalAdverb, // ADVPRO

        /// <summary>
        /// Числительное-прилагательное
        /// </summary>
        NumeralAdjective, // ANUM

        /// <summary>
        /// Местоимение-прилагательное
        /// </summary>
        PronounAdjective, // APRO

        /// <summary>
        /// Часть композита - сложного слова
        /// </summary>
        CompositePart, // COM

        /// <summary>
        /// Союз
        /// </summary>
        Conjunction, // CONJ

        /// <summary>
        /// Иеждометие
        /// </summary>
        Interjection, // INTJ

        /// <summary>
        /// Числительное
        /// </summary>
        Numeral, // NUM

        /// <summary>
        /// Частица
        /// </summary>
        Part, // PART

        /// <summary>
        /// Предлог
        /// </summary>
        Pretext, // PR

        /// <summary>
        /// Существительное
        /// </summary>
        Noun, // S

        /// <summary>
        /// Местоимение-существительное
        /// </summary>
        NounPronoun, // SPRO

        /// <summary>
        /// Глагол
        /// </summary>
        Verb // V
    }
}
