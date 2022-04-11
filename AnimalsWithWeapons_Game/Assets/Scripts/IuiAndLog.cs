using UnityEngine.UI;
using TMPro;
interface IuiAndLog
{
    public void WriteToUI(string LogText);

    public void WriteToLog(string Announcement);
}


public class UIAndLogUsage : IuiAndLog
{
    public TextMeshProUGUI UITextAnnouncement;

    public void WriteToLog(string LogText)
    {
        
    }

    public void WriteToUI(string Announcement)
    {
        UITextAnnouncement.text = Announcement;

        WriteToLog(Announcement);
    }

}