using System;

namespace ConsoleApp1
{
    public class Book
    {
        public Book()
        {
            BookInit();
        }
        
        private Title _title { get; set; }
        private Author _author = null;
        private Content _content = null;

        private void BookInit()
        {
            _title = new Title();
            _author = new Author();
            _content = new Content();
        }
        public void PrintInfo()
        {
            _title.Show();
            _author.Show();
            _content.Show();
            Console.BackgroundColor = ConsoleColor.Black; 
            Console.ForegroundColor = ConsoleColor.Gray; 
        }
        public string Title
        {
            get => _title.Value;
            set => _title.Value = value;
        }

        public string Author
        {
            get => _author.Value;
            set => _author.Value = value;
        }
        
        public string Content
        {
            get => _content.Value;
            set => _content.Value = value;
        }
    }
    
    public class Title
    {
        private string _value;

        public string Value
        {
            get => _value;
            set => _value = value;
        }

        public Title(){}

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Gray; // устанавливаем белый цвет фона для текста
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем красный цвет шрифта
            Console.WriteLine(_value);
        }
    }
    
    public class Author
    {
        private string _value;
        
        public string Value
        {
            get => _value;
            set => _value = value;
        }
        
        public Author(){}

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Gray; // устанавливаем белый цвет фона для текста
            Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем красный цвет шрифта
            Console.WriteLine(_value);
        }
    }
    
    public class Content
    {
        private string _value;
        public string Value
        {
            get => _value;
            set => _value = value;
        }
        
        public Content(){}

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Gray; // устанавливаем белый цвет фона для текста
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем красный цвет шрифта
            Console.WriteLine(_value);
        }
    }
}
