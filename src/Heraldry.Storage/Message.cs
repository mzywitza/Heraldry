using System;

namespace Heraldry.Storage
{
	using Messages;

	/// <summary>
	/// Stores a message in a database
	/// </summary>
	public class Message
	{
		private string _content;
		private DateTime _published;
		private DateTime _created;

		/// <summary>
		/// Default constructor for ORM-use only.
		/// </summary>
		protected Message()
		{
		}

		/// <summary>
		/// Creates a Message from a given rawMessage, setting the
		/// <see cref="Published"/> property to the actual time.
		/// </summary>
		/// <param name="rawMessage">
		/// The raw message to construct the message from.
		/// </param>
		public Message(IRawMessage rawMessage) :this(rawMessage,DateTime.Now)
		{
		}

		/// <summary>
		/// Creates a Message from a given rawMessage and publishing time.
		/// </summary>
		/// <param name="rawMessage">
		/// The raw message to construct the message from.
		/// </param>
		/// <param name="publishTime">The time of publishing</param>
		public Message(IRawMessage rawMessage, DateTime publishTime)
		{
			if (publishTime < rawMessage.CreatedAt)
			{
				throw new ArgumentException("publishTime must not be older than the time of creating the message.", "publishTime");
			}
			_content = rawMessage.Content;
			_created = rawMessage.CreatedAt;
			_published = publishTime;
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