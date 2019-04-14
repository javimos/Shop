namespace Shop.UIForms.Infrastructure
{
    using ViewModels;

    public class InstantLocator
    {
        public MainViewModel Main { get; set; }

        public InstantLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
