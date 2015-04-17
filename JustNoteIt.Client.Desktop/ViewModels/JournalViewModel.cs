using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JustNoteIt.Client.Desktop.ViewModels
{
    public class JournalViewModel : PropertyChangedBase
    {
        #region fields and properties
        private bool _canDisplayNote;
        /// <summary>
        /// Indicates whether or not the Note can be displayed.
        /// </summary>
        public bool CanDisplayNote
        {
            get
            {
                return _canDisplayNote;
            }
            set
            {
                _canDisplayNote = value;
                NotifyOfPropertyChange(() => CanDisplayNote);
                NotifyOfPropertyChange(() => NoteVisibility);
            }
        }

        /// <summary>
        /// Indicate whether the note label is visible.
        /// </summary>
        public Visibility NoteVisibility
        {
            get
            {
                return CanDisplayNote ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private string _note = string.Empty;
        /// <summary>
        /// The Journal's Note.
        /// </summary>
        public string Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
                NotifyOfPropertyChange(() => Note);
            }
        }

        private string _noteDisplay = string.Empty;
        /// <summary>
        /// The note to display.
        /// </summary>
        public string NoteDisplay
        {
            get
            {
                return _noteDisplay;
            }
            set
            {
                _noteDisplay = value;
                NotifyOfPropertyChange(() => NoteDisplay);
            }
        }

        #endregion

        #region public methods
        public void DisplayNote()
        {
            NoteDisplay = Note;
        }

        #endregion
    }
}
