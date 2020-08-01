using System;
using System.Collections.Generic;
using System.Text;

namespace Clients
{
    public class Guest
    {
        private int _id;
        private string _name;

        //not assigning id value as default is 0, assigining value is redundant
        public Guest(int id,string name)
        {
            _id = id;
            _name = name;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return $"Guest [ id is: {_id}, name is: {_name} ]";
        }
    }
}
