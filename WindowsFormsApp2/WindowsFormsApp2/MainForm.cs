using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private int score = 0;

        public MainForm()
        {
            InitializeComponent();
            InitializeQuestions();
            DisplayQuestion();
        }

        private void InitializeQuestions()
        {
            // Ajouter vos questions ici
            questions.Add(new Question("Quelle est la capitale de la France?", new string[] { "Paris", "Londres", "Berlin" }, "Paris"));
            questions.Add(new Question("Quelle est la couleur du ciel par temps clair?", new string[] { "Rouge", "Bleu", "Vert" }, "Bleu"));
            // Ajouter plus de questions si nécessaire
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];
                lblQuestion.Text = currentQuestion.Text;
                radioBtnChoice1.Text = currentQuestion.Choices[0];
                radioBtnChoice2.Text = currentQuestion.Choices[1];
                radioBtnChoice3.Text = currentQuestion.Choices[2];
            }
            else
            {
                MessageBox.Show("Le quizz est terminé! Votre score est de " + score + " points.");
                Application.Exit();
            }
        }

        private void CheckAnswer(string selectedAnswer)
        {
            Question currentQuestion = questions[currentQuestionIndex];
            if (selectedAnswer == currentQuestion.CorrectAnswer)
            {
                score++;
                MessageBox.Show("Bonne réponse! Vous avez gagné 1 point.");
            }
            else
            {
                MessageBox.Show("Mauvaise réponse. La bonne réponse était: " + currentQuestion.CorrectAnswer);
            }

            currentQuestionIndex++;
            DisplayQuestion();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioBtnChoice1.Checked)
                CheckAnswer(radioBtnChoice1.Text);
            else if (radioBtnChoice2.Checked)
                CheckAnswer(radioBtnChoice2.Text);
            else if (radioBtnChoice3.Checked)
                CheckAnswer(radioBtnChoice3.Text);
            else
                MessageBox.Show("Veuillez sélectionner une réponse.");
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string text, string[] choices, string correctAnswer)
        {
            Text = text;
            Choices = choices;
            CorrectAnswer = correctAnswer;
        }
    }
}
