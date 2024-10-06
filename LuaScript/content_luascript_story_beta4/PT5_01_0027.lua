-- このluaスクリプトは、PT5_01_0027.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:今日のホームルームは私が担当する<br>内容は当学園のなりたちについてだ
	Talk(Actor004,"CHRNAME_KAY","speech","L","PT5_01_00270002")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ケイ★★:キャメロット騎士学術院は<br>ログレス王城に作られたＧＳ研究施設を母体に
	Talk(Actor004,"CHRNAME_KAY","speech","L","PT5_01_00270003")


	--★★ケイ★★:５年ほど前、現国王アーサーが前王ユーサーより<br>王位を継承したさいに作った学術機関だ
	Talk(Actor004,"CHRNAME_KAY","speech","L","PT5_01_00270004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:今はまだログレス王城の一角に<br>間借りしている状態であるから
	Talk(Actor004,"CHRNAME_KAY","speech","L","PT5_01_00270005")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:教室の数もそれほど多いわけではなく<br>時折城仕えの兵士とすれ違うこともあるだろう
	Talk(Actor004,"CHRNAME_KAY","speech","L","PT5_01_00270006")


	--★★ケイ★★:とはいえアーサー王…<br>この場合は学長というのが正しいか…
	Talk(Actor004,"CHRNAME_KAY","speech","L","PT5_01_00270007")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ケイ★★:アーサー学長は<br>精力的に規模の拡張を検討してくれている
	Talk(Actor004,"CHRNAME_KAY","speech","L","PT5_01_00270008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:皆もよりよい学園にするための案があるようなら<br>積極的に申し出てもらいたい
	Talk(Actor004,"CHRNAME_KAY","speech","L","PT5_01_00270009")


	--★★ノワール★★:（なるほど<br>ここは学園であると同時に王城でもあるんだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT5_01_00270010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
