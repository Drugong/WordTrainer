using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloicka
{
    public class WordDataModel : IListSource
    {
        private BindingList<Word> data = new BindingList<Word>();
        public bool ContainsListCollection
        {
            get { return true; }
        }

        public void Import(BindingList<Word> list)
        {
            this.data = list;
        }

        public IList GetList()
        {
            return this.data;
        }

        public void Add(Word word)
        {
            this.data.Add(word);
        }

        public void Delete(int index)
        {
            this.data.RemoveAt(index);
        }

        public void Update(int index, Word word)
        {
            Word w = this.data[index];
            w.Language1 = word.Language1;
            w.Language2 = word.Language2;
        }

        public Word GetWordByIndex(int index)
        {
            return this.data[index];
        }

        public int ItemCount()
        {
            return this.data.Count;
        }

        public bool IsWordOriginal(Word w)
        {
            foreach (Word item in data)
            {
                //if (item.Equals(w))
                //    return false;
                if (item.Language1 == w.Language1 && item.Language2 == w.Language2)
                    return false;
            }
            return true;
        }
    }
}
