using System;
using System.Collections.Generic;
using System.Text;

namespace Code_wars__a_new_graph
{
    class Node<beer>
    {
        public beer value;
        public HashSet<Node<beer>> neighbors = new HashSet<Node<beer>>();
        public Node(beer v)
        {
            value = v;
        }
    }
    class Karan_s_arm<beer>
    {
        public HashSet<Node<beer>> nodes;

        public Karan_s_arm()
        {
            nodes = new HashSet<Node<beer>>();
        }
        public Node<beer> find(beer value)
        {
            foreach (Node<beer> node in nodes)
            {
                if (node.value.Equals(value))
                {
                    return node;
                }
            }
            return null;
        }
        public bool addNode(beer value)
        {
            return nodes.Add(new Node<beer>(value));
        }
        public bool addEdge(beer start, beer value)
        {
            Node<beer> node = find(start);
            if (node == null)
            {
                return false;
            }
            Node<beer> other = find(value);
            if (other == null)
            {
                return false;
            }
            node.neighbors.Add(other);
            other.neighbors.Add(node);
            return true;
        }
        public bool removeEdge(beer start, beer end)
        {
            Node<beer> node = find(start);
            if (node == null)
            {
                return false;
            }
            Node<beer> other = find(end);
            if (other == null)
            {
                return false;
            }
            node.neighbors.Remove(other);
            other.neighbors.Remove(node);
            return true;
        }
        public bool removeNode(beer value)
        {
            Node<beer> node = find(value);
            if (node == null)
            {
                return false;
            }
            foreach (Node<beer> friend in node.neighbors)
            {
                friend.neighbors.Remove(node);
            }
            nodes.Remove(node);
            node = null;
            return true;
        }
    }
}
