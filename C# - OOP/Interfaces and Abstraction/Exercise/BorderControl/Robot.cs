using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IInhabitants
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.model = model;
            this.Id = id;
        }

        public string Id
        {
            get { return id; }
            private set { id = value; }
        }
    }
}
