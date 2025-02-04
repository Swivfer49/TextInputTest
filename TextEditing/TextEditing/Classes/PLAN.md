# Plan

## Design

The interface will include a toolbar at the top. This will show the title of the selected line as well as the titles of the lines before and after the selected line.

Below the toolbar will be the text of the selected line.

## Problems

- Lines may possibly go off screen, this will cause an error if the cursor is told to go off screen.

## Classes

- `TextLine`: Stores a line with a title and some text.
- `TextEditable`: Acts as a manager system for multiple lines.

## Key Presses to Handle

- `Enter`: Creates a new line (if current line has content).
- `Delete`: Removes a character after the cursor.
- `Backspace`: Removes a character before the cursor.
- `Tab`: Switches between Title and Text editing.
- `LeftArrow`: Moves cursor left.
- `RightArrow`: Moves cursor right.
- `DownArrow`: Moves cursor down.
- `UpArrow`: Moves cursor up.
- `Shift + LeftArrow`: Moves to previous line.
- `Shift + RightArrow`: Moves to next line.
- `Shift + Enter`: Exit.
- Characters: Add character at cursor.