<!-- Template เต็มไฟล์สำหรับสร้าง docs/agile/sprint-plan-[NN].md ของ Sprint ไหนก็ได้ -->

<!-- ดึง Story ของ Sprint นี้มาจาก docs/agile/02-sprint-backlog.md -->

<!-- Sprint 1: เปลี่ยนชื่อ sprint-01.md จาก Lab 07 เป็น sprint-plan-01.md แล้วแทนที่เนื้อหาด้วย template นี้ -->

<!-- Sprint 2-4 ในแลปถัดไป: คัดลอกไฟล์นี้ทั้งไฟล์ไปสร้าง sprint-plan-02.md, sprint-plan-03.md, sprint-plan-04.md ตามลำดับ -->

# Sprint 1 Plan

**Sprint Goal:** ทำ core gameplay loop ให้เล่นได้ครบ 1 รัน (เลือกวาทยกร → เลือกเส้นทาง → จัดวง → เขียนโน้ต → ต่อสู้ 8 บีต → สู้บอสท้าย Floor) โดยใช้ art/เสียง placeholder ไปก่อน
**ระยะเวลา:** 2026-09-01 — 2026-09-14
**Team:** [105 124 126 149 150]

> สถานะงานฝั่งโค้ดอ้างอิงจาก repo Tacetno433 (ตรวจ 2026-09-22) ส่วนงาน Art/Sound ที่ไม่อยู่ใน repo ใช้สถานะเดิมที่ทีมกรอกไว้
> Story 7-25 ยังไม่มีผู้รับผิดชอบ — ทีมกรอกเอง / Story 11-25 ยังไม่มี MoSCoW และ SP (รอจัด)

---

## Sprint Backlog

| # | User Story | รับผิดชอบ | MoSCoW | Estimate (SP) | Status |
| - | ---------- | --------- | ------ | ------------- | ------ |
| 1 | ระบบนับจังหวะ 8 ช่องแบบเมโทรโนม | [105 149] | Must Have | 3 | ✅ Done |
| 2 | ระบบดันคะแนนที่อิงจาก 8 ช่อง | [105 149] | Must Have | 2 | ✅ Done |
| 3 | การวางตัวละคร | [105 149] | Must Have | 4 | 🔄 In Progress |
| 4 | Asset Sound & Music | [126] | Must Have | 4 | 🔄 In Progress |
| 5 | Sprite ของนักดนตรี (ตัวละคร) | [124 126 150] | Must Have | 2 | 🔄 In Progress |
| 6 | Art ในเกม | [124 150] | Must Have | 3 | 🔄 In Progress |
| 7 | ตัวละครแต่ละประเภท | [ ] | Should Have | 3 | ✅ Done |
| 8 | UI ในเกม | [ ] | Should Have | 2 | ✅ Done |
| 9 | บัฟต่างๆ ของนักดนตรีแต่ละสาย | [ ] | Should Have | 2 | 🔄 In Progress |
| 10 | บอสในเกม | [ ] | Should Have | 3 | ✅ Done |
| 11 | ระบบเลือกวาทยกร (Conductor) | [ ] | รอจัด | - | ✅ Done |
| 12 | ระบบแผนที่เส้นทาง / Floor | [ ] | รอจัด | - | ✅ Done |
| 13 | ระบบเลือกยุค (Era) | [ ] | รอจัด | - | ✅ Done |
| 14 | ระบบรับนักดนตรีเข้าวง (Recruit) | [ ] | รอจัด | - | ✅ Done |
| 15 | ตั้งชื่อวง | [ ] | รอจัด | - | ✅ Done |
| 16 | ระบบเขียนโน้ต (Score) | [ ] | รอจัด | - | ✅ Done |
| 17 | ระบบ QTE + Combo | [ ] | รอจัด | - | ✅ Done |
| 18 | ระบบ Stamina | [ ] | รอจัด | - | ✅ Done |
| 19 | ระบบ Motif (ไอเทมติดตัว) | [ ] | รอจัด | - | ✅ Done |
| 20 | ร้านค้า (Shop) | [ ] | รอจัด | - | ✅ Done |
| 21 | จุดพัก (Rest) | [ ] | รอจัด | - | ✅ Done |
| 22 | ระบบ Event | [ ] | รอจัด | - | ✅ Done |
| 23 | ศัตรูทั่วไปและ Elite | [ ] | รอจัด | - | ✅ Done |
| 24 | หน้าสอนเล่น (Guide) | [ ] | รอจัด | - | ✅ Done |
| 25 | หน้าผลการต่อสู้ + สรุปจบรัน | [ ] | รอจัด | - | ✅ Done |

