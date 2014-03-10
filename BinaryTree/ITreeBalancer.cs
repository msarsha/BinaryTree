using System;

namespace BinaryTree
{
    public interface ITreeBalancer<T> 
        where T : IComparable
    {
        /// <summary>
        /// Balance a given node
        /// </summary>
        /// <param name="node">node to balance</param>
        /// <returns>balanced node</returns>
        void Balance(ref BinaryTreeNode<T> node);
    }
}
