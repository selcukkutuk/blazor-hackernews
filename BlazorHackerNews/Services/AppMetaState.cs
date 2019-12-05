using System;

namespace BlazorHackerNews.Services
{
    public class AppMetaState
    {
        private string _appTitle = "Blazor HackerNews";

        public string Title { get; private set; }

        public void SetTitle(string title)
        {
            Title = title + " - " + _appTitle;
        }

        public Action CallStateHasChanged;
    }
}
