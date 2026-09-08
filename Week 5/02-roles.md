---
type: jam-roles
version: 0.1
date: [21/07/2026]
team: [Alphodite] (105,124,126,149,150)
---
# Team Roles & Pipeline Ownership — [Alphodite]

## แบ่งความรับผิดชอบตาม Pipeline (4 คน)

| คน | ชื่อ      | Module ที่รับผิดชอบ         | Phase ที่ต้องเสร็จ |
| ---- | ------------- | --------------------------------------- | ------------------------------ |
| 1    | [105,126,149] | `GameStateManager` + `InputManager` | Hour 4 -7                      |
| 2    | [105,126,149] | Core mechanic `Update()` logic        | Hour 7-19                      |
| 3    | [105,126,149] | Render/`SpriteBatch` + Collision      | Hour 4 -15                     |
| 4    | [105,126,149] | Content pipeline (MGCB) + Audio/UI      | Hour 19 - 29                   |
| 5    | [124,150]     | All art in game                         | Hour 0 - 24                    |

> คนละไฟล์/module = ชนกันน้อยที่สุด ปรับ module ตามตาราง [01-pipeline-checklist.md](01-pipeline-checklist.md) ให้ตรงกับเกมจริงของทีม

## File Ownership Rule

> ไฟล์ที่ต้องแตะร่วมกันบ่อย เช่น `Game1.cs`, ไฟล์ scene หลัก — ตกลงล่วงหน้าว่าใครแก้ก่อน-หลัง เพื่อลด merge conflict

| ไฟล์/พื้นที่ที่เสี่ยงชนกัน | เจ้าของหลัก | กติกาการแก้ไข                                               |
| --------------------------------------------------- | ---------------------- | ------------------------------------------------------------------------ |
| `Game1.cs`                                        | [149]                  | คนอื่นแจ้งใน chat ก่อนแก้ แล้ว pull ก่อน push |
| [link drive for art]                                | [124]                  | เมื่อเพิ่มงานตรงกับโฟเดอร์นั้น ๆ          |
| [coming soon]                                       | [coming soon]          | [coming soon]                                                            |

## เมื่อคนใดคนหนึ่งเสร็จงานตัวเองก่อน

- ลำดับความช่วยเหลือถัดไป: [เช่น ไปช่วย QA/playtest → ไปช่วย content → ไปช่วย polish]
- [กติกาเพิ่มเติมของทีม]
