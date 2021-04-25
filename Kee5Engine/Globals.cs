using LD48.Audio;
using LD48.Logic;
using LD48.Logic.Cards;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48
{
    /// <summary>
    /// Static class for holding all things that need to be globally accessable
    /// </summary>
    public static class Globals
    {
        public static Vector2 windowSize;
        public static List<Button> activeButtons = new List<Button>();
        public static GameHandler gameHandler;
        public static Card cardSelected = null;
        public static Random r = new Random();

        public static int unloaded;

        /// <summary>
        /// Update the active buttons and the AudioManager
        /// </summary>
        public static void Update(double delta)
        {
            AudioManager.Update();
            gameHandler.Update(delta);
        }

        /// <summary>
        /// Draw the active buttons
        /// </summary>
        public static void Draw()
        {
            gameHandler.Draw();
        }
    }
}
