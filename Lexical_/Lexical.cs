using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical_Analyzer
{
    class Lexical
    {
        public static int _Position {get; set;} //_Position
        public static int a_zPosition {get; set;} //a_zPosition
        public static int A_ZPosition {get; set;} //A_ZPosition
        public static int digitPosition { get; set; } //digitPosition
        public static char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };                     // digits
        public static char[] punctuators = { '.', ',', ';', '{', '}', '[', ']', '(', ')' };                     // punctuators
        public static char[] operators = { '+', '-', '*', '/', '%' };                                           // operators
        public static string[] assignment_operators = { "=", "+=", "-=", "*=", "/=" };                          // assignment_operators
        public static string[] relational_operators = { "==", "!=", "<=", ">=", "<", ">" };                     // relational_operators
        public static string[] logical_operators = { "&&", "||" };                                              // logical_operators
        public static string alphas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";                                             // alphas
        public char[] capital_letters = (alphas).ToCharArray();                                                 // capital_letters
        public char[] small_letters = (alphas.ToLower()).ToCharArray();                                         // small_letters
        public static string[] keywords = { "num", "fnum", "char", "str", "tf", "check", "leave", "write",      // keywords
                                              "loop" };

        /******************************* Lexical Analysis Checks *************************************/


        /************ Carriage return or Enter key ****************/
        public bool isCarriageReturn(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == '\n')
                {
                    return true;
                }
            }
            return false;
        }

        /******** Keyword ********/
        //public bool isKeyword(string value)
        //{
        //    char[] seperators = { ' ', '.', ',', '-', '?', '!', '<', '>', '&', '[', ']', '(', ')' };
        //    for (int i = 0; i < seperators.Length; i++)
        //    {
        //        string a = value.Remove(value.IndexOf(seperators[i]), 1);
        //        //return true;
        //    }
        //    if (keywords.Contains(value))
        //        return true;
        //    else
        //        return false;
        //}

        /******** punctuators ********/
        public bool isPunctuator(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (punctuators.Contains(value[i]))
                {
                    return true;
                }
            }
            return false;
        }

        /******** operators ********/
        public bool isOperator(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (operators.Contains(value[i]))
                {
                    return true;
                }
            }
            return false;
        }

        /******** assignment_operators ********/
        public bool isAssignmentOperator(string value)
        {
            if (assignment_operators.Contains(value))
                return true;
            else
                return false;
        }

        /******** relational_operators ********/
        public bool isRelationalOperator(string value)
        {
            if (relational_operators.Contains(value))
                return true;
            else
                return false;
        }

        /******** logical_operators ********/
        public bool isLogicalOperator(string value)
        {
            if (logical_operators.Contains(value))
                return true;
            else
                return false;
        }


        /******** Identifier ********/

            public bool isIdentifier(string value)
            {

                int i = 0;

                while (i < value.Length)
                    Transition_Table_for_Identifier(value[i++], i);

                if (_Position == 0 && a_zPosition == 1 || _Position == 0 && A_ZPosition == 1 || a_zPosition == 0 || A_ZPosition == 0)
                {
                    return true;
                }
                else return false;
            }
            public int Transition_Table_for_Identifier(char ch, int index)
            {
                if (ch == '_')
                {
                    _Position = index;
                    return _Position;
                }
                else if (small_letters.Contains(ch))
                {
                    a_zPosition = index;
                    return a_zPosition;
                }
                else if (capital_letters.Contains(ch))
                {
                    A_ZPosition = index;
                    return A_ZPosition;
                }
                else if (digits.Contains(ch))
                {
                    digitPosition = index;
                    return digitPosition;
                }
                else
                    return 0;
            }
    

        /******** Integer constant ********/


            int[,] TT_int_const = { { 0, 1 }, { 1, 1 }, { 1, 1 } };
            public bool isIntConst(string value)
            {

                int state = 0, finalState = 1, i = 0;

                while (i < value.Length)
                    state = Transition_Table_for_Integer(state, value[i++]);
                if (state == finalState)
                    return true;
                else
                    return false;
            }
            public int Transition_Table_for_Integer(int state, char ch)
            {
                if (ch == '+' || ch == '-')
                    return TT_int_const[state, 0];
             
                else if (digits.Contains(ch))
                    return TT_int_const[state, 1];
                else
                    return 0;
            }
        

        /*
         * ----------------------------------
         * Floating Point Trasition Table
         * ----------------------------------
           states |__________inputs__________
         * _______|_+,-,^_|_(0-9)_|_.(0-9)___
         *  s0    |   1   |   1   |    2 
         *  s1    |   0   |   1   |    2 
         *  s2    |   0   |   2   |    2 
         *  ---------------------------------
         */


            int[,] TT_for_floating_point = new int[,] { { 1, 1, 2 }, { 0, 1, 2 }, { 0, 3, 0 }, { 0, 3, 0 } };
            public bool isFloatingPointConst(string value)
            {

                int state = 0, finalState = 3, i = 0;

                while (i < value.Length)
                    state = Transition_Table_for_floating(state, value[i++]);
                if (state == finalState)
                    return true;
                else
                    return false;
            }
            public int Transition_Table_for_floating(int state, char ch)
            {
                if (ch == '+' || ch == '-')
                    return TT_for_floating_point[state, 0];
                else if (digits.Contains(ch))
                    return TT_for_floating_point[state, 1];
                else if (ch == '.')
                    return TT_for_floating_point[state, 2];
                else
                    return 0;
            }


            /************* character constant *****************/

            int[,] TT_for_character_constant = new int[,] { { 1, 2, 0 }, { 0, 2, 2 }, { 0, 2, 2 } };
            public bool isCharacterConstant(string value)
            {

                int state = 0, finalState = 2, i = 0;

                while (i < value.Length)
                    state = Transition_Table_for_char_const(state, value[i++]);
                if (state == finalState)
                    return true;
                else
                    return false;
            }
            public int Transition_Table_for_char_const(int state, char ch)
            {
                if (small_letters.Contains(ch))
                    return TT_for_character_constant[state, 2];
                else if (capital_letters.Contains(ch))
                    return TT_for_character_constant[state, 2];
                else if (digits.Contains(ch))
                    return TT_for_character_constant[state, 2];

                else
                    return 0;
            }
        

        ///******** string constant ********/
        
        //    Lexical lex5 = new Lexical(new int[,] { { 1, 2, 0 }, { 0, 2, 2 }, { 0, 2, 2 } });
        //    public string isStringConstant(string value)
        //    {

        //        int state = 0, finalState = 2, i = 0;

        //        while (i < value.Length)
        //            state = Transition_Table_for_string_const(state, value[i++]);
        //        if (state == finalState)
        //            return "Valid String Constant";
        //        else
        //            return "Invalid String Constant";
        //    }
        //    public int Transition_Table_for_string_const(int state, char ch)
        //    {
        //        if (ch == '_')
        //            return Transition_Table[state, 0];
        //        else if (small_letters.Contains(ch))
        //            return Transition_Table[state, 1];
        //        else if (digits.Contains(ch))
        //            return Transition_Table[state, 2];

        //        else
        //            return 0;
        //    }
        
    }
}
