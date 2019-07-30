using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massenger
{
    public delegate void EventDelegate();

    public class EventClass
    {
        public event EventDelegate SomeEvent;

        public void OnSomeEvent()
        {
            SomeEvent();
        }
    }

    public class Handler1
    {
        public static void PrintText()
        {
            Console.WriteLine("handler1");
        }
    }

    public class Handler2
    {
        public static void PrintText()
        {
            Console.WriteLine("handler2");
        }
    }
    public class MailMessageEventArgs : EventArgs
    {
        private string _from;
        private string _to;
        private string _text;

        public string From
        {
            get => _from;
        }

        public string To
        {
            get => _to;
        }

        public string Text
        {
            get => _text;
        }

        public MailMessageEventArgs(string from, string to, string text)
        {
            this._from = from;
            this._to = to;
            this._text = text;
        }
    }

    public delegate void MailDelegate(Object sender, MailMessageEventArgs args);

    public class Messanger
    {
        public event MailDelegate NewMailSent;

        protected virtual void OnNewMailSent(MailMessageEventArgs args)
        {
            NewMailSent(this, args);
        }

        public void SendNewMail(string from, string to, string text)
        {
            MailMessageEventArgs args = new MailMessageEventArgs(from, to, text);
            OnNewMailSent(args);
        }


    }
    public class Fax
    {
        private readonly Messanger messanger;

        public Fax(Messanger messanger)
        {
            this.messanger = messanger;
            this.messanger.NewMailSent += FaxMessage;
        }

        public void FaxMessage(Object sender, MailMessageEventArgs args)
        {
            Console.WriteLine($"From: {args.From}\n To: {args.To}\n Text: {args.Text}");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //EventClass ec = new EventClass();
            //ec.SomeEvent += new EventDelegate(Handler1.PrintText);
            //ec.SomeEvent += Handler2.PrintText;
            //ec.SomeEvent += () => Console.WriteLine("Lamda handler");

            //for(int i =0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i % 5 == 0)
            //    {
            //        ec.OnSomeEvent();
            //    }
            //    if (i  == 10)
            //    {
            //        ec.SomeEvent-= new EventDelegate(Handler1.PrintText);
            //    }
            //    Thread.Sleep(2000);
            //}

            Messanger messanger = new Messanger();
            Fax fax = new Fax(messanger);
            messanger.SendNewMail("fromAddress", "toAddress", "someText");
        }
    }
}
