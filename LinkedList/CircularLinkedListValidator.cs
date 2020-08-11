using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class CirclularLinkedListValidator 
    {
        public bool IsCircular<T>(LinkedList<T> linkedList)
        {
            LinkedListNode<T> node = linkedList.First;
            int iterationCounter = 0;
            
            while(node.Next != null && iterationCounter < linkedList.Count)
            {
                iterationCounter++;
            }
            if (iterationCounter < linkedList.Count)
            {
                return false;
            }
            return true;
        }
    }
}
