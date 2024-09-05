// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdditionalParameterList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200143C")]
  public class AdditionalParameterList
  {
    [Token(Token = "0x17001141")]
    public AdditionalParameterType Reinforce
    {
      [Token(Token = "0x60071C3"), Address(RVA = "0x404A470", Offset = "0x404A470", VA = "0x404A470")] get
      {
        return (AdditionalParameterType) null;
      }
    }

    [Token(Token = "0x17001142")]
    public AdditionalParameterType Resist
    {
      [Token(Token = "0x60071C4"), Address(RVA = "0x404A478", Offset = "0x404A478", VA = "0x404A478")] get
      {
        return (AdditionalParameterType) null;
      }
    }

    [Token(Token = "0x17001143")]
    public AdditionalParameterType Slay
    {
      [Token(Token = "0x60071C5"), Address(RVA = "0x404A480", Offset = "0x404A480", VA = "0x404A480")] get
      {
        return (AdditionalParameterType) null;
      }
    }

    [Token(Token = "0x17001144")]
    public AdditionalParameterType ResistSlay
    {
      [Token(Token = "0x60071C6"), Address(RVA = "0x404A488", Offset = "0x404A488", VA = "0x404A488")] get
      {
        return (AdditionalParameterType) null;
      }
    }

    [Token(Token = "0x60071C7")]
    [Address(RVA = "0x404A490", Offset = "0x404A490", VA = "0x404A490")]
    public void OnLoadEntityReinforce(StyleData entity)
    {
    }

    [Token(Token = "0x60071C8")]
    [Address(RVA = "0x404B704", Offset = "0x404B704", VA = "0x404B704")]
    public void OnLoadEntityResist(StyleData entity)
    {
    }

    [Token(Token = "0x60071C9")]
    [Address(RVA = "0x404B9B8", Offset = "0x404B9B8", VA = "0x404B9B8")]
    public void OnLoadEntitySlay(StyleData entity)
    {
    }

    [Token(Token = "0x60071CA")]
    [Address(RVA = "0x404C228", Offset = "0x404C228", VA = "0x404C228")]
    public void OnLoadEntityResistSlay(StyleData entity)
    {
    }

    [Token(Token = "0x60071CB")]
    [Address(RVA = "0x404C3D8", Offset = "0x404C3D8", VA = "0x404C3D8")]
    private void Add(List<AdditionalParameter> list, ElementType element, int value)
    {
    }

    [Token(Token = "0x60071CC")]
    [Address(RVA = "0x404C4C4", Offset = "0x404C4C4", VA = "0x404C4C4")]
    public AdditionalParameterList()
    {
    }
  }
}
