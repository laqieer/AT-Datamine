-- このluaスクリプトは、MA_01A112_26.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",80,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101020011)
	Actor001 = InitializeCharacter_3D("101011","002","101011002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","002","101016002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:つゆ払いご苦労さま
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","MA_01A112_260002")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:変わってしまいましたね、ここも随分
	Talk(Actor002,"CHRNAME_GWENHWYMAWR2","speech","L","MA_01A112_260003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:バルバロイとの戦いがぜぇんぶ終わったら<br>リフォームしなきゃね、いっぱいの人を呼んで
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","MA_01A112_260004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:いかがでしたか？里帰りは
	Talk(Actor002,"CHRNAME_GWENHWYMAWR2","speech","L","MA_01A112_260005")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:サイアクでした
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","MA_01A112_260006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:ですね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR2","speech","L","MA_01A112_260007")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…でもね、それでいいんだよきっと
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","MA_01A112_260008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ギネヴィア★★:変わっちゃったものは戻らないし<br>過ぎた時間は取り返しつかない
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","MA_01A112_260010")


	--★★ギネヴィア★★:だから──
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","MA_01A112_260011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101020011)
	InitializeCharacter_3D_Preload("101011","002","101011002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","002","101016002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
