using System;

namespace schoolManagment 
{
    public class EnglishPaper : IScored
    {
        public string Title { get; set; }
        public int MinimumWordCount { get; set; }
        public string PaperText { get; set; }
        public float Score { get; set; }
        public float MaximumScore { get; set; }

        public int WordCount {
            get { return PaperText.countNow(); }
        }
    }
}