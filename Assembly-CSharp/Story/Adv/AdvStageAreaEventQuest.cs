// Decompiled with JetBrains decompiler
// Type: Story.Adv.AdvStageAreaEventQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData.AreaEvent;
using System;
using UnityEngine;

#nullable disable
namespace Story.Adv
{
  [Token(Token = "0x2000748")]
  public class AdvStageAreaEventQuest : AdvStage, HaveStoryAlreadyRead, HaveStoryAlreadyReadAdvOption
  {
    [Token(Token = "0x17000602")]
    public AreaEventQuestLuaFunction LuaFunction
    {
      [Token(Token = "0x60028B6"), Address(RVA = "0x3678950", Offset = "0x3678950", VA = "0x3678950")] get
      {
        return (AreaEventQuestLuaFunction) null;
      }
      [Token(Token = "0x60028B7"), Address(RVA = "0x3678958", Offset = "0x3678958", VA = "0x3678958")] private set
      {
      }
    }

    [Token(Token = "0x60028B8")]
    [Address(RVA = "0x3678960", Offset = "0x3678960", VA = "0x3678960")]
    public AdvStageAreaEventQuest(
      AdvDemoInfoData demoInfo,
      Func<string, GameObject> areaObjectModelRefGetMethod,
      Func<GameObject> getPlayerOjectModelRefMethod,
      Action onChangeArea)
    {
    }

    [Token(Token = "0x60028B9")]
    [Address(RVA = "0x3678964", Offset = "0x3678964", VA = "0x3678964")]
    public void Initialize(int areaEventTaskID)
    {
    }
  }
}
