/*
 * @lc app=leetcode id=133 lang=java
 *
 * [133] Clone Graph
 */

// @lc code=start
/*
// Definition for a Node.
class Node {
    public int val;
    public List<Node> neighbors;
    public Node() {
        val = 0;
        neighbors = new ArrayList<Node>();
    }
    public Node(int _val) {
        val = _val;
        neighbors = new ArrayList<Node>();
    }
    public Node(int _val, ArrayList<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

import java.util.ArrayList;
import java.util.HashMap;

class Solution {
    HashMap<Node, Node> map = new HashMap<>();

    public Node cloneGraph(Node node) {
        // DFS
        if (node == null) {
            return null;
        }
        Node ans = new Node(node.val, new ArrayList<>());
        map.put(node, ans);
        for (Node neighbor : node.neighbors) {
            if (map.containsKey(neighbor)) {
                ans.neighbors.add(map.get(neighbor));
            } else {
                ans.neighbors.add(cloneGraph(neighbor));
            }
        }
        return ans;
    }
}
// @lc code=end
