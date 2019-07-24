using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace RolePlayingGame.Interfaces
{
    public interface IItem
    {
        string ItemName { get; }
        string Description { get; }
    }
}
