using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0843;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0843.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindSecretWordTest()
        {
            string secret = "acckzz";
            string[] wordlist = { "acckzz", "ccbazz", "eiowzz", "abcczz" };
            int maxTry = 10;
            Master master = new Master(secret, maxTry);

            Solution solution = new Solution();
            solution.FindSecretWord(wordlist, master);
        }
        
        [TestMethod()]
        public void FindSecretWordTest2()
        {
            string secret = "hbaczn";
            string[] wordlist = { "gaxckt","trlccr","jxwhkz","ycbfps","peayuf","yiejjw","ldzccp","nqsjoa","qrjasy","pcldos","acrtag","buyeia","ubmtpj","drtclz","zqderp","snywek","caoztp","ibpghw","evtkhl","bhpfla","ymqhxk","qkvipb","tvmued","rvbass","axeasm","qolsjg","roswcb","vdjgxx","bugbyv","zipjpc","tamszl","osdifo","dvxlxm","iwmyfb","wmnwhe","hslnop","nkrfwn","puvgve","rqsqpq","jwoswl","tittgf","evqsqe","aishiv","pmwovj","sorbte","hbaczn","coifed","hrctvp","vkytbw","dizcxz","arabol","uywurk","ppywdo","resfls","tmoliy","etriev","oanvlx","wcsnzy","loufkw","onnwcy","novblw","mtxgwe","rgrdbt","ckolob","kxnflb","phonmg","egcdab","cykndr","lkzobv","ifwmwp","jqmbib","mypnvf","lnrgnj","clijwa","kiioqr","syzebr","rqsmhg","sczjmz","hsdjfp","mjcgvm","ajotcx","olgnfv","mjyjxj","wzgbmg","lpcnbj","yjjlwn","blrogv","bdplzs","oxblph","twejel","rupapy","euwrrz","apiqzu","ydcroj","ldvzgq","zailgu","xgqpsr","wxdyho","alrplq","brklfk" };
            int maxTry = 10;
            Master master = new Master(secret, maxTry);

            Solution solution = new Solution();
            solution.FindSecretWord(wordlist, master);
        }
    }
}