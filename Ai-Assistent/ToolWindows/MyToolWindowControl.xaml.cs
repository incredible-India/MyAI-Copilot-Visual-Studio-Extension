using System.Windows;
using System.Windows.Controls;

namespace Ai_Assistent
{
    public partial class MyToolWindowControl : UserControl
    {
        public MyToolWindowControl()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ChatInput.Text))
            {
                var message = new TextBlock { Text = ChatInput.Text, Margin = new Thickness(0, 5, 0, 0) };
                ChatMessages.Children.Add(message);
                ChatInput.Clear();
                ChatInput.Focus();
            }
        }

        private void ChatInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Optional: Adjust the height of the TextBox based on the content
            ChatInput.Height = Double.NaN; // Reset to auto
          //  ChatInput.Height = ChatInput.LineCount * ChatInput.FontSize + 5; // Adjust height
        }
    }
}