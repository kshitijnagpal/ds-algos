//driver
void quickSort(int[] arr, int left, int right) {
    //get partition index
    int index = partition(arr, left, right);

    //sort left half
    if(left < index-1) {
        quickSort(arr, left, index-1);
    }

    //sort right half
    if(index < right) {
        quickSort(arr, index, right);
    }
}

//helper
int partition(int[] arr, int left, int right) {
    int pivot = arr[(left+right)/2];

    while(left<=right) {
        //find element on left that should be on right
        while(arr[left] < pivot) {
            left++;
        }

        //find element on right that should be on left
        while(arr[right] > pivot) {
            right--;
        }

        if(left<=right) {
            swap(arr, left, right);
            left++;
            right--;
        }
    }

    return left;
}
//helper function
void swap(int[] arr, int left, int right) {
    int temp = arr[left];
    arr[left] = arr[right];
    arr[right] = temp;
}