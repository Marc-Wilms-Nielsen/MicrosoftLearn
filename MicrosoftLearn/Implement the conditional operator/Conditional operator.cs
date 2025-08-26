


//The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false. 
//The conditional operator is commonly referred to as the ternary conditional operator.
//Here's the basic form:
//<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

int saleAmount1 = 10;



//if the saleAmount is greater than 1000 u get 100 discount, but if it is true that the saleAmount is less than 1000 u get 50 discount. 
Console.WriteLine($"Discount: {(saleAmount1 > 1000 ? 100 : 50)}");
