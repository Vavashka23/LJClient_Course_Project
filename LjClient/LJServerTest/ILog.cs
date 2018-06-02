namespace ClientLiveJornal
{
    public interface ILog
	{
		void Write(string text);
		void WriteLine(string text);
		void Clear();
	}
}