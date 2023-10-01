using BrainPulse.Data;
using BrainPulse.Models;

namespace BrainPulse
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Questions.Any())
            {
                var questions = new List<Question>()
                {
                    // Easy Questions
                    new Question()
                    {
                        QuestionText = "What does CPU stand for?",
                        CorrectAnswer = "Central Processing Unit",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Central Process Unit" },
                            new IncorrectOption { IncorrectOptionText="Computer Personal Unit" },
                            new IncorrectOption { IncorrectOptionText="Central Processor Unit" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language is known for its simplicity and readability, often used for beginners?",
                        CorrectAnswer = "Python",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="C++" },
                            new IncorrectOption { IncorrectOptionText="Java" },
                            new IncorrectOption { IncorrectOptionText="Ruby" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What does HTML stand for?",
                        CorrectAnswer = "Hypertext Markup Language",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Hyperlink and Text Markup Language" },
                            new IncorrectOption { IncorrectOptionText="High-Level Text Markup Language" },
                            new IncorrectOption { IncorrectOptionText="Hypertext Markdown Language" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which company developed the C# programming language?",
                        CorrectAnswer = "Microsoft",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Apple" },
                            new IncorrectOption { IncorrectOptionText="Google" },
                            new IncorrectOption { IncorrectOptionText="IBM" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "In web development, what does CSS stand for?",
                        CorrectAnswer = "Cascading Style Sheets",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Computer Style Sheets" },
                            new IncorrectOption { IncorrectOptionText="Creative Style Sheets" },
                            new IncorrectOption { IncorrectOptionText="Coded Style Sheets" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure uses a Last-In-First-Out (LIFO) approach?",
                        CorrectAnswer = "Stack",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Queue" },
                            new IncorrectOption { IncorrectOptionText="Array" },
                            new IncorrectOption { IncorrectOptionText="Linked List" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What does API stand for in programming?",
                        CorrectAnswer = "Application Programming Interface",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Advanced Program Interface" },
                            new IncorrectOption { IncorrectOptionText="Automated Programming Interface" },
                            new IncorrectOption { IncorrectOptionText="Application Program Integration" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What is the main purpose of a firewall in network security?",
                        CorrectAnswer = "To monitor and control incoming and outgoing network traffic",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="To boost network speed" },
                            new IncorrectOption { IncorrectOptionText="To store user data" },
                            new IncorrectOption { IncorrectOptionText="To perform encryption" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language was created by Guido van Rossum?",
                        CorrectAnswer = "Python",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Java" },
                            new IncorrectOption { IncorrectOptionText="C++" },
                            new IncorrectOption { IncorrectOptionText="JavaScript" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What does RAM stand for?",
                        CorrectAnswer = "Random Access Memory",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Read-Only Memory" },
                            new IncorrectOption { IncorrectOptionText="Remote Access Memory" },
                            new IncorrectOption { IncorrectOptionText="Run-And-Manage" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },

                    new Question()
                    {
                        QuestionText = "Which programming language is often used for web development and known for its flexibility and ease of use?",
                        CorrectAnswer = "JavaScript",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Python" },
                            new IncorrectOption { IncorrectOptionText="C#" },
                            new IncorrectOption { IncorrectOptionText="Java" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary function of an operating system?",
                        CorrectAnswer = "To manage computer hardware and provide services for computer programs",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="To create computer graphics" },
                            new IncorrectOption { IncorrectOptionText="To design software applications" },
                            new IncorrectOption { IncorrectOptionText="To develop web pages" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure is used to store and retrieve data in a first-in-first-out (FIFO) order?",
                        CorrectAnswer = "Queue",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Stack" },
                            new IncorrectOption { IncorrectOptionText="Array" },
                            new IncorrectOption { IncorrectOptionText="Linked List" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "In programming, what does the acronym 'OOP' stand for?",
                        CorrectAnswer = "Object-Oriented Programming",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Operational Object Programming" },
                            new IncorrectOption { IncorrectOptionText="Object-Oriented Process" },
                            new IncorrectOption { IncorrectOptionText="Ordered Object Programming" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which computer component is responsible for storing data and programs that are currently being used?",
                        CorrectAnswer = "RAM (Random Access Memory)",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="CPU (Central Processing Unit)" },
                            new IncorrectOption { IncorrectOptionText="Hard Drive" },
                            new IncorrectOption { IncorrectOptionText="Graphics Card" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What is the main purpose of an HTTP cookie in web development?",
                        CorrectAnswer = "To store user data or track user behavior on websites",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="To display web page content" },
                            new IncorrectOption { IncorrectOptionText="To create web forms" },
                            new IncorrectOption { IncorrectOptionText="To design website layouts" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language is commonly used for building dynamic web applications and server-side scripting?",
                        CorrectAnswer = "PHP",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Ruby" },
                            new IncorrectOption { IncorrectOptionText="C++" },
                            new IncorrectOption { IncorrectOptionText="Swift" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What does the acronym 'URL' stand for in web addresses?",
                        CorrectAnswer = "Uniform Resource Locator",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Universal Routing Language" },
                            new IncorrectOption { IncorrectOptionText="Unified Resource Link" },
                            new IncorrectOption { IncorrectOptionText="Unique Resource Listing" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "In computer programming, what is an 'if statement' used for?",
                        CorrectAnswer = "Conditional execution of code based on a specified condition",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Looping through an array" },
                            new IncorrectOption { IncorrectOptionText="Displaying user input" },
                            new IncorrectOption { IncorrectOptionText="Creating functions" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which web development technology is used for creating the structure and layout of a webpage?",
                        CorrectAnswer = "HTML (Hypertext Markup Language)",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="CSS (Cascading Style Sheets)" },
                            new IncorrectOption { IncorrectOptionText="JavaScript" },
                            new IncorrectOption { IncorrectOptionText="PHP (Hypertext Preprocessor)" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    
                    new Question()
                    {
                        QuestionText = "What is the purpose of a 'for loop' in programming?",
                        CorrectAnswer = "To repeat a block of code a specified number of times",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="To define a function" },
                            new IncorrectOption { IncorrectOptionText="To create a variable" },
                            new IncorrectOption { IncorrectOptionText="To display a message" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure is used to organize data in a hierarchical manner?",
                        CorrectAnswer = "Tree",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Array" },
                            new IncorrectOption { IncorrectOptionText="Stack" },
                            new IncorrectOption { IncorrectOptionText="Queue" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What is the primary function of an 'if-else statement' in programming?",
                        CorrectAnswer = "To execute different code blocks depending on a specified condition",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="To define a variable" },
                            new IncorrectOption { IncorrectOptionText="To create a loop" },
                            new IncorrectOption { IncorrectOptionText="To display user input" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which programming language is often used for developing mobile applications for Android devices?",
                        CorrectAnswer = "Java",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Swift" },
                            new IncorrectOption { IncorrectOptionText="Python" },
                            new IncorrectOption { IncorrectOptionText= "C#" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of 'version control' in software development?",
                        CorrectAnswer = "To track changes and collaborate on code with multiple developers",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="To design user interfaces" },
                            new IncorrectOption { IncorrectOptionText="To test software applications" },
                            new IncorrectOption { IncorrectOptionText="To write code documentation" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which file format is commonly used for storing structured data that is easy for humans to read and write?",
                        CorrectAnswer = "JSON (JavaScript Object Notation)",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="XML (eXtensible Markup Language)" },
                            new IncorrectOption { IncorrectOptionText="CSV (Comma-Separated Values)" },
                            new IncorrectOption { IncorrectOptionText="PDF (Portable Document Format)" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What is the main purpose of 'HTTP' in web development?",
                        CorrectAnswer = "To transfer data between a web server and a web browser",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="To create web page layouts" },
                            new IncorrectOption { IncorrectOptionText="To store data on a web server" },
                            new IncorrectOption { IncorrectOptionText="To design user interfaces" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which programming paradigm emphasizes the use of functions as the primary building blocks of software?",
                        CorrectAnswer = "Functional Programming",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Object-Oriented Programming" },
                            new IncorrectOption { IncorrectOptionText="Procedural Programming" },
                            new IncorrectOption { IncorrectOptionText="Structured Programming" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "What is the purpose of 'debugging' in software development?",
                        CorrectAnswer = "To identify and fix errors or defects in the code",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="To write new code" },
                            new IncorrectOption { IncorrectOptionText= "To test software performance" },
                            new IncorrectOption { IncorrectOptionText="To document code functions" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                    new Question()
                    {
                        QuestionText = "Which data structure is used to store a collection of key-value pairs?",
                        CorrectAnswer = "Dictionary",
                        IncorrectOptions = new List<IncorrectOption>()
                        {
                            new IncorrectOption { IncorrectOptionText="Array" },
                            new IncorrectOption { IncorrectOptionText="List" },
                            new IncorrectOption { IncorrectOptionText="Queue" },
                        },
                        Difficulty = "easy",
                        QuestionType = "multiple",
                        Category = "1",
                    },
                };
                dataContext.Questions.AddRange(questions);
                dataContext.SaveChanges();
            }
        }
    }
}
