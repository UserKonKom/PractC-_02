// Конструкторы классов. Модификатор static!

using System;

namespace project {

    class Program {
        static void Main(){
            Robot Bot = new Robot("Bot", 800, new byte[] {0, 0, 0,});
            Bot.printValues();

            Robot Killer = new Robot();
            Killer.setValues("Killer", 1000, new byte[] {0, 0, 10,});
            Killer.printValues();

            Robot Bot1 = new Robot("Bot");

            // Robot.count = 5;
            Robot.Print();

        }

    }

}