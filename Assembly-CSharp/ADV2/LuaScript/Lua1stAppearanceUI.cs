// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Lua1stAppearanceUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EA1")]
  [MoonSharpUserData]
  public class Lua1stAppearanceUI : LuaUI
  {
    [Token(Token = "0x40112DD")]
    private const string TagImage = "CharacterImage";
    [Token(Token = "0x40112DE")]
    private const string TagImageShadow = "CharacterImage_Shadow";
    [Token(Token = "0x40112DF")]
    private const string TextCharaName = "CharacterName";
    [Token(Token = "0x40112E0")]
    private const string TextCharaNameAlphabet = "CharaName_Alphabet_Back";
    [Token(Token = "0x40112E1")]
    private const string TextTitle = "Title";
    [Token(Token = "0x40112E2")]
    private const string TextAffiliation = "Affiliation";
    [Token(Token = "0x40112E3")]
    private const string TextExplanation = "Explanation";
    [Token(Token = "0x40112E4")]
    private const string TagTitle1 = "Title1";
    [Token(Token = "0x40112E5")]
    private const string TagTitle2 = "Title2";

    [Token(Token = "0x6019359")]
    [Address(RVA = "0x2D066DC", Offset = "0x2D066DC", VA = "0x2D066DC")]
    public Lua1stAppearanceUI(Adv2UI instance)
    {
    }

    [Token(Token = "0x601935A")]
    [Address(RVA = "0x2D06704", Offset = "0x2D06704", VA = "0x2D06704")]
    public void Set1stAppearanceDatas(string fullImageTag, int styleId)
    {
    }
  }
}
