using System.Collections.Generic;
using System.Linq;

namespace when_compiler_bug
{
    internal interface IInputElement
    {
    }

    internal class FrameworkElement : IInputElement
    {
        public object DataContext { get; set; }
    }

    internal class ListBox : FrameworkElement
    {
        public List<object> SelectedItems { get; set; }
    }

    internal class ListBoxItem : FrameworkElement
    {
    }

    internal class FolderViewModel
    {
        public bool CanDelete { get; set; }
        public object Folder { get; set; }
    }

    internal static class Reproduce
    {
        public static void Run(IInputElement inputElement)
        {
            switch (inputElement)
            {
                case FrameworkElement { DataContext: FolderViewModel { CanDelete: true, Folder: { } } f2 }
                    when ShouldCancel(f2):
                    // ...
                    break;
                case ListBox box when box.SelectedItems.OfType<FolderViewModel>().Any(folder => folder.Folder != null):
                    // ...
                    break;
                case ListBoxItem { DataContext: FolderViewModel { CanDelete: true, Folder: { } } }:
                    // ...
                    break;
                case FrameworkElement { DataContext: FolderViewModel { CanDelete: true, Folder: { } } f2 }:
                    // ...
                    break;
            }
        }

        private static bool ShouldCancel(params FolderViewModel[] folder)
        {
            return false;
        }
    }

    internal class Program
    {
        public void Main(string[] args)
        {
            Reproduce.Run(new ListBoxItem());
        }
    }
}