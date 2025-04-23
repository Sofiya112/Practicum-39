using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__39
{
    public interface IBook
    {
        string Title { get; } //Заголовок
        string Author { get; }  //Автор
        int Year { get; } //Годв ыпуска

        void DisplayInfo(); //Вывод
    }
}
