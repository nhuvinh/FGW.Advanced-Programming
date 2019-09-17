using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Tutorial
    {
        protected int Key;
        public Tutorial() { }
        public void SetKey (int key)
        {
            Key = key;
        }

        public int GetKey()
        {
            return Key;
        }
        public virtual void Display()
        {

        }
    }
    class Guru99Tutorial : Tutorial
    {
        protected int TutorialID;
        protected string TutorialName;

        public override void Display()
        {
            Console.WriteLine("Welcome to Guru99 Tutorials");
        }

        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }

        public String GetTutorial()
        {
            return TutorialName;
        }

        static void Main(string[] args)
        {
            //Tutorial myTutorial = new Tutorial();
            Guru99Tutorial pTutor = new Guru99Tutorial();

            pTutor.SetTutorial(1, ".Net");

            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();
        }
    }
}
