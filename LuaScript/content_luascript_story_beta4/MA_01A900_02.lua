-- このluaスクリプトは、MA_01A900_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor007)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor009)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor010)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:これまででもっとも残酷な選択を<br>迫られるのだった
	Talk(Actor011,"telop","narration","N","MA_01A900_021001")


	--★★テロップ★★:
	Talk(Actor011,"telop","narration","N","MA_01A900_021002")


	--★★テロップ★★:皆<br>すまない
	Talk(Actor011,"telop","narration","N","MA_01A900_021003")


	--★★テロップ★★:ルーシャスの足取りは<br>なにひとつつかめぬままだ
	Talk(Actor011,"telop","narration","N","MA_01A900_021004")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:皆<br>すまない
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01A900_020002")


	--★★ケイ★★:ルーシャスの足取りは<br>なにひとつつかめぬままだ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01A900_020003")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★ケイ★★:悠長なことをやっている暇はないというのに<br>…本当にすまない
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01A900_020004")

	open_select_window_tag(Actor001,"Normal","MA_01A900_020006","MA_01A900_020007","MA_01A900_020008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや<br>別にあんたが謝る必要はない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_020010")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今のところは<br>目立った被害も聞こえてこないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_020011")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:年が明けたというのに<br>朗報のひとつもないなど…！くうっ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01A900_020012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:情報屋に伝手がある<br>聞いてみようか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_020014")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:キッスさんのことか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A900_020015")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ。魔女の情報まで<br>つかんでいるかはわからないが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_020016")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:焦ってもしょうがない<br>待つしかないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_020018")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:ルーシャスにしても魔女にしても<br>やることが派手だからね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01A900_020019")

	change_face(Actor003,"Normal")

	--★★トリスタン★★:行動を始めたら<br>すぐにわかるでしょ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01A900_020020")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:…大陸への出入り口である各港は封鎖<br>カレドニア城も引き続き監視しよう
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A900_020022")

	change_face(Actor005,"Smile")

	--★★アーサー★★:人手不足は相変わらずだが<br>休める時に休むのも仕事のひとつだ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A900_020023")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:努めて休んでくれたまえ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01A900_020024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:義兄さんもな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A900_020025")

-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:騎士たちに休みボケをされても困る<br>早急に敵を見つけるよ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01A900_020026")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:そりゃ困るなー<br>ケイ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A900_020027")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:精々余暇を楽しみ給え
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01A900_020029")

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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor010")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
