interface IuiAndLog
{
    public void WriteToUI();

    public void WriteToLog();
}


public class UIAndLogUsage : IuiAndLog
{
    public void WriteToLog()
    {
        throw new System.NotImplementedException();
    }

    public void WriteToUI()
    {
        throw new System.NotImplementedException();
    }
}