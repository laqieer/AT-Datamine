-- このluaスクリプトは、MA_01A900_61.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114091_02","114091_02_h")
Include("content_adv_advsmall_114091_02","Template114091_02_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114091_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_03_MA01A900_61_Controller","to Std_Loop",CameraAssetBundleName114091_02,CameraPos114091_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114091_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_03_MA01A900_61_Controller","to Std_Loop",CameraAssetBundleName114091_02,CameraPos114091_02_002)
	InitializeTemplateRandomCamera114091_02()
	InitializeTemplate114091_02()
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10103013_anim", "10103013_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("10103025", "content_still_10103025_image", "101030250_StillImage") 
load_image("10103026", "content_still_10103026_image", "101030260_StillImage") 
load_image("10103027", "content_still_10103027_image", "101030270_StillImage") 
load_image("10103028", "content_still_10103028_image", "101030280_StillImage") 
-- ▲直接出力
-- ▼直接出力
CUT_01 = cat_template_camera("P10_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_02 = cat_template_camera("P11_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_03 = cat_template_camera("P12_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_04 = cat_template_camera("P13_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_05 = cat_template_camera("P14_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_06 = cat_template_camera("P15_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_07 = cat_template_camera("P16_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_08 = cat_template_camera("P17_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_08_1 = cat_template_camera("P18_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_09 = cat_template_camera("P19_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_10 = cat_template_camera("P20_Cam")
-- ▲直接出力
-- ▼直接出力
tegami2 = setup_prop_object(10106003)
tegami_offset2 = {0,-0.08,0,358.654,30.0615,275.411}
-- ▲直接出力
-- ▼直接出力
load_image("101010140_1", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140_1", 0.0, 0.0,0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Snuggle")
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(CUT_01)
-- ▲直接出力

	--★★エレイン★★:美しい<br>ってなんだと思います？
	Talk(Actor002,"CHRNAME_ELAINE","simple","L","MA_01A900_610002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
movie_load("MA_01A900_61")
movie_set_active(true)
movie_play()
movie_wait_playing()
movie_stop()
setup_small_camera_start(CUT_01)
hide_image(1.0)
wait_time(1.0)
--ムービー後待機
wait_time(MOVIE_AFTER)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:脳裏に焼き付いて離れない<br>刹那鮮烈に…精一杯咲き誇った誰かのことを
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610009")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Yes")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:追いかけてきたんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610010")


	--★★エレイン★★:その人に繋いでもらったんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610011")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610012")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_02)
wait_time(0.3)
-- ▲直接出力

	--★★エレイン★★:ずっと、一生、永遠に、私の命が続くかぎり<br>あなたをひとりぼっちにはさせません
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610013")


	--★★エレイン★★:あなたを愛した人たちのために
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610014")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_03)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Surp")
wait_time(0.18)
force_lipsync(Actor001,"Open2")
-- ▲直接出力

	--★★エレイン★★:あなたの心の片隅に<br>誰かの愛が遺っていても
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610015")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
force_lipsync(Actor001,"Close2")
setup_small_camera_start(CUT_04)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:一番近くに、いていいですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610016")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_05)
force_lipsync(Actor001,"Auto")
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:………俺も変わらなきゃ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610017")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Yes")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:…少しずつでいいんですよ、きっと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610018")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_No")
-- ▲直接出力

	--★★ノワール★★:悪い思い出にしたくないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610019")


	--★★ノワール★★:失うことなんて望まないし<br>キズや死がないに越したことはない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610020")


	--★★ノワール★★:だけど、あの日々があったから生きていける<br>そう思えるように…変わりたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610021")

	change_face(Actor002,"Normal")

	--★★エレイン★★:言えなかったこと、ありますか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610022")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Yes")
-- ▲直接出力

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610023")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力

	--★★エレイン★★:全部、残せますよ<br>どれも思い起こせますよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610024")

