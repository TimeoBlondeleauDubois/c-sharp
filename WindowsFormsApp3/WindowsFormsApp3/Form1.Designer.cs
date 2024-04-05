using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        private object questionLabel;

        public Form1()
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
                new Question("Quelle est la capitale de la France ?", new List<string> { "Paris", "Londres", "Berlin", "Madrid" }, "Paris"),
                new Question("Quelle est la couleur du ciel ?", new List<string> { "Rouge", "Bleu", "Vert", "Jaune" }, "Bleu"),
                new Question("Combien de continents y a-t-il sur Terre ?", new List<string> { "3", "5", "7", "9" }, "7"),
                // Ajoutez autant de questions que vous le souhaitez
            };
        }

        private void DisplayQuestion(int index)
        {
            // Vérifie si l'index est valide
            if (index >= 0 && index < questions.Count)
            {
                currentQuestionIndex = index;
                Question currentQuestion = questions[index];
                questionLabel = currentQuestion.Text;

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
