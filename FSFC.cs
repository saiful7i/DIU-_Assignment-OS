public class Program
{
  public static void Main(string[] args)
  {
   Console.Write($"Please Enter the Number of Process:");
   int n = Convert.ToInt32(Console.ReadLine());

   int[] burstT = new int[n];
   int[] waitingT = new int[n];
   int[] turnAroundT = new int[n];
   int[] completionT = new int[n];

   for(int i = 0; i<n; i++){
    Console.Write($"Enter burst Time for process P{i+1}:");
    burstT[i] = Convert.ToInt32(Console.ReadLine());
   }
   //Completion, Waiting & Turnaround Time Calculation 
    waitingT[0] = 0;
    completionT[0] = burstT[0];
    turnAroundT[0] = waitingT[0];

    for(int i=1; i<n; i++){
      completionT[i] = completionT[i-1]+burstT[i];
      turnAroundT[i] = completionT[i];
      waitingT[i] = turnAroundT[i]-burstT[i];
    }

    Console.WriteLine($"Process\tBurst\tCompletion\tWaiting\tTurnaround");
    for (int i =0; i<n  ; i++){
      Console.WriteLine
      ($" P{i+1}\t{burstT[i]}\t{completionT[i]}\t\t{waitingT[i]}\t{turnAroundT[i]}");
    }

    //Average Waiting and Turnaround Time Calculation
    double awt;
    double att;
    int nop = burstT.Length;
    int sumOfWaitingT = 0;
    int sumOfatt = 0;

    for (int i = 0; i < n; i++)
    {
     sumOfWaitingT += waitingT[i];
     sumOfatt += turnAroundT[i];      
    }
    awt = (double)sumOfWaitingT/nop;
    att =(double)sumOfatt/nop;

    Console.WriteLine($"Average Waiting Time: {awt:F2}");
    Console.WriteLine($"Average Turn Around Time: {att:F2}");
    }
  }

