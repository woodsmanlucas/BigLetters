using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Big.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BigSentenceController : ControllerBase
    {
        private readonly ILogger<BigSentenceController> _logger;

        public BigSentenceController(ILogger<BigSentenceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            return "Welcome to my API. Usage: {\"sentence\":\"Hello World\"} then check your console output";
        }


        [HttpPost]
        public async Task<ActionResult<String>> Post(Sentence sentence)
        {

            if (!ModelState.IsValid)
            return BadRequest("Invalid data.");

           MakeBig(sentence);

            return Ok(sentence.sentence);
        }

        private void MakeBig(Sentence small)
        {
            String CurrentLine = "";

            for (int line = 4; line >= 0; line--) {
                CurrentLine = "";
                foreach (char character in small.sentence.ToLower()) {
                    switch (character)
                    {
                        case 'a':
                            CurrentLine += A[4 - line];
                            break;
                        case 'b':
                            CurrentLine += B[4 - line];
                            break;

                        case 'c':
                            CurrentLine += C[4 - line];
                            break;
                        case 'd':
                            CurrentLine += D[4 - line];
                            break;
                        case 'e':
                            CurrentLine += E[4 - line];
                            break;
                        case 'f':
                            CurrentLine += F[4 - line];
                            break;
                        case 'g':
                            CurrentLine += G[4 - line];
                            break;
                        case 'h':
                            CurrentLine += H[4 - line];
                            break;

                        case 'i':
                            CurrentLine += I[4 - line];
                            break;
                        case 'j':
                            CurrentLine += J[4 - line];
                            break;
                        case 'k':
                            CurrentLine += K[4 - line];
                            break;
                        case 'l':
                            CurrentLine += L[4 - line];
                            break;
                        case 'm':
                            CurrentLine += M[4 - line];
                            break;
                        case 'n':
                            CurrentLine += N[4 - line];
                            break;

                        case 'o':
                            CurrentLine += O[4 - line];
                            break;
                        case 'p':
                            CurrentLine += P[4 - line];
                            break;
                        case 'q':
                            CurrentLine += Q[4 - line];
                            break;
                        case 'r':
                            CurrentLine += R[4 - line];
                            break;
                        case 's':
                            CurrentLine += S[4 - line];
                            break;
                        case 't':
                            CurrentLine += T[4 - line];
                            break;

                        case 'u':
                            CurrentLine += U[4 - line];
                            break;
                        case 'v':
                            CurrentLine += V[4 - line];
                            break;
                        case 'w':
                            CurrentLine += W[4 - line];
                            break;
                        case 'x':
                            CurrentLine += X[4 - line];
                            break;
                        case 'y':
                            CurrentLine += Y[4 - line];
                            break;
                        case 'z':
                            CurrentLine += Z[4 - line];
                            break;
                        case ' ':
                            CurrentLine += "           ";
                            break;
                        default:
                            break;
                    }
                }
            Console.Out.WriteLine(CurrentLine);
        }
        }

        private String[] A =
            { "    AA     ",
              "   AAAA    ",
              "  AA  AA   ",
              " AAAAAAAA  ",
              "AA      AA " };

        private String[] B =
        {
            "BBBBBBBB   ",
            "BB      BB ",
            "BBBBBBBBB  ",
            "BB      BB ",
            "BBBBBBBB   "
        };
        private String[] C =
        {
            " CCCCCC    ",
            "CC      CC ",
            "CC         ",
            "CC      CC ",
            "  CCCCCC   "
        };

        private String[] D =
        {
            "DDDDDDDDD  ",
            "DD      DD ",
            "DD      DD ",
            "DD      DD ",
            "DDDDDDDDD  "
        };

        private String[] E =
        {
            "EEEEEEEEEEE ",
            "EE          ",
            "EEEEEEEEEEE ",
            "EE          ",
            "EEEEEEEEEEE "
        };
        private String[] F =
        {
            "FFFFFFFFFF ",
            "FF         ",
            "FFFFFFF    ",
            "FF         ",
            "FF         ",


        };
        private String[] G =
        {
            "  GGGGGG   ",
            "GG         ",
            "GG    GGGG ",
            "GG      GG ",
            "  GGGGGG   "
        };
        private String[] H =
        {
            "HH      HH ",
            "HH      HH ",
            "HHHHHHHHHH ",
            "HH      HH ",
            "HH      HH "
        };

        private String[] I =
        {
            "IIIIIIIIII ",
            "    II     ",
            "    II     ",
            "    II     ",
            "IIIIIIIIII ",
        };
        private String[] J =
        {
            "JJJJJJJJJJ ",
            "        JJ ",
            "        JJ ",
            "JJ     JJ  ",
            " JJJJJJJ   ",
        };
        private String[] K =
        {
            "KK    KK   ",
            "KK  KK     ",
            "KKKK       ",
            "KK  KK     ",
            "KK    KK   "
        };
        private String[]L =
        {
            "LL         ",
            "LL         ",
            "LL         ",
            "LL         ",
            "LLLLLLLLLL "
        };
        private String[] M =
        {
            "MM      MM ",
            "MMMM  MMMM ",
            "MM MMMM MM ",
            "MM      MM ",
            "MM      MM "
        };
        private String[] N =
            { "NN      NN ",
              "NNNN    NN ",
              "NN  NN  NN ",
              "NN    NNNN ",
              "NN      NN "};

        private String[] O =
        {
            "   OOOO    ",
            " OO    OO  ",
            "OO      OO ",
            " OO    OO  ",
            "   OOOO    ",
        };
        private String[] P =
        {
            "PPPPPP   ",
            "PP    PP ",
            "PPPPPP   ",
            "PP       ",
            "PP       "
        };

        private String[] Q =
        {
            "  QQQQQQ   ",
            "QQ      QQ ",
            "QQ      QQ ",
            "  QQQQQQ   ",
            "       QQ  ",

        };

        private String[] R =
        {
            "RRRRRRRR   ",
            "RR     RR  ",
            "RRRRRRRR   ",
            "RR      RR ",
            "RR      RR "
        };
        private String[] S =
        {
            "  SSSSSSSS ",
            "SS         ",
            " SSSSSSSS  ",
            "        SS ",
            " SSSSSSSS  ",
        };
        private String[] T =
        {
            "TTTTTTTTTTTTT ",
            "     TT       ",
            "     TT       ",
            "     TT       ",
            "     TT       "
        };
        private String[] U =
        {
            "UU      UU ",
            "UU      UU ",
            "UU      UU ",
            " UU    UU  ",
            "  UUUUUU   "
        };

        private String[] V =
        {
            "VV      VV ",
            " VV    VV  ",
            "  VV  VV   ",
            "   VVVV    ",
            "    VV     "
        };
        private String[] W =
        {
            "WW   WW   WW ",
            "WW   WW   WW ",
            " WW WW WW WW ",
            "  WWWW WWWW  ",
            "   WW   WW   "

        };
        private String[] X =
        {
            "XX        XX ",
            "  XX    XX   ",
            "    XXXX    ",
            "  XX    XX   ",
            "XX        XX "
        };
        private String[] Y =
        {
            "YY      YY ",
            "  YY  YY   ",
            "    YY     ",
            "    YY     ",
            "    YY     "
        };
        private String[] Z =
        {
            "ZZZZZZZZZZ ",
            "       ZZ  ",
            "     ZZ    ",
            "   ZZ      ",
            "ZZZZZZZZZZ "
        };







    }
}
