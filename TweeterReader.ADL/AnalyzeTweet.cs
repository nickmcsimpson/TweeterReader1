using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweeterReader.ADL
{
    public class AnalyzeTweet
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        //Row Data variables
        int row1count = 0;
        int row2count = 0;
        int row3count = 0;
        int row4count = 0;
        //Finger data varibles
        int rpinkie = 0;
        int rring = 0;
        int rmiddle = 0;
        int rindex = 0;
        int lpinkie = 0;
        int lring = 0;
        int lmiddle = 0;
        int lindex = 0;
        int thumbs = 0;
        //general variables
        int strokes = 0;
        int keytravel = 0;
        string input;
        double efficiency;

        public AnalyzeTweet(string tweet)// int KeyboardType// TODO: Convert to take string
        {
            input = tweet;

            logger.Debug("#Starting #Analysis of tweet: " + tweet);

            char[] char_input = input.ToCharArray();

            AnalyzeInput(char_input);

            logger.Debug("#Finished #Analysis of tweet: " + tweet);
        }

        private void AnalyzeInput(char[] charInput)
        {
            var tracer = StackifyLib.ProfileTracer.CreateAsTrackedFunction("Analyze Tweet"); tracer.Exec(() =>
            {
                foreach (var letter in charInput)
                {
                    int _keyRow;
                    //Determine KeyRow
                    //to show which rows are more active... 1,2,3,4
                    if (QWERTY.Row1.Contains(letter.ToString().ToLower()))
                    {
                        _keyRow = 1;
                    }
                    else if (QWERTY.Row2.Contains(letter.ToString().ToLower()))
                    {
                        _keyRow = 2;
                    }
                    else if (QWERTY.Row3.Contains(letter.ToString().ToLower()))
                    {
                        _keyRow = 3;
                    }
                    else if (QWERTY.Row4.Contains(letter.ToString().ToLower()))
                    {
                        _keyRow = 4;
                    }
                    else
                    {
                        logger.Debug("#Key not in row 1-4: " + letter.ToString());
                        _keyRow = 0;
                    }

                    string _finger;
                    //determine the _finger
                    //If the letter is in the R1,L2... etc
                    if (QWERTY.R1.Contains(letter.ToString().ToLower()))
                    {
                        _finger = "Right Index";
                    }
                    else if (QWERTY.R2.Contains(letter.ToString().ToLower()))
                    {
                        _finger = "Right Middle";
                    }
                    else if (QWERTY.R3.Contains(letter.ToString().ToLower()))
                    {
                        _finger = "Right Ring";
                    }
                    else if (QWERTY.R4.Contains(letter.ToString().ToLower()))
                    {
                        _finger = "Right Pinkie";
                    }
                    else if (QWERTY.L1.Contains(letter.ToString().ToLower()))
                    {
                        _finger = "Left Index";
                    }
                    else if (QWERTY.L2.Contains(letter.ToString().ToLower()))
                    {
                        _finger = "Left Middle";
                    }
                    else if (QWERTY.L3.Contains(letter.ToString().ToLower()))
                    {
                        _finger = "Left Ring";
                    }
                    else if (QWERTY.L4.Contains(letter.ToString().ToLower()))
                    {
                        _finger = "Left Pinkie";
                    }
                    else
                    {
                        //logger.Debug("#Thumb triggered, should be a space: [" + letter.ToString() + "]");
                        _finger = "Thumb";
                    }

                    //_distance
                    /*
                     This is determined by the space travelled by the finger to get to the key. So distance from the home row
                     can be calculated from row value

                    Maybe the left pinkie should add a half distance metric when shifting... can i measure Caps?
                    I could measure capitals by checking if .tolower = input
                    should I condense 
                     */

                    switch (_keyRow)
                    {
                        case 0:
                            keytravel += 0;
                            break;
                        case 1:
                            row1count += 1;
                            keytravel += 1;
                            break;
                        case 2:
                            row2count += 1;
                            keytravel += 0;
                            break;
                        case 3:
                            row3count += 1;
                            keytravel += 1;
                            break;
                        case 4:
                            row4count += 1;
                            keytravel += 2;
                            break;
                        default:
                            break;
                    }

                    switch (_finger)
                    {
                        case "Right Index":
                            rindex += 1;
                            break;

                        case "Right Middle":
                            rmiddle += 1;
                            break;

                        case "Right Ring":
                            rring += 1;
                            break;

                        case "Right Pinkie":
                            rpinkie += 1;
                            break;

                        case "Left Index":
                            lindex += 1;
                            break;

                        case "Left Middle":
                            lmiddle += 1;
                            break;

                        case "Left Ring":
                            lring += 1;
                            break;

                        case "Left Pinkie":
                            lpinkie += 1;
                            break;

                        case "Thumb":
                            rindex += 1;
                            break;

                        default:
                            break;
                    }


                    //AddShft //using shift 19
                    if (QWERTY.AddShft.Contains(letter.ToString().ToLower()))
                    {
                        //StackifyLib.Logger.Queue("#Shift", "Let's get shwifty");
                        StackifyLib.Metrics.IncrementGauge("Analyze Tweet", "Using that Shift", 1.0);
                        keytravel += 1;
                    }
                    //Add1Motion //buttons that are reached for extra
                    if (QWERTY.Add1Motion.Contains(letter.ToString().ToLower()))
                    {
                        StackifyLib.Logger.Queue("#Extra", "Some of these aren't very close to your finger!");
                        StackifyLib.Metrics.IncrementGauge("Analyze Tweet", "Add 1 Motion", 1.0);
                        keytravel += 1;
                    }
                    //Add3Motion //special +3
                    if (QWERTY.Add3Motion.Contains(letter.ToString().ToLower()))
                    {
                        StackifyLib.Logger.Queue("#Reaching", "Slash and pipes, really?");
                        StackifyLib.Metrics.IncrementGauge("Analyze Tweet", "Add 3 Motion", 1.0);
                        keytravel += 3;
                    }

                    strokes += 1;
                }//end foreach  
                 //Use letter count for custom metric for 'efficiency' keytravel/keystroke
                efficiency = (double)keytravel / (double)strokes;
                StackifyLib.Metrics.SetGauge("Analyze Tweet", "Efficiency (distance/stroke)", efficiency);
            });
        }//endAnalyzeInput

        public string EasyResult()
        {
            string result = String.Format("After analyzing your typing, I found these results...\nYou typed: {0}" +
                "\n--------Button presses by row:\n Bottom(1): {1}\n Middle(2): {2}\n Top(3): {3}\n Number(4): {4}" +
                "\n--------Buttons Pressed by Finger:" +
                "\n Right Index: {5}\n Right Middle: {6}\n Right Ring: {7}\n Right Pinkie: {8}\n Left Index: {9}\n Left Middle: {10}\n Left Ring: {11}\n Left Pinkie: {12}" +
                "\n Total Number of Keystrokes: {13}\n Total distance (keys) moved: {14}", input, row1count, row2count, row3count, row4count, rpinkie, rring, rmiddle, rindex, lpinkie, lring, lmiddle, lindex, strokes, keytravel);
            logger.Debug(result);

            return (result);
        }



        public int Row1Count { get { return row1count; } set { row1count = value; } }
        public int Row2Count { get { return row2count; } set { row2count = value; } }
        public int Row3Count { get { return row3count; } set { row3count = value; } }
        public int Row4Count { get { return row4count; } set { row4count = value; } }

        public int RPinkie { get { return rpinkie; } set { rpinkie = value; } }
        public int RRing { get { return rring; } set { rring = value; } }
        public int RMiddle { get { return rmiddle; } set { rmiddle = value; } }
        public int RIndex { get { return rindex; } set { rindex = value; } }

        public int LPinkie { get { return lpinkie; } set { lpinkie = value; } }
        public int LRing { get { return lring; } set { lring = value; } }
        public int LMiddle { get { return lmiddle; } set { lmiddle = value; } }
        public int LIndex { get { return lindex; } set { lindex = value; } }

        public int Thumbs { get { return thumbs; } set { thumbs = value; } }

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        public int Strokes
        {
            get { return strokes; }
            set { strokes = value; }
        }

        public int KeyTravel
        {
            get { return keytravel; }
            set { keytravel = value; }
        }
        public double Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }
    }
}