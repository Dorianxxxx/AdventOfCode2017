using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EighteenthPuzzle
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Select a input file",
                Filter = "Txt file|*.txt"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            var input = File.ReadAllLines(openFileDialog.FileName);
            var puzzleSolver = new PuzzleSolver(input);
            Console.WriteLine(puzzleSolver.SolveFirst());
            Console.WriteLine(puzzleSolver.SolveSecond().Result);
            Console.ReadLine();
        }
    }
}
