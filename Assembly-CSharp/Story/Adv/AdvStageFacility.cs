// Decompiled with JetBrains decompiler
// Type: Story.Adv.AdvStageFacility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv.Facility;
using System;
using UnityEngine;

#nullable disable
namespace Story.Adv
{
  [Token(Token = "0x2000750")]
  public class AdvStageFacility : AdvStage, HaveStoryAlreadyReadAdvOption
  {
    [Token(Token = "0x17000619")]
    public int AttachID
    {
      [Token(Token = "0x60028F4"), Address(RVA = "0x3679B40", Offset = "0x3679B40", VA = "0x3679B40")] get
      {
        return new int();
      }
      [Token(Token = "0x60028F5"), Address(RVA = "0x3679B48", Offset = "0x3679B48", VA = "0x3679B48")] set
      {
      }
    }

    [Token(Token = "0x1700061A")]
    public int RewardSetLabelID
    {
      [Token(Token = "0x60028F6"), Address(RVA = "0x3679B50", Offset = "0x3679B50", VA = "0x3679B50")] get
      {
        return new int();
      }
      [Token(Token = "0x60028F7"), Address(RVA = "0x3679B58", Offset = "0x3679B58", VA = "0x3679B58")] set
      {
      }
    }

    [Token(Token = "0x1700061B")]
    public int BonusSetLabelID
    {
      [Token(Token = "0x60028F8"), Address(RVA = "0x3679B60", Offset = "0x3679B60", VA = "0x3679B60")] get
      {
        return new int();
      }
      [Token(Token = "0x60028F9"), Address(RVA = "0x3679B68", Offset = "0x3679B68", VA = "0x3679B68")] set
      {
      }
    }

    [Token(Token = "0x1700061C")]
    public LuaFunction LuaFunction
    {
      [Token(Token = "0x60028FA"), Address(RVA = "0x3679B70", Offset = "0x3679B70", VA = "0x3679B70")] get
      {
        return (LuaFunction) null;
      }
    }

    [Token(Token = "0x60028FB")]
    [Address(RVA = "0x3679B78", Offset = "0x3679B78", VA = "0x3679B78")]
    public AdvStageFacility(
      AdvDemoInfoData demoInfo,
      Func<string, GameObject> areaObjectModelRefGetMethod,
      Func<GameObject> getPlayerOjectModelRefMethod,
      Action onChangeArea)
    {
    }

    [Token(Token = "0x60028FC")]
    [Address(RVA = "0x3679C14", Offset = "0x3679C14", VA = "0x3679C14")]
    public void Initialize(int attachID)
    {
    }

    [Token(Token = "0x60028FD")]
    [Address(RVA = "0x367A2D4", Offset = "0x367A2D4", VA = "0x367A2D4")]
    public void Initialize(int attachID, int targetWorkID)
    {
    }
  }
}
