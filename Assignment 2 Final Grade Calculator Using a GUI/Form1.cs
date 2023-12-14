/*Author: Roselia Dela Cruz
Assignment No. 2
ICT 710 Computer Programming 1
Date Created: July 30, 2022
Instructor: Scott Thornton
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Final_Grade_Calculator_Using_a_GUI
{
    public partial class gradeCalculator_form : Form
    {
        int quiz_counter = 0; //indicates how many quizzes are saved
        String quizvalue;// holds the string value of quiz from input box
        bool errorvalue; // value depends if quiz mark is valid or not
        int quiznumvalue; // numerical value of quiz mark
        int min_quiz = 0; // holds the smallest value quiz mark
        int max_quiz = 0; // holds the biggest value quiz mark
        int inputnumvalue; //holds the numerical value of input after validation
        String midtermvalue; //holds the string value of midterm mark from input box
        String finaltermvalue; //holds the string value of final term mark from input box
        int midtermnumvalue; //numerical value of midterm mark
        int finaltermnumvalue; //numerical value of final term mark
        int linecount; //holds the number of lines of textbox to assign to quiz counter
        double totalquizzes;//holds the sum of quizzes
        double averagequiz; // average of all quizzes 
        String letter_grade = "";//letter equivalent to final grade
        string[] textperline;//holds the text taken from everyline of quiz textbox
        

        //IsNumeric() is method used to check if the user input is an integer.
        public bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        //Validate_value() method is used to check if the user input is a whole number and within range 1-100
        //This method sets the value of errorvalue to either true (incorrect input) or false (correct input)
        public void Validate_value(string input_value)
        {
            if (IsNumeric(input_value) == true)
            {
                inputnumvalue = Convert.ToInt32(input_value);
                if (inputnumvalue >= 0 && inputnumvalue <= 100)
                {
                    errorvalue = false;
                    return;
                }
                else
                {
                    errorvalue = true;
                    MessageBox.Show("The value must be between 0 to 100 only.", "Input Error");
                    return;
                }
            }
            else
            {
                errorvalue = true;
                MessageBox.Show("The value must not contain letter and must be a whole number.", "Input Error");
            }
        }
        //countLines() method count the number of lines in the multiline textbox as the user enter or remove a quiz mark.
        //This method is called to update the quiz_counter variable
        public int CountLines(TextBox txtbx)
        {
            string[] lines = txtbx.Text.Split(new Char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            linecount = lines.Length;
            return linecount;
        }
        //This method is gets quiz mark with the smallest value
        public int get_minimum_value()
        {
            textperline = list_of_Quiz_textbox.Lines;
            int Min = Convert.ToInt32(textperline[0]);
            for (int i = 0; i <= textperline.GetUpperBound(0); i++)
            {
                if (textperline[i].Equals(""))
                    continue;
                int number = Convert.ToInt32(textperline[i]);
                if (number < Min)
                     Min = number;
            }
            return Min;
        }
        //This method is gets quiz mark with the biggest value
        public int get_maximum_value()
        {
            textperline = list_of_Quiz_textbox.Lines;
            int Max = Convert.ToInt32(textperline[0]);
            for (int i = 0; i <= textperline.GetUpperBound(0); i++)
            {
                if (textperline[i].Equals(""))
                    continue;
                int number = Convert.ToInt32(textperline[i]);
                if (number > Max)
                    Max = number;
            }
            
            return Max;
        }
        //When the main form loads, components/controls are initialized
        public gradeCalculator_form()
        {
            InitializeComponent();
            list_of_Quiz_textbox.ReadOnly = true;
            list_of_Quiz_textbox.ScrollBars = ScrollBars.Vertical;
            midtermGrade_textbox.AcceptsReturn = true;
            finalTermGrade_textbox.AcceptsReturn = true;
        }
        //This method record the quiz mark input to a multiline textbox after validation.
        private void Add_a_Quiz_button_Click(object sender, EventArgs e)
        {
            quizvalue = quiz_inputvalue_textbox.Text;
            Validate_value(quizvalue);
            if (errorvalue == false)
            {
                quizerrormessage_label.Text = "";
                list_of_Quiz_textbox.Text += quizvalue + Environment.NewLine;
                quiz_inputvalue_textbox.Clear();
                quiz_inputvalue_textbox.Focus();
                quiz_counter = CountLines(list_of_Quiz_textbox);
                if (quiz_counter >= 5)
                            dropValue_checkbox.Enabled = true;
            }
            else
            {
                quiz_inputvalue_textbox.Clear();
                quiz_inputvalue_textbox.Focus();
            }
        }
        //This method remove a selected quiz mark value from the multiline textbox.
        private void Remove_a_Quiz_button_Click(object sender, EventArgs e)
        {
            // this part gets the current line and position of the cursor to know what value is to be deleted
            int startpos = list_of_Quiz_textbox.SelectionStart;
            int currentline = list_of_Quiz_textbox.GetLineFromCharIndex(startpos);
            int linefirstchar = list_of_Quiz_textbox.GetFirstCharIndexOfCurrentLine();
            int linelength = list_of_Quiz_textbox.Text.IndexOf(Environment.NewLine, linefirstchar) - linefirstchar + Environment.NewLine.Length;
            
            if (list_of_Quiz_textbox.Text =="")
            {
                MessageBox.Show("No quiz mark to delete.");
                return;
            }
            else
            {  
                if (linelength < 1)
                {
                    linelength += linefirstchar;
                }
                textperline = list_of_Quiz_textbox.Lines;
                list_of_Quiz_textbox.Select(linefirstchar, linelength);
                if (textperline[currentline].Equals(string.Empty))
                    MessageBox.Show("Please select a value");
                else
                {
                    list_of_Quiz_textbox.SelectedText = list_of_Quiz_textbox.SelectedText.Remove(0);
                    list_of_Quiz_textbox.SelectionLength = 0;
                }   
                
            }
          
            remove_a_Quiz_button.Focus();
            quiz_counter = CountLines(list_of_Quiz_textbox);
            
            if (quiz_counter < 5)
            {
                dropValue_checkbox.Enabled = false;
                dropValue_checkbox.Checked = false;
            }
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //check if there are missing inputs
            if (list_of_Quiz_textbox.Text == "" || midtermGrade_textbox.Text == "" || finalTermGrade_textbox.Text == "")
            {
                MessageBox.Show("There is missing input. All marks are required.");
                if (list_of_Quiz_textbox.Text == "")
                {
                    quizerrormessage_label.ForeColor = Color.Red;
                    quizerrormessage_label.Text = "There must be at least one quiz mark.";
                }
                if (midtermGrade_textbox.Text == "")
                {
                    midtermprompt_label.ForeColor = Color.Red;
                    midtermprompt_label.Text = "Midterm mark is required.";
                }
                if (finalTermGrade_textbox.Text == "")
                {
                    finaltermprompt_label.ForeColor = Color.Red;
                    finaltermprompt_label.Text = "Final term mark is required.";
                }
            }
            else
            {
                //if there are no missing mark, proceed to getting the string value of marks, then validate
                midtermvalue = midtermGrade_textbox.Text;
                Validate_value(midtermvalue);
                if (errorvalue == false)
                {
                    midtermnumvalue = Convert.ToInt32(midtermvalue);
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Rosel\source\repos\Final Grade Calculator\check_icon.png");
                    midtermprompt_label.ForeColor = Color.Green;
                    midtermprompt_label.Text = "Midterm mark saved.";
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Rosel\source\repos\Final Grade Calculator\cross_icon.png");
                    midtermprompt_label.ForeColor = Color.Red;
                    midtermprompt_label.Text = "Invalid format.";
                    return;
                }

                finaltermvalue = finalTermGrade_textbox.Text;
                Validate_value(finaltermvalue);
                if (errorvalue == false)
                {
                    finaltermnumvalue = Convert.ToInt32(finaltermvalue);
                    pictureBox2.Image = Image.FromFile(@"C:\Users\Rosel\source\repos\Final Grade Calculator\check_icon.png");
                    finaltermprompt_label.ForeColor = Color.Green;
                    finaltermprompt_label.Text = "Final term mark saved.";
                }
                else
                {
                    pictureBox2.Image = Image.FromFile(@"C:\Users\Rosel\source\repos\Final Grade Calculator\cross_icon.png");
                    finaltermprompt_label.ForeColor = Color.Red;
                    finaltermprompt_label.Text = "Invalid format.";
                    return;
                }

                //enable the report panel to display the results of calculation
                report_panel.Enabled = true;
                quizerrormessage_label.Text = "";
                //Show student info
                reportName_label.Text = name_textbox.Text;
                reportID_label.Text = idNumber_textbox.Text;
                reportCourse_label.Text = course_textbox.Text;

                //compute quiz average and show in the report
                //get the quiz marks per line from the multiline textbox, parse, then sum up
                textperline = list_of_Quiz_textbox.Lines;
                for (int i = 0; i <= textperline.GetUpperBound(0); i++)
                {
                    if (textperline[i].Equals(""))
                        continue;
                    quiznumvalue = Convert.ToInt32(textperline[i]);
                    totalquizzes += quiznumvalue;
                }

                if (dropValue_checkbox.Checked == true)
                {
                    min_quiz = get_minimum_value();
                    max_quiz = get_maximum_value();
                    
                    averagequiz = Convert.ToDouble((totalquizzes - (min_quiz + max_quiz)) / (quiz_counter - 2));
                    MessageBox.Show("min: " + min_quiz + " & max: " + max_quiz + " dropped. Ave. is  " + averagequiz);
                }
                else
                {
                    averagequiz = Convert.ToDouble(totalquizzes / (quiz_counter));
                    MessageBox.Show("total q " + totalquizzes + " and Average " + averagequiz);
                }

                totalquizzes = 0;
                reportQuizAverage_textBox.Text = Convert.ToString(averagequiz);
                reportQuizAverage_textBox.Text = string.Format("{0:#,##0.00}", double.Parse(reportQuizAverage_textBox.Text));

                //compute 20 percent of quiz average and show in the report
                double quizpercentvalue = averagequiz * 0.2;
                reportQuizPercent_textbox.Text = Convert.ToString(quizpercentvalue);
                reportQuizPercent_textbox.Text = string.Format("{0:#,##0.00}", double.Parse(reportQuizPercent_textbox.Text));
                
                //compute 30 percent of midterm and show in the report
                reportMidterm_textbox.Text = midtermGrade_textbox.Text;
                double midtermpercentvalue = midtermnumvalue * 0.3;
                reportMidtermPercent_textbox.Text = Convert.ToString(midtermpercentvalue);

                //compute 50 percent of final term and show on the report
                reportFinalTerm_textbox.Text = finalTermGrade_textbox.Text;
                double finaltermpercentvalue = finaltermnumvalue * 0.5;
                reportFinalTermPercent_textbox.Text = Convert.ToString(finaltermpercentvalue);

                //compute the total grade and convert to letter grade
                double totalgrade = quizpercentvalue + midtermpercentvalue + finaltermpercentvalue;
                reportFinalGrade_textbox.Text = Convert.ToString(totalgrade);

                //convert the total grade to it letter equivalent
                if (totalgrade <= 100 && totalgrade >= 95)
                    letter_grade = "A+";
                else if (totalgrade <= 94 && totalgrade >= 90)
                    letter_grade = "A";
                else if (totalgrade <= 89 && totalgrade >= 85)
                    letter_grade = "A-";
                else if (totalgrade <= 84 && totalgrade >= 80)
                    letter_grade = "B+";
                else if (totalgrade <= 79 && totalgrade >= 75)
                    letter_grade = "B";
                else if (totalgrade <= 74 && totalgrade >= 70)
                    letter_grade = "B-";
                else if (totalgrade <= 69 && totalgrade >= 67)
                    letter_grade = "C+";
                else if (totalgrade <= 66 && totalgrade >= 64)
                    letter_grade = "C";
                else if (totalgrade <= 63 && totalgrade >= 60)
                    letter_grade = "C-";
                else if (totalgrade <= 59 && totalgrade >= 55)
                    letter_grade = "D+";
                else if (totalgrade <= 54 && totalgrade >= 50)
                    letter_grade = "D";
                else 
                    letter_grade = "F (Fail)";
 
                letterGrade_label.Text = letter_grade;
            }
            totalquizzes = 0; //reset the total quizzes after computation
        }
    
        //The program will end when exit button is clicked
        private void exit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Reset variables, clear control values, set controls to their default set of properties
        private void reset_button_Click(object sender, EventArgs e)
        {
         
            name_textbox.Clear();
            idNumber_textbox.Clear();
            course_textbox.Clear();
            quiz_inputvalue_textbox.Clear();
            list_of_Quiz_textbox.Clear();
            midtermGrade_textbox.Clear();
            finalTermGrade_textbox.Clear();
            pictureBox1.Image = Image.FromFile(@"C:\Users\Rosel\source\repos\Final Grade Calculator\enter_key.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\Rosel\source\repos\Final Grade Calculator\enter_key.png");
            dropValue_checkbox.Checked = false;
            dropValue_checkbox.Enabled = false;
            
            report_panel.Enabled = false;
            reportName_label.Text = "";
            reportID_label.Text = "";
            reportCourse_label.Text = "";
            reportQuizPercent_textbox.Clear();
            reportQuizAverage_textBox.Clear();
            reportMidterm_textbox.Clear();
            reportMidtermPercent_textbox.Clear();
            reportFinalTerm_textbox.Clear();
            reportFinalTermPercent_textbox.Clear();
            reportFinalGrade_textbox.Clear();
            letterGrade_label.Text = "";

            quiz_counter = 0;
            quizvalue = "";
            quiznumvalue = 0;
            inputnumvalue = 0;
            midtermvalue = "";
            finaltermvalue ="";
            midtermnumvalue = 0;
            finaltermnumvalue = 0;
            linecount = 0;
            totalquizzes = 0;
            averagequiz = 0;
            letter_grade = null;

            midtermprompt_label.ForeColor = Color.Black;
            midtermprompt_label.Text = "Enter 0-100 only.";
            finaltermprompt_label.ForeColor = Color.Black;
            finaltermprompt_label.Text = "Enter 0-100 only.";
        }
        //This method removes all the quiz marks from the multiline textbox
        private void removeAll_button_Click(object sender, EventArgs e)
        {
            if (list_of_Quiz_textbox.Text == "")
            {
                MessageBox.Show("No quiz mark to delete.","Delete Quiz Mark");
                return;
            }
            else
            {
                //show messagebox to make sure 
                quiz_counter = 0;
                quizvalue = "";
                quiznumvalue = 0;
                list_of_Quiz_textbox.Clear();
                dropValue_checkbox.Checked = false;
                dropValue_checkbox.Enabled = false;
            }
        }
        //Quiz average and Final grade is reset whenever user make changes to quiz input box and multiline textbox
        private void quiz_inputvalue_textbox_TextChanged(object sender, EventArgs e)
        {
            reportFinalGrade_textbox.Text = "";
            letterGrade_label.Text = "";
            reportQuizAverage_textBox.Text = "";
        }
        //Midterm mark is reset in the report panel whenever user make changes to midterm input textbox
        private void midtermGrade_textbox_TextChanged(object sender, EventArgs e)
        {
            reportFinalGrade_textbox.Text = "";
            letterGrade_label.Text = "";
            reportMidterm_textbox.Text = "";
        }
        //Final term mark is reset in the report panel whenever user make changes to final term input textbox
        private void finalTermGrade_textbox_TextChanged(object sender, EventArgs e)
        {
            reportFinalGrade_textbox.Text = "";
            letterGrade_label.Text = "";
            reportFinalTerm_textbox.Text = "";
        }

       
    }
}
