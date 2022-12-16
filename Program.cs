using System;

namespace CircularQueues_Csharp
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            /* Initializing the values of the variebles REAR and FRONT to -1 
             * to indicate that queue is initialy empty. */
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            /* This statement checks for the overflow condition. */
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
            }
            /* The following statement checks whether the queue is empty. 
             * if the queue is empty then value of REAR and FRONT variables 
             * is set to 0. */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
        }
    }
}
