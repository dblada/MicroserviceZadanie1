namespace MicroserviceZadanie1
{
    public class BinaryTree
    {
        public TreeNode root;

        public virtual void mirror() { root = mirror(root); }

        public virtual TreeNode mirror(TreeNode node)
        {
            if (node == null)
            {
                return node;
            }

            TreeNode left = mirror(node.left);
            TreeNode right = mirror(node.right);

            node.left = right;
            node.right = left;

            return node;
        }
      
        static int t;

        public static TreeNode Deserialize(string data)
        {
            if (data == null)
                return null;
            t = 0;
            string[] arr = data.Split(',');
            return Helper(arr);
        }

        public static TreeNode Helper(string[] arr)
        {
            if (arr[t].Contains("null"))
                return null;

            TreeNode root = new TreeNode(arr[t]);
            t++;
            root.left = Helper(arr);
            t++;
            root.right = Helper(arr);
            return root;
        }
    }
}
