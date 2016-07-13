------------------------------------------------------------------
2D Sky FREE 1.0.5
------------------------------------------------------------------

	2D Sky FREE has low-resolution sprites and demo scene found in 2D Sky.

	Features:

		• Low-res hand-painted sunny sky sprites.
		• Components to control cloud.
		• Use Unity 2D Sprite features, no required for thirdparty 2d frameworks.
		• Realtime self strength background and self auto-tile large cloud for any screen resolution.

		• Support all build player platforms.
		
	Compatible:

		• Unity 4.6.9 or higher.
		• Unity 5.3.2 or higher.

	Note:

		• This package does not contain hi-quality textures and scripts.
		• If you are interested or need them, please visit 2D Sky full version on Unity Asset Store at https://www.assetstore.unity3d.com/en/#!/content/21555

	Please direct any bugs/comments/suggestions to support e-mail (geteamdev@gmail.com).

	Thank you for your support,

	Gold Experience Team
	E-mail: geteamdev@gmail.com
	Website: http://www.ge-team.com

------------------------------------------------------------------
Use demo scene
------------------------------------------------------------------

	1. Open Demo in "2D Sky FREE/Demo/Scenes/2D Sky FREE Demo (960x600px)".
	2. In Hierarchy tab, look for NearCloud, MidCloud, FarCloud objects.
	3. Select any of them, you will see GE2DSkyFREE_CloudFlow component in Inspector tab. GE2DSkyFREE_CloudFlow component does update position of children objects.

			Parameters:

				Camera:			An orthographic camera that renders clouds and background
				Tile:				Enable tile for large cloud
				Behavior:	
					- Flow Mixed Left Right	:	Randomly left/right direction for children
					- Flow to Left:				Children objects move to left, they will repeat from right edge when they get off from screen.
					- Flow to Right:			Children objects move to right, they will repeat from left edge when they get off from screen.
				Min Speed:		Minimum speed of children
				Max Speed:		Maximum speed of children
				Speed Multiplier:	Current speed multiplier

	4. Select an object names Sunny_01_sky.
	5. Look for GE2DSkyFREE_SkyBG component in Inspector tab, this component does resize Sunny_01_sky sprite to strength  fit on screen.

			Parameters:

				Camera:			An orthographic camera that renders clouds and background

------------------------------------------------------------------
Use cloud on your scene
------------------------------------------------------------------
	
	1. Open Demo in "2D Sky FREE/Demo/Scenes/2D Sky FREE Demo (960x600px)".
	2. Look for Sky object, copy it.
	3. Open your scene then paste it into your scene.
	4. Press play, you shoud see Sky and its children active same as in the 2D Sky FREE Demo (960x600px) scene.

------------------------------------------------------------------
Release notes
------------------------------------------------------------------

	Version 1.0.5

		• Add real-time strength capability for background when screen resolution is changed.
		• Add real-time tile capability for large cloud when screen resolution is changed.
		• Add cloud Speed multiplier.
		• Add Full Screen toggle button.
		• Add Settings button and details panels.
		• Fixed GUID conflict with other packages.
		• Rearrange folders.
		• Update Demo scene.
		• Use component in dll instead of scripts.
		• Unity 4.6.9 and higher compatible.
		• Unity 5.3.2 and higher compatible.

	version 1.0 (Initial version, released on Sep 15, 2014)

		• Sunny sky sprites.
		• Scripts to control cloud.
		• Use Unity 2D features, doesn't other 2d frameworks.
		• Supports all player platforms.
		• Unity and Unity Pro compatible.
