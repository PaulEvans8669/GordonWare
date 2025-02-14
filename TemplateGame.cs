﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;

namespace GordonWare
{
    class TemplateGame : MiniGame
        ///This is a template class, not used in the game. Feel free to c/c it for your game class
    {
        // Add your local variable with their type here (example : int Speed)
        public TemplateGame()
        {
            // Below is the mandatory stuff for any game
            name = "insert the name of your game here";
            description = "insert description here";
            description_color = Color.Black; // Color of the description/timer, black or white is better
            author = "your name here";
            // insert other variable initialisation here
        }

        public override void Reset()
        {
            // Please add the resetting of your game here, such as new random generation

            base.Reset(); // This calls MiniGame.Reset() to reset other things
        }

        public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            // Okay, here's the kinda tricky part :

            base.LoadContent(Content); // This calls MiniGame.LoadContent() in oreder to load stuff mandatory for every minigame, such as the font.
            
            // Below, load every ressource needed for your game (sounds, pictures, fonts, ...)
            // In order for a ressource to be available, you must :
            //   - create a new fodler with the name of your game in the "Content" folder inside the "GordonWare" folder
            //   - add your ressource inside it
            //   - Open Content.mgcb with the MonoGame Pipeline tool (you must have monogame installed on your computer
            //   - click on "add existing item" (the square with a green + sign on it)
            //   - select every ressource and confirm (you can add new ressources later on without re-adding everything)
            //   - click on "Build" (the arrow pointing downward)
            // Once this is done, you can load any ressource with Content.Load<YourRessourceType>(yourgamename/ressourcename) in this part of the code
            
            // example (a background is mandatory for any game, so you'll have to add a line like this) :
            //background = new Sprite(Content.Load<Texture2D>("templategame/background"));

            // common ressources type are : 
            //   - Texture2D for textures, used in a Sprite constructor as above
            //   - SoundEffects that can be played whenever you want using SoundEffectName.Play()
            //   - SpriteFont to write stuff.
        }
        public override void Update(GameTime gameTime)
        {
            if (game_status == GameStatus.Pending)
            {
                // Main game logic. You can get the input, and interpret it here.
                // You can check win or lose condition and call the base.Win() or base.Lose() function
            }
            else if (game_status == GameStatus.Win)
            {
                // This is mandatory, but you can also allow the player to do something else if he won 
                // (there's a short window of time after win before going to the transition screen)
            }
            else if (game_status == GameStatus.Lose)
            {
                // You can here mock the player for losing for the same short period of time
            }
            base.Update(gameTime); // Calls MiniGame.Update() to update other logic such as timer decreasing, ... Feel free to check it
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            // The final function. Here's where you decide what to display, how to display it and where to display it.
            // Life in the Update function, you can create a seperate draw depending on the game_status parameter if you want.
            // first, you have to draw the background, then everything that's above (from back to front)
            background.TopLeftDraw(spriteBatch, new Vector2(0, 0));

            // PlayerSprite.Draw(spriteBatch, Position);

            base.Draw(spriteBatch); // Above your minigame, the description and timer are drawn so donc forget to call MiniGame.Draw() with this.
        }

        // Please feel free to check the other mini-games class, and to copy some part of it such as how to get keyboard input, mouse input, ...
        // If you want to test your minigame, please go in the Game1 class (main game logic), remove the other minigames in the init function, and add your game.
        // Feel free to contact any member that contributed to ask them question about the code or their game class
        // Good luck :)
    }
}
