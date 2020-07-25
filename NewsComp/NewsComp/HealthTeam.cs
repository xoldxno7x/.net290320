using System;
using System.Collections.Generic;
using System.Text;

namespace NewsComp
{
    internal class HealthTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            _story = new Story();
            _story.SetTitle("Something shoking about coivd 19");
            _story.SetBody("Something rehashed and not new");
        }

        internal override void AddStyle()
        {
            _story.SetVisualStyle("Pictures of Doctors");
        }

        public override string ToString()
        {
            return $"Health Team: {base.ToString()}";
        }
    }
}
