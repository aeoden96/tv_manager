﻿namespace TvManager.View.Interfaces
{
    using System;
    using System.Collections.Generic;
    using TvManager.Model.Models;

    public interface IShowService
    {
        void DeleteShow(Show show);

        void DeleteAllShows();
        IEnumerable<Show> GetAllShows();
        Show GetShow(Guid id);
        void SaveShow(Show show);
    }
}
