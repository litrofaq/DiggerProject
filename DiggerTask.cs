using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digger
{
    class Terrain : ICreature
    {
        public CreatureCommand Act(int x, int y) =>
            new CreatureCommand() { DeltaX = 0, DeltaY = 0, TransformTo = this };

        public bool DeadInConflict(ICreature conflictedObject)
        {
            throw new NotImplementedException();
        }

        public int GetDrawingPriority() => 0;

        public string GetImageFileName() => "Terrain.png";
    }

}
