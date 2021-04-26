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
            LoadTexture("Sprites/Cards/Income/UndeclaredBabySitter.png", "BabySitter");
            LoadTexture("Sprites/Cards/Income/Actor.png", "Actor");
            LoadTexture("Sprites/Cards/Income/Artist.png", "Artist");
            LoadTexture("Sprites/Cards/Income/Astrophysicist.png", "Astrophysicist");
            LoadTexture("Sprites/Cards/Income/BabySitter.png", "BabySitter");
            LoadTexture("Sprites/Cards/Income/BusDriver.png", "Bus Driver");
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
            LoadTexture("Sprites/Cards/Income/Intern.png", "Intern Dev");
            LoadTexture("Sprites/Cards/Income/JunDev.png", "Junior Dev");
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
            LoadTexture("Sprites/Cards/Income/UndeclaredBabySitter.png", "BabySitter (undeclared)");
            LoadTexture("Sprites/Cards/Income/Writer.png", "Writer");
            LoadTexture("Sprites/Cards/Income/YogaInstructor.png", "YogaInstructor");

            LoadTexture("Sprites/Cards/Addiction/Alcohol.png", "Alcohol");
            LoadTexture("Sprites/Cards/Addiction/Drugs.png", "Drugs");
            LoadTexture("Sprites/Cards/Addiction/EatingOut.png", "EatingOut");
            LoadTexture("Sprites/Cards/Addiction/FastFoodAdd.png", "FastFoodAddiction");
            LoadTexture("Sprites/Cards/Addiction/Gambling.png", "Gambling");
            LoadTexture("Sprites/Cards/Addiction/Gaming.png", "Gaming");
            LoadTexture("Sprites/Cards/Addiction/Kleptomania.png", "Kleptomania");
            LoadTexture("Sprites/Cards/Addiction/Shopping.png", "Shopping");
            LoadTexture("Sprites/Cards/Addiction/Smoking.png", "Smoking");
            LoadTexture("Sprites/Cards/Addiction/SocialMedia.png", "Social Media");
            LoadTexture("Sprites/Cards/Addiction/Streaming.png", "Streaming");
            LoadTexture("Sprites/Cards/Addiction/Pyromania.png", "Pyromania");
            LoadTexture("Sprites/Cards/Addiction/Pom_xml.png", "Pom.XML");

            LoadTexture("Sprites/Cards/Collectable/Beef.png", "Beef");
            LoadTexture("Sprites/Cards/Collectable/Betting.png", "Betting");
            LoadTexture("Sprites/Cards/Collectable/Bitterballen.png", "Bitterballen");
            LoadTexture("Sprites/Cards/Collectable/Blackjack.png", "BlackJack");
            LoadTexture("Sprites/Cards/Collectable/Bratwurst.png", "Bratwurst");
            LoadTexture("Sprites/Cards/Collectable/Cable.png", "Cable");
            LoadTexture("Sprites/Cards/Collectable/Calendar.png", "Calendar");
            LoadTexture("Sprites/Cards/Collectable/Carpaccio.png", "Carpaccio");
            LoadTexture("Sprites/Cards/Collectable/Champagne.png", "Champagne");
            LoadTexture("Sprites/Cards/Collectable/Cigar.png", "Cigar");
            LoadTexture("Sprites/Cards/Collectable/Cigarette.png", "Cigarette");
            LoadTexture("Sprites/Cards/Collectable/Clothes.png", "Clothes");
            LoadTexture("Sprites/Cards/Collectable/Cocain.png", "Cocain");
            LoadTexture("Sprites/Cards/Collectable/Dasnyplus.png", "Dasnyplus");
            LoadTexture("Sprites/Cards/Collectable/Doner.png", "Döner");
            LoadTexture("Sprites/Cards/Collectable/DonkeyKong.png", "DonkeyKong");
            LoadTexture("Sprites/Cards/Collectable/Drugs.png", "Drugs");
            LoadTexture("Sprites/Cards/Collectable/Fries.png", "Fries");
            LoadTexture("Sprites/Cards/Collectable/Frikadel.png", "Frikadel");
            LoadTexture("Sprites/Cards/Collectable/Fakebook.png", "Fakebook");
            LoadTexture("Sprites/Cards/Collectable/Hamburger.png", "Hamburger");
            LoadTexture("Sprites/Cards/Collectable/Heroin.png", "Heroin");
            LoadTexture("Sprites/Cards/Collectable/H-Haven.png", "H-Haven");
            LoadTexture("Sprites/Cards/Collectable/Hooloo.png", "Hooloo");
            LoadTexture("Sprites/Cards/Collectable/Huves.png", "Huves");
            LoadTexture("Sprites/Cards/Collectable/Instagrem.png", "Instagrem");
            LoadTexture("Sprites/Cards/Collectable/Jewelry.png", "Jewelry");
            LoadTexture("Sprites/Cards/Collectable/Jonko.png", "Jonko");
            LoadTexture("Sprites/Cards/Collectable/Kaasouffle.png", "Kaassouffle");
            LoadTexture("Sprites/Cards/Collectable/Ketamine.png", "Ketamine");
            LoadTexture("Sprites/Cards/Collectable/Lasagne.png", "Lasagne");
            LoadTexture("Sprites/Cards/Collectable/Lottery.png", "Lottery");
            LoadTexture("Sprites/Cards/Collectable/Magazine.png", "Magazine");
            LoadTexture("Sprites/Cards/Collectable/Mario.png", "Mario");
            LoadTexture("Sprites/Cards/Collectable/MDMA.png", "MDMA");
            LoadTexture("Sprites/Cards/Collectable/Meth.png", "Meth");
            LoadTexture("Sprites/Cards/Collectable/Nederwiet.png", "Nederwiet");
            LoadTexture("Sprites/Cards/Collectable/Netflux.png", "Netflux");
            LoadTexture("Sprites/Cards/Collectable/OFSub.png", "OFSub");
            LoadTexture("Sprites/Cards/Collectable/OurTube.png", "Ourtube");
            LoadTexture("Sprites/Cards/Collectable/Pacman.png", "Pacman");
            LoadTexture("Sprites/Cards/Collectable/Phone.png", "Phone");
            LoadTexture("Sprites/Cards/Collectable/Pipe.png", "Pipe");
            LoadTexture("Sprites/Cards/Collectable/Pizza.png", "Pizza");
            LoadTexture("Sprites/Cards/Collectable/pokebowl.png", "Pokebowl");
            LoadTexture("Sprites/Cards/Collectable/Poker.png", "Poker");
            LoadTexture("Sprites/Cards/Collectable/pomsub.png", "Pomsub");
            LoadTexture("Sprites/Cards/Collectable/Port.png", "Port");
            LoadTexture("Sprites/Cards/Collectable/Reddit.png", "Reddit");
            LoadTexture("Sprites/Cards/Collectable/Risotto.png", "Risotto");
            LoadTexture("Sprites/Cards/Collectable/Roulette.png", "Roulette");
            LoadTexture("Sprites/Cards/Collectable/Rum.png", "Rum");
            LoadTexture("Sprites/Cards/Collectable/Salad.png", "Salad");
            LoadTexture("Sprites/Cards/Collectable/Shoes.png", "Shoes");
            LoadTexture("Sprites/Cards/Collectable/Slots.png", "Slotmachines");
            LoadTexture("Sprites/Cards/Collectable/Soda.png", "Soda");
            LoadTexture("Sprites/Cards/Collectable/Soup.png", "Soup");
            LoadTexture("Sprites/Cards/Collectable/SpaceInvaders.png", "SpaceInvaders");
            LoadTexture("Sprites/Cards/Collectable/Speed.png", "Speed");
            LoadTexture("Sprites/Cards/Collectable/Tablet.png", "Tablets");
            LoadTexture("Sprites/Cards/Collectable/Tetris.png", "Tetris");
            LoadTexture("Sprites/Cards/Collectable/TikToc.png", "TikToc");
            LoadTexture("Sprites/Cards/Collectable/Tweeter.png", "Tweeter");
            LoadTexture("Sprites/Cards/Collectable/Vape.png", "Vape");
            LoadTexture("Sprites/Cards/Collectable/Vodka.png", "Vodka");
            LoadTexture("Sprites/Cards/Collectable/Watch.png", "Watches");
            LoadTexture("Sprites/Cards/Collectable/Whiskey.png", "Whiskey");
            LoadTexture("Sprites/Cards/Collectable/Wine.png", "Wine");
            LoadTexture("Sprites/Cards/Collectable/Feiv.png", "Feiv");


            LoadTexture("Sprites/Cards/EventCard.png", "EventCard");

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
