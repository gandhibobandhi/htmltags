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

        public static T NoClosingTag<T>(this T tag) where T : HtmlTag
        {
            tag.NoClosingTag();
            return tag;
        }

        public static T NoTag<T>(this T tag) where T : HtmlTag
        {
            tag.NoTag();
            return tag;
        }

        public static T Append<T>(this T tag, HtmlTag child) where T : HtmlTag
        {
            tag.Append(child);
            return tag;
        }

        public static T Append<T>(this T tag, string tagNames) where T : HtmlTag
        {
            tag.Append(tagNames);
            return tag;
        }

        public static T Append<T>(this T tag, string tagNames, Action<HtmlTag> configuration) where T : HtmlTag
        {
            tag.Append(tagNames, configuration);
            return tag;
        }

        public static T Append<T>(this T tag, TagList tags) where T : HtmlTag
        {
            tag.Append(tags);
            return tag;
        }

        public static T Append<T>(this T tag, params HtmlTag[] tags) where T : HtmlTag
        {
            tag.Append(tags);
            return tag;
        }

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

        public static T AddClass<T>(this T tag, string @class) where T : HtmlTag
        {
            tag.AddClass(@class);
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

        public static T Modify<T>(this T tag, Action<HtmlTag> action) where T : HtmlTag
        {
            tag.Modify(action);
            return tag;
        }

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

        public static T Data<T>(this T tag, string key, object value) where T : HtmlTag
        {
            tag.Data(key, value);
            return tag;
        }
        
        public static T MetaData<T>(this T tag, string key, object value) where T : HtmlTag
        {
            tag.MetaData(key, value);
            return tag;
        }
        

    }
}