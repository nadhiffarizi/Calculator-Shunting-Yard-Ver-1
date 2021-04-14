using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Description for application
/// </summary>
namespace Calculator_Shunting_Yard_Ver_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region cursor_focus_input

        // save position cursor 
        private int posCursor;

        /// <summary>
        /// Manipulate cursor position so that the position doesn't change when inserted with characters
        /// </summary>
        private void TextEquationInsert(string value)
        {

            posCursor = TextBoxEquation.SelectionStart;
            TextBoxEquation.Text = TextBoxEquation.Text.Insert(TextBoxEquation.SelectionStart, value);
            TextBoxEquation.SelectionStart = posCursor + value.Length;
            InputTextFocus();
        }


        /// <summary>
        /// Method to focus to textbox equation
        /// </summary>
        private void InputTextFocus()
        {
            TextBoxEquation.Focus();
        }


        /// <summary>
        /// Manipulate cursor position when deleting characters from textbox equation
        /// </summary>

        private void TextEquationDelete()
        {
            posCursor = TextBoxEquation.SelectionStart;

            if ((posCursor - 1) >= 0)
            {
                TextBoxEquation.Text = TextBoxEquation.Text.Remove(posCursor - 1, 1);
                TextBoxEquation.SelectionStart = posCursor - 1;
            }
            else
            {
                TextBoxEquation.SelectionStart = 0;
            }

            TextBoxEquation.Focus();
        }

        #endregion


        #region numbers clicks
        /// <summary>
        /// Number 0 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonZero_Click(object sender, EventArgs e)
        {
            TextEquationInsert("0");
        }

        /// <summary>
        /// Number 00 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDoubleZero_Click(object sender, EventArgs e)
        {
            TextEquationInsert("00");
        }


        /// <summary>
        /// Number 1 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOne_Click(object sender, EventArgs e)
        {
            TextEquationInsert("1");
        }


        /// <summary>
        /// Number 2 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            TextEquationInsert("2");
        }


        /// <summary>
        /// Number 3 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonThree_Click(object sender, EventArgs e)
        {
            TextEquationInsert("3");
        }


        /// <summary>
        /// Number 4 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFour_Click(object sender, EventArgs e)
        {
            TextEquationInsert("4");
        }


        /// <summary>
        /// Number 5 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFive_Click(object sender, EventArgs e)
        {
            TextEquationInsert("5");
        }


        /// <summary>
        /// Number 6 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSix_Click(object sender, EventArgs e)
        {
            TextEquationInsert("6");
        }


        /// <summary>
        /// Number 7 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            TextEquationInsert("7");
        }


        /// <summary>
        /// Number 8 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEight_Click(object sender, EventArgs e)
        {
            TextEquationInsert("8");
        }


        /// <summary>
        /// Number 9 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNine_Click(object sender, EventArgs e)
        {
            TextEquationInsert("9");
        }


        /// <summary>
        /// Character '.' clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDot_Click(object sender, EventArgs e)
        {
            TextEquationInsert(".");
        }

        #endregion


        #region operator clicks

        /// <summary>
        /// Operation 'x' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMultiple_Click(object sender, EventArgs e)
        {
            TextEquationInsert("*");
        }


        /// <summary>
        /// Operation 'ANS' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonANS_Click(object sender, EventArgs e)
        {
            //get the temporary result
        }


        /// <summary>
        /// Operation '/' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            TextEquationInsert("/");
        }


        /// <summary>
        /// Operation '+' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            TextEquationInsert("+");
        }


        /// <summary>
        /// Operation '-' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            TextEquationInsert("-");
        }


        /// <summary>
        /// Operation '=' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            //checks if textbox doesn't have character
            if (TextBoxEquation.Text == string.Empty)
                this.LabelResult.Text = "0";
            else
                //calculate
                Calculate();

            //Re-focus on textbox equation
            InputTextFocus();
        }

        #endregion


        #region input_manipulation_delete_and_max

        /// <summary>
        /// CE button click (delete all written equation on textbox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            TextBoxEquation.Text = "";
            TextBoxEquation.Focus();
        }

        /// <summary>
        /// Delete button for single character in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (TextBoxEquation.Text == "")
            {
                posCursor = 0;
                return;
            }
            else
            {
                //Call method TextEquationDelete to manipulate cursor for changes
                TextEquationDelete();
            }

        }
        #endregion

        #region Calculate

        private void Calculate()
        {
            //create object 
            Calculator cal = new Calculator();

            //get end result with input text equation
            string end_result = cal.ParseEquation(TextBoxEquation.Text);

            this.LabelResult.Text = end_result;
        }

        #endregion
    }
}
