using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexMystem.Wrapper.Models.Mystem;

namespace YandexMystem.Wrapper.Models
{
    public class WordModel
    {
        public List<LexModel> Lexems { get; set; }

        public MystemWord SourceWord { get; set; }

        public WordModel()
        {

        }

        public WordModel(MystemWord mysteamWord)
        {
            SourceWord = mysteamWord;
            Lexems = SourceWord.Analysis.ToList()
                .Select(x => new LexModel(x))
                .ToList();
        }

        public override string ToString()
        {
            return SourceWord.Text;
        }
    }
}
