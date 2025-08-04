# Expense Tracker - My ASP.NET Core MVC Learning Project

This project is an Expense Tracker App built with ASP.NET Core MVC, using **Syncfusion Components** for the UI. It serves as my personal learning project to demonstrate how to build a complete enterprise-level application from scratch.

By following a detailed video tutorial, I will be exploring and implementing various key concepts of modern web development.

## 🚀 Features & Learning Points

This application showcases the following features, which represent key learning points for me during the development process:

* **Implemented CRUD Operations:** I learned how to build and integrate full CRUD (Create, Read, Update, Delete) functionality for both the `Category` and `Transaction` models.
* **Syncfusion Grid with Paging & Sorting:** I gained hands-on experience using the **Syncfusion Data Grid component** to display data, implementing advanced features like paging, sorting, and filtering.
* **Interactive Dashboard:** The application features a dashboard with **Syncfusion Chart elements** to provide a visual summary of financial data.
* **Dockable Side Bar Menu:** I implemented a responsive and user-friendly side menu for navigation using a **Syncfusion Dockable Side Bar**.

## 💻 Technologies Used

* **Backend:** ASP.NET Core MVC
* **UI Components:** **Syncfusion ASP.NET Core UI Controls**
* **Database:** Entity Framework Core (Code-First approach)
* **Frontend:**
    * HTML5
    * CSS3
    * JavaScript
    * Bootstrap (for core layout and styling)
* **Other:**
    * C#
    * Razor syntax for dynamic views

## ✅ Prerequisites

To run this project on your local machine, you will need the following:

* [.NET SDK](https://dotnet.microsoft.com/download) (Version 6.0 or later)
* A code editor such as [Visual Studio](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
* A database provider (e.g., SQL Server LocalDB, which is included with Visual Studio)

## 🚀 Getting Started

Follow these steps to set up and run the application:

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/your-username/your-repo-name.git](https://github.com/your-username/your-repo-name.git)
    cd your-repo-name
    ```
2.  **Restore NuGet packages:**
    ```bash
    dotnet restore
    ```
3.  **Update the database:**
    This project uses Entity Framework Core with Code-First migrations. Run the following commands to create the database and apply the initial migrations:
    ```bash
    dotnet ef database update
    ```
4.  **Run the application:**
    ```bash
    dotnet watch run
    ```
    The application will launch and be accessible at a local address like `https://localhost:5001`.

## 📺 Video Tutorial

This project was developed by following the video tutorial, "Build an Expense Tracker with Asp.Net Core MVC," which served as my guide.

[https://www.youtube.com/watch?v=zQ5eijfpuu8](https://www.youtube.com/watch?v=zQ5eijfpuu8)

All credit for the project structure, logic, and tutorial content goes to the video's author.

## ✍️ Author & Acknowledgments

* **[Yong Yew Sing]** - Project implementation and repository owner.
* **[CodAffection]** - For the excellent video tutorial and guidance.
* **Syncfusion** - For the UI components that power the application's interface.
