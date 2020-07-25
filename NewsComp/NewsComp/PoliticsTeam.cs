using System;
using System.Collections.Generic;
using System.Text;

namespace NewsComp
{
    class PoliticsTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            _story = new Story();
            _story.SetTitle("Something shocking and scanalous");
            _story.SetBody("Something vaguely connected to the title");
        }

        override internal void AddStyle()
        {
            _story.SetVisualStyle("Picture of the Kneset");
        }

        public override string ToString()
        {
            return $"PoliticalTeam: {base.ToString()}";
        }
    }
}
