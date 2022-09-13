int distans = 10000;
int first_Friend_Speed = 1;
int second_Friend_Speed = 2;
int dog_Speed = 5;
int friend = 2;
int count = 0;
int time = 0;

while(distans > 10)
{
    if(friend == 1)
    {
        time = distans / (first_Friend_Speed + dog_Speed);
        friend = 2;
    }

    else
    {
        time = distans / (second_Friend_Speed + dog_Speed);
        friend = 1;
    }

    distans = distans - (first_Friend_Speed + second_Friend_Speed) * time;
    count++;
    
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз!");
