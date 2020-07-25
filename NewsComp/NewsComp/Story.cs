using System;
using System.Collections.Generic;
using System.Text;

namespace NewsComp
{
    public class Story
    {
        private string _title;
        private string _body;
        private string _visualStyle;

        public void SetTitle(string title)
        {
            _title = title;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetBody(string body)
        {
            _body = body;
        }

        public string GetBody()
        {
            return _body;
        }

        public void SetVisualStyle(string vs)
        {
            _visualStyle = vs;
        }

        public string GetVisualStyle()
        {
            return _visualStyle;
        }

        public override string ToString()
        {
            return $"Story: [title is: {_title}, body is: {_body}, visual style is: {_visualStyle}]";
        }
    }
}
