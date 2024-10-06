// Decompiled with JetBrains decompiler
// Type: FreeMap.FreeMapCharacterFinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015E0")]
  public class FreeMapCharacterFinder
  {
    [Token(Token = "0x40063C7")]
    [FieldOffset(Offset = "0x10")]
    private readonly int sequenceId;
    [Token(Token = "0x40063C8")]
    [FieldOffset(Offset = "0x18")]
    private readonly StoryMainQuestSequenceData sequenceData;
    [Token(Token = "0x40063C9")]
    [FieldOffset(Offset = "0x20")]
    private readonly StoryFreeActionSettingData freeActionSettingData;
    [Token(Token = "0x40063CA")]
    [FieldOffset(Offset = "0x28")]
    private readonly IReadOnlyCollection<StoryCommunicationAttachData> commuAttachDatas;

    [Token(Token = "0x6007BA3")]
    [Address(RVA = "0x22A3444", Offset = "0x22A3444", VA = "0x22A3444")]
    public FreeMapCharacterFinder(int sequenceId)
    {
    }

    [Token(Token = "0x6007BA4")]
    [Address(RVA = "0x22A3580", Offset = "0x22A3580", VA = "0x22A3580")]
    public bool ExistsInFreeMap(Communication communication) => new bool();
  }
}
