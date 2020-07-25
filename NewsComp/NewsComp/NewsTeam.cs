using System;
using System.Collections.Generic;
using System.Text;

namespace NewsComp
{
    internal abstract class NewsTeam
    {
        protected Story _story;

        internal abstract void CreateStory();
        internal Story GetStory()
        {
            return _story;
        }

        internal virtual void AddStyle()
        {
            _story.SetVisualStyle("Basic");
        }

        public override string ToString()
        {
            return $"News Team: [Story: {_story}]";
        }
    }
}
