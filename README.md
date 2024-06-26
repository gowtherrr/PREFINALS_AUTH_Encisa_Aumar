Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered)
Conceptual Understanding:
 
Onion Architecture: (Yes/No) 
Have you heard of the Onion Architecture principle in software design?
Answer: No, I don't know how where to use it.

MVC Pattern: (Yes/No) 
Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?
Answer: Yes, but it is hard for me to understand.

Web API: (Yes/No) 
Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?
Answer: Yes

Application & Bottlenecks:
Onion Architecture:
Benefits: (1-3 keywords)
Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
Answer:  Separation of concerns
      Testability
      Maintainability 

Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s).
Answer: Yes. greater difficulty when compared to simpler undertakings. If it's hard to find engineers who know the pattern, the development process can stop.

MVC:
Components: (1-3 keywords each)
Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
Model: Manages the data and business logic
View: Displays the data (UI)
Controller: Handles user input and updates the Model
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)
Answer: Yes. Tight connection between the model and controller can have a detrimental effect on maintainability because it can make controller unit testing difficult and lead to logic changes spreading throughout the application.

Web API:
Differences from MVC: (Yes/No and Briefly Explain
Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
Answer: Yes. Web APIs are designed to provide clients with data typically for mobile applications or single-page applications; in contrast, classic MVC applications are typically used to manage user interfaces and generate views.

Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)
Answer: Yes. Because they include complicated data exchanges and frequent page refreshes, traditional MVC apps may have performance issues. A lighter method is provided by web APIs, which lower performance overhead and increase data handling effectiveness.

