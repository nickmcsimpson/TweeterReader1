using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweeterReader.ADL
{
    public class QWERTY
    {
        /* QWERTY Layout
                Q  |   W  |   E  |   R  |   T  |   Y  |   U  |   I  |   O  |   P  | Del  |  []\{}|
   * |------+------+------+------+------+-------------+------+------+------+------+------|
   * | Esc  |   A  |   S  |   D  |   F  |   G  |   H  |   J  |   K  |   L  |   ;  |  "   |;':"
   * |------+------+------+------+------+------|------+------+------+------+------+------|
   * | Shift|   Z  |   X  |   C  |   V  |   B  |   N  |   M  |   ,  |   .  |   /            <>?

           */

        // TODO: Separate Info into each class for calling to the main math calc.

        //public int _distance;
        //public ConsoleKey _character;
        //public string _finger;
        //public int _keyRow;

        //Store the keys in Arrays?
        //Paster
        //    ", "    public string[] Row1 = {""};

        //rows
        public static string[] Row1 = { "z", "x", "c", "v", "b", "n", "m", ",", ".", "/", "<", ">", "?" };//13
        public static string[] Row2 = { "a", "s", "d", "f", "g", "h", "j", "k", "l", ";", "\'", ":", "\"" };//13
        public static string[] Row3 = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "[", "]", "\\", "{", "}", "|" };//16
        public static string[] Row4 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "+", "-", "=", "_", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };//24
        public static string[] AddShft = { "<", ">", "?", ":", "\"", "{", "}", "+", "_", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };//using shift 19
        public static string[] Add1Motion = { "g", "h", "\'", "\"", "]", "}", "+", "=", "5", "6", "% ", "^" };//buttons that are reached for extra
        public static string[] Add3Motion = { "|", "\\" };//special +3



        //finger
        public static string[] R4 = { "q", "a", "z" };
        public static string[] R3 = { "w", "s", "x", "1", "2" };
        public static string[] R2 = { "e", "d", "c", "3", "!", "@" };
        public static string[] R1 = { "4", "5", "r", "t", "f", "g", "v", "b", "#", "$", "%" };
        public static string[] L4 = { "/", ";", "p", "?", ":", "\"", "[", "]", "{", "}", "\'", "|", "\\" };

        public static string[] L3 = { ".", ">", "l", "o", "9", "(", ")", "_", "-", "+", "=", "Backspace" };
        public static string[] L2 = { ",", "k", "i", "<", "8", "*" };
        public static string[] L1 = { "^", "&", "y", "u", "j", "h", "n", "m" };


        //public QWERTY(ConsoleKey input)
        //{
        //    //_character
        //    _character = input;

        //    //_keyRow
        //    //to show which rows are more active... 1,2,3,4
        //    if (Row1.Contains(_character.ToString().ToLower()))
        //    {
        //        _keyRow = 1;
        //    }
        //    else if (Row2.Contains(_character.ToString().ToLower()))
        //    {
        //        _keyRow = 2;
        //    }
        //    else if (Row3.Contains(_character.ToString().ToLower()))
        //    {
        //        _keyRow = 3;
        //    }
        //    else if (Row4.Contains(_character.ToString().ToLower()))
        //    {
        //        _keyRow = 4;
        //    }
        //    else
        //    {
        //        _keyRow = 0;
        //    }

        //    //_finger
        //    //If the letter is in the R1,L2... etc
        //    if (R1.Contains(_character.ToString().ToLower()))
        //    {
        //        _finger = "Right Index";
        //    }
        //    else if (R2.Contains(_character.ToString().ToLower()))
        //    {
        //        _finger = "Right Middle";
        //    }
        //    else if (R3.Contains(_character.ToString().ToLower()))
        //    {
        //        _finger = "Right Ring";
        //    }
        //    else if (R4.Contains(_character.ToString().ToLower()))
        //    {
        //        _finger = "Right Pinkie";
        //    }
        //    else if (L1.Contains(_character.ToString().ToLower()))
        //    {
        //        _finger = "Left Index";
        //    }
        //    else if (L2.Contains(_character.ToString().ToLower()))
        //    {
        //        _finger = "Left Middle";
        //    }
        //    else if (L3.Contains(_character.ToString().ToLower()))
        //    {
        //        _finger = "Left Ring";
        //    }
        //    else if (L4.Contains(_character.ToString().ToLower()))
        //    {
        //        _finger = "Left Pinkie";
        //    }
        //    else
        //    {
        //        _finger = "Thumb";
        //    }

        //    //_distance
        //    /*
        //     This is determined by the space travelled by the finger to get to the key. So distance from the home row
        //     can be calculated from row value

        //    Maybe the left pinkie should add a half distance metric when shifting... can i measure Caps?
        //    I could measure capitals by checking if .tolower = input
        //    should I condense 
        //     */

        //    switch (_keyRow)
        //    {
        //        case 0:
        //            _distance = 0;
        //            break;
        //        case 1:
        //            _distance = 1;
        //            break;
        //        case 2:
        //            _distance = 0;
        //            break;
        //        case 3:
        //            _distance = 1;
        //            break;
        //        case 4:
        //            _distance = 2;
        //            break;
        //        default:
        //            break;
        //    }


        //    //AddShft //using shift 19
        //    if (AddShft.Contains(_character.ToString().ToLower()))
        //    {
        //        _distance += 1;
        //    }
        //    //Add1Motion //buttons that are reached for extra
        //    if (Add1Motion.Contains(_character.ToString().ToLower()))
        //    {
        //        _distance += 1;
        //    }
        //    //Add3Motion //special +3
        //    if (Add3Motion.Contains(_character.ToString().ToLower()))
        //    {
        //        _distance += 3;
        //    }





        //}

        //public int Distance
        //{
        //    get { return _distance; }
        //    set { _distance = value; }
        //}
        //public ConsoleKey Character
        //{
        //    get { return _character; }
        //    set { _character = value; }
        //}
        //public string Finger
        //{
        //    get { return _finger; }
        //    set { _finger = value; }
        //}
        //public int KeyRow
        //{
        //    get { return _keyRow; }
        //    set { _keyRow = value; }
        //}
    }//End QWERTY

    //Add DVORAK?
}
