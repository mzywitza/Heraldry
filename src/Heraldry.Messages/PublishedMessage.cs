namespace Heraldry.Messages
{
	using System;

	/// <summary>
	/// Default implementation of <see cref="IPublishedMessage"/>.
	/// </summary>
	public class PublishedMessage :IPublishedMessage
	{
		/// <summary>
		/// The message's content
		/// </summary>
		public string Content { get; set; }

		/// <summary>
		/// The time the message was created.
		/// </summary>
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// The message's categories.
		/// </summary>
		public string[] Categories { get; set; }

		/// <summary>
		/// The name of the message sender. This information
		/// is extracted from the raw message. A user-friendly
		/// name is used here (display name)
		/// </summary>
		public string CreatedBy { get; set; }

		/// <summary>
		/// The time the message was received by the Heraldry server
		/// for publishing. Due to offline support, messages can be
		/// created when there is no connection available and not published
		/// until hours later when the connection is available again.
		/// </summary>
		public DateTime PublishedAt { get; set; }
	}
}