/**************************************************************
* Name        : FirstComeFirstServedTickets
* Author      : Kabrina Brady
* Created     : 2/17/2021
* Course      : Data Structures
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program overall description here
*               Input:  list and describe
*               Output: list and describe
* Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

using System;
using System.Collections;

namespace FirstComeFirstServedTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            Random randomGenerator = new Random();
            int totalTickets = 10;
            //int totalTickets = 100;
            //int totalTickets = 1000;
            int lineSize = randomGenerator.Next(1, 1001);
            int[] numCustomers = new int[lineSize];
            int numCustomersWhoPurchased = 0;

            Console.WriteLine("Total tickets: " + totalTickets);
            Console.WriteLine("Number of customers: " + lineSize + "\n");

            foreach(int cust in numCustomers)
            {
                q.Enqueue(cust);
            }

            while(q.Count > 0)
            {
                int numTicketsPurchased = randomGenerator.Next(1, 5);
                Console.WriteLine("Customer wants to purchase " + numTicketsPurchased + " tickets." + "\n");

                if(totalTickets >= numTicketsPurchased)
                {
                    totalTickets -= numTicketsPurchased;
                    numCustomersWhoPurchased++;
                    q.Dequeue();
                    Console.WriteLine("Happy customers (who were able to purchase tickets): " + numCustomersWhoPurchased);
                    Console.WriteLine("Tickets remaining: " + totalTickets + "\n");
                }
                else
                {
                    Console.WriteLine("Error: Customer tried to purchase more tickets than there are available. Customer wanted " + numTicketsPurchased + " tickets, but there were only " + totalTickets + " tickets remaining.");
                    Environment.Exit(0);
                }
            }
            if(q.Count == 0)
            {
                Console.WriteLine("There were more tickets than customers. Number of customers: " + numCustomersWhoPurchased + ", Number of remaining tickets: " + totalTickets);
                Environment.Exit(0);
            }
        }
    }
}
