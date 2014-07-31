namespace Refactoring.DealingWithGeneralization.FormTemplateMethod.Before
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