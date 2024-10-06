-- このluaスクリプトは、PT7_02_02_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","落胆")
-- ▲直接出力

	--★★ケイ★★:遅い
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT7_02_02_0020001")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:悪い。これでも急いで来たんだけどさ<br>それで用事ってのは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT7_02_02_0020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","肯定2")
-- ▲直接出力

	--★★ケイ★★:簡潔に言う<br>魔物が出没したので、これの退治を頼みたい
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT7_02_02_0020003")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ケイ★★:貴公は傭兵を生業としていたのだから<br>魔物退治など慣れたものだろう？
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT7_02_02_0020004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:魔物退治を専門でやってたわけじゃないけど<br>まあ、経験はあるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT7_02_02_0020005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","肯定3")
-- ▲直接出力

	--★★ケイ★★:ならば早速出るといい
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT7_02_02_0020006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:やれやれ<br>俺に拒否権はないんだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT7_02_02_0020007")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
