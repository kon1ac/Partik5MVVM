using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFMagicPartik5MVVM
{
    /// <summary>
    /// Логика взаимодействия для MainViewModel.xaml
    /// </summary>
    public partial class MainViewModel : Window
    {
        public ObservableCollection<NoteModel> Notes { get; set; }
        private int _currentNoteIndex;
        public int CurrentNoteIndex
        {
            get { return _currentNoteIndex; }
            set
            {
                _currentNoteIndex = value;
                OnPropertyChanged(nameof(CurrentNoteIndex));
                OnPropertyChanged(nameof(SelectedNote));
            }
        }

        public NoteModel SelectedNote => Notes[CurrentNoteIndex];

        public MainViewModel()
        {
            Notes = new ObservableCollection<NoteModel>
        {
            new NoteModel { Name = "Сходить за пивом", Description = "Мне нужно 7 литров пива", Date = new DateTime(2023, 10, 20), Deadline = new DateTime(2023, 10, 22).AddDays(1) },
            new NoteModel { Name = "Купить блок сигарет", Description = "У меня кончились сигареты, бегом восполнять потерю", Date = new DateTime(2023, 10, 22), Deadline = new DateTime(2023, 10, 23).AddDays(1) },
            new NoteModel { Name = "Купить жижу, никобустер и испаритель", Description = "На моей курилке полетел испар и кончилось жижло", Date = new DateTime(2023, 10, 24), Deadline = new DateTime(2023, 10, 25).AddDays(1) },
            new NoteModel { Name = "Сгонять за шайбой снюсика", Description = "Друзья посоветовали новую линейку снюсика, надо попробовать", Date = new DateTime(2023, 10, 26), Deadline = new DateTime(2023, 10, 28).AddDays(1) },
            new NoteModel { Name = "Встретиться с кентафариком", Description = "Давненько не виделись с Бро, надо исправить", Date = new DateTime(2023, 11, 3), Deadline = new DateTime(2023, 11, 7).AddDays(1) }
        };
            CurrentNoteIndex = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
