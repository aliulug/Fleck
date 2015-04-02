namespace Fleck.Ada
{
	public interface IMessageCounter
	{
		void ProcessMessage(object message);
		void Reset();
		int NumberOfUserMessages { get; }
		int NumberOfAdminMessages { get; }
	}
}
