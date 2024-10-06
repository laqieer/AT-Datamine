-- このluaスクリプトは、MA_01107_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera008 = SetTemplate("Actor008",0,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera012 = SetTemplate("Actor012",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
load_image("102010080_StillImage", "content_still_10201008_image", "102010080_StillImage")
load_image("10301015", "content_still_10301015_image", "103010150_StillImage")
DontChangeRandomCamera(true)
set_pos(Actor008,{1.4,0,-10.5})
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
DontCameraOffset(Actor009)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor010)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor011)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor012)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115060)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor012")
	Actor013 = InitializeCharacter_2DOnly("101050","001","101050001")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
se_play("SE_ADV_MA_01104_20_DoorOpen")
wait_time(0.6)
PlayActionDirect(Actor008,"to Run")
slidemove(Actor008,{1.4,0,-6.5},1)
wait_time(0.8)
PlayActionDirect(Actor008,"to Std_Loop")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:円卓会議中に失礼いたします！
	Talk(Actor008,"NPCNAME_0124","speech","N","MA_01107_290002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Worry")
turn_chara(Actor007,35,0.5)
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★ルーシャス★★:去れ、興が削がれる
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_290003")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★アーサー★★:話してくれるかな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_290005")

-- ▼直接出力
set_common_look_at(Actor007,Actor005)
PlayActionDirect(Actor007,"to Std_Loop")
turn_chara(Actor007,0,1)
-- ▲直接出力

	--★★ルーシャス★★:…余よりも優先して相手すべきだと？
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_290006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:俺にとっては大切なゲストだ、どちらもな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_290007")

	change_face(Actor005,"Smile")

	--★★アーサー★★:卓を囲む者は全てに平等<br>それが円卓の騎士の精神でね
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_290008")

	PlayAction(Actor007,"to  Std_Talk")
	change_face(Actor007,"Normal")

	--★★ルーシャス★★:なるほど「ローマではローマ人のごとくせよ」<br>ログレスでは国王のやりかたに従おう
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_290010")

	change_face(Actor010,"Surprise")

	--★★パーシヴァル★★:…ホッ
	Talk(Actor010,"CHRNAME_PERCIVAL","speech","L","MA_01107_290012")

	change_face(Actor011,"Sad")

	--★★ガレス★★:空気ピリつくね～
	Talk(Actor011,"CHRNAME_GARETH","speech","L","MA_01107_290013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ケイ★★:なにがあった？
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01107_290015")

-- ▼直接出力
CloseTalkWindow()
show_image("102010080_StillImage", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:ソールズベリー平原にて<br>キラーズを伴った騎士がカレドニア軍と交戦中！
	Talk(Actor008,"NPCNAME_0124","simple","N","MA_01107_290016")


	--★★キャメロット軍兵士_下位★★:カレドニアのバルバロイ混成部隊に対し<br>たった2人のみで踏み止まっている模様！
	Talk(Actor008,"NPCNAME_0124","simple","N","MA_01107_290017")

	open_cutin(2,1)
	on_cutin(1,Actor011,"Surprise")

	--★★ガレス★★:ソールズベリー平原って…<br>そんな近くまで敵がいきなり来てるの！？
	Talk(Actor011,"CHRNAME_GARETH","simple","N","MA_01107_290018")

	on_cutin(2,Actor006,"Surprise")

	--★★ケイ★★:ば、ばかな…我らは島東部のカーライル城まで<br>カレドニアを押し返しているのだぞ…？
	Talk(Actor006,"CHRNAME_KAY","simple","N","MA_01107_290019")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME) 
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
-- ▲直接出力

	--★★トリスタン★★:相当お尻に火が点いて突っ込んで来たか<br>それともなにか狙いがあってのことか
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01107_290020")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:てか、それを止めてる騎士っつーのがスゲエよ！<br>ふたりだけでカレドニア軍相手にしてんだろ！？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01107_290021")


	--★★ヴォールス★★:その活躍…<br><ruby=ランスロット>最強騎士</ruby>にも匹敵するな
	Talk(Actor009,"CHRNAME_BORS","speech","L","MA_01107_290022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_290024")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301015", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ブライアン★★:ランスロットは最強の騎士だ
	Talk(Actor013,"CHRNAME_BRIAN","simple","N","MA_01107_290026")


	--★★ブライアン★★:カレドニアのライエンス率いる王の軍勢を<br>単騎で百人以上蹴散らしたって話もある
	Talk(Actor013,"CHRNAME_BRIAN","simple","N","MA_01107_290027")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image()
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")

	--★★キャメロット軍兵士_下位★★:その者は『銀卓騎士団』を名乗り
	Talk(Actor008,"NPCNAME_0124","speech","N","MA_01107_290029")


	--★★キャメロット軍兵士_下位★★:「ランスロット卿は何処か」と<br>声を上げております！
	Talk(Actor008,"NPCNAME_0124","speech","N","MA_01107_290030")

	change_face(Actor002,"Surprise")

	--★★ランスロット★★:…俺を？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_290032")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)

	--★★キャメロット軍兵士_下位★★:また、カレドニア軍には<br>王の軍勢らしき影も──
	Talk(Actor008,"NPCNAME_0124","speech","N","MA_01107_290033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:…ランス
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_290034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…──フォー・ラウンド
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_290035")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102010080_StillImage", "content_still_10201008_image", "102010080_StillImage")
load_image_preload("10301015", "content_still_10301015_image", "103010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115060)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor012")
	InitializeCharacter_2DOnly_Preload("101050","001","101050001")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
