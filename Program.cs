int examAssignments = 5;  // Number of regular exam assignments

// Arrays for student names and their respective assignment scores
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// Individual score arrays for each student
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// Array to store scores dynamically depending on the student being processed
int[] studentScores = new int[10];

string currentStudentLetterGrade = "";  // Variable to store the letter grade for each student

// Display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    // Assign the correct student's scores based on their name
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // Initialize counters and variables to store sums and averages
    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;
    int sumExamScores = 0;
    int sumExtraCreditScores = 0;
    decimal currentStudentExamScore = 0;
    decimal finalNumericScore = 0;
    decimal extraCreditPoints = 0;

    // Sum the exam and extra credit scores, also count extra credit assignments
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)  // Exam scores
        {
            sumExamScores += score;
        }
        else  // Extra credit scores
        {
            gradedExtraCreditAssignments += 1;
            sumExtraCreditScores += score;
        }
    }

    // Calculate the average exam score
    currentStudentExamScore = (decimal)(sumExamScores) / examAssignments;

    // Calculate the final numeric score (with 10% of the extra credit added to the exam scores)
    finalNumericScore = (decimal)(sumExamScores + (sumExtraCreditScores * 0.1)) / examAssignments;

    // Calculate the extra credit points earned (10% of the extra credit scores)
    extraCreditPoints = (decimal)(sumExtraCreditScores * 0.1);

    // Determine the letter grade based on the final numeric score
    if (finalNumericScore >= 97)
        currentStudentLetterGrade = "A+";
    else if (finalNumericScore >= 93)
        currentStudentLetterGrade = "A";
    else if (finalNumericScore >= 90)
        currentStudentLetterGrade = "A-";
    else if (finalNumericScore >= 87)
        currentStudentLetterGrade = "B+";
    else if (finalNumericScore >= 83)
        currentStudentLetterGrade = "B";
    else if (finalNumericScore >= 80)
        currentStudentLetterGrade = "B-";
    else if (finalNumericScore >= 77)
        currentStudentLetterGrade = "C+";
    else if (finalNumericScore >= 73)
        currentStudentLetterGrade = "C";
    else if (finalNumericScore >= 70)
        currentStudentLetterGrade = "C-";
    else if (finalNumericScore >= 67)
        currentStudentLetterGrade = "D+";
    else if (finalNumericScore >= 63)
        currentStudentLetterGrade = "D";
    else if (finalNumericScore >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    // Output the student's score, grade, and extra credit info
    // Format: Student Name | Exam Score | Overall Grade | Extra Credit
    Console.WriteLine($"{currentStudent,-15}{currentStudentExamScore:F1}\t\t{finalNumericScore:F2}\t{currentStudentLetterGrade}\t{(sumExamScores / examAssignments):F0} ({extraCreditPoints:F2} pts)");
}

// Keep the output window open for reading results
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
