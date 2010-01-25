namespace Heraldry.Storage.Tests
{
	using System;
	using Messages;
	using NUnit.Framework;

	[TestFixture]
	public class MessageExplorationTests
	{
		private readonly string _content = "Message";
		private readonly DateTime _createdAt = DateTime.Now.AddMinutes(-1);
		private readonly string[] _categories = new[] {"test", "heraldry"};
		private IRawMessage _rawMessage;

		[SetUp]
		public void Setup()
		{
			_rawMessage = new RawMessage()
			              	{
			              		Content = _content,
			              		CreatedAt = _createdAt,
			              		Categories = _categories
			              	};
		}

		[Test]
		public void MessageClassExists()
		{
			Assert.That(typeof(Message),Is.Not.Null);
		}

		[Test]
		public void MessageCanBeCreatedFromARawMessage()
		{
			var msg = new Message(_rawMessage);

			Assert.That(msg.Content, Is.EqualTo(_content));
			Assert.That(msg.Created, Is.EqualTo(_createdAt));
		}

		[Test]
		public void MessageCreatedWithoutPublishedTimeUsesActualTime()
		{
			var msg = new Message(_rawMessage);

			Assert.That(msg.Published, Is.EqualTo(DateTime.Now).Within(10).Milliseconds);
		}

		[Test]
		public void MessageAllowsToSetThePublishedTimeExplicitly()
		{
			var msg = new Message(_rawMessage, DateTime.Now);
			Assert.That(msg.Published, Is.EqualTo(DateTime.Now).Within(10).Milliseconds);
		}

		[Test]
		public void MessageDoesntAllowPublishingBeforeTheMessageWasCreated()
		{
			var ex = Assert.Throws<ArgumentException>(() => new Message(_rawMessage, _rawMessage.CreatedAt.AddMinutes(-2)));
			Assert.That(ex.ParamName, Is.EqualTo("publishTime"));
		}



	}
}