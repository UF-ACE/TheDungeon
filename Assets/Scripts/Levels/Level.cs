using System.Collections;
using System.Collections.Generic;

// Level: Describes a level
public class Level {
    enum Mission { Capture, Assassinate, Steal }
    enum LevelSize { Small, Medium, Large }

    Tileset tileset;
    Mission missionType;
    LevelSize size;

    int enteranceCount;

    // Awards
    int notorityAward, creditAward;
}
