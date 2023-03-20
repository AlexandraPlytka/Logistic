using Logistic.Domain.Convertors.txt;
using Logistic.Domain.Repositories.Abstract;
using System.Collections.Generic;
using System.IO;
using System;

namespace Logistic.Domain.Repositories.Concreate.Txt
{
    internal class TxtBaseRepository<T> :IRepository<T>
    {
        private List<T> _items;
        private string _sourceFileName;
        private ITxtConvector<T> _convertor;
        public TxtBaseRepository(string sourceFileName, ITxtConvector<T> convertor)
        {
            _items= new List<T>();
            _sourceFileName= sourceFileName;    
            _convertor= convertor;
        }
        public void Add(T item)
        {
            _items.Add(item);
            WriteItemsToFile();
        }
        /// <summary>
        /// Call Count method after GetAll mwthod to sync all data
        /// </summary>
        public int Count()
        {
            //ReadItemsFromFile();
            return _items.Count;
        }

        public T[] GetAll()
        {
            ReadItemsFromFile();
            return _items.ToArray();
        }
        private void ReadItemsFromFile()
        {
            _items.Clear();
            using (var sr = new StreamReader(_sourceFileName))
            {
                var lines = sr.ReadToEnd().Split('\n');
                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line)) // line == null || line == ""
                        _items.Add(_convertor.Convert(line));
                }
            }

        }
        private void WriteItemsToFile(){
            using (var sw = new StreamWriter(_sourceFileName)) {
                foreach (var item in _items)
                {
                    sw.WriteLine(_convertor.Convert(item));
                }
            }

        }
    }
}
