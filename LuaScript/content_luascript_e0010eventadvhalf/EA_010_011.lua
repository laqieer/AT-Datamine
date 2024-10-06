-- このluaスクリプトは、EA_010_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100021_02","100021_02_h")
Include("content_adv_advsmall_100021_02","Template100021_02_h")
-- ▼直接出力
Include("content_luascript_common","PlayerControllerData")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100021_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleName100021_02,CameraPos100021_02_001)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPos100021_02_014,CameraAssetBundleName100021_02,CameraPos100021_02_014)
	Camera003 = SetTemplate("Actor003",nil,CharaPos100021_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleName100021_02,CameraPos100021_02_003)
	InitializeTemplateRandomCamera100021_02()
	InitializeTemplate100021_02()
-- ▼直接出力
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
　set_enable_auto_lookat_all(false)

CUT10 =  cat_template_camera("P10_Cam")
CUT11 =  cat_template_camera("P11_Cam")
CUT12 =  cat_template_camera("P12_Cam")
CUT13 =  cat_template_camera("P13_Cam")
CUT14 = cat_template_camera("P14_Cam", Actor002)
CUT16 =  cat_template_camera("P16_Cam")
CUT17 =  cat_template_camera("P17_Cam", Actor002)
CUT19 =  cat_template_camera("P19_Cam")
CUT20 =  cat_template_camera("P20_Cam")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
load_image("MA01B1092901", "content_still_10105001_image", "101050010_StillImage")
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("201010680", "content_still_20101068_image", "201010680_StillImage")
load_image("201010210", "content_still_20101021_image", "201010210_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
heroId = GetPlayerStyleId()
    local controllerName = GetE0010PlayerController(heroId)
    set_animationcontroller(Actor002,controllerName, "to wakeUp_start_pose")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Armoury")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_LTeinn")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100021)
	Actor001 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	Actor003 = InitializeCharacter_3D("101002","001","101002001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101002","001","101002001")
	Actor005 = InitializeCharacter_2DOnly("101059","001","101059001")
	Actor006 = InitializeCharacter_TextOnly()
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★銀髪の少女★★:
	Talk(Actor004,"NPCNAME_0311","simple","L","EA_010_0110003")


	--★★銀髪の少女★★:救いようのない私は<br>顔を上げられないままだ
	Talk(Actor004,"NPCNAME_0311","simple","L","EA_010_0110005")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2 + 0.2)
