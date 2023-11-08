namespace ChemistryQuizTest
{
    public class QuizService
    {
        private List<QuizQuestion> questions;

        public QuizService()
        {
            // Questions
            questions = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Question = "What is the chemical symbol for gold?",
                Options = new List<string> { "Au", "Ag", "Hg", "Fe" },
                CorrectAnswer = "Au"
            },
            // Add more questions here.
        };
        }

        public QuizQuestion GetRandomQuestion()
        {
            Random random = new Random();
            return questions[random.Next(questions.Count)];
        }
    }

}
