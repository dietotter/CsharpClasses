// TASK 3
class Worker
{
    public int Wage { get; }

    public Worker(int wage = 0)
    {
        Wage = wage;
    }

    public static Worker operator +(Worker worker, int bonus) => new Worker(worker.Wage + bonus);
}