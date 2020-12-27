using System;

namespace schoolManagment 
{
    public interface IScored 
    {
        float Score { get; set; }
        float MaximumScore { get; set; }      
    }
}