using System;
using System.Collections.Generic;

namespace HtmlTags
{
    public static class HtmlTagExtensions
    {
        public static TagList ToTagList(this IEnumerable<HtmlTag> tags) => new TagList(tags);

        public static T Text<T>(this T tag, string text) where T : HtmlTag
        {
            tag.Text(text);
            return tag;
        }

        public static T Encoded<T>(this T tag, bool encoded) where T : HtmlTag
        {
            tag.Encoded(encoded);
            return tag;
        }

        public static T Id<T>(this T tag, string id) where T : HtmlTag
        {
            tag.Id(id);
            return tag;
        }

        /// <summary>
        /// Specify that the tag should render only its children and not itself.  
        /// Used for declaring container/placeholder tags that should not affect the final markup.
        /// </summary>
        public static T NoClosingTag<T>(this T tag) where T : HtmlTag
        {
            tag.NoClosingTag();
            return tag;
        }

        public static T UseClosingTag<T>(this T tag) where T : HtmlTag
        {
            tag.UseClosingTag();
            return tag;
        }

        public static T NoTag<T>(this T tag) where T : HtmlTag
        {
            tag.NoTag();
            return tag;
        }

        /// <summary>
        /// Adds the given tag as the last child of the parent, and returns the parent.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="child">The tag to add as a child of the parent.</param>
        /// <returns></returns>
        public static T Append<T>(this T tag, HtmlTag child) where T : HtmlTag
        {
            tag.Append(child);
            return tag;
        }

        /// <summary>
        /// Creates nested child tags and returns the tag on which the method was called. Use <see cref="HtmlTag.Add(string)" /> if you want to return the innermost tag.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="tagNames">One or more HTML element names separated by a <c>/</c> or <c>&gt;</c></param>
        /// <returns>
        /// The instance on which the method was called (the parent of the new tags)
        /// </returns>
        public static T Append<T>(this T tag, string tagNames) where T : HtmlTag
        {
            tag.Append(tagNames);
            return tag;
        }

        /// <summary>
        /// Adds a LiteralTag of unencoded html to this HtmlTag
        /// </summary>
        public static T AppendHtml<T>(this T tag, string html) where T : HtmlTag
        {
            tag.AppendHtml(html);
            return tag;
        }

        /// <summary>
        /// Adds all tags from <paramref name="tagSource" /> as children of the current tag. Returns the parent tag.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="tagSource">The source of tags to add as children.</param>
        /// <returns>
        /// The parent tag
        /// </returns>
        public static T AppendHtml<T>(this T tag, ITagSource tagSource) where T : HtmlTag
        {
            tag.Append(tagSource);
            return tag;
        }

        /// <summary>
        /// Creates nested child tags, runs <paramref name="configuration"/> on the innermost tag, and returns the tag on which the method was called. Use <see cref="HtmlTag.Add(string, Action{HtmlTag})"/> if you want to return the innermost tag.
        /// </summary>
        /// <returns>The parent tag</returns>
        public static T Append<T>(this T tag, string tagNames, Action<HtmlTag> configuration) where T : HtmlTag
        {
            tag.Append(tagNames, configuration);
            return tag;
        }

        /// <summary>
        /// Adds all tags from <paramref name="tagSource" /> as children of the current tag. Returns the parent tag.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="tagSource">The source of tags to add as children.</param>
        /// <returns>
        /// The parent tag
        /// </returns>
        public static T Append<T>(this T tag, ITagSource tagSource) where T : HtmlTag
        {
            tag.Append(tagSource);
            return tag;
        }
        
        /// <summary>
        /// Adds a sequence of tags as children of the current tag. Returns the parent tag.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="tags">A sequence of tags to add as children.</param>
        /// <returns>
        /// The parent tag
        /// </returns>
        public static T Append<T>(this T tag, IEnumerable<HtmlTag> tags) where T : HtmlTag
        {
            tag.Append(tags);
            return tag;
        }


        public static T Attr<T>(this T tag, string attribute, object value) where T : HtmlTag
        {
            tag.Attr(attribute, value);
            return tag;
        }
        
        public static T UnencodedAttr<T>(this T tag, string attribute, object value) where T : HtmlTag
        {
            tag.UnencodedAttr(attribute, value);
            return tag;
        }

        public static T RemoveAttr<T>(this T tag, string attribute) where T : HtmlTag
        {
            tag.RemoveAttr(attribute);
            return tag;
        }

        public static T Title<T>(this T tag, string title) where T : HtmlTag
        {
            tag.Title(title);
            return tag;
        }

