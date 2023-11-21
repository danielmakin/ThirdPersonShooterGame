# ThirdPersonShooterGame
A unity 3D Project to create a third person shooter

As of 21/11/2023 : 
* Utilised *PolygonHeist* Models for envirnoment GFX.
* Player uses animation tree for smooth transitions between animations, animation rigging included for Guns.
* Menu has been implemented to allow the user to change their character look (which is then saved for future use).
  * *HeistCharacterSelect.cs*, *SavePlayer.cs*, *ChangePlayerName.cs*
* Load into game and allow weapon PickUp of SMG weapon which can be used as a weapon.
  * *ActiveWeapon.cs*, *WeaponPickup.cs*, *WeaponRecoil.cs*, *Gun.cs*
* AI agent will use NavMesh to follow player and will take damage when gun is shot towards it.
* AI agent will die when zero health is reached.
  * *OnlineModelsURP Y/Assets/Scripts/AI States*

Future Improvements :
* Implement ability to play with friends online using *Photon Unity Networking* package for connection.
* Allow more than one weapon to be picked up.
* Implement a way for the AI agent to attack the player and implement player health.

Notable C# scripts are located in *OnlineModelsURP Y/Assets/Scripts*

Based on tutorial series by *TheKiwiCoder* on YouTube.<br>
