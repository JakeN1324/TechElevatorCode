namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int raccoonsInWoods = 3;
            int raccoonsAtHome = 2;
            int raccoonsLeft = raccoonsInWoods - raccoonsAtHome;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            int flowersToBeesDifference = flowers - bees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int firstPigeon = 1;
            int secondPigeon = 1;
            int totalPigeons = firstPigeon + secondPigeon;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int fenceOwls = 3;
            int otherOwls = 2;
            int totalOwls = fenceOwls + otherOwls;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int beaversAtHome = 2;
            int beaversSwimming = 1;
            int beaversStillWorking = beaversAtHome - beaversSwimming;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int treeToucans = 2;
            int newToucans = 1;
            int totalToucans = treeToucans + newToucans;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrels = 4;
            int nuts = 2;
            int squirrelsNutsDiff = squirrels - nuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quarter = (decimal)0.25;
            decimal dime = (decimal)0.1;
            decimal twoNickels = (decimal)0.1;
            decimal totalMoney = quarter + dime + twoNickels;
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int brierClass = 18;
            int macAdamsClass = 20;
            int flanneryClass = 17;
            int totalMuffins = brierClass + macAdamsClass + flanneryClass;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyoCost = (decimal)0.24;
            decimal whistleCost = (decimal)0.14;
            decimal totalToyCost = yoyoCost + whistleCost;
            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int largeMarsh = 8;
            int miniMarsh = 10;
            int totalMarshmallows = largeMarsh + miniMarsh;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltSnow = 29;
            int brecknockSnow = 17;
            int snowDifference = hiltSnow - brecknockSnow;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            decimal hiltMoney = 10;
            decimal toysCost = (3 + 2);
            decimal hiltMoneyLeft = hiltMoney - toysCost;
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int oldMarbleCount = 16;
            int newMarbleCount = oldMarbleCount - 7;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int megansShells = 19;
            int shellsNeeded = 25 - megansShells;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int currentBooks = 38;
            int addedBooks = 10;
            int newCurrentBooks = currentBooks + addedBooks;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int eightBeesLegs = beeLegs * 8;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal iceCreamCost = (decimal)0.99;
            decimal twoConesCost = iceCreamCost * 2;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rocksAcquired = 64;
            int totalRocksNeeded = 125;
            int rocksNeeded = totalRocksNeeded - rocksAcquired;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int marbleCount = 38;
            int remainingMarbles = marbleCount - 15;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int totalMiles = 78;
            int milesDriven = 32;
            int remainingMiles = totalMiles - milesDriven;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int amShoveling = 90;
            int pmShoveling = 45;
            int totalShoveling = amShoveling + pmShoveling;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            decimal hotDogCost = (decimal)0.50;
            decimal totalDogCost = hotDogCost * 6.0M;
            
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal pencilMoney = (decimal)0.50;
            decimal pencilCost = (decimal)0.07;
            int buyablePencils = (int)(pencilMoney / pencilCost);
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterflies - orangeButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
           
            decimal candyCost = 0.54M;
            decimal changeGiven = 1 - candyCost;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int currentTrees = 13;
            int newTreeTotal = currentTrees + 12;


            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int hoursPerDay = 24;
            int grandmaCountdown = hoursPerDay * 2;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int totalCousins = 4;
            int gumPerCousin = 5;
            int totalGum = totalCousins * gumPerCousin;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal danMoney = 3.00M;
            decimal remainingMoney = danMoney - 1M;

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int totalBoats = 5;
            int totalPeople = totalBoats * 3;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int startingLegos = 380;
            int newLegoTotal = startingLegos - 57;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int muffinsBaked = 35;
            int muffinsNeeded = 83 - muffinsBaked;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int crayonDeficit = willyCrayons - lucyCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int totalPages = 22;
            int totalStickers = stickersPerPage * totalPages;
            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int totalCupcakes = 100;
            double cupcakeDivision = (double)totalCupcakes / 8;
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */
            int totalCookies = 47;
            int leftoverCookies = totalCookies % 6;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */
            int totalCroissants = 59;
            int leftoverCroissants = totalCroissants % 8;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int oatmealCookies = 276;
            int cookiesPerTray = 12;
            int totalTraysNeeded = oatmealCookies / cookiesPerTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalPretzels = 480;
            int pretzelsPerServing = 12;
            int servingsOfPretzels = totalPretzels / pretzelsPerServing;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int totalLemonCakes = 53 - 2;
            int cakesPerBox = 3;
            int cakesGivenAway = totalLemonCakes / cakesPerBox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int totalCarrots = 74;
            int leftoverCarrots = totalCarrots % 12;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totalBears = 98;
            int bearsPerShelf = 7;
            int filledShelves = totalBears / bearsPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int totalPics = 480;
            int albumsNeeded = totalPics / 20;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalCards = 94;
            int cardsPerBox = 8;
            int boxesFilled = totalCards / cardsPerBox;
            int unfilledBoxes = totalCards % cardsPerBox;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalBooks = 210;
            int booksPerShelf = totalBooks / 10;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int croissantsBaked = 17;
            double croissantsPerGuest = (double)croissantsBaked / 7;
            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */
            double billHourlyRate = (12 * 14) / 2.15;
            double jillHourlyRate = (12 * 14) / 1.90;
            double combinedRate = billHourlyRate + jillHourlyRate;
            int totalFtOfWall = 5 * 12 * 14;
            double totalJobTime = totalFtOfWall / combinedRate;
            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace";
            string lastName = "Hopper";
            string middleInitial = "B";
            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";
            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */

            double travelledOverTotal = 537.0 / 800.0;
            double timesAHundered = travelledOverTotal * 100.0;
            int totalPercent = (int)timesAHundered;
            

        }
    }
}
