// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Report report = new Report(new BetterMailSender());
Report report2 = new Report(new WhatsAppSender());

report.SendReport();
report2.SendReport();


public class Report
{
    ISender sender;

    public Report(ISender sender)
    {
        this.sender = sender;
    }
    public void SendReport()
    {
       
        sender.Send();
    }
}

public interface ISender
{
    void Send();
}

public class MailSender : ISender
{
   public void Send()
    {
        Console.WriteLine("mail gönderildi");
    }
}

public class BetterMailSender: MailSender
{

}

public class WhatsAppSender : ISender
{
    public void Send()
    {
        Console.WriteLine("whatsapp'dan gönderildi");
    }
}
