-- このluaスクリプトは、MA_01105_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
BgProp = setup_prop_object(10102009)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:さがしちゃった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_020002")

	open_select_window_tag(Actor001,"Normal","MA_01105_020004","MA_01105_020005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺も、ちょうどキミを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_020007")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:転校生クンは<br>トモダチいないもんね～
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_020009")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:やぁいボッチめ～
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_020010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…さて<br>向こうの屋台でも見に行こうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_020012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ちょっとォ…<br>せっかく声かけてあげてるのにい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_020013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:冗談だよ、冗談
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_020014")

	goto Block1end

::Block1end::
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
on_camera(RndCamera006)
-- ▲直接出力

	--★★貴族（男）★★:ギネヴィア殿下…<br>いつもにも増してお美しい
	Talk(Actor003,"NPCNAME_0128","speech","N","MA_01105_020016")


	--★★貴族（男）★★:カレドニアとの戦争終結の暁には<br>どうか我が愚息と友好を結べぬものか…
	Talk(Actor003,"NPCNAME_0128","speech","N","MA_01105_020017")


	--★★貴族（男）②★★:なんと不倫なさるおつもりで？<br>まあアーサー王との不仲説もありますからなあ
	Talk(Actor004,"NPCNAME_0129","speech","N","MA_01105_020018")


	--★★貴族（男）★★:そもそもこの婚姻自体<br><dot>おままごと</dot>だとか
	Talk(Actor003,"NPCNAME_0128","speech","N","MA_01105_020019")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:…お祭り<br>エスコートしてくださる？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_020021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102009)
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
