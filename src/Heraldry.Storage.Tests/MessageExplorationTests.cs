namespace Heraldry.Storage.Tests
{
	using System;
	using NUnit.Framework;

	[TestFixture]
	public class MessageExplorationTests
	{
		[Test]
		public void MessageClassExists()
		{
			var msg = new Message();
		}

		[Test]
		public void MessageCanHoldAString()
		{
			var msg = new Message("content");
		}

		[Test]
		public void MessageHasAContentProperty()
		{
			var msg = new Message("content");
			Assert.That(msg.Content, Is.EqualTo("content"));
		}

		[Test]
		public void MessageHasAPublishedProperty()
		{
			var published = DateTime.Now;
			var msg = new Message("content", published);
			Assert.That(msg.Published, Is.EqualTo(published));
			Assert.That(msg.Content, Is.EqualTo("content"));
		}

		[Test]
		public void MessageHasACreatedProperty()
		{
			var published = DateTime.Now;
			var created = published.AddMinutes(-1);
			var msg = new Message("content", published, created);
			Assert.That(msg.Created, Is.EqualTo(created));
			Assert.That(msg.Published, Is.EqualTo(published));
			Assert.That(msg.Content, Is.EqualTo("content"));
		}


	}
}