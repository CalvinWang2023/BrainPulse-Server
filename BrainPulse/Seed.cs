using BrainPulse.Data;
using BrainPulse.Models;

namespace BrainPulse
{
    public class Seed
    {
        private readonly DataContext _dataContext;
        public Seed(DataContext context)
        {
            _dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!_dataContext.Questions.Any())
            {
                var questions = new List<Question>()
                {
                    // Easy Computer Science Questions
                    new Question()
                    {
                        QuestionText = "What does CPU stand for?",
                        CorrectAnswer = "Central Processing Unit",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Central Processing Unit" },
                            new Option { OptionText="Central Process Unit" },
                            new Option { OptionText="Computer Personal Unit" },
                            new Option { OptionText="Central Processor Unit" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language is known for its simplicity and readability, often used for beginners?",
                        CorrectAnswer = "Python",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Python" },
                            new Option { OptionText="C++" },
                            new Option { OptionText="Java" },
                            new Option { OptionText="Ruby" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What does HTML stand for?",
                        CorrectAnswer = "Hypertext Markup Language",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Hypertext Markup Language" },
                            new Option { OptionText="Hyperlink and Text Markup Language" },
                            new Option { OptionText="High-Level Text Markup Language" },
                            new Option { OptionText="Hypertext Markdown Language" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which company developed the C# programming language?",
                        CorrectAnswer = "Microsoft",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Microsoft" },
                            new Option { OptionText="Apple" },
                            new Option { OptionText="Google" },
                            new Option { OptionText="IBM" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "In web development, what does CSS stand for?",
                        CorrectAnswer = "Cascading Style Sheets",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Cascading Style Sheets" },
                            new Option { OptionText="Computer Style Sheets" },
                            new Option { OptionText="Creative Style Sheets" },
                            new Option { OptionText="Coded Style Sheets" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure uses a Last-In-First-Out (LIFO) approach?",
                        CorrectAnswer = "Stack",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Stack" },
                            new Option { OptionText="Queue" },
                            new Option { OptionText="Array" },
                            new Option { OptionText="Linked List" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What does API stand for in programming?",
                        CorrectAnswer = "Application Programming Interface",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Application Programming Interface" },
                            new Option { OptionText="Advanced Program Interface" },
                            new Option { OptionText="Automated Programming Interface" },
                            new Option { OptionText="Application Program Integration" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the main purpose of a firewall in network security?",
                        CorrectAnswer = "To monitor and control incoming and outgoing network traffic",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="To monitor and control incoming and outgoing network traffic" },
                            new Option { OptionText="To boost network speed" },
                            new Option { OptionText="To store user data" },
                            new Option { OptionText="To perform encryption" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language was created by Guido van Rossum?",
                        CorrectAnswer = "Python",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Python" },
                            new Option { OptionText="Java" },
                            new Option { OptionText="C++" },
                            new Option { OptionText="JavaScript" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What does RAM stand for?",
                        CorrectAnswer = "Random Access Memory",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Random Access Memory" },
                            new Option { OptionText="Read-Only Memory" },
                            new Option { OptionText="Remote Access Memory" },
                            new Option { OptionText="Run-And-Manage" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language is often used for web development and known for its flexibility and ease of use?",
                        CorrectAnswer = "JavaScript",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="JavaScript" },
                            new Option { OptionText="Python" },
                            new Option { OptionText="C#" },
                            new Option { OptionText="Java" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary function of an operating system?",
                        CorrectAnswer = "To manage computer hardware and provide services for computer programs",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="To manage computer hardware and provide services for computer programs" },
                            new Option { OptionText="To create computer graphics" },
                            new Option { OptionText="To design software applications" },
                            new Option { OptionText="To develop web pages" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure is used to store and retrieve data in a first-in-first-out (FIFO) order?",
                        CorrectAnswer = "Queue",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Queue" },
                            new Option { OptionText="Stack" },
                            new Option { OptionText="Array" },
                            new Option { OptionText="Linked List" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "In programming, what does the acronym 'OOP' stand for?",
                        CorrectAnswer = "Object-Oriented Programming",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Object-Oriented Programming" },
                            new Option { OptionText="Operational Object Programming" },
                            new Option { OptionText="Object-Oriented Process" },
                            new Option { OptionText="Ordered Object Programming" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which computer component is responsible for storing data and programs that are currently being used?",
                        CorrectAnswer = "RAM (Random Access Memory)",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="RAM (Random Access Memory)" },
                            new Option { OptionText="CPU (Central Processing Unit)" },
                            new Option { OptionText="Hard Drive" },
                            new Option { OptionText="Graphics Card" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the main purpose of an HTTP cookie in web development?",
                        CorrectAnswer = "To store user data or track user behavior on websites",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="To store user data or track user behavior on websites" },
                            new Option { OptionText="To display web page content" },
                            new Option { OptionText="To create web forms" },
                            new Option { OptionText="To design website layouts" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language is commonly used for building dynamic web applications and server-side scripting?",
                        CorrectAnswer = "PHP",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="PHP" },
                            new Option { OptionText="Ruby" },
                            new Option { OptionText="C++" },
                            new Option { OptionText="Swift" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What does the acronym 'URL' stand for in web addresses?",
                        CorrectAnswer = "Uniform Resource Locator",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Uniform Resource Locator" },
                            new Option { OptionText="Universal Routing Language" },
                            new Option { OptionText="Unified Resource Link" },
                            new Option { OptionText="Unique Resource Listing" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "In computer programming, what is an 'if statement' used for?",
                        CorrectAnswer = "Conditional execution of code based on a specified condition",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Conditional execution of code based on a specified condition" },
                            new Option { OptionText="Looping through an array" },
                            new Option { OptionText="Displaying user input" },
                            new Option { OptionText="Creating functions" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which web development technology is used for creating the structure and layout of a webpage?",
                        CorrectAnswer = "HTML (Hypertext Markup Language)",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="HTML (Hypertext Markup Language)" },
                            new Option { OptionText="CSS (Cascading Style Sheets)" },
                            new Option { OptionText="JavaScript" },
                            new Option { OptionText="PHP (Hypertext Preprocessor)" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    
                    new Question()
                    {
                        QuestionText = "What is the purpose of a 'for loop' in programming?",
                        CorrectAnswer = "To repeat a block of code a specified number of times",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="To repeat a block of code a specified number of times" },
                            new Option { OptionText="To define a function" },
                            new Option { OptionText="To create a variable" },
                            new Option { OptionText="To display a message" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure is used to organize data in a hierarchical manner?",
                        CorrectAnswer = "Tree",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Tree" },
                            new Option { OptionText="Array" },
                            new Option { OptionText="Stack" },
                            new Option { OptionText="Queue" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary function of an 'if-else statement' in programming?",
                        CorrectAnswer = "To execute different code blocks depending on a specified condition",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="To execute different code blocks depending on a specified condition" },
                            new Option { OptionText="To define a variable" },
                            new Option { OptionText="To create a loop" },
                            new Option { OptionText="To display user input" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language is often used for developing mobile applications for Android devices?",
                        CorrectAnswer = "Java",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Java" },
                            new Option { OptionText="Swift" },
                            new Option { OptionText="Python" },
                            new Option { OptionText= "C#" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of 'version control' in software development?",
                        CorrectAnswer = "To track changes and collaborate on code with multiple developers",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="To track changes and collaborate on code with multiple developers" },
                            new Option { OptionText="To design user interfaces" },
                            new Option { OptionText="To test software applications" },
                            new Option { OptionText="To write code documentation" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which file format is commonly used for storing structured data that is easy for humans to read and write?",
                        CorrectAnswer = "JSON (JavaScript Object Notation)",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="JSON (JavaScript Object Notation)" },
                            new Option { OptionText="XML (eXtensible Markup Language)" },
                            new Option { OptionText="CSV (Comma-Separated Values)" },
                            new Option { OptionText="PDF (Portable Document Format)" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the main purpose of 'HTTP' in web development?",
                        CorrectAnswer = "To transfer data between a web server and a web browser",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="To transfer data between a web server and a web browser" },
                            new Option { OptionText="To create web page layouts" },
                            new Option { OptionText="To store data on a web server" },
                            new Option { OptionText="To design user interfaces" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which programming paradigm emphasizes the use of functions as the primary building blocks of software?",
                        CorrectAnswer = "Functional Programming",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Functional Programming" },
                            new Option { OptionText="Object-Oriented Programming" },
                            new Option { OptionText="Procedural Programming" },
                            new Option { OptionText="Structured Programming" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of 'debugging' in software development?",
                        CorrectAnswer = "To identify and fix errors or defects in the code",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="To identify and fix errors or defects in the code" },
                            new Option { OptionText="To write new code" },
                            new Option { OptionText= "To test software performance" },
                            new Option { OptionText="To document code functions" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure is used to store a collection of key-value pairs?",
                        CorrectAnswer = "Dictionary",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Dictionary" },
                            new Option { OptionText="Array" },
                            new Option { OptionText="List" },
                            new Option { OptionText="Queue" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1"
                    },


                    // Medium CS MCQ
                    new Question()
                    {
                        QuestionText = "What is the purpose of the HTTP status code '404 Not Found'?",
                        CorrectAnswer = "Page Not Found",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Internal Server Error" },
                            new Option { OptionText="Unauthorized" },
                            new Option { OptionText="Page Not Found" },
                            new Option { OptionText="OK" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "In object-oriented programming, what is a mechanism that allows one class to inherit properties and behaviors from another class?",
                        CorrectAnswer = "Inheritance",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Composition" },
                            new Option { OptionText="Polymorphism" },
                            new Option { OptionText="Inheritance" },
                            new Option { OptionText="Abstraction" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language is commonly used for developing web applications and is known for its simplicity and ease of use in creating dynamic web pages?",
                        CorrectAnswer = "JavaScript",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Python" },
                            new Option { OptionText="Ruby" },
                            new Option { OptionText="JavaScript" },
                            new Option { OptionText=" C++" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary function of an HTTP server?",
                        CorrectAnswer = "To process HTTP requests and serve web pages",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="To store and manage databases" },
                            new Option { OptionText="To handle user authentication" },
                            new Option { OptionText="To process HTTP requests and serve web pages" },
                            new Option { OptionText="To encrypt data transmission" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure allows for efficient retrieval of data based on a key and is often used for implementing dictionaries and associative arrays?",
                        CorrectAnswer = "Hash Table",
                        Options = new List<Option>()
                        {
                            new Option { OptionText="Queue" },
                            new Option { OptionText="Linked List" },
                            new Option { OptionText="Binary Tree" },
                            new Option { OptionText="Hash Table" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What does SQL stand for in the context of databases?",
                        CorrectAnswer = "Structured Query Language",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Standard Query Language" },
                            new Option { OptionText = "Structured Query Language" },
                            new Option { OptionText = "Simple Query Language" },
                            new Option { OptionText = "System Query Language" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which sorting algorithm has a time complexity of O(n^2) in the worst case and is known for its simplicity?",
                        CorrectAnswer = "Bubble Sort",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Merge Sort" },
                            new Option { OptionText = "Quick Sort" },
                            new Option { OptionText = "Bubble Sort" },
                            new Option { OptionText = "Insertion Sort" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a programming error that occurs when a program attempts to access memory that it is not authorized to access?",
                        CorrectAnswer = "Access Violation",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Syntax Error" },
                            new Option { OptionText = "Logic Error" },
                            new Option { OptionText = "Runtime Error" },
                            new Option { OptionText = "Access Violation" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure is used for storing and managing data in a Last-In-First-Out (LIFO) manner?",
                        CorrectAnswer = "Stack",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Queue" },
                            new Option { OptionText = "Stack" },
                            new Option { OptionText = "Linked List" },
                            new Option { OptionText = "Heap" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which type of network topology connects all devices in a linear sequence and has no central hub?",
                        CorrectAnswer = "Bus Topology",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Bus Topology" },
                            new Option { OptionText = "Star Topology" },
                            new Option { OptionText = "Ring Topology" },
                            new Option { OptionText = "Mesh Topology" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a programming construct that allows the same code to be executed repeatedly based on a specified condition?",
                        CorrectAnswer = "Loop",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Function" },
                            new Option { OptionText = "Variable" },
                            new Option { OptionText = "Class" },
                            new Option { OptionText = "Loop" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure uses a First-In-First-Out (FIFO) approach for data retrieval?",
                        CorrectAnswer = "Queue",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Stack" },
                            new Option { OptionText = "Heap" },
                            new Option { OptionText = "Queue" },
                            new Option { OptionText = "Array" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "In the context of databases, what does ACID stand for?",
                        CorrectAnswer = "Atomicity, Consistency, Isolation, Durability",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "All Computers in Database" },
                            new Option { OptionText = "Atomicity, Consistency, Isolation, Durability" },
                            new Option { OptionText = "Advanced Coding in Databases" },
                            new Option { OptionText = "Automated Control of Information Data" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language is often used for developing mobile applications for Android devices?",
                        CorrectAnswer = "Java",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Java" },
                            new Option { OptionText = "Swift" },
                            new Option { OptionText = "Python" },
                            new Option { OptionText = "C#" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of a firewall in network security?",
                        CorrectAnswer = "To monitor and control incoming and outgoing network traffic",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To amplify network signals" },
                            new Option { OptionText = "To prevent hardware failures" },
                            new Option { OptionText = "To monitor and control incoming and outgoing network traffic" },
                            new Option { OptionText = "To manage computer resources" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    
                    new Question()
                    {
                        QuestionText = "What is the purpose of the 'git' version control system?",
                        CorrectAnswer = "To track changes in source code and collaborate on software development",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To play video games" },
                            new Option { OptionText = "To create graphical user interfaces" },
                            new Option { OptionText = "To track changes in source code and collaborate on software development" },
                            new Option { OptionText = "To write scientific research papers" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary role of an operating system in a computer?",
                        CorrectAnswer = "To manage hardware resources and provide a user interface",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To create web applications" },
                            new Option { OptionText = "To design computer hardware" },
                            new Option { OptionText = "To manage hardware resources and provide a user interface" },
                            new Option { OptionText = "To encrypt data transmissions" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which of the following is a commonly used programming paradigm for solving problems by breaking them into smaller subproblems?",
                        CorrectAnswer = "Divide and Conquer",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Imperative Programming" },
                            new Option { OptionText = "Object-Oriented Programming" },
                            new Option { OptionText = "Functional Programming" },
                            new Option { OptionText = "Divide and Conquer" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of a compiler in software development?",
                        CorrectAnswer = "To translate high-level programming code into machine code",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To write documentation" },
                            new Option { OptionText = "To create user interfaces" },
                            new Option { OptionText = "To translate high-level programming code into machine code" },
                            new Option { OptionText = "To manage database operations" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "In web development, what does 'HTML' stand for?",
                        CorrectAnswer = "Hypertext Markup Language",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "High-Level Text Markup Language" },
                            new Option { OptionText = "Hypertext Markup Language" },
                            new Option { OptionText = "Hyperlink and Text Markup Language" },
                            new Option { OptionText = "High-Level Text Management Language" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    
                    // Medium CS MCQ (Continued)
                    new Question()
                    {
                        QuestionText = "What is the purpose of the 'SQL' language in database management?",
                        CorrectAnswer = "To query and manipulate relational databases",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To develop video games" },
                            new Option { OptionText = "To create mobile applications" },
                            new Option { OptionText = "To query and manipulate relational databases" },
                            new Option { OptionText = "To design computer hardware" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure follows the Last-In-First-Out (LIFO) order for adding and removing elements?",
                        CorrectAnswer = "Stack",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Queue" },
                            new Option { OptionText = "Linked List" },
                            new Option { OptionText = "Heap" },
                            new Option { OptionText = "Stack" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the main purpose of a firewall in network security?",
                        CorrectAnswer = "To protect a network from unauthorized access and threats",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To accelerate internet speed" },
                            new Option { OptionText = "To enhance network performance" },
                            new Option { OptionText = "To protect a network from unauthorized access and threats" },
                            new Option { OptionText = "To install software updates" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language is often used for developing system software and low-level applications?",
                        CorrectAnswer = "C",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Python" },
                            new Option { OptionText = "Java" },
                            new Option { OptionText = "C++" },
                            new Option { OptionText = "C" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of a binary search algorithm?",
                        CorrectAnswer = "To efficiently search for a specific element in a sorted array",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To create animations" },
                            new Option { OptionText = "To sort data in ascending order" },
                            new Option { OptionText = "To efficiently search for a specific element in a sorted array" },
                            new Option { OptionText = "To encrypt data transmissions" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What does the acronym 'CPU' stand for in computer terminology?",
                        CorrectAnswer = "Central Processing Unit",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Computer Peripheral Unit" },
                            new Option { OptionText = "Central Power Unit" },
                            new Option { OptionText = "Central Processing Unit" },
                            new Option { OptionText = "Common Processing Unit" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which programming paradigm emphasizes data immutability and pure functions?",
                        CorrectAnswer = "Functional Programming",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Object-Oriented Programming" },
                            new Option { OptionText = "Procedural Programming" },
                            new Option { OptionText = "Structured Programming" },
                            new Option { OptionText = "Functional Programming" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "In computer networking, what does 'LAN' stand for?",
                        CorrectAnswer = "Local Area Network",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Large Access Network" },
                            new Option { OptionText = "Local Access Network" },
                            new Option { OptionText = "Long Area Network" },
                            new Option { OptionText = "Local Area Network" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure allows for efficient insertion and deletion of elements and is often used for implementing databases?",
                        CorrectAnswer = "B-Tree",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Linked List" },
                            new Option { OptionText = "Hash Table" },
                            new Option { OptionText = "Binary Tree" },
                            new Option { OptionText = "B-Tree" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a computer program that replicates itself and spreads to other computers or systems?",
                        CorrectAnswer = "Computer Virus",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Computer Worm" },
                            new Option { OptionText = "Trojan Horse" },
                            new Option { OptionText = "Spyware" },
                            new Option { OptionText = "Computer Virus" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "1"
                    },

                    // Hard CS MCQ
                    new Question()
                    {
                        QuestionText = "What is the time complexity of the quicksort algorithm in the worst case?",
                        CorrectAnswer = "O(n^2)",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "O(n log n)" },
                            new Option { OptionText = "O(n)" },
                            new Option { OptionText = "O(log n)" },
                            new Option { OptionText = "O(n^2)" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "In computer science, what does 'ACID' stand for in the context of database transactions?",
                        CorrectAnswer = "Atomicity, Consistency, Isolation, Durability",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "All Conditions In Database" },
                            new Option { OptionText = "Atomicity, Consistency, Integrity, Durability" },
                            new Option { OptionText = "All Components In Database" },
                            new Option { OptionText = "Atomicity, Consistency, Isolation, Durability" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the maximum number of IP addresses that can be assigned in a /24 subnet?",
                        CorrectAnswer = "256",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "128" },
                            new Option { OptionText = "64" },
                            new Option { OptionText = "512" },
                            new Option { OptionText = "256" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which sorting algorithm has the best average-case time complexity?",
                        CorrectAnswer = "Merge Sort",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Insertion Sort" },
                            new Option { OptionText = "Bubble Sort" },
                            new Option { OptionText = "Quick Sort" },
                            new Option { OptionText = "Merge Sort" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "In cryptography, what is the process of converting plaintext into unreadable gibberish called?",
                        CorrectAnswer = "Encryption",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Decryption" },
                            new Option { OptionText = "Encoding" },
                            new Option { OptionText = "Encryption" },
                            new Option { OptionText = "Hashing" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a programming error that occurs when memory is accessed after it has been freed?",
                        CorrectAnswer = "Dangling Pointer",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Null Pointer" },
                            new Option { OptionText = "Memory Leak" },
                            new Option { OptionText = "Segmentation Fault" },
                            new Option { OptionText = "Dangling Pointer" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure is often used to implement LRU (Least Recently Used) caching?",
                        CorrectAnswer = "Linked List",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Array" },
                            new Option { OptionText = "Stack" },
                            new Option { OptionText = "Queue" },
                            new Option { OptionText = "Linked List" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of the 'finally' block in a try-catch-finally statement in programming?",
                        CorrectAnswer = "To execute code that must be run regardless of whether an exception was thrown or not",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To catch exceptions and handle them" },
                            new Option { OptionText = "To execute code only if an exception is thrown" },
                            new Option { OptionText = "To execute code that must be run regardless of whether an exception was thrown or not" },
                            new Option { OptionText = "To specify the type of exception to catch" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },

                    // Hard CS MCQ
                    new Question()
                    {
                        QuestionText = "What is the purpose of a semaphore in concurrent programming?",
                        CorrectAnswer = "To control access to a shared resource by multiple threads",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To synchronize the execution of multiple processes" },
                            new Option { OptionText = "To allocate memory dynamically" },
                            new Option { OptionText = "To control access to a shared resource by multiple threads" },
                            new Option { OptionText = "To handle exceptions in multithreaded programs" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of the 'volatile' keyword in Java?",
                        CorrectAnswer = "To indicate that a variable's value may be changed by multiple threads",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To declare a constant variable" },
                            new Option { OptionText = "To indicate that a variable cannot be modified" },
                            new Option { OptionText = "To indicate that a variable's value may be changed by multiple threads" },
                            new Option { OptionText = "To specify the access modifier of a class" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of a Dijkstra's algorithm in computer science?",
                        CorrectAnswer = "To find the shortest path between nodes in a weighted graph",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To find prime numbers" },
                            new Option { OptionText = "To sort an array of integers" },
                            new Option { OptionText = "To find the shortest path between nodes in a weighted graph" },
                            new Option { OptionText = "To compress data" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary goal of a Denial-of-Service (DoS) attack?",
                        CorrectAnswer = "To make a service or network unavailable to users",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To steal sensitive data" },
                            new Option { OptionText = "To impersonate a legitimate user" },
                            new Option { OptionText = "To make a service or network unavailable to users" },
                            new Option { OptionText = "To encrypt data" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is a Turing machine in theoretical computer science?",
                        CorrectAnswer = "An abstract mathematical model of computation",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "A type of computer keyboard" },
                            new Option { OptionText = "A programming language" },
                            new Option { OptionText = "A software testing tool" },
                            new Option { OptionText = "An abstract mathematical model of computation" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "In computer graphics, what does 'GPU' stand for?",
                        CorrectAnswer = "Graphics Processing Unit",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "General Processing Unit" },
                            new Option { OptionText = "Graphical Performance Unit" },
                            new Option { OptionText = "Graphics Processing Unit" },
                            new Option { OptionText = "Graphical Presentation Unit" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of the 'grep' command in Unix-like operating systems?",
                        CorrectAnswer = "To search for text patterns in files",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To create a new directory" },
                            new Option { OptionText = "To list files in a directory" },
                            new Option { OptionText = "To search for text patterns in files" },
                            new Option { OptionText = "To display system information" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "Which encryption algorithm is used for secure communications over the Internet?",
                        CorrectAnswer = "TLS/SSL",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "AES" },
                            new Option { OptionText = "RSA" },
                            new Option { OptionText = "DES" },
                            new Option { OptionText = "TLS/SSL" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary function of a firewall in network security?",
                        CorrectAnswer = "To monitor and control incoming and outgoing network traffic",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To encrypt data transmissions" },
                            new Option { OptionText = "To block all incoming network traffic" },
                            new Option { OptionText = "To filter spam emails" },
                            new Option { OptionText = "To manage user authentication" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    // Hard CS MCQ
                    new Question()
                    {
                        QuestionText = "What is the primary purpose of the OSI model in computer networking?",
                        CorrectAnswer = "To provide a framework for understanding and standardizing network protocols.",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To implement strong encryption for data transmission." },
                            new Option { OptionText = "To manage network hardware resources." },
                            new Option { OptionText = "To optimize network performance." }
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "In the context of programming languages, what does the term 'garbage collection' refer to?",
                        CorrectAnswer = "A process of automatically releasing memory occupied by objects that are no longer in use.",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "A method of optimizing code for execution speed." },
                            new Option { OptionText = "A technique for securely deleting files from a computer." },
                            new Option { OptionText = "A way to protect software from unauthorized access." }
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    // Hard CS MCQ (Continued)
                    new Question()
                    {
                        QuestionText = "What is a 'race condition' in concurrent programming?",
                        CorrectAnswer = "A situation in which the behavior of a program depends on the relative timing of events, such as threads or processes.",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "A security vulnerability that allows unauthorized access to data." },
                            new Option { OptionText = "A method for synchronizing access to shared resources." },
                            new Option { OptionText = "A programming error that causes a program to crash." }
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "What is the purpose of a 'mutex' in multithreaded programming?",
                        CorrectAnswer = "To provide mutual exclusion and ensure that only one thread can access a shared resource at a time.",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To optimize memory usage in a program." },
                            new Option { OptionText = "To create parallel threads for improved performance." },
                            new Option { OptionText = "To prevent network congestion in distributed systems." }
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "What is the purpose of 'asymmetric encryption' in computer security?",
                        CorrectAnswer = "To encrypt data using a pair of keys, one for encryption and one for decryption.",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To encrypt data using a single shared key." },
                            new Option { OptionText = "To compress data for efficient storage." },
                            new Option { OptionText = "To authenticate users based on their IP address." }
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },
                    // Hard CS MCQ (Continued)
                    new Question()
                    {
                        QuestionText = "What is 'buffer overflow' in software security?",
                        CorrectAnswer = "A vulnerability that occurs when a program writes data beyond the boundaries of a buffer, potentially overwriting adjacent memory.",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "A security measure to prevent unauthorized access to a database." },
                            new Option { OptionText = "A technique to increase the speed of data transmission." },
                            new Option { OptionText = "A method for encrypting sensitive data." }
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "What is 'garbage collection' in programming languages?",
                        CorrectAnswer = "A process of automatically reclaiming memory occupied by objects that are no longer in use.",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "A debugging technique for finding memory leaks." },
                            new Option { OptionText = "A method for optimizing code execution speed." },
                            new Option { OptionText = "A data structure used for storing temporary variables." }
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "What is the purpose of 'dependency injection' in software design?",
                        CorrectAnswer = "To achieve separation of concerns by allowing components to receive their dependencies from an external source.",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To reduce code duplication by using templates." },
                            new Option { OptionText = "To automate testing and validation of code." },
                            new Option { OptionText = "To enforce strict data typing in a program." }
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "What is 'Big O notation' used for in computer science?",
                        CorrectAnswer = "To describe the upper bound on the time complexity of an algorithm in terms of its input size.",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To measure the physical size of data structures." },
                            new Option { OptionText = "To define the order of execution of program statements." },
                            new Option { OptionText = "To calculate the average-case performance of an algorithm." }
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "What is a 'Distributed Denial of Service (DDoS) attack'?",
                        CorrectAnswer = "An attack in which multiple compromised computers are used to flood a target system with a high volume of traffic, causing it to become unavailable.",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "An attack that steals sensitive information from a database." },
                            new Option { OptionText = "An attack that exploits vulnerabilities in web applications." },
                            new Option { OptionText = "An attack that manipulates data during transmission." }
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "1"
                    },



                    // Easy CS True/False
                    new Question()
                    {
                        QuestionText = "True or False: A byte consists of 8 bits.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: HTML stands for 'Hyper Text Markup Language'.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: JavaScript is a compiled programming language.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Python is a dynamically typed programming language.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: CSS is used to style web pages and control their layout.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: A router is a network device that operates at the data link layer of the OSI model.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Java is an interpreted programming language.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: RAM stands for 'Random Access Memory'.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: PHP is a server-side scripting language.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Git is a distributed version control system.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: HTML is a programming language.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: CSS stands for 'Cascading Style Sheets'.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: JavaScript is a statically typed programming language.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: SQL is a programming language used for managing relational databases.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The 'for' loop is used for creating functions in JavaScript.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Java is primarily used for front-end web development.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: An IP address uniquely identifies a device on the internet.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: PHP can be embedded within HTML code.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: JSON is a data interchange format that stands for 'JavaScript Object Notation'.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Python is a compiled programming language.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Linux is an open-source operating system.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: HTTP stands for 'Hypertext Transfer Protocol'.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: CSS is primarily used for server-side scripting.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: RAM stands for 'Random Access Memory'.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Java is a scripting language.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    // Medium CS True/False
                    new Question()
                    {
                        QuestionText = "True or False: Binary search can only be applied to sorted arrays.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Object-Oriented Programming (OOP) promotes code reusability and modularity.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: HTML is a programming language.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: IPv6 uses 32-bit addresses.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Python is a dynamically typed programming language.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: SQL is a programming language used for building websites.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: HTTP/2 is a faster and more efficient version of HTTP/1.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Virtual Reality (VR) uses computer technology to create a simulated environment.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: CSS can be used to style HTML documents.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Java is a purely functional programming language.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },
                    // Medium CS True/False
                    new Question()
                    {
                        QuestionText = "True or False: AJAX stands for 'Asynchronous JavaScript and XML'.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Docker is a containerization platform used for software deployment.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The OSI model has seven layers.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: JavaScript is a case-sensitive programming language.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: A stack data structure follows the First-In, First-Out (FIFO) principle.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: PHP is a statically typed programming language.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: CSS is used to define the structure and content of a web page.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: A firewall can be used to protect a network from unauthorized access and cyber threats.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: UDP (User Datagram Protocol) is a connectionless protocol used for data transmission on the internet.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The 'this' keyword in JavaScript refers to the current object or context.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: HTTP/2 is a backward-compatible update to HTTP/1.1 that significantly improves web page load times.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: IPv6 uses 128-bit addresses and is designed to address the exhaustion of IPv4 addresses.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The 'for' loop in JavaScript can be used to iterate over the properties of an object.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: An SSL certificate is used to establish secure connections between a client and a server, typically over HTTPS.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: JSON (JavaScript Object Notation) is a data interchange format that is typically used for configuration files and data exchange between a server and a web application.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    // Hard CS True/False
                    new Question()
                    {
                        QuestionText = "True or False: In computer science, a Turing machine can solve any problem that a digital computer can, given enough time and memory.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The P vs. NP problem in computer science has been solved, proving that P is equal to NP.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: A quantum computer uses qubits, which can exist in multiple states simultaneously, to perform certain calculations faster than classical computers.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The Halting Problem, in the context of theoretical computer science, is undecidable, meaning there is no algorithm that can solve it for all possible program-input pairs.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: In computer security, a 'zero-day exploit' refers to a vulnerability that has been known for at least one day without a patch or fix available.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: A non-deterministic Turing machine can solve some problems faster than a deterministic Turing machine.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The concept of 'big data' refers to the volume of data, but not its velocity and variety.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: In computer graphics, 'ray tracing' is a technique used for real-time rendering of complex scenes.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: A 'compiler' is a program that interprets high-level programming languages directly without the need for compilation.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The 'Church-Turing thesis' suggests that any algorithmic process can be simulated by a Turing machine.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    // Hard CS True/False
                    new Question()
                    {
                        QuestionText = "True or False: In computer science, 'NP-hard' problems can be solved in polynomial time by a deterministic algorithm.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The 'halting problem' is solvable; there exists an algorithm that can determine whether any given program will eventually halt.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: 'Quantum computing' leverages the principles of classical physics to perform computations faster than classical computers.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: 'Moore's Law' predicts that the processing power of computers doubles approximately every 18 months.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: In distributed systems, 'Byzantine fault tolerance' can handle arbitrary faults, including malicious ones.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },
                    // Hard CS True/False
                    new Question()
                    {
                        QuestionText = "True or False: In computer science, 'NP-hard' problems can be solved in polynomial time by a deterministic algorithm.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The 'halting problem' is solvable; there exists an algorithm that can determine whether any given program will eventually halt.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: 'Quantum computing' leverages the principles of classical physics to perform computations faster than classical computers.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: 'Moore's Law' predicts that the processing power of computers doubles approximately every 18 months.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: In distributed systems, 'Byzantine fault tolerance' can handle arbitrary faults, including malicious ones.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: In computer networking, 'OSI model' consists of 7 layers, with the physical layer at the top.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: 'Big O notation' is used to represent the best-case time complexity of an algorithm.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: 'Dijkstra's algorithm' guarantees the shortest path in a weighted, directed graph even if it has negative edge weights.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: In computer graphics, 'ray tracing' is a rendering technique that traces the path of light as pixels in an image plane.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The 'Huffman coding' algorithm is used for lossless data compression, such as in ZIP files.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "1"
                    },

                    /* Philosophy */

                    new Question()
                    {
                        QuestionText = "What is the term for the philosophical study of knowledge, belief, and justification?",
                        CorrectAnswer = "Epistemology",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Epistemology" },
                            new Option { OptionText = "Ontology" },
                            new Option { OptionText = "Ethics" },
                            new Option { OptionText = "Aesthetics" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is considered the 'Father of Western Philosophy'?",
                        CorrectAnswer = "Thales",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Thales" },
                            new Option { OptionText = "Socrates" },
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Plato" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What philosophical concept describes the belief that knowledge is primarily or exclusively derived from sensory experience?",
                        CorrectAnswer = "Empiricism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Rationalism" },
                            new Option { OptionText = "Empiricism" },
                            new Option { OptionText = "Skepticism" },
                            new Option { OptionText = "Idealism" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is known for his thought experiment involving an 'unmoved mover' and his contributions to natural theology?",
                        CorrectAnswer = "Thomas Aquinas",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Augustine of Hippo" },
                            new Option { OptionText = "Thomas Aquinas" },
                            new Option { OptionText = "Anselm of Canterbury" },
                            new Option { OptionText = "Duns Scotus" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "In philosophy, what term is used to describe the view that the only true reality is the world of eternal unchanging Forms or Ideas?",
                        CorrectAnswer = "Platonism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Materialism" },
                            new Option { OptionText = "Skepticism" },
                            new Option { OptionText = "Pragmatism" },
                            new Option { OptionText = "Platonism" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who wrote the famous work 'Meditations,' exploring the nature of reality, the self, and the concept of 'cogito, ergo sum' (I think, therefore I am)?",
                        CorrectAnswer = "René Descartes",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Immanuel Kant" },
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "Voltaire" },
                            new Option { OptionText = "René Descartes" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which Greek philosopher is known for his contributions to ethics, emphasizing the importance of virtue and moral character?",
                        CorrectAnswer = "Aristotle",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Socrates" },
                            new Option { OptionText = "Plato" },
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Heraclitus" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What philosophical school of thought asserts that ethical judgments are based on individual feelings and emotions rather than universal principles?",
                        CorrectAnswer = "Emotivism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Utilitarianism" },
                            new Option { OptionText = "Kantianism" },
                            new Option { OptionText = "Deontology" },
                            new Option { OptionText = "Emotivism" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who wrote the famous dialogue 'The Republic' and explored the concept of an ideal state governed by philosopher-kings?",
                        CorrectAnswer = "Plato",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Socrates" },
                            new Option { OptionText = "Plato" },
                            new Option { OptionText = "Epicurus" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },

                    new Question()
                    {
                        QuestionText = "Who is the famous philosopher known for his statement 'Cogito, ergo sum' (I think, therefore I am)?",
                        CorrectAnswer = "René Descartes",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Immanuel Kant" },
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "Voltaire" },
                            new Option { OptionText = "René Descartes" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the study of knowledge, belief, and justification?",
                        CorrectAnswer = "Epistemology",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Metaphysics" },
                            new Option { OptionText = "Ethics" },
                            new Option { OptionText = "Aesthetics" },
                            new Option { OptionText = "Epistemology" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which ancient Greek philosopher was a student of Plato and later became the tutor of Alexander the Great?",
                        CorrectAnswer = "Aristotle",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Socrates" },
                            new Option { OptionText = "Plato" },
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Heraclitus" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What philosophical concept asserts that the rightness or wrongness of actions is determined by their consequences?",
                        CorrectAnswer = "Utilitarianism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Kantianism" },
                            new Option { OptionText = "Deontology" },
                            new Option { OptionText = "Utilitarianism" },
                            new Option { OptionText = "Virtue Ethics" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is known for his work 'Nicomachean Ethics' and his contributions to virtue ethics?",
                        CorrectAnswer = "Aristotle",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Socrates" },
                            new Option { OptionText = "Plato" },
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Epicurus" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which philosopher is often associated with the concept of the 'categorical imperative' in ethics?",
                        CorrectAnswer = "Immanuel Kant",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "John Locke" },
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "Voltaire" },
                            new Option { OptionText = "Immanuel Kant" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Utilitarianism' and the principle of 'the greatest happiness for the greatest number'?",
                        CorrectAnswer = "Jeremy Bentham",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "John Stuart Mill" },
                            new Option { OptionText = "Jeremy Bentham" },
                            new Option { OptionText = "David Hume" },
                            new Option { OptionText = "Friedrich Hayek" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which philosophical concept asserts that moral truths are determined by the individual and their cultural context?",
                        CorrectAnswer = "Relativism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Universalism" },
                            new Option { OptionText = "Objectivism" },
                            new Option { OptionText = "Absolutism" },
                            new Option { OptionText = "Relativism" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who wrote the famous book 'Leviathan,' where he explored political philosophy and the social contract theory?",
                        CorrectAnswer = "Thomas Hobbes",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "John Locke" },
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "Voltaire" },
                            new Option { OptionText = "Thomas Hobbes" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },

                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the study of knowledge, belief, and justification?",
                        CorrectAnswer = "Epistemology",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Metaphysics" },
                            new Option { OptionText = "Ethics" },
                            new Option { OptionText = "Aesthetics" },
                            new Option { OptionText = "Epistemology" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which ancient Greek philosopher was a student of Plato and later became the tutor of Alexander the Great?",
                        CorrectAnswer = "Aristotle",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Socrates" },
                            new Option { OptionText = "Plato" },
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Heraclitus" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What philosophical concept asserts that the rightness or wrongness of actions is determined by their consequences?",
                        CorrectAnswer = "Utilitarianism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Kantianism" },
                            new Option { OptionText = "Deontology" },
                            new Option { OptionText = "Utilitarianism" },
                            new Option { OptionText = "Virtue Ethics" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is known for his work 'Nicomachean Ethics' and his contributions to virtue ethics?",
                        CorrectAnswer = "Aristotle",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Socrates" },
                            new Option { OptionText = "Plato" },
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Epicurus" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which philosopher is often associated with the concept of the 'categorical imperative' in ethics?",
                        CorrectAnswer = "Immanuel Kant",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "John Locke" },
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "Voltaire" },
                            new Option { OptionText = "Immanuel Kant" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Utilitarianism' and the principle of 'the greatest happiness for the greatest number'?",
                        CorrectAnswer = "Jeremy Bentham",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "John Stuart Mill" },
                            new Option { OptionText = "Jeremy Bentham" },
                            new Option { OptionText = "David Hume" },
                            new Option { OptionText = "Friedrich Hayek" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which philosophical concept asserts that moral truths are determined by the individual and their cultural context?",
                        CorrectAnswer = "Relativism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Universalism" },
                            new Option { OptionText = "Objectivism" },
                            new Option { OptionText = "Absolutism" },
                            new Option { OptionText = "Relativism" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who wrote the famous book 'Leviathan,' where he explored political philosophy and the social contract theory?",
                        CorrectAnswer = "Thomas Hobbes",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "John Locke" },
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "Voltaire" },
                            new Option { OptionText = "Thomas Hobbes" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for the branch of philosophy that deals with the nature and existence of reality?",
                        CorrectAnswer = "Metaphysics",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Ethics" },
                            new Option { OptionText = "Aesthetics" },
                            new Option { OptionText = "Epistemology" },
                            new Option { OptionText = "Metaphysics" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which Greek philosopher is known for his dialogues exploring the nature of justice, the ideal city-state, and the allegory of the cave?",
                        CorrectAnswer = "Plato",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Socrates" },
                            new Option { OptionText = "Plato" },
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Heraclitus" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "2"
                    },

                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his existentialist philosophy, including the idea that 'existence precedes essence'?",
                        CorrectAnswer = "Jean-Paul Sartre",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "Albert Camus" },
                            new Option { OptionText = "Jean-Paul Sartre" },
                            new Option { OptionText = "Martin Heidegger" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What philosophical term describes the belief that individuals are morally responsible for their actions, even if those actions are determined?",
                        CorrectAnswer = "Compatibilism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Determinism" },
                            new Option { OptionText = "Incompatibilism" },
                            new Option { OptionText = "Compatibilism" },
                            new Option { OptionText = "Nihilism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Critique of Pure Reason' and contributions to metaphysics and epistemology?",
                        CorrectAnswer = "Immanuel Kant",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "David Hume" },
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "Voltaire" },
                            new Option { OptionText = "Immanuel Kant" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What ethical theory emphasizes the importance of moral character and virtues in determining right and wrong actions?",
                        CorrectAnswer = "Virtue Ethics",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Utilitarianism" },
                            new Option { OptionText = "Deontology" },
                            new Option { OptionText = "Virtue Ethics" },
                            new Option { OptionText = "Consequentialism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his works 'Thus Spoke Zarathustra' and 'Beyond Good and Evil' and his critique of traditional morality?",
                        CorrectAnswer = "Friedrich Nietzsche",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Søren Kierkegaard" },
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "Albert Camus" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the study of values, ethics, and morality?",
                        CorrectAnswer = "Ethics",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Aesthetics" },
                            new Option { OptionText = "Metaethics" },
                            new Option { OptionText = "Ethics" },
                            new Option { OptionText = "Existentialism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who wrote the philosophical novel 'The Stranger' and explored themes of existentialism and absurdity?",
                        CorrectAnswer = "Albert Camus",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Jean-Paul Sartre" },
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "Albert Camus" },
                            new Option { OptionText = "Søren Kierkegaard" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the belief in the existence of multiple deities or gods?",
                        CorrectAnswer = "Polytheism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Monotheism" },
                            new Option { OptionText = "Atheism" },
                            new Option { OptionText = "Agnosticism" },
                            new Option { OptionText = "Polytheism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },

                    new Question()
                    {
                        QuestionText = "What philosophical concept argues that all human actions are motivated by self-interest?",
                        CorrectAnswer = "Egoism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Utilitarianism" },
                            new Option { OptionText = "Altruism" },
                            new Option { OptionText = "Egoism" },
                            new Option { OptionText = "Hedonism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Categorical Imperative' and deontological ethics?",
                        CorrectAnswer = "Immanuel Kant",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "John Locke" },
                            new Option { OptionText = "John Stuart Mill" },
                            new Option { OptionText = "Jeremy Bentham" },
                            new Option { OptionText = "Immanuel Kant" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What philosophical term describes the theory that knowledge is derived primarily from sensory experience?",
                        CorrectAnswer = "Empiricism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Rationalism" },
                            new Option { OptionText = "Idealism" },
                            new Option { OptionText = "Empiricism" },
                            new Option { OptionText = "Skepticism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Nicomachean Ethics' and the concept of virtue ethics?",
                        CorrectAnswer = "Aristotle",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Plato" },
                            new Option { OptionText = "Socrates" },
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Confucius" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What philosophical term describes the belief that the external world exists independently of our perceptions?",
                        CorrectAnswer = "Realism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Idealism" },
                            new Option { OptionText = "Solipsism" },
                            new Option { OptionText = "Empiricism" },
                            new Option { OptionText = "Realism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Essay Concerning Human Understanding' and the idea of the 'tabula rasa'?",
                        CorrectAnswer = "John Locke",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "George Berkeley" },
                            new Option { OptionText = "John Locke" },
                            new Option { OptionText = "David Hume" },
                            new Option { OptionText = "René Descartes" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What ethical theory argues that the morality of an action is determined by its consequences?",
                        CorrectAnswer = "Consequentialism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Virtue Ethics" },
                            new Option { OptionText = "Deontology" },
                            new Option { OptionText = "Consequentialism" },
                            new Option { OptionText = "Utilitarianism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Dialogues Concerning Natural Religion' and arguments on the existence of God?",
                        CorrectAnswer = "David Hume",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Thomas Aquinas" },
                            new Option { OptionText = "David Hume" },
                            new Option { OptionText = "Blaise Pascal" },
                            new Option { OptionText = "Gottfried Leibniz" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Critique of Practical Reason' and his work on moral philosophy?",
                        CorrectAnswer = "Immanuel Kant",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "Immanuel Kant" },
                            new Option { OptionText = "John Stuart Mill" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the study of what can be known?",
                        CorrectAnswer = "Epistemology",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Ethics" },
                            new Option { OptionText = "Aesthetics" },
                            new Option { OptionText = "Epistemology" },
                            new Option { OptionText = "Ontology" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Two Dogmas of Empiricism' and contributions to analytic philosophy?",
                        CorrectAnswer = "Willard Van Orman Quine",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Ludwig Wittgenstein" },
                            new Option { OptionText = "Karl Popper" },
                            new Option { OptionText = "Bertrand Russell" },
                            new Option { OptionText = "Willard Van Orman Quine" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What philosophical term refers to the theory that all events are predetermined and therefore inevitable?",
                        CorrectAnswer = "Determinism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Free Will" },
                            new Option { OptionText = "Fatalism" },
                            new Option { OptionText = "Indeterminism" },
                            new Option { OptionText = "Determinism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Principia Mathematica' and contributions to the philosophy of mathematics?",
                        CorrectAnswer = "Alfred North Whitehead",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Bertrand Russell" },
                            new Option { OptionText = "Kurt Gödel" },
                            new Option { OptionText = "Ludwig Wittgenstein" },
                            new Option { OptionText = "Alfred North Whitehead" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the belief that nothing is inherently meaningful or significant?",
                        CorrectAnswer = "Nihilism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Existentialism" },
                            new Option { OptionText = "Absurdism" },
                            new Option { OptionText = "Nihilism" },
                            new Option { OptionText = "Hedonism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his works on 'Being and Time' and existentialism?",
                        CorrectAnswer = "Martin Heidegger",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "Jean-Paul Sartre" },
                            new Option { OptionText = "Søren Kierkegaard" },
                            new Option { OptionText = "Martin Heidegger" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the study of the nature of reality?",
                        CorrectAnswer = "Ontology",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Epistemology" },
                            new Option { OptionText = "Aesthetics" },
                            new Option { OptionText = "Ethics" },
                            new Option { OptionText = "Ontology" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Tractatus Logico-Philosophicus' and contributions to the philosophy of language?",
                        CorrectAnswer = "Ludwig Wittgenstein",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Karl Popper" },
                            new Option { OptionText = "Alfred North Whitehead" },
                            new Option { OptionText = "Ludwig Wittgenstein" },
                            new Option { OptionText = "Willard Van Orman Quine" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What ethical theory focuses on the inherent value of actions themselves, rather than the consequences or duties involved?",
                        CorrectAnswer = "Deontology",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Utilitarianism" },
                            new Option { OptionText = "Virtue Ethics" },
                            new Option { OptionText = "Deontology" },
                            new Option { OptionText = "Egoism" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "2"
                    },

                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Being and Time' and his influential work on existentialism?",
                        CorrectAnswer = "Martin Heidegger",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Søren Kierkegaard" },
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "Jean-Paul Sartre" },
                            new Option { OptionText = "Martin Heidegger" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which philosopher proposed the 'Veil of Ignorance' thought experiment as a way to determine principles of justice?",
                        CorrectAnswer = "John Rawls",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Immanuel Kant" },
                            new Option { OptionText = "John Locke" },
                            new Option { OptionText = "Thomas Hobbes" },
                            new Option { OptionText = "John Rawls" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the view that reality is fundamentally composed of indivisible units called 'atoms'?",
                        CorrectAnswer = "Atomism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Idealism" },
                            new Option { OptionText = "Dualism" },
                            new Option { OptionText = "Empiricism" },
                            new Option { OptionText = "Atomism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his works on the 'Ubermensch' and his critique of traditional morality?",
                        CorrectAnswer = "Friedrich Nietzsche",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Søren Kierkegaard" },
                            new Option { OptionText = "Jean-Paul Sartre" },
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "Albert Camus" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which philosophical theory asserts that the highest good is happiness and that moral actions are those that maximize overall happiness?",
                        CorrectAnswer = "Utilitarianism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Deontology" },
                            new Option { OptionText = "Virtue Ethics" },
                            new Option { OptionText = "Utilitarianism" },
                            new Option { OptionText = "Egoism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who wrote 'The Communist Manifesto' and 'Das Kapital,' promoting revolutionary socialism and criticizing capitalism?",
                        CorrectAnswer = "Karl Marx",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Friedrich Engels" },
                            new Option { OptionText = "Vladimir Lenin" },
                            new Option { OptionText = "Leon Trotsky" },
                            new Option { OptionText = "Karl Marx" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical theory that knowledge is derived from sensory experience and observation?",
                        CorrectAnswer = "Empiricism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Rationalism" },
                            new Option { OptionText = "Idealism" },
                            new Option { OptionText = "Skepticism" },
                            new Option { OptionText = "Empiricism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Meditations' and contributions to the philosophy of skepticism?",
                        CorrectAnswer = "René Descartes",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "David Hume" },
                            new Option { OptionText = "Immanuel Kant" },
                            new Option { OptionText = "Bertrand Russell" },
                            new Option { OptionText = "René Descartes" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the belief that individuals should act in their self-interest and maximize their own well-being?",
                        CorrectAnswer = "Egoism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Utilitarianism" },
                            new Option { OptionText = "Deontology" },
                            new Option { OptionText = "Altruism" },
                            new Option { OptionText = "Egoism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },

                    new Question()
                    {
                        QuestionText = "What is the philosophical theory that reality is fundamentally unknowable, and that true knowledge is impossible?",
                        CorrectAnswer = "Skepticism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Empiricism" },
                            new Option { OptionText = "Rationalism" },
                            new Option { OptionText = "Solipsism" },
                            new Option { OptionText = "Skepticism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Critique of Pure Reason' and his contributions to metaphysics and epistemology?",
                        CorrectAnswer = "Immanuel Kant",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "René Descartes" },
                            new Option { OptionText = "Immanuel Kant" },
                            new Option { OptionText = "David Hume" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the belief that only physical matter truly exists, and that mental phenomena are reducible to physical processes?",
                        CorrectAnswer = "Physicalism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Dualism" },
                            new Option { OptionText = "Idealism" },
                            new Option { OptionText = "Materialism" },
                            new Option { OptionText = "Physicalism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Republic' and his ideas on justice, the ideal state, and the allegory of the cave?",
                        CorrectAnswer = "Plato",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Socrates" },
                            new Option { OptionText = "Plato" },
                            new Option { OptionText = "Epicurus" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical view that there is no inherent meaning or purpose in the universe, and that individuals must create their own meaning?",
                        CorrectAnswer = "Existentialism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Nihilism" },
                            new Option { OptionText = "Rationalism" },
                            new Option { OptionText = "Existentialism" },
                            new Option { OptionText = "Absurdism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Metaphysics' and contributions to the study of being, existence, and reality?",
                        CorrectAnswer = "Aristotle",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Parmenides" },
                            new Option { OptionText = "Heraclitus" },
                            new Option { OptionText = "Aristotle" },
                            new Option { OptionText = "Thales" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the belief that all knowledge and reality are ultimately dependent on one's own mind?",
                        CorrectAnswer = "Solipsism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Monism" },
                            new Option { OptionText = "Idealism" },
                            new Option { OptionText = "Skepticism" },
                            new Option { OptionText = "Solipsism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Essay Concerning Human Understanding' and his ideas on empiricism?",
                        CorrectAnswer = "John Locke",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Thomas Hobbes" },
                            new Option { OptionText = "George Berkeley" },
                            new Option { OptionText = "John Locke" },
                            new Option { OptionText = "Gottfried Leibniz" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the belief that there are no objective moral truths or standards?",
                        CorrectAnswer = "Moral Relativism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Moral Objectivism" },
                            new Option { OptionText = "Utilitarianism" },
                            new Option { OptionText = "Deontology" },
                            new Option { OptionText = "Moral Relativism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },

                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Critique of Pure Reason' and his contributions to the philosophy of metaphysics and epistemology?",
                        CorrectAnswer = "Immanuel Kant",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "John Locke" },
                            new Option { OptionText = "Thomas Hobbes" },
                            new Option { OptionText = "Immanuel Kant" },
                            new Option { OptionText = "Georg Wilhelm Friedrich Hegel" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which philosopher is associated with the philosophy of absurdism and wrote 'The Myth of Sisyphus'?",
                        CorrectAnswer = "Albert Camus",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Jean-Paul Sartre" },
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "Albert Camus" },
                            new Option { OptionText = "Søren Kierkegaard" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which philosopher is known for his works on political philosophy, including 'The Leviathan'?",
                        CorrectAnswer = "Thomas Hobbes",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "John Locke" },
                            new Option { OptionText = "Thomas Hobbes" },
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "John Stuart Mill" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the study of the nature of reality, including the relationship between mind and matter?",
                        CorrectAnswer = "Metaphysics",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Epistemology" },
                            new Option { OptionText = "Ethics" },
                            new Option { OptionText = "Aesthetics" },
                            new Option { OptionText = "Metaphysics" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Which philosopher is associated with the concept of 'categorical imperative' and the idea that actions should be universally applicable?",
                        CorrectAnswer = "Immanuel Kant",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "John Stuart Mill" },
                            new Option { OptionText = "Jean-Jacques Rousseau" },
                            new Option { OptionText = "Immanuel Kant" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What philosophical term refers to the theory that everything, including all thoughts, is in principle reducible to simple physical interactions?",
                        CorrectAnswer = "Reductionism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Dualism" },
                            new Option { OptionText = "Holism" },
                            new Option { OptionText = "Idealism" },
                            new Option { OptionText = "Reductionism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "Who is the philosopher known for his 'Thus Spoke Zarathustra' and his ideas on the 'will to power'?",
                        CorrectAnswer = "Friedrich Nietzsche",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Søren Kierkegaard" },
                            new Option { OptionText = "Jean-Paul Sartre" },
                            new Option { OptionText = "Friedrich Nietzsche" },
                            new Option { OptionText = "Albert Camus" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "What is the philosophical term for the view that only mental states are real and that the physical world does not exist independently?",
                        CorrectAnswer = "Idealism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Materialism" },
                            new Option { OptionText = "Dualism" },
                            new Option { OptionText = "Solipsism" },
                            new Option { OptionText = "Idealism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "2"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Socrates was a famous ancient Greek philosopher known for his contributions to ethics and the Socratic method.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Aristotle was a disciple of Socrates.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Plato was a student of Aristotle.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'Allegory of the Cave' is a famous philosophical concept introduced by Plato.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Epistemology is the branch of philosophy that deals with questions about knowledge and belief.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Rene Descartes is known for his famous statement 'Cogito, ergo sum' (I think, therefore I am).",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Ethics is the branch of philosophy that deals with questions about what is morally right and wrong.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'Allegory of the Cave' is a famous philosophical concept introduced by Aristotle.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Immanuel Kant is known for his influential work on utilitarian ethics.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The study of aesthetics focuses on questions related to the nature of beauty and art.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Rene Descartes is known for his famous statement 'Cogito, ergo sum' (I think, therefore I am).",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Søren Kierkegaard is considered one of the founding figures of existentialism in philosophy.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Empiricism is a philosophical approach that emphasizes the role of reason and innate ideas in human knowledge.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Aesthetics is the branch of philosophy that deals with questions about what is morally right and wrong.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Albert Camus is a prominent figure in the philosophy of existentialism.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: John Stuart Mill is known for his contributions to the field of epistemology.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Logic is the branch of philosophy that deals with the nature of reality and existence.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Plato was a famous philosopher known for his contributions to the field of ethics.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Jean-Jacques Rousseau is a key figure in political philosophy and social contract theory.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Socratic irony is a technique used by Socrates in his philosophical dialogues.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: John Locke is known for his influential work on epistemology and the theory of knowledge.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Friedrich Nietzsche is a prominent philosopher associated with nihilism and the 'will to power.'",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Aristotle was a student of Plato and later became a teacher of Alexander the Great.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Dualism is a philosophical concept that asserts the unity of mind and body.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Confucius is known for his significant influence on Chinese philosophy and ethics.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Utilitarianism is an ethical theory that emphasizes the importance of individual rights and freedoms.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "2"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Immanuel Kant is associated with the idea of 'categorical imperative' in ethics.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Existentialism is a philosophical movement that emphasizes the importance of individual freedom and choice.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Thomas Hobbes is best known for his theory of 'social contract' and the state of nature.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'Euthyphro dilemma' is a problem in the philosophy of religion, related to the nature of morality and the divine.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Empiricism is a philosophical approach that emphasizes the role of experience and sensory perception in gaining knowledge.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Karl Marx is a key figure in political philosophy and the author of 'The Communist Manifesto.'",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'trolley problem' is a thought experiment in ethics that raises moral dilemmas about sacrificing one for the greater good.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Aristotle's virtue ethics focuses on developing moral character through virtuous habits and moderation.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'Ship of Theseus' paradox is a philosophical problem concerning identity and the replacement of ship parts.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Simone de Beauvoir is a significant figure in existentialist philosophy and feminist thought.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: John Locke is known for his theory of the 'blank slate' or 'tabula rasa' regarding human knowledge.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Jean-Jacques Rousseau's political philosophy emphasizes the 'general will' as the foundation of a just society.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Utilitarianism is an ethical theory that suggests actions are morally right if they maximize happiness or pleasure.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Søren Kierkegaard is considered the father of existentialist philosophy and is known for the concept of 'leap of faith.'",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'cogito, ergo sum' ('I think, therefore I am') is a foundational statement in the philosophy of René Descartes.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Nihilism is a philosophical belief that life is without objective meaning or value.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Platonism is a philosophical theory that asserts the existence of abstract, ideal forms or entities.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Albert Camus is known for his concept of the 'absurd' and his contributions to existentialist philosophy.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Pragmatism is a philosophical tradition that focuses on the practical consequences of beliefs and ideas.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'problem of evil' is a philosophical challenge related to the existence of evil and suffering in a world created by an all-powerful and benevolent God.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Immanuel Kant's 'categorical imperative' is a principle that one should act only according to that maxim by which one can consistently will that it become a universal law.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Albert Camus' philosophical work 'The Myth of Sisyphus' explores the concept of absurdity and the idea that life is inherently meaningless.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Existentialism is a philosophical movement that emphasizes individual freedom and the importance of personal choice and responsibility.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Thomas Hobbes' political philosophy is best summarized by the phrase 'life is solitary, poor, nasty, brutish, and short.'",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Friedrich Nietzsche famously declared that 'God is dead' to emphasize the decline of religious and moral authority in the modern world.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Jean-Paul Sartre's philosophy is often associated with the concept of 'bad faith' or self-deception in avoiding one's freedom and responsibility.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'philosopher's stone' is a real substance with the power to transmute base metals into gold, as believed in alchemy.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'Euthyphro dilemma' poses the question of whether something is morally good because it is loved by the gods, or if the gods love it because it is morally good.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Jean-Jacques Rousseau's social contract theory suggests that individuals should submit to the 'general will' of the community for the common good.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'Ship of Theseus' is a thought experiment that explores the concept of identity and change over time by considering whether a ship with all its parts replaced remains the same ship.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Søren Kierkegaard is considered the father of existentialism and is known for his exploration of subjective truth and individual authenticity.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Utilitarianism is an ethical theory that states the right action is the one that maximizes overall happiness or utility.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: John Locke's philosophy includes the idea of the 'blank slate' or 'tabula rasa,' suggesting that individuals are born without innate ideas and knowledge is acquired through experience.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: 'Cogito, ergo sum' is a famous philosophical statement by René Descartes, which translates to 'I think, therefore I am.'",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The 'trolley problem' is a moral dilemma that raises questions about the ethics of sacrificing one person to save many, often involving a runaway trolley.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Thomas Aquinas' 'Five Ways' are five arguments for the existence of God, including the cosmological, teleological, and moral arguments.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Confucius is primarily known for his contributions to the development of Daoism and the idea of 'the Way' as a path to ethical behavior.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Simone de Beauvoir's book 'The Second Sex' is a foundational work in feminist philosophy, addressing the oppression of women and the concept of 'the other.'",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Blaise Pascal's 'Pascal's Wager' is an argument that suggests it is more rational to believe in God, even if God's existence cannot be proven, as the potential benefits of belief outweigh the consequences of disbelief.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Platonism is a philosophical view that asserts the existence of abstract objects, such as numbers and mathematical entities, as independent and objective realities.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Albert Camus is known for his philosophy of absurdism, which argues that life is inherently devoid of meaning or purpose.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Jean-Jacques Rousseau's social contract theory suggests that individuals should voluntarily give up some freedoms for the common good and protection of their natural rights.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Friedrich Nietzsche introduced the concept of the 'will to power' as a fundamental driving force in human behavior and creativity.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: John Stuart Mill's philosophy of utilitarianism argues that actions are morally right if they promote happiness and wrong if they produce the reverse of happiness.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Existentialism is a philosophical movement that emphasizes individual existence, freedom, and choice, often associated with thinkers like Jean-Paul Sartre and Friedrich Nietzsche.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Karl Marx's philosophy of historical materialism posits that societal change is primarily driven by changes in economic systems and modes of production.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Thomas Hobbes' political philosophy argues that the state of nature is a condition of war, and individuals create social contracts to establish a civil society and escape the 'war of all against all.'",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Immanuel Kant's moral philosophy is known for its categorical imperative, a principle that commands individuals to act only according to maxims that they can consistently will as universal laws without contradiction.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Simone Weil was a philosopher who explored concepts of attention and affliction, advocating for empathy and compassionate understanding of others' suffering.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Baruch Spinoza's philosophy combines elements of rationalism and pantheism, asserting that God and the universe are one and the same, and everything is a manifestation of the divine substance.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "2"
                    },
                    /* economics */
                    new Question()
                    {
                        QuestionText = "Which of the following is considered a fundamental economic problem?",
                        CorrectAnswer = "Scarcity",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Inflation" },
                            new Option { OptionText = "Economic growth" },
                            new Option { OptionText = "Scarcity" },
                            new Option { OptionText = "Monopoly" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What does GDP stand for in economics?",
                        CorrectAnswer = "Gross Domestic Product",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "General Development Program" },
                            new Option { OptionText = "Growth, Development, Progress" },
                            new Option { OptionText = "Gross Domestic Product" },
                            new Option { OptionText = "Global Development Process" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which economic system is characterized by private ownership of resources and a market-driven approach?",
                        CorrectAnswer = "Capitalism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Communism" },
                            new Option { OptionText = "Socialism" },
                            new Option { OptionText = "Capitalism" },
                            new Option { OptionText = "Feudalism" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary function of the central bank in a country?",
                        CorrectAnswer = "Control the money supply and interest rates",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Provide loans to individuals" },
                            new Option { OptionText = "Promote international trade" },
                            new Option { OptionText = "Control the money supply and interest rates" },
                            new Option { OptionText = "Set fiscal policies" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the law of supply and demand in economics?",
                        CorrectAnswer = "Prices rise when supply is low and demand is high",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Prices rise when supply is low and demand is high" },
                            new Option { OptionText = "Prices fall when supply is low and demand is low" },
                            new Option { OptionText = "Prices fall when supply is high and demand is high" },
                            new Option { OptionText = "Prices rise when supply is high and demand is low" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary goal of fiscal policy?",
                        CorrectAnswer = "Stimulate economic growth and stability",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Reduce government debt" },
                            new Option { OptionText = "Stimulate economic growth and stability" },
                            new Option { OptionText = "Control inflation" },
                            new Option { OptionText = "Promote international trade" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which factor of production refers to the skills, knowledge, and abilities of the workforce?",
                        CorrectAnswer = "Labor",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Capital" },
                            new Option { OptionText = "Land" },
                            new Option { OptionText = "Entrepreneurship" },
                            new Option { OptionText = "Labor" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the economic term for a good that has the characteristics of being rivalrous and non-excludable?",
                        CorrectAnswer = "Public good",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Private good" },
                            new Option { OptionText = "Common resource" },
                            new Option { OptionText = "Club good" },
                            new Option { OptionText = "Public good" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },

                    new Question()
                    {
                        QuestionText = "What is the term for a tax that takes a higher percentage of income from high-income earners than from low-income earners?",
                        CorrectAnswer = "Progressive tax",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Regressive tax" },
                            new Option { OptionText = "Flat tax" },
                            new Option { OptionText = "Progressive tax" },
                            new Option { OptionText = "Sales tax" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which market structure is characterized by many sellers offering similar but not identical products, and each seller has a small market share?",
                        CorrectAnswer = "Monopolistic competition",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Perfect competition" },
                            new Option { OptionText = "Monopoly" },
                            new Option { OptionText = "Oligopoly" },
                            new Option { OptionText = "Monopolistic competition" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "In economics, what does the term 'utility' refer to?",
                        CorrectAnswer = "The satisfaction or happiness derived from consuming a good or service",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "The value of a currency in foreign exchange markets" },
                            new Option { OptionText = "The level of government spending" },
                            new Option { OptionText = "The satisfaction or happiness derived from consuming a good or service" },
                            new Option { OptionText = "The quantity of goods produced by a firm" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which of the following best defines the term 'monetary policy' in economics?",
                        CorrectAnswer = "Control of the money supply by a central bank to achieve economic goals",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "A system of barter trade" },
                            new Option { OptionText = "Control of government spending on social programs" },
                            new Option { OptionText = "A government's regulation of prices" },
                            new Option { OptionText = "Control of the money supply by a central bank to achieve economic goals" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What term is used in economics to describe the gap between a country's exports and imports of goods and services?",
                        CorrectAnswer = "Trade balance",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Budget deficit" },
                            new Option { OptionText = "National debt" },
                            new Option { OptionText = "Trade balance" },
                            new Option { OptionText = "Fiscal policy" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary goal of microeconomics?",
                        CorrectAnswer = "To study the economic behavior of individual consumers and firms",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To analyze the overall economy of a country" },
                            new Option { OptionText = "To study international trade and finance" },
                            new Option { OptionText = "To study the economic behavior of individual consumers and firms" },
                            new Option { OptionText = "To examine the economic impact of government policies" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which term describes a legal maximum price set by the government at which a particular good or service can be sold?",
                        CorrectAnswer = "Price ceiling",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Price floor" },
                            new Option { OptionText = "Market equilibrium" },
                            new Option { OptionText = "Price ceiling" },
                            new Option { OptionText = "Demand elasticity" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the definition of 'opportunity cost' in economics?",
                        CorrectAnswer = "The value of the next best alternative that is forgone",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "The total cost of a decision" },
                            new Option { OptionText = "The value of the next best alternative that is forgone" },
                            new Option { OptionText = "The explicit cost of production" },
                            new Option { OptionText = "The price of a good or service" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },

                    new Question()
                    {
                        QuestionText = "What does the term 'inflation' refer to in economics?",
                        CorrectAnswer = "A sustained increase in the general price level of goods and services",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "A decrease in the money supply" },
                            new Option { OptionText = "A sustained decrease in prices" },
                            new Option { OptionText = "A sustained increase in the general price level of goods and services" },
                            new Option { OptionText = "An increase in the value of a currency" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which term is used in economics to describe the cost of forgoing the next best alternative when making a decision?",
                        CorrectAnswer = "Opportunity cost",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Explicit cost" },
                            new Option { OptionText = "Marginal cost" },
                            new Option { OptionText = "Sunk cost" },
                            new Option { OptionText = "Opportunity cost" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a market structure in which there is only one seller and no close substitutes for the product?",
                        CorrectAnswer = "Monopoly",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Oligopoly" },
                            new Option { OptionText = "Perfect competition" },
                            new Option { OptionText = "Monopolistic competition" },
                            new Option { OptionText = "Monopoly" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the economic term for a good that is both non-excludable and rivalrous?",
                        CorrectAnswer = "Common resource",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Private good" },
                            new Option { OptionText = "Public good" },
                            new Option { OptionText = "Club good" },
                            new Option { OptionText = "Common resource" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the economic concept that refers to the increase in the general level of prices over time?",
                        CorrectAnswer = "Inflation",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Deflation" },
                            new Option { OptionText = "Recession" },
                            new Option { OptionText = "Inflation" },
                            new Option { OptionText = "Stagnation" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which economic term describes a situation where the production of a good or service is most efficient when a single firm produces it?",
                        CorrectAnswer = "Natural monopoly",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Cartel" },
                            new Option { OptionText = "Oligopoly" },
                            new Option { OptionText = "Perfect competition" },
                            new Option { OptionText = "Natural monopoly" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a tax that takes a larger percentage of income from low-income earners than from high-income earners?",
                        CorrectAnswer = "Regressive tax",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Progressive tax" },
                            new Option { OptionText = "Flat tax" },
                            new Option { OptionText = "Excise tax" },
                            new Option { OptionText = "Regressive tax" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which economic concept represents the additional cost incurred when producing one more unit of a good?",
                        CorrectAnswer = "Marginal cost",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Fixed cost" },
                            new Option { OptionText = "Variable cost" },
                            new Option { OptionText = "Average cost" },
                            new Option { OptionText = "Marginal cost" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What does Gross Domestic Product (GDP) measure?",
                        CorrectAnswer = "The total value of goods and services produced in a country in a given time period",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "The total population of a country" },
                            new Option { OptionText = "The average income of the population" },
                            new Option { OptionText = "The total value of goods and services produced in a country in a given time period" },
                            new Option { OptionText = "The total government spending in a country" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a situation where there are not enough resources to satisfy all human wants?",
                        CorrectAnswer = "Scarcity",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Abundance" },
                            new Option { OptionText = "Surplus" },
                            new Option { OptionText = "Scarcity" },
                            new Option { OptionText = "Monopoly" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which type of unemployment occurs when a person is temporarily out of work as they search for a new job or transition between jobs?",
                        CorrectAnswer = "Frictional unemployment",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Structural unemployment" },
                            new Option { OptionText = "Cyclical unemployment" },
                            new Option { OptionText = "Seasonal unemployment" },
                            new Option { OptionText = "Frictional unemployment" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for the change in the average level of prices of goods and services over time?",
                        CorrectAnswer = "Inflation",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Deflation" },
                            new Option { OptionText = "Hyperinflation" },
                            new Option { OptionText = "Stagflation" },
                            new Option { OptionText = "Inflation" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "In economics, what does the law of supply state?",
                        CorrectAnswer = "As the price of a good increases, the quantity supplied also increases, all else being equal",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "As the price of a good increases, the quantity supplied decreases, all else being equal" },
                            new Option { OptionText = "As the price of a good decreases, the quantity supplied increases, all else being equal" },
                            new Option { OptionText = "As the price of a good remains constant, the quantity supplied remains constant" },
                            new Option { OptionText = "As the price of a good increases, the quantity supplied also increases, all else being equal" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What does the term 'Laissez-faire' mean in economics?",
                        CorrectAnswer = "A policy of minimal government interference in economic affairs",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "A policy of heavy government regulation of economic affairs" },
                            new Option { OptionText = "A policy of socialism and central planning" },
                            new Option { OptionText = "A policy of minimal government interference in social affairs" },
                            new Option { OptionText = "A policy of minimal government interference in economic affairs" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for the additional benefit gained from consuming one more unit of a good or service?",
                        CorrectAnswer = "Marginal utility",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Total utility" },
                            new Option { OptionText = "Diminishing returns" },
                            new Option { OptionText = "Marginal cost" },
                            new Option { OptionText = "Marginal utility" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "In economics, what is the term for the maximum price at which a buyer is willing to purchase a good or service?",
                        CorrectAnswer = "Reservation price",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Market price" },
                            new Option { OptionText = "Supply price" },
                            new Option { OptionText = "Reservation price" },
                            new Option { OptionText = "Demand price" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a market structure where there is only one seller in the market with a unique product?",
                        CorrectAnswer = "Monopoly",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Oligopoly" },
                            new Option { OptionText = "Monopsony" },
                            new Option { OptionText = "Monopoly" },
                            new Option { OptionText = "Perfect competition" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a decrease in the general price level of goods and services in an economy over time?",
                        CorrectAnswer = "Deflation",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Inflation" },
                            new Option { OptionText = "Hyperinflation" },
                            new Option { OptionText = "Deflation" },
                            new Option { OptionText = "Stagflation" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which of the following best describes a regressive tax system?",
                        CorrectAnswer = "Taxes take a larger percentage of income from low-income earners than from high-income earners",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Taxes take a larger percentage of income from high-income earners than from low-income earners" },
                            new Option { OptionText = "Taxes take the same percentage of income from all income earners" },
                            new Option { OptionText = "Taxes take a larger percentage of income from low-income earners than from high-income earners" },
                            new Option { OptionText = "Taxes are only collected from businesses" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "In economics, what is the term for the value of the next best alternative when a decision is made?",
                        CorrectAnswer = "Opportunity cost",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Marginal cost" },
                            new Option { OptionText = "Sunk cost" },
                            new Option { OptionText = "Average cost" },
                            new Option { OptionText = "Opportunity cost" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the economic term for a situation where a market lacks competitive pricing and is dominated by a few large sellers?",
                        CorrectAnswer = "Oligopoly",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Monopoly" },
                            new Option { OptionText = "Perfect competition" },
                            new Option { OptionText = "Oligopoly" },
                            new Option { OptionText = "Monopsony" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the economic term for a decrease in the total output or production of an economy over time?",
                        CorrectAnswer = "Recession",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Inflation" },
                            new Option { OptionText = "Stagflation" },
                            new Option { OptionText = "Deflation" },
                            new Option { OptionText = "Recession" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a legal framework that establishes and enforces the rules and regulations governing the financial markets and institutions?",
                        CorrectAnswer = "Financial regulation",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Fiscal policy" },
                            new Option { OptionText = "Financial regulation" },
                            new Option { OptionText = "Monetary policy" },
                            new Option { OptionText = "Trade policy" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "In economics, what is the term for the excess of total revenue over total cost?",
                        CorrectAnswer = "Profit",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Loss" },
                            new Option { OptionText = "Revenue" },
                            new Option { OptionText = "Income" },
                            new Option { OptionText = "Profit" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary function of the central bank in a country's monetary system?",
                        CorrectAnswer = "To regulate the money supply and ensure stability in the financial system",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "To issue currency notes and coins" },
                            new Option { OptionText = "To manage government spending" },
                            new Option { OptionText = "To regulate the money supply and ensure stability in the financial system" },
                            new Option { OptionText = "To set interest rates for commercial banks" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which of the following is an example of a regressive tax?",
                        CorrectAnswer = "Sales tax on essential goods",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Progressive income tax" },
                            new Option { OptionText = "Flat tax on all income levels" },
                            new Option { OptionText = "Sales tax on essential goods" },
                            new Option { OptionText = "Property tax on real estate" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What economic term is used to describe the situation when the prices of goods and services rise over time?",
                        CorrectAnswer = "Inflation",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Deflation" },
                            new Option { OptionText = "Stagflation" },
                            new Option { OptionText = "Inflation" },
                            new Option { OptionText = "Hyperinflation" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "In economics, what does GDP stand for?",
                        CorrectAnswer = "Gross Domestic Product",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Gross Development Percentage" },
                            new Option { OptionText = "General Domestic Production" },
                            new Option { OptionText = "Global Distribution Protocol" },
                            new Option { OptionText = "Gross Domestic Product" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for the total value of all goods and services produced within a country in a given time period?",
                        CorrectAnswer = "Gross National Product (GNP)",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Gross Domestic Product (GDP)" },
                            new Option { OptionText = "Gross National Product (GNP)" },
                            new Option { OptionText = "Net National Product (NNP)" },
                            new Option { OptionText = "National Income (NI)" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What type of economic system is characterized by private ownership of the means of production and individual economic freedom?",
                        CorrectAnswer = "Capitalism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Socialism" },
                            new Option { OptionText = "Communism" },
                            new Option { OptionText = "Capitalism" },
                            new Option { OptionText = "Mixed economy" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which of the following is an example of a fiscal policy tool used to combat inflation?",
                        CorrectAnswer = "Increasing taxes",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Decreasing government spending" },
                            new Option { OptionText = "Decreasing taxes" },
                            new Option { OptionText = "Increasing government spending" },
                            new Option { OptionText = "Increasing taxes" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a good that is non-excludable and non-rivalrous, meaning that one person's use does not diminish its availability to others?",
                        CorrectAnswer = "Public good",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Private good" },
                            new Option { OptionText = "Commons" },
                            new Option { OptionText = "Public good" },
                            new Option { OptionText = "Club good" },
                        },
                        Difficulty = "medium",
                        QuestionType = "multiple",
                        Category = "3"
                    },

                    new Question()
                    {
                        QuestionText = "Which economic theory argues that government intervention in the economy is typically inefficient and should be minimized?",
                        CorrectAnswer = "Neoliberalism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Keynesianism" },
                            new Option { OptionText = "Marxism" },
                            new Option { OptionText = "Neoliberalism" },
                            new Option { OptionText = "Socialism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a sudden and severe drop in the value of a currency, often caused by a loss of confidence in the country's economic policies?",
                        CorrectAnswer = "Currency crisis",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Hyperinflation" },
                            new Option { OptionText = "Bank run" },
                            new Option { OptionText = "Currency crisis" },
                            new Option { OptionText = "Recession" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which economic concept refers to the tendency of governments to increase spending during economic upturns and decrease spending during downturns?",
                        CorrectAnswer = "Pro-cyclical fiscal policy",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Countercyclical fiscal policy" },
                            new Option { OptionText = "Procyclical fiscal policy" },
                            new Option { OptionText = "Anticyclical fiscal policy" },
                            new Option { OptionText = "Pro-cyclical fiscal policy" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "In economics, what is the term for the phenomenon where individuals make decisions based on their personal preferences rather than rational self-interest?",
                        CorrectAnswer = "Behavioral economics",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Classical economics" },
                            new Option { OptionText = "Rational choice theory" },
                            new Option { OptionText = "Game theory" },
                            new Option { OptionText = "Behavioral economics" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which economic concept refers to the ability to convert an asset into cash quickly without significant loss in value?",
                        CorrectAnswer = "Liquidity",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Profitability" },
                            new Option { OptionText = "Solvency" },
                            new Option { OptionText = "Liquidity" },
                            new Option { OptionText = "Marketability" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a policy where a central bank increases the money supply by buying financial assets, typically government securities?",
                        CorrectAnswer = "Quantitative easing (QE)",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Monetary tightening" },
                            new Option { OptionText = "Quantitative easing (QE)" },
                            new Option { OptionText = "Inflation targeting" },
                            new Option { OptionText = "Currency pegging" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for the condition where a country is unable to meet its debt obligations, leading to a default on its loans?",
                        CorrectAnswer = "Sovereign default",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Credit risk" },
                            new Option { OptionText = "Sovereign default" },
                            new Option { OptionText = "Bankruptcy" },
                            new Option { OptionText = "Debt repudiation" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which economic theory advocates for government ownership of key industries and a planned economy?",
                        CorrectAnswer = "Socialism",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Laissez-faire capitalism" },
                            new Option { OptionText = "Socialism" },
                            new Option { OptionText = "Monetarism" },
                            new Option { OptionText = "Supply-side economics" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },

                    new Question()
                    {
                        QuestionText = "In international trade, what is the term for the exchange of goods and services without the use of money?",
                        CorrectAnswer = "Barter trade",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Free trade" },
                            new Option { OptionText = "Barter trade" },
                            new Option { OptionText = "Foreign exchange" },
                            new Option { OptionText = "Protectionism" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a market structure where there is a single seller and no close substitutes for the product?",
                        CorrectAnswer = "Monopoly",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Oligopoly" },
                            new Option { OptionText = "Monopolistic competition" },
                            new Option { OptionText = "Perfect competition" },
                            new Option { OptionText = "Monopoly" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which economic theory suggests that government spending should increase during recessions and decrease during economic booms?",
                        CorrectAnswer = "Keynesian economics",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Austrian economics" },
                            new Option { OptionText = "Monetarism" },
                            new Option { OptionText = "Classical economics" },
                            new Option { OptionText = "Keynesian economics" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a market structure where there are many sellers of similar but not identical products?",
                        CorrectAnswer = "Monopolistic competition",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Oligopoly" },
                            new Option { OptionText = "Perfect competition" },
                            new Option { OptionText = "Monopolistic competition" },
                            new Option { OptionText = "Monopoly" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which of the following is a characteristic of a command economy?",
                        CorrectAnswer = "Centralized government planning and control of resources",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Private ownership of most resources" },
                            new Option { OptionText = "Market-driven allocation of resources" },
                            new Option { OptionText = "Centralized government planning and control of resources" },
                            new Option { OptionText = "Profit-driven decision-making" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for the interest rate at which banks can borrow money from the central bank?",
                        CorrectAnswer = "Discount rate",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Prime rate" },
                            new Option { OptionText = "Federal funds rate" },
                            new Option { OptionText = "Discount rate" },
                            new Option { OptionText = "LIBOR rate" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which of the following is a measure of the overall price level in an economy, often used as an indicator of inflation?",
                        CorrectAnswer = "Consumer Price Index (CPI)",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Gross Domestic Product (GDP)" },
                            new Option { OptionText = "Consumer Price Index (CPI)" },
                            new Option { OptionText = "Producer Price Index (PPI)" },
                            new Option { OptionText = "Balance of Trade (BOT)" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a situation where an individual or entity can produce a good or service at a lower opportunity cost than others?",
                        CorrectAnswer = "Comparative advantage",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Absolute advantage" },
                            new Option { OptionText = "Diminishing marginal utility" },
                            new Option { OptionText = "Opportunity cost" },
                            new Option { OptionText = "Comparative advantage" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which of the following is an example of a trade barrier that restricts the import of foreign goods?",
                        CorrectAnswer = "Tariff",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Subsidy" },
                            new Option { OptionText = "Quota" },
                            new Option { OptionText = "Tariff" },
                            new Option { OptionText = "Dumping" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "In economics, what is the term for a good that is both excludable and rivalrous?",
                        CorrectAnswer = "Private good",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Public good" },
                            new Option { OptionText = "Commons" },
                            new Option { OptionText = "Private good" },
                            new Option { OptionText = "Club good" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which economic theory argues that people have rational preferences and will seek to maximize their utility?",
                        CorrectAnswer = "Rational choice theory",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Behavioral economics" },
                            new Option { OptionText = "Game theory" },
                            new Option { OptionText = "Rational choice theory" },
                            new Option { OptionText = "Classical economics" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for the practice of selling goods in a foreign market at a price lower than the production cost?",
                        CorrectAnswer = "Dumping",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Price discrimination" },
                            new Option { OptionText = "Subsidy" },
                            new Option { OptionText = "Monopoly" },
                            new Option { OptionText = "Dumping" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "Which type of inflation occurs when there is an increase in the price level due to excessive demand for goods and services?",
                        CorrectAnswer = "Demand-pull inflation",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Cost-push inflation" },
                            new Option { OptionText = "Stagflation" },
                            new Option { OptionText = "Hyperinflation" },
                            new Option { OptionText = "Demand-pull inflation" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a legal restriction on the maximum price at which a good or service can be sold?",
                        CorrectAnswer = "Price ceiling",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Price floor" },
                            new Option { OptionText = "Monopoly pricing" },
                            new Option { OptionText = "Price ceiling" },
                            new Option { OptionText = "Price discrimination" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "In economics, what does the term 'opportunity cost' refer to?",
                        CorrectAnswer = "The value of the next best alternative when a choice is made",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "The monetary cost of a decision" },
                            new Option { OptionText = "The value of the next best alternative when a choice is made" },
                            new Option { OptionText = "The fixed cost of production" },
                            new Option { OptionText = "The total cost of a product" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "What is the term for a tax system where the tax rate increases as the income or wealth of the taxpayer increases?",
                        CorrectAnswer = "Progressive taxation",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "Proportional taxation" },
                            new Option { OptionText = "Regressive taxation" },
                            new Option { OptionText = "Progressive taxation" },
                            new Option { OptionText = "Lump-sum taxation" },
                        },
                        Difficulty = "hard",
                        QuestionType = "multiple",
                        Category = "3"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: Scarcity refers to the unlimited availability of resources to meet human wants and needs.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A market economy is also known as a planned economy.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Supply and demand are the fundamental forces that determine prices in a market economy.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Gross Domestic Product (GDP) is a measure of the total value of all goods and services produced within a country's borders in a given time period.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Elasticity measures the responsiveness of quantity demanded to changes in price.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Monopoly is a market structure with many firms competing against each other.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A progressive tax system charges a higher percentage of income from high-income earners than low-income earners.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Federal Reserve System is responsible for regulating and supervising banks in the United States.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Fiscal policy involves the use of government spending and taxation to influence the economy.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The opportunity cost of a decision is the value of the next best alternative that must be forgone.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Microeconomics studies the behavior of individual households and firms.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Inflation is the sustained increase in the overall price level of goods and services in an economy over time.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A budget deficit occurs when government expenditures exceed government revenues in a fiscal year.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Gross National Product (GNP) measures the economic output of a country's residents and businesses, regardless of where they are located.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A recession is a period of economic decline with negative growth in Gross Domestic Product (GDP) for two consecutive quarters.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Comparative advantage is the ability of one country or firm to produce a good or service at a lower opportunity cost than others.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The law of demand states that, all else being equal, as the price of a good or service increases, the quantity demanded decreases.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A trade deficit occurs when a country exports more goods and services than it imports.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Elasticity measures the responsiveness of quantity demanded to changes in price.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Federal Reserve System is responsible for regulating and supervising banks in the United States.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Monopoly is a market structure with multiple firms competing for market share.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Elasticity measures how well a firm can stretch its resources to meet demand.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A regressive tax takes a higher percentage of income from low-income earners than from high-income earners.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A central bank is responsible for managing a country's monetary policy and issuing currency.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Gross Domestic Product (GDP) is the total value of all goods and services produced within a country's borders in a specific time period.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A progressive tax takes a higher percentage of income from high-income earners than from low-income earners.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Supply and demand is a fundamental concept in economics that describes how prices are determined in markets.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Barter is an exchange of goods and services without the use of money.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A trade surplus occurs when a country exports more goods and services than it imports.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Fiscal policy refers to the use of government spending and taxation to influence the economy.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "easy",
                        QuestionType = "boolean",
                        Category = "3"
                    },

                    new Question()
                    {
                        QuestionText = "True or False: The law of diminishing returns states that as more units of a variable input are added to a fixed input, the marginal product of the variable input eventually decreases.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: An oligopoly is a market structure with many small firms, each producing a slightly different product.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Inflation is the decline in the general price level of goods and services in an economy over a period of time.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A mixed economy combines elements of both free-market capitalism and central planning socialism.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Phillips curve illustrates the trade-off between inflation and unemployment in the short run.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A budget deficit occurs when government spending exceeds tax revenue, leading to an increase in public debt.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Opportunity cost is the value of the best alternative forgone when a decision is made.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A price ceiling is a government-imposed limit on the highest price that can be charged for a good or service.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Comparative advantage is the ability of one country to produce a good or service at a lower opportunity cost than another country.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A subsidy is a payment from the government to producers of a good or service, often used to encourage production or consumption.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A progressive tax system imposes higher tax rates on those with higher incomes.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A subsidy is a payment from the government to consumers of a good or service, often used to reduce consumption.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Monopolistic competition is a market structure characterized by a large number of firms, each producing identical products.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Fiscal policy refers to the use of government spending and taxation to influence the economy.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: An externality is a side effect or consequence of an industrial or commercial activity that affects other parties not directly involved in the activity.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Consumer Price Index (CPI) measures the average change over time in the prices paid by urban consumers for a market basket of consumer goods and services.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Gross Domestic Product (GDP) measures the total economic output of a country, including both goods and services.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A subsidy is a government payment that encourages the production and consumption of a good or service.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A budget surplus occurs when government spending exceeds tax revenue, leading to an increase in public debt.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Absolute advantage refers to the ability of one country to produce a good or service at a lower opportunity cost than another country.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: In economics, the term 'elasticity' measures the responsiveness of demand or supply to changes in price.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Laffer curve suggests that there is an optimal tax rate that maximizes government revenue.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Federal Reserve, often referred to as the Fed, is the central bank of the United States and is responsible for monetary policy.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A trade deficit occurs when a country's exports exceed its imports.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Gross National Product (GNP) includes the income earned by a country's residents and businesses, both domestically and abroad.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A regressive tax system imposes higher tax rates on those with higher incomes.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Fiscal policy involves the use of interest rates and the money supply to control the economy.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A trade surplus occurs when a country's exports exceed its imports.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Phillips curve illustrates the inverse relationship between inflation and unemployment.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The law of diminishing marginal utility states that the more of a good or service a consumer consumes, the greater the satisfaction derived from each additional unit.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "medium",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A Giffen good is a type of inferior good for which demand decreases as the price increases.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Quantity Theory of Money suggests that changes in the money supply have a direct and proportional effect on price levels in an economy.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: An economic bubble is characterized by the sustained increase in the prices of certain assets or commodities beyond their intrinsic value.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Lucas critique is a criticism of economic models that lack the ability to account for unanticipated changes in economic policy.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A Gini coefficient of 1 represents perfect income equality, while a Gini coefficient of 0 represents perfect income inequality.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Fiscal consolidation refers to an expansionary fiscal policy aimed at increasing government spending to stimulate economic growth.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Economic rent is the surplus income earned by a factor of production that exceeds its opportunity cost.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Kuznets curve suggests that income inequality tends to decrease as an economy develops and matures.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A zero-sum game is a situation in which one participant's gain or loss is exactly balanced by the losses or gains of other participants.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Fiscal drag refers to a situation in which a person is pushed into a higher tax bracket due to an increase in their income.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Comparative advantage, as explained by David Ricardo, suggests that countries should specialize in producing goods they can produce at the lowest opportunity cost.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Laffer curve illustrates the relationship between tax rates and tax revenue, suggesting that there is an optimal tax rate that maximizes revenue.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Phillips curve shows an inverse relationship between inflation and unemployment, implying that policymakers can choose a trade-off between the two variables.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A budget deficit occurs when government expenditures exceed government revenues in a given fiscal year.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The law of demand states that, all other factors being equal, as the price of a good increases, the quantity demanded for that good decreases.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Oligopoly is a market structure characterized by a large number of firms, each producing a unique product.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Economic growth is measured by the annual percentage increase in a country's gross domestic product (GDP).",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Monetarism is an economic theory that argues that variations in the money supply are the main driver of economic fluctuations.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: In economics, the term 'ceteris paribus' means 'holding all other factors constant' and is often used in the analysis of cause and effect relationships.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A supply shock can lead to changes in both the price level and real GDP in an economy, making it an important factor in economic analysis.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A regressive tax system takes a larger percentage of income from low-income individuals than from high-income individuals.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Giffen goods are a type of inferior good, where demand increases as the price rises and decreases as the price falls.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Pareto efficiency is achieved when it is impossible to make any individual better off without making someone else worse off.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Fisher effect suggests that an increase in expected inflation rates will lead to a corresponding increase in nominal interest rates.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Monopoly is a market structure where there are many firms selling identical products, and there are no barriers to entry for new firms.",
                        CorrectAnswer = "False",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: The Lorenz curve is used to measure income inequality within a society, showing the distribution of income among individuals or households.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Elasticity measures how much the quantity demanded of a good responds to changes in the price of that good.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Deflation is a general decrease in the price level of goods and services and is often associated with economic recessions.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: Opportunity cost is the cost of forgoing the next best alternative when making a decision.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    },
                    new Question()
                    {
                        QuestionText = "True or False: A subsidy is a government payment to producers to encourage the production of a particular good or service.",
                        CorrectAnswer = "True",
                        Options = new List<Option>()
                        {
                            new Option { OptionText = "True" },
                            new Option { OptionText = "False" },
                        },
                        Difficulty = "hard",
                        QuestionType = "boolean",
                        Category = "3"
                    }
                };
                _dataContext.Questions.AddRange(questions);
                _dataContext.SaveChanges();
            }
        }
    }
}
