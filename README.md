# TravelBro_Csharp
# Travel Agency Management System
 
Welcome to the Travel Agency Management System project!
This application is designed to efficiently manage the core operations of a travel agency, streamlining the process of handling travel packages, customer bookings, employee management, and more. Built using C# (.NET) and integrated with a Microsoft SQL Server database, the system provides seamless data storage and retrieval, ensuring efficient and accurate management of all travel-related activities. Whether it's booking vacations, managing travel itineraries, or overseeing administrative tasks, this system is designed to enhance the user experience and improve operational efficiency for travel agencies.
 
## Prerequisites
 
Before starting, ensure you have the following installed:
- **Visual Studio:** [Download the latest version](https://visualstudio.microsoft.com/)
- **.NET Framework:** Available via Visual Studio or [Microsoft's official site](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks)
- **SQL Server Management Studio (SSMS):** [Download the latest version](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
 
## Get Started
 
### Database Configuration
 
**Database Setup Instructions:**
 
1. **Create a New Server in SSMS:**
   - Open **SQL Server Management Studio (SSMS)**.
   - Connect to your server using the appropriate credentials.
   - To create a new database, right-click on "Databases" in the Object Explorer pane, select "New Database...", enter `TravelBro`, and click "OK."
 
2. **Access Database Files:**
   - Navigate to the "database" section in this repository.
   - Download the SQL script files for each table.
 
3. **Execute SQL Scripts:**
   - Open a new query window in SSMS.
   - Copy and paste or directly open the SQL scripts from the downloaded files into the query window.

** SQL Query:**
 
#### user_prepack_id Table
```bash
CREATE TABLE [dbo].[user_prepack_id](
      NOT NULL,
      NOT NULL
) ON [PRIMARY]
GO
```
#### user_info Table
```bash
CREATE TABLE [dbo].[user_info](
      NOT NULL,
      NULL,
      NOT NULL,
      NULL,
      NULL,
      NULL,
      NOT NULL,
    CONSTRAINT [PK_user_info] PRIMARY KEY CLUSTERED ([u_id] ASC)
) ON [PRIMARY]
GO
```
#### prepack_info Table
```bash
CREATE TABLE [dbo].[prepack_info](
      NOT NULL,
      NOT NULL,
      NOT NULL,
    [pr_price] [float] NOT NULL,
    [pr_pcount] [int] NOT NULL,
      NOT NULL,
    [pr_image] [image] NULL,
      NULL,
    CONSTRAINT [PK_prepack_info] PRIMARY KEY CLUSTERED ([pr_id] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
```
#### admin_info Table
```bash
CREATE TABLE [dbo].[admin_info](
      NOT NULL,
      NOT NULL,
      NOT NULL,
    CONSTRAINT [PK_admin_info] PRIMARY KEY CLUSTERED ([ad_id] ASC)
) ON [PRIMARY]
GO
```
#### agency_info Table
```bash
CREATE TABLE [dbo].[agency_info](
      NOT NULL,
      NOT NULL,
      NULL,
      NULL,
      NULL,
      NOT NULL,
      NULL,
    CONSTRAINT [PK_agency_info] PRIMARY KEY CLUSTERED ([ag_id] ASC)
) ON [PRIMARY]
GO
```
#### custompack_info Table
```bash
CREATE TABLE [dbo].[custompack_info](
      NOT NULL,
      NOT NULL,
      NOT NULL,
    [c_pcount] [float] NOT NULL,
      NOT NULL,
    CONSTRAINT [PK_custompack_info] PRIMARY KEY CLUSTERED ([c_id] ASC)
) ON [PRIMARY]
GO
```
#### payment_info Table
```bash
CREATE TABLE [dbo].[payment_info](
      NOT NULL,
      NOT NULL,
    [pay_amnt] [float] NOT NULL,
      NOT NULL,
    CONSTRAINT [PK_payment_info] PRIMARY KEY CLUSTERED ([pay_id] ASC)
) ON [PRIMARY]
GO
```
#### prepack_agency_id Table
```bash
CREATE TABLE [dbo].[prepack_agency_id](
      NOT NULL,
      NOT NULL
) ON [PRIMARY]
GO
```
#### user_custompack_id Table
```bash
CREATE TABLE [dbo].[user_custompack_id](
      NOT NULL,
      NOT NULL
) ON [PRIMARY]
GO
```
#### user_payment_id Table
```bash
CREATE TABLE [dbo].[user_payment_id](
      NOT NULL,
      NOT NULL
) ON [PRIMARY]
GO
```
#### CustomerPrepackInfoView Table
```bash
CREATE VIEW [dbo].[CustomerPrepackInfoView] AS
SELECT 
    uinfo.u_id, 
    uinfo.u_name, 
    pinfo.pr_id,
    pinfo.pr_dest, 
    pinfo.pr_hotel, 
    pinfo.pr_price, 
   
```

 
5. **Configure Connection String:**
   - In the **app.config** or **web.config** file of your WinForms application, update the connection string with your SQL Server details:
 
   ```xml
   <connectionStrings>
     <add name="TrabelBroDB"
          connectionString="Data Source=LAPTOP-FS3OVK5Q\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False"
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
 
   - Replace `YOUR_SERVER_NAME` with the name of your SQL Server instance (for example, `localhost` or `.\SQLEXPRESS`).
 
 
Make sure the connection string is set up properly to ensure smooth communication between your application and the database.
 

## Application's Screenshots

### Home Page
![Screenshot 2024-09-25 112052](https://github.com/user-attachments/assets/9fc8ae98-1d74-4c7c-a20e-6695abbebd6a)

 
### Admin Page
![Screenshot 2024-09-25 112103](https://github.com/user-attachments/assets/3dcaaf81-381d-4ee7-a6a5-b4fac76ad8de)

 
### Admin Dashboard Page
![Screenshot 2024-09-25 112131](https://github.com/user-attachments/assets/de7fabc4-0d96-4f95-ac5d-e98e6f90e23d)


 
### Agency_Login Page
![Screenshot 2024-09-25 112143](https://github.com/user-attachments/assets/17098868-12ec-477c-8828-415d3ae8594e)

 
### Agency_sign_up Page
![Screenshot 2024-09-25 112157](https://github.com/user-attachments/assets/a9b817e2-95a4-46b8-b5b2-697cc8aa0725)

 
### Agency_Home Page
![Screenshot 2024-09-25 112252](https://github.com/user-attachments/assets/a9b803e5-d79d-4275-a232-5d4cd8b22916)

 
### Customer_View Page
![Screenshot 2024-09-25 112307](https://github.com/user-attachments/assets/6a364e68-f725-4fb4-8a48-7419d6774e3e)

 
### Destination User control
![Screenshot 2024-09-25 112716](https://github.com/user-attachments/assets/f53795dc-4a44-4785-9631-bad8098396bb)

 
### User_Login Page
![Screenshot 2024-09-25 112329](https://github.com/user-attachments/assets/a6780362-d68e-4b46-a182-17cc399c54db)



### User_Sign_up Page
![Screenshot 2024-09-25 112542](https://github.com/user-attachments/assets/7bc7c0b7-0580-481c-b12d-8ac14574b6b9)

###  forget_Passwoard Page
![Screenshot 2024-09-25 112816](https://github.com/user-attachments/assets/b7490ea2-be2d-44c9-802b-408b01f5987d)

 
### User_Home Page
![Screenshot 2024-09-25 112343](https://github.com/user-attachments/assets/60f2eeab-f4fe-4fa3-b962-3bb66e88b81d)

### About_us Page
![Screenshot 2024-09-25 112528](https://github.com/user-attachments/assets/7e82fb7a-30bf-4b80-a2ca-5051a2fcc665)


 
### Customer_Prepack Page
![Screenshot 2024-09-25 112354](https://github.com/user-attachments/assets/12032061-959e-4aae-9d10-ee1ac5785ac6)

 
### Destination_Book user control
![Screenshot 2024-09-25 112659](https://github.com/user-attachments/assets/76ba2cec-7894-4a87-8470-fb61677772e2)

 
 
### CustomPack Page
![Screenshot 2024-09-25 112418](https://github.com/user-attachments/assets/56a6b34e-26e0-4dac-8b04-a7d0539b7ba0)

 
### Payment Page
![Screenshot 2024-09-25 112439](https://github.com/user-attachments/assets/d13a1b9d-4484-4038-bc20-80d70e82bf06)

 
### Invoice Page
![Screenshot 2024-09-25 112504](https://github.com/user-attachments/assets/412797b3-8899-4d6f-a7e5-a9020347b6e5)

 
  
## Features
 
### User Features
 
- **Sign Up & Login / Logout:**
   - Users can create a new account, log in, log out.
   - Password management includes change and recovery options like "Forgot Password."
 
- **Travel Package Browsing:**
   - Users can browse available travel packages and directly proceed to booking.
   - After selecting a package, users can review the itinerary, details, and pricing before confirming the booking.
 
- **Booking and Payment:**
   - Multiple payment methods are available, including bKash, Nagad, Rocket, and Banking.
   - On booking confirmation, users can see the total bill and complete their payment.
  

 
 
### Admin Features
 

 - **Travel Package Management:**
   - Admins can view and search customer, agency, package information and se overview of the whole system.
  
## Technology Used
 
- **[C#](https://learn.microsoft.com/en-us/dotnet/csharp/):** A versatile programming language for the .NET platform, used for developing a wide range of applications.
- **[.NET Framework](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet-framework):** A comprehensive developer platform for building various types of applications across different operating systems.
 

## Lessons Learned
 
1. **Authentication and Role Management:**
   - Implementing different user roles (Customer and Admin) provided valuable insights into managing secure access to specific features, ensuring that each user type can only access the relevant parts of the system.
 
2. **Booking and Cart System Development:**
   - Building a cart and booking system taught the importance of session management, ensuring that user actions, like adding travel packages to the cart, persist seamlessly.
   - Handling multiple payment methods such as **bKash**, **Nagad**, **Rocket**, and Banking provided practical experience in integrating diverse payment gateways.

3. **Booking History and Reporting**
   - Developing the booking history feature highlighted the need for efficient data retrieval and presentation. Ensuring that users can easily access their past bookings and details is crucial for a positive user experience.
4. **Database Design:**
   - Designing and managing the database schema for travel packages, employees, and salaries emphasized the importance of normalization and efficient data organization for scalability and performance.

5. **User Interface and Experience:**
   - Implementing user interfaces and navigation components, such as drop-down menus and user-friendly dashboards, underscored the need for a clean and intuitive design to improve user interaction and satisfaction.
6. **Error Handling and Security:**
   - Encountering and resolving exceptions, such as connection issues and authentication problems, reinforced the significance of robust error handling and security measures in travel agency system development.

## FAQ

**Q: How can I add more travel packages to the system?**
- A:  To add travel packages, use the package management interface available in the Admin panel. Admins can input package details, including name, price, destination, and itinerary, directly into the system.

**Q: What should I do if I forget my password?**
- A: Use the "Forgot Password" feature on the login page to reset your password. Follow the instructions sent to your registered email address.

**Q: How do I change my email or contact information?**
- A: Log in to your account and navigate to the profile settings. You can update your email and contact information from there.


## Acknowledgements

Special thanks to:
- **Microsoft** for their development tools and platform.
- **Stack Overflow** and **GitHub** communities for their valuable support and resources.
- And Also <br>
🎓 **Dr. Md. Iftekharul Mobin**  <br>
🎓 Assistant Professor, Department of Computer Science, AIUB <br>
Your guidance has been instrumental in the development of this project.
