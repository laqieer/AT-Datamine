-- このluaスクリプトは、EA_072_037.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation06","DuelCommonFormation06_h")
Include("content_adv_advsmall_duelcommonformation06","TemplateDuelCommonFormation06_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-200,CharaPosDuelCommonFormation06_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation06,CameraPosDuelCommonFormation06_002)
	InitializeTemplateRandomCameraDuelCommonFormation06()
	InitializeTemplateDuelCommonFormation06()
-- ▼直接出力
load_image("101030280","content_still_10103028_image","101030280_StillImage")
load_image("101030190","content_still_10103019_image","101030190_StillImage")
set_pos(Actor001,{0.57,0,14.1})
-- ▲直接出力
-- ▼直接出力
CUT10 =  cat_template_camera("P10_Cam")
CUT11 =  cat_template_camera("P11_Cam")
CUT16 =  cat_template_camera("P16_Cam")
CUT18 =  cat_template_camera("P18_Cam")
CUT20 =  cat_template_camera("P20_Cam")
CUT24 =  cat_template_camera("P24_Cam")
CUT25 =  cat_template_camera("P25_Cam")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RndCamera001=CUT10
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101220013)
	Actor001 = InitializeCharacter_3D("101011","002","101011002","content_animationpack__common","FacialPack","Actor001")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(2.5)
setup_small_camera_start(CUT16)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0025")
-- ▲直接出力

	--★★ギネヴィア★★:ノワール<br>着てくれたかな
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370005")


	--★★ギネヴィア★★:<dot>ヨソ行きの服</dot>
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370006")


	--★★テロップ★★:日本　東京　六千年学園<br>２ＸＸＸ年
	Talk(Actor003,"","narration","N","EA_072_0370008")

-- ▼直接出力
CloseTalkWindow()
wait_time(1)
setup_small_camera_start(CUT25)
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………ショージキな話
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370010")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Sad02")
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★ギネヴィア★★:あたまが<br>おかしくなりそうだったよ
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370011")


	--★★ギネヴィア★★:聖遺物化して<br>誰もわたしを覚えてない世界をあとにして
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370012")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ギネヴィア★★:後悔と決意の繰り返しで<br>聖遺物のなかに一千年以上
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370013")

-- ▼直接出力
setup_small_camera_start(CUT11)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:目が覚めてみれば見覚えのない景色で
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370014")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:ふふ<br>見覚えしかない敵！
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370015")

-- ▼直接出力
CloseTalkWindow()
wait_time(1)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…あなたもいない<br>お姉ちゃんもいない、だぁれもいない
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370016")

-- ▼直接出力
setup_small_camera_start(CUT24)
-- ▲直接出力

	--★★ギネヴィア★★:ひとりぼっちで
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370017")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT16)
wait_time(1)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…けど、わたし
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370019")

	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:わたしね？ノワール
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","EA_072_0370020")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
show_image("101030280", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) 
set_scale_image(0.9,0.9)
on_cameraframe(2)
wait_time(0.3 + 0.2)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
wait_time(0.7)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:ひとりで来られたよ
	Talk(Actor001,"CHRNAME_GUINEVERE2","simple","N","EA_072_0370022")


	--★★ギネヴィア★★:あなたの隣には<br>いれないけど──
	Talk(Actor001,"CHRNAME_GUINEVERE2","simple","N","EA_072_0370023")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
show_image("101030190", 0.0, 0.0, 0, true,true)
set_scale_image(0.75,0.75)
on_screencolor(IMAGE_COLOR, 0, -50)
--フェードイン
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
wait_time(0.3)
-- ▲直接出力

	--★★ギネヴィア★★:手を繋いでるよ
	Talk(Actor001,"CHRNAME_GUINEVERE2","simple","N","EA_072_0370025")


	--★★ギネヴィア★★:あなたの思い出と<br>ずっと手を繋いでるよ
	Talk(Actor001,"CHRNAME_GUINEVERE2","simple","N","EA_072_0370026")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力

	--★★ギネヴィア★★:…──にっしっし
	Talk(Actor001,"CHRNAME_GUINEVERE2","simple","N","EA_072_0370027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101030280","content_still_10103028_image","101030280_StillImage")
load_image_preload("101030190","content_still_10103019_image","101030190_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101220013)
	InitializeCharacter_3D_Preload("101011","002","101011002","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation06)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
