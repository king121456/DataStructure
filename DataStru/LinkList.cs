
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DataStru
{
    /// <summary>
    /// 链表的实现
    /// </summary>
    public class LinkListNode
    {
        public Object Value { get; private set; }


        public LinkListNode(Object value)
        {
            this.Value = value;
        }

        //直接前驱
        public LinkListNode Next { get; internal set; }
        //直接后继
        public LinkListNode Prev { get; internal set; }
    }

    public class LinkList:IEnumerable<
    {
        public LinkListNode First { get; set; }
        public LinkListNode Last { get; set; }

        public LinkListNode Add(Object obj)
        {
            LinkListNode node = new LinkListNode(obj);
            if (First == null)
            {
                First = node;
                Last = node;
            }
            //维护next和prev，直接前驱，直接后继
            else
            {
                LinkListNode lastNode=this.Last;
                this.Last.Next = node;
                this.Last = node;
                node.Prev = lastNode;
            }
            return node;
        }
        
        

        public IEnumerator GetEnumerator()
        {
            LinkListNode current=this.First;
            while(current!=null)
            {
                yield return current.Value;
                current = current.Next;
            }
           
        }

    }


}
