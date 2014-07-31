namespace Refactoring.DealingWithGeneralization.FormTemplateMethod.After
{
    public class Movie
    {
        private readonly string _title;

        public Movie(string title)
        {
            _title = title;
        }

        public string Title
        {
            get { return _title; }
        }
    }
}