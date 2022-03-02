Module Module1
    'Adrian Declared all the variables
    Dim choice As Integer = 0
    Dim habachox As Integer = 10000

    'resources and factories
    Dim coal As Integer = 250
    Dim cmine As Integer = 0
    Dim farm As Integer = 0
    Dim food As Integer = 500
    Dim water As Integer = 1000
    Dim dam As Integer = 0
    Dim electricity As Integer = 250
    Dim powerplant As Integer = 0
    Dim power As Boolean = False

    'land
    Dim avlland As Integer = 9
    Dim uland As Integer = 1
    Dim maxland As Integer = 50


    'people
    Dim people As Integer = 50
    Dim house As Integer = 1
    Dim happiness As Integer = 50

    'menu
    Dim daycount As Integer = 0
    Dim eventcount As Integer = 0
    Dim factories As Integer = 0
    Dim country As String = ""
    Dim choice2 As String = ""

    'event
    Dim decision As Integer = 0
    Dim landcount As Integer = 0
    Dim factcount As Integer = 0
    Dim help As Boolean = False
    Dim cdecision As String = ""

    'war
    Dim war As Boolean = False
    Dim warchance As Integer = 0
    Dim cycle As Integer = 0
    Dim warlength As Integer = 0
    Dim numgen As Integer = 0
    Dim warcycle As Integer = 0
    Dim wcount1 As Integer = 0
    Dim wcount2 As Integer = 0
    Dim whap As Integer = 0
    Dim wfood As Integer = 0
    Dim wcoal As Integer = 0
    Dim wwat As Integer = 0
    Dim wpeople As Integer = 0
    Dim whaba As Integer = 0
    Dim warcheck As Boolean = False

    Sub Main()
        'Jaylyn
        Console.WriteLine("You come from a wealthy family, and have just inherited a country, from your families vast empire.")
        Console.ReadKey()
        Console.WriteLine("Welcome to NOMIX! The economix simulation where you manage your own country by, buying, selling, and controlling your country to riches. There are random events that take place, so be careful what you do.")
        Console.ReadKey()
        Console.WriteLine("First off, select your countries name!")
        country = Console.ReadLine()
        Console.Clear()
        Explain()

    End Sub

    Sub Menu()
        'factories = all factories added
        'Jaylyn
        factories = cmine + farm + dam

        If factories + powerplant + house <> uland Then
            Do Until factories + powerplant + house = uland
                If house = 0 Then
                    Randomize()
                    factcount = Rnd() * 4 + 1
                    Select Case factcount
                        Case Is = 1
                            cmine -= 1
                        Case Is = 2
                            powerplant -= 1
                        Case Is = 3
                            dam -= 1
                        Case Is = 4
                            farm -= 1
                    End Select
                End If
                house -= 1
            Loop
        End If

        'Tian
        Console.Clear()
        Console.WriteLine("Country: " & Country)
        Console.WriteLine("Day Count:" & daycount)
        Console.WriteLine("Event Count: " & eventcount)
        Console.WriteLine("Currency (Habachox): " & habachox)
        Console.WriteLine("People: " & people)
        Console.WriteLine("House(s): " & house)
        Console.WriteLine("FACTORIES(press a for more info): " & factories + powerplant)
        Console.WriteLine("Electricity: " & electricity)
        Console.WriteLine("Water: " & water)
        Console.WriteLine("Food: " & food)
        Console.WriteLine("Coal " & coal)
        Console.WriteLine("Happiness(amount):" & happiness)
        Console.WriteLine("")



        Console.WriteLine("1. Next Day")
        Console.WriteLine("2. Shop")
        Console.WriteLine("3. Sell")
        Console.WriteLine("4. Info")


        choice2 = Console.ReadLine()
        Select Case choice2
            Case Is = "1"
                daycount = daycount + 1

                If people < 1 Then
                    loss()
                End If
                If habachox < -5000 Then
                    loss()
                End If


                check()



            Case Is = "2"
                If daycount Mod 7 = 0 Then
                    Shopr()
                Else
                    Console.WriteLine("You can only buy and sell every 7 days.")
                    Console.ReadKey()
                    Console.Clear()
                    Menu()
                End If
            Case Is = "3"
                If daycount Mod 7 = 0 Then
                    sell()
                Else
                    Console.WriteLine("You can only buy and sell every 7 days.")
                    Console.ReadKey()
                    Console.Clear()
                    Menu()
                End If

            Case Is = "4"
                Explain()


            Case Is = "a"
                Console.WriteLine("Available land: " & avlland)
                Console.WriteLine("Coal mine(s): " & cmine)
                Console.WriteLine("Farm(s): " & farm)
                Console.WriteLine("Dam(s): " & dam)
                Console.WriteLine("Power Plant(s): " & powerplant)
                Console.ReadKey()
                Menu()

            Case Else
                Console.WriteLine("Please choose an option.")
                Console.ReadKey()
                Menu()
        End Select


    End Sub

    Sub sell()
        'Jaylyn
        Dim sellchoice As Integer = 0
        Console.Clear()
        Console.WriteLine("---------")
        Console.WriteLine("Shop(sell):")
        Console.WriteLine("---------")
        Console.WriteLine("Habachox is: " & habachox)
        Console.WriteLine("Available land is: " & avlland)

        Console.WriteLine("1. Land = 1000")
        Console.WriteLine("2. Coal = 4")
        Console.WriteLine("3. Coal Mine = 500")
        Console.WriteLine("4. Food = 2")
        Console.WriteLine("5. Farm = 750")
        Console.WriteLine("6. Water = 1")
        Console.WriteLine("7. Dam = 400")
        Console.WriteLine("8. Electricity = 10")
        Console.WriteLine("9. Power Plant = 1500")
        Console.WriteLine("10. House = 100")
        Console.WriteLine("11. Exit")
        choice = Console.ReadLine()

        Select Case choice
            Case Is = 1
                If avlland < 1 Then
                    Console.WriteLine("You can't sell land, because all of it is being used up.")
                Else
                    Console.WriteLine("You will lose 1 land and gain 1000 Habachox.")
                    Console.WriteLine("1. Yes")
                    Console.WriteLine("2. No")
                    sellchoice = Console.ReadLine()
                    If sellchoice = 1 Then
                        avlland -= 1
                        habachox += 1000
                        Console.WriteLine("You have sold 1 piece of land for 1000 Habachox.")
                    Else
                    End If
                End If
                sell()

            Case Is = 2
                If coal < 1 Then
                    Console.WriteLine("You can't sell any coal, because you don't have any.")
                Else
                    Console.WriteLine("You will sell 1 unit of coal for 4 Habachox.")
                    Console.WriteLine("1. Yes")
                    Console.WriteLine("2. No")
                    sellchoice = Console.ReadLine()
                    If sellchoice = 1 Then
                        coal -= 1
                        habachox += 4
                        Console.WriteLine("You have sold 1 unit of coal for 4 Habachox.")
                    Else
                    End If
                End If
                sell()

            Case Is = 3
                If cmine < 1 Then
                    Console.WriteLine("You can't sell a coal mine, because you don't own any.")
                Else
                    Console.WriteLine("You will sell your coal mine for 500 Habachox.")
                    Console.WriteLine("1. Yes")
                    Console.WriteLine("2. No")
                    sellchoice = Console.ReadLine()
                    If sellchoice = 1 Then
                        cmine -= 1
                        habachox += 500
                        uland -= 1
                        avlland += 1
                        Console.WriteLine("You have sold your coal mine for 500 Habachox.")
                    Else
                    End If
                End If
                sell()

            Case Is = 4
                If food < 1 Then
                    Console.WriteLine("You can't sell any food, because you don't have any.")
                Else
                    Console.WriteLine("You will sell 1 unit of food for 2 Habachox.")
                    Console.WriteLine("1. Yes")
                    Console.WriteLine("2. No")
                    sellchoice = Console.ReadLine()
                    If sellchoice = 1 Then
                        food -= 1
                        habachox += 2
                        Console.WriteLine("You have sold 1 unit of food for 2 Habachox.")
                    Else
                    End If
                End If
                sell()

            Case Is = 5
                If farm < 1 Then
                    Console.WriteLine("You can't sell a farm, because you don't own any.")
                Else
                    Console.WriteLine("You will sell your farm for 750 Habachox.")
                    Console.WriteLine("1. Yes")
                    Console.WriteLine("2. No")
                    sellchoice = Console.ReadLine()
                    If sellchoice = 1 Then
                        farm -= 1
                        habachox += 750
                        uland -= 1
                        avlland += 1
                        Console.WriteLine("You have sold your farm for 750 Habachox.")
                    Else
                    End If
                End If
                sell()

            Case Is = 6
                sell()

            Case Is = 7
                If dam < 1 Then
                    Console.WriteLine("You can't sell a dam, because you don't own any.")
                Else
                    Console.WriteLine("You will sell your dam for 400 Habachox.")
                    Console.WriteLine("1. Yes")
                    Console.WriteLine("2. No")
                    sellchoice = Console.ReadLine()
                    If sellchoice = 1 Then
                        dam -= 1
                        habachox += 400
                        uland -= 1
                        avlland += 1
                        Console.WriteLine("You have sold your dam for 400 Habachox.")
                    Else
                    End If
                End If
                sell()

            Case Is = 8
                If electricity < 1 Then
                    Console.WriteLine("You can't sell any electricity, because you don't have any.")
                Else
                    Console.WriteLine("You will sell 1 unit of electricity for 10 Habachox.")
                    Console.WriteLine("1. Yes")
                    Console.WriteLine("2. No")
                    sellchoice = Console.ReadLine()
                    If sellchoice = 1 Then
                        electricity -= 1
                        habachox += 10
                        Console.WriteLine("You have sold 1 unit of electricity for 10 Habachox.")
                    Else
                    End If
                End If
                sell()

            Case Is = 9
                If powerplant < 1 Then
                    Console.WriteLine("You can't sell a power plant station, because you don't own any.")
                Else
                    Console.WriteLine("You will sell your power plant station for 1500 Habachox.")
                    Console.WriteLine("1. Yes")
                    Console.WriteLine("2. No")
                    sellchoice = Console.ReadLine()
                    If sellchoice = 1 Then
                        powerplant -= 1
                        habachox += 1500
                        uland -= 1
                        avlland += 1
                        Console.WriteLine("You have sold your power plant station for 1500 Habachox.")
                    Else
                    End If
                End If
                sell()

            Case Is = 10
                If house < 1 Then
                    Console.WriteLine("You can't sell a house, because you don't own any.")
                Else
                    Console.WriteLine("You will sell your house for 100 Habachox.")
                    Console.WriteLine("1. Yes")
                    Console.WriteLine("2. No")
                    sellchoice = Console.ReadLine()
                    If sellchoice = 1 Then
                        house -= 1
                        habachox += 1500
                        uland -= 1
                        avlland += 1
                        Console.WriteLine("You have sold your house for 100 Habachox.")
                    Else
                    End If
                End If
                sell()




            Case Is = 11
                Console.WriteLine("Are you sure?")
                Console.WriteLine("1. Yes")
                Console.WriteLine("2. No")

                sellchoice = Console.ReadLine()

                If sellchoice = 1 Then
                    Menu()
                ElseIf sellchoice = 2 Then
                    sell()
                End If

            Case Else
                Console.Write("Please choose an option.")
                Console.ReadKey()
                sell()

        End Select

    End Sub

    Sub Shopr()
        'Mila and Kiana
        Dim buychoice As Integer = 0
        Console.Clear()
        Console.WriteLine("---------")
        Console.WriteLine("Shop:")
        Console.WriteLine("---------")
        Console.WriteLine("Habachox is: " & habachox)
        Console.WriteLine("Available land is: " & avlland)
        'shop
        Console.WriteLine("1. Land = 2500")
        Console.WriteLine("2. Coal = 10")
        Console.WriteLine("3. Coal Mine = 1750")
        Console.WriteLine("4. Food = 5")
        Console.WriteLine("5. Farm = 2500")
        Console.WriteLine("6. Water = 2")
        Console.WriteLine("7. Dam = 2000")
        Console.WriteLine("8. Electricity = 20")
        Console.WriteLine("9. Power Plant = 3500")
        Console.WriteLine("10. House = 1000")
        Console.WriteLine("11. Exit")
        choice = Console.ReadLine()

        Select Case choice

            Case Is = 1

                If habachox < 2500 Then
                    Console.WriteLine("you don't have enough money.")
                    Console.ReadKey()
                    Shopr()
                End If

                Console.WriteLine("Land is 2500 Habachox.")
                Console.WriteLine("1. Buy.")
                Console.WriteLine("2. Cancel.")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then

                    If uland + avlland = maxland Then
                        Console.WriteLine("You have bought all available land. To increase this by 20, pay 10 000 Habachox")
                        Console.WriteLine("1. Yes")
                        Console.WriteLine("2. No")
                        buychoice = Console.ReadLine()
                        If buychoice = 1 Then
                            habachox -= 10000
                            maxland += 20
                        ElseIf buychoice = 2 Then
                            Shopr()
                        End If

                    End If
                    habachox = habachox - 2500
                    avlland = avlland + 1
                    Console.WriteLine("You have bought one unit of land.")
                    Console.ReadKey()
                    Console.Clear()
                    Shopr()

                ElseIf buychoice = 2 Then
                    Shopr()

                End If

            Case Is = 2

                If habachox < 10 Then
                    Console.WriteLine("You don't have enough money.")
                    Console.ReadKey()
                    Shopr()
                End If

                Console.WriteLine("Coal is 10 Habachox.")
                Console.WriteLine("1. Buy.")
                Console.WriteLine("2. Cancel.")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then


                    habachox = habachox - 5
                    coal = coal + 1
                    Console.WriteLine("You have bought one unit of coal.")
                    Console.ReadKey()
                    Console.Clear()
                    Shopr()

                ElseIf buychoice = 2 Then
                    Shopr()

                End If


            Case Is = 3

                If habachox < 1750 Then
                    Console.WriteLine("you don't have enough money.")
                    Console.ReadKey()
                    Shopr()
                End If
                Console.WriteLine("The coal mine is 1750 Habachox.")
                Console.WriteLine("1. Buy.")
                Console.WriteLine("2. Cancel.")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then

                    If avlland < 1 Then
                        Console.WriteLine("You don't have enough free land available")
                        Console.ReadKey()
                        Shopr()
                    Else
                        habachox = habachox - 1750
                        avlland -= 1
                        cmine += 1
                        uland += 1
                        Console.WriteLine("You have bought a coal mine.")
                        Console.ReadKey()
                        Console.Clear()
                        Shopr()
                    End If
                ElseIf buychoice = 2 Then
                    Shopr()

                End If

            Case Is = 4
                If habachox < 5 Then
                    Console.WriteLine("you don't have enough money.")
                    Console.ReadKey()
                    Shopr()
                End If
                Console.WriteLine("Food is 5 habachox")
                Console.WriteLine("1. Buy.")
                Console.WriteLine("2. Cancel.")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then


                    habachox = habachox - 5
                    food += 1
                    Console.WriteLine("You have bought one unit of food.")
                    Console.ReadKey()
                    Console.Clear()
                    Shopr()

                ElseIf buychoice = 2 Then
                    Shopr()

                End If

            Case Is = 5
                If habachox < 2500 Then
                    Console.WriteLine("you don't have enough money.")
                    Console.ReadKey()
                    Shopr()
                End If
                Console.WriteLine("A farm is 2500 Habachox.")
                Console.WriteLine("1. Buy.")
                Console.WriteLine("2. Cancel.")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then


                    If avlland < 1 Then
                        Console.WriteLine("You don't have enough free land available")
                        Console.ReadKey()
                        Shopr()
                    Else
                        habachox = habachox - 2500
                        avlland -= 1
                        farm += 1
                        uland += 1
                        Console.WriteLine("You have bought a farm.")
                        Console.ReadKey()
                        Console.Clear()
                        Shopr()
                    End If
                ElseIf buychoice = 2 Then
                    Shopr()

                End If


            Case Is = 6
                If habachox < 2 Then
                    Console.WriteLine("you don't have enough money.")
                    Console.ReadKey()
                    Shopr()
                End If
                Console.WriteLine("Water is 2 Habachox.")
                Console.WriteLine("1. Buy.")
                Console.WriteLine("2. Cancel.")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then

                    water += 1
                    habachox = habachox - 2
                    Console.WriteLine("You have bought one unit of water.")
                    Console.ReadKey()
                    Console.Clear()
                    Shopr()

                ElseIf buychoice = 2 Then
                    Shopr()

                End If

            Case Is = 7
                If habachox < 2000 Then
                    Console.WriteLine("you don't have enough money.")
                    Console.ReadKey()
                    Shopr()
                End If
                Console.WriteLine("A dam is 2000 Habachox.")
                Console.WriteLine("1. Buy.")
                Console.WriteLine("2. Cancel.")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then

                    If avlland < 1 Then
                        Console.WriteLine("You don't have enough free land available")
                        Console.ReadKey()
                        Shopr()
                    Else
                        habachox = habachox - 2000
                        avlland -= 1
                        dam += 1
                        uland += 1
                        Console.WriteLine("You have bought a dam.")
                        Console.ReadKey()
                        Console.Clear()
                        Shopr()
                    End If
                ElseIf buychoice = 2 Then
                    Shopr()
                End If



            Case Is = 8
                If habachox < 20 Then
                    Console.WriteLine("you don't have enough money.")
                    Console.ReadKey()
                    Shopr()

                End If


                Console.WriteLine("Electricity is 20 habachox")
                Console.WriteLine("1. Buy.")
                Console.WriteLine("2. Cancel.")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then

                    electricity += 1
                    habachox = habachox - 20
                    Console.WriteLine("You have bought one unit of electricity.")
                    Console.ReadKey()
                    Console.Clear()
                    Shopr()

                ElseIf buychoice = 2 Then
                    Shopr()
                End If

            Case Is = 9
                If habachox < 3500 Then
                    Console.WriteLine("you don't have enough money.")
                    Console.ReadKey()
                    Shopr()
                End If
                Console.WriteLine("A power plant is 3500 Habachox.")
                Console.WriteLine("1. Buy.")
                Console.WriteLine("2. Cancel.")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then

                    If avlland < 1 Then
                        Console.WriteLine("You don't have enough free land available")
                        Console.ReadKey()
                        Shopr()
                    Else
                        habachox = habachox - 3500
                        avlland -= 1
                        powerplant += 1
                        uland += 1
                        Console.WriteLine("You have bought a power plant station.")
                        Console.ReadKey()
                        Console.Clear()
                        Shopr()
                    End If
                ElseIf buychoice = 2 Then
                    Shopr()
                End If


            Case Is = 10

                If habachox < 1000 Then
                    Console.WriteLine("you don't have enough money.")
                    Console.ReadKey()
                    Shopr()
                End If
                Console.WriteLine("A house is 1000 Habachox.")
                Console.WriteLine("1. Buy.")
                Console.WriteLine("2. Cancel.")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then

                    If avlland < 1 Then
                        Console.WriteLine("You don't have enough free land available")
                        Console.ReadKey()
                        Shopr()
                    Else
                        habachox = habachox - 1000
                        avlland -= 1
                        house += 1
                        uland += 1
                        Console.WriteLine("You have bought a house.")
                        Console.ReadKey()
                        Console.Clear()
                        Shopr()
                    End If
                ElseIf buychoice = 2 Then
                    Shopr()
                End If


            Case Is = 11

                Console.WriteLine("Are you sure?")
                Console.WriteLine("1. Yes")
                Console.WriteLine("2. No")

                buychoice = Console.ReadLine()

                If buychoice = 1 Then
                    Menu()
                ElseIf buychoice = 2 Then
                    Shopr()
                End If

            Case Else
                Console.Write("Please choose an option.")
                Console.ReadKey()
                Shopr()

        End Select
    End Sub

    Sub Explain()
        'Jaylyn
        Console.WriteLine("The aim of the game is to keep your economy afloat.")
        Console.WriteLine("You will lose, if you have less than 1 person in your country, or if you are in debt of over 5000 Habachox.")
        Console.WriteLine("")
        Console.WriteLine("Everyday, people will use up resources.")
        Console.WriteLine("They will use 2 units of water everyday, 1 unit of food everyday, and half a unit of coal everyday.")
        Console.WriteLine("If they do not get the sufficient amount of resources, they will die, which is very bad for your economy.")
        Console.WriteLine("Factories will also use 10 electricity everyday(except power plants, which use 0). So if you don't have enough power, you will struggle to gain any resources.")
        Console.WriteLine("")
        Console.WriteLine("This game works on a 7 day period. This means that every 7 days, you will be able to shop and sell for resoruces, and gain resources from your factories.")
        Console.WriteLine("People will give 10 Habachox every cycle.")
        Console.WriteLine("Each factory/plant gives the following: ")
        Console.WriteLine("Dam - produces 600 units of water every week.")
        Console.WriteLine("Farm - produces 350 units of food every week.")
        Console.WriteLine("Coal Mine - produces 200 units of coal every week.")
        Console.WriteLine("Power Plant - produces 200 units of electricity every week.")
        Console.WriteLine("")
        Console.WriteLine("Events also take place at random, which might ask you to make a decision which will affect your resources.")
        Console.WriteLine("If you lose land, and your buildings exceed the amount of land you have, houses will always be removed first. Then it will randomly pick between your factories")
        Console.WriteLine("")
        Console.WriteLine("Remember to look at the happiness of your country!")
        Console.WriteLine("This is determined by the amount of houses you have in comparison to people. 1 house can support up to 50 people.")
        Console.WriteLine("It will check everyday, and increase/decrease your happiness in accordance.")
        Console.WriteLine("Happiness is used to determine how many people join/leave your country. If your happiness is below 50, people will start to leave, which is not good.")
        Console.WriteLine("")
        Console.WriteLine("Once you press enter, the game will begin. You can always press 4 from the menu if you want to re-read this information.")
        Console.WriteLine("ENJOY!")

        Console.ReadKey()
        Menu()

    End Sub

    Sub check()
        'Leruo
        Dim prob As Integer = 0
        help = False
        If daycount Mod 30 = 0 Then
            Console.WriteLine("Habachox " & habachox)
            Console.WriteLine("")
            If food < people Then
                Console.WriteLine("Your food supplies are running low")
                Console.ReadKey()
                help = True
            End If
            If water < people * 2 Then
                Console.WriteLine("Your water supplies are running low")
                Console.ReadKey()
                help = True
            End If

            If coal < people / 2 Then
                Console.WriteLine("Your coal supplies are running low")
                Console.ReadKey()
                help = True
            End If

            If help = True Then
                eventcount += 1
                Console.WriteLine("Due to your lack of water/food or coal your people are dying...")
                Console.ReadKey()
                Randomize()
                prob = Rnd() * 5 + 1
                Select Case prob

                    Case Is = 1
                        Console.WriteLine(" 100 people have died, but you have gained 500 of each resource (water, foood and coal)")
                        people -= 100
                        water += 500
                        food += 500
                        coal += 500
                        Console.ReadKey()

                        Main()

                    Case Is = 2
                        Console.WriteLine("You are here because your country does not have enough Food, Water or Coal to survive you can pay 1000 habachox for some imported food from South Africa or have an estimated 200 people die")
                        Console.ReadKey()
                        Console.WriteLine("To pay 1000 habachox type in 1000, to take a risk type in people")
                        cdecision = Console.ReadLine()
                        If cdecision = "1000" Then
                            habachox = habachox - 1000
                            Console.WriteLine("STATEMENT----BANK OF HABA _____1000 habachox has been deducted from your bank")
                            Console.ReadKey()
                        ElseIf cdecision = "people" Then
                            people -= 200
                            Console.WriteLine("HABA NEWS ***200 Die in African country crisis***")
                            Console.ReadKey()
                        End If

                    Case Is = 3
                        Dim case3 As String = " "
                        Console.WriteLine("You have been given a business offer from Ben Gales (President of Microland")
                        Console.ReadKey()
                        Console.WriteLine("Under this agreement you will be debited 10000 habachox, however you will be left with 5 happiness. If not, 50 of your people will die.")
                        Console.ReadKey()
                        Console.WriteLine("To agree type in y to disagree type in n")
                        case3 = Console.ReadLine()
                        If case3 = "y" Then
                            Console.WriteLine("STATEMENT----BANK OF HABA _____10000 habachox have been deposited")
                            Console.ReadKey()
                            Console.WriteLine("Loading...")
                            Console.ReadKey()
                            happiness = 5
                        ElseIf case3 + "n" Then
                            people -= 50
                            Console.WriteLine("50 people died")
                            Console.ReadKey()
                            Console.WriteLine("Loading...")
                        End If

                    Case Is = 4
                        Console.WriteLine("A project by the UN and and World Bank has been started to feed your citzens, You have gotten away with it this time")
                        Console.ReadKey()
                        Console.WriteLine("HABA BANK STATEMENT----+2000 Habachox, REF UN & WB")
                        Console.ReadKey()
                        Console.WriteLine("Food, water and coal has increased ")
                        Console.ReadKey()
                        Console.WriteLine("Loading...")
                        Console.ReadKey()
                        Console.WriteLine("Loading...")
                        Console.ReadKey()
                        Console.WriteLine("Still Loading")
                        Console.ReadKey()
                        habachox += 2000
                        food = food + 100
                        water = water + 200
                        coal += 50
                    Case Is = 5
                        Console.WriteLine("Nothing has taken place.")
                End Select
            End If
        End If
        resuse()
    End Sub

    Sub resuse()
        'Adrian and Jaylyn
        Dim count As Integer = 0

        If water < people * 2 Then
            Do Until water = 0
                water -= 2
                count += 1
            Loop
            Console.WriteLine("Some of your people have been dehydrated. You have lost " & (count - people) * -1 & " people.")
            people = count
            count = 0
            Console.ReadKey()
        Else
            water -= people * 2
        End If

        If food < people Then
            Do Until food = 0
                food -= 1
                count += 1
            Loop
            Console.WriteLine("Some of your people have starved to death. You have lost " & (count - people) * -1 & " people.")
            people = count
            count = 0
            Console.ReadKey()
        Else
            food -= people
        End If


        If coal < people / 2 Then
            Do Until coal = 0
                coal -= 0.5
                count += 1
            Loop
            Console.WriteLine("Some of your people have died, due to a shortage of coal. You have lost " & (count - people) * -1 & " people.")
            people = count
            count = 0
            Console.ReadKey()
        Else
            coal -= people / 2
        End If

        If electricity < factories * 10 Then
            power = False
        Else
            power = True
            electricity -= factories * 10
        End If

        resgain()

    End Sub

    Sub resgain()
        'Jaylyn
        If house * 50 > people - 1 Then
            If happiness < 100 Then
                happiness += 1
            End If
        Else
            If happiness > 0 Then
                happiness -= 1
            End If

        End If

        If daycount Mod 7 = 0 Then

            habachox = habachox + (people * 10)

            If power = True Then
                food += farm * 350
                water += dam * 600
                coal += cmine * 200
                electricity += powerplant * 200
                Console.WriteLine("")
                Console.WriteLine("You have gained " & dam * 600 & " water.")
                Console.WriteLine("You have gained " & farm * 350 & " food.")
                Console.WriteLine("You have gained " & cmine * 200 & " coal.")
                Console.WriteLine("You have gained " & powerplant * 200 & " electricity.")
                Console.WriteLine("")

            Else
                Console.WriteLine("Please get more electricity, your factories were only able to produce 10% of their full capacity.")
                food += farm * (350 * 0.1)
                water += dam * (600 * 0.1)
                coal += cmine * (200 * 0.1)
                electricity += powerplant * (200 * 0.1)
                Console.WriteLine("")
                Console.WriteLine("You have gained " & dam * 600 * 0.1 & " water.")
                Console.WriteLine("You have gained " & farm * 350 * 0.1 & " food.")
                Console.WriteLine("You have gained " & cmine * 200 * 0.1 & " coal.")
                Console.WriteLine("You have gained " & powerplant * 200 * 0.1 & " electricity.")
                Console.WriteLine("")

            End If

            If daycount > 14 Then

                Select Case happiness
                    Case Is < 10
                        people -= 5
                        Console.WriteLine("5 people have left your country, due to the depressing conditions.")
                    Case Is < 30
                        people -= 1
                        Console.WriteLine("1 person has left your country, due to the depressing conditions.")
                    Case Is < 50
                        Console.WriteLine("No one has left or joined your country.")
                    Case Is < 70
                        people += 1
                        Console.WriteLine("1 person has joined your country, due to how happy your citizens look.")
                    Case Is < 90
                        people += 5
                        Console.WriteLine("5 people have joined your country, due to how happy your citizens look.")
                    Case Is = 100
                        people += 10
                        Console.WriteLine("10 people have joined your country, due to how happy your citizens look.")
                End Select
            End If
            Console.ReadKey()
        End If

        Disaster()

    End Sub

    Sub Disaster()
        'Jaylyn
        If warcheck = False Then
            warcheck = True
            mwar()
        End If
        Console.WriteLine("Habachox " & habachox)
        Console.WriteLine("")

        Dim x As Integer = 0
        If daycount Mod 7 = 0 Then
            Randomize()
            If Rnd() * 100 + 1 > 60 Then
                Randomize()

                x = Rnd() * 8 + 1

                Select Case x
                    Case Is = 1
                        Tsunami()
                    Case Is = 2
                        earthquake()
                    Case Is = 3
                        floods()
                    Case Is = 4
                        SnowStorm()
                    Case Is = 5
                        Disease()
                    Case Is = 6
                        discession()
                    Case Is = 7
                        eventcount += 1
                        habachox += 800
                        Console.WriteLine("Someone has generously donated 800 Habachox to you!")
                        Console.ReadKey()
                    Case Is = 8
                        Tattack()
                End Select
            End If
        End If
        warcheck = False
        Menu()
    End Sub

    Sub Tsunami()
        'Phokela
        eventcount += 1
        Console.WriteLine("A tsunami has taken place. Do you want to")
        Console.WriteLine("1. Gather your people in a building")
        Console.WriteLine("2. Save your land")
        decision = Console.ReadLine()

        If decision = 1 Then

            If avlland < 5 Then
                Do Until avlland = 0
                    avlland -= 1
                    landcount += 1
                Loop
                uland = uland - (5 - landcount)
            Else
                avlland = avlland - 5
            End If

            Console.WriteLine("5 of your land have sunk into the waters!")
            Console.ReadKey()
        ElseIf decision = 2 Then
            people = people - people * 10 / 100
            Console.WriteLine("You have lost 10% of your population")
            Console.ReadKey()
        End If
        Menu()
    End Sub

    Sub earthquake()
        'Karabo
        eventcount += 1
        Console.WriteLine("An earthquake has taken place. Do you want to")
        Console.WriteLine("1. Lose" & people - people * 10 / 100 & " of your people, and save money")
        Console.WriteLine("2. Take your people to a shelter and lose your money ")
        decision = Console.ReadLine()


        If decision = 1 Then
            people = people - people * 10 / 100
            Console.WriteLine("You have lost 10% of your population")
            Console.ReadKey()
            Console.Clear()
        ElseIf decision = 2 Then
            habachox = habachox - habachox * 10 / 100
            Console.WriteLine("You have lost 10% of your Habachox. Unlucky!")
            Console.ReadKey()
        End If
        Menu()
    End Sub

    Sub floods()
        'Kagiso
        eventcount += 1
        Console.WriteLine("The nearby dam has bursted and your town is flooding. You can either:")
        Console.WriteLine("1. Lose half of your food, and save your water")
        Console.WriteLine("2. Lose half your water, and save your food")
        decision = Console.ReadLine()

        If decision = 1 Then
            food = food / 2
            Console.WriteLine("50 % of yourfood have been damaged by the floods")
            Console.ReadKey()
        ElseIf decision = 2 Then
            water = water / 2
            Console.WriteLine("You have lost half your water!")
            Console.ReadKey()
            Console.Clear()
        End If
        Menu()
    End Sub

    Sub SnowStorm()
        'Itu
        eventcount += 1
        Console.WriteLine("A Snow Storm taken place, do you want to")
        Console.WriteLine("1. Keep your people warm and use up some coal.")
        Console.WriteLine("2. Keep the coal for future use.")
        decision = Console.ReadLine()

        If decision = 1 Then
            coal = coal * 0.75
            Console.WriteLine("You lost 25% of your coal, but the happiness increased by 10")
            If happiness > 90 Then
                Do Until happiness = 100
                    happiness += 1
                Loop
            Else
                happiness += 10
            End If
            Console.ReadKey()
        ElseIf decision = 2 Then
            people = people - people * 10 / 100
            Console.WriteLine("You have lost 10% of your population. Happiness decreased by 10.")
            Console.ReadKey()
            Console.Clear()

        End If
        Menu()
    End Sub

    Sub Disease()
        'Vernon
        eventcount += 1
        Console.WriteLine("A disease outbreak has occured . Do you want to")
        Console.WriteLine("1. Save" & people - people * 50 / 100 & " some of your people for 1000 Habachox")
        Console.WriteLine("2. Save" & people & " people for 2000 Habachox")
        Console.WriteLine("3. Take all your people to a rehab center for 4000 Habachox")
        Console.WriteLine("4. Save only 5% of your population for free")
        decision = Console.ReadLine()

        If decision = 1 Then
            habachox -= 1000
            people = people / 4
            Console.WriteLine("1 quarter of your people survived.")
            Console.ReadKey()
        ElseIf decision = 2 Then
            people = people / 2
            habachox -= 2000
            Console.WriteLine("You have lost 50% of your population due to this disease")
            Console.ReadKey()
            Console.Clear()
        ElseIf decision = 3 Then
            habachox -= 4000
            Console.WriteLine("Everyone survived!")
        Else
            people = people * 0.05
            Console.WriteLine("Only " & people & " survived.")
        End If
        Console.ReadKey()
        Menu()
    End Sub

    Sub Tattack()
        'Tlotlo
        eventcount += 1

        people -= 6
        Console.WriteLine("You've been attacked ")
        Console.WriteLine("-You lost 3 land. Ha!")
        Console.WriteLine("-Six people died")
        Console.WriteLine("")
        Console.WriteLine("Do you want to pay for repairs? (1000 Habachox)")
        Console.WriteLine("1. Yes")
        Console.WriteLine("2. No")
        decision = Console.ReadLine()

        If decision = 1 Then
            habachox -= 1000
            If happiness > 95 Then
                Do Until happiness = 100
                    happiness += 1
                Loop
            Else
                happiness += 5
            End If

            Console.WriteLine("You have sucessfully restored your land, and increased your happiness by 5.")

        Else
            If avlland < 5 Then
                Do Until avlland = 0
                    avlland -= 1
                    landcount += 1
                Loop
                uland = uland - (5 - landcount)
            Else
                avlland = avlland - 5
            End If
            happiness -= 5
            Console.WriteLine("Your people are unhappy. You didn't restore any land and lost 5 happiness")

        End If
        Console.ReadKey()
        Menu()
    End Sub

    Sub discession()
        'Ethan
        Dim num As Integer = 0
        Dim disc As Integer = 0
        eventcount += 1
        num = Rnd() * 3 + 1
        Select Case num
            Case 1

                Console.WriteLine("Would you like to spend 100 habachox to improve your countries happines?")
                Console.WriteLine("1. Yes")
                Console.WriteLine("2. No")
                disc = Console.ReadLine
                If disc = 1 Then
                    habachox -= 100
                    If happiness > 95 Then
                        Do Until happiness = 100
                            happiness += 1
                        Loop
                    Else
                        happiness += 5
                    End If
                    Console.WriteLine("Your happiness has increaed by 5")
                End If


            Case 2
                Console.WriteLine("There is a problem with the power lines! You have four options")
                Console.WriteLine("1. Pay 300 habachox to fix the power lines but this will cause loadshedding for 3 days, This will cause your countries happines to temperarily lower")
                Console.WriteLine("2. Pay 100 habachox to fix the power lines. This will cause a week worth of loadshedding and will lower your countries happiness, even more!")
                Console.WriteLine("3. Wait a month, this will cost you nothing, but your happiness will decrease by 50%")
                Console.WriteLine("4. Pay 500 Habachox, and have your cables repaired with no load shedding.")
                disc = Console.ReadLine
                If disc = 1 Then
                    habachox -= 300
                    happiness -= 5
                    Console.WriteLine("You have succesfully repaired the power lines, but your happiness decreased by 5.")

                ElseIf disc = 2 Then
                    habachox -= 100
                    happiness -= 10
                    Console.WriteLine("You have succesefully repaired the power lines, but your happiness decreased by 10")

                ElseIf disc = 3 Then
                    Console.WriteLine("Your happiness has decreased by " & happiness / 2 & " happiness.")
                    happiness -= happiness / 2

                ElseIf disc = 4 Then
                    habachox -= 500
                    Console.WriteLine("You have succesefully repaired the power lines, your happiness has increased by 5.")
                    If happiness > 95 Then
                        Do Until happiness = 100
                            happiness += 1
                        Loop
                    Else
                        happiness += 5
                    End If

                End If

            Case 3
                Console.WriteLine("There is a request to donate to help save the turtles.")
                Console.WriteLine("Will you")
                Console.WriteLine("1. Donate 50 habachox to support the worlds move to metal straws?")
                Console.WriteLine("2. Don't donate any money!")
                disc = Console.ReadLine
                If disc = 1 Then
                    Console.WriteLine("You saved the turtles, Everybody liked that")
                    Console.WriteLine("Your happines increased by 20")
                    habachox -= 50
                    If happiness > 80 Then
                        Do Until happiness = 100
                            happiness += 1
                        Loop
                    Else
                        happiness += 20
                    End If
                ElseIf disc = 2 Then
                    Console.WriteLine("All the turtles have gone extinct! your happines decreased by 30")
                    happiness -= 30
                End If


        End Select
        Console.ReadKey()
        Menu()
    End Sub

    Sub mwar()
        'Nathan
        war = False

        If daycount Mod 7 = 0 Then
            warchance = 0
            Randomize()
            warchance = Rnd() * 100 + 1

            If warchance < 5 Then

                war = True
                Randomize()
                warlength = Rnd() * 10 + 1
                newsletter()
            Else
                newsletter()
            End If

        End If

    End Sub
    Sub war1()
        'Nathan
        eventcount += 1
        numgen = 0


        Do Until warlength = 0
            Randomize()
            numgen = Rnd() * 5 + 1
            Select Case numgen
                Case 1
                    Randomize()
                    wcount1 = Rnd() * 20 + 1
                    people -= wcount1
                    wpeople += wcount1
                    Randomize()
                    wcount2 -= Rnd() * 10 + 1
                    happiness = wcount2
                    whap += wcount2
                    Randomize()
                    Console.Clear()
                    Console.WriteLine("We Need Reinforcements")
                    Console.WriteLine("-People")
                    Console.WriteLine("-Happiness")
                    Console.ReadKey()
                Case 2
                    Randomize()
                    wcount1 = Rnd() * 50 + 1
                    coal -= wcount1
                    wcoal += wcount1
                    Randomize()
                    wcount2 = Rnd() * 40 + 1
                    food -= wcount2
                    wfood += wcount2
                    Console.Clear()
                    Console.WriteLine("We Need Fuel")
                    Console.WriteLine("-Coal")
                    Console.WriteLine("-Food")
                    Console.ReadKey()
                Case 3
                    Randomize()
                    wcount1 = Rnd() * 70 + 1
                    food -= wcount1
                    wfood += wcount1
                    Randomize()
                    wcount2 = Rnd() * 100 + 1
                    water -= wcount2
                    wwat += wcount2
                    Console.Clear()
                    Console.WriteLine("We Need Supples")
                    Console.WriteLine("-Food")
                    Console.WriteLine("-Water")
                    Console.ReadKey()

                Case 4
                    Randomize()
                    wcount1 = Rnd() * 1000
                    habachox += wcount1
                    whaba += wcount1
                    Randomize()
                    Console.Clear()
                    Console.WriteLine("We Raided a Base")
                    Console.WriteLine("+Habachox")
                    Console.ReadKey()

                Case 5
                    Console.Clear()
                    Console.WriteLine("Nothing Major Happened")
                    Console.ReadKey()
            End Select
            warlength -= 1
        Loop

        Console.WriteLine("A war took place.")
        Console.WriteLine("You lost " & wpeople & " People.")
        Console.WriteLine("You lost " & whap & " Happiness.")
        Console.WriteLine("You lost " & wwat & " Water.")
        Console.WriteLine("You lost " & wfood & " Food.")
        Console.WriteLine("You lost " & wcoal & " Coal.")
        Console.WriteLine("You gained " & whaba & " Habachox.")

        wpeople = 0
        whap = 0
        wcoal = 0
        wfood = 0
        whaba = 0
        wwat = 0

    End Sub
    Sub newsletter()
        'Nathan
        If war = False Then
            Console.Clear()
            Console.WriteLine("Status of war :")
            Console.WriteLine("====================")
            Console.WriteLine("False")
            Console.ReadKey()
        Else
            Console.Clear()
            Console.WriteLine("Status of war :")
            Console.WriteLine("====================")
            Console.WriteLine("True")
            Console.ReadKey()
            war1()
        End If
    End Sub

    Sub loss()
        'Jaylyn
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("You have lost!")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Days survived: " & daycount)
        Console.WriteLine("Events encountered: " & eventcount)
        Console.ReadKey()
        loss()

    End Sub

End Module
