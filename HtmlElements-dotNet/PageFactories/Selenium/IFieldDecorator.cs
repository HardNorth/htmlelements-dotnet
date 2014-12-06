using System.Reflection;

namespace Yandex.HtmlElements.PageFactories.Selenium
{
    public interface IFieldDecorator
    {
        object Decorate(FieldInfo field);
    }
}
