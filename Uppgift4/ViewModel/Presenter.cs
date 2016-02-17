using System;
using System.Collections.Generic;
using System.Windows.Input;
using Uppgift4.Models;

namespace Uppgift4.ViewModel
{
    public class Presenter : ObservableObject
    {
        private string _sender = "Linus";
        private BaseMessage _selectedMessage;

        private Settings _settings;
        private Contacts _contacts;
        private Messages _messages;

        public string Sender
        {
            get { return _sender; }
            set
            {
                _sender = value;

                RaisePropertyChangedEvent("Sender");
            }
        }

        public Messages Messages
        {
            get { return _messages; }
            set
            {
                _messages = value;

                RaisePropertyChangedEvent("Messages");
            }
        }

        public BaseMessage SelectedMessage
        {
            get { return _selectedMessage; }
            set
            {
                _selectedMessage = value;

                RaisePropertyChangedEvent("SelectedMessage");
            }
        }

        public Presenter()
        {
            string[] files = { "settings.json", "contacts.xml", "messages.bin" };

            _settings = JsonSerialization.ReadFromJsonFile<Settings>(files[0]);
            _contacts = XmlSerialization.ReadFromXmlFile<Contacts>(files[1]);
            _messages = BinarySerialization.ReadFromBinaryFile<Messages>(files[2]);
        }

        // A new ICommand that corresponds to the Data Binding
        // of the same name
        public ICommand CloseCommand
        {
            // When clicked delegate that command to a function
            get { return new DelegateCommand(CloseApplication); }
        }

        public ICommand MaximizeCommand
        {
            get { return new DelegateCommand(MaximizeApplication); }
        }

        public ICommand MinimizeCommand
        {
            get { return new DelegateCommand(MinimizeApplication); }
        }

        public ICommand MessagesCommand
        {
            get { return new DelegateCommand(MessagesWindow); }
        }

        public ICommand RemoveCommand
        {
            get { return new DelegateCommand(RemoveMessage); }
        }

        public void RemoveMessage()
        {
            _messages
        }

        private void MessagesWindow()
        {
            //System.Windows.Application.Current.Windows[1].Show();
        }

        private void CloseApplication()
        {
            System.Environment.Exit(0);
        }

        private void MaximizeApplication()
        {
            if (System.Windows.Application.Current.MainWindow.WindowState == System.Windows.WindowState.Maximized)
                System.Windows.Application.Current.MainWindow.WindowState = System.Windows.WindowState.Normal;
            else
                System.Windows.Application.Current.MainWindow.WindowState = System.Windows.WindowState.Maximized;
        }

        private void MinimizeApplication()
        {
            System.Windows.Application.Current.MainWindow.WindowState = System.Windows.WindowState.Minimized;
        }
    }
}
