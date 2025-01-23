using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                // display the active line

                    // Item Name

                    // Lines Bar

                    // Line Contents

                    // Set Cursor

                // continue till the user changes lines
                int line = _active_line;
                while (line == _active_line)
                {
                    EditOneKey();
                }

            }
        }

        private void EditOneKey()
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
