// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TagList.cs" company="Simon Paramore">
// © 2020, Simon Paramore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Furysoft.TagList
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The Tag List.
    /// </summary>
    public sealed class TagList : List<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagList" /> class.
        /// </summary>
        /// <param name="tagListType">Type of the tag list.</param>
        public TagList(TagListType tagListType)
        {
            this.TagListType = tagListType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagList" /> class.
        /// </summary>
        /// <param name="tagListType">Type of the tag list.</param>
        public TagList(string tagListType)
        {
            this.TagListType = (TagListType)Enum.Parse(typeof(TagListType), tagListType);
        }

        /// <summary>Gets the type of the tag list.</summary>
        public TagListType TagListType { get; }
    }
}