namespace HtmlTags.Conventions.Elements.Builders
{
    public class SpanDisplayBuilder : IElementBuilder
    {
        public HtmlTag Build(ElementRequest request)
        {
            return HtmlTagExtensions.Id(HtmlTagExtensions.Text(new HtmlTag("span"), request.StringValue()), request.ElementId);
        }
    }
    
}