namespace HtmlTags
{
    /// <summary>
    ///     HtmlTag that *only outputs the literal html put into it in the
    ///     constructor function
    /// </summary>
    public class LiteralTag : HtmlTag
    {
        public LiteralTag(string html) : base("div")
        {
            Text(html);
            Encoded(false);
        }

        protected override void WriteHtml(HtmlTextWriter html) => html.Write(Text());
    }    
}