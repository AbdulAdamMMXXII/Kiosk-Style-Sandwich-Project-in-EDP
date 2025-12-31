# Mia’s Sandwich Shop – Kiosk Ordering System

## Overview
Mia’s Sandwich Shop is a prototype kiosk-style ordering and payment system designed for a small local sandwich business. The system is developed using **C# and Windows Forms** in **Visual Studio**, following **Event-Driven Programming (EDP)** principles. It provides a fast, intuitive, and user-friendly way for customers and staff to place and manage orders.

This project was created to meet Mia’s software requirements for a modern self-service kiosk solution.

---

## Features
- Graphical User Interface (GUI) using Windows Forms  
- Browse products by category (Sandwiches, Drinks, Salads, Desserts)  
- Item display with image, description, and price  
- Quantity selection using numeric controls  
- Shopping cart with add and remove functionality  
- Automatic total price calculation  
- Checkout page with order summary and payment overview  
- Backward navigation to modify orders before payment  
- Receipt generation with date, time, items, total paid, and reference number  
- Printable receipt and “Buy Again” option  

---

## Application Structure
The system consists of **four main forms**:

1. **Home Page**  
   Welcomes the user and introduces available products.

2. **Kiosk / Shopping Page**  
   Contains tab controls for product categories. Users can select items, choose quantities, add or remove items from the cart, and view their current order.

3. **Checkout Page**  
   Displays selected items, total cost, and payment details. Includes a back button to allow users to return to the shopping page and edit their order.

4. **Receipt Page**  
   Shows a full order summary and provides options to print the receipt or start a new order.

---

## Technologies Used
- C#  
- Windows Forms  
- Visual Studio IDE  
- Event-Driven Programming principles  

---

## Event-Driven Programming Concepts Applied
- Event handlers for buttons, tabs, and controls  
- User input events (clicks, selections, quantity changes)  
- Service-oriented processing (cart management and checkout)  
- Time-driven events (date and time on receipt)  
- Predefined and custom functions for modular design  

---

## How to Run
1. Open the solution file in **Visual Studio**  
2. Build the project  
3. Run the application using **Start (F5)**  

---

## Purpose
This prototype demonstrates how event-driven programming can be used to design an effective kiosk system. It fulfils Mia’s requirements by providing a quick, simple, and reliable ordering experience for both customers and staff.

---

## Author
Developed by Abdulrazig Adam as part of an **Event-Driven Programming / Software Development module**.
