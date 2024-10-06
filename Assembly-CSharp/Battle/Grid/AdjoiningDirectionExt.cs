// Decompiled with JetBrains decompiler
// Type: Battle.Grid.AdjoiningDirectionExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x200252C")]
  public static class AdjoiningDirectionExt
  {
    [Token(Token = "0x4009FBB")]
    private const int TexNoOffsetDangerArea = 8;
    [Token(Token = "0x4009FBC")]
    private const int BaseTexNo1 = 1;
    [Token(Token = "0x4009FBD")]
    private const int BaseTexNo2 = 2;
    [Token(Token = "0x4009FBE")]
    private const int BaseTexNo3 = 3;
    [Token(Token = "0x4009FBF")]
    private const int BaseTexNo4 = 4;
    [Token(Token = "0x4009FC0")]
    private const int BaseTexNo5 = 5;
    [Token(Token = "0x4009FC1")]
    private const int BaseTexNo6 = 6;
    [Token(Token = "0x4009FC2")]
    private const int BaseTexNo7 = 7;
    [Token(Token = "0x4009FC3")]
    private const int BaseTexNo8 = 8;
    [Token(Token = "0x4009FC4")]
    private const int BaseTexNo9 = 9;
    [Token(Token = "0x4009FC5")]
    private const int BaseTexNo10 = 10;
    [Token(Token = "0x4009FC6")]
    private const int BaseTexNo11 = 11;
    [Token(Token = "0x4009FC7")]
    private const int BaseTexNo12 = 12;
    [Token(Token = "0x4009FC8")]
    private const int BaseTexNo13 = 13;
    [Token(Token = "0x4009FC9")]
    private const int BaseTexNo14 = 14;
    [Token(Token = "0x4009FCA")]
    private const int BaseTexNo15 = 15;

    [Token(Token = "0x600E590")]
    [Address(RVA = "0x48693A0", Offset = "0x48693A0", VA = "0x48693A0")]
    public static void SetDangerPanelTexInfo(
      this AdjoiningDirection dir,
      out int texNo,
      out int angle)
    {
    }

    [Token(Token = "0x600E591")]
    [Address(RVA = "0x48693C8", Offset = "0x48693C8", VA = "0x48693C8")]
    private static void GetPanelTexInfo(AdjoiningDirection dir, out int texNo, out int angle)
    {
    }

    [Token(Token = "0x600E592")]
    [Address(RVA = "0x4869654", Offset = "0x4869654", VA = "0x4869654")]
    public static bool Has(this AdjoiningDirection direction, AdjoiningDirection flags)
    {
      return new bool();
    }

    [Token(Token = "0x600E593")]
    [Address(RVA = "0x486962C", Offset = "0x486962C", VA = "0x486962C")]
    public static bool Empty(this AdjoiningDirection direction) => new bool();

    [Token(Token = "0x600E594")]
    [Address(RVA = "0x4869638", Offset = "0x4869638", VA = "0x4869638")]
    public static bool HasAll(this AdjoiningDirection direction) => new bool();

    [Token(Token = "0x600E595")]
    [Address(RVA = "0x4869660", Offset = "0x4869660", VA = "0x4869660")]
    public static bool HasAllCorner(this AdjoiningDirection direction) => new bool();

    [Token(Token = "0x600E596")]
    [Address(RVA = "0x4869644", Offset = "0x4869644", VA = "0x4869644")]
    public static bool HasFourDirections(this AdjoiningDirection direction) => new bool();
  }
}
