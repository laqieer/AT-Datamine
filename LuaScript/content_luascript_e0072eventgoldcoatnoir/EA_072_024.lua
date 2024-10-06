-- このluaスクリプトは、EA_072_024.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image("201010940", "content_still_20101094_image", "201010940_StillImage")
show_image("201010940", 0.0, 0.0, 0.0,true,false)
set_scale_image(1.0,1.0)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Snuggle")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101080011)
	Actor001 = InitializeCharacter_3D("101030","005","101030005","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","003","101009003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★エレイン★★:この傷は、勲章
	Talk(Actor001,"CHRNAME_ELAINE","simple","N","EA_072_0240003")


	--★★エレイン★★:『誰か』を守れた勲章
	Talk(Actor001,"CHRNAME_ELAINE","simple","N","EA_072_0240004")


	--★★エレイン★★:沢山のひとの前で<br>強くあった『誰か』のための
	Talk(Actor001,"CHRNAME_ELAINE","simple","N","EA_072_0240005")


	--★★エレイン★★:だから──…
	Talk(Actor001,"CHRNAME_ELAINE","simple","N","EA_072_0240006")


	--★★エレイン★★:…──逆巻け
	Talk(Actor001,"CHRNAME_ELAINE","simple","N","EA_072_0240007")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_LongFade")
fadeout(0,0,0,1.0,STILL_SWITCH_TIME)
setup_small_camera_start()
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
hide_image(0.0)
wait_time(1.0)
fadein(FADE_TIME)
wait_time(FADE_TIME+1.0)
bgm_play("BGM_ADV_Snuggle")
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0001")
-- ▲直接出力

	--★★エレイン★★:素敵な服ですね。先輩
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:ああ──…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240012")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ノワール★★:ログレスの、王妃の…部屋に<br>遺されていたものなんだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:知ってます
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0052")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:…え？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240015")


	--★★エレイン★★:私、そのひとと<br>文通していましたので
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★エレイン★★:…そのひとの顔も、私は<br>忘れてしまって…わかりませんけど
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240017")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★エレイン★★:その服に込めた想いは<br>手紙に書かれていました
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:………その、手紙には<br>なんて書かれていたんだ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240019")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★エレイン★★:先輩、野暮ですよ<br>淑女同士の文通内容を聞くのは
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ノワール★★:ご、ごめん
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240021")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★エレイン★★:…そのひとは<br>手紙から知る限り──
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240022")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0011")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★エレイン★★:すっごく貧乏性で！
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:…ああ。そうだな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240026")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★エレイン★★:服だけ『タダで』くれるひとじゃ<br>ないと思います
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240027")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:どういう、ことだ…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★エレイン★★:なにか遺されていませんか？<br>その服の…ポケットのどこかに
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240029")

	change_face(Actor002,"Normal")

	--★★ノワール★★:………？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240030")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME)
se_play("SE_ADV_EA_003_062_Cloth")
wait_time(6.7)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:あ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240032")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:ありました？
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:内ポケットのさらに奥に…なにか、ある…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240034")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★エレイン★★:きっと恥ずかしいから<br>隠してたんですね
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","EA_072_0240035")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:手紙…いや、これは──…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…──紙の欠片？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240037")

-- ▼直接出力
CloseTalkWindow()
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★テロップ★★:「ノワール様へ」
	Talk(Actor003,"","narration","N","EA_072_0240040")


	--★★ノワール★★:『ギネヴィア』の──
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_072_0240041")


	--★★テロップ★★:「修繕トラブルのお詫び！」
	Talk(Actor003,"","narration","N","EA_072_0240042")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("201010940", "content_still_20101094_image", "201010940_StillImage")
preload_sound("BGM_ADV_Snuggle")
	InitializeLoad_Preload()
	load_duel_scene_preload(101080011)
	InitializeCharacter_3D_Preload("101030","005","101030005","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","003","101009003","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
