# API Documentation

## Subscription Plans

### Create Subscription Plan

**Endpoint:** `POST /api/subscriptionplans`

**Request Body:**
```json
{
  "Name": "Premium Plan",
  "Price": 29.99,
  "Features": "[\"Unlimited Storage\",\"Premium Support\",\"Advanced Analytics\",\"Custom Branding\",\"API Access\"]"
}
```

**Notes:**
- The `Features` field is a JSON string representing an array of features included in the subscription plan.
- The JSON string will be parsed into a JsonDocument when processed by the service.

**Response:** Returns the created subscription plan with its assigned ID. 