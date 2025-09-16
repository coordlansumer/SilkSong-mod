# SILKSONG mod
press ALT + 0 to wake up gui (x)

# team cherry define hornet
use to develop

---

## 🎮 PlayerData(you can edit)

## 📋 basic information

| 字段名 | 类型 | 默认值 | 说明 |
|--------|------|--------|------|
| `version` | `string` | `"1.0.28561"` | 游戏版本 |
| `RevisionBreak` | `int` | `28104` | 版本断点 |
| `date` | `string` | - | 存档日期 |
| `profileID` | `int` | - | 存档ID |
| `playTime` | `float` | - | 游戏时长（秒） |
| `permadeathMode` | `PermadeathModes` | - | 永久死亡模式 |
| `isFirstGame` | `bool` | `true` | 是否第一次游戏 |

---

## ❤️ health and silk

| 字段名 | 类型 | 默认值 | 说明 |
|--------|------|--------|------|
| `health` | `int` | `5` | 当前生命值 |
| `maxHealth` | `int` | `5` | 最大生命值 |
| `maxHealthBase` | `int` | `5` | 基础最大生命值 |
| `healthBlue` | `int` | - | 蓝色生命值 |
| `heartPieces` | `int` | - | 心之碎片数量 |
| `geo` | `int` | - | 货币（Geo） |
| `silk` | `int` | - | 丝线值 |
| `silkMax` | `int` | `9` | 最大丝线值 |
| `silkRegenMax` | `int` | - | 丝线恢复最大值 |
| `silkParts` | `int` | - | 丝线碎片（非序列化） |
| `silkSpoolParts` | `int` | - | 丝线卷轴碎片 |

---

## 🧭 map and region

| 字段名 | 类型 | 说明 |
|--------|------|------|
| `respawnScene` | `string` | 重生场景名 |
| `mapZone` | `MapZone` | 当前地图区域 |
| `scenesVisited` | `HashSet<string>` | 已访问的场景集合 |
| `scenesMapped` | `HashSet<string>` | 已绘制地图的场景集合 |
| `HasMossGrottoMap` | `bool` | 是否拥有苔藓洞穴地图 |
| `HasWildsMap` | `bool` | 是否拥有荒野地图 |
| ...（其他 `HasXXXMap` 字段） | `bool` | 其他区域地图是否获得 |

---

## ⚔️ ability and gift

| 字段名 | 类型 | 说明 |
|--------|------|------|
| `hasDash` | `bool` | 是否拥有冲刺 |
| `hasWalljump` | `bool` | 是否拥有蹬墙跳 |
| `hasDoubleJump` | `bool` | 是否拥有二段跳 |
| `hasHarpoonDash` | `bool` | 是否拥有鱼叉冲刺 |
| `hasSuperJump` | `bool` | 是否拥有超级跳 |
| `hasNeedolin` | `bool` | 是否拥有尼德林 |
| `hasSilkCharge` | `bool` | 是否拥有丝线充能 |
| `hasSilkBomb` | `bool` | 是否拥有丝线炸弹 |
| `nailUpgrades` | `int` | 针武器升级次数 |
| `silkSpecialLevel` | `int` | 丝线特殊技能等级 |

---

## 🧩 mission

| 字段名 | 类型 | 说明 |
|--------|------|------|
| `defeatedMossMother` | `bool` | 是否击败苔藓母亲 |
| `defeatedSplinterQueen` | `bool` | 是否击败分裂女王 |
| `defeatedCoralKing` | `bool` | 是否击败珊瑚王 |
| `encounteredLace1` | `bool` | 是否遇到蕾丝（第一次） |
| `encounteredLaceTower` | `bool` | 是否在塔中遇到蕾丝 |
| `CompletedEndings` | `CompletionState` | 已完成的结局 |
| `fixerBridgeConstructed` | `bool` | 是否建造了桥梁 |
| `shermaQuestActive` | `bool` | 谢尔玛任务是否激活 |

---

## 🧰 items 

| 字段名 | 类型 | 说明 |
|--------|------|------|
| `hasJournal` | `bool` | 是否拥有日志 |
| `hasPinBench` | `bool` | 是否拥有长椅图钉 |
| `hasPinShop` | `bool` | 是否拥有商店图钉 |
| `hasPinStag` | `bool` | 是否拥有鹿站图钉 |
| `ShellShards` | `int` | 贝壳碎片数量 |
| `CollectedMementoGrey` | `bool` | 是否收集灰色纪念品 |
| `CollectedHeartFlower` | `bool` | 是否收集花之心 |
| `CollectedHeartCoral` | `bool` | 是否收集珊瑚之心 |

---

## 🧪 debug

| 字段名 | 类型 | 说明 |
|--------|------|------|
| `isInvincible` | `bool` | 是否无敌 |
| `infiniteAirJump` | `bool` | 是否无限空中跳跃 |
| `mapAllRooms` | `bool` | 是否显示所有房间地图 |
| `betaEnd` | `bool` | 是否测试版结束 |
| `bossRushMode` | `bool` | 是否Boss Rush模式 |
| `unlockedBossScenes` | `List<string>` | 已解锁的Boss场景 |

---

## 🧭 travel

| 字段名 | 类型 | 说明 |
|--------|------|------|
| `UnlockedFastTravel` | `bool` | 是否解锁快速旅行 |
| `UnlockedDocksStation` | `bool` | 是否解锁码头站 |
| `UnlockedBoneforestEastStation` | `bool` | 是否解锁骨林东站 |
| `UnlockedGreymoorStation` | `bool` | 是否解锁灰沼站 |
| ...（其他 `UnlockedXXXStation`） | `bool` | 其他站点是否解锁 |

---

## 🧩 other

| 字段名 | 类型 | 说明 |
|--------|------|------|
| `atBench` | `bool` | 是否在长椅处 |
| `showGeoUI` | `bool` | 是否显示Geo UI |
| `showHealthUI` | `bool` | 是否显示生命UI |
| `promptFocus` | `bool` | 是否提示专注 |
| `currentInvPane` | `int` | 当前物品栏面板 |
| `completionPercentage` | `float` | 完成度百分比 |

---

## 🧰 equitments

| 字段名 | 类型 | 说明 |
|--------|------|------|
| `ToolEquips` | `ToolCrestsData` | 当前装备的工具 |
| `Tools` | `ToolItemsData` | 所有工具数据 |
| `ToolLiquids` | `ToolItemLiquidsData` | 工具液体数据 |
| `ToolPouchUpgrades` | `int` | 工具袋升级次数 |
| `ToolKitUpgrades` | `int` | 工具包升级次数 |

---

