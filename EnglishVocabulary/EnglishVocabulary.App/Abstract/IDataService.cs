using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishVocabulary.App.Abstract
{
    public interface IDataService
    {
        bool SaveData(string path);
        bool LoadData(string path);
    }
}
