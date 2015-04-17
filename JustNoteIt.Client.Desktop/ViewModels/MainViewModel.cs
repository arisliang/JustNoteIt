using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustNoteIt.Client.Desktop.ViewModels
{
    public class MainViewModel : PropertyChangedBase
    {
        #region fields and properties
        public const string WindowTitleDefault = "So. Just Note It.";

        private string _windowTitle = WindowTitleDefault;

        public string WindowTitle
        {
            get
            {
                return _windowTitle;
            }
            set
            {
                _windowTitle = value;
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }

        #endregion

        #region dependencies
        private JournalViewModel _journaVM = null;
        public JournalViewModel JournalVM
        {
            get
            {
                return _journaVM;
            }
            set
            {
                _journaVM = value;
                NotifyOfPropertyChange(() => JournalVM);
            }
        }

        #endregion

        #region constructor
        public MainViewModel(JournalViewModel jvm)
        {
            _journaVM = jvm;
        }

        #endregion
    }
}
