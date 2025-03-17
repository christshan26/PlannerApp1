# PlannerApp1

PlannerApp1 is a cross-platform application built using .NET MAUI. It helps users plan and manage their daily activities efficiently. The application supports Android, iOS, MacCatalyst, and Windows platforms.
<br>**The application is intended for Swedish users.**
> [!NOTE]
>Please be aware that this is an application under development by me, a .NET-developer student.

## Features

- **Activity Management**: Add, edit, and delete activities.
- **Daily Overview**: View a list of activities for the current day, sorted by time.
- **Monthly Overview**: View a calender of activities for the selected month.
- **Color Coding**: Activities are color-coded based on the member responsible.
  
<br/>

<br/>

**Screenshots**
<br/>
![Screenshot of Daily Overview](https://github.com/user-attachments/assets/934f1767-29c1-4f70-9162-fd4e760098bb)
![Screenshot of Adding an Acitvity](https://github.com/user-attachments/assets/ce1165ba-02c3-48a5-b546-19ae62e2c73c)

<br/>
<br/>

## Installation

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) with .NET MAUI workload installed

### Steps

1. Clone the repository:
    git clone https://github.com/christshan26/PlannerApp1.git

2. Navigate to the project directory:
    cd PlannerApp1
      
3. Open the solution in Visual Studio:
   start PlannerApp1.sln

4. Restore the NuGet packages:
   dotnet restore

5. Build and run the project on your preferred platform.

## Usage

### Home Page

The home page displays a list of today's activities, sorted by their start time. Each activity is color-coded based on the member responsible.

### Adding a New Activity

To add a new activity, navigate to the "New Activity" page and fill in the required details such as title, description, start time, end time, and member.

## TODOs

- [ ] Implement save functionality
- [ ] Add UI elements for the month overview
- [ ] Implement month overview functionality
- [ ] Integrate Firebase for cloud synchronization

## Project Structure

- **Models**: Contains the `Activity` model which represents an activity.
- **ViewModels**: Contains the view models for the application, including `HomeViewModel` and `BaseViewModel`.
- **Views**: Contains the XAML pages for the application, such as `HomePage`, `MonthOverviewPage`, and `NewActivityPage`.
- **Platforms**: Contains platform-specific code for Android, iOS, MacCatalyst, and Windows.

## License

This project is licensed under the MIT License. See [the file](https://github.com/christshan26/PlannerApp1/blob/master/LICENSE.txt) for details.
