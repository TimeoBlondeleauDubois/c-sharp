using System;
using Microsoft.Maui.Controls;

namespace QuizzApp
{

    public class QuizzPage : ContentPage
    {
        private readonly string[] questions = { "Quelle est la capitale de la France ?", "Quelle est la capitale du Japon ?", "Quelle est la capitale de l'Inde ?" };
        private readonly string[] answers = { "Paris", "Tokyo", "New Delhi" };
        private readonly string[] options = { "Paris", "Londres", "Berlin", "Tokyo", "Pékin", "New Delhi" };

        private int currentQuestionIndex;
        private Label questionLabel;
        private Picker optionsPicker;
        private Button submitButton;

        public QuizzPage(int index)
        {
            currentQuestionIndex = index;

            questionLabel = new Label
            {
                Text = questions[index],
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            optionsPicker = new Picker
            {
                Title = "Sélectionnez une réponse",
                ItemsSource = options,
                SelectedIndex = -1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            submitButton = new Button
            {
                Text = "Soumettre",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            submitButton.Clicked += SubmitButton_Clicked;

            Content = new StackLayout
            {
                Children = { questionLabel, optionsPicker, submitButton }
            };
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            if (optionsPicker.SelectedIndex == Array.IndexOf(answers, optionsPicker.SelectedItem as string))
            {
                DisplayAlert("Résultat", "Bonne réponse!", "Suivant");
            }
            else
            {
                DisplayAlert("Résultat", "Mauvaise réponse!", "Suivant");
            }

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Length)
            {
                Navigation.PushAsync(new QuizzPage(currentQuestionIndex));
            }
            else
            {
                DisplayAlert("Fin du quizz", "Vous avez terminé le quizz!", "OK");
                Navigation.PopToRootAsync();
            }
        }
    }
}
