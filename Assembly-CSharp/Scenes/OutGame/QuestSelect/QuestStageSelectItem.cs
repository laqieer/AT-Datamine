// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestStageSelectItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x2003403")]
  internal class QuestStageSelectItem : MonoBehaviour
  {
    [Token(Token = "0x400E224")]
    private const string MissionProgressTemplate = "{0}<voffset=2><size=19>/</size></voffset><size=24>{1}</size>";
    [Token(Token = "0x400E225")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject[] selectCursors;
    [Token(Token = "0x400E226")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject newIcon;
    [Token(Token = "0x400E227")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI questName;
    [Token(Token = "0x400E228")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject missionProgress;
    [Token(Token = "0x400E229")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI missionProgressVal;
    [Token(Token = "0x400E22A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject missionComplete;
    [Token(Token = "0x400E22B")]
    [FieldOffset(Offset = "0x48")]
    private QuestInfo questInfo;

    [Token(Token = "0x601470E")]
    [Address(RVA = "0x1891E08", Offset = "0x1891E08", VA = "0x1891E08")]
    public void InitQuest(int idx, QuestInfo questInfo, Action<int> clickAction)
    {
    }

    [Token(Token = "0x601470F")]
    [Address(RVA = "0x1891F1C", Offset = "0x1891F1C", VA = "0x1891F1C")]
    public void SetQuest(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x6014710")]
    [Address(RVA = "0x1891F24", Offset = "0x1891F24", VA = "0x1891F24")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6014711")]
    [Address(RVA = "0x1892230", Offset = "0x1892230", VA = "0x1892230")]
    public void Select(bool sw, QuestDifficultyTypeEnum difficulty = QuestDifficultyTypeEnum.Normal)
    {
    }

    [Token(Token = "0x6014712")]
    [Address(RVA = "0x1892374", Offset = "0x1892374", VA = "0x1892374")]
    public void EnableButton(bool sw)
    {
    }

    [Token(Token = "0x6014713")]
    [Address(RVA = "0x18923DC", Offset = "0x18923DC", VA = "0x18923DC")]
    public QuestStageSelectItem()
    {
    }
  }
}
