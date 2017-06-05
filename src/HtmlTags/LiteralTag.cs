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

    public static class LiteralTagExtensions
    {
        /// <summary>
        ///     Adds a LiteralTag to the Children collection
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="html"></param>
        /// <returns></returns>
        public static T AppendHtml<T>(this T tag, string html) where T : HtmlTag
        {
            tag.Append(new LiteralTag(html));
            return tag;
        }
    }
}