-- ▼直接出力
local CHT = 0.5
local STW = 1.5
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0, 1.0, CHT)
wait_time(CHT)
show_image("10103025", 0.0, 0.0, 0.0,true,false)
fadein(CHT)
wait_time(STW)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0, 1.0, CHT)
wait_time(CHT)
show_image("10103026", 0.0, 0.0, 0.0,true,false)
fadein(CHT)
wait_time(STW)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0, 1.0, CHT)
wait_time(CHT)
show_image("10103027", 0.0, 0.0, 0.0,true,false)
fadein(CHT)
wait_time(STW)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0, 1.0, CHT)
wait_time(CHT)
show_image("10103028", 0.0, 0.0, 0.0,true,false)
fadein(CHT)
wait_time(STW)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0, 1.0, CHT)
wait_time(CHT + 1)
hide_image(0)
setup_small_camera_start(CUT_06)
fadein(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力

	--★★エレイン★★:「さびしい」も「あいたい」も「さよなら」も<br>「ありがとう」も「あいしている」も
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610026")


	--★★エレイン★★:忘れ得ぬ日々を愛おしく思える日が<br>きっと来ますから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610027")


	--★★エレイン★★:追想しませんか、一緒に
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610028")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610029")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor002,"to SendLetter01")
setup_small_camera_start(CUT_07)
wait_time(4.0)
-- ▲直接出力

	--★★ノワール★★:………赤い、スカーフ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610031")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
on_active(tegami2)
set_enable_auto_lookat(Actor001, false)
on_parent(tegami2,Actor001, "Loc_weapon_constrint_R", tegami_offset2)
-- 注視位置へのweight設定を変えることで振り向きます
lookat_delay_weight_default(Actor001, 0.5)
-- weight設定前は注視位置の指定をしたあと
keep_ik_lookat(Actor001, tegami2, "Loc_Prop")
PlayActionDirect(Actor001,"to LookLetter01_loop")
setup_small_camera_start(CUT_08)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop_02")
-- ▲直接出力

	--★★エレイン★★:…たいせつに、包んでおいたんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610032")


	--★★エレイン★★:文通してたんですよ。私
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_610034")

	change_face(Actor001,"Sad")

	--★★ノワール★★:………『ギネヴィア』の字だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610036")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…『ギネヴィア』の声が、聞こえる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610038")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_08_1)
wait_time(0.3)
-- ▲直接出力

	--★★テロップ★★:「ノワールへ」
	Talk(Actor003,"telop","narration","L","MA_01A900_610039")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_610040")


	--★★テロップ★★:「だいじにしてくれて、ありがとう」
	Talk(Actor003,"telop","narration","L","MA_01A900_610042")


	--★★テロップ★★:「元気でいてね<br>健康でいてね」
	Talk(Actor003,"telop","narration","L","MA_01A900_610043")


	--★★テロップ★★:「落ち込むことがあっても<br>大変な時期が来ても」
	Talk(Actor003,"telop","narration","L","MA_01A900_610044")


	--★★テロップ★★:「戦うことに疲れても<br>息切れするときがあっても」
	Talk(Actor003,"telop","narration","L","MA_01A900_610045")


	--★★テロップ★★:「わたしは、ずっとずっとずぅーっと！」
	Talk(Actor003,"telop","narration","L","MA_01A900_610046")


	--★★テロップ★★:「あなたの味方だよ」
	Talk(Actor003,"telop","narration","L","MA_01A900_610047")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
PlayActionDirect(Actor001,"to LookLetter02_loop")
setup_small_camera_start(CUT_09)
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Walk01")
setup_small_camera_start(CUT_10)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
fadeout(255, 255, 255, 0, STILL_SWITCH_TIME )
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
stillAnime.SetActive(true)
hide_image(0)
fadein(0.5)
local signal = play_ui_timeline_controller_in(stillAnime)
while signal.IsProccessing() do
coroutine.yield()
	end
-- ▲直接出力

	--★★エレイン★★:追いかけましょう<br>ずっと、ずっと、ずっと
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A900_610049")


	--★★エレイン★★:どれだけ遠くても、いつまでも
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A900_610050")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
signal = play_ui_timeline_controller_out(stillAnime, true)
while signal.IsProccessing() do
coroutine.yield()
	end
fadeout(255, 255, 255, 1.0, 2.0)
wait_time(3.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_ui_effect_preload("content_still_10103013_anim", "10103013_StillAnim", nil, nil, nil, "Root")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("10103025", "content_still_10103025_image", "101030250_StillImage")
load_image_preload("10103026", "content_still_10103026_image", "101030260_StillImage")
load_image_preload("10103027", "content_still_10103027_image", "101030270_StillImage")
load_image_preload("10103028", "content_still_10103028_image", "101030280_StillImage")
setup_prop_object_preload(10106003)
tegami_offset2 = {0,-0.08,0,358.654,30.0615,275.411}
load_image_preload("101010140_1", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_ADV_Snuggle")
	InitializeLoad_Preload()
	load_area_scene_preload(114091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName114091_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
