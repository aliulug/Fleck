namespace Fleck.Ada
{
	public interface IMessageCounter
	{
		/// <summary>
		/// Adds the message to the counting
		/// </summary>
		/// <param name="message"></param>
		void ProcessMessage<T>(T message);
		/// <summary>
		/// Resets the counting
		/// </summary>
		void Reset();
		int NumberOfUserMessages { get; }
		int NumberOfAdminMessages { get; }
	}
}
