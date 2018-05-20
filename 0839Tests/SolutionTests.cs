using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0839;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0839.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void NumSimilarGroupsTest()
        {
            string[] input = { "tars", "rats", "arts", "star" };
            int expected = 2;

            Solution solution = new Solution();
            var result = solution.NumSimilarGroups(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void NumSimilarGroupsTest2()
        {
            string[] input = { "kccomwcgcs","socgcmcwkc","sgckwcmcoc",
                "coswcmcgkc","cowkccmsgc","cosgmccwkc",
                "sgmkwcccoc","coswmccgkc","kowcccmsgc",
                "kgcomwcccs" };
            int expected = 5;

            Solution solution = new Solution();
            var result = solution.NumSimilarGroups(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void NumSimilarGroupsTest3()
        {
            string[] input = { "ajdidocuyh","djdyaohuic","ddjyhuicoa","djdhaoyuic","ddjoiuycha","ddhoiuycja","ajdydocuih","ddjiouycha","ajdydohuic","ddjyouicha"};
            int expected = 2;

            Solution solution = new Solution();
            var result = solution.NumSimilarGroups(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void NumSimilarGroupsTest4()
        {
            string[] input = { "uqtqjancqpfataqrlfmuglyyv","yalucgattqqpfmfunyrvqlajq","yatucgatlqqpfmfunyrvqlajq","yatucgatlqqpfrfunymvqlajq","qqyajmtpafulucvtgqqalnfry","clqugvltmryyqajqafqntafup","qmrglvyayaajqnfulcptqutfq","qcagqvyayarjlmfulnptqutfq","qnrgqvyayaajlmfulcptqutfq","qcagqvyauarjlmfylnptqutfq","clqugvltpryyqajqafqntafum","qmrgqvyayaajlnfulcptqutfq","rlqugvltyjpyqacqafqnfatum","uqtqjancqpfytyqrafmuglalv","clqugvjtmryyqalqafqntafup","qqyujmtpafalucvtgqqalnfry","clqugvltyrpyqajqafqnfatum","qnagqvyayarjlmfulcptqutfq","uqtqjancqpfataqryfmuglylv","yglavtqaptqfmfqjrunqlaycu","uqtqjancqpfatyqrafmuglylv","mvfqtcgfaqrauqytplqyuajnl","jlqugvltyrpyqacqafqnfatum","yatfcgatlqqpfruunymvqlajq","clqugvltpryyqajqafqnfatum"};
            int expected = 7;

            Solution solution = new Solution();
            var result = solution.NumSimilarGroups(input);
            Assert.AreEqual(expected, result);
        }
    }
}