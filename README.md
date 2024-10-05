# Hacker Rank - 1 Month Preparation Kit
## Time Conversion

### Introduction

This is a series of exercises included in the "1 Month Preparation Kit" within HackerRank preparation kits. I am developing these solutions inside devcontainers to solve the different challenges in various programming languages that I know, such as:
- C#
- Python
- TypeScript
- Ruby

Additionally, I will assign different difficulty levels to each challenge, starting with console applications. Once the entire series is completed, I will display the results in a web application.

### Prerequisites

To run this devcontainer, you need:
- Linux, Mac, or Windows with WSL
- Docker
- Visual Studio Code
- Git

### Usage

Open this repository in VSCode (in CLI, open the repo folder and type `code .`). Press Ctrl + Shift + P, and type "Reopen in Container" to enter the devcontainer. Once inside the devcontainer, navigate to the file `Program.cs` and run it using the play button above.
![image](https://github.com/user-attachments/assets/be3f28fa-b04f-4515-b8b9-5c9be0158cd6)


### Challenge

Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.

Note:
- 12:00:00 AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00 PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

Example:

- Input: '12:01:00 PM'
    Output: '12:01:00'

- Input: '12:01:00 AM'
    Output: '00:01:00'

Function Description:

Complete the `timeConversion` function in the editor below. It should return a new string representing the input time in 24-hour format.

`timeConversion` has the following parameter(s):
- `string s`: a time in 12-hour format

Returns:
- `string`: the time in 24-hour format

Input Format:
- A single string `s` that represents a time in 12-hour clock format (i.e., `hh:mm:ssAM` or `hh:mm:ssPM`).

Constraints:
- All input times are valid.

Sample Input:
- `07:05:45PM`

Sample Output:
- `19:05:45`

### Solution

Here I tought in 2 possible ways, use time parsing, or processing strings, I used time parsing, because is less complicated, and it worked perfectly;

### Evidence
![image](https://github.com/user-attachments/assets/bdee82f6-06f4-405e-9330-5c1c27282a81)

