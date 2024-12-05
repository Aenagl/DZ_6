using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop
{
    public abstract class Video
    {
        #region Field
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Жанр
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Длительность в минутах
        /// </summary>
        public int Duration { get; set; }
        #endregion

        #region Constructor
        public Video(string title,string genre, string description, int duration)
        {
            Title = title;
            Genre = genre;
            Description = description;
            Duration = duration;
        }
        #endregion

        #region Methods
        public abstract void Play();
        public abstract void Info();
        #endregion
    }
}