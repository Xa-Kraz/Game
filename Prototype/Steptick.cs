using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Steptick
    {
        // 1. เปิด grid ให้ Game1 เข้าถึงได้
        public bool[,] grid = new bool[4, 8];

        // 2. เปลี่ยนเป็น public หรือทำ Getter ให้ Game1 ดึงไปวาดสี UI ได้
        public int[] TacetPowerTrack { get; private set; } = new int[8] { 0, 1, 2, 3, 0, 2, 1, 3 };


        // เพิ่มตัวแปรพวกนี้ลงใน Steptick.cs
        public float TargetPositionX { get; private set; } = 400f;
        public bool IsWinLeft { get; private set; } = false;
        public bool IsWinRight { get; private set; } = false;


        public void OnStepTick(int stepIndex)
        {
            int playerPower = 0;
            for (int r = 0; r < 4; r++)
            {
                if (grid[r, stepIndex] == true) playerPower++;
            }

            int tacetPower = TacetPowerTrack[stepIndex];
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
                    System.Diagnostics.Debug.WriteLine($"Step {stepIndex + 1}: CLASH / PERFECT BLOCK!");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Step {stepIndex + 1}: REST (ฟื้นฟู Stamina)");
                }
            }
        }

        // Helper ฟังก์ชันสำหรับอัปเดตพลังใน Step
        public void TogglePower(int col)
        {
            int currentPower = 0;
            for (int r = 0; r < 4; r++)
            {
                if (grid[r, col]) currentPower++;
            }

            int nextPower = (currentPower + 1) % 4; // วน 0 -> 1 -> 2 -> 3 -> 0

            for (int r = 0; r < 4; r++)
            {
                grid[r, col] = (r < nextPower);
            }

            System.Diagnostics.Debug.WriteLine($"Player Step {col + 1} Power set to: {nextPower}");
        }

        public void UpdateTacetPosition(bool isPressW, bool isPressE)
        {
            int pushForce = -1; // ค่าปกติไหลกลับ

            if (isPressW) pushForce = 4;
            else if (isPressE) pushForce = -4;

            TargetPositionX += pushForce;

            // เช็กขอบจอ Win / Lose (0 กับ 700 ตามโค้ดเพื่อน)
            if (TargetPositionX <= 100) IsWinLeft = true;
            else if (TargetPositionX >= 700) IsWinRight = true;
            else { IsWinLeft = false; IsWinRight = false; }
        }

        // เมื่อกดจังหวะโดนจุด ดึงฟังก์ชันนี้ไปเพิ่มแรงดัน Target
        public void PushTarget(float amount)
        {
            TargetPositionX += amount;
        }

    }
}
