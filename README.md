## Movie App Project

### Overview
This Movie App is built using the Model-View-Controller (MVC) architectural pattern, leveraging ASP.NET Identity for user authentication and authorization, as well as Entity Framework for database interactions and CRUD operations. The app is designed to provide a robust platform for managing and exploring a collection of movies.

### Features

- **MVC Architecture**: Ensures a clean separation of concerns, making the application modular and maintainable.
- **Entity Framework**: Facilitates seamless integration with the database, enabling Create, Read, Update, and Delete (CRUD) operations for movie records.
- **User Authentication and Authorization**: Implements ASP.NET Identity to manage user accounts, roles, and permissions.
  - **Admins**: Have full CRUD permissions, allowing them to add, update, delete, and view movies.
  - **Admin Dashboard**: There is an admin dashboard where admin can view users, edit and delete users.
  - **Users**: Can edit movie records, similar to admins, providing a collaborative environment.
  - **Non-Users**: Can only view movie information, ensuring secure and controlled access to the app's features.

### Functionality

- **Movie Management**: Admins add new movies to the database, update existing records, and delete movies that are no longer needed.
- **Search Capability**: Users can search for movies by various criteria, making it easy to find specific titles or explore the movie collection.
- **User Roles**: The app enforces role-based access control, ensuring that only authorized users can perform certain actions.
- **Data Persistence**: All movie data is stored in a database, ensuring reliable and persistent storage of information.

### User Experience

- **Interactive UI**: A user-friendly interface that makes navigation intuitive and enjoyable.
- **Security**: Robust security measures to protect user data and ensure only authorized access.

This project showcases a comprehensive use of MVC, ASP.NET Identity, and Entity Framework, providing a feature-rich platform for movie enthusiasts to manage and explore their movie collections securely.
