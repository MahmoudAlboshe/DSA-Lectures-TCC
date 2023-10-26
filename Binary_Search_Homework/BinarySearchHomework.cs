using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {

                int mid1 = left + (right - left) / 3;
                int mid2 = right - (right - left) / 3;

                if (arr[mid1] == key)
                {
                    return mid1;
                }

                if (arr[mid2] == key)
                {
                    return mid2;
                }

                if (key < arr[mid1])
                {
                    right = mid1 - 1;
                }
                else if (key > arr[mid2])
                {
                    left = mid2 + 1;
                }
                else
                {
                    left = mid1 + 1;
                    right = mid2 - 1;
                }
            }
            //TODO: write code for the ternary search algorithm and return the index of the element
            return -1;
        }

        public static int BinarySearchForCalculatingRepeated(int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            int left = 0;
            int right = arr.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == key)
                {
                    result = mid;
                    right = mid - 1;
                }
                else if (arr[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            //TODO: this methods is for getting the first accurence of the key and the last accurance
            return result;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            int start = BinarySearchForCalculatingRepeated(arr, key,true,0,0);

            if (start == -1)
            {
                return -1; 
            }

            int end = start;

            
            while (end + 1 < arr.Length && arr[end + 1] == key)
            {
                end++;
            }

            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            return end - start + 1;
        }
    }
}