show_image("201010210", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力

	--★★テロップ★★:日本　東京　六千年学園<br>２ＸＸＸ年
	Talk(Actor006,"","simple","L","EA_010_0110006")

-- ▼直接出力
CloseTalkWindow() 
fadeout(0,0,0,0.2, 0.2)
wait_time(1+ 0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(0.8 + 0.2)--0.6秒+0.5秒
fadein(0.2)
-- ▲直接出力

	--★★バルバロイ★★:キャキャキャキャキャキャキャキャ
	Talk(Actor007,"CHRNAME_BARBAROI","speech","L","EA_010_0110007")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0033")
-- ▲直接出力

	--★★銀髪の少女★★:イラつく笑い声
	Talk(Actor004,"NPCNAME_0311","speech","L","EA_010_0110008")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2 + 0.2)
show_image("MA01B1092901", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.75,0.75)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
se_play("SE_ADV_EA_010_011_Sword_Slash_01")
wait_time(2.0)
fadein(0.2)
wait_time(0.2)
-- ▲直接出力

	--★★バルバロイ★★:キャキャキャキャキャキャキャキャ！！<br>キャキャキャキャキャキャキャキャ！！
	Talk(Actor007,"CHRNAME_BARBAROI","simple","L","EA_010_0110010")


	--★★銀髪の少女★★:消すよ
	Talk(Actor004,"NPCNAME_0311","simple","L","EA_010_0110011")

-- ▼直接出力
CloseTalkWindow() 
se_play("SE_ADV_EA_010_011_Sword_Slash_02")
fadeout(0,0,0,0.2, 0.2)
wait_time(1+ 0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(0.2)
se_play("SE_ADV_EA_010_011_Sword_Slash_03")
wait_time(0.5 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★銀髪の少女★★:痛くても、笑ってみてよ
	Talk(Actor004,"NPCNAME_0311","speech","L","EA_010_0110014")

-- ▼直接出力
bgm_play("BGM_ADV_Armoury")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT10)
wait_time(1.5)
hide_image(BLACK_WHITE_TIME)
--目覚まし180フレ
PlayActionDirect(Actor002,"to wakeUp")
wait_time(6.0)
setup_small_camera_start(CUT11)
Appear(Actor001)
--主観視点見回し100フレ
wait_time(3.3)
lookat_delay_weight_default(Actor002, 1)
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookat_delay_weight_default(Actor001, 1)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0009")
-- ▲直接出力

	--★★猫？★★:深い眠りであったな<br><%player>
	Talk(Actor005,"NPCNAME_0312","speech","L","EA_010_0110021")

-- ▼直接出力
wait_time(1.0)
setup_small_camera_start(CUT12)
-- ▲直接出力
-- ▼直接出力
heroId = GetPlayerStyleId()
    local controllerName = GetE0010CommonPlayerController(heroId)
    set_animationcontroller(Actor002,controllerName, "to Std_Loop")
-- ▲直接出力

	--★★猫？★★:キサマにとってワタシは<br>久しぶりの再会といったところか
	Talk(Actor005,"NPCNAME_0312","speech","L","EA_010_0110025")

-- ▼直接出力
CloseTalkWindow()
shake_camera(CUT12, 0.42, 3.5)
se_play("SE_ADV_MA_01A111_14_Earthquake")
se_play("SE_LoopSE_Stop")
wait_time(3.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0033")
-- ▲直接出力

	--★★猫？★★:懐かしむ時間はない<br>改めて自己紹介と状況の説明をしよう
	Talk(Actor005,"NPCNAME_0312","speech","L","EA_010_0110026")

-- ▼直接出力
setup_small_camera_start(CUT13)
-- ▲直接出力

	--★★アルハン★★:ワタシはアルハン<br>継承者を導く者
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0110027")

-- ▼直接出力
setup_small_camera_start(CUT14)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★アルハン★★:
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0110028")

	open_select_window_tag(Actor002,"Normal","EA_010_0110030")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
setup_small_camera_start(CUT16)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アルハン★★:世界の終わりが近い
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0110032")

	change_face(Actor001,"Normal")

	--★★アルハン★★:『バルバロイ』という出自不明の怪物が<br>世界を覆い尽くしているのだ
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0110033")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0013")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アルハン★★:<ruby=バルバロイ>謎の怪物</ruby>を倒して世界を救うには<br>伝説の武器が必要…よくあるハナシだ
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0110034")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
--スチル表示
show_image("201010680", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)--0.6秒+0.5秒
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アルハン★★:
	Talk(Actor001,"NPCNAME_0313","simple","L","EA_010_0110037")


	--★★アルハン★★:キサマは武器を得るために<br>武器を継承せし者の記憶・歴史へと潜ったのだ
	Talk(Actor001,"NPCNAME_0313","simple","L","EA_010_0110038")

-- ▼直接出力
CloseTalkWindow()
--スチル終了
hide_image(STILL_SWITCH_TIME) --0.6秒
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) --0.6秒 + 0.8秒
-- ▲直接出力

	--★★アルハン★★:過去の歴史上で観測した武器を<br><ruby=さいご>この現代</ruby>へと<dot>継承</dot>し、召喚…使役できる<dot>者</dot>──
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0110040")

	change_face(Actor001,"Anger")

	--★★アルハン★★:世界の救世主<br>『最後の継承者』としてな
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0110044")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT13)
--アルハンお辞儀
PlayActionDirect(Actor001,"to Bow")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アルハン★★:…このアルハンが<br>誰よりも高い位置にある頭を下げて頼もう
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0110045")

-- ▼直接出力
setup_small_camera_start(CUT17)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★アルハン★★:手を、貸してくれ
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0110046")

-- ▼直接出力
CloseTalkWindow()
--レヴァ足音
character_in_move_walk_offset(Actor003,CharaPos003,0,0,-2.5,2.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0002")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★銀髪の少女★★:ねぇ、アルハンに手を貸すより<br>こっちに来てよ
	Talk(Actor004,"NPCNAME_0311","speech","L","EA_010_0110048")

-- ▼直接出力
CloseTalkWindow()
--主人公向き直し
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,180,0.35)
wait_time(0.35)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
setup_small_camera_start(CUT19)
PlayActionDirect(Actor003,"to WalkEnd_pose")
character_in_move_walk_offset(Actor003,CharaPos003,0,0,-2.5,2.0)
PlayActionDirect(Actor003,"to WalkEnd")
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★銀髪の少女★★:私は六千年学園・<ruby=けいしゅかい>継守会</ruby>
	Talk(Actor004,"NPCNAME_0311","speech","L","EA_010_0110050")

-- ▼直接出力
bgm_play("BGM_Battle_LTeinn")
-- ▲直接出力

	--★★レーヴァテイン★★:レーヴァテイン
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","EA_010_0110054")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT20)
--手を差し出す
PlayActionDirect(Actor003,"to TakeHand")
-- ▲直接出力

	--★★レーヴァテイン★★:あなたを<br>迎えに来た
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","EA_010_0110055")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
load_image_preload("MA01B1092901", "content_still_10105001_image", "101050010_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("201010680", "content_still_20101068_image", "201010680_StillImage")
load_image_preload("201010210", "content_still_20101021_image", "201010210_StillImage")
heroId = GetPlayerStyleId()
preload_sound("BGM_ADV_Armoury")
preload_sound("BGM_Battle_LTeinn")
	InitializeLoad_Preload()
	load_area_scene_preload(100021)
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101002","001","101002001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101002","001","101002001")
	InitializeCharacter_2DOnly_Preload("101059","001","101059001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName100021_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
