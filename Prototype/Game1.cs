using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.CompilerServices;



namespace Prototype
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        bool[,] grid = new bool[4, 8];
        private int _currentStep = 0;
        private float _bpm = 120f;
        private float _stepTimer = 0f;
        private float _stepInterval;
        private Texture2D _pixel;

        // ประกาศตัวแปร _tacetPowerTrack แค่รอบเดียวตรงนี้
        private int[] _tacetPowerTrack = new int[8] { 0, 1, 2, 3, 0, 2, 1, 3 };

        int startX = 100;
        int startY = 100;
        int cellSize = 50;
        int padding = 5;
        private MouseState _previousMouse;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _stepInterval = 60f / _bpm / 2f;
            grid = new bool[4, 8];

            grid[0, 0] = true;
            grid[0, 4] = true;
            grid[2, 0] = true;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _pixel = new Texture2D(GraphicsDevice, 1, 1);
            _pixel.SetData(new Color[] { Color.White });
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            _stepTimer += deltaTime;

            if (_stepTimer >= _stepInterval)
            {
                _stepTimer -= _stepInterval;
                _currentStep = (_currentStep + 1) % 8;
                OnStepTick(_currentStep);
            }

            // --- 1. อ่านค่าเมาส์ปัจจุบัน ---
            MouseState currentMouse = Mouse.GetState();

            // --- 2. เช็กการคลิกเมาส์ ---
            if (currentMouse.LeftButton == ButtonState.Released && _previousMouse.LeftButton == ButtonState.Pressed)
            {
                int mouseX = currentMouse.X;
                int mouseY = currentMouse.Y;

                for (int uiRow = 0; uiRow < 2; uiRow++)
                {

                    for (int c = 0; c < 8; c++)
                    {
                        int x = startX + c * (cellSize + padding);
                        int y = startY + uiRow * (cellSize + padding);

                        Rectangle cellBounds = new Rectangle(x, y, cellSize, cellSize);

                        if (cellBounds.Contains(mouseX, mouseY))
                        {
                            if (uiRow == 0)
                            {
                                // 1. นับจำนวนพลัง/โน้ตปัจจุบันของ Player ใน Step นี้ (คอลัมน์ c)
                                int currentPower = 0;
                                for (int r = 0; r < 4; r++)
                                {
                                    if (grid[r, c] == true) currentPower++;
                                }

                                // 2. คำนวณพลังใหม่ (วนลูป 0 -> 1 -> 2 -> 3 -> 0)
                                int nextPower = (currentPower + 1) % 4; // พลังจะไม่เกิน 3 แน่นอน

                                // 3. อัปเดตค่าเข้า grid[r, c] ใน System
                                for (int r = 0; r < 4; r++)
                                {
                                    // เปิดช่องตามจำนวน nextPower (เช่น ถ้า nextPower = 2 จะเปิดแถว 0 และ 1)
                                    grid[r, c] = (r < nextPower);
                                }

                                System.Diagnostics.Debug.WriteLine($"Player Step {c + 1} Power set to: {nextPower}");
                            }
                        }
                        

                    }
                }
            }

            // --- 3. อัปเดตสถานะเมาส์สำหรับเฟรมถัดไป ---
            _previousMouse = currentMouse;

            base.Update(gameTime);
        }

        private void OnStepTick(int stepIndex)
        {
            int playerPower = 0;
            for (int r = 0; r < 4; r++)
            {
                if (grid[r, stepIndex] == true) playerPower++;
            }

            int tacetPower = _tacetPowerTrack[stepIndex];
            int netResult = playerPower - tacetPower;

            if (netResult > 0)
            {
                int playerDamage = netResult;
                System.Diagnostics.Debug.WriteLine($"Step {stepIndex + 1}: Player ชนะ! สวนกลับได้ {playerDamage} ดาเมจ");
            }
            else if (netResult < 0)
            {
                int takenDamage = Math.Abs(netResult);
                System.Diagnostics.Debug.WriteLine($"Step {stepIndex + 1}: Player โดนตี้! เสียเลือด {takenDamage}");
            }
            else
            {
                if (playerPower > 0)
                {
                    System.Diagnostics.Debug.WriteLine($"Step {stepIndex + 1}: CLASH / PERFECT BLOCK! (ไม่เสียเลือดทั้งคู่)");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Step {stepIndex + 1}: REST (ฟื้นฟู Stamina)");
                }
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkSlateGray);
            _spriteBatch.Begin();

            for (int c = 0; c < 8; c++)
            {
                // --- แถวที่ 1: Player UI ---
                int activeCount = 0;
                for (int r = 0; r < 4; r++)
                {
                    if (grid[r, c] == true) activeCount++;
                }

                Color playerColor;
                switch (activeCount)
                {
                    case 1: playerColor = Color.LightGreen; break; // พลัง 1 (เขียวอ่อน)
                    case 2: playerColor = Color.LimeGreen; break; // พลัง 2 (เขียว)
                    case 3: playerColor = Color.Green; break; // พลัง 3 (เขียวเข้ม - พลังเต็ม 3)
                    default: playerColor = Color.DimGray; break; // พลัง 0 (สีเทา)
                }

                int playerY = startY;
                _spriteBatch.Draw(_pixel, new Rectangle(startX + c * (cellSize + padding), playerY, cellSize, cellSize), playerColor);

                // --- แถวที่ 2: TACET UI ---
                int tacetY = startY + (cellSize + padding);
                Color tacetColor;

                switch (_tacetPowerTrack[c])
                {
                    case 1: tacetColor = Color.LightCoral; break; // พลัง 1
                    case 2: tacetColor = Color.Red; break; // พลัง 2
                    case 3: tacetColor = Color.DarkRed; break; // พลัง 3
                    default: tacetColor = Color.DimGray; break; // พลัง 0
                }

                _spriteBatch.Draw(_pixel, new Rectangle(startX + c * (cellSize + padding), tacetY, cellSize, cellSize), tacetColor);
            }

            // --- วาดเข็ม (Needle) ---
            int needleX = startX + _currentStep * (cellSize + padding);
            int needleHeight = 2 * (cellSize + padding);
            _spriteBatch.Draw(_pixel, new Rectangle(needleX, startY, cellSize, needleHeight), Color.Red * 0.4f);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
