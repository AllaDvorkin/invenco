
Dear Developer,

We are delighted to introduce you to `promotion-engine`, our innovative API that specializes in handling product discounts. It recalculates the prices of products based on specific discount rules, all in line with our aim of creating a seamless and dependable discount management environment.

In its current implementation, `promotion-engine` integrates with two third-party providers through network calls to fetch the applicable product discounts. Please find the essential guidelines below to ensure smooth operation of the `promotion-engine`:

1. **Final Discount Calculation**:
   - **During Regular Hours**: The final discount for a product will be the largest discount from all participating providers.
   - **During Night Hours**: The discount for the product will be the total sum of all calculated discounts.
2. **Error Handling**: If fetching a discount for any items in a transaction fails, we won't apply any discount from that provider for that specific transaction.
3. **Future Support**: We may accommodate multiple different providers in the future.
4. **Provider-Specific Discounts**: Each provider supports discounts for a specific list of items. This list remains constant during the entire business day and may change at midnight.
5. **Performance Requirement**: The service must be highly efficient.

In your role as a  developer candidate, we are eager for you to demonstrate your expertise in the following areas:

1. **Accuracy**: Ensure that the code aligns with the business requirements.
2. **Efficiency**: Optimize the code for fast execution.
3. **Production Readiness**: Include any missing components required for a smooth release.
4. **Extensibility**: Prepare for seamless integration with additional discount providers in the future.

We wish you success in undertaking these tasks and are confident that your efforts will contribute to making `promotion-engine` a reliable and high-performing API.

Should you have any questions or require further clarification about the business requirements, please do not hesitate to contact us.

Thank you for your dedication, and we look forward to seeing your accomplishments.

Best regards,

The PPX Team
