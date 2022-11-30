# CodeJam
2022CodeJam문제풀이
Problem 1
A secret team of programmers is plotting to disrupt the programming language landscape and bring punched cards back by introducing a new language called Punched Card Python that lets people code in Python using punched cards! Like good disrupters, 
they are going to launch a viral campaign to promote their new language before even having the design for a prototype. For the campaign, they want to draw punched cards of different sizes in ASCII art.
Example Punched Card.

The ASCII art of a punched card they want to draw is similar to an R×C matrix without the top-left cell. That means, it has (R⋅C)−1 cells in total. Each cell is drawn in ASCII art as a period (.) surrounded by dashes (-) above and below, pipes (|) to the left and right,
and plus signs (+) for each corner. Adjacent cells share the common characters in the border. Periods (.) are used to align the cells in the top row.
For example, the following is a punched card with R=3 rows and C=4 columns:
..+-+-+-+
..|.|.|.|
+-+-+-+-+
|.|.|.|.|
+-+-+-+-+
|.|.|.|.|
+-+-+-+-+
There are more examples with other sizes in the samples below. Given the integers R and C describing the size of a punched card, print the ASCII art drawing of it as described above.

Input
The first line of the input gives the number of test cases, T. T lines follow, each describing a different test case with two integers R and C: the number of rows and columns of the punched card that must be drawn.

Output
For each test case, output one line containing Case #x:, where x is the test case number (starting from 1). Then, output (2⋅R)+1 additional lines with the ASCII art drawing of a punched card with R rows and C columns.

Limits
Time limit: 5 seconds.
Memory limit: 1 GB.
Test Set 1 (Visible Verdict)
1≤T≤81.
2≤R≤10.
2≤C≤10.
Sample
Sample Input
save_alt
content_copy
3
3 4
2 2
2 3
Sample Output
save_alt
content_copy
Case #1:
..+-+-+-+
..|.|.|.|
+-+-+-+-+
|.|.|.|.|
+-+-+-+-+
|.|.|.|.|
+-+-+-+-+
Case #2:
..+-+
..|.|
+-+-+
|.|.|
+-+-+
Case #3:
..+-+-+
..|.|.|
+-+-+-+
|.|.|.|
+-+-+-+
Sample Case #1 is the one described in the problem statement. Sample Cases #2 and #3 are additional examples. Notice that the output for each case contains exactly R⋅C+3 periods.

--------------------------------------------------------------------------------------------------------------------------------
Problem 3
While the most typical type of dice have 6 sides, each of which shows a different integer 1 through 6, there are many games that use other types. In particular, a dk is a die with k sides, each of which shows a different integer 1 through k. A d6 is a typical die, a d4 has four sides, and a d1000000 has one million sides.

Dice from sample case 1

In this problem, we start with a collection of N dice. The i-th die is a dSi, that is, it has Si sides showing integers 1 through Si. A straight of length ℓ starting at x is the list of integers x,x+1,…,x+(ℓ−1). We want to choose some of the dice (possibly all) and pick one number from each to form a straight. 
What is the longest straight we can form in this way?

Input
The first line of the input gives the number of test cases, T. T test cases follow. Each test case is described in two lines. The first line of a test case contains a single integer N, the number of dice in the game. The second line contains N integers S1,S2,…,SN, each representing the number of sides of a different die.

Output
For each test case, output one line containing Case #x: y, where x is the test case number (starting from 1) and y is the maximum number of input dice that can be put in a straight.

Limits
Memory limit: 1 GB.
1≤T≤100.
Test Set 1 (Visible Verdict)
Time limit: 5 seconds.
1≤N≤10.
4≤Si≤20, for all i.
Test Set 2 (Visible Verdict)
Time limit: 15 seconds.
1≤N≤105.
4≤Si≤106, for all i.
Sample
Sample Input
save_alt
content_copy
4
4
6 10 12 8
6
5 4 5 4 4 4
10
10 10 7 6 7 4 4 5 7 4
1
10
Sample Output
save_alt
content_copy
Case #1: 4
Case #2: 5
Case #3: 9
Case #4: 1
In Sample Case #1, there are multiple ways to form a straight using all 4 dice. One possible way is shown in the image above.

In Sample Case #2, since none of the dice can show an integer greater than 5, there is no way to have a straight with more than 5 dice. There are multiple ways to form a straight with exactly 5 dice. For example, pick the integers 4 and 5 for both d5⁠'s and then integers 1,2, and 3 for three of the d4⁠'s to form 1,2,3,4,5.

In Sample Case #3, it is possible to form the straight 1,2,3,4,5,6,7,8,9 by discarding one d4 and using the d4⁠'s, d5, and d6 to get 1 through 4; the d7⁠'s to get 5 through 7; and the d10⁠'s to get 8 and 9. There is no way to form a straight of length 10, so this is the best that can be done.

In Sample Case #4, we can only form a straight of length 1, but we can do so by picking any integer for the d10 we are given.
