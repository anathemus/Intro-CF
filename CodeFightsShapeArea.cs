int shapeArea(int n) {
    int area = 0;
    if (n == 1)
    {
        area = 1;
    }
    else
    {
        area = 1;
        for (int i = 2; i <= n; i++)
        {
            area = area + ((i * i)-((i-2)*(i-2)));
        }   
    }
    return area;
}