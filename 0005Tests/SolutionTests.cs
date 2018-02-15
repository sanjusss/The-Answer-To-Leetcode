using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0005;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0005.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void LongestPalindromeTest()
        {
            string source = "babad";
            string target = "bab";

            Solution solution = new Solution();
            string result = solution.LongestPalindrome(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void LongestPalindromeTest2()
        {
            string source = "cbbd";
            string target = "bb";

            Solution solution = new Solution();
            string result = solution.LongestPalindrome(source);
            Assert.AreEqual(target, result);
        }

        [TestMethod()]
        public void LongestPalindromeTest3()
        {
            string source = "anugnxshgonmqydttcvmtsoaprxnhpmpovdolbidqiyqubirkvhwppcdyeouvgedccipsvnobrccbndzjdbgxkzdbcjsjjovnhpnbkurxqfupiprpbiwqdnwaqvjbqoaqzkqgdxkfczdkznqxvupdmnyiidqpnbvgjraszbvvztpapxmomnghfaywkzlrupvjpcvascgvstqmvuveiiixjmdofdwyvhgkydrnfuojhzulhobyhtsxmcovwmamjwljioevhafdlpjpmqstguqhrhvsdvinphejfbdvrvabthpyyphyqharjvzriosrdnwmaxtgriivdqlmugtagvsoylqfwhjpmjxcysfujdvcqovxabjdbvyvembfpahvyoybdhweikcgnzrdqlzusgoobysfmlzifwjzlazuepimhbgkrfimmemhayxeqxynewcnynmgyjcwrpqnayvxoebgyjusppfpsfeonfwnbsdonucaipoafavmlrrlplnnbsaghbawooabsjndqnvruuwvllpvvhuepmqtprgktnwxmflmmbifbbsfthbeafseqrgwnwjxkkcqgbucwusjdipxuekanzwimuizqynaxrvicyzjhulqjshtsqswehnozehmbsdmacciflcgsrlyhjukpvosptmsjfteoimtewkrivdllqiotvtrubgkfcacvgqzxjmhmmqlikrtfrurltgtcreafcgisjpvasiwmhcofqkcteudgjoqqmtucnwcocsoiqtfuoazxdayricnmwcg";
            string target = "hpyyph";

            Solution solution = new Solution();
            string result = solution.LongestPalindrome(source);
            Assert.AreEqual(target, result);
        }
    }
}