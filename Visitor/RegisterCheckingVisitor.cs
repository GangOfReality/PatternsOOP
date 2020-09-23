using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class RegisterCheckingVisitor : Visitor
    {
        private List<char> currentWord = new List<char>();
        private List<string> misregisters = new List<string>();

        protected bool IsUpRegister(List<char> currentWord)
        {
            bool isUp = false;
            foreach(var ch in currentWord)
            {
                if (char.IsUpper(ch))
                    isUp = true;
            }
            return isUp;
        }
        public override void VisitCharacter(Character character)
        {
            char ch = character.character;

            if (char.IsLetter(ch))
                currentWord.Add(ch);
            else
            {
                if (IsUpRegister(currentWord))
                    misregisters.Add(new string(currentWord.ToArray()));
                currentWord.Clear();
            }
        }

        public override void VisitRow(Row row)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<string> GetElements()
        {
            return misregisters;
        }
    }
}
