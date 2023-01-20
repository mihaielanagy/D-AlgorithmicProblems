using AlgorithmicProblems;

Console.WriteLine("Enter the assigment number to run");
string input = Console.ReadLine();

switch (input)
{
    case "1":
        {
            var AS1 = new Assignment1();
            AS1.Run();
            break;
        }
    case "2":
        {
            var AS2 = new Assignment2();
            AS2.Run();
            break;
        }
    case "3":
        {
            var AS3 = new Assignment3();
            AS3.Run();
            break;
        }
    case "4":
        {
            var AS4 = new Assignment4();
            AS4.Run();
            break;
        }
    case "5":
        {
            var AS5 = new Assignment5();
            AS5.Run();
            break;
        }

    case "6":
        {
            var AS6 = new Assignment6();
            AS6.Run();
            break;
        }
    case "7":
        {
            var AS7 = new Assignment7();
            AS7.Run();
            break;
        }
    case "8":
        {
            var AS8 = new Assignment8();
            AS8.Run();
            break;
        }
    case "9":
        {
            var AS9 = new Assignment9();
            AS9.Run();
            break;
        }
    case "10":
        {
            var AS10 = new Assignment10();
            AS10.Run();
            break;
        }
    default:
        break;
}
