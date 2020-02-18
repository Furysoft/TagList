// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TagList.cs" company="Simon Paramore">
// © 2020, Simon Paramore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Furysoft.TagList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// The Tag List.
    /// </summary>
    [DataContract]
    public sealed class TagList : ICollection<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagList" /> class.
        /// </summary>
        public TagList()
        {
            this.InnerList = new List<string>();
            this.TagListType = TagListType.And;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagList" /> class.
        /// </summary>
        /// <param name="tagListType">Type of the tag list.</param>
        public TagList(TagListType tagListType)
        {
            this.InnerList = new List<string>();
            this.TagListType = tagListType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagList" /> class.
        /// </summary>
        /// <param name="tagListType">Type of the tag list.</param>
        /// <param name="collection">The collection.</param>
        public TagList(TagListType tagListType, IEnumerable<string> collection)
        {
            this.InnerList = new List<string>(collection);
            this.TagListType = tagListType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagList" /> class.
        /// </summary>
        /// <param name="tagListType">Type of the tag list.</param>
        /// <param name="capacity">The capacity.</param>
        public TagList(TagListType tagListType, int capacity)
        {
            this.InnerList = new List<string>(capacity);
            this.TagListType = tagListType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagList" /> class.
        /// </summary>
        /// <param name="tagListType">Type of the tag list.</param>
        public TagList(string tagListType)
        {
            this.InnerList = new List<string>();
            this.TagListType = (TagListType)Enum.Parse(typeof(TagListType), tagListType);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagList" /> class.
        /// </summary>
        /// <param name="tagListType">Type of the tag list.</param>
        /// <param name="collection">The collection.</param>
        public TagList(string tagListType, IEnumerable<string> collection)
        {
            this.InnerList = new List<string>(collection);
            this.TagListType = (TagListType)Enum.Parse(typeof(TagListType), tagListType);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagList" /> class.
        /// </summary>
        /// <param name="tagListType">Type of the tag list.</param>
        /// <param name="capacity">The capacity.</param>
        public TagList(string tagListType, int capacity)
        {
            this.InnerList = new List<string>(capacity);
            this.TagListType = (TagListType)Enum.Parse(typeof(TagListType), tagListType);
        }

        /// <inheritdoc />
        public int Count => this.InnerList.Count;

        /// <inheritdoc />
        public bool IsReadOnly => false;

        /// <summary>Gets the type of the tag list.</summary>
        [DataMember(Name = "TagListType", Order = 1)]
        public TagListType TagListType { get; private set; }

        /// <summary>Gets or sets the inner list.</summary>
        [DataMember(Name = "InnerList", Order = 2)]
        private List<string> InnerList { get; set; }

        /// <inheritdoc />
        public void Add(string item) => this.InnerList.Add(item);

        /// <inheritdoc />
        public void Clear() => this.InnerList.Clear();

        /// <inheritdoc />
        public bool Contains(string item) => this.InnerList.Contains(item);

        /// <inheritdoc />
        public void CopyTo(string[] array, int arrayIndex) => this.InnerList.CopyTo(array, arrayIndex);

        /// <inheritdoc />
        public IEnumerator<string> GetEnumerator() => this.InnerList.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => this.InnerList.GetEnumerator();

        /// <inheritdoc />
        public bool Remove(string item) => this.InnerList.Remove(item);
    }
}