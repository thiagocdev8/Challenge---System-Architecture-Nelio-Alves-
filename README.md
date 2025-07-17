# Nelio Alves Challenge 
# System Architecture

# 🛒 Order Summary Challenge

## 📋 Description

This challenge consists of building a simple program that reads the data of an order containing **N items** (where **N** is specified by the user), and then displays a summary of the order.

The summary includes details such as the order moment (using the system time), item details, and totals — following the structure shown in the example output.

---

## ✅ Requirements

1. Prompt the user to enter **client data**:
   - Name
   - Email
   - Birth date (`DD/MM/YYYY`)
2. Prompt for basic **order data**:
   - Order status (e.g. `PendingPayment`, `Processing`, `Shipped`, etc.)
3. Ask for the number of items in the order (**N**).
4. For each item, collect:
   - Product name
   - Product price
   - Quantity
5. Capture the current system time using:
   ```csharp
   DateTime.Now


🧪 Example Input & Output
🧾 Example Input (user entries shown in parentheses):
Enter client data:
Name: (Alex Green)
Email: (alex@gmail.com)
Birth date (DD/MM/YYYY): (15/03/1985)

Enter order data:
Status: (Processing)

How many items to this order? (2)

Enter #1 item data:
Product name: (TV)
Product price: (1000.00)
Quantity: (1)

Enter #2 item data:
Product name: (Mouse)
Product price: (40.00)
Quantity: (2)

ORDER SUMMARY: //output at the end 
Order moment: 20/04/2018 11:25:09
Order status: Processing
Client: Alex Green (15/03/1985) - alex@gmail.com
Order items:
TV, $1000.00, Quantity: 1, Subtotal: $1000.00
Mouse, $40.00, Quantity: 2, Subtotal: $80.00
Total price: $1080.00


