-- このluaスクリプトは、MA_00200_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100021_01","100021_01_h")
Include("content_adv_advsmall_100021_01","Template100021_01_h")
-- ▼直接出力
Include("content_luascript_common", "SceneCommonPack")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_MA00100_15_Controller","to Sit01_Loop",CameraAssetBundleName100021_01,CameraPos100021_01_002)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPos100021_01_001,CameraAssetBundleName100021_01,CameraPos100021_01_001)
	InitializeTemplateRandomCamera100021_01()
	InitializeTemplate100021_01()
-- ▼直接出力
 --ボタン制御
ShowGlobalMenuButton(false)
load_image("10105001", "content_still_10105001_image", "101050010_StillImage")
load_image("10105017", "content_still_10105017_image", "101050170_StillImage")
load_image("10105018", "content_still_10105018_image", "101050180_StillImage")
load_image("10105019", "content_still_10105019_image", "101050190_StillImage")
load_image("10105020", "content_still_10105020_image", "101050200_StillImage")
load_image("10101014", "content_still_10101014_image", "101010140_StillImage") 
show_image("10101014", 0.0, 0.0, 0 ,true,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
ARUHAN_CAMERA1 = create_camera()
load_camera_anim(ARUHAN_CAMERA1, CameraAssetBundleName100021_01, CameraPos005)
ARUHAN_CAMERA2 = create_camera()
load_camera_anim(ARUHAN_CAMERA2, CameraAssetBundleName100021_01, CameraPos006)
ARUHAN_CAMERA3 = create_camera()
load_camera_anim(ARUHAN_CAMERA3, CameraAssetBundleName100021_01, CameraPos007)
ARUHAN_CAMERA4 = create_camera()
load_camera_anim(ARUHAN_CAMERA4, CameraAssetBundleName100021_01, CameraPos008)
ARUHAN_CAMERA5 = create_camera()
load_camera_anim(ARUHAN_CAMERA5, CameraAssetBundleName100021_01, CameraPos009)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
heroId = GetPlayerStyleId()
-- ▲直接出力
-- ▼直接出力
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
-- ▲直接出力
-- ▼直接出力
initialize_MA0010023(heroIdshort)
-- ▲直接出力
-- ▼直接出力
Ef_Flash1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash01", false, true)
-- ▲直接出力
-- ▼直接出力
Ef_Flash2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash01", false, true)
-- ▲直接出力
-- ▼直接出力
Ef_Flash3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash01", false, true)
-- ▲直接出力
-- ▼直接出力
Ef_warp_In1 =  load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_IN_ADV",false,true)
-- ▲直接出力
-- ▼直接出力
Ef_warp_In2 =  load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_IN_ADV",false,true)
-- ▲直接出力
-- ▼直接出力
Ef_warp_In3 =  load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_IN_ADV",false,true)
-- ▲直接出力
-- ▼直接出力
Ef_warp_Out1 =  load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true)
-- ▲直接出力
-- ▼直接出力
Ef_warp_Out2 =  load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true)
-- ▲直接出力
-- ▼直接出力
Ef_warp_Out3 =  load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true)
-- ▲直接出力
-- ▼直接出力
set_pos(Ef_warp_Out1,{CharaPos100021_01_002[1],0.87,CharaPos100021_01_002[3]})
set_pos(Ef_warp_Out2,{CharaPos100021_01_003[1],1.595,CharaPos100021_01_003[3]})
set_pos(Ef_warp_Out3,{CharaPos100021_01_004[1],1.0,CharaPos100021_01_004[3]})
set_pos(Ef_warp_In1,{CharaPos100021_01_003[1],1.595,CharaPos100021_01_003[3]})
set_pos(Ef_warp_In2,{CharaPos100021_01_004[1],1.0,CharaPos100021_01_004[3]})
set_pos(Ef_warp_In3,{CharaPos100021_01_002[1],0.87,CharaPos100021_01_002[3]})
set_scale(Ef_warp_In1, {0.3, 0.3, 0.3})
set_scale(Ef_warp_In2, {0.3, 0.3, 0.3})
set_scale(Ef_warp_In3, {0.3, 0.3, 0.3})
set_scale(Ef_warp_Out1, {0.3, 0.3, 0.3})
set_scale(Ef_warp_Out2, {0.3, 0.3, 0.3})
set_scale(Ef_warp_Out3, {0.3, 0.3, 0.3})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
CameraEx = set_camera({0,Yof, -15.32,   0, 180, 0,   19})
CameraEx1 = set_camera({-0.77, 1.38, -31.68,   0, 160.4438, 0,   18})
CameraEx2 = set_camera({-1.91, 1.318, -32.52,   0, 141.0856, 0,   18})
CameraEx3 = set_camera({-1.029, 2.64, -39.935,   348, 3.803, 359.174,   23.25884})
CameraEx3_1={-1.029, 1.208, -39.935,   1.87734, 3.80342, 359.1739,   23.25884}
-- ▲直接出力
-- ▼直接出力
StPos1={0, 0, -47.5}
StPos2={0, 0, -34.9}
StPos3={-0.5, 0, -34.9}
set_pos(Actor002,StPos1)
-- ▲直接出力
-- ▼直接出力
subCmaera=RndCamera001
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
lookoj = {1.13, 1.5, -15.773,   65.0}
lookoj2 ={-0.8, 1.5, -15.773,   65.00001}
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_00100_21_Foot")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100021)
	Actor001 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
