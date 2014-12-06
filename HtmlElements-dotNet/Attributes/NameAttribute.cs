using System;

namespace Yandex.HtmlElements.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public class NameAttribute : Attribute
    {
        private string name;

        public NameAttribute(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }

        }
    }
}
