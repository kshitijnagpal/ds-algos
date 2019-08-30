//Complexity  - Time: O(logn), Space: O(1)

//iterative
int binarySearch(int[]a, int target) {
    int low = 0;
    int high = a.Length - 1;
    int mid;

    while(low<=high) {
        mid = (low+high)/2;
        if(a[mid] > target) {
            high = mid - 1;
        }
        else if (a[mid] < target) {
            low = mid + 1;
        }
        else {
            return mid;
        }
    }

    //not found
    return -1;
}

//recursive
int binarySearch(int[] a, int target, int low, int high) {
    if(low>high){
        return -1;
    }

    int mid = (low+high)/2;
    if(a[mid] < target) {
        return binarySearch(a, target, mid+1, high);
    }
    else if (a[mid] > x) {
        return binarySearch(a, target, low, mid-1);
    }
    else {
        return mid;
    }
}

//Template 2 (Leetcode)
int binarySearch(int[] nums, int target)
{
    if (nums == null || nums.Length == 0)
        return -1;

    int left = 0, right = nums.Length;

    while (left < right)
    {
        int mid = left + (right - left) / 2;

        if (nums[mid] == target)
            return mid;

        else if (nums[mid] < target)
        {
            left = mid + 1;
        }

        else
        {
            right = mid;
        }
    }

    //Post processing
    if (left != nums.Length && nums[left] == target)
        return left;

    return -1;
}