## Status Legend

- 🔲 Todo
- 🔄 In Progress
- ✅ Done
- ❌ Blocked

---

## Tasks

### Story 1 — [ระบบนับจังหวะ 8 ช่องแบบเมโทรโนม]

- [x] [การนับคะแนน 8 ช่อง]  [owner:: 105]  [estimate:: 3]  [status:: ✅ Done]
- [x] [การหาผลต่าง]  [owner:: 105]  [estimate:: 3]  [status:: ✅ Done]
- [x] [การเติมจังหวะในแต่ละช่อง]  [owner:: 105]  [estimate:: 3]  [status:: ✅ Done]
- [x] [การนับช่อง 8 ช่อง]  [owner:: 105]  [estimate:: 3]  [status:: ✅ Done]
- [x] [การดึงโค้ดมาจาก class การวางตัวละคร]  [owner:: 105]  [estimate:: 3]  [status:: ✅ Done]

### Story 2 — [ระบบดันคะแนนที่อิงจาก 8 ช่อง]

- [x] [การดึงโค้ดมาจาก class ระบบดันคะแนนที่อิงจาก 8 ช่อง]  [owner:: 149]  [estimate:: 2]  [status:: ✅ Done]
- [x] [ดันกันจนมีฝ่ายใดฝ่ายหนึ่งชนะ]  [owner:: 149]  [estimate:: 2]  [status:: ✅ Done]

### Story 3 — [การวางตัวละคร]

- [x] [ตัวละครเครื่องสาย]  [owner:: 105.149]  [estimate:: 4]  [status:: ✅ Done]
- [x] [ตัวละครเครื่องตี]  [owner:: 105.149]  [estimate:: 4]  [status:: ✅ Done]
- [x] [ตัวละครเครื่องเป่า]  [owner:: 105.149]  [estimate:: 4]  [status:: ✅ Done]
- [x] [ตัวละครจากวัฒนธรรมที่ 1 (EUROPEAN)]  [owner:: 105.149]  [estimate:: 4]  [status:: ✅ Done]
- [x] [ตัวละครจากวัฒนธรรมที่ 2 (SIAM)]  [owner:: 105.149]  [estimate:: 4]  [status:: ✅ Done]
- [ ] [ตัวละครจากวัฒนธรรมที่ 3]  [owner:: 105.149]  [estimate:: 4]  [status:: 🔲 Todo]  — ในโค้ดมี 3 ยุค แต่ยุค ROMANTIC ใช้ Culture = EUROPEAN ซ้ำกับยุค CLASSICAL
- [x] [ระบบวางที่นั่ง 9 ที่ 3 แถว + ม้านั่งสำรอง]  [owner:: 105.149]  [estimate:: 4]  [status:: ✅ Done]

### Story 4 — [Asset Sound & Music]

- [x] [ระบบเสียง SoundBank + จุดเรียกเสียงครบทุกหน้า]  [owner:: ]  [estimate:: 4]  [status:: ✅ Done]
- [ ] [Song 1]  [owner:: 126]  [estimate:: 4]  [status:: 🔄 In Progress]
- [ ] [Song 2]  [owner:: 126]  [estimate:: 4]  [status:: 🔲 Todo]
- [ ] [Song 3]  [owner:: 126]  [estimate:: 4]  [status:: 🔲 Todo]
- [ ] [Song 4]  [owner:: 126]  [estimate:: 4]  [status:: 🔲 Todo]

