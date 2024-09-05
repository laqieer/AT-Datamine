// Decompiled with JetBrains decompiler
// Type: Home.Event.HomeEventAdvPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv;
using System;
using System.Collections;

#nullable disable
namespace Home.Event
{
  [Token(Token = "0x2000B64")]
  internal class HomeEventAdvPlayer
  {
    [Token(Token = "0x60040D1")]
    [Address(RVA = "0x2A29F04", Offset = "0x2A29F04", VA = "0x2A29F04")]
    public IEnumerator Play(int advId, Action onComplete = null) => (IEnumerator) null;

    [Token(Token = "0x60040D2")]
    [Address(RVA = "0x2A29FA4", Offset = "0x2A29FA4", VA = "0x2A29FA4")]
    public HomeEventAdvPlayer()
    {
    }

    [Token(Token = "0x2000B65")]
    private class HomeEventAdvStage : AdvStageBase
    {
      [Token(Token = "0x60040D3")]
      [Address(RVA = "0x2A29FAC", Offset = "0x2A29FAC", VA = "0x2A29FAC")]
      public HomeEventAdvStage(AdvDemoInfoData demoInfo)
      {
      }
    }
  }
}
