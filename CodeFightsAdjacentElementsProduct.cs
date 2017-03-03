int adjacentElementsProduct(int[] inputArray) {

int greatestAdjacentProduct = 0;
int currentNumber = 1;

while (currentNumber < inputArray.Length)
{
    if ((inputArray[currentNumber] * inputArray[currentNumber - 1]) > greatestAdjacentProduct)
    {
        greatestAdjacentProduct = (inputArray[currentNumber] * inputArray[currentNumber - 1]);
    } 
    else if ((currentNumber < (inputArray.Length - 1)) && (inputArray[currentNumber] * inputArray[currentNumber + 1]) > greatestAdjacentProduct)
    {
        greatestAdjacentProduct = (inputArray[currentNumber] * inputArray[currentNumber + 1]);
    }
    currentNumber++;
}
return greatestAdjacentProduct;
}


static void Main(string[] args)
{
    inputArray[] = int.Parse(Console.ReadLine());
    Console.WriteLine(adjacentElementsProduct(inputArray));
    Console.Readline();
}