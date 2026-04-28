# E-Commerce API Database Schema V1

## Main Tables

### Users

Stores application users.

Columns:

- Id
- FirstName
- LastName
- Email
- PasswordHash
- IsActive
- CreatedAtUtc
- UpdatedAtUtc

Relationships:

- One user can have many roles through UserRoles.
- One user can have one shopping cart.
- One user can have many orders.

---

### Roles

Stores user roles.

Examples:

- Admin
- Customer

Columns:

- Id
- Name
- CreatedAtUtc

Relationships:

- One role can belong to many users through UserRoles.

---

### UserRoles

Connects users and roles.

Columns:

- UserId
- RoleId

Relationships:

- Many-to-many relationship between Users and Roles.

---

### Categories

Stores product categories.

Examples:

- Laptops
- Phones
- Accessories

Columns:

- Id
- Name
- Description
- IsActive
- CreatedAtUtc
- UpdatedAtUtc

Relationships:

- One category can have many products.

---

### Brands

Stores product brands.

Examples:

- Apple
- Samsung
- Lenovo

Columns:

- Id
- Name
- Description
- IsActive
- CreatedAtUtc
- UpdatedAtUtc

Relationships:

- One brand can have many products.

---

### Products

Stores products for sale.

Columns:

- Id
- Name
- Description
- Price
- StockQuantity
- IsActive
- CategoryId
- BrandId
- CreatedAtUtc
- UpdatedAtUtc

Relationships:

- One product belongs to one category.
- One product belongs to one brand.
- One product can appear in many cart items.
- One product can appear in many order items.
- One product can have many inventory transactions.

---

### ShoppingCarts

Stores customer shopping carts.

Columns:

- Id
- UserId
- CreatedAtUtc
- UpdatedAtUtc

Relationships:

- One shopping cart belongs to one user.
- One shopping cart has many cart items.

---

### CartItems

Stores products inside a shopping cart.

Columns:

- Id
- ShoppingCartId
- ProductId
- Quantity
- CreatedAtUtc
- UpdatedAtUtc

Relationships:

- One cart item belongs to one shopping cart.
- One cart item belongs to one product.

---

### Orders

Stores customer orders.

Columns:

- Id
- UserId
- OrderNumber
- Status
- Subtotal
- TotalAmount
- CreatedAtUtc
- UpdatedAtUtc

Relationships:

- One order belongs to one user.
- One order has many order items.
- One order can have one payment.

---

### OrderItems

Stores products inside an order.

Columns:

- Id
- OrderId
- ProductId
- ProductName
- UnitPrice
- Quantity
- LineTotal

Relationships:

- One order item belongs to one order.
- One order item references one product.

Important:

ProductName and UnitPrice are copied at the time of order.
This protects old orders if the product name or price changes later.

---

### Payments

Stores mock payment records.

Columns:

- Id
- OrderId
- PaymentMethod
- Status
- Amount
- TransactionReference
- PaidAtUtc
- CreatedAtUtc

Relationships:

- One payment belongs to one order.

---

### InventoryTransactions

Stores inventory history.

Columns:

- Id
- ProductId
- Type
- Quantity
- Reason
- CreatedAtUtc

Relationships:

- One inventory transaction belongs to one product.

Examples of Type:

- StockIn
- StockOut
- Adjustment
