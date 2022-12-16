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
             to indicate that queue is initialy empty. */
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
             if the queue is empty then value of REAR and FRONT variables 
             is set to 0. */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* if REAR is at the last position of the array, then the 
                 value of REAR is setmto 0 that corresponds to 
                 the first position of the array. */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /* if REAR is not at the last position, 
                     then its value is increment by one. */
                    REAR = REAR + 1;
            }
            /* once the position of REAR is determined, the element is added at its proper place. */
            queue_array[REAR] = element;
        }
        public void remove()
        {
            /*Checks whether the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is : " + queue_array[FRONT] + "\n");
            /* Checks if the queue has one element. */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /* FRONT the element tp be deleted is at the last position of the array, then the value of FRONT is set to 0 i.e to thr first element of array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    /* FRONT is incremented by one if it is not the first element of array. */
                    FRONT = FRONT + 1;
            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /*checks if the queue is empty/ */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("nElements in the queue are...............\n");
            if (FRONT_position <= REAR_position)
            {
                /* traverses the queue till the last element present in an array. */
                while (FRONT_position <= REAR_position)
                {
                    Console.WriteLine(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /* traverses the queue till the last position of the array. */
                while (FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "    ");
                    FRONT_position++;
                }
                /* set the FRONT position to the first element of the array/ */
                FRONT_position = 0;
                /*traverses the array till the last element present in the queue/ */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number: ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                q.insert(num);
                            }
                            break;
                    }
                }
                catch (Exception e)
                {

                    throw;
                }
                {

                }
            }
        }
    }
}
