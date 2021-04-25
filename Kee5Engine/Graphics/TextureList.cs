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

            LoadTexture("Sprites/Cards/Income/Actor.png", "Actor");
            LoadTexture("Sprites/Cards/Income/Artist.png", "Artist");
            LoadTexture("Sprites/Cards/Income/Astrophysicist.png", "Astrophysicist");
            LoadTexture("Sprites/Cards/Income/BabySitter.png", "BabySitter");
            LoadTexture("Sprites/Cards/Income/Conman.png", "Conman");
            LoadTexture("Sprites/Cards/Income/Delivery.png", "Delivery");
            LoadTexture("Sprites/Cards/Income/DrugDealer.png", "Drug Dealer");
            LoadTexture("Sprites/Cards/Income/FastFood.png", "FastFood");
            LoadTexture("Sprites/Cards/Income/Hacker.png", "Hacker");
            LoadTexture("Sprites/Cards/Income/Hitman.png", "Hitman");
            LoadTexture("Sprites/Cards/Income/HumanTrafficker.png", "HumanTrafficker");
            LoadTexture("Sprites/Cards/Income/IndieDev.png", "IndieDev");
            LoadTexture("Sprites/Cards/Income/Influencer.png", "Influencer");
            LoadTexture("Sprites/Cards/Income/InstaModel.png", "Insta Model");
            LoadTexture("Sprites/Cards/Income/Intern.png", "Intern");
            LoadTexture("Sprites/Cards/Income/JunDev.png", "JuniorDev");
            LoadTexture("Sprites/Cards/Income/Mucisian.png", "Musician");
            LoadTexture("Sprites/Cards/Income/OnlyFence.png", "Only Fence");
            LoadTexture("Sprites/Cards/Income/Referee.png", "Referee");
            LoadTexture("Sprites/Cards/Income/RiceFarmer.png", "Rice Farmer");
            LoadTexture("Sprites/Cards/Income/Santa.png", "Santa");
            LoadTexture("Sprites/Cards/Income/ShelfStacker.png", "Shelf Stacker");
            LoadTexture("Sprites/Cards/Income/ShopLifter.png", "ShopLifter");
            LoadTexture("Sprites/Cards/Income/Sporter.png", "Sporter");
            LoadTexture("Sprites/Cards/Income/Streamer.png", "Streamer");
            LoadTexture("Sprites/Cards/Income/SugarDaddy.png", "SugarDaddy");
            LoadTexture("Sprites/Cards/Income/TaxiDriver.png", "TaxiDriver");
            LoadTexture("Sprites/Cards/Income/UndeclaredBabySitter.png", "UBabySitter");
            LoadTexture("Sprites/Cards/Income/Writer.png", "Writer");
            LoadTexture("Sprites/Cards/Income/YogaInstructor.png", "YogaInstructor");
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
