// Создание классов и объектов!

using System;

namespace project {

    class Program {
        static void Main(){
            Robot Bot = new Robot();
            Bot.setValues("Bot", 800, new byte[] {0, 0, 0,});
            Bot.printValues();

            Robot Killer = new Robot();
            Killer.setValues("Killer", 1000, new byte[] {0, 0, 10,});
            Killer.printValues();

        }

    }

}