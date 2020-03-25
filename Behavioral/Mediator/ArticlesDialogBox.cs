using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ArticlesDialogBox : DialogBox
    {
        private readonly ListBox _articlesListBox;
        private readonly TextBox _titleTextBox;
        private readonly Button _saveButton;

        public ArticlesDialogBox()
        {
            _articlesListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
        }

        public void SimulateUserInteraction()
        {
            _articlesListBox.Selection = "Article 1";

            //_titleTextBox.Content = string.Empty;

            Console.WriteLine($"TextBox {_titleTextBox.Content}");
            Console.WriteLine($"Button {_saveButton.IsEnabled}");
        }

        public override void Changed(UIControl control)
        {
            if (control == _articlesListBox)
            {
                ArticleSelected();
            }
            else if (control == _titleTextBox)
            {
                TitleChanged();
            }
        }

        private void TitleChanged()
        {
            var isEmpty = string.IsNullOrEmpty(_titleTextBox.Content);

            _saveButton.IsEnabled = !isEmpty;
        }

        private void ArticleSelected()
        {
            _titleTextBox.Content = _articlesListBox.Selection;

            _saveButton.IsEnabled = true;
        }
    }
}
