// Decompiled with JetBrains decompiler
// Type: StaqData.Points
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002056")]
  public class Points
  {
    [Token(Token = "0x40089CC")]
    [FieldOffset(Offset = "0x10")]
    private AmountManagement friendPointEntity;

    [Token(Token = "0x17002908")]
    public AmountManagement.IReadOnlyEntity FriendPoint
    {
      [Token(Token = "0x600C2F7"), Address(RVA = "0x19EEF2C", Offset = "0x19EEF2C", VA = "0x19EEF2C")] get
      {
        return (AmountManagement.IReadOnlyEntity) null;
      }
    }

    [Token(Token = "0x600C2F8")]
    [Address(RVA = "0x19EEF34", Offset = "0x19EEF34", VA = "0x19EEF34")]
    public void Apply(PlayerType entity)
    {
    }

    [Token(Token = "0x600C2F9")]
    [Address(RVA = "0x19EEF38", Offset = "0x19EEF38", VA = "0x19EEF38")]
    public Points()
    {
    }
  }
}
