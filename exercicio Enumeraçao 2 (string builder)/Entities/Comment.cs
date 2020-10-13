using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_Enumeraçao_2__string_builder_.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
