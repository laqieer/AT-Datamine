// Decompiled with JetBrains decompiler
// Type: Story.AdvStagePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Story.Adv;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000546")]
  public static class AdvStagePlayer
  {
    [Token(Token = "0x6001E90")]
    [Address(RVA = "0x29FE0CC", Offset = "0x29FE0CC", VA = "0x29FE0CC")]
    public static IEnumerator Play(this AdvStage advStage, AdvDemoInfoData demoInfo)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6001E91")]
    [Address(RVA = "0x29FE15C", Offset = "0x29FE15C", VA = "0x29FE15C")]
    public static void Extract(
      this AdvStage advStage,
      out List<int> selectedlist,
      out List<int> unlockedlist,
      out List<int> alreadyReadChoices)
    {
    }

    [Token(Token = "0x6001E92")]
    [Address(RVA = "0x29FD78C", Offset = "0x29FD78C", VA = "0x29FD78C")]
    public static AdvRequest Extract(this AdvStage advStage) => (AdvRequest) null;
  }
}
