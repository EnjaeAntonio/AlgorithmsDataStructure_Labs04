//Lab 4: Lists

//Note that several of these methods have Nested Lists (ie. Lists within Lists) as
//their parameters. It is best to write helper methods to simplify the required ones. 

//For example, int GetHighestValueInList(List<int>) would be a helpful method to write
//and use throughout these problems. Ideally, each function should be as simple as possible,
//performing a small amount of work before passing it to another function inside or after that method.

//List<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter a List of Lists of Integers.
// It returns a new list with each element representing the maximum number found in the corresponding original list. 
//For example, { {1, 5, 3}, { 9, 7, 3, -2}, { 2, 1, 2} } returns
//{ 5, 9, 2}. Output the results with a message like: “List 1 has a maximum of 5.
//List 2 has a maximum of 9. List 3 has a maximum of 2.”

List<List<int>> intList = new List<List<int>>
{
    new List<int> {1, 5, 3 },
    new List<int> {9, 7, 3, -2},
    new List<int> {2, 1, 2 }
};  

for (int i = 0;i < intList.Count; i++)
{
    int max = intList[i].Max();
    Console.WriteLine($"List {i + 1} has a max of {max}");
}

/* The time complexity of this algorithm is O(n) where n is the total number of
  elements */

//String HighestGrade(List<List<int>>) accepts a list of number grades among students
//in different courses (where each list represents a single course), between 0 and 100.
//It returns the highest grade among all students in all courses.
//For example: { { 85,92, 67, 94, 94}, { 50, 60, 57, 95}, { 95} }
//returns "The highest grade is 95. This grade was found in class(es) {index}".

List<List<int>> grades = new List<List<int>>
{
    new List<int> { 85, 92, 67, 90, 94},
    new List<int> { 50, 60, 57, 100   }, 
    new List<int> { 99                }
};

List<int> classIndex = new List<int>();
string HighestGrade(List<List<int>> grades)
{
    int highest = 0;
    for(int i = 0; i < grades.Count; i++)
    {
        for (int j = 0; j < grades[i].Count; j++)
        {
            if (grades[i][j] > highest)
            {
                highest = grades[i][j];
                classIndex.Clear();
                classIndex.Add(i + 1);
            }
        }
    }
    return $"The highest grades is {highest} this grade was found in class {string.Join(", ", classIndex)} ";
}

Console.WriteLine(HighestGrade(grades));


//List<int> OrderByLooping(List<int>) orders a list of integers, from least to greatest,
//using only basic control statements(ie. if/else, for/while).

//For example, argument {6, -2, 5, 3} returns
//{ -2, 3, 5, 6}.

//Bonus:
//Once you finish these methods, do some research into bubble sorting. refactor OrderByLooping method to use it