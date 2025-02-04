using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TextEditing.Classes
{
    internal class TextEditable
    {
        private List<TextLine> _lines;
        private int _active_line = 0;
        private int _cursor_at = 0;

        public void Edit(int atLine = 0, int cursorAt = 0)
        {
            // setup
            _active_line = atLine;
            _cursor_at = cursorAt;

            // continue till the user exits
            bool userExit = false;
            while (!userExit)
            {
                
            }
        }

        private bool EditOneLine()
        {
            // display the active line

                // Lines Bar

                // Item Name

                // Line Contents

                // Set Cursor

            // continue till the user changes lines
            int line = _active_line;
            while (line == _active_line)
            {
                // if user exits
                if (EditOneKey())
                {
                    return true;
                }
            }
        }

        private bool EditOneKey()
        {
            // get key
            ConsoleKeyInfo keyInfo = Console.ReadKey();
      
            // use key
            if (char.IsAscii(keyInfo.KeyChar))
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        break;
                    case ConsoleKey.Tab:
                        break;
                    case ConsoleKey.Backspace:
                        break;
                    case ConsoleKey.Delete:
                        break;
                    default:
                        break;
                }
            }

            // update console
        }

        private void DisplayToolbar(int highlightedIndex)
        {
            StringBuilder sb = new StringBuilder();

            if(highlightedIndex > 1)
            {
                sb.Append($".{highlightedIndex - 1}. ");
            }

            if(highlightedIndex > 0)
            {
                string preTitle = _lines[highlightedIndex - 1].Title;
                if (preTitle.Length > 4)
                {
                    preTitle = $"{preTitle.Substring(0, 3)}+";
                }
                sb.Append($"{preTitle} ");
            }

            string selectedTitle = _lines[highlightedIndex].Title;
            sb.Append(selectedTitle);

            if(highlightedIndex < _lines.Count - 2)
            {
                string postTitle = _lines[highlightedIndex + 1].Title;
                if (postTitle.Length > 4)
                {
                    postTitle = $"{postTitle.Substring(0, 3)}+";
                }
                sb.Append($" {postTitle}");
            }

            if(highlightedIndex < _lines.Count - 1)
            {
                sb.Append($" .{_lines.Count - (highlightedIndex + 2)}.");
            }

            string bar = sb.ToString();

            Console.WriteLine(bar);
        }

        private void ConsoleWriteWithoutCursor(string s)
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.Write(s);
            Console.SetCursorPosition(x, y);
        }

        private enum KeyPressState
        {
            None,
            ArrowH,
            ArrowV,
            Ascii,
            Delete,
            Enter,
            Backspace
        }
    }
}
