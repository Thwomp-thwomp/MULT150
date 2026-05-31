public class Modifications
{/*
    ░▒▓████████▓▒░▒▓█▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓██████▓▒░ ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ */


    // Choose 1 of the games below and list modifications 
    // Delete the other 2 games


    /*  ================================================================
        AMAZING RACER to Michael's "Theres toxic water on da mooooon!"
        ================================================================
        1 - directional light (colour, intensity, etc)
        modifications: changed light color to a redish hue, intensity to 1.5, and indirect multiplier to 1. 

        2 - fog
        modifications: changed fog to linear (start 0, end 20 meters from camera) made it closer to camera but not so it is ever too close to you.Changed fog to a reddish hue to match the directional light. 


        3 - create & apply skybox and customise it (atmosphere thickness, sky tint, exposure, etc)
        modifications: sun size changed it to .145, changed sun size convergence to a lower value 3.65 than before to give it more a halo, changed atmopsphere thickness to .64, as well as changed the sky color to a hazy pink. 
        I wanted to give it an alien-like looking atmopstphere with craters full of water. 
        PLAYER
        4 - create and attach a complex object comprised of 3 or more shapes and make it so that it is visible when the game is played.
        -If you're having trouble coming up with ideas, create a simple figure out of shapes like a Minecraft or Roblox character!
        modifications: made an american flag for our astronaut boy that he holds while expoloring the moon with his roblox lookin arm. 

        5 - use gameobject hierarchy to keep it organised
        [no record necessary]

        FINISH ZONE
        6 - convert to prefab, create 2 variants, and add an instance of each variant around the scene
        modifications: made a flag prefab variant with a yellowish light, made a rocket prefab with a particle system and orange light underneath, put the rocket in a different finish zone under "finish zone 2."

        7 - modify the light component of the variants so that all have a different colour
        [no record necessary]

        8 - add a particle system component to the original prefab and customise at least 3 parameters
        -All instances will update to include the particle system
        -Don't forget to reassign any public fields on the instances to get them to work
        parameter 1: main module: changed start lifetime to give it a smaller life time and keep smoke tight. changed start speed to higher value to give some thrust look, and start size for smaller particles.
        parameter 2: emission module rate over time was changed from 10 to 250+ to increase the amount of particles making it look more like more realistic and elininimate gaps in the smoke. 
        parameter 3: shape module: set shape to cone and radius to .05 to give it a rocket launch look. As a bonus also changed color over lifetime module to start out more white and become light orange later on. 
        TERRAIN
        9 - raise/lower to reshape and make it distinctly different from original
        modifications: got rid of the trees, made more crators of "toxic" water, made mountain range around my terrian higher on the border areas. 

        10 - paint with at least 2 new textures to replace all the textures used in the book
        (add source url or package name)
        texture 1 source: https://assetstore.unity.com/packages/3d/environments/landscapes/lunar-landscape-3d-132614    moon surface (flat areas) Ground_03
        texture 2 source: https://assetstore.unity.com/packages/3d/environments/landscapes/lunar-landscape-3d-132614    moon mountains (meduim to large slopes) Ground 01

        extra: made the astronuats jump look more like a moon jump by decreasing jump speed and lessening the gravity multiplier. 