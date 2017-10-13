namespace WebRequestJson
{
    public interface IClient
    {
        T Get<T>(string url);
    }
}
