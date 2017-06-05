namespace HtmlTags.Conventions.Elements.Builders
{
    public class TextboxBuilder : IElementBuilder
    {
        public bool Matches(ElementRequest subject) => true;

        public HtmlTag Build(ElementRequest request)
        {
            return HtmlTagExtensions.Attr(new TextboxTag(),"value", (request.RawValue ?? string.Empty).ToString());
        }
    }
}