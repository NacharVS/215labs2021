using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labs215Y2K.UnityProjects
{
    class Music
    {
        public static async Task SuperMario(CancellationToken token)
        {
            Console.WriteLine($"Метод SuperMario начал свою работу в потоке  - {Thread.CurrentThread.ManagedThreadId}");

            int[] FrequncyMassive = new int[] { 659, 659, 659, 523, 659, 784, 392, 523, 392, 330, 440, 494, 466, 440, 392, 659, 784, 880, 698, 784, 659, 880, 698, 784, 659, 523, 587, 494, 523, 392, 330, 440, 392, 659, 784, 880, 698, 784, 659, 523, 587, 494, 784, 740, 698, 622, 659, 415, 440, 523, 440, 523, 587, 784, 740, 698, 622, 659, 698, 698, 698, 784, 740, 698, 622, 659, 415, 440, 523, 440, 523, 587, 622, 587, 523, 784, 740, 698, 622, 659, 415, 440, 523, 440, 523, 587, 784, 740, 698, 622, 659, 698, 698, 698, 784, 740, 698, 622, 659, 415, 440, 523, 587, 622, 587, 523 };
            int DurationMusic = 125;
            int[] PauseMassive = new int[] { 0, 125, 125, 0, 125, 325, 375, 250, 250, 250, 125, 125, 42, 125, 125, 125, 125, 125, 0, 125, 125, 125, 0, 125, 250, 250, 250, 125, 125, 42, 125, 125, 125, 125, 125, 0, 125, 125, 125, 0, 325, 0, 0, 42, 125, 167, 0, 0, 125, 0, 0, 250, 0, 0, 42, 125, 167, 125, 0, 625, 0, 0, 42, 125, 167, 0, 0, 125, 0, 0, 250, 250, 250, 1150, 0, 0, 42, 125, 167, 0, 0, 125, 0, 0, 250, 0, 0, 42, 120, 167, 125, 0, 650, 0, 0, 42, 125, 167, 0, 0, 125, 0, 0, 250, 250, 250, 650 };
            for (int i = 0; i < FrequncyMassive.Length; i++)
            {
                Console.Beep(FrequncyMassive[i], DurationMusic);
                if (PauseMassive[i] > 0)
                    await Task.Delay(PauseMassive[i], token);
                else
                    continue;
            }
            Console.WriteLine($"Метод SuperMario законьчил свою работу в потоке  - {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