SetTrackingId(21)
on_camera(CameraEx3)
hide_image(1.0)
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,0, 0,-20.6,5.0)
slidemove2(CameraEx3,CameraEx3_1[1],CameraEx3_1[2],CameraEx3_1[3],4.25,3)
turn(CameraEx3,CameraEx3_1[4],CameraEx3_1[5],CameraEx3_1[6],4.25)
wait_time(5.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
PlayActionDirect(Actor002,"Run to Walk")
wait_time(0.5)
slidemove(Actor002,CharaPos100021_01_001[1],CharaPos100021_01_001[2],CharaPos100021_01_001[3],2.15)
wait_time(2.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
lookat_weight(Actor002,1.0, 0.3, 0.8, 0.35)
keep_delay_ik_lookat(Actor002,Actor001, "J_Hips",0.7)
wait_time(2.5)
on_camera(ARUHAN_CAMERA1)
wait_time(1.5)
-- ▲直接出力

	--★★アルハン★★:見下すな、仰ぎ見ろ<br>ワタシに耳をかたむけよ
	Talk(Actor001,"NPCNAME_0312","speech","L","MA_00200_020002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
on_camera(ARUHAN_CAMERA2)
PlayActionDirect(Actor001,"to float")
SkipDefaultMotion(Actor001)
wait_time(2.4)
on_camera(ARUHAN_CAMERA3)
wait_time(4.2)
lookat_delay_weight_reset(Actor002,0.7)
-- ▲直接出力
-- ▼直接出力
--アルハン,NPCNAME_0313 @名前変更
-- ▲直接出力

	--★★アルハン★★:ワタシはアルハン<br>継承者を導く者
	Talk(Actor001,"NPCNAME_0313","speech","L","MA_00200_020004")

-- ▼直接出力
setup_small_camera_end(Camera002)
SkipOffsetCamera(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★Player★★:…？
	Talk(Actor002,"PLAYERNAME_GENDAI","speech","L","MA_00200_020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アルハン★★:まもなく世界は終わり<br>歴史は幕を閉じる
	Talk(Actor001,"NPCNAME_0313","speech","L","MA_00200_020008")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("10105017", 0.0, 0.0, 0 ,true,true)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(STILL_ACTIVE_AFTER)
-- ▲直接出力

	--★★アルハン★★:人類の歴史は<br><ruby=バルバロイ>侵略者</ruby>との戦いの歴史
	Talk(Actor001,"NPCNAME_0313","simple","N","MA_00200_020012")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.5)
wait_time(1.0)
show_image("10105018", 0.0, 0.0, 0 ,true,true)
fadein(0.5)
wait_time(1.0)
-- ▲直接出力

	--★★アルハン★★:歴史の節目節目に来襲するバルバロイ<br>人間たちはその都度武器を取り、妨げ続けてきた
	Talk(Actor001,"NPCNAME_0313","simple","N","MA_00200_020014")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.5)
wait_time(1.0)
show_image("10105001", 0.0, 0.0, 0 ,true,true)
fadein(0.5)
wait_time(1.0)
-- ▲直接出力

	--★★アルハン★★:だがそれも限界だ<br>未曾有の脅威が迫っている
	Talk(Actor001,"NPCNAME_0313","simple","N","MA_00200_020016")


	--★★アルハン★★:
	Talk(Actor001,"NPCNAME_0313","simple","N","MA_00200_020018")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
hide_image(0)
on_camera(CameraEx)
DontChangeRandomCamera(true)
slidemove(CameraEx,{0,Yof,-14.14},10.0)
fadein(FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
-- ▲直接出力

	--★★アルハン★★:お前だ<br><dot>最後の継承者</dot><%player>
	Talk(Actor001,"NPCNAME_0313","speech","L","MA_00200_020021")

-- ▼直接出力
wait_time(0.8)
setup_small_camera_start(ARUHAN_CAMERA5)
-- ▲直接出力

	--★★アルハン★★:キサマのあとに<br>歴史は続かない
	Talk(Actor001,"NPCNAME_0313","speech","L","MA_00200_020023")

	change_face(Actor001,"Smile")

	--★★アルハン★★:世界がどうなろうとな
	Talk(Actor001,"NPCNAME_0313","speech","L","MA_00200_020025")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
fadeout(1,1,1,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("10105019", 0.0, 0.0, 0 ,true,true)

fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(STILL_ACTIVE_AFTER)
-- ▲直接出力

	--★★アルハン★★:過去、バルバロイを討ったのは伝説の武器たちだ<br>それを現在まで継承してくれた者たちがいる
	Talk(Actor001,"NPCNAME_0313","simple","N","MA_00200_020027")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
fadeout(0,0,0,1.0,0.5)
wait_time(0.5)
show_image("10105020", 0.0, 0.0, 0 ,true,true)
fadein(1.0)
wait_time(1.25)
-- ▲直接出力

	--★★アルハン★★:だがその武器は時の流れにより風化し<br>今や元来の力を発揮できる状態ではない
	Talk(Actor001,"NPCNAME_0313","simple","N","MA_00200_020029")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.5)
wait_time(1.0)
hide_image(0)
setup_small_camera_start()
fadein(0.5)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
 --瞬間移動演出
on_active(Ef_warp_Out1)
play_particle(Ef_warp_Out1)
wait_time(0.2)
Hide(Actor001)
wait_time(0.1)
on_active(Ef_warp_In1)
play_particle(Ef_warp_In1)
set_pos(Actor001,{CharaPos100021_01_003[1],CharaPos100021_01_003[2],CharaPos100021_01_003[3]})
set_rot(Actor001,{0,CharaPos100021_01_003[4],0})
wait_time(0.3)
Appear(Actor001)
wait_time(0.5)
lookat_position(Actor002,lookoj)
lookat_delay_weight_default(Actor002,0.7)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アルハン★★:終末を回避するためには<br>武器の歴史へと潜り…
	Talk(Actor001,"NPCNAME_0313","speech","L","MA_00200_020031")

-- ▼直接出力
 --瞬間移動演出
CloseTalkWindow()
on_active(Ef_warp_Out2)
play_particle(Ef_warp_Out2)
wait_time(0.2)
Hide(Actor001)
wait_time(0.1)
on_active(Ef_warp_In2)
play_particle(Ef_warp_In2)
set_pos(Actor001,{CharaPos100021_01_004[1],CharaPos100021_01_004[2],CharaPos100021_01_004[3]})
set_rot(Actor001,{0,CharaPos100021_01_004[4],0})
wait_time(0.3)
Appear(Actor001)
lookat_delay_weight_reset(Actor002,0.7)
-- ▲直接出力

	--★★アルハン★★:それらの記憶を呼び覚ます必要がある
	Talk(Actor001,"NPCNAME_0313","speech","L","MA_00200_020033")

-- ▼直接出力
 --瞬間移動演出
on_active(Ef_warp_Out3)
play_particle(Ef_warp_Out3)
wait_time(0.2)
Hide(Actor001)
wait_time(0.1)
on_active(Ef_warp_In3)
play_particle(Ef_warp_In3)
set_pos(Actor001,{CharaPos100021_01_002[1],CharaPos100021_01_002[2],CharaPos100021_01_002[3]})
set_rot(Actor001,{0,CharaPos100021_01_002[4],0})
wait_time(0.3)
Appear(Actor001)
-- ▲直接出力
-- ▼直接出力
 --一応消しておく
off_active(Ef_warp_Out1)
off_active(Ef_warp_Out2)
off_active(Ef_warp_Out3)
off_active(Ef_warp_In1)
off_active(Ef_warp_In2)
off_active(Ef_warp_In3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(ARUHAN_CAMERA4)
-- ▲直接出力

	--★★アルハン★★:武器に秘められた歴史の可能性を<br>キサマが体験し、一本に<dot>選び抜く</dot>のだ
	Talk(Actor001,"NPCNAME_0313","speech","L","MA_00200_020035")


	--★★アルハン★★:
	Talk(Actor001,"NPCNAME_0313","speech","L","MA_00200_020037")


	--★★アルハン★★:その<ruby=レアリティ>稀少性</ruby>が力となる
	Talk(Actor001,"NPCNAME_0313","speech","L","MA_00200_020039")

-- ▼直接出力
CloseTalkWindow()
fadeout(1,1,1, 1.0,BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 1.0)
-- ▲直接出力
-- ▼直接出力
play_MA0010023()
Play_end(true)
SetTrackingId(22)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10105001", "content_still_10105001_image", "101050010_StillImage")
load_image_preload("10105017", "content_still_10105017_image", "101050170_StillImage")
load_image_preload("10105018", "content_still_10105018_image", "101050180_StillImage")
load_image_preload("10105019", "content_still_10105019_image", "101050190_StillImage")
load_image_preload("10105020", "content_still_10105020_image", "101050200_StillImage")
load_image_preload("10101014", "content_still_10101014_image", "101010140_StillImage")
load_camera_anim_preload(ARUHAN_CAMERA1, CameraAssetBundleName100021_01, CameraPos005)
load_camera_anim_preload(ARUHAN_CAMERA2, CameraAssetBundleName100021_01, CameraPos006)
load_camera_anim_preload(ARUHAN_CAMERA3, CameraAssetBundleName100021_01, CameraPos007)
load_camera_anim_preload(ARUHAN_CAMERA4, CameraAssetBundleName100021_01, CameraPos008)
load_camera_anim_preload(ARUHAN_CAMERA5, CameraAssetBundleName100021_01, CameraPos009)
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
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash01", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash01", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash01", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_IN_ADV",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_IN_ADV",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_IN_ADV",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true)
StPos1={0, 0, -47.5}
StPos2={0, 0, -34.9}
StPos3={-0.5, 0, -34.9}
subCmaera=RndCamera001
lookoj = {1.13, 1.5, -15.773,   65.0}
lookoj2 ={-0.8, 1.5, -15.773,   65.00001}
	InitializeLoad_Preload()
	load_area_scene_preload(100021)
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName100021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
