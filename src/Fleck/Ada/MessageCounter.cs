namespace Fleck.Ada
{
	public class MessageCounter : IMessageCounter
	{
		private static volatile int _numberOfUserMessages;
		private static volatile int _numberOfAdminMessages;

		private MessageCounter()
		{
			
		}
		
		public static MessageCounter Create()
		{
			return new MessageCounter();
		}

		public int NumberOfUserMessages
		{
			get { return _numberOfUserMessages; }
		}
		public int NumberOfAdminMessages
		{
			get { return _numberOfAdminMessages; }
		}

		public void Reset()
		{
			_numberOfUserMessages = 0;
			_numberOfAdminMessages = 0;
		}

		public void ProcessMessage(object message)
		{
			if (message is string && message.ToString().Contains("Abonelik başarılı"))
				_numberOfAdminMessages++;
			else
				_numberOfUserMessages++;
		}
	}
}

