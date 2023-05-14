namespace pz_28;

public class Student
{
    private int _sumOfMarks = 0;
    private int _countOfMarks = 0;
    private double _average = 0;

    public delegate void MarkHandler(double average);
    public event MarkHandler? OnAddMark;

    public void AddMark(int mark)
    {
        _sumOfMarks += mark;
        _countOfMarks++;

        _average = (double)_sumOfMarks / _countOfMarks;
        
        OnAddMark?.Invoke(_average);
    }
}