        /// <summary>
        /// Adds one or more classes (separated by spaces) to the tag
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="className">Valid CSS class name, JSON object, JSON array, or multiple valid CSS class names separated by spaces</param>
        /// <returns>
        /// The tag for method chaining
        /// </returns>
        /// <exception cref="System.ArgumentException">One or more CSS class names were invalid (contained invalid characters)</exception>
        public static T AddClass<T>(this T tag, string className) where T : HtmlTag
        {
            tag.AddClass(className);
            return tag;
        }

        public static T BooleanAttr<T>(this T tag, string attribute) where T : HtmlTag
        {
            tag.BooleanAttr(attribute);
            return tag;
        }

        public static T AddClasses<T>(this T tag, IEnumerable<string> classes) where T : HtmlTag
        {
            tag.AddClasses(classes);
            return tag;
        }

        public static T AddClasses<T>(this T tag, params string[] classes) where T : HtmlTag
        {
            tag.AddClasses(classes);
            return tag;
        }

        public static T RemoveClass<T>(this T tag, string @class) where T : HtmlTag
        {
            tag.RemoveClass(@class);
            return tag;
        }

        public static T Style<T>(this T tag, string key, string value) where T : HtmlTag
        {
            tag.Style(key, value);
            return tag;
        }

        public static T Name<T>(this T tag, string name) where T : HtmlTag
        {
            tag.Name(name);
            return tag;
        }

        public static T Value<T>(this T tag, string value) where T : HtmlTag
        {
            tag.Value(value);
            return tag;
        }

        public static T TextIfEmpty<T>(this T tag, string defaultText) where T : HtmlTag
        {
            tag.TextIfEmpty(defaultText);
            return tag;
        }

        public static T Modify<T>(this T tag, Action<HtmlTag> action) where T : HtmlTag
        {
            tag.Modify(action);
            return tag;
        }

        /// <summary>
        /// Inserts a sibling tag immediately after the current tag. Any existing sibling will follow the inserted tag.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="nextTag">The tag to add as a sibling</param>
        /// <returns>
        /// The original tag
        /// </returns>
        public static T After<T>(this T tag, HtmlTag nextTag) where T : HtmlTag
        {
            tag.After(nextTag);
            return tag;
        }
        
        public static T Hide<T>(this T tag) where T : HtmlTag
        {
            tag.Hide();
            return tag;
        }
        
        public static T TagName<T>(this T @this, string tag) where T : HtmlTag
        {
            @this.TagName(tag);
            return @this;
        }
        
        public static T Render<T>(this T tag, bool shouldRender) where T : HtmlTag
        {
            tag.Render(shouldRender);
            return tag;
        }
        
        public static T RenderFromTop<T>(this T tag) where T : HtmlTag
        {
            tag.RenderFromTop();
            return tag;
        }
        
        public static T Authorized<T>(this T tag, bool isAuthorized) where T : HtmlTag
        {
            tag.Authorized(isAuthorized);
            return tag;
        }

        /// <summary>
        /// Stores a value in an HTML5 custom data attribute
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="key">The name of the data attribute. Will have "data-" prepended when rendered.</param>
        /// <param name="value">The value to store. Non-string values will be JSON</param>
        /// <returns>
        /// The calling tag.
        /// </returns>
        public static T Data<T>(this T tag, string key, object value) where T : HtmlTag
        {
            tag.Data(key, value);
            return tag;
        }

        /// <summary>
        /// Modifies an existing reference value stored in an HTML5 custom data
        /// </summary>
        /// <typeparam name="T">The type of the data stored in the given location</typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="key">The name of the data storage location</param>
        /// <param name="configure">The action to perform on the currently stored value</param>
        /// <returns>
        /// The calling tag.
        /// </returns>
        public static T Data<T>(this T tag, string key, Action<T> configure) where T : HtmlTag
        {
            tag.Data(key, configure);
            return tag;
        }

        public static T BuildAttr<T>(this T tag, string attribute, object value, bool encode = true) where T : HtmlTag
        {
            tag.BuildAttr(attribute, value, encode);
            return tag;
        }

        /// <summary>
        /// Stores multiple JSON-encoded key/value pairs in a the "data-__" attribute. Useful when used with the jquery.metadata plugin
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tag">The tag.</param>
        /// <param name="key">The name of the stored value</param>
        /// <param name="value">The value to store</param>
        /// <returns>
        /// The calling tag.
        /// </returns>
        /// <remarks>
        /// You need to configure the the jquery.metadata plugin to read from the data-__ attribute.
        /// Add the following line after you have loaded jquery.metadata.js, but before you use its metadata() method:
        /// <code>
        /// if ($.metadata) {
        /// $.metadata.setType('attr', 'data-__');
        /// }
        /// </code>
        /// </remarks>
        public static T MetaData<T>(this T tag, string key, object value) where T : HtmlTag
        {
            tag.MetaData(key, value);
            return tag;
        }
        

    }
}