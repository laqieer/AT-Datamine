// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.AreaEventQuest.FreeMapAreaEventQuestButtonEvent`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam.AreaEvent;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.AreaEventQuest
{
  [Token(Token = "0x2001744")]
  public abstract class FreeMapAreaEventQuestButtonEvent<TParam> : FreeMapIconButtonEventBase<TParam>
    where TParam : FreeMapAreaEventQuestEventUIParam
  {
    [Token(Token = "0x170014AC")]
    protected int AdvID
    {
      [Token(Token = "0x60083BA")] get => new int();
    }

    [Token(Token = "0x60083BB")]
    public FreeMapAreaEventQuestButtonEvent(TParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x60083BC")]
    protected override void BuildTask(FreeMapCommonElement element)
    {
    }
  }
}
