/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        string numero1String = recursiveConcatNodes(l1);
        string numero2String = recursiveConcatNodes(l2);
        BigInteger n1 = BigInteger.Parse(numero1String);
        BigInteger n2 = BigInteger.Parse(numero2String);
        string resultado = Convert.ToString(n1+n2);
        return produzListaResultado(resultado, resultado.Length-1);
    }

    private string recursiveConcatNodes(ListNode node){
        if(node.next == null)
        {
            return node.val.ToString();
        }
        return recursiveConcatNodes(node.next) + node.val.ToString();
    }

    private ListNode produzListaResultado(string resultado, int i){
        int val = int.Parse(resultado[i].ToString());
        if(i == 0){
            return new ListNode(val, null);
        }
        return new ListNode(val, produzListaResultado(resultado,--i));
    }
}