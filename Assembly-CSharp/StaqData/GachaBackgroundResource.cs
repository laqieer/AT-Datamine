// Decompiled with JetBrains decompiler
// Type: StaqData.GachaBackgroundResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002140")]
  public class GachaBackgroundResource
  {
    [Token(Token = "0x4008D15")]
    [FieldOffset(Offset = "0x10")]
    public int Id;
    [Token(Token = "0x4008D16")]
    [FieldOffset(Offset = "0x14")]
    public int ResourceId;
    [Token(Token = "0x4008D17")]
    [FieldOffset(Offset = "0x18")]
    public string Path;
    [Token(Token = "0x4008D18")]
    [FieldOffset(Offset = "0x20")]
    public GachaResourceTypeEnum ResourceType;

    [Token(Token = "0x600CBC8")]
    [Address(RVA = "0x1BA9AE8", Offset = "0x1BA9AE8", VA = "0x1BA9AE8")]
    public static GachaBackgroundResource CreateFromServerData(GachaResourceDetailType serverData)
    {
      return (GachaBackgroundResource) null;
    }

    [Token(Token = "0x600CBC9")]
    [Address(RVA = "0x1BAA328", Offset = "0x1BAA328", VA = "0x1BAA328")]
    public GachaBackgroundResource()
    {
    }
  }
}
