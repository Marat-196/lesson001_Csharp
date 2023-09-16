int count = 0;
int distance = 10000;
int firstfriendspeed = 1;
int secondfriendspeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 1;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstfriendspeed + dogSpeed);
        friend = 1;
    }
    else
    {
        time = distance / (secondfriendspeed + dogSpeed);
        friend = 2;
    }
    distance = distance - (firstfriendspeed + secondfriendspeed) * time;
    count += 1;

}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");
