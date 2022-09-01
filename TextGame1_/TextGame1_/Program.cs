Random generator = new Random();
string pText = "";
bool healthPotion = false;
int pHealth = 100;
int mHealth = 50;
int playerD = 10;
int monsterD = 1;
int pMiss = -1;
bool hasTakepotion = false;


Console.WriteLine("The Dark Corridor Stands Before You");
Console.WriteLine("But The Monster That Plagues Your Village Is Ahead");
Console.WriteLine("You Have To Keep Moving");
Console.WriteLine("Type To Move");


start();
void start(){
while (pText != "forward" && pText != "right" && pText != "clear"){
    pText = Console.ReadLine();
    if (pText != "forward" && pText != "right"){
        Console.WriteLine("Try Something Diffrent");
        pText = "";
    }
    if (pText == "forward"){
    Console.WriteLine("A Monster Stands Before You");
    Console.WriteLine("You Have To Fight It, For Your Village");
    Console.WriteLine("Type To Take Your Action");
    monster();
    }

    if (pText == "right"){
    chest();
    }
    if(pText == "clear"){
        Console.Clear();
    }
}
}


void monster(){
    while(mHealth != 0){
        pMiss = -1;
        pText = "";
        pText = Console.ReadLine();
    if(pText != "run" && pText != "attack" && pText != "healthpotion" && pText != "clear"){
        Console.WriteLine("Try Something Else");
    }
        monsterD = generator.Next(20,30);
        playerD = generator.Next(5,15);
    if (pText == "attack"){
        pMiss = generator.Next(100);
    }
    if (pMiss <= 40 && pMiss >=0){
        mHealth = mHealth - playerD;
        Console.WriteLine("You Attacked The Monster");
        Console.WriteLine($"Dealing {playerD}");
        Console.WriteLine($"Monster Health {mHealth}");
    }
    else if (pMiss >= 41 && pMiss <=100){
        int monsterMiss = -1;
        monsterMiss = generator.Next(100);
        if (monsterMiss >= 50 && monsterMiss<=100){
            Console.WriteLine("You Try To Attack The Monster");
            Console.WriteLine("You Miss But Manage To Get Away Before Getting Hit Yourself");
        }
        if (monsterMiss <= 50 && monsterMiss >= 0){
            pHealth = pHealth - monsterD;
            Console.WriteLine("You Try To Attack The Monster");
            Console.WriteLine("But You Miss And The Monster Attacks You Back");
            Console.WriteLine($"The Monster Dealt {monsterD}");
            Console.WriteLine($"Your Health {pHealth}");
        }
    }
    if (mHealth <= 0){
        Console.Clear();
        Console.WriteLine("You Have Killed The Monster");
        Console.WriteLine("Your Village Is Saved!");
        Console.WriteLine("Thanks For Playing:)");
    }
    if (pHealth <= 0){
        Console.Clear();
        Console.WriteLine("Game Over");
        Console.WriteLine("You Suck XD");
    }
    if (healthPotion == true){
        if (pText == "healthpotion"){
            pHealth = 100;
            Console.WriteLine("You Used A Healthpotion");
            Console.WriteLine("Your Health Is Now Full");
        }
    }
    if (pText == "run"){
        runAway();
    }
    }
    if (pText == "clear"){
        Console.Clear();
    }
}


void runAway(){
    int rRun = 100;
    rRun = generator.Next(100);
    monsterD = generator.Next(20,30);
    if (rRun > 5){{
        Console.WriteLine("You Try To Run Away");
        Console.WriteLine("But The Monster Blocks Your Path");
        Console.WriteLine("He Hits You And You Fly Back");
        Console.WriteLine("Getting Past Him Might Take A Few Trys");
        pHealth = pHealth - monsterD;
        Console.WriteLine($"The Monster Dealt {monsterD}");
        Console.WriteLine($"Your Health {pHealth}");
    }
    if (rRun <= 10){
        Console.Clear();
        Console.WriteLine("You Ran Away");
        Console.WriteLine("Leaving Your Village To It's DOOOOOM!!!!!");
        Console.WriteLine("You Pussy");
        Console.ReadLine();
    }
}
}

void chest(){
    if(!hasTakepotion){
        Console.WriteLine("A Chest Is In Front Of You");
        Console.WriteLine("Will You Open It Or Go Back?");
        pText = "";
        pText = Console.ReadLine();
        if (pText == "open"){
            Console.WriteLine("You Found A Health Potion");
            Console.WriteLine("Type \"healthpotion\" To Use It");
            Console.WriteLine("You Went Back To The Beginning");

            healthPotion = true;
            hasTakepotion = true;
            start();
        }
        else if (pText == "back"){
            Console.WriteLine("You Went Back To The Beginning");
            pText = "";
            start();
        }
    }else{
        Console.WriteLine("Dumbass, You Have Already Explored This");
        Console.WriteLine("Did You Really Thing I Have The Will To Add More Stuff");
            pText = "";
            start();
    }
    }
    if(pText == "clear"){
        Console.Clear();
    }



Console.ReadLine();