public class Solution {
    public int MaxLevelSum(TreeNode root) {
        int ans = 0;
        int mx = int.MinValue;
        Queue<TreeNode> q = new Queue<TreeNode>();
        int cnt = 0;
        q.Enqueue(root);

        while (q.Count > 0) {
            int sz = q.Count;
            int sum = 0;
            cnt++;

            for (int i = 0; i < sz; i++) {
                TreeNode tem = q.Dequeue();

                if (tem.left != null) {
                    q.Enqueue(tem.left);
                }
                if (tem.right != null) {
                    q.Enqueue(tem.right);
                }

                sum += tem.val;
            }

            if (sum > mx) {
                mx = sum;
                ans = cnt;
            }
        }

        return ans;
    }
}
