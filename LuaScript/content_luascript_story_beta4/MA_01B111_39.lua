-- このluaスクリプトは、MA_01B111_39.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
Hide(Actor002)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101200051)
	Actor001 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
setup_small_camera_start(Camera001)
 --PlayPartVoice("ギネマウア", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:どこにいるの！？<br>ギネヴィア、ギネヴィア！！
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","MA_01B111_390002")


	--★★ギネマウア★★:帰りましょうギネヴィア！！戦いは終わったの！<br>貴方が指揮したログレスが勝ったのよ！！
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","MA_01B111_390003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ギネマウア★★:お願い、顔を見せて…！<br>返事をして、ギネヴィア！！
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","MA_01B111_390004")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor001)
change_face(Actor002,"Sad")
--フェードイン
fadein(CHARA_IN_OUT)
EntryWalk(Actor002,Camera002,EntryDataDuelCommonFormation01_06,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_106)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:………『<ruby=けが>穢</ruby>れた血』
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B111_390006")


	--★★アーサー★★:わかって、いるさ…マーリン<br>どこにいる、マーリン…？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B111_390008")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力

	--★★アーサー★★:…どうせなら、僅かでも…<br>先を生きる者のために…お前と意志は同じ…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B111_390009")


	--★★アーサー★★:その血を流すよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B111_390010")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★アーサー★★:一滴、遺さず
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B111_390012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101200051)
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
