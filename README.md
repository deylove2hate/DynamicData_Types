# 🚀 DynamicData - Modern ASP.NET Core Web Application

[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-6.0%2F7.0-512BD4?style=flat&logo=.net)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-10%2F11-239120?style=flat&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

A modern, feature-rich ASP.NET Core web application demonstrating advanced dynamic data handling, configuration-driven form generation, and interactive data visualization with a stunning, animated UI.

## ✨ Features

### 🎨 Modern UI/UX Design
- **Animated Gradient Background** - Smooth, continuously shifting gradient animations
- **Glassmorphism Effects** - Modern backdrop blur and translucent card designs
- **Smooth Transitions** - Fluid animations on hover, scroll, and interaction
- **Responsive Layout** - Fully responsive design that works beautifully on all devices
- **Custom CSS Variables** - Consistent theming throughout the application

### ⚙️ Dynamic Configuration Forms
- **Data-Driven Form Generation** - Forms generated dynamically from configuration data
- **Multiple Input Types** - Support for text, email, number, and dropdown fields
- **Real-Time Validation** - Client-side validation with visual feedback
- **Flexible Layout System** - Grid-based responsive form layouts
- **Required Field Indicators** - Clear visual indicators for mandatory fields

### 📊 Interactive Data Tables
- **Dynamic Data Binding** - Tables populated from DataTable objects
- **Multiple Data Sources** - Switch between People and Products datasets
- **Column Humanization** - Automatic formatting of column names
- **Responsive Tables** - Mobile-friendly table layouts with custom scrollbars
- **Empty State Handling** - Elegant no-data displays

### 🔍 Reflection Examples
- **Runtime Type Inspection** - Demonstrate .NET reflection capabilities
- **Property Enumeration** - Display object properties dynamically
- **Type Information** - Show detailed type metadata

### 🌐 DOM Manipulation
- **Client-Side Interactivity** - JavaScript-based DOM manipulation examples
- **Real-Time Updates** - Dynamic content updates without page refresh

## 🛠️ Technologies Used

**Backend:**
- ASP.NET Core 6/7 (Razor Pages)
- C# 10/11
- Entity Framework Core
- ADO.NET & System.Data

**Frontend:**
- Bootstrap 5
- Custom CSS3 with animations
- Vanilla JavaScript
- Google Fonts (Inter)

**Libraries:**
- [Humanizer](https://github.com/Humanizr/Humanizer) - Text formatting
- jQuery - DOM manipulation

## 🚀 Getting Started

### Prerequisites
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) or later
- Visual Studio 2022 / VS Code / JetBrains Rider
- SQL Server (optional, uses in-memory database by default)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/GawdSizwe/DynamicData_Types.git
   cd DynamicData_Types
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   cd DynamicData.Web.Config.After
   dotnet run
   ```

5. **Open in browser**
   ```
   https://localhost:5001
   ```

## 📂 Project Structure

```
DynamicData.Web.Config.After/
├── Pages/
│   ├── Shared/
│   │   └── _Layout.cshtml          # Main layout with modern styling
│   ├── Index.cshtml                # Landing page with hero section
│   ├── ConfigExample.cshtml        # Dynamic form configuration demo
│   ├── DtExample.cshtml            # DataTable visualization
│   ├── ReflectionExample.cshtml    # .NET Reflection demo
│   └── DomExample.cshtml           # DOM manipulation examples
├── Data/
│   ├── ApplicationDbContext.cs     # EF Core DbContext
│   └── InitializeDatabase.cs       # Database initialization
├── Models/
│   ├── Person.cs                   # Person entity model
│   └── Product.cs                  # Product entity model
├── Service/
│   ├── IDataTableDataService.cs    # DataTable service interface
│   └── DataTableDataService.cs     # DataTable service implementation
└── wwwroot/
    ├── css/
    │   └── site.css                # Global styles with modern design
    └── js/
        └── site.js                 # Custom JavaScript
```

## 🎯 Key Features Demonstrated

### Dynamic Form Generation
Forms are created dynamically based on configuration data:
```csharp
Questions.Add(new FormField
{
    FieldName = "LastName",
    FieldLabel = "Last Name",
    Row = 1,
    Column = 1,
    Span = 4,
    IsRequired = true,
    FieldType = FieldTypes.Text
});
```

### DataTable Visualization
Working with ADO.NET DataTable objects:
- Dynamic column generation
- Type-aware data formatting
- Humanized column names
- Interactive data switching between entities

### Reflection & Metaprogramming
Demonstrates .NET reflection capabilities:
- Type inspection at runtime
- Property enumeration
- Dynamic object manipulation

## 🎨 Design Features

- **Color Palette**: Purple gradient theme (#667eea to #764ba2)
- **Typography**: Inter font family for modern readability
- **Animations**: Smooth hover effects, page transitions, and loading states
- **Shadows**: Layered shadow system for depth
- **Cards**: Glassmorphism-style cards with blur effects

## 📱 Responsive Design

Fully responsive with breakpoints for:
- 📱 Mobile devices (< 768px)
- 📱 Tablets (768px - 1024px)
- 💻 Desktop (> 1024px)

## 🔒 Security Features

- ✅ Built-in CSRF protection
- ✅ Input validation
- ✅ XSS prevention
- ✅ Secure configuration management

## 📈 Performance

- Efficient data binding
- Minimal DOM manipulation
- CSS-based animations (GPU accelerated)
- Asset bundling and minification

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👨‍💻 Author

**Sizwe Mazibuko**
- GitHub: [@GawdSizwe](https://github.com/GawdSizwe)
- Repository: [DynamicData_Types](https://github.com/GawdSizwe/DynamicData_Types)

## 🙏 Acknowledgments

- ASP.NET Core documentation and community
- Bootstrap team for the excellent framework
- Humanizer library contributors
- Modern web design inspiration

## 📸 Screenshots

### Landing Page
Modern hero section with animated gradients and feature cards

### Dynamic Configuration
Configuration-driven form generation with validation

### Data Tables
Interactive data tables with multiple data sources

### Reflection Demo
Runtime type inspection and property enumeration

---

⭐ **Star this repository if you find it helpful!**

Built with ❤️ using ASP.NET Core and modern web technologies.

© 2026 Sizwe Mazibuko. All rights reserved.

