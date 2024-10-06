// Decompiled with JetBrains decompiler
// Type: UnitDetail.UnitTrustInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x2000493")]
  public class UnitTrustInfo : ItemInfoBase
  {
    [Token(Token = "0x1700031B")]
    public UnitTrust Data
    {
      [Token(Token = "0x60019B4"), Address(RVA = "0x2C22FA4", Offset = "0x2C22FA4", VA = "0x2C22FA4")] get
      {
        return (UnitTrust) null;
      }
      [Token(Token = "0x60019B5"), Address(RVA = "0x2C22FAC", Offset = "0x2C22FAC", VA = "0x2C22FAC")] private set
      {
      }
    }

    [Token(Token = "0x60019B6")]
    [Address(RVA = "0x2C22FB4", Offset = "0x2C22FB4", VA = "0x2C22FB4")]
    public UnitTrustInfo(string itemName, string iconName, UnitTrust unitTrust)
    {
    }
  }
}
