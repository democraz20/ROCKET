namespace ROCKET;

[CommandAttribute("argtest")]
public class argtest : InCom
{
    public void Run(string[] input)
    {
        if (input.Length == 0){
            Console.WriteLine("no args passed in");
        }
        else{
            for (int i = 0; i < input.Length; i++)
            {   
                Console.WriteLine($"index {i} all args {input[i]}");
            }
        }
    }
}
