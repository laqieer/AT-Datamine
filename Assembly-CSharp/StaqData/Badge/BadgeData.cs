// Decompiled with JetBrains decompiler
// Type: StaqData.Badge.BadgeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace StaqData.Badge
{
  [Token(Token = "0x20021C1")]
  public class BadgeData
  {
    [Token(Token = "0x4008EF5")]
    [FieldOffset(Offset = "0x10")]
    private bool isEnable;
    [Token(Token = "0x4008EF6")]
    [FieldOffset(Offset = "0x18")]
    private Action<bool> valueChangeEvent;

    [Token(Token = "0x17002CFE")]
    public bool IsEnable
    {
      [Token(Token = "0x600CE34"), Address(RVA = "0x4B6176C", Offset = "0x4B6176C", VA = "0x4B6176C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CE35"), Address(RVA = "0x4B61774", Offset = "0x4B61774", VA = "0x4B61774")] set
      {
      }
    }

    [Token(Token = "0x600CE36")]
    [Address(RVA = "0x4B617A8", Offset = "0x4B617A8", VA = "0x4B617A8")]
    public void SetEnable(bool value)
    {
    }

    [Token(Token = "0x14000135")]
    public event Action<bool> ValueChangeEvent
    {
      [Token(Token = "0x600CE37"), Address(RVA = "0x4B617CC", Offset = "0x4B617CC", VA = "0x4B617CC")] add
      {
      }
      [Token(Token = "0x600CE38"), Address(RVA = "0x4B61890", Offset = "0x4B61890", VA = "0x4B61890")] remove
      {
      }
    }

    [Token(Token = "0x600CE39")]
    [Address(RVA = "0x4B61938", Offset = "0x4B61938", VA = "0x4B61938")]
    public BadgeData()
    {
    }
  }
}