### Story 5 — [Sprite ของนักดนตรี (ตัวละคร)]

- [x] [Placeholder นักดนตรีวาดด้วยโค้ด (MusicianArt)]  [owner:: ]  [estimate:: 2]  [status:: ✅ Done]
- [ ] [Musician 1]  [owner:: 124]  [estimate:: 2]  [status:: 🔲 Todo]
- [ ] [Musician 2]  [owner:: 124]  [estimate:: 2]  [status:: 🔲 Todo]
- [ ] [Musician 3]  [owner:: 124]  [estimate:: 2]  [status:: 🔲 Todo]
- [ ] [Musician 4]  [owner:: 150]  [estimate:: 2]  [status:: 🔲 Todo]
- [ ] [Musician 5]  [owner:: 150]  [estimate:: 2]  [status:: 🔲 Todo]
- [ ] [Musician 6]  [owner:: 150]  [estimate:: 2]  [status:: 🔲 Todo]

### Story 6 — [Art ในเกม]

- [x] [Placeholder ฉากหลังแต่ละยุควาดด้วยโค้ด (EraBackdrop, SceneBackdrop)]  [owner:: ]  [estimate:: 3]  [status:: ✅ Done]
- [ ] [BG]  [owner:: 150]  [estimate:: 3]  [status:: 🔄 In Progress]
- [ ] [dmg bar]  [owner:: 124]  [estimate:: 3]  [status:: 🔄 In Progress]
- [ ] [ui]  [owner:: 150]  [estimate:: 3]  [status:: 🔄 In Progress]
- [ ] [note]  [owner:: 124]  [estimate:: 3]  [status:: 🔄 In Progress]

### Story 7 — [ตัวละครแต่ละประเภท]

- [x] [แบ่งประเภท String / Wind / Percussion]  [owner:: ]  [estimate:: 3]  [status:: ✅ Done]
- [x] [นักดนตรี 9 คน ใน 3 ยุค (ยุคละ 3 ประเภท)]  [owner:: ]  [estimate:: 3]  [status:: ✅ Done]
- [x] [ค่าพลัง / ค่า stamina ต่างกันตามประเภท]  [owner:: ]  [estimate:: 3]  [status:: ✅ Done]

### Story 8 — [UI ในเกม]

- [x] [หน้า Title]  [owner:: ]  [estimate:: 2]  [status:: ✅ Done]
- [x] [HUD ระหว่างรัน (RunHud)]  [owner:: ]  [estimate:: 2]  [status:: ✅ Done]
- [x] [ปุ่ม / แผง / ตัวอักษรกลาง (Ui, PanelStrip)]  [owner:: ]  [estimate:: 2]  [status:: ✅ Done]

### Story 9 — [บัฟต่างๆ ของนักดนตรีแต่ละสาย]

- [x] [บัฟตามประเภทผ่าน Motif (ROSIN, SPARE STICKS, REED CASE)]  [owner:: ]  [estimate:: 2]  [status:: ✅ Done]
- [x] [บัฟข้ามวัฒนธรรมของวาทยกร THE FOLK LEADER]  [owner:: ]  [estimate:: 2]  [status:: ✅ Done]
- [ ] [บัฟจากการจัดเครื่องดนตรีเดียวกัน / วัฒนธรรมเดียวกันในวง (ไม่ต้องมี Motif)]  [owner:: ]  [estimate:: 2]  [status:: 🔲 Todo]

### Story 10 — [บอสในเกม]

- [x] [บอส 3 ตัว ยุคละ 1 ตัว]  [owner:: ]  [estimate:: 3]  [status:: ✅ Done]
- [x] [ด่านบอสท้ายแต่ละ Floor]  [owner:: ]  [estimate:: 3]  [status:: ✅ Done]

