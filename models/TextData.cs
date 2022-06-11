using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.models
{
    public class TextData
    {
        private string text;

        public string Text { get => text; set => text = value.ToLower(); }
    }
}
