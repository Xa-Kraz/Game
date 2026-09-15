using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Prototype
{
    public class Game1 : Game
    {
        private Steptick _stepSystem;
        private SpriteFont _font;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private int _currentStep = 0;
        private float _bpm = 120f;
        private float _stepTimer = 0f;
        private float _stepInterval;
        private Texture2D _pixel;
        private Texture2D _triangleTexture;

        private int startX = 250;
        private int startY = 25;
        private int cellSize = 30;
        private int padding = 5;
        private MouseState _previousMouse;

        private float scannerX;

        // --- ตัวแปรสำหรับระบบ Tug-of-War ---
        private float _tugOfWarPos;
        private float _barStartX = 0f;    // ให้เริ่มจากขอบซ้ายสุด (0)
        private float _barEndX;           // ขอบขวาสุด (กว้างเต็มจอ)
        private float _pushForce = 20f;   // แรงดันต่อ 1 แต้มที่ต่างกัน

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _stepSystem = new Steptick();
            _stepInterval = 60f / _bpm / 2f;

            _stepSystem.grid[0, 0] = true;
            _stepSystem.grid[0, 4] = true;
            _stepSystem.grid[2, 0] = true;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _font = Content.Load<SpriteFont>("Arseky");

            _pixel = new Texture2D(GraphicsDevice, 1, 1);
            _pixel.SetData(new Color[] { Color.White });

            // ดึงความกว้างจริงของหน้าจอมาใช้เต็มๆ
            _barEndX = GraphicsDevice.Viewport.Width;

            // ให้จุดกึ่งกลางเริ่มต้นอยู่กลางจอพอดีเป๊ะ
            _tugOfWarPos = _barEndX / 2f;

            int triSize = 16;
            _triangleTexture = new Texture2D(GraphicsDevice, triSize, triSize);
            Color[] colorData = new Color[triSize * triSize];

            for (int y = 0; y < triSize; y++)
            {
                int rowWidth = y;
                int leftX = (triSize / 2) - (rowWidth / 2);
                int rightX = (triSize / 2) + (rowWidth / 2);

                for (int x = 0; x < triSize; x++)
                {
                    if (x >= leftX && x <= rightX)
                        colorData[y * triSize + x] = Color.White;
                    else
                        colorData[y * triSize + x] = Color.Transparent;
                }
            }
            _triangleTexture.SetData(colorData);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState keyboard = Keyboard.GetState();
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            _stepSystem.UpdateTacetPosition(keyboard.IsKeyDown(Keys.W), keyboard.IsKeyDown(Keys.E));

            // --- 2. ระบบจังหวะเมโทรโนม และ การปะทะ (Clash) ---
            _stepTimer += deltaTime;
            if (_stepTimer >= _stepInterval)
            {
                _stepTimer -= _stepInterval;
                _currentStep = (_currentStep + 1) % 8;

                // เรียก OnStepTick
                _stepSystem.OnStepTick(_currentStep);

                // --------------------------------------------------
                // คำนวณระบบดึงเย่อ (Tug-of-War Clash)
                // --------------------------------------------------
                // 1. นับพลัง Player ในช่องปัจจุบัน
                int playerPower = 0;
                for (int r = 0; r < 4; r++)
                {
                    if (_stepSystem.grid[r, _currentStep] == true) playerPower++;
                }

                // 2. ดึงพลัง Tacet ในช่องปัจจุบัน
                int tacetPower = _stepSystem.TacetPowerTrack[_currentStep];

                // 3. หาส่วนต่าง (Player ชนะได้บวก / Tacet ชนะได้ลบ)
                int difference = playerPower - tacetPower;

                // 4. ดันมาร์คเกอร์ (Player ฝั่งซ้ายดันไปขวา [+] / Tacet ฝั่งขวาดันมาซ้าย [-])
                _tugOfWarPos += (difference * _pushForce);

                // 5. ล็อกไม่ให้มาร์คเกอร์ทะลุขอบจอ (จำกัดเขตไว้ที่ฐานซ้าย-ขวา)
                _tugOfWarPos = Math.Clamp(_tugOfWarPos, _barStartX, _barEndX);
                // --------------------------------------------------
            }

            scannerX = startX + (_currentStep * (cellSize + padding)) + (cellSize / 2f);

            // --- ระบบอ่าน Input เมาส์ ---
            MouseState currentMouse = Mouse.GetState();
            if (currentMouse.LeftButton == ButtonState.Released && _previousMouse.LeftButton == ButtonState.Pressed)
            {
                int mouseX = currentMouse.X;
                int mouseY = currentMouse.Y;

                for (int c = 0; c < 8; c++)
                {
                    int x = startX + c * (cellSize + padding);
                    int y = startY;

                    Rectangle cellBounds = new Rectangle(x, y, cellSize, cellSize);

                    if (cellBounds.Contains(mouseX, mouseY))
                    {
                        _stepSystem.TogglePower(c);
                        break;
                    }
                }
            }

            _previousMouse = currentMouse;
            base.Update(gameTime);
        }

        private void DrawSolidRectangle(Rectangle rect, Color color)
        {
            _spriteBatch.Draw(_pixel, rect, color);
        }


        protected override void Draw(GameTime gameTime)
        {
            // ล้างจอด้วยสีเทาก่อน (แต่จะโดนสีขาวดำทับมิดอยู่ดี)
            GraphicsDevice.Clear(Color.DarkSlateGray);
            _spriteBatch.Begin();
            

            // =======================================================
            // --- วาดพื้นหลัง ดึงเย่อ (Tug-of-War) ขาว-ดำ เต็มจอ ---
            // =======================================================
            int screenHeight = GraphicsDevice.Viewport.Height;
            int leftWidth = (int)_tugOfWarPos;
            int rightWidth = (int)(_barEndX - _tugOfWarPos);

            // 1. วาดพื้นหลังฝั่งซ้าย Player (สีขาว)
            _spriteBatch.Draw(_pixel, new Rectangle(0, 0, leftWidth, screenHeight), Color.White);

            // 2. วาดพื้นหลังฝั่งขวา Tacet (สีดำ)
            _spriteBatch.Draw(_pixel, new Rectangle((int)_tugOfWarPos, 0, rightWidth, screenHeight), Color.Black);
            // =======================================================

            // ตัวอย่างการวาดสี่เหลี่ยมทึบสีน้ำเงิน กว้าง 100 สูง 50
            Rectangle Rect1 = new Rectangle(0, 150, 100, 400);
            DrawSolidRectangle(Rect1, Color.LightGray); // แอบคูณ 0.5f ให้โปร่งแสงได้ด้วย

            Rectangle Rect2 = new Rectangle(100, 200, 100, 400);
            DrawSolidRectangle(Rect2, Color.DarkGray); // แอบคูณ 0.5f ให้โปร่งแสงได้ด้วย

            Rectangle Rect3 = new Rectangle(200, 250, 100, 400);
            DrawSolidRectangle(Rect3, Color.Gray); // แอบคูณ 0.5f ให้โปร่งแสงได้ด้วย

            // --- วาด UI ของ Steptick (8 ช่อง) ---
            for (int c = 0; c < 8; c++)
            {
                // แถวที่ 1: Player UI
                int activeCount = 0;
                for (int r = 0; r < 4; r++)
                {
                    if (_stepSystem.grid[r, c] == true) activeCount++;
                }

                int playerX = startX + c * (cellSize + padding);
                int playerY = startY;

                _spriteBatch.Draw(_pixel, new Rectangle(playerX, playerY, cellSize, cellSize), Color.DimGray);

                if (activeCount > 0)
                {
                    string text = activeCount.ToString();
                    Vector2 textSize = _font.MeasureString(text);
                    Vector2 origin = textSize / 2f;
                    Vector2 boxCenter = new Vector2(playerX + (cellSize / 2f), playerY + (cellSize / 2f));

                    // ปรับสีตัวอักษรนิดหน่อย เผื่อกลืนไปกับพื้นหลังสีขาว
                    _spriteBatch.DrawString(_font, text, boxCenter, Color.LightGreen, 0f, origin, 1f, SpriteEffects.None, 0f);
                }

                // แถวที่ 2: TACET UI 
                int tacetY = startY + (cellSize + padding);
                Color tacetColor;
                switch (_stepSystem.TacetPowerTrack[c])
                {
                    case 1: tacetColor = Color.LightCoral; break;
                    case 2: tacetColor = Color.Red; break;
                    case 3: tacetColor = Color.DarkRed; break;
                    default: tacetColor = Color.DimGray; break;
                }
                _spriteBatch.Draw(_pixel, new Rectangle(playerX, tacetY, cellSize, cellSize), tacetColor);
            }

            // --- วาดสามเหลี่ยมตัวชี้จังหวะ Metronome (▲) ---
            int metronomeY = startY + (2 * (cellSize + padding)) + 5;
            Vector2 trianglePos = new Vector2(scannerX - (_triangleTexture.Width / 2f), metronomeY);
            // เปลี่ยนสีเข็มเป็นสีแดงอมส้ม จะได้เห็นชัดทั้งบนพื้นขาวและดำ
            _spriteBatch.Draw(_triangleTexture, trianglePos, Color.Green);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
        // วาดสี่เหลี่ยมแบบทึบสี
        
    }

}