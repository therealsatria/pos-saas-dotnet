# pos-saas-dotnet

```
erDiagram
    %% 1. Tenant & Subscription Management
    tenants {
        uuid id PK
        string name
        string subdomain
        uuid plan_id FK
    }

    subscriptions {
        uuid id PK
        uuid tenant_id FK
        uuid plan_id FK
        string status
        timestamp start_date
        timestamp end_date
    }

    subscription_plans {
        uuid id PK
        string name
        decimal price
        json features
    }

    %% 2. User & RBAC
    users {
        uuid id PK
        uuid tenant_id FK
        string email
        string password_hash
        timestamp created_at
    }

    roles {
        uuid id PK
        uuid tenant_id FK
        string name
        json permissions
    }

    user_roles {
        uuid user_id PK, FK
        uuid role_id PK, FK
    }

    permissions {
        uuid id PK
        string name
        string description
    }

    %% 3. Product & Inventory
    products {
        uuid id PK
        uuid tenant_id FK
        string sku
        string name
        decimal price
    }

    categories {
        uuid id PK
        uuid tenant_id FK
        string name
        uuid parent_id FK "Hierarchical category"
    }

    product_categories {
        uuid product_id PK, FK
        uuid category_id PK, FK
    }

    inventory {
        uuid id PK
        uuid tenant_id FK
        uuid product_id FK
        integer stock
        string location
    }

    inventory_logs {
        uuid id PK
        uuid inventory_id FK
        integer quantity
        string action_type "restock/sale/adjustment"
        timestamp created_at
    }

    suppliers {
        uuid id PK
        uuid tenant_id FK
        string name
        string contact
    }

    %% 4. Sales & Payment
    sales {
        uuid id PK
        uuid tenant_id FK
        uuid user_id FK
        decimal total_amount
        timestamp created_at
    }

    sale_items {
        uuid id PK
        uuid sale_id FK
        uuid product_id FK
        integer quantity
        decimal unit_price
    }

    payments {
        uuid id PK
        uuid sale_id FK
        string method "cash/card/ewallet"
        decimal amount
        string transaction_id
    }

    taxes {
        uuid id PK
        uuid tenant_id FK
        string name
        decimal rate
    }

    discounts {
        uuid id PK
        uuid tenant_id FK
        string code
        decimal value
        string type "percentage/fixed"
    }

    %% 5. Customer & Loyalty
    customers {
        uuid id PK
        uuid tenant_id FK
        string name
        string phone
        string email
    }

    loyalty_programs {
        uuid id PK
        uuid tenant_id FK
        string name
        decimal points_rate "Points per currency"
    }

    loyalty_points {
        uuid id PK
        uuid customer_id FK
        integer balance
    }

    %% 6. Reporting & Logs
    audit_logs {
        uuid id PK
        uuid tenant_id FK
        uuid user_id FK
        string action
        timestamp created_at
    }

    reports {
        uuid id PK
        uuid tenant_id FK
        string type
        json data
    }

    %% 7. Integrations & Settings
    payment_gateways {
        uuid id PK
        uuid tenant_id FK
        string type "stripe/midtrans"
        string api_key_encrypted
    }

    tenant_settings {
        uuid id PK
        uuid tenant_id FK
        string setting_key
        string setting_value
    }

    %% Relationships
    tenants ||--o{ subscriptions : "has"
    subscription_plans ||--o{ subscriptions : "offers"
    tenants ||--o{ users : "has"
    tenants ||--o{ roles : "defines"
    users }|--|| roles : "assigned_via"
    roles }|--|{ permissions : "has"

    tenants ||--o{ products : "owns"
    products }|--|{ categories : "categorized_via"
    categories }|--|| categories : "child_of"
    products ||--o{ inventory : "tracks"
    inventory ||--o{ inventory_logs : "logs"
    suppliers }o--|| products : "supplies"

    tenants ||--o{ sales : "has"
    sales ||--o{ sale_items : "contains"
    sale_items }o--|| products : "references"
    sales }|--|| payments : "processed_via"
    sales }|--|| taxes : "applies"
    sales }|--|| discounts : "applies"

    tenants ||--o{ customers : "has"
    customers }|--|| loyalty_points : "earns"
    loyalty_programs ||--o{ loyalty_points : "governs"

    tenants ||--o{ audit_logs : "logs"
    tenants ||--o{ reports : "generates"
    tenants ||--o{ payment_gateways : "configures"
    tenants ||--o{ tenant_settings : "configures"