---
type: gdd-mechanics
version: 0.1
date: [วันที่]
---
# Mechanic Design — [ไม่มี]

## State Diagram

```mermaid

stateDiagram-v2
    [*] --> Core_Mechanic
	Core_Mechanic --> Management_System
	Management_System --> Department
	Department --> Prayer
	Department --> Immolate
	Department --> Abattoir
	Department --> Purifier
	Department --> Messiah
	Prayer --> Gain4TypeOfFaith
	Immolate --> Gain4TypeOfFaith
	Abattoir --> Gain4TypeOfFaith
	Purifier --> Gain4TypeOfFaith
	Gain4TypeOfFaith --> Upgrade
	Core_Mechanic --> Pick_Operator
	Pick_Operator --> Operator_Interview : click for select
	Operator_Interview --> Accept
	Operator_Interview --> Decline
	Decline --> Pick_Operator : Pick another Operator
	Accept --> Pick_Department
	Pick_Department --> Send_to_Work
	Send_to_Work --> End_Daily_Operator_Picking
	Core_Mechanic --> Daily_Quota : Meet Daily Quota
	Daily_Quota --> Collect_Lost_Sheep
	Collect_Lost_Sheep --> Full_Quota
	Full_Quota --> End_Day
```

## Rules

| State        | เข้าเงื่อนไข | ออกเงื่อนไข   | Note |
| ------------ | ------------------------ | ------------------------ | ---- |
| Daily Quota  | เริ่มทำงาน     | เก็บแต้มครบ   | -    |
| Upgrade      | จบวัน               | อัพเกรดเสร็จ | -    |
| PickOperator | เรื่มวัน         | เลือกเสร็จ     | -    |
