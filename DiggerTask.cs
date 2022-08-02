using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digger
{
    class Terrain : ICreature
    {
        public CreatureCommand Act(int x, int y) =>
            new CreatureCommand() { DeltaX = 0, DeltaY = 0, TransformTo = this };

        public bool DeadInConflict(ICreature conflictedObject) => conflictedObject is Player;

        public int GetDrawingPriority() => 998;

        public string GetImageFileName() => "Terrain.png";
    }

    class Player:ICreature
    {
        public string GetImageFileName() => "Digger.png";

        public int GetDrawingPriority() => 0;

        public CreatureCommand Act(int x, int y)
        {
            var command = new CreatureCommand() { DeltaX = 0, DeltaY = 0, TransformTo = this };
            switch (Game.KeyPressed)
            {
                case Keys.Up:
                    command.DeltaY = -1;
                    break;
                case Keys.Down:
                    command.DeltaY = 1;
                    break;
                case Keys.Left:
                    command.DeltaX = -1;
                    break;
                case Keys.Right:
                    command.DeltaX = 1;
                    break;
                default:
                    break;
            }
            if (!CanGoTo(x + command.DeltaX, y + command.DeltaY)) command.DeltaX = command.DeltaY = 0;
            return command;
        }

        private bool CanGoTo(int x, int y)
        {
            if (x < 0 || y < 0 || Game.MapWidth <= x || Game.MapHeight <= y) return false;
            return true;
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return false;
        }
    }

}
