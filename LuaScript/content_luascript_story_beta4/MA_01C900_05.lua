-- このluaスクリプトは、MA_01C900_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_004)
	Camera002 = SetTemplate("Actor002",80,CharaPos110031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_002)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
-- ▼直接出力
set_common_look_at(Actor001,Actor002,1.0)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115034)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:すまない、ノワール<br>貴公にばかり背負わせてしまう
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_050002")

	open_select_window_tag(Actor001,"Normal","MA_01C900_050003","MA_01C900_050004")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_050006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ケイ★★:なんだ、その表情は
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_050007")

-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや…あんたにそんなこと言われるなんて<br>思わなかったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_050008")

	change_face(Actor002,"Sad")

	--★★ケイ★★:そうか？…いや、そうだな
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_050009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気にしないでくれ<br>もう慣れたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_050011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:誰かさんから次々と無理難題を押し付けられて<br>鍛えられた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_050012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ケイ★★:…それは、誰のことを言っているのかね
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_050013")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:さぁ？誰だろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_050014")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:継承者ならば背負って当然だと<br>以前の私であれば思っていたかもしれない
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_050016")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:思えば私は、ずっとそうだった
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_050017")

	change_face(Actor002,"Sad")

	--★★ケイ★★:選ばれぬ者ならば選ばれぬ者なりに<br>役に立とうと考え、務めてきた
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_050019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力

	--★★ケイ★★:だが結局それは<br>私の自己満足に過ぎなかった
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_050020")


	--★★ケイ★★:…それどころか<br>重荷にすらなっていたのかもしれん
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_050021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:重荷なんて、俺は思わなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_050023")

	change_face(Actor002,"Surprise")

	--★★ケイ★★:む…？
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_050024")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:重すぎる荷物はいつだって<br>皆が一緒に背負ってくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_050025")


	--★★ノワール★★:文句と悪態のオンパレードだったけど<br>それでも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_050026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:この学園は、そういう場所だったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_050027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115034)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
