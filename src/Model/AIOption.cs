﻿/// <summary>
/// The different AI levels.
/// </summary>

namespace Battleships2
{
    public enum AIOption
    {
        /// <summary>
    /// Easy, total random shooting
    /// </summary>
        Easy,

        /// <summary>
    /// Medium, marks squares around hits
    /// </summary>
        Medium,

        /// <summary>
    /// As medium, but removes shots once it misses
    /// </summary>
        Hard
    }
}