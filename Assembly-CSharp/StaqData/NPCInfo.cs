// Decompiled with JetBrains decompiler
// Type: StaqData.NPCInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020C1")]
  public class NPCInfo
  {
    [Token(Token = "0x4008B17")]
    [FieldOffset(Offset = "0x28")]
    private int styleSwitchPatternID;
    [Token(Token = "0x4008B18")]
    [FieldOffset(Offset = "0x2C")]
    private int objectID;

    [Token(Token = "0x17002A79")]
    public string AreaName
    {
      [Token(Token = "0x600C655"), Address(RVA = "0x1CD654C", Offset = "0x1CD654C", VA = "0x1CD654C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002A7A")]
    public string Name
    {
      [Token(Token = "0x600C656"), Address(RVA = "0x1CD6668", Offset = "0x1CD6668", VA = "0x1CD6668")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C657"), Address(RVA = "0x1CD6670", Offset = "0x1CD6670", VA = "0x1CD6670")] private set
      {
      }
    }

    [Token(Token = "0x17002A7B")]
    public int StyleID
    {
      [Token(Token = "0x600C658"), Address(RVA = "0x1CD6678", Offset = "0x1CD6678", VA = "0x1CD6678")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A7C")]
    public string ThumbABName
    {
      [Token(Token = "0x600C659"), Address(RVA = "0x1CD6720", Offset = "0x1CD6720", VA = "0x1CD6720")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C65A"), Address(RVA = "0x1CD6728", Offset = "0x1CD6728", VA = "0x1CD6728")] private set
      {
      }
    }

    [Token(Token = "0x17002A7D")]
    public string ThumbABAssetName
    {
      [Token(Token = "0x600C65B"), Address(RVA = "0x1CD6730", Offset = "0x1CD6730", VA = "0x1CD6730")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C65C"), Address(RVA = "0x1CD6738", Offset = "0x1CD6738", VA = "0x1CD6738")] private set
      {
      }
    }

    [Token(Token = "0x600C65D")]
    [Address(RVA = "0x1CD6740", Offset = "0x1CD6740", VA = "0x1CD6740")]
    private NPCInfo(int objectID)
    {
    }

    [Token(Token = "0x600C65E")]
    [Address(RVA = "0x1CD6554", Offset = "0x1CD6554", VA = "0x1CD6554")]
    private static string SearchNowAreaName(int objectID) => (string) null;

    [Token(Token = "0x600C65F")]
    [Address(RVA = "0x1CD6788", Offset = "0x1CD6788", VA = "0x1CD6788")]
    private static string SearchNowName(int objectID) => (string) null;

    [Token(Token = "0x600C660")]
    [Address(RVA = "0x1CD690C", Offset = "0x1CD690C", VA = "0x1CD690C")]
    private static (string, string) SearchNowThumnail(int objectID) => ();

    [Token(Token = "0x600C661")]
    [Address(RVA = "0x1CD6864", Offset = "0x1CD6864", VA = "0x1CD6864")]
    private static int GetStyleSwitchPatternID(int objectID) => new int();

    [Token(Token = "0x600C662")]
    [Address(RVA = "0x1CD4294", Offset = "0x1CD4294", VA = "0x1CD4294")]
    public static NPCInfo CreateByObjectID(int objectID) => (NPCInfo) null;
  }
}
