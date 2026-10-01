namespace ContractsLab3;

// Writes shelf count records to a file and safely closes the log.
public class CountLog : IDisposable
{
    private StreamWriter _writer;
    private string _path;
    private int _count;
    private bool _isClosed;

    public string Path
    {
        get { return _path; }
    }

    public int Count
    {
        get { return _count; }
    }

    public bool IsClosed
    {
        get { return _isClosed; }
    }

    public CountLog(string path)
    {
        _path = path;
        _writer = new StreamWriter(path);

        _writer.WriteLine("LOG OPENED");

        _count = 0;
        _isClosed = false;
    }

    public void Write(ShelfCount record)
    {
        _count++;

        _writer.WriteLine(
            String.Format("{0,3} {1}", Count, record)
            );
    }

    public void Dispose()
    {
        if (_isClosed)
        {
            return;
        }

        try
        {
            _writer.WriteLine(
                String.Format("LOG CLOSED, {0} lines written", Count)
                );

            _writer.Close();
        }
        catch
        {
            try
            {
                _writer.Close();
            }
            catch
            {

            }
        }

        _isClosed = true;
    }
}