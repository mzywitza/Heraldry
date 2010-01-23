using System;

namespace Heraldry.Storage
{
	/// <summary>
	/// Stores a message in a database
	/// </summary>
	public class Message
	{
		private string _content;
		private DateTime _published;
		private DateTime _created;

		/// <summary>
		/// Default constructor
		/// </summary>
		public Message()
		{
		}

		/// <summary>
		/// Constructs a message with the given content
		/// </summary>
		/// <param name="content">The message's content</param>
		public Message(string content)
		{
			_content = content;
		}

		/// <summary>
		/// Constructs a message with a given content and publishing
		/// date.
		/// </summary>
		/// <param name="content">The content of the message</param>
		/// <param name="published">The time when the message is published</param>
		public Message(string content, DateTime published) : this(content)
		{
			_published = published;
		}

		/// <summary>
		/// Constructs a message with a given content and publishing
		/// date.
		/// </summary>
		/// <param name="content">The content of the message</param>
		/// <param name="published">The time when the message is published</param>	
		/// <param name="created">The time when the message was created</param>
		public Message(string content, DateTime published, DateTime created) : this(content, published)
		{
			_created = created;
		}

		/// <summary>
		/// The full content of the string
		/// </summary>
		public string Content
		{
			get {
				return _content;
			}
		}

		/// <summary>
		/// The time the message was published
		/// </summary>
		public DateTime Published
		{
			get {
				return _published;
			}
		}

		/// <summary>
		/// The time the message was created.
		/// </summary>
		public DateTime Created
		{
			get {
				return _created;
			}
		}
	}
}