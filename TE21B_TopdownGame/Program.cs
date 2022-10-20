using Raylib_cs;

Raylib.InitWindow(800, 600, "Mickes awesome spel");
Raylib.SetTargetFPS(60);

Color hotPink = new Color(255, 105, 180, 255);



Texture2D avatarImage = Raylib.LoadTexture("avatar.png");
Texture2D bkgImage = Raylib.LoadTexture("background.png");

Rectangle playerRect = new Rectangle(0, 0, avatarImage.width, avatarImage.height);
Rectangle trapRect = new Rectangle(700, 500, 64, 64);

float speed = 5.5f;

string currentScene = "start"; // start, game, end

while (Raylib.WindowShouldClose() == false)
{
  // Logik

  if (currentScene == "game")
  {
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
  
    if (Raylib.CheckCollisionRecs(playerRect, trapRect))
    {
      currentScene = "end";
    }
  }
  else if (currentScene == "start")
  {
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
    {
      currentScene = "game";
    }
  }

  // Grafik
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.WHITE);

  if (currentScene == "game")
  {
    Raylib.DrawTexture(bkgImage, 0, 0, Color.WHITE);

    Raylib.DrawTexture(avatarImage,
      (int)playerRect.x,
      (int)playerRect.y,
      Color.WHITE);

    Raylib.DrawRectangleRec(trapRect, Color.RED);
  }
  else if (currentScene == "start")
  {

    Raylib.DrawText("Press ENTER to start", 50, 560, 50, Color.BLACK);
  }
  else if (currentScene == "end")
  {
    Raylib.DrawText("GAME OVER", 10, 10, 64, Color.RED);
  }

  Raylib.EndDrawing();
}