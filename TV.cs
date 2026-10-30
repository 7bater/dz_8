using dz_8;
using static System.Console;

namespace dz_8
{
    public class TV : IRemoteControl
    {
        public void TurnOn()
        {
            WriteLine("Телевізор увімкнено.");
        }

        public void TurnOff()
        {
            WriteLine("Телевізор вимкнено.");
        }

        public void SetChannel(int channel)
        {
            WriteLine($"Телевізор перемкнено на канал {channel}.");
        }
    }

    public class Radio : IRemoteControl
    {
        public void TurnOn()
        {
            WriteLine("Радіо увімкнено.");
        }

        public void TurnOff()
        {
            WriteLine("Радіо вимкнено.");
        }

        public void SetChannel(int channel)
        {
            WriteLine($"Радіо налаштовано на хвилю {channel} FM.");
        }
    }
}