using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexMystem.Wrapper.Enums;
using YandexMystem.Wrapper.Models.Mystem;

namespace YandexMystem.Wrapper.Models
{
    public class LexModel
    {
        public MystemLex SourceLex { get; set; }

        public string Lexeme { get; set; }

        public double Weight { get; set; }

        public GramPartsEnum GramPart { get; set; }

        public LexModel()
        {
        }

        public LexModel(MystemLex mysteamLex)
        {
            SourceLex = mysteamLex;

            Lexeme = SourceLex.Lex.ToLower();
            Weight = SourceLex.Wt;

            var group1 = SourceLex.Gr.Split('=');

            GramPart = GetGramPart(group1[0].Split(',')[0]);

            /*GramPart = group1[0].Split(',')[0];

            if (GramPart.IsNoun)
            {
                GramGender = group1[0];
                GramAnim = group1[0];
            }else if (GramPart.IsVerb)
            {
                GramVerbTense = group1[0];
                GramVerbSpecies = group1[0];

                if (group1.Length > 0)
                {
                    GramVerbTense = group1[1];
                    GrammCount = group1[1];
                    GramVerbPers = group1[1];
                }
            }*/
        }

        public GramPartsEnum GetGramPart(string str)
        {
            switch (str.ToUpper().Trim())
            {
                case "A":
                    return GramPartsEnum.Adjective;

                case "ADV":
                    return GramPartsEnum.Adverb;

                case "ADVPRO":
                    return GramPartsEnum.PronominalAdverb;

                case "ANUM":
                    return GramPartsEnum.NumeralAdjective;

                case "APRO":
                    return GramPartsEnum.PronounAdjective;
                    
                case "COM":
                    return GramPartsEnum.CompositePart;

                case "CONJ":
                    return GramPartsEnum.Conjunction;
                    
                case "INTJ":
                    return GramPartsEnum.Interjection;
                    
                case "NUM":
                    return GramPartsEnum.Numeral;
                    
                case "PART":
                    return GramPartsEnum.Part;
                    
                case "PR":
                    return GramPartsEnum.Pretext;
                    
                case "S":
                    return GramPartsEnum.Noun;

                case "SPRO":
                    return GramPartsEnum.NounPronoun;

                case "V":
                    return GramPartsEnum.Verb;
            }

            throw new ArgumentException("Unknow part");
        }

        public override string ToString()
        {
            return GramPart.ToString();
        }
    }
}
