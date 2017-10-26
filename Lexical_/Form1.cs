using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lexical_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void analyze_btn_Click(object sender, EventArgs e)
        {
            Lexical lex = new Lexical();
            int line_no = 1;
            string userInput = richTextBox1.Text;

//            string[] tokens = userInput.Split(' ', '.', ',', '-', '?', '!', '<', '>', '&', '[', ']', '(', ')');
            string[] tokens = userInput.Split(' ');

            
            
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "(")
                {

                }
                textBox1.Text += '\t' + tokens[i]; // for testing tokens
                if (lex.isCarriageReturn(tokens[i]))
                {
                    line_no++;
                }
                //if (lex.isKeyword(tokens[i])) dataGridView1.Rows.Add(i, "Keyword", tokens[i], line_no);
                if (lex.isPunctuator(tokens[i])) dataGridView1.Rows.Add(i, "Punctuator", tokens[i], line_no);
                if (lex.isOperator(tokens[i])) dataGridView1.Rows.Add(i, "Operator", tokens[i], line_no);
                if (lex.isAssignmentOperator(tokens[i])) dataGridView1.Rows.Add(i, "Assignment Operator", tokens[i], line_no);
                if (lex.isRelationalOperator(tokens[i])) dataGridView1.Rows.Add(i, "Relational Operator", tokens[i], line_no);
                if (lex.isLogicalOperator(tokens[i])) dataGridView1.Rows.Add(i, "Logical Operator", tokens[i], line_no);
                if (lex.isIntConst(tokens[i])) dataGridView1.Rows.Add(i, "Integer Constant", tokens[i], line_no);
                //if (lex.isIdentifier(tokens[i])) dataGridView1.Rows.Add(i, "Identifier", tokens[i], line_no);
                if (lex.isCharacterConstant(tokens[i])) dataGridView1.Rows.Add(i, "Character Constant", tokens[i], line_no);
                if (lex.isFloatingPointConst(tokens[i])) dataGridView1.Rows.Add(i, "Floating Point Constant", tokens[i], line_no);
                //if (lex.isIntConst(tokens[i])) dataGridView1.Rows.Add(i, "Identifier", tokens[i], line_no);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = "";
        }
         
    }
}
