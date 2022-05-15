public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
       Array.Sort(seats);
       Array.Sort(students);
        int moves = 0;
        for (int i = 0; i< seats.Length; i++) {
            moves = moves + Math.Abs((students[i]-seats[i]));
        }
        return moves;
    }
}

//Sorted both the array and than find the diffrence between both the array and add to find the result.
//We have to consider all teh diffrence in a postive number only so used Math.Abs();