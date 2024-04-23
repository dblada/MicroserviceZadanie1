namespace MicroserviceZadanie1
{
    public class TreeNode
    {
        public string val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(string x) {
            string result = x.Replace("\"", "");
            result = result.Replace("{", "").Replace("}", "");
            result = result.Replace("val:", "");
            result = result.Replace("left:", "");
            result = result.Replace("right:", "");
            result = result.Replace(" ", "");
            result = result.Replace("\r\n", "");

            val = result;
        }
    }
}
