using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShellPresentationModeTest;

public class NewTabPageViewModel:INotifyPropertyChanged
{
    private string title = "";
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (value != title)
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
    }
    public string Name { get; set; }

    public NewTabPageViewModel()
    {
        Title = "Hello";
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
