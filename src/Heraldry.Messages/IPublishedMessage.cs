namespace Heraldry.Messages
{
	using System;

	/// <summary>
	/// A published message is created by the server from a raw 
	/// message.
	/// </summary>
	public interface IPublishedMessage : IRawMessage
	{
		/// <summary>
		/// The name of the message sender. This information
		/// is extracted from the raw message. A user-friendly
		/// name is used here (display name)
		/// </summary>
		string CreatedBy { get; set; }

		/// <summary>
		/// The time the message was received by the Heraldry server
		/// for publishing. Due to offline support, messages can be
		/// created when there is no connection available and not published
		/// until hours later when the connection is available again.
		/// </summary>
		DateTime PublishedAt { get; set; }
	}
}