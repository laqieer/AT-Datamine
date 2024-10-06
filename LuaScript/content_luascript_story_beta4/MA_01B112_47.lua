-- このluaスクリプトは、MA_01B112_47.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera003 = SetTemplate("Actor003",328.5131,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera004 = SetTemplate("Actor004",96.00001,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera005 = SetTemplate("Actor005",30.75584,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_animationbattlecontroller(Actor003, 1, false)
set_animationbattlecontroller(Actor004, 1, false)
sword_01 = setup_prop_object(10101035)
sword_02 = setup_prop_object(10101035)
weapon_offset = {0,0,0,0,0,0}
on_parent(sword_01,Actor003, "Loc_weapon_constrint_R",weapon_offset)
on_parent(sword_02,Actor004, "Loc_weapon_constrint_R",weapon_offset)
set_pos(Actor003, {6.844, 0, 11.379})
set_pos(Actor004, {5.543, 0, 11.998})
set_pos(Actor005, {5.778, 0, 10.606})
BgProp = setup_prop_object(10102012)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115119)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401018","001","401018001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:水色なんだって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_470002")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力

	--★★ランスロット★★:なにがだ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:このあいだディナタンが言ってたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_470004")

	change_face(Actor002,"Surprise")

	--★★ランスロット★★:水………？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ランスロットは<br>「水みたいに綺麗で、透明な人」だって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_470006")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:「つかみどころがない」…ということだろうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_470009","MA_01B112_470010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:たしかにつかみどころはないな<br>なにを考えてるかわからないときが多いし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_470012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:いまだに俺に隠しごとをしてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_470013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…すまない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたは俺にはなくてはならない存在だ<br>人の生活に水が必要なように
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_470016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そういう意味かなって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_470017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…そうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470018")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
wait_time(4.0)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:──決闘ごっこを、していたな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470020")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:懐かしい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470021")


	--★★ランスロット★★:いつもノワールから申し込まれて
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…いつも、負けて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_470023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:手を抜くのは良くないからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470024")

	open_select_window_tag(Actor001,"Normal","MA_01B112_470025","MA_01B112_470026")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:１回くらい勝たせてくれても良かったのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_470028")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:本気で言っているのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470029")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:手を抜けば──嘘の勝利を与えてしまえば<br>お前は俺に呆れたはずだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:２度と決闘を申し込まれることは<br>ないだろうと思った
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470031")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:勝つまでやるつもりだったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_470033")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そのつもりなんだろうと思っていた<br>だから負けるわけにはいかなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470034")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:決闘を申し込まれるたびに<br>ひやひやした
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:お前との時間が終わるのが<br>なによりも嫌だったんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470036")

	goto Block2end

::Block2end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺を追いかけてくれる<br>お前が好きだった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470038")


	--★★ランスロット★★:今もそうだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470039")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…ありがとう。ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470040")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:この時間がなによりの贈り物だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_470041")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101035)
setup_prop_object_preload(10101035)
weapon_offset = {0,0,0,0,0,0}
setup_prop_object_preload(10102012)
	InitializeLoad_Preload()
	load_area_scene_preload(115119)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401018","001","401018001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
