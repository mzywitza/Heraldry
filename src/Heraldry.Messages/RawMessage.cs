namespace Heraldry.Messages
{
	using System;

	/// <summary>
	/// Default implementation of <see cref="IRawMessage"/>.
	/// </summary>
	public class RawMessage :IRawMessage
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
	}
}