using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace VocabTrainer
{
    public partial class Window : Form
    {
        private readonly Vocabulary voc = new Vocabulary();
        private Vocabulary clone = new Vocabulary();
        private KeyValuePair<string, string[]> current = new KeyValuePair<string, string[]>();
        private int correctAnswers = 0;
        private bool answerShown = false;

        public Window() => InitializeComponent();

        private void Window_Load(object sender, EventArgs e)
            => UpdateScoreLabel();

        private void OpenButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                openFileDialog.ShowDialog();
        }

        private void CheckButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Check();
        }

        private void RestartButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Start();
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            voc.Clear();
            var lines = File.ReadAllLines(openFileDialog.FileName);

            foreach (var l in lines)
            {
                var spl = l.Split('=');

                if (spl.Length == 2)
                    voc.Add(spl[0], spl[1].Split('|'));
            }

            Start();
        }

        private void Check()
        {
            var answers = answerBox.Lines.Where(v => v.Length > 0).Select(v => v.ToLower()).ToList();
            var cond = true;

            if (current.Value.Length > 0)
                foreach (var x in current.Value)
                    if (!answers.Contains(x.ToLower()))
                        cond = false;
            else
                cond = answers[0] == current.Value[0].ToLower();


            if (cond)
            {
                if (!answerShown)
                    correctAnswers++;

                UpdateScoreLabel();
                LoadWords();
            }
            else
            {
                if (!answerShown)
                {
                    var lines = new List<string>();
                    lines.Add(taskBox.Lines[0] + " =");
                    lines.AddRange(current.Value);

                    taskBox.Lines = lines.ToArray();
                    answerShown = true;
                }

                UpdateScoreLabel();
            }

            answerBox.Focus();
            answerBox.Clear();
        }

        private void Start()
        {
            restartButton.Enabled = true;
            clone.Clear();

            voc.ForEach((left, right)
                => clone.Add(left, right));

            correctAnswers = 0;
            answerShown = false;
            answerBox.Clear();

            LoadWords();
            UpdateScoreLabel();
        }


        private void LoadWords()
        {
            checkButton.Enabled = clone.Size > 0;

            if (clone.Size > 0)
            {
                var rnd = new Random();
                var index = (int)(rnd.NextDouble() * clone.Size);

                current = clone[index];
                clone.RemoveAt(index);

                taskBox.Text = current.Key;
                answerShown = false;
            }
        }

        private void UpdateScoreLabel()
        {
            var percentage = (voc.Size - clone.Size > 0) ? (correctAnswers / (float)(voc.Size - clone.Size)) : 0;
            var points = Math.Min(Math.Max((int)(16 * (percentage - .1999f) / .8001f), 0), 15);
            var grade = "?";

            if (clone.Size != voc.Size)
            {
                switch (points)
                {
                    case 0: grade = "6"; break;
                    case 1: grade = "5-"; break;
                    case 2: grade = "5"; break;
                    case 3: grade = "5+"; break;
                    case 4: grade = "4-"; break;
                    case 5: grade = "4"; break;
                    case 6: grade = "4+"; break;
                    case 7: grade = "3-"; break;
                    case 8: grade = "3"; break;
                    case 9: grade = "3+"; break;
                    case 10: grade = "2-"; break;
                    case 11: grade = "2"; break;
                    case 12: grade = "2+"; break;
                    case 13: grade = "1-"; break;
                    case 14: grade = "1"; break;
                    case 15: grade = "1+"; break;
                }
            }

            var correct = (int)Math.Round(100 * percentage);

            scoreLabel.Text = $"{voc.Size - clone.Size}/{voc.Size} - {correctAnswers} Correct {correct}% - Points {points} - Grade {grade}";
        }

        private void AnswerBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
                answerBox.Clear();
        }

        private void AnswerBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift && checkButton.Enabled)
                Check();
        }
    }
}