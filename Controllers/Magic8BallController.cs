// Fernando Aguilar
// 10-27-22
// Magic 8 Ball Endpoint
// This program takes the magic 8 ball mini challenge and converts it into API format. 
// The program takes the randomize function and gives the user a random answer like the magic 8 ball.
// Peer Reviewed By: Manuel L. When looking and the code evertything looks good
// so I went to postman to make sure everything works even better and it does
//the code throws out different endings which is the point of magic eight ball
//overall everything looks really great and so does the code, Great job 
// on the assignment :)


using Microsoft.AspNetCore.Mvc;

namespace AguilarFMagic8BallEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    [HttpGet]
    [Route("answer/{randomize}")]

    public string MagicAnswer(string myAnswer)
    {
        string[] magicAnswers = { "Yes", "No", " unclear, ask again", "For Sure", "No Chance", " Focus harder and ask again", " It will be so", " It will not be so" };

        if (myAnswer == "randomize")

        {
            Random rd = new Random();
            int myNum = rd.Next(1, 8);
            return magicAnswers[myNum];
        }
        else
        {
            return "invalid Entry.";
        }

    }
}
