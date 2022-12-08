using System;using System.IO.Pipes;
using System.Numerics;

namespace Deliverable2
{
    class Program
    { 
        static void Main(string[] args) 
        {
            Console.WriteLine("After a long drive you arrive at an old truck stop hoping to find some food to replenish your famished body.");
            Console.WriteLine();
            Console.WriteLine("Upon entering into what you believed to be a Kwik Trip your nostrils are assualted by the scent of sea salt and limes.\nYour eyes are immediately drawn to the center of the room where you see a massive aquarium that pales in comparision to the great white shark that swims within.You stare in awe before being interrupted by a man whose pirate costume seems a bit to accurate.");
            Console.WriteLine();
            Console.WriteLine("Ahoy Matey! Welcome 't the Leaky Galeon. Where the rum be free 'n the grub be salted 'n pickled!\nHow many will be joinin us tonight?");
            Console.WriteLine();
            Console.Write("You look to your left and right in an attempt to determine how many people you came with before squeaking out.");
            
                double people = int.Parse(Console.ReadLine());
                double meal = 9.99;
                double watercost = 5.00;
                double rum = 0;
                double water = 0;

            if (people <= 6 && people > 1){
                Console.WriteLine();
                Console.WriteLine(people + " Mates! Right this way!");
                Console.WriteLine();
                Console.WriteLine("The smelly pirate takes you to a cramped table that you imagine has never been properly sanitized.\n" + people + " rounds of rum! he shouts.\nThen noticing your party hesitate he eyes the plank longingly.\nSalt water also be available, but it be $5.00 a pour.");

                for (int person = 1; person <= people; person++){
                    Console.WriteLine();
                    Console.WriteLine("What will it be Matey " + person + " rum or saltwater?");

                    string drink = (Console.ReadLine().ToLower());
                    
                    if (drink == "rum"){
                        rum++;
                        Console.WriteLine();
                        Console.WriteLine("Rum!!!! A great choice.");
                    }else if (drink == "saltwater" || drink == "salt water"){
                        water++;
                        Console.WriteLine();
                        Console.WriteLine("He glares angerly and toys with his scimitar. Salt Water it be...");
                    }else {
                        Console.WriteLine();
                        Console.WriteLine("His nostrils flare with rage! We don't serve that you scallywag! Walk the plank!\nYou watch as your mate falls into the icy water and disappears into the now red aquarium water.");
                        Console.WriteLine("I still be charging ye' crew for that scallywags food!");}
                }Console.WriteLine();
                    Console.WriteLine("So ye' be wanting " + rum + " bottles of rum and " + water + " *he stifles sickness* pours of salt water. I'll be right back!");
                if (rum == people) {
                    Console.WriteLine();
                    Console.WriteLine("You and your mates awaken on a sandy shore of a deserted island. You find that you have an odd arrangement of peg legs and hooked hands and that you are missing $" +(meal*people+watercost*water));
                } else if (water == people){
                    Console.WriteLine();
                    Console.WriteLine("As the pirate returns he tells you, Ye total would be " + (meal * people + watercost * water) + "but instead ye' shall walk the plank, Ye scallywags!\n You are quickly ushered to the aquarium in the center of the room. The water is quite frigid and you find yourself quite disappointed that you don't go numb fast enough, as you feel big bertha's teeth sink into you.");
                } else{
                    Console.WriteLine();
                    Console.WriteLine("You and your mates awaken on a sandy shore of a deserted island. You find that you have an odd arrangement of peg legs and hooked hands and that you are missing $" + (meal * people + watercost * water));
                }
            
            } else if (people == 1){
                Console.WriteLine();
                Console.WriteLine("Just you me hearty! Right this way!");
                Console.WriteLine();
                Console.Write("The smelly pirate takes you to a cramped table that you imagine has never been properly sanitized.\n" + people + " round of rum! he shouts.\nThen noticing you hesitate he eyes the plank longingly.\nSalt water also be available, but it be $5.00 a pour. [Rum/Saltwater]");

                string drink=(Console.ReadLine().ToLower());

                if (drink == "rum"){
                    rum++;
                    Console.WriteLine();
                    Console.WriteLine("A great choice me matey!\n You awaken the next day on the sandy beaches of a deserted island with a peg leg and missing $9.99 from your wallet.");
                }
                else if (drink == "saltwater" || drink == "salt water"){
                    water++;
                    Console.WriteLine();
                    Console.WriteLine(drink + "!!! You dirty scallywag! That would be $14.99 but instead walk the plank!\n You are quickly ushered to the aquarium in the center of the room. The water is quite frigid and you find yourself quite disappointed that you don't go numb fast enough, as you feel big bertha's teeth sink into you.");
                }else{
                    Console.WriteLine();
                    Console.WriteLine("His nostrils flare with rage! We don't serve that you scallywag! Walk the plank!\nYou are quickly ushered to the aquarium in the center of the room. The water is quite frigid and you find yourself quite disappointed that you don't go numb fast enough, as you feel big bertha's teeth sink into you.");
                }

            } else if (people == 0){
                Console.WriteLine("The pirate removes his second eye patch. Mayhaps I should cease drinkin? I be hearin things.");
            
            } else {
                Console.WriteLine();
                Console.WriteLine(people + "!!! Walk the plank!!!");
                Console.WriteLine();
                Console.WriteLine("You and your 'mateys' are quickly ushered to the aquarium in the center of the room. The water is quite frigid and you find yourself quite disappointed that you don't go numb fast enough, as you feel big bertha's teeth sink into you.");
            }
            Console.WriteLine("Total Meals "+ people +"\nTotal Rum "+ rum +"\nTotal Salt Water "+ water + "\nTotal Cost" + (meal * people + watercost * water));
                        }
    }
}