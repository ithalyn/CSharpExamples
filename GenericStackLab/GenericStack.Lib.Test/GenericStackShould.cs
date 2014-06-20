using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericStack.Lib.Test{

    [TestClass]
    public class GenericStackShould{

        [TestMethod]
        public void Return1IfPoppedWithOnlyOneItemOf1(){
            var stack = new Stack<int>(new[]{1});
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void ReturnAbcIfPeekedTwiceWithTwoItemsOfAbcAndDef(){
            var stack = new Stack<string>(new[]{"Abc", "Def"});
            stack.Peek();
            Assert.AreEqual("Def", stack.Peek());
        }

        [TestMethod]
        public void ReturnAbcIfPoppedAfterPushingAbc(){
            var stack = new Stack<string>();
            stack.Push("Abc");
            Assert.AreEqual("Abc", stack.Pop());
        }

        [TestMethod]
        public void ReturnAbcIfPoppedTwiceAfterPushingAbcAndDef(){
            var stack = new Stack<string>();
            stack.Push("Abc");
            stack.Push("Def");
            stack.Pop();
            Assert.AreEqual("Abc", stack.Pop());
        }

        [TestMethod]
        public void ReturnAbcIfPoppedWithOnlyOneItemOfAbc(){
            IGenericStack<string> stack = new Stack<string>(new[]{"Abc"});
            Assert.AreEqual("Abc", stack.Pop());
        }

        [TestMethod]
        public void ReturnDefIfPoppedAfterPushingAbcAndDef(){
            var stack = new Stack<string>();
            stack.Push("Abc");
            stack.Push("Def");
            Assert.AreEqual("Def", stack.Pop());
        }

        [TestMethod]
        public void ReturnDefIfPoppedTwiceWithTwoItemsOfAbcAndDef(){
            var stack = new Stack<string>(new[]{"Abc", "Def"});
            stack.Pop();
            Assert.AreEqual("Abc", stack.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof (InvalidOperationException))]
        public void ThrowInvalidOperationExceptionIfPoppedWhileEmpty(){
            var stack = new Stack<string>();
            stack.Pop();
        }
    }
}