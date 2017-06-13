using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.Infrastructure.Assets
{
    public abstract class Node<T>
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

        protected Node(T data)
        {
            _data = data;
        }

        protected void AddNeighbour(Node<T> neighbour)
        {
            if (_neighbours.All(x => x != neighbour))
                _neighbours.Add(neighbour);
        }

        protected void AddNeighbourAt(Node<T> neighbour, int index)
        {
            if(_neighbours.Count < index)
                throw new IndexOutOfRangeException();
            if (_neighbours.Count > index)
                _neighbours.RemoveAt(index);
            _neighbours.Insert(index, neighbour);
        }

        protected void RemoveNeighbourAt(int index)
        {
            if (_neighbours.ElementAtOrDefault(index) != null)
                _neighbours.RemoveAt(index);
        }

        protected void RemoveNeighbour(Node<T> neighbour)
        {
            if (Neighbours.Any(x => x == neighbour))
                _neighbours.Remove(neighbour);
        }

        protected List<Node<T>> GetNeighbours()
        {
            return _neighbours;
        }

        protected List<Node<T>> GetNeighbours(Func<Node<T>, bool> predicate)
        {
            return _neighbours.Where(predicate).ToList();
        }

    }
}