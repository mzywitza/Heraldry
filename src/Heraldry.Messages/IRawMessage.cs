namespace Heraldry.Messages
{
	using System;
	using NServiceBus;

	/// <summary>
	/// A raw message is a message that is send from the initial
	/// sender to the publishing server.
	/// </summary>
	public interface IRawMessage : IMessage 
	{
		/// <summary>
		/// The message's content
		/// </summary>
		string Content { get; set; }

		/// <summary>
		/// The time the message was created.
		/// </summary>
		DateTime CreatedAt { get; set; }

		/// <summary>
		/// The message's categories.
		/// </summary>
		string[] Categories { get; set; }
	}
}