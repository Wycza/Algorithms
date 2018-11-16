namespace BinarySearchTree {
    public class TreeNode<T> {
        public TreeNode<T> left;
        public TreeNode<T> right;
        public T data;

        public TreeNode (T data) {
            this.left = new TreeNode<T>();
            this.right = new TreeNode<T>();
            this.data = data;
        }
    }
}