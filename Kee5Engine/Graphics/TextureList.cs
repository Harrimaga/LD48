using OpenTK.Graphics.ES11;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LD48
{
    public class TextureList
    {
        private Dictionary<string, Texture> _textures;

        /// <summary>
        /// Create a List to hold all loaded Textures
        /// </summary>
        public TextureList()
        {
            _textures = new Dictionary<string, Texture>();
            init();
        }

        /// <summary>
        /// Load all the Textures
        /// </summary>
        public void init()
        {
            LoadTexture("Sprites/Test/Test.png", "Test");
            LoadTexture("Sprites/Test/Pixel.png", "Pixel");
            LoadTexture("Sprites/Test/PlayerIdle.png", "PlayerIdle");
            LoadTexture("Sprites/Test/PlatinumEnemyCastCard.png", "TestCard");
            LoadTexture("Sprites/Cards/CardBack.png", "CardBack");
            LoadTexture("Sprites/Cards/Collectable/Beer.png", "Beer");

            LoadTexture("Sprites/Cards/Income/DrugDealer.png", "Drug Dealer");
            LoadTexture("Sprites/Cards/Income/InstaModel.png", "Insta Model");
            LoadTexture("Sprites/Cards/Income/OnlyFence.png", "Only Fence");
            LoadTexture("Sprites/Cards/Income/RiceFarmer.png", "Rice Farmer");
            LoadTexture("Sprites/Cards/Income/ShelfStacker.png", "Shelf Stacker");
        }

        /// <summary>
        /// Loads a texture from a filepath
        /// </summary>
        /// <param name="path">Path to the texture</param>
        /// <param name="name">Name of the texture</param>
        public void LoadTexture(string path, string name)
        {
            Texture texture = Texture.LoadFromFile(path, name);
            if (_textures.ContainsKey(name))
            {
                GL.DeleteTexture(_textures[name].Handle);
            }
            _textures[name] = texture;
        }

        /// <summary>
        /// Loads a texture from a Bitmap
        /// </summary>
        /// <param name="image">Bitmap</param>
        /// <param name="name">Name of the texture</param>
        public Texture LoadTexture(Bitmap image, string name)
        {
            Texture texture = Texture.LoadFromBmp(image, name, false);
            if (_textures.ContainsKey(name))
            {
                GL.DeleteTexture(_textures[name].Handle);
            }
            _textures[name] = texture;
            return texture;
        }

        /// <summary>
        /// Get a loaded texture from a name
        /// </summary>
        /// <param name="name">Name of the texture</param>
        /// <returns><code>Texture</code></returns>
        public Texture GetTexture(string name)
        {
            return _textures[name];
        }

        /// <summary>
        /// Unload all textures from memory
        /// </summary>
        public void UnLoad()
        {
            foreach (Texture texture in _textures.Values)
            {
                Console.WriteLine($"Unloaded {texture.name}");
                GL.DeleteTexture(texture.Handle);
                Globals.unloaded++;
            }
        }

        public bool CheckIfTextureExists(string name)
        {
            return _textures.ContainsKey(name);
        }

    }
}
