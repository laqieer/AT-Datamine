// Decompiled with JetBrains decompiler
// Type: Network.API.UpdatedPlayerItemsInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B30")]
  public class UpdatedPlayerItemsInfo
  {
    [Token(Token = "0x17001CF5")]
    public int ItemId
    {
      [Token(Token = "0x6009F9E"), Address(RVA = "0x46C1234", Offset = "0x46C1234", VA = "0x46C1234")] get
      {
        return new int();
      }
      [Token(Token = "0x6009F9F"), Address(RVA = "0x46C123C", Offset = "0x46C123C", VA = "0x46C123C")] private set
      {
      }
    }

    [Token(Token = "0x17001CF6")]
    public int ItemQuantity
    {
      [Token(Token = "0x6009FA0"), Address(RVA = "0x46C1244", Offset = "0x46C1244", VA = "0x46C1244")] get
      {
        return new int();
      }
      [Token(Token = "0x6009FA1"), Address(RVA = "0x46C124C", Offset = "0x46C124C", VA = "0x46C124C")] private set
      {
      }
    }

    [Token(Token = "0x17001CF7")]
    public int ItemTypeId
    {
      [Token(Token = "0x6009FA2"), Address(RVA = "0x46C1254", Offset = "0x46C1254", VA = "0x46C1254")] get
      {
        return new int();
      }
      [Token(Token = "0x6009FA3"), Address(RVA = "0x46C125C", Offset = "0x46C125C", VA = "0x46C125C")] private set
      {
      }
    }

    [Token(Token = "0x6009FA4")]
    [Address(RVA = "0x46C1264", Offset = "0x46C1264", VA = "0x46C1264")]
    public UpdatedPlayerItemsInfo(int id, int count, int typeID)
    {
    }
  }
}
