public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> hash = new HashSet<int>();
        HashSet<int> returnData = new HashSet<int>();
        
        if(nums1.Length<nums2.Length) {
            var temp = nums1;
            nums1 = nums2;
            nums2 = temp;
        }
		for(int i = 0; i < nums1.Length;i++) {
			hash.Add(nums1[i]);
		}
		for(int i = 0;i<nums2.Length;i++) {
			if(hash.Contains(nums2[i])) {
				returnData.Add(nums2[i]);
			}
		}
        return returnData.ToArray();
    }
}
//Here to get the unique intersection of two array we are saving first array
//element in to the hashset and then check with another array element with the 
//stored hashset element and check if the element wo array2 is there. if yes 
//store it in another hashset as we have to display only unique intersection.