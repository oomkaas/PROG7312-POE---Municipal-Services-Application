# PROG7312 POE - Municipal Services Application

# **Municipal Services Application**

Overview
This Municipal Services Application aims to streamline the process for South African citizens to report issues, request services, access local events and announcements, and receive updates on the status of their service requests. Currently, the application provides the ability to Report Issues, with other features to be implemented in future updates.

# **Features**

**Report Issues:** Allows users to report municipal issues such as sanitation problems, road damage, and utility outages. Users can input their location, choose a category, attach media, and submit their report.

**Local Events and Announcements:** (To be implemented later)

**Service Request Status:** (To be implemented later)

**Progress Tracking:** A progress bar is shown during the report submission process to enhance user engagement.

**View Reported Issues:** Users can view a list of previously reported issues.

# **Setup and Installation**

Prerequisites
.NET Framework: Ensure that .NET Framework 4.7.2 or higher is installed on your machine.

Visual Studio: The project should be compiled and run using Visual Studio 2019 or later.

**Steps to Compile and Run**

Clone the repository:

Copy code
git clone (https://github.com/oomkaas/PROG7312-POE---Municipal-Services-Application)
Open the solution:

Open the .sln in Visual Studio.

Restore dependencies:

Build the project:

Run the project:

Form1 (Main Menu): The startup form with three buttons for navigating to:

Report Issues (implemented)

Local Events and Announcements (to be implemented)

Service Request Status (to be implemented)

ReportIssues Form: The form where users can:
Enter the location of the issue.

Select a category from a dropdown list.

Provide a description of the issue.

Attach images or documents related to the issue.

Submit the issue with a progress bar that tracks submission progress.

View previously reported issues in a ListBox.

# **User Instructions**

**Main Menu**

Upon launching the application, the main menu is presented with the following options:

Report Issues: Navigate to the form where users can submit issues to the municipality.

Local Events and Announcements (disabled in current version).

Service Request Status (disabled in current version).

**Reporting an Issue**

Click on Report Issues to open the reporting form.

Fill in the Location of the issue in the text box.

Select the appropriate Category from the dropdown (e.g., sanitation, roads, utilities).

Provide a detailed Description of the issue in the RichTextBox.

Attach any relevant media files (images/documents) by clicking the Attach Media button.

Click Submit to send the report to the municipality. A progress bar will indicate the submission process.

After submission, you will see a success message and the reported issue will be added to the list of reported issues.

**Viewing Reported Issues**

A ListBox is available on the Report Issues form to view the list of previously reported issues. Each entry includes the location, category, and description.

**Future Enhancements**

Local Events and Announcements: Users will be able to view upcoming municipal events and public announcements.

Service Request Status: Users will be able to track the status of their previously reported issues
