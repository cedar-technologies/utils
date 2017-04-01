using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.Infrastructure.Assets
{
    public class Node<T>
    {

        private T _data;
        private List<Node<T>> _neighbours = new List<Node<T>>();

        public T Data
        {
            get { return _data; }
        }

        public List<Node<T>> Neighbours
        {
            get { return _neighbours; }
        }

        public Node(T data)
        {
            if(data == null) throw new ArgumentNullException("data");
            _data = data;
        }

        public void AddNeighbour(Node<T> neighbour)
        {
            if(!_neighbours.Any(x => x == neighbour))
                _neighbours.Add(neighbour);
        }

        public void RemoveNeighbour(Node<T> neighbour)
        {
            if(Neighbours.Any(x=> x == neighbour))
                _neighbours.Remove(neighbour);
        }

        public List<Node<T>> GetNeighbours(Func<Node<T>, bool> predicate)
        {
            return _neighbours.Where(predicate).ToList();
        }

    }
}