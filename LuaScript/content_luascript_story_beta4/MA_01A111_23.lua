-- このluaスクリプトは、MA_01A111_23.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_007)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)

-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:わかる？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_230002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力

	--★★ラヴェイン★★:わかります。ありますよね<br>いえ完全にわかるわけではありませんが
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A111_230003")


	--★★ラヴェイン★★:ガウェイン、貴方のムカつき具合はひしひしと<br>これから一緒に殴りに行きましょうか？
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A111_230004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:いやあアイツぐにゃぐにゃだから<br>殴ったらボヨンボヨンになっちまうよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_230005")

-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラヴェイン★★:そうしましたらプシューと仕掛けて<br>ウワウワーとやってやればいいんですよ
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A111_230006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:おお！！その手があったか！！<br>ラヴェインお前ホント話わかるヤツ～
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_230007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（仲良くなっている…！『B』と…！<br>そしてなんの話なのかさっぱりわからない…！）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01A111_230008")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
