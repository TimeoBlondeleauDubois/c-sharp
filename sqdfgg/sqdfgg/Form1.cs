using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuizForm : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;

        public QuizForm()
        {
            InitializeComponent();

            // Initialise les questions
            InitializeQuestions();

            // Affiche la première question
            DisplayQuestion(0);
        }

        private void InitializeQuestions()
        {
            // Initialise la liste de questions
            questions = new List<Question>
            {
                new Question("Quel est le plus grand organisme vivant sur Terre ?", new List<string> { "Baleine bleue", "Séquoia géant", "Mycélium de champignon", "Grande barrière de corail" }, "Mycélium de champignon"),
                new Question("Quel est l'élément chimique le plus abondant dans l'univers ?", new List<string> { "Hydrogène", "Oxygène", "Carbone", "Azote" }, "Hydrogène"),
                new Question("Quelle est la distance approximative entre la Terre et la Lune ?", new List<string> { "384 000 km", "149 600 000 km", "12 742 km", "6 371 km" }, "384 000 km"),
                new Question("Quelle est la température la plus élevée jamais enregistrée sur Terre ?", new List<string> { "70,7°C (159.3°F)", "56,7°C (134°F)", "45,0°C (113°F)", "48,9°C (120°F)" }, "70,7°C (159.3°F)"),
                new Question("Quelle est la plus grande planète du système solaire ?", new List<string> { "Jupiter", "Saturne", "Neptune", "Uranus" }, "Jupiter"),

            };
        }

        private void DisplayQuestion(int index)
        {
            // Vérifie si l'index est valide
            if (index >= 0 && index < questions.Count)
            {
                currentQuestionIndex = index;
                Question currentQuestion = questions[index];
                questionLabel.Text = currentQuestion.Text;

                // Affiche les options de réponse
                for (int i = 0; i < currentQuestion.Options.Count; i++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = currentQuestion.Options[i];
                    radioButton.AutoSize = true;
                    radioButton.Location = new Point(20, 50 + i * 30);
                    radioButton.CheckedChanged += (sender, e) =>
                    {
                        if (radioButton.Checked)
                        {
                            SubmitAnswer(radioButton.Text);
                        }
                    };
                    Controls.Add(radioButton);
                }
            }
        }

        private void SubmitAnswer(string selectedAnswer)
        {
            // Vérifie la réponse
            if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
            {
                MessageBox.Show("Correct !", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect !", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Passe à la question suivante
            if (currentQuestionIndex < questions.Count - 1)
            {
                ClearRadioButtons();
                DisplayQuestion(currentQuestionIndex + 1);
            }
            else
            {
                MessageBox.Show("Quiz terminé !", "Résultat Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void ClearRadioButtons()
        {
            // Supprime tous les contrôles de type RadioButton
            foreach (Control control in Controls)
            {
                if (control is RadioButton)
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string text, List<string> options, string correctAnswer)
        {
            Text = text;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
}
