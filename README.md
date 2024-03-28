# Lunavex.SmartEnum NuGet Package

## Overview
The `Lunavex.SmartEnum` package offers a powerful solution for managing enumerations in .NET applications. This library provides an easy way to define and use strongly-typed enumerations, improving code readability and maintainability. It simplifies enumeration handling and allows developers to work more efficiently and safely with enumerated values in their projects. 

## Features
- **Strongly-Typed Enumerations**: Define and utilize strongly-typed enumerations for type safety.
- **Configurable Page Size**: Provides a customizable and extensible structure to accommodate specific needs.
- **Extensibility**: Offers a straightforward pagination logic, abstracting away the complexity of calculating page numbers and total pages, ensuring ease of use.

## Getting Started

### Installation
To integrate `Lunavex.SmartEnum` into your project, install it via the NuGet package manager:

```plaintext
Install-Package Lunavex.SmartEnum
```

Or through the .NET CLI:
```plaintext
dotnet add package Lunavex.SmartEnum
```

## Usage
- **CreditCard is an example class created to represent different types of credit cards.** It can inherit from either Enumeration<int, CreditCard> or Enumeration<string, CreditCard> 
classes to manage credit card types with integer or string values, respectively.

```csharp
public sealed class CreditCard : Enumeration<int, CreditCard>
{
    public static readonly CreditCard Standard = new(1, nameof(Standard));
    public static readonly CreditCard Platinum = new(2, nameof(Platinum));
    public static readonly CreditCard Premium = new(3, nameof(Premium));
    public CreditCard(int value, string name) : base(value, name)
    {
    }
}
```
```csharp
public sealed class CreditCard : Enumeration<string, CreditCard>
{
    public static readonly CreditCard Standard = new("Standard", nameof(Standard));
    public static readonly CreditCard Platinum = new("Platinum", nameof(Platinum));
    public static readonly CreditCard Premium = new("Premium", nameof(Premium));
    public CreditCard(string value, string name) : base(value, name)
    {
    }
}
```

## Contributing
We welcome contributions! Feel free to open an issue or submit a pull request on our GitHub repository for any suggestions or improvements.

## License
`Lunavex.SmartEnum` is licensed under the MIT License. See the LICENSE file in the source repository for full details.

```rust
This Markdown formatted README provides a comprehensive guide on how to use the `Lunavex.SmartEnum` package, suitable for your project's repository or documentation.

```