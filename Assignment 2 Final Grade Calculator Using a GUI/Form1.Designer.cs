namespace Assignment_2_Final_Grade_Calculator_Using_a_GUI
{
    partial class gradeCalculator_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Marks_label = new System.Windows.Forms.Label();
            this.calculate_button = new System.Windows.Forms.Button();
            this.dropValue_checkbox = new System.Windows.Forms.CheckBox();
            this.StudentInfo_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.idNumber_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.idNumber_textbox = new System.Windows.Forms.TextBox();
            this.course_label = new System.Windows.Forms.Label();
            this.course_textbox = new System.Windows.Forms.TextBox();
            this.quizGrades_label = new System.Windows.Forms.Label();
            this.enterValuePrompt_label = new System.Windows.Forms.Label();
            this.quiz_inputvalue_textbox = new System.Windows.Forms.TextBox();
            this.add_a_Quiz_button = new System.Windows.Forms.Button();
            this.remove_a_Quiz_button = new System.Windows.Forms.Button();
            this.midterm_label = new System.Windows.Forms.Label();
            this.finalTerm_label = new System.Windows.Forms.Label();
            this.midtermGrade_textbox = new System.Windows.Forms.TextBox();
            this.finalTermGrade_textbox = new System.Windows.Forms.TextBox();
            this.report_panel = new System.Windows.Forms.Panel();
            this.letterGrade_label = new System.Windows.Forms.Label();
            this.reportFinalTermPercent_textbox = new System.Windows.Forms.TextBox();
            this.reportMidtermPercent_textbox = new System.Windows.Forms.TextBox();
            this.reportQuizPercent_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportFinalGrade_textbox = new System.Windows.Forms.TextBox();
            this.reportQuizAverage_textBox = new System.Windows.Forms.TextBox();
            this.reportFinalTerm_textbox = new System.Windows.Forms.TextBox();
            this.reportMidterm_textbox = new System.Windows.Forms.TextBox();
            this.reportHeader_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportCourse_label = new System.Windows.Forms.Label();
            this.reportID_label = new System.Windows.Forms.Label();
            this.reportName_label = new System.Windows.Forms.Label();
            this.reportFinalGrade_label = new System.Windows.Forms.Label();
            this.reportFinalTerm_label = new System.Windows.Forms.Label();
            this.reportMidterm_label = new System.Windows.Forms.Label();
            this.reportQuizAverage_label = new System.Windows.Forms.Label();
            this.studentGradeReport_label = new System.Windows.Forms.Label();
            this.verticalLine_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.list_of_Quiz_textbox = new System.Windows.Forms.TextBox();
            this.removeAll_button = new System.Windows.Forms.Button();
            this.quizerrormessage_label = new System.Windows.Forms.Label();
            this.midtermprompt_label = new System.Windows.Forms.Label();
            this.finaltermprompt_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.report_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Marks_label
            // 
            this.Marks_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks_label.Location = new System.Drawing.Point(24, 192);
            this.Marks_label.MaximumSize = new System.Drawing.Size(100, 100);
            this.Marks_label.Name = "Marks_label";
            this.Marks_label.Size = new System.Drawing.Size(73, 20);
            this.Marks_label.TabIndex = 0;
            this.Marks_label.Text = "Marks";
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_button.Location = new System.Drawing.Point(27, 598);
            this.calculate_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(123, 50);
            this.calculate_button.TabIndex = 10;
            this.calculate_button.Text = "&Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // dropValue_checkbox
            // 
            this.dropValue_checkbox.AutoSize = true;
            this.dropValue_checkbox.Enabled = false;
            this.dropValue_checkbox.Location = new System.Drawing.Point(173, 442);
            this.dropValue_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropValue_checkbox.Name = "dropValue_checkbox";
            this.dropValue_checkbox.Size = new System.Drawing.Size(230, 20);
            this.dropValue_checkbox.TabIndex = 8;
            this.dropValue_checkbox.Text = "Drop the lowest and highest score";
            this.dropValue_checkbox.UseVisualStyleBackColor = true;
            // 
            // StudentInfo_label
            // 
            this.StudentInfo_label.AutoSize = true;
            this.StudentInfo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInfo_label.Location = new System.Drawing.Point(25, 18);
            this.StudentInfo_label.Name = "StudentInfo_label";
            this.StudentInfo_label.Size = new System.Drawing.Size(200, 25);
            this.StudentInfo_label.TabIndex = 0;
            this.StudentInfo_label.Text = "Student Information";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(27, 63);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(62, 22);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name:";
            // 
            // idNumber_label
            // 
            this.idNumber_label.AutoSize = true;
            this.idNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumber_label.Location = new System.Drawing.Point(27, 98);
            this.idNumber_label.Name = "idNumber_label";
            this.idNumber_label.Size = new System.Drawing.Size(100, 22);
            this.idNumber_label.TabIndex = 0;
            this.idNumber_label.Text = "ID Number:";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(95, 60);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(304, 28);
            this.name_textbox.TabIndex = 1;
            this.name_textbox.Text = "Roselia Dela Cruz";
            this.name_textbox.WordWrap = false;
            // 
            // idNumber_textbox
            // 
            this.idNumber_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumber_textbox.Location = new System.Drawing.Point(133, 94);
            this.idNumber_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idNumber_textbox.Name = "idNumber_textbox";
            this.idNumber_textbox.Size = new System.Drawing.Size(265, 28);
            this.idNumber_textbox.TabIndex = 2;
            this.idNumber_textbox.Text = "23028817";
            this.idNumber_textbox.WordWrap = false;
            // 
            // course_label
            // 
            this.course_label.AutoSize = true;
            this.course_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_label.Location = new System.Drawing.Point(27, 133);
            this.course_label.Name = "course_label";
            this.course_label.Size = new System.Drawing.Size(73, 22);
            this.course_label.TabIndex = 0;
            this.course_label.Text = "Course:";
            // 
            // course_textbox
            // 
            this.course_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_textbox.Location = new System.Drawing.Point(105, 127);
            this.course_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.course_textbox.Name = "course_textbox";
            this.course_textbox.Size = new System.Drawing.Size(295, 28);
            this.course_textbox.TabIndex = 3;
            this.course_textbox.Text = "ICT 710 Computer Programming 1";
            this.course_textbox.WordWrap = false;
            // 
            // quizGrades_label
            // 
            this.quizGrades_label.AutoSize = true;
            this.quizGrades_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizGrades_label.Location = new System.Drawing.Point(27, 221);
            this.quizGrades_label.Name = "quizGrades_label";
            this.quizGrades_label.Size = new System.Drawing.Size(109, 20);
            this.quizGrades_label.TabIndex = 0;
            this.quizGrades_label.Text = "Quiz Grades:";
            // 
            // enterValuePrompt_label
            // 
            this.enterValuePrompt_label.AutoSize = true;
            this.enterValuePrompt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterValuePrompt_label.Location = new System.Drawing.Point(25, 254);
            this.enterValuePrompt_label.Name = "enterValuePrompt_label";
            this.enterValuePrompt_label.Size = new System.Drawing.Size(131, 18);
            this.enterValuePrompt_label.TabIndex = 0;
            this.enterValuePrompt_label.Text = "Enter the mark >>:";
            // 
            // quiz_inputvalue_textbox
            // 
            this.quiz_inputvalue_textbox.AcceptsReturn = true;
            this.quiz_inputvalue_textbox.AcceptsTab = true;
            this.quiz_inputvalue_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz_inputvalue_textbox.Location = new System.Drawing.Point(169, 255);
            this.quiz_inputvalue_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quiz_inputvalue_textbox.Name = "quiz_inputvalue_textbox";
            this.quiz_inputvalue_textbox.Size = new System.Drawing.Size(116, 28);
            this.quiz_inputvalue_textbox.TabIndex = 4;
            this.quiz_inputvalue_textbox.TextChanged += new System.EventHandler(this.quiz_inputvalue_textbox_TextChanged);
            // 
            // add_a_Quiz_button
            // 
            this.add_a_Quiz_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_a_Quiz_button.Location = new System.Drawing.Point(95, 293);
            this.add_a_Quiz_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_a_Quiz_button.Name = "add_a_Quiz_button";
            this.add_a_Quiz_button.Size = new System.Drawing.Size(190, 37);
            this.add_a_Quiz_button.TabIndex = 5;
            this.add_a_Quiz_button.Text = "&Add a Quiz  >>";
            this.add_a_Quiz_button.UseVisualStyleBackColor = true;
            this.add_a_Quiz_button.Click += new System.EventHandler(this.Add_a_Quiz_button_Click);
            // 
            // remove_a_Quiz_button
            // 
            this.remove_a_Quiz_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_a_Quiz_button.Location = new System.Drawing.Point(95, 334);
            this.remove_a_Quiz_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_a_Quiz_button.Name = "remove_a_Quiz_button";
            this.remove_a_Quiz_button.Size = new System.Drawing.Size(190, 41);
            this.remove_a_Quiz_button.TabIndex = 6;
            this.remove_a_Quiz_button.Text = "<< &Remove A Quiz";
            this.remove_a_Quiz_button.UseVisualStyleBackColor = true;
            this.remove_a_Quiz_button.Click += new System.EventHandler(this.Remove_a_Quiz_button_Click);
            // 
            // midterm_label
            // 
            this.midterm_label.AutoSize = true;
            this.midterm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midterm_label.Location = new System.Drawing.Point(24, 492);
            this.midterm_label.Name = "midterm_label";
            this.midterm_label.Size = new System.Drawing.Size(126, 20);
            this.midterm_label.TabIndex = 0;
            this.midterm_label.Text = "Midterm Grade:";
            // 
            // finalTerm_label
            // 
            this.finalTerm_label.AutoSize = true;
            this.finalTerm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalTerm_label.Location = new System.Drawing.Point(24, 544);
            this.finalTerm_label.Name = "finalTerm_label";
            this.finalTerm_label.Size = new System.Drawing.Size(150, 20);
            this.finalTerm_label.TabIndex = 0;
            this.finalTerm_label.Text = "Final Term Grade: ";
            // 
            // midtermGrade_textbox
            // 
            this.midtermGrade_textbox.AcceptsReturn = true;
            this.midtermGrade_textbox.AcceptsTab = true;
            this.midtermGrade_textbox.AllowDrop = true;
            this.midtermGrade_textbox.CausesValidation = false;
            this.midtermGrade_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtermGrade_textbox.Location = new System.Drawing.Point(197, 484);
            this.midtermGrade_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.midtermGrade_textbox.Name = "midtermGrade_textbox";
            this.midtermGrade_textbox.Size = new System.Drawing.Size(88, 28);
            this.midtermGrade_textbox.TabIndex = 8;
            this.midtermGrade_textbox.TextChanged += new System.EventHandler(this.midtermGrade_textbox_TextChanged);
            // 
            // finalTermGrade_textbox
            // 
            this.finalTermGrade_textbox.AcceptsReturn = true;
            this.finalTermGrade_textbox.AcceptsTab = true;
            this.finalTermGrade_textbox.AllowDrop = true;
            this.finalTermGrade_textbox.CausesValidation = false;
            this.finalTermGrade_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalTermGrade_textbox.Location = new System.Drawing.Point(197, 535);
            this.finalTermGrade_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finalTermGrade_textbox.Name = "finalTermGrade_textbox";
            this.finalTermGrade_textbox.Size = new System.Drawing.Size(88, 28);
            this.finalTermGrade_textbox.TabIndex = 9;
            this.finalTermGrade_textbox.TextChanged += new System.EventHandler(this.finalTermGrade_textbox_TextChanged);
            // 
            // report_panel
            // 
            this.report_panel.Controls.Add(this.letterGrade_label);
            this.report_panel.Controls.Add(this.reportFinalTermPercent_textbox);
            this.report_panel.Controls.Add(this.reportMidtermPercent_textbox);
            this.report_panel.Controls.Add(this.reportQuizPercent_textbox);
            this.report_panel.Controls.Add(this.label3);
            this.report_panel.Controls.Add(this.label2);
            this.report_panel.Controls.Add(this.label1);
            this.report_panel.Controls.Add(this.reportFinalGrade_textbox);
            this.report_panel.Controls.Add(this.reportQuizAverage_textBox);
            this.report_panel.Controls.Add(this.reportFinalTerm_textbox);
            this.report_panel.Controls.Add(this.reportMidterm_textbox);
            this.report_panel.Controls.Add(this.reportHeader_label);
            this.report_panel.Controls.Add(this.label5);
            this.report_panel.Controls.Add(this.reportCourse_label);
            this.report_panel.Controls.Add(this.reportID_label);
            this.report_panel.Controls.Add(this.reportName_label);
            this.report_panel.Controls.Add(this.reportFinalGrade_label);
            this.report_panel.Controls.Add(this.reportFinalTerm_label);
            this.report_panel.Controls.Add(this.reportMidterm_label);
            this.report_panel.Controls.Add(this.reportQuizAverage_label);
            this.report_panel.Controls.Add(this.studentGradeReport_label);
            this.report_panel.Enabled = false;
            this.report_panel.Location = new System.Drawing.Point(487, 18);
            this.report_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.report_panel.Name = "report_panel";
            this.report_panel.Size = new System.Drawing.Size(397, 630);
            this.report_panel.TabIndex = 25;
            // 
            // letterGrade_label
            // 
            this.letterGrade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterGrade_label.Location = new System.Drawing.Point(241, 402);
            this.letterGrade_label.Name = "letterGrade_label";
            this.letterGrade_label.Size = new System.Drawing.Size(135, 36);
            this.letterGrade_label.TabIndex = 24;
            this.letterGrade_label.Text = "(letter grade)";
            this.letterGrade_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportFinalTermPercent_textbox
            // 
            this.reportFinalTermPercent_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportFinalTermPercent_textbox.Location = new System.Drawing.Point(269, 328);
            this.reportFinalTermPercent_textbox.Name = "reportFinalTermPercent_textbox";
            this.reportFinalTermPercent_textbox.ReadOnly = true;
            this.reportFinalTermPercent_textbox.Size = new System.Drawing.Size(73, 24);
            this.reportFinalTermPercent_textbox.TabIndex = 23;
            // 
            // reportMidtermPercent_textbox
            // 
            this.reportMidtermPercent_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportMidtermPercent_textbox.Location = new System.Drawing.Point(269, 288);
            this.reportMidtermPercent_textbox.Name = "reportMidtermPercent_textbox";
            this.reportMidtermPercent_textbox.ReadOnly = true;
            this.reportMidtermPercent_textbox.Size = new System.Drawing.Size(73, 24);
            this.reportMidtermPercent_textbox.TabIndex = 22;
            // 
            // reportQuizPercent_textbox
            // 
            this.reportQuizPercent_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportQuizPercent_textbox.Location = new System.Drawing.Point(269, 255);
            this.reportQuizPercent_textbox.Name = "reportQuizPercent_textbox";
            this.reportQuizPercent_textbox.ReadOnly = true;
            this.reportQuizPercent_textbox.Size = new System.Drawing.Size(73, 24);
            this.reportQuizPercent_textbox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "50 %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "30 %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "20%";
            // 
            // reportFinalGrade_textbox
            // 
            this.reportFinalGrade_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportFinalGrade_textbox.Location = new System.Drawing.Point(269, 371);
            this.reportFinalGrade_textbox.Name = "reportFinalGrade_textbox";
            this.reportFinalGrade_textbox.ReadOnly = true;
            this.reportFinalGrade_textbox.Size = new System.Drawing.Size(73, 27);
            this.reportFinalGrade_textbox.TabIndex = 17;
            // 
            // reportQuizAverage_textBox
            // 
            this.reportQuizAverage_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportQuizAverage_textBox.Location = new System.Drawing.Point(113, 253);
            this.reportQuizAverage_textBox.Name = "reportQuizAverage_textBox";
            this.reportQuizAverage_textBox.ReadOnly = true;
            this.reportQuizAverage_textBox.Size = new System.Drawing.Size(56, 24);
            this.reportQuizAverage_textBox.TabIndex = 16;
            // 
            // reportFinalTerm_textbox
            // 
            this.reportFinalTerm_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportFinalTerm_textbox.Location = new System.Drawing.Point(113, 319);
            this.reportFinalTerm_textbox.Name = "reportFinalTerm_textbox";
            this.reportFinalTerm_textbox.ReadOnly = true;
            this.reportFinalTerm_textbox.Size = new System.Drawing.Size(56, 24);
            this.reportFinalTerm_textbox.TabIndex = 15;
            // 
            // reportMidterm_textbox
            // 
            this.reportMidterm_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportMidterm_textbox.Location = new System.Drawing.Point(113, 288);
            this.reportMidterm_textbox.Name = "reportMidterm_textbox";
            this.reportMidterm_textbox.ReadOnly = true;
            this.reportMidterm_textbox.Size = new System.Drawing.Size(56, 24);
            this.reportMidterm_textbox.TabIndex = 14;
            // 
            // reportHeader_label
            // 
            this.reportHeader_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportHeader_label.Location = new System.Drawing.Point(13, 194);
            this.reportHeader_label.Name = "reportHeader_label";
            this.reportHeader_label.Size = new System.Drawing.Size(377, 37);
            this.reportHeader_label.TabIndex = 13;
            this.reportHeader_label.Text = "      Type      |   Score   |   Percentage   |    Value";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(2, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 10);
            this.label5.TabIndex = 11;
            // 
            // reportCourse_label
            // 
            this.reportCourse_label.AutoSize = true;
            this.reportCourse_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportCourse_label.Location = new System.Drawing.Point(15, 123);
            this.reportCourse_label.Name = "reportCourse_label";
            this.reportCourse_label.Size = new System.Drawing.Size(72, 20);
            this.reportCourse_label.TabIndex = 10;
            this.reportCourse_label.Text = "(course)";
            // 
            // reportID_label
            // 
            this.reportID_label.AutoSize = true;
            this.reportID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportID_label.Location = new System.Drawing.Point(15, 92);
            this.reportID_label.Name = "reportID_label";
            this.reportID_label.Size = new System.Drawing.Size(95, 20);
            this.reportID_label.TabIndex = 9;
            this.reportID_label.Text = "(id number)";
            // 
            // reportName_label
            // 
            this.reportName_label.AutoSize = true;
            this.reportName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportName_label.Location = new System.Drawing.Point(13, 62);
            this.reportName_label.Name = "reportName_label";
            this.reportName_label.Size = new System.Drawing.Size(122, 20);
            this.reportName_label.TabIndex = 8;
            this.reportName_label.Text = "(student name)";
            // 
            // reportFinalGrade_label
            // 
            this.reportFinalGrade_label.AutoSize = true;
            this.reportFinalGrade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportFinalGrade_label.Location = new System.Drawing.Point(151, 377);
            this.reportFinalGrade_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reportFinalGrade_label.Name = "reportFinalGrade_label";
            this.reportFinalGrade_label.Size = new System.Drawing.Size(101, 20);
            this.reportFinalGrade_label.TabIndex = 6;
            this.reportFinalGrade_label.Text = "Final Grade ";
            // 
            // reportFinalTerm_label
            // 
            this.reportFinalTerm_label.AutoSize = true;
            this.reportFinalTerm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportFinalTerm_label.Location = new System.Drawing.Point(16, 328);
            this.reportFinalTerm_label.Name = "reportFinalTerm_label";
            this.reportFinalTerm_label.Size = new System.Drawing.Size(78, 18);
            this.reportFinalTerm_label.TabIndex = 3;
            this.reportFinalTerm_label.Text = "Final Term";
            // 
            // reportMidterm_label
            // 
            this.reportMidterm_label.AutoSize = true;
            this.reportMidterm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportMidterm_label.Location = new System.Drawing.Point(16, 290);
            this.reportMidterm_label.Name = "reportMidterm_label";
            this.reportMidterm_label.Size = new System.Drawing.Size(62, 18);
            this.reportMidterm_label.TabIndex = 2;
            this.reportMidterm_label.Text = "Midterm";
            // 
            // reportQuizAverage_label
            // 
            this.reportQuizAverage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportQuizAverage_label.Location = new System.Drawing.Point(15, 255);
            this.reportQuizAverage_label.Name = "reportQuizAverage_label";
            this.reportQuizAverage_label.Size = new System.Drawing.Size(103, 24);
            this.reportQuizAverage_label.TabIndex = 1;
            this.reportQuizAverage_label.Text = "Quiz Average: ";
            // 
            // studentGradeReport_label
            // 
            this.studentGradeReport_label.AutoSize = true;
            this.studentGradeReport_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGradeReport_label.Location = new System.Drawing.Point(109, 7);
            this.studentGradeReport_label.Name = "studentGradeReport_label";
            this.studentGradeReport_label.Size = new System.Drawing.Size(186, 22);
            this.studentGradeReport_label.TabIndex = 0;
            this.studentGradeReport_label.Text = "Student Grade Report";
            // 
            // verticalLine_label
            // 
            this.verticalLine_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.verticalLine_label.Location = new System.Drawing.Point(463, 25);
            this.verticalLine_label.Margin = new System.Windows.Forms.Padding(0);
            this.verticalLine_label.Name = "verticalLine_label";
            this.verticalLine_label.Size = new System.Drawing.Size(1, 622);
            this.verticalLine_label.TabIndex = 26;
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(320, 598);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(119, 50);
            this.exit_button.TabIndex = 12;
            this.exit_button.Text = "E&xit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.Location = new System.Drawing.Point(177, 598);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(124, 50);
            this.reset_button.TabIndex = 11;
            this.reset_button.Text = "&Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // list_of_Quiz_textbox
            // 
            this.list_of_Quiz_textbox.AcceptsReturn = true;
            this.list_of_Quiz_textbox.AcceptsTab = true;
            this.list_of_Quiz_textbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.list_of_Quiz_textbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list_of_Quiz_textbox.Location = new System.Drawing.Point(299, 231);
            this.list_of_Quiz_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_of_Quiz_textbox.Multiline = true;
            this.list_of_Quiz_textbox.Name = "list_of_Quiz_textbox";
            this.list_of_Quiz_textbox.ReadOnly = true;
            this.list_of_Quiz_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.list_of_Quiz_textbox.Size = new System.Drawing.Size(105, 196);
            this.list_of_Quiz_textbox.TabIndex = 0;
            this.list_of_Quiz_textbox.TabStop = false;
            this.list_of_Quiz_textbox.WordWrap = false;
            this.list_of_Quiz_textbox.TextChanged += new System.EventHandler(this.quiz_inputvalue_textbox_TextChanged);
            // 
            // removeAll_button
            // 
            this.removeAll_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAll_button.Location = new System.Drawing.Point(95, 377);
            this.removeAll_button.Name = "removeAll_button";
            this.removeAll_button.Size = new System.Drawing.Size(189, 39);
            this.removeAll_button.TabIndex = 7;
            this.removeAll_button.Text = "R&emove All";
            this.removeAll_button.UseVisualStyleBackColor = true;
            this.removeAll_button.Click += new System.EventHandler(this.removeAll_button_Click);
            // 
            // quizerrormessage_label
            // 
            this.quizerrormessage_label.AutoSize = true;
            this.quizerrormessage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizerrormessage_label.Location = new System.Drawing.Point(166, 208);
            this.quizerrormessage_label.Name = "quizerrormessage_label";
            this.quizerrormessage_label.Size = new System.Drawing.Size(0, 16);
            this.quizerrormessage_label.TabIndex = 30;
            // 
            // midtermprompt_label
            // 
            this.midtermprompt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtermprompt_label.Location = new System.Drawing.Point(341, 484);
            this.midtermprompt_label.Name = "midtermprompt_label";
            this.midtermprompt_label.Size = new System.Drawing.Size(106, 40);
            this.midtermprompt_label.TabIndex = 31;
            this.midtermprompt_label.Text = "Enter midterm mark here.";
            // 
            // finaltermprompt_label
            // 
            this.finaltermprompt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finaltermprompt_label.Location = new System.Drawing.Point(341, 537);
            this.finaltermprompt_label.Name = "finaltermprompt_label";
            this.finaltermprompt_label.Size = new System.Drawing.Size(106, 42);
            this.finaltermprompt_label.TabIndex = 32;
            this.finaltermprompt_label.Text = "Enter final mark here.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Assignment_2_Final_Grade_Calculator_Using_a_GUI.Properties.Resources.enter_key;
            this.pictureBox2.InitialImage = global::Assignment_2_Final_Grade_Calculator_Using_a_GUI.Properties.Resources.enter_key;
            this.pictureBox2.Location = new System.Drawing.Point(301, 536);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment_2_Final_Grade_Calculator_Using_a_GUI.Properties.Resources.enter_key;
            this.pictureBox1.InitialImage = global::Assignment_2_Final_Grade_Calculator_Using_a_GUI.Properties.Resources.enter_key;
            this.pictureBox1.Location = new System.Drawing.Point(301, 484);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // gradeCalculator_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 670);
            this.Controls.Add(this.finaltermprompt_label);
            this.Controls.Add(this.midtermprompt_label);
            this.Controls.Add(this.quizerrormessage_label);
            this.Controls.Add(this.removeAll_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.verticalLine_label);
            this.Controls.Add(this.report_panel);
            this.Controls.Add(this.finalTermGrade_textbox);
            this.Controls.Add(this.midtermGrade_textbox);
            this.Controls.Add(this.finalTerm_label);
            this.Controls.Add(this.midterm_label);
            this.Controls.Add(this.remove_a_Quiz_button);
            this.Controls.Add(this.add_a_Quiz_button);
            this.Controls.Add(this.quiz_inputvalue_textbox);
            this.Controls.Add(this.enterValuePrompt_label);
            this.Controls.Add(this.quizGrades_label);
            this.Controls.Add(this.course_textbox);
            this.Controls.Add(this.course_label);
            this.Controls.Add(this.idNumber_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.idNumber_label);
            this.Controls.Add(this.list_of_Quiz_textbox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.StudentInfo_label);
            this.Controls.Add(this.dropValue_checkbox);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.Marks_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gradeCalculator_form";
            this.Text = "Grade Calculator";
            this.report_panel.ResumeLayout(false);
            this.report_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Marks_label;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.CheckBox dropValue_checkbox;
        private System.Windows.Forms.Label StudentInfo_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label idNumber_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox idNumber_textbox;
        private System.Windows.Forms.Label course_label;
        private System.Windows.Forms.TextBox course_textbox;
        private System.Windows.Forms.Label quizGrades_label;
        private System.Windows.Forms.Label enterValuePrompt_label;
        private System.Windows.Forms.TextBox quiz_inputvalue_textbox;
        private System.Windows.Forms.Button add_a_Quiz_button;
        private System.Windows.Forms.Button remove_a_Quiz_button;
        private System.Windows.Forms.Label midterm_label;
        private System.Windows.Forms.Label finalTerm_label;
        private System.Windows.Forms.TextBox midtermGrade_textbox;
        private System.Windows.Forms.TextBox finalTermGrade_textbox;
        private System.Windows.Forms.Panel report_panel;
        private System.Windows.Forms.Label verticalLine_label;
        private System.Windows.Forms.Label reportFinalTerm_label;
        private System.Windows.Forms.Label reportMidterm_label;
        private System.Windows.Forms.Label reportQuizAverage_label;
        private System.Windows.Forms.Label studentGradeReport_label;
        private System.Windows.Forms.Label reportFinalGrade_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label reportCourse_label;
        private System.Windows.Forms.Label reportID_label;
        private System.Windows.Forms.Label reportName_label;
        private System.Windows.Forms.Label reportHeader_label;
        private System.Windows.Forms.TextBox reportFinalTermPercent_textbox;
        private System.Windows.Forms.TextBox reportMidtermPercent_textbox;
        private System.Windows.Forms.TextBox reportQuizPercent_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reportFinalGrade_textbox;
        private System.Windows.Forms.TextBox reportQuizAverage_textBox;
        private System.Windows.Forms.TextBox reportFinalTerm_textbox;
        private System.Windows.Forms.TextBox reportMidterm_textbox;
        private System.Windows.Forms.TextBox list_of_Quiz_textbox;
        private System.Windows.Forms.Button removeAll_button;
        private System.Windows.Forms.Label letterGrade_label;
        private System.Windows.Forms.Label quizerrormessage_label;
        private System.Windows.Forms.Label midtermprompt_label;
        private System.Windows.Forms.Label finaltermprompt_label;
    }
}

