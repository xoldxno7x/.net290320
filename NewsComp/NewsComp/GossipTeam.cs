using System;
using System.Collections.Generic;
using System.Text;

namespace NewsComp
{
    internal class GossipTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            _story = new Story();
            _story.SetTitle("Something really outrages");
            _story.SetBody("Something speculative at best");
        }
    }
}
