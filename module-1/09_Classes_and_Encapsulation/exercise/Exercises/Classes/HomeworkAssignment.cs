namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        
        public HomeworkAssignment(int possiblemarks, string submittername)
        {
            PossibleMarks = possiblemarks;
            SubmitterName = submittername;
            
        }

        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }
        public string LetterGrade
        {
            get
            {
                int grade = (EarnedMarks / PossibleMarks) * 100;
                if (grade >= 90)
                {
                    return "A";
                }
                else if (grade >= 80 && grade <= 89)
                {
                    return "B";
                }
                else if (grade >= 70 && grade <= 79)
                {
                    return "C";
                }
                else if (grade >= 60 && grade <= 69)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }





    }

}

