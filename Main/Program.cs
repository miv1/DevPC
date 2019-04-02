namespace Main
{
    using System;
    using System.Collections.Generic;
    using Jalasoft.DevBootcamp.Pc.Hardware;
    using Jalasoft.DevBootcamp.Pc.PersonalComputer;
    using Jalasoft.DevBootcamp.Pc.Software;
    using Jalasoft.DevBootcamp.Pc.Software.User;

    public class Program
    {
        public static void Main(string[] args)
        {
            PersonalComputer myPc = new PersonalComputer();
            myPc.Guarantee = 2;
            myPc.Price = 1000;
            myPc.Provider = "World PC";
            myPc.HardwarePc = new List<Hardware>();

            // setting screen
            Screen myScreen = new Screen();
            myScreen.Brand = "Samsung";
            myPc.HardwarePc.Add(myScreen);

            // setting keyboard
            Keyboard myKeyboard = new Keyboard();
            myKeyboard.Brand = "Genius";
            myPc.HardwarePc.Add(myKeyboard);

            // setting mouse
            Mouse myMouse = new Mouse();
            myMouse.Brand = "Genius";
            myPc.HardwarePc.Add(myMouse);

            // setting case
            Case myCase = new Case();
            myCase.Brand = "Ducky";
            myPc.HardwarePc.Add(myCase);

            // setting camera
            Camera myCamera = new Camera();
            myCamera.Color = "Silver";
            myPc.HardwarePc.Add(myCamera);

            // setting speaker
            Speaker mySpeaker = new Speaker();
            mySpeaker.Frequency = 100;
            myPc.HardwarePc.Add(mySpeaker);
            myPc.SoftwarePc = new List<Software>();

            // setting softwareOS
            Software mySoftwareOS = new Software();
            mySoftwareOS.Version = 2;
            mySoftwareOS.LastUpdate = DateTime.Now.AddYears(-10);
            mySoftwareOS.Name = "Windows XP";
            myPc.SoftwarePc.Add(mySoftwareOS);
            Software mySoftwareApp = new Software();
            mySoftwareApp.Version = 5;
            mySoftwareApp.LastUpdate = DateTime.Now.AddYears(-2);
            mySoftwareApp.Name = "League of Legends";
            mySoftwareApp.Release = DateTime.Now.AddYears(-8);
            myPc.SoftwarePc.Add(mySoftwareApp);
            User myUser = new User();
            myUser.FirstName = "Bill";
            myUser.LastName = "Gates";
            myUser.UserName = "B.Gates";
            mySoftwareOS.Users = new List<User>();
            mySoftwareOS.Users.Add(myUser);
            myScreen.Brand = "Samsung";
            myPc.HardwarePc.Add(myScreen);
        }
    }
}