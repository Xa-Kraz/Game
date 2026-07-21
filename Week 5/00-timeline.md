---
type: jam-timeline
version: 0.1
date: [21/7/2026]
team: [Alphodite] [105,124,126,149,150]
---
# 48-Hour Timeline — [Alphodite]

| หัวข้อ                             | รายละเอียด         |
| ---------------------------------------- | ---------------------------- |
| Time Keeper                              | [105]                        |
| Jam เริ่มจริง (วัน-เวลา) | [ศ. 24 ก.ค. 2569 18:00]   |
| Deadline ส่งงาน (วัน-เวลา)  | [อา. 26 ก.ค. 2569 15:00] |

> คำนวณ "เวลาจริง" ของแต่ละ Phase จาก **เวลาที่ Jam เริ่มจริง** ด้านบน แล้วเติมในคอลัมน์ขวาสุด — ใช้ตารางนี้เป็นจุดอ้างอิงเดียวของทีมตลอด 48 ชม.

| Phase                                       | ช่วง (Hour) | เวลาจริง (Hour 0 = เวลาเริ่ม Jam) | เป้าหมาย / Deliverable                                                                   | สถานะ | เวลาจริงที่เสร็จ |
| ------------------------------------------- | --------------- | -------------------------------------------------- | ------------------------------------------------------------------------------------------------ | ---------- | -------------------------------- |
| 0. Kickoff & Ideation                       | 0–2            | [0] – [2]                                         | รู้ theme, brainstorm, ล็อกคอนเซปต์ + core loop 1 บรรทัด                    | ✅         |                                  |
| 1. Planning & Setup                         | 2–4            | [2] – [4]                                         | GDD one-pager, ตกลง pipeline, ตั้ง repo, แบ่งงาน                                  | ✅         |                                  |
| 2. Core Pipeline & Skeleton                 | 4–7            | [4] – [12]                                        | Game loop โครงหลักรันได้ (state, input, render ว่างเปล่า)                 | ✅         |                                  |
| 3. Core Mechanic                            | 7–19           | [7] – [19]                                        | กลไกหลักเล่นได้จริง 1 อย่าง —**Playable Build Checkpoint**        | ✅         |                                  |
| 4. Content & Feature Build-out              | 19–29          | [19] – [29]                                       | ด่าน/เนื้อหา, UI/HUD, เสียง, กลไกรอง                                      | 🔲         |                                  |
| 5. 🔒 Feature Freeze                        | ที่ Hour 29  | [29]                                               | **ห้ามเพิ่ม feature ใหม่หลังจุดนี้** ทุกคน merge เข้า main | 🔲         |                                  |
| 6. Polish & Bugfix                          | 31–38          | [31] – [38]                                       | แก้บั๊ก, ปรับ balance, juice/feedback เล็กๆ                                      | 🔲         |                                  |
| 7. Testing (คนนอกทีมลองเล่น) | 38–41          | [38] – [41]                                       | playtest, จด bug ที่เหลือ, แก้เฉพาะตัวที่ critical                       | 🔲         |                                  |
| 8. Build & Package                          | 41–45          | [41] – [45]                                       | สร้าง build จริง, ทดสอบบนเครื่องอื่น, เตรียมหน้า submission | 🔲         |                                  |
| 9. Buffer & Submit                          | 45–48          | [45] – [48]                                       | เผื่อเวลาหน้างาน, ส่งงานก่อนเวลาอย่างน้อย 15 นาที     | 🔲         |                                  |

```mermaid
gantt
    title Game Jam 48 ชั่วโมง — [ชื่อทีม]
    dateFormat  X
    axisFormat %s h
    section Plan
    Kickoff & Ideation        :0, 2h
    Planning & Setup          :2, 2h
    section Build
    Core Pipeline & Skeleton  :4, 3h
    Core Mechanic (Playable @24h) :7, 12h
    Content & Feature Build-out :18, 10h
    section Ship
    Polish & Bugfix           :31, 7h
    Testing                   :38, 3h
    Build & Package           :41, 4h
    Buffer & Submit           :45, 3h
```

## กติกา Checkpoint

- ถ้าถึงเวลาใน Phase ใดแล้วยังไม่เสร็จ → **Time Keeper** เรียกประชุมด่วน (ไม่เกิน 5 นาที) เพื่อตัด scope ทันที ตาม cut-list ใน [01-pipeline-checklist.md](01-pipeline-checklist.md)
- ห้ามปล่อยให้ Phase ที่ล่าช้าลากยาวไปกระทบ Phase ถัดไปเกิน [1 ชม.]
- อัปเดตคอลัมน์ "สถานะ" และ "เวลาจริงที่เสร็จ" ทุกครั้งที่ปิด Phase เพื่อให้ทั้งทีมเห็นความคืบหน้าตรงกัน
