<!-- Template เต็มไฟล์สำหรับสร้าง docs/agile/sprint-plan-[NN].md ของ Sprint ไหนก็ได้ -->

<!-- ดึง Story ของ Sprint นี้มาจาก docs/agile/02-sprint-backlog.md -->

<!-- Sprint 1: เปลี่ยนชื่อ sprint-01.md จาก Lab 07 เป็น sprint-plan-01.md แล้วแทนที่เนื้อหาด้วย template นี้ -->

<!-- Sprint 2-4 ในแลปถัดไป: คัดลอกไฟล์นี้ทั้งไฟล์ไปสร้าง sprint-plan-02.md, sprint-plan-03.md, sprint-plan-04.md ตามลำดับ -->

# Sprint [N] Plan

**Sprint Goal:** [เป้าหมายหลักของ Sprint นี้ คือ ทำตามที่วางแผนประมาณ 80%]
**ระยะเวลา:** [วันที่เริ่ม] — [วันที่สิ้นสุด]
**Team:** [105 124 126 149 150]

---

## Sprint Backlog

| # | User Story                                                  | รับผิดชอบ | MoSCoW    | Estimate (SP) | Status         |
| - | ----------------------------------------------------------- | ------------------ | --------- | ------------- | -------------- |
| 1 | ระบบนับจังหวะ 8 ช่องแบบเมโทรโนม | [105 149 ]        | Must Have | 3             | 🔄 In Progress |
| 2 | ระบบดันคะแนนที่อิงจาก 8 ช่อง       | [105 149 ]        | Must Have | 2             | 🔄 In Progress |
| 3 | การวางตัวละคร                                  | [105 149 ]         | Must Have | 4             | 🔄 In Progress |
| 4 | Asset Sound & Music                                         | [ 126 ]            | Must Have | 4             | 🔄 In Progress |
| 5 | Sprite ของนักดนตรี(ตัวละคร)               | [124 126 150]     | Must Have | 2             | 🔄 In Progress |
| 6 | Art ในเกม                                              | [124 150]         | Must Have | 3             | 🔄 In Progress |

## Status Legend

- 🔲 Todo
- 🔄 In Progress
- ✅ Done
- ❌ Blocked

---

## Tasks

### Story 1 — [ระบบนับจังหวะ 8 ช่องแบบเมโทรโนม]

- [ ] [การนับคะแนน 8 ช่อง]  [owner:: 105]  [estimate:: 3]  [status::✅ Done]
- [ ] [การหาผลต่าง]  [owner:: 105]  [estimate:: 3]  [status:: ✅ Done]
- [ ] [การเติมจังหวะในแต่ละช่อง]  [owner:: 105]  [estimate:: 3]  [status::✅ Done]
- [ ] [การนับช่อง 8 ช่อง]  [owner:: 105]  [estimate:: 3]  [status:: ✅ Done]
- [ ] [การดึงโค้ดมาจากclass การวางตัวละคร]  [owner:: 105]  [estimate:: 3]  [status:: 🔄 In Progress]

### Story 2 — [ระบบดันคะแนนที่อิงจาก 8 ช่อง]

- [ ] [การดึงโค้ดมาจากclass ระบบดันคะแนนที่อิงจาก 8 ช่อง]  [owner:: 149]  [estimate:: 2]  [status:: ✅ Done]
- [ ] [ดันกันจนมีฝ่ายใดฝ่ายหนึ่งชนะ]  [owner:: 149]  [estimate:: 2]  [status:: ✅ Done]

### Story 3 — [การวางตัวละคร]

- [ ] [ตัวละครเครื่องสาย]  [owner:: 105.149]  [estimate:: 4]  [status:: 🔲 Todo]
- [ ] [ตัวละครเครื่องตี]  [owner:: 105.149]  [estimate:: 4]  [status:: 🔲 Todo]
- [ ] [ตัวละครเครื่องเป่า]  [owner:: 105.149]  [estimate:: 4]  [status::🔲 Todo]
- [ ] [ตัวละครจาดวรรฒนธรรมที่1]  [owner:: 105.149]  [estimate:: 4]  [status:: 🔲 Todo]
- [ ] [ตัวละครจาดวรรฒนธรรมที่2]  [owner:: 105.149]  [estimate:: 4]  [status:: 🔲 Todo]
- [ ] [ตัวละครจาดวรรฒนธรรมที่3]  [owner:: 105.149]  [estimate:: 4]  [status:: 🔲 Todo]

### Story 4 — [Asset Sound & Music]

- [ ] [Song 1]  [126]  [4]  [🔄 In Progress]
- [ ] [Song 2]  [126]  [4]  [🔲 Todo]
- [ ] [Song 3]  [126]  [4]  [🔲 Todo]
- [ ] [Song 4]  [126]  [4]  [🔲 Todo]

### Story 5 — [Sprite ของนักดนตรี(ตัวละคร)]

- [ ] [Musician 1]  [124]  [2]  [🔲 Todo]
- [ ] [Musician 2]  [124]  [2]  [🔲 Todo]
- [ ] [Musician 3]  [124]  [2]  [🔲 Todo]
- [ ] [Musician 4]  [150]  [2]  [🔲 Todo]
- [ ] [Musician 5]  [150]  [2]  [🔲 Todo]
- [ ] [Musician 6]  [150]  [2]  [🔲 Todo]

### Story 6 — [Art ในเกม]

- [ ] [BG]  [150]  [3]  [🔄 In Progress]
- [ ] [dmg bar]  [124]  [3]  [🔄 In Progress]
- [ ] [ui]  [150]  [3]  [🔄 In Progress]
- [ ] [note]  [124]  [3]  [🔄 In Progress]

---

## Daily Notes

### [วันที่]

**เมื่อวาน:** ...การดึงโค้ดมาจากclass ระบบดันคะแนนที่อิงจาก 8 ช่อง
**วันนี้:** ...การดึงโค้ดมาจากclass การวางตัวละคร
**Blocked:** ...

---

## Links

- [[docs/gdd/00-concept|GDD Concept]]
- [[docs/agile/01-product-backlog|Product Backlog]]
- [[docs/agile/02-sprint-backlog|Sprint Backlog]]
