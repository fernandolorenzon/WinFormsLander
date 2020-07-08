using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLander
{
    public class Enum
    {
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right,
        }

        public enum Axis
        {
            Vertical,
            Horizontal,
            All
        }

        public enum Ships
        {            
            Type01,
            Type02,
            Type03,
            Type04,
            Type05,
            Type06,
            Type07,
            Type08,
            Type09,
            TypeX1,
        }

        public enum Sounds
        {
            Rocket,
            Float,
            Special,
            Selected,
            Explosion,
        }

        public enum RecordType
        {
            SelectedShip,
            UnlockedArea,
            OreCollected,
        }

        public enum GameType
        {
            Arcade,
            OreColleting,
            Free,
        }
    }
}
