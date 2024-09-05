// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapObliviaeEnterUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x200186D")]
  public class FreeMapObliviaeEnterUIParam : FreeMapUIParamBase
  {
    [Token(Token = "0x4006A5F")]
    [FieldOffset(Offset = "0x48")]
    private StoryFreeActionObliviaeLayoutData layout;

    [Token(Token = "0x17001603")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A6A"), Address(RVA = "0x4521D3C", Offset = "0x4521D3C", VA = "0x4521D3C", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x17001604")]
    public int AdvID
    {
      [Token(Token = "0x6008A6B"), Address(RVA = "0x4521D44", Offset = "0x4521D44", VA = "0x4521D44")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001605")]
    public int LayoutObjectID
    {
      [Token(Token = "0x6008A6C"), Address(RVA = "0x4521D60", Offset = "0x4521D60", VA = "0x4521D60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008A6D")]
    [Address(RVA = "0x4521D7C", Offset = "0x4521D7C", VA = "0x4521D7C", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A6E")]
    [Address(RVA = "0x4521D84", Offset = "0x4521D84", VA = "0x4521D84")]
    public FreeMapObliviaeEnterUIParam(StoryFreeActionObliviaeLayoutData layout)
    {
    }

    [Token(Token = "0x6008A6F")]
    [Address(RVA = "0x4521E18", Offset = "0x4521E18", VA = "0x4521E18", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A70")]
    [Address(RVA = "0x4521E7C", Offset = "0x4521E7C", VA = "0x4521E7C", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008A71")]
    [Address(RVA = "0x4521F54", Offset = "0x4521F54", VA = "0x4521F54", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008A72")]
    [Address(RVA = "0x4521F5C", Offset = "0x4521F5C", VA = "0x4521F5C", Slot = "10")]
    public override string GetTitle() => (string) null;

    [Token(Token = "0x6008A73")]
    [Address(RVA = "0x4521F78", Offset = "0x4521F78", VA = "0x4521F78", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
