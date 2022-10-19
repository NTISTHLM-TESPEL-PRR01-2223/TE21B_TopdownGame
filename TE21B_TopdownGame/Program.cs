using Raylib_cs;

Raylib.InitWindow(800, 600, "Mickes awesome spel");
Raylib.SetTargetFPS(60);

Color hotPink = new Color(255, 105, 180, 255);

Rectangle playerRect = new Rectangle(0, 0, 64, 64);
Texture2D avatarImage = Raylib.LoadTexture("avatar.png");

float speed = 5.5f;

while (Raylib.WindowShouldClose() == false)
{
  // Logik

  if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
  {
    playerRect.x += speed;
  }
  else if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
  {
    playerRect.x -= speed;
  }
  if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
  {
    playerRect.y -= speed;
  }
  else if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
  {
    playerRect.y += speed;
  }

  // Grafik
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.WHITE);

  Raylib.DrawTexture(avatarImage,
    (int)playerRect.x,
    (int)playerRect.y,
    Color.WHITE);

  // Raylib.DrawRectangleRec(playerRect, hotPink);
  // Raylib.DrawRectangle(40, 20, 32, 32, hotPink);

  Raylib.EndDrawing();
}