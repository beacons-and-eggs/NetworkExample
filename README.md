# Networking Example

An example of networking using Unity's built-in networking framework.

Player object is a cube and upon pressing **Space** on the keyboard, the player cube fires **bullets**.

**Player object cubes** are spawned on the network upon joining the game.
**Bullets** are spawned on the network, rendered on the client(s), and then destroyed shortly after.

How to use:
-----------
Use the **Unity Editor / Game Mode** as a client/server.
Use **networkTest.exe** as an additional client/server.