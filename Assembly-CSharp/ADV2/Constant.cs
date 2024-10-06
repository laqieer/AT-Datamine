// Decompiled with JetBrains decompiler
// Type: ADV2.Constant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003D85")]
  public class Constant
  {
    [Token(Token = "0x4010E30")]
    public const string RootObjectName = "3D_Root";
    [Token(Token = "0x4010E31")]
    public const string RootCanvasName = "2D_Root";
    [Token(Token = "0x4010E32")]
    public const string RootBackCanvasName = "Back2D_Root";
    [Token(Token = "0x4010E33")]
    public const string RootFrontCanvasName = "Front2D_Root";
    [Token(Token = "0x4010E34")]
    public const string RootTurorialCanvasName = "Tutorial2D_Root";
    [Token(Token = "0x4010E35")]
    public const string TurorialUICameraName = "TutorialUICamera";
    [Token(Token = "0x4010E36")]
    public const string PlayerNameTag = "PLAYERNAME";
    [Token(Token = "0x4010E37")]
    public const string ReplaceTargetPlayerName = "<%player>";

    [Token(Token = "0x6018C08")]
    [Address(RVA = "0x2649D14", Offset = "0x2649D14", VA = "0x2649D14")]
    public Constant()
    {
    }

    [Token(Token = "0x2003D86")]
    public class AssetPath
    {
      [Token(Token = "0x4010E38")]
      public const string Adv2EditorSettings = "Assets/Editor/Adv2EditorSettings.asset";
      [Token(Token = "0x4010E39")]
      public const string Adv2ProjectFileList = "Assets/AssetBundle/Content/LuaScript/LuaScriptViewList.asset";

      [Token(Token = "0x6018C09")]
      [Address(RVA = "0x2649D1C", Offset = "0x2649D1C", VA = "0x2649D1C")]
      public AssetPath()
      {
      }
    }

    [Token(Token = "0x2003D87")]
    public class ResourcesName
    {
      [Token(Token = "0x4010E3A")]
      public const string BuildData = "BuildData";

      [Token(Token = "0x6018C0A")]
      [Address(RVA = "0x2649D24", Offset = "0x2649D24", VA = "0x2649D24")]
      public ResourcesName()
      {
      }
    }

    [Token(Token = "0x2003D88")]
    public class LuaFunctionName
    {
      [Token(Token = "0x4010E3B")]
      public const string ProjectPreLoad = "PreLoad";
      [Token(Token = "0x4010E3C")]
      public const string ProjectLoad = "Load";
      [Token(Token = "0x4010E3D")]
      public const string ProjectPlay = "Play";
      [Token(Token = "0x4010E3E")]
      public const string SystemPrePlay = "PreStartProc";
      [Token(Token = "0x4010E3F")]
      public const string SystemPostPlay = "PostStartProc";
      [Token(Token = "0x4010E40")]
      public const string SystemPreloadVoiceBank = "PreloadVoicePack";
      [Token(Token = "0x4010E41")]
      public const string SystemLoadVoiceBank = "LoadVoicePack";

      [Token(Token = "0x6018C0B")]
      [Address(RVA = "0x2649D2C", Offset = "0x2649D2C", VA = "0x2649D2C")]
      public LuaFunctionName()
      {
      }
    }
  }
}