### Story 11 — [ระบบเลือกวาทยกร (Conductor)]

- [x] [วาทยกร 5 คน พร้อมค่าสถานะและความสามารถพิเศษ]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [หน้าเลือกวาทยกร + หน้ารายละเอียด]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 12 — [ระบบแผนที่เส้นทาง / Floor]

- [x] [สุ่มทางเลือกแต่ละด่าน (Battle / Elite / Event / Shop / Rest / ข้ามยุค)]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [Floor ละ 7-10 ด่าน จบด้วยด่านบอส]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 13 — [ระบบเลือกยุค (Era)]

- [x] [3 ยุค CLASSICAL / SIAM / ROMANTIC]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [เลือกยุคตอนเปิด Floor + ข้ามยุคกลาง Floor]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 14 — [ระบบรับนักดนตรีเข้าวง (Recruit)]

- [x] [สุ่มนักดนตรีจากยุคที่เลือกตอนเปิด Floor]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [โอกาสได้นักดนตรีหลังชนะ Elite]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 15 — [ตั้งชื่อวง]

- [x] [หน้าตั้งชื่อวงตอนเริ่ม Floor แรก]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 16 — [ระบบเขียนโน้ต (Score)]

- [x] [กำหนดว่าที่นั่งไหนเล่นบีตไหน]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [แสดงจังหวะศัตรูล่วงหน้า + คำใบ้แต่ละบีต + stamina ที่จะใช้]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 17 — [ระบบ QTE + Combo]

- [x] [กด F / G / H = Boost / Normal / Ease]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [เกรด Perfect / Good / Miss / Hesitate]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [Combo จาก Perfect ติดกัน]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 18 — [ระบบ Stamina]

- [x] [โน้ตทุกตัวใช้ stamina, บีตเงียบและ Ease คืน stamina]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [stamina หมดแล้วเล่นได้เท่าที่จ่ายไหว]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 19 — [ระบบ Motif (ไอเทมติดตัว)]

- [x] [Motif 15 แบบ 3 ระดับ]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [หน้ารางวัลเลือก Motif 1 ใน 3 หรือรับ Shards]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 20 — [ร้านค้า (Shop)]

- [x] [ซื้อที่นั่งเพิ่ม / ฟื้น stamina / จ้างนักดนตรี / Motif ด้วย Shards]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 21 — [จุดพัก (Rest)]

- [x] [ตัวเลือก Breathe / Rehearse / Deep Rest]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 22 — [ระบบ Event]

- [x] [เหตุการณ์ 7 แบบ พร้อมตัวเลือก]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [เช็คผลสำเร็จ/ล้มเหลว โบนัสตามประเภทนักดนตรี]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 23 — [ศัตรูทั่วไปและ Elite]

- [x] [ศัตรู Normal 5 ตัว, Elite 2 ตัว มีรูปแบบจังหวะของตัวเอง]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [ความแรงเพิ่มตาม Floor]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 24 — [หน้าสอนเล่น (Guide)]

- [x] [คู่มือ 5 หน้า ROUTE / STAGE / SCORE / DUEL / LINE]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

### Story 25 — [หน้าผลการต่อสู้ + สรุปจบรัน]

- [x] [หน้าผลชนะ/แพ้ + แจกรางวัล]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]
- [x] [หน้า Curtain Call สรุปสถิติทั้งรัน]  [owner:: ]  [estimate:: -]  [status:: ✅ Done]

---

## Daily Notes

### [วันที่]

**เมื่อวาน:** ...การดึงโค้ดมาจาก class ระบบดันคะแนนที่อิงจาก 8 ช่อง
**วันนี้:** ...การดึงโค้ดมาจาก class การวางตัวละคร
**Blocked:** ...

---

## Links

- [[docs/gdd/00-concept|GDD Concept]]
- [[docs/agile/01-product-backlog|Product Backlog]]
- [[docs/agile/02-sprint-backlog|Sprint Backlog]]
