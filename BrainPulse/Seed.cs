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
                };
                dataContext.Questions.AddRange(questions);
                dataContext.SaveChanges();
            }
        }
    }
}
