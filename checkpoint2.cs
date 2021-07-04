float Sum(float a, float b)
{
    return a+b;
}

float Prod(float a, float b)
 {
     return a*b;
 }

float Div(float a, float b)
{
    float x = a/b;
    
    if (x == 0)
    {
    Debug.log("error!");
    }

    else
    {
      return a/b;  
    }
}