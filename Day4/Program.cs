namespace Day4
{
     class Program
    {
        static void Main()
        {
            #region Typr  of Array:
            //The type of Array
            //array should has size

            //-----------------------sigle Dimenstional Array---------------

            int n = Convert.ToInt32 (Console.ReadLine());
            int[] arr1= new int[n];

            //The array is Accessed by Index
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;
            arr1[3] = 4;
            arr1[4] = 5;
            // arr1[5] = 6; this is out of Bound width



            //----------------------Multi Dimenstional Array---------------

            //1, 2, 3, 4,
            //5, 6 ,8 ,7 ===> matrix
            //4, 5, 6
            int[,] Grades = new int[2,2];
            Grades[0, 0] = 1;
            Grades[1, 0] = 2;
            Grades[1, 0] = 1;
            Grades[1, 1] = 1;


            //----------------------Jagged Array---------------

            int[][] Employees = new int[2][];
            Employees[0]= new int[3] { 1, 2, 3};
            Employees[1]= new int[2] {1, 2 };




            //...........................array example ........................

            //sigle example:
            int e = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[e];
            name[0] = "khaloud";
            name[1] = "Hamed";
            name[2] = "Almamri";

            //Multi example:
            int[,] g = new int[2, 2];
            g[0, 0] = 2;
            g[1, 0] = 5;

            //Jagged example:
            int[][] salary = new int[2][];
            salary[0] = new int[5] { 1, 2, 3, 4, 5 };
            salary[1] = new int[2] { 1, 2 };
#endregion

            //------------------------------------------------------------------------------
            //------------------------------------------------------------------------------
           

        }
    }
}