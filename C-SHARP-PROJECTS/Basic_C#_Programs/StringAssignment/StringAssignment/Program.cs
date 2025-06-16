using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Concatenates three strings
            string one = "A frog jumps into the pond,\n";
            string two = "Splash! Silence again.\n";
            string three = "The day is still calm.\n";

            string haiku = one + two + three;
            Console.WriteLine(haiku);


            // Converts a string to uppercase
            string yelling = "ahhhhhhhhhhhhhhh";
            yelling = yelling.ToUpper();
            Console.WriteLine(yelling);


            // Creates a Stringbuilder object and builds a paragraph of text, one sentence at a time
            StringBuilder sb = new StringBuilder();
            sb.Append("Soon we were hemmed in with trees, which in places arched right over the roadway till we passed as through a tunnel; and again great frowning rocks guarded us boldly on either side. ");
            sb.Append("Though we were in shelter, we could hear the rising wind, for it moaned and whistled through the rocks, and the branches of the trees crashed together as we swept along.");
            sb.Append("It grew colder and colder still, and fine, powdery snow began to fall, so that soon we and all around us were covered with a white blanket. ");
            sb.Append("The keen wind still carried the howling of the dogs, though this grew fainter as we went on our way. ");
            sb.Append("The baying of the wolves sounded nearer and nearer, as though they were closing round on us from every side. ");
            sb.Append("I grew dreadfully afraid, and the horses shared my fear. ");
            sb.Append("The driver, however, was not in the least disturbed; he kept turning his head to left and right, but I could not see anything through the darkness.");

            Console.WriteLine(sb);



            Console.ReadLine();
        }
    }
}
