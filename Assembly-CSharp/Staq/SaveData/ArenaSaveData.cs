// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ArenaSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CF4")]
  public class ArenaSaveData
  {
    [Token(Token = "0x4010C5D")]
    [FieldOffset(Offset = "0x10")]
    public bool ShowFullDuelAnimation;
    [Token(Token = "0x4010C5E")]
    [FieldOffset(Offset = "0x11")]
    public bool FastMode;
    [Token(Token = "0x4010C5F")]
    [FieldOffset(Offset = "0x18")]
    public BattleSettingsSaveData.BattleCamera[] Cameras;
    [Token(Token = "0x4010C60")]
    [FieldOffset(Offset = "0x20")]
    public int CameraIndex;
    [Token(Token = "0x4010C61")]
    [FieldOffset(Offset = "0x24")]
    public bool GridView;
    [Token(Token = "0x4010C62")]
    [FieldOffset(Offset = "0x28")]
    public int NeedResult;

    [Token(Token = "0x1700500C")]
    public static string Path
    {
      [Token(Token = "0x60187E6"), Address(RVA = "0x2938D58", Offset = "0x2938D58", VA = "0x2938D58")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60187E7")]
    [Address(RVA = "0x2938DA8", Offset = "0x2938DA8", VA = "0x2938DA8")]
    public string getPath() => (string) null;

    [Token(Token = "0x60187E8")]
    [Address(RVA = "0x2938DF0", Offset = "0x2938DF0", VA = "0x2938DF0")]
    public void Delete()
    {
    }

    [Token(Token = "0x60187E9")]
    [Address(RVA = "0x2938E08", Offset = "0x2938E08", VA = "0x2938E08")]
    public void deleteFile()
    {
    }

    [Token(Token = "0x60187EA")]
    [Address(RVA = "0x2938E34", Offset = "0x2938E34", VA = "0x2938E34")]
    public void load()
    {
    }

    [Token(Token = "0x60187EB")]
    [Address(RVA = "0x2939140", Offset = "0x2939140", VA = "0x2939140")]
    public void save()
    {
    }

    [Token(Token = "0x60187EC")]
    [Address(RVA = "0x2939300", Offset = "0x2939300", VA = "0x2939300")]
    public ArenaSaveData()
    {
    }
  }